using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wowapp.Manager
{
    public class Offsets
    {
        public enum ObjectManager
        {
            clientConnection = 0xE3CB00,
            objectManager = 0x462C,
            firstObject = 0xCC,
            nextObject = 0x34,
            localGUID = 0xE0
        }

        public enum Descriptors
        {
            descriptor = 0x4,
            level = 0xD0,
            displayId = 0x108
        }

        public enum Object
        {
            type = 0xC,
            guid = 0x28,
        }

        public enum Player
        {
            name = 0xE3CB40,
            guid = 0xC8A7B0,
            targetGuid = 0xCDC878,
            mouseOverGUID = 0xD50F38,
            playerClass = 0xE3CCBD,
            zoneText = 0xCDC844, //Orgrimmar
            subZoneText = 0xCDC840 //The valley of honor
        }

        public enum WowUnit
        {
            NamePointer = 0x974,
            NameOffset = 0x6C,
            X = 0x7F8,
            Y = X + 0x4,
            Z = Y + 0x4,
            R = Z + 0x4,
            Charm = 0x20,
            Summon = 0x28,
            Critter = 0x30,
            CharmedBy = 0x38,
            SummonedBy = 0x40,
            CreatedBy = 0x48,
            Target = 0x50,
            BattlePetCompanionGUID = 0x58,
            ChannelObject = 0x60,
            ChannelSpell = 0x68,
            SummonedByHomeRealm = 0x6C,
            DisplayPower = 0x70,
            OverrideDisplayPowerID = 0x74,
            Health = 0x78,
            Power = 0x7C,
            MaxHealth = 0x90,
            MaxPower = 0x94,
            Energy = Power + 0x4,
            MaxEnergy = Energy + 0x4, //Dunno what this is
            PowerRegenFlatModifier = 0xA8,
            PowerRegenInterruptedFlatModifier = 0xBC,
            Level = 0xD0,
            EffectiveLevel = 0xD4,
            FactionTemplate = 0xD8,
            VirtualItemID = 0xDC,
            Flags = 0xE8,
            Flags2 = 0xEC,
            AuraState = 0xF0,
            AttackRoundBaseTime = 0xF4,
            RangedAttackRoundBaseTime = 0xFC,
            BoundingRadius = 0x100,
            CombatReach = 0x104,
            DisplayID = 0x108,
            NativeDisplayID = 0x10C,
            MountDisplayID = 0x110,
            MinDamage = 0x114,
            MaxDamage = 0x118,
            MinOffHandDamage = 0x11C,
            MaxOffHandDamage = 0x120,
            AnimTier = 0x124,
            PetNumber = 0x128,
            PetNameTimestamp = 0x12C,
            PetExperience = 0x130,
            PetNextLevelExperience = 0x134,
            ModCastingSpeed = 0x138,
            ModSpellHaste = 0x13C,
            ModHaste = 0x140,
            ModHasteRegen = 0x144,
            CreatedBySpell = 0x148,
            NpcFlags = 0x14C,
            EmoteState = 0x154,
            Stats = 0x158,
            StatPosBuff = 0x16C,
            StatNegBuff = 0x180,
            Resistances = 0x194,
            ResistanceBuffModsPositive = 0x1B0,
            ResistanceBuffModsNegative = 0x1CC,
            BaseMana = 0x1E8,
            BaseHealth = 0x1EC,
            ShapeshiftForm = 0x1F0,
            AttackPower = 0x1F4,
            AttackPowerModPos = 0x1F8,
            AttackPowerModNeg = 0x1FC,
            AttackPowerMultiplier = 0x200,
            RangedAttackPower = 0x204,
            RangedAttackPowerModPos = 0x208,
            RangedAttackPowerModNeg = 0x20C,
            RangedAttackPowerMultiplier = 0x210,
            MinRangedDamage = 0x214,
            MaxRangedDamage = 0x218,
            PowerCostModifier = 0x21C,
            PowerCostMultiplier = 0x238,
            MaxHealthModifier = 0x254,
            HoverHeight = 0x258,
            MinItemLevel = 0x25C,
            MaxItemLevel = 0x260,
            WildBattlePetLevel = 0x264,
            BattlePetCompanionNameTimestamp = 0x268,
        }
    }

    public enum WowObjectType
    {
        Item = 1,
        Container = 2,
        Unit = 3,
        Player = 4,
        GameObject = 5,
        DynamicObject = 6,
        Corpse = 7,
        AiGroup = 8,
        AreaTrigger = 9
    }

    public enum WowClass
    {
        None = 0,
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11,
    }
}
