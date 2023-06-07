﻿using System.Numerics;
using NexusForever.Database.World.Model;
using NexusForever.Game.Abstract.Entity.Movement;
using NexusForever.Game.Abstract.Social;
using NexusForever.Game.Static.Entity;
using NexusForever.Game.Static.Reputation;
using NexusForever.GameTable.Model;
using NexusForever.Network.Message;
using NexusForever.Network.World.Message.Model;

namespace NexusForever.Game.Abstract.Entity
{
    /// <summary>
    /// An <see cref="IWorldEntity"/> is an extension to <see cref="IGridEntity"/> which is also sent to the client and visible in the game world.
    /// </summary>
    public interface IWorldEntity : IGridEntity
    {
        EntityType Type { get; }
        EntityCreateFlag CreateFlags { get; set; }
        Vector3 Rotation { get; set; }
        Dictionary<Property, IPropertyValue> Properties { get; }

        uint EntityId { get; }
        uint CreatureId { get; set; }
        Creature2Entry CreatureEntry { get; }
        uint DisplayInfo { get; set; }
        Creature2DisplayInfoEntry CreatureDisplayEntry { get; }
        ushort OutfitInfo { get; set; }
        Creature2OutfitInfoEntry CreatureOutfitEntry { get; }
        Faction Faction1 { get; set; }
        Faction Faction2 { get; set; }

        ushort WorldSocketId { get; }
        ulong ActivePropId { get; }

        Vector3 LeashPosition { get; }
        float LeashRange { get; }
        IMovementManager MovementManager { get; }

        uint Health { get; }
        uint Shield { get; }
        uint Level { get; set; }
        bool Sheathed { get; set; }

        /// <summary>
        /// Guid of the <see cref="IWorldEntity"/> currently targeted.
        /// </summary>
        uint TargetGuid { get; set; }

        /// <summary>
        /// Guid of the <see cref="IPlayer"/> currently controlling this <see cref="IWorldEntity"/>.
        /// </summary>
        uint ControllerGuid { get; set; }

        /// <summary>
        /// Initialise <see cref="IWorldEntity"/> from an existing database model.
        /// </summary>
        void Initialise(EntityModel model);

        ServerEntityCreate BuildCreatePacket();

        /// <summary>
        /// Invoked when <see cref="IWorldEntity"/> is activated.
        /// </summary>
        void OnActivate(IPlayer activator);

        /// <summary>
        /// Invoked when <see cref="IWorldEntity"/> is cast activated.
        /// </summary>
        void OnActivateCast(IPlayer activator);

        /// <summary>
        /// Add a <see cref="Property"/> modifier given a Spell4Id and <see cref="IPropertyModifier"/> instance
        /// </summary>
        void AddItemProperty(Property property, ItemSlot itemSlot, float value);

        /// <summary>
        /// Remove a <see cref="Property"/> modifier by a Spell that is currently affecting this <see cref="IWorldEntity"/>
        /// </summary>
        void RemoveItemProperty(Property property, ItemSlot itemSlot);

        /// <summary>
        /// Add a <see cref="Property"/> modifier given a Spell4Id and <see cref="IPropertyModifier"/> instance
        /// </summary>
        void AddSpellModifierProperty(ISpellPropertyModifier modifier, uint spell4Id);

        /// <summary>
        /// Remove a <see cref="Property"/> modifier by a Spell that is currently affecting this <see cref="IWorldEntity"/>
        /// </summary>
        void RemoveSpellProperty(Property property, uint spell4Id);

        /// <summary>
        /// Return a collection of <see cref="IItemVisual"/> for <see cref="IWorldEntity"/>.
        /// </summary>
        IEnumerable<IItemVisual> GetVisuals();

        /// <summary>
        /// Set <see cref="IWorldEntity"/> to broadcast all <see cref="IItemVisual"/> on next world update.
        /// </summary>
        void SetVisualEmit(bool status);

        /// <summary>
        /// Add or update <see cref="IItemVisual"/> at <see cref="ItemSlot"/> with supplied data.
        /// </summary>
        void AddVisual(ItemSlot slot, ushort displayId, ushort colourSetId = 0, int dyeData = 0);

        /// <summary>
        /// Add or update <see cref="IItemVisual"/>.
        /// </summary>
        void AddVisual(IItemVisual visual);

        /// <summary>
        /// Remove <see cref="IItemVisual"/> at supplied <see cref="ItemSlot"/>.
        /// </summary>
        void RemoveVisual(ItemSlot slot);

        /// <summary>
        /// Return the <see cref="uint"/> value of the supplied <see cref="Stat"/> as an <see cref="Enum"/>.
        /// </summary>
        T? GetStatEnum<T>(Stat stat) where T : struct, Enum;

        /// <summary>
        /// Enqueue broadcast of <see cref="IWritable"/> to all visible <see cref="IPlayer"/>'s in range.
        /// </summary>
        void EnqueueToVisible(IWritable message, bool includeSelf = false);

        /// <summary>
        /// Return <see cref="Disposition"/> between <see cref="IWorldEntity"/> and <see cref="Faction"/>.
        /// </summary>
        Disposition GetDispositionTo(Faction factionId, bool primary = true);

        /// <summary>
        /// Broadcast NPC say chat message to to <see cref="IPlayer"/> in supplied range.
        /// </summary>
        void NpcSay(string text, float range = 155f);

        /// <summary>
        /// Broadcast NPC yell chat message to to <see cref="IPlayer"/> in supplied range.
        /// </summary>
        void NpcYell(string text, float range = 155f);

        /// <summary>
        /// Broadcast chat message built from <see cref="IChatMessageBuilder"/> to <see cref="IPlayer"/> in supplied range.
        /// </summary>
        void Talk(IChatMessageBuilder builder, float range, IGridEntity exclude = null);
    }
}