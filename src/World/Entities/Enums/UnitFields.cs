namespace Classic.World.Entities.Enums
{
    public enum UnitFields_Vanilla
    {
        UNIT_FIELD_CHARM = 0x00 + ObjectFields.End, // Size:2
        UNIT_FIELD_SUMMON = 0x02 + ObjectFields.End, // Size:2
        UNIT_FIELD_CHARMEDBY = 0x04 + ObjectFields.End, // Size:2
        UNIT_FIELD_SUMMONEDBY = 0x06 + ObjectFields.End, // Size:2
        UNIT_FIELD_CREATEDBY = 0x08 + ObjectFields.End, // Size:2
        UNIT_FIELD_TARGET = 0x0A + ObjectFields.End, // Size:2
        UNIT_FIELD_PERSUADED = 0x0C + ObjectFields.End, // Size:2
        UNIT_FIELD_CHANNEL_OBJECT = 0x0E + ObjectFields.End, // Size:2
        UNIT_FIELD_HEALTH = 0x10 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER1 = 0x11 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER2 = 0x12 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER3 = 0x13 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER4 = 0x14 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER5 = 0x15 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXHEALTH = 0x16 + ObjectFields.End, // Size:1 
        UNIT_FIELD_MAXPOWER1 = 0x17 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXPOWER2 = 0x18 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXPOWER3 = 0x19 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXPOWER4 = 0x1A + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXPOWER5 = 0x1B + ObjectFields.End, // Size:1
        UNIT_FIELD_LEVEL = 0x1C + ObjectFields.End, // Size:1
        UNIT_FIELD_FACTIONTEMPLATE = 0x1D + ObjectFields.End, // Size:1
        UNIT_FIELD_BYTES_0 = 0x1E + ObjectFields.End, // Size:1
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = 0x1F + ObjectFields.End, // Size:3
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_01 = 0x20 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_02 = 0x21 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_INFO = 0x22 + ObjectFields.End, // Size:6
        UNIT_VIRTUAL_ITEM_INFO_01 = 0x23 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_INFO_02 = 0x24 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_INFO_03 = 0x25 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_INFO_04 = 0x26 + ObjectFields.End,
        UNIT_VIRTUAL_ITEM_INFO_05 = 0x27 + ObjectFields.End,
        UNIT_FIELD_FLAGS = 0x28 + ObjectFields.End, // Size:1
        UNIT_FIELD_AURA = 0x29 + ObjectFields.End, // Size:48
        UNIT_FIELD_AURA_LAST = 0x58 + ObjectFields.End,
        UNIT_FIELD_AURAFLAGS = 0x59 + ObjectFields.End, // Size:6
        UNIT_FIELD_AURAFLAGS_01 = 0x5a + ObjectFields.End,
        UNIT_FIELD_AURAFLAGS_02 = 0x5b + ObjectFields.End,
        UNIT_FIELD_AURAFLAGS_03 = 0x5c + ObjectFields.End,
        UNIT_FIELD_AURAFLAGS_04 = 0x5d + ObjectFields.End,
        UNIT_FIELD_AURAFLAGS_05 = 0x5e + ObjectFields.End,
        UNIT_FIELD_AURALEVELS = 0x5f + ObjectFields.End, // Size:12
        UNIT_FIELD_AURALEVELS_LAST = 0x6a + ObjectFields.End,
        UNIT_FIELD_AURAAPPLICATIONS = 0x6b + ObjectFields.End, // Size:12
        UNIT_FIELD_AURAAPPLICATIONS_LAST = 0x76 + ObjectFields.End,
        UNIT_FIELD_AURASTATE = 0x77 + ObjectFields.End, // Size:1
        UNIT_FIELD_BASEATTACKTIME = 0x78 + ObjectFields.End, // Size:2
        UNIT_FIELD_OFFHANDATTACKTIME = 0x79 + ObjectFields.End, // Size:2
        UNIT_FIELD_RANGEDATTACKTIME = 0x7a + ObjectFields.End, // Size:1
        UNIT_FIELD_BOUNDINGRADIUS = 0x7b + ObjectFields.End, // Size:1
        UNIT_FIELD_COMBATREACH = 0x7c + ObjectFields.End, // Size:1
        UNIT_FIELD_DISPLAYID = 0x7d + ObjectFields.End, // Size:1
        UNIT_FIELD_NATIVEDISPLAYID = 0x7e + ObjectFields.End, // Size:1
        UNIT_FIELD_MOUNTDISPLAYID = 0x7f + ObjectFields.End, // Size:1
        UNIT_FIELD_MINDAMAGE = 0x80 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXDAMAGE = 0x81 + ObjectFields.End, // Size:1
        UNIT_FIELD_MINOFFHANDDAMAGE = 0x82 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXOFFHANDDAMAGE = 0x83 + ObjectFields.End, // Size:1
        UNIT_FIELD_BYTES_1 = 0x84 + ObjectFields.End, // Size:1
        UNIT_FIELD_PETNUMBER = 0x85 + ObjectFields.End, // Size:1
        UNIT_FIELD_PET_NAME_TIMESTAMP = 0x86 + ObjectFields.End, // Size:1
        UNIT_FIELD_PETEXPERIENCE = 0x87 + ObjectFields.End, // Size:1
        UNIT_FIELD_PETNEXTLEVELEXP = 0x88 + ObjectFields.End, // Size:1
        UNIT_DYNAMIC_FLAGS = 0x89 + ObjectFields.End, // Size:1
        UNIT_CHANNEL_SPELL = 0x8a + ObjectFields.End, // Size:1
        UNIT_MOD_CAST_SPEED = 0x8b + ObjectFields.End, // Size:1
        UNIT_CREATED_BY_SPELL = 0x8c + ObjectFields.End, // Size:1
        UNIT_NPC_FLAGS = 0x8d + ObjectFields.End, // Size:1
        UNIT_NPC_EMOTESTATE = 0x8e + ObjectFields.End, // Size:1
        UNIT_TRAINING_POINTS = 0x8f + ObjectFields.End, // Size:1
        UNIT_FIELD_STAT0 = 0x90 + ObjectFields.End, // Size:1
        UNIT_FIELD_STAT1 = 0x91 + ObjectFields.End, // Size:1
        UNIT_FIELD_STAT2 = 0x92 + ObjectFields.End, // Size:1
        UNIT_FIELD_STAT3 = 0x93 + ObjectFields.End, // Size:1
        UNIT_FIELD_STAT4 = 0x94 + ObjectFields.End, // Size:1
        UNIT_FIELD_RESISTANCES = 0x95 + ObjectFields.End, // Size:7
        UNIT_FIELD_RESISTANCES_01 = 0x96 + ObjectFields.End,
        UNIT_FIELD_RESISTANCES_02 = 0x97 + ObjectFields.End,
        UNIT_FIELD_RESISTANCES_03 = 0x98 + ObjectFields.End,
        UNIT_FIELD_RESISTANCES_04 = 0x99 + ObjectFields.End,
        UNIT_FIELD_RESISTANCES_05 = 0x9a + ObjectFields.End,
        UNIT_FIELD_RESISTANCES_06 = 0x9b + ObjectFields.End,
        UNIT_FIELD_BASE_MANA = 0x9c + ObjectFields.End, // Size:1
        UNIT_FIELD_BASE_HEALTH = 0x9d + ObjectFields.End, // Size:1
        UNIT_FIELD_BYTES_2 = 0x9e + ObjectFields.End, // Size:1
        UNIT_FIELD_ATTACK_POWER = 0x9f + ObjectFields.End, // Size:1
        UNIT_FIELD_ATTACK_POWER_MODS = 0xa0 + ObjectFields.End, // Size:1
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER = 0xa1 + ObjectFields.End, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER = 0xa2 + ObjectFields.End, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER_MODS = 0xa3 + ObjectFields.End, // Size:1
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = 0xa4 + ObjectFields.End, // Size:1
        UNIT_FIELD_MINRANGEDDAMAGE = 0xa5 + ObjectFields.End, // Size:1
        UNIT_FIELD_MAXRANGEDDAMAGE = 0xa6 + ObjectFields.End, // Size:1
        UNIT_FIELD_POWER_COST_MODIFIER = 0xa7 + ObjectFields.End, // Size:7
        UNIT_FIELD_POWER_COST_MODIFIER_01 = 0xa8 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MODIFIER_02 = 0xa9 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MODIFIER_03 = 0xaa + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MODIFIER_04 = 0xab + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MODIFIER_05 = 0xac + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MODIFIER_06 = 0xad + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER = 0xae + ObjectFields.End, // Size:7
        UNIT_FIELD_POWER_COST_MULTIPLIER_01 = 0xaf + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER_02 = 0xb0 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER_03 = 0xb1 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER_04 = 0xb2 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER_05 = 0xb3 + ObjectFields.End,
        UNIT_FIELD_POWER_COST_MULTIPLIER_06 = 0xb4 + ObjectFields.End,
        UNIT_FIELD_PADDING = 0xb5 + ObjectFields.End,
        UNIT_END = 0xb6 + ObjectFields.End
    }

    public enum UnitFields_TBC
    {
        UNIT_FIELD_CHARM = ObjectFields.End + 0x0000, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_SUMMON = ObjectFields.End + 0x0002, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CHARMEDBY = ObjectFields.End + 0x0004, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_SUMMONEDBY = ObjectFields.End + 0x0006, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CREATEDBY = ObjectFields.End + 0x0008, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_TARGET = ObjectFields.End + 0x000A, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_PERSUADED = ObjectFields.End + 0x000C, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_CHANNEL_OBJECT = ObjectFields.End + 0x000E, // Size: 2, Type: LONG, Flags: PUBLIC
        UNIT_FIELD_HEALTH = ObjectFields.End + 0x0010, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_FIELD_POWER1 = ObjectFields.End + 0x0011, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER2 = ObjectFields.End + 0x0012, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER3 = ObjectFields.End + 0x0013, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER4 = ObjectFields.End + 0x0014, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_POWER5 = ObjectFields.End + 0x0015, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXHEALTH = ObjectFields.End + 0x0016, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_FIELD_MAXPOWER1 = ObjectFields.End + 0x0017, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER2 = ObjectFields.End + 0x0018, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER3 = ObjectFields.End + 0x0019, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER4 = ObjectFields.End + 0x001A, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER5 = ObjectFields.End + 0x001B, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_LEVEL = ObjectFields.End + 0x001C, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_FACTIONTEMPLATE = ObjectFields.End + 0x001D, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BYTES_0 = ObjectFields.End + 0x001E, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = ObjectFields.End + 0x001F, // Size: 3, Type: INT, Flags: PUBLIC
        UNIT_VIRTUAL_ITEM_INFO = ObjectFields.End + 0x0022, // Size: 6, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_FLAGS = ObjectFields.End + 0x0028, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_FLAGS_2 = ObjectFields.End + 0x0029, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_AURA = ObjectFields.End + 0x002A, // Size: 56, Type: INT, Flags: PUBLIC
        UNIT_FIELD_AURAFLAGS = ObjectFields.End + 0x0062, // Size: 14, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_AURALEVELS = ObjectFields.End + 0x0070, // Size: 14, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_AURAAPPLICATIONS = ObjectFields.End + 0x007E, // Size: 14, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_AURASTATE = ObjectFields.End + 0x008C, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BASEATTACKTIME = ObjectFields.End + 0x008D, // Size: 2, Type: INT, Flags: PUBLIC
        UNIT_FIELD_RANGEDATTACKTIME = ObjectFields.End + 0x008F, // Size: 1, Type: INT, Flags: PRIVATE
        UNIT_FIELD_BOUNDINGRADIUS = ObjectFields.End + 0x0090, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_COMBATREACH = ObjectFields.End + 0x0091, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_FIELD_DISPLAYID = ObjectFields.End + 0x0092, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_NATIVEDISPLAYID = ObjectFields.End + 0x0093, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MOUNTDISPLAYID = ObjectFields.End + 0x0094, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_MINDAMAGE = ObjectFields.End + 0x0095, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY, UNK3
        UNIT_FIELD_MAXDAMAGE = ObjectFields.End + 0x0096, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY, UNK3
        UNIT_FIELD_MINOFFHANDDAMAGE = ObjectFields.End + 0x0097, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY, UNK3
        UNIT_FIELD_MAXOFFHANDDAMAGE = ObjectFields.End + 0x0098, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY, UNK3
        UNIT_FIELD_BYTES_1 = ObjectFields.End + 0x0099, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_PETNUMBER = ObjectFields.End + 0x009A, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_PET_NAME_TIMESTAMP = ObjectFields.End + 0x009B, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_PETEXPERIENCE = ObjectFields.End + 0x009C, // Size: 1, Type: INT, Flags: OWNER_ONLY
        UNIT_FIELD_PETNEXTLEVELEXP = ObjectFields.End + 0x009D, // Size: 1, Type: INT, Flags: OWNER_ONLY
        UNIT_DYNAMIC_FLAGS = ObjectFields.End + 0x009E, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_CHANNEL_SPELL = ObjectFields.End + 0x009F, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_MOD_CAST_SPEED = ObjectFields.End + 0x00A0, // Size: 1, Type: FLOAT, Flags: PUBLIC
        UNIT_CREATED_BY_SPELL = ObjectFields.End + 0x00A1, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_NPC_FLAGS = ObjectFields.End + 0x00A2, // Size: 1, Type: INT, Flags: DYNAMIC
        UNIT_NPC_EMOTESTATE = ObjectFields.End + 0x00A3, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_TRAINING_POINTS = ObjectFields.End + 0x00A4, // Size: 1, Type: TWO_SHORT, Flags: OWNER_ONLY
        UNIT_FIELD_STAT0 = ObjectFields.End + 0x00A5, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_STAT1 = ObjectFields.End + 0x00A6, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_STAT2 = ObjectFields.End + 0x00A7, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_STAT3 = ObjectFields.End + 0x00A8, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_STAT4 = ObjectFields.End + 0x00A9, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POSSTAT0 = ObjectFields.End + 0x00AA, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POSSTAT1 = ObjectFields.End + 0x00AB, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POSSTAT2 = ObjectFields.End + 0x00AC, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POSSTAT3 = ObjectFields.End + 0x00AD, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POSSTAT4 = ObjectFields.End + 0x00AE, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_NEGSTAT0 = ObjectFields.End + 0x00AF, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_NEGSTAT1 = ObjectFields.End + 0x00B0, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_NEGSTAT2 = ObjectFields.End + 0x00B1, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_NEGSTAT3 = ObjectFields.End + 0x00B2, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_NEGSTAT4 = ObjectFields.End + 0x00B3, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_RESISTANCES = ObjectFields.End + 0x00B4, // Size: 7, Type: INT, Flags: PRIVATE, OWNER_ONLY, UNK3
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = ObjectFields.End + 0x00BB, // Size: 7, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = ObjectFields.End + 0x00C2, // Size: 7, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_BASE_MANA = ObjectFields.End + 0x00C9, // Size: 1, Type: INT, Flags: PUBLIC
        UNIT_FIELD_BASE_HEALTH = ObjectFields.End + 0x00CA, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_BYTES_2 = ObjectFields.End + 0x00CB, // Size: 1, Type: BYTES, Flags: PUBLIC
        UNIT_FIELD_ATTACK_POWER = ObjectFields.End + 0x00CC, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_ATTACK_POWER_MODS = ObjectFields.End + 0x00CD, // Size: 1, Type: TWO_SHORT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER = ObjectFields.End + 0x00CE, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_RANGED_ATTACK_POWER = ObjectFields.End + 0x00CF, // Size: 1, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_RANGED_ATTACK_POWER_MODS = ObjectFields.End + 0x00D0, // Size: 1, Type: TWO_SHORT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = ObjectFields.End + 0x00D1, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_MINRANGEDDAMAGE = ObjectFields.End + 0x00D2, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_MAXRANGEDDAMAGE = ObjectFields.End + 0x00D3, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POWER_COST_MODIFIER = ObjectFields.End + 0x00D4, // Size: 7, Type: INT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_POWER_COST_MULTIPLIER = ObjectFields.End + 0x00DB, // Size: 7, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_MAXHEALTHMODIFIER = ObjectFields.End + 0x00E2, // Size: 1, Type: FLOAT, Flags: PRIVATE, OWNER_ONLY
        UNIT_FIELD_PADDING = ObjectFields.End + 0x00E3, // Size: 1, Type: INT, Flags: NONE
        UNIT_END = ObjectFields.End + 0x00E4,
    }
}