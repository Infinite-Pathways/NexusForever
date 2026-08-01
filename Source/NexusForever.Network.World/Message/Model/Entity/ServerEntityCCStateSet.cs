using NexusForever.Game.Static.Combat.CrowdControl;
using NexusForever.Network.Message;

namespace NexusForever.Network.World.Message.Model.Entity
{
    // Must be sent same time or after SpellEffects are applied to the unit.
    // The SpellEffectUniqueId must match the id from the SpellCast result in ServerSpellGo/ServerSpellExecute
    // This triggers the restrictions and VisualEffects for the CC state.
    [Message(GameMessageOpcode.ServerEntityCCStateSet)]
    public class ServerEntityCCStateSet : IWritable
    {
        public uint Guid { get; set; }
        public CCState CCState { get; set; }
        public uint EffectUniqueId { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(Guid);
            writer.Write(CCState, 5);
            writer.Write(EffectUniqueId);
        }
    }
}
