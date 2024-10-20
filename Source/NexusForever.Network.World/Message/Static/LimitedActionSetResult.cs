﻿namespace NexusForever.Network.World.Message.Static
{
    public enum LimitedActionSetResult
    {
        Ok                                          = 0x0001,
        SlotUnlockPrereqFalse                       = 0x0002,
        UnknownSpellId                              = 0x0003,
        UnknownClassId                              = 0x0004,
        UnknownSpellActionSetCategoryGroupPlacement = 0x0005,
        UnknownSlotActionSetCategoryGroupAllowed    = 0x0006,
        InvalidSpellActionSetCategoryGroupPlacement = 0x0007,
        InvalidSlotActionSetCategoryGroupAllowed    = 0x0008,
        SlotSpellAnyMatchFail                       = 0x0009,
        SlotSpellAllMatchFail                       = 0x000A,
        SlotSpellNoneMatchFail                      = 0x000B,
        UnknownSpellActionSetGroupMatchType         = 0x000C,
        DuplicateSpell                              = 0x000D,
        SpellActionSetPrereqFalse                   = 0x000E,
        SpellDependencyAnyMatchFail                 = 0x000F,
        SpellDependencyAllMatchFail                 = 0x0010,
        SpellDependencyNoneMatchFail                = 0x0011,
        BadSpellInActionSet                         = 0x0012,
        ActionSetRequirementAnyMatchFail            = 0x0013,
        ActionSetRequirementAllMatchFail            = 0x0014,
        ActionSetRequirementNoneMatchFail           = 0x0015,
        InvalidActionSetSize                        = 0x0016,
        InvalidUnit                                 = 0x0017,
        InvalidSlot                                 = 0x0018,
        InvalidActionSetTable                       = 0x0019,
        SpellDependencyMaxMatchFail                 = 0x001A,
        PlayerIsDead                                = 0x001B,
        RestrictedInPVP                             = 0x001C,
        MissingTag                                  = 0x001D,
        InCombat                                    = 0x001E,
        EldanAugmentationNotEnoughPower             = 0x001F,
        EldanAugmentationLockedInlaid               = 0x0020,
        EldanAugmentationLockedCategoryTier         = 0x0021,
        EldanAugmentationInvalidSeries              = 0x0022,
        EldanAugmentationInvalidId                  = 0x0023,
        EldanAugmentationInvalidCategoryId          = 0x0024,
        EldanAugmentationInvalidCategoryTier        = 0x0025,
        UpdateSpellInProgress                       = 0x0026,
        InVoid                                      = 0x0027,
        InvalidSpecIndex                            = 0x0028,
        InvalidSpellTier                            = 0x0029,
        InsufficientAbilityPoints                   = 0x002A,
        EldanAugmentationVersionMismatch            = 0x002B,
        EldanAugmentationSpecNotFound               = 0x002C,
        LASChangeSpellFailed                        = 0x002D,
        SpecUnlockPrereqFalse                       = 0x002E
    }
}
