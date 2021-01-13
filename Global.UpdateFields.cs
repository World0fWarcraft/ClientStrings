// Auto generated file
// Patch: 1.4.1
// Build: 4364

Public Enum EObjectFields
{
    OBJECT_FIELD_GUID = 0x0,                                                      // 0x000 - Size: 2 - Type: GUID - Flags: PUBLIC
    OBJECT_FIELD_TYPE = 0x2,                                                      // 0x002 - Size: 1 - Type: INT - Flags: PUBLIC
    OBJECT_FIELD_ENTRY = 0x3,                                                     // 0x003 - Size: 1 - Type: INT - Flags: PUBLIC
    OBJECT_FIELD_SCALE_X = 0x4,                                                   // 0x004 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    OBJECT_FIELD_PADDING = 0x5,                                                   // 0x005 - Size: 1 - Type: INT - Flags: NONE
    OBJECT_END = 0x6                                                              
}
Public Enum EItemFields
{
    ITEM_FIELD_OWNER = EObjectFields.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_CONTAINED = EObjectFields.OBJECT_END + 0x2,                        // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_CREATOR = EObjectFields.OBJECT_END + 0x4,                          // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_GIFTCREATOR = EObjectFields.OBJECT_END + 0x6,                      // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_STACK_COUNT = EObjectFields.OBJECT_END + 0x8,                      // 0x00E - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_DURATION = EObjectFields.OBJECT_END + 0x9,                         // 0x00F - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_SPELL_CHARGES = EObjectFields.OBJECT_END + 0xA,                    // 0x010 - Size: 5 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_FLAGS = EObjectFields.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    ITEM_FIELD_ENCHANTMENT = EObjectFields.OBJECT_END + 0x10,                     // 0x016 - Size: 21 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_PROPERTY_SEED = EObjectFields.OBJECT_END + 0x25,                   // 0x02B - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_RANDOM_PROPERTIES_ID = EObjectFields.OBJECT_END + 0x26,            // 0x02C - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_ITEM_TEXT_ID = EObjectFields.OBJECT_END + 0x27,                    // 0x02D - Size: 1 - Type: INT - Flags: OWNER_ONLY
    ITEM_FIELD_DURABILITY = EObjectFields.OBJECT_END + 0x28,                      // 0x02E - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_MAXDURABILITY = EObjectFields.OBJECT_END + 0x29,                   // 0x02F - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_END = EObjectFields.OBJECT_END + 0x2A                                    // 0x030
}
Public Enum EContainerFields
{
    CONTAINER_FIELD_NUM_SLOTS = EItemFields.ITEM_END + 0x0,                       // 0x02A - Size: 1 - Type: INT - Flags: PUBLIC
    CONTAINER_ALIGN_PAD = EItemFields.ITEM_END + 0x1,                             // 0x02B - Size: 1 - Type: BYTES - Flags: NONE
    CONTAINER_FIELD_SLOT_1 = EItemFields.ITEM_END + 0x2,                          // 0x02C - Size: 40 - Type: GUID - Flags: PUBLIC
    CONTAINER_END = EItemFields.ITEM_END + 0x2A                                   // 0x054
}
Public Enum EUnitFields
{
    UNIT_FIELD_CHARM = EObjectFields.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMON = EObjectFields.OBJECT_END + 0x2,                           // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CHARMEDBY = EObjectFields.OBJECT_END + 0x4,                        // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMONEDBY = EObjectFields.OBJECT_END + 0x6,                       // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CREATEDBY = EObjectFields.OBJECT_END + 0x8,                        // 0x00E - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_TARGET = EObjectFields.OBJECT_END + 0xA,                           // 0x010 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_PERSUADED = EObjectFields.OBJECT_END + 0xC,                        // 0x012 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CHANNEL_OBJECT = EObjectFields.OBJECT_END + 0xE,                   // 0x014 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_HEALTH = EObjectFields.OBJECT_END + 0x10,                          // 0x016 - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_POWER1 = EObjectFields.OBJECT_END + 0x11,                          // 0x017 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER2 = EObjectFields.OBJECT_END + 0x12,                          // 0x018 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER3 = EObjectFields.OBJECT_END + 0x13,                          // 0x019 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER4 = EObjectFields.OBJECT_END + 0x14,                          // 0x01A - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER5 = EObjectFields.OBJECT_END + 0x15,                          // 0x01B - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXHEALTH = EObjectFields.OBJECT_END + 0x16,                       // 0x01C - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_MAXPOWER1 = EObjectFields.OBJECT_END + 0x17,                       // 0x01D - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER2 = EObjectFields.OBJECT_END + 0x18,                       // 0x01E - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER3 = EObjectFields.OBJECT_END + 0x19,                       // 0x01F - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER4 = EObjectFields.OBJECT_END + 0x1A,                       // 0x020 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER5 = EObjectFields.OBJECT_END + 0x1B,                       // 0x021 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_LEVEL = EObjectFields.OBJECT_END + 0x1C,                           // 0x022 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_FACTIONTEMPLATE = EObjectFields.OBJECT_END + 0x1D,                 // 0x023 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BYTES_0 = EObjectFields.OBJECT_END + 0x1E,                         // 0x024 - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = EObjectFields.OBJECT_END + 0x1F,             // 0x025 - Size: 3 - Type: INT - Flags: PUBLIC
    UNIT_VIRTUAL_ITEM_INFO = EObjectFields.OBJECT_END + 0x22,                     // 0x028 - Size: 6 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_FLAGS = EObjectFields.OBJECT_END + 0x28,                           // 0x02E - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_AURA = EObjectFields.OBJECT_END + 0x29,                            // 0x02F - Size: 56 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_AURALEVELS = EObjectFields.OBJECT_END + 0x61,                      // 0x067 - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAAPPLICATIONS = EObjectFields.OBJECT_END + 0x6B,                // 0x071 - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAFLAGS = EObjectFields.OBJECT_END + 0x75,                       // 0x07B - Size: 7 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURASTATE = EObjectFields.OBJECT_END + 0x7C,                       // 0x082 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BASEATTACKTIME = EObjectFields.OBJECT_END + 0x7D,                  // 0x083 - Size: 2 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_RANGEDATTACKTIME = EObjectFields.OBJECT_END + 0x7F,                // 0x085 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BOUNDINGRADIUS = EObjectFields.OBJECT_END + 0x80,                  // 0x086 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_COMBATREACH = EObjectFields.OBJECT_END + 0x81,                     // 0x087 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_DISPLAYID = EObjectFields.OBJECT_END + 0x82,                       // 0x088 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_NATIVEDISPLAYID = EObjectFields.OBJECT_END + 0x83,                 // 0x089 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MOUNTDISPLAYID = EObjectFields.OBJECT_END + 0x84,                  // 0x08A - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MINDAMAGE = EObjectFields.OBJECT_END + 0x85,                       // 0x08B - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_MAXDAMAGE = EObjectFields.OBJECT_END + 0x86,                       // 0x08C - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_MINOFFHANDDAMAGE = EObjectFields.OBJECT_END + 0x87,                // 0x08D - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_MAXOFFHANDDAMAGE = EObjectFields.OBJECT_END + 0x88,                // 0x08E - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_BYTES_1 = EObjectFields.OBJECT_END + 0x89,                         // 0x08F - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_PETNUMBER = EObjectFields.OBJECT_END + 0x8A,                       // 0x090 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PET_NAME_TIMESTAMP = EObjectFields.OBJECT_END + 0x8B,              // 0x091 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PETEXPERIENCE = EObjectFields.OBJECT_END + 0x8C,                   // 0x092 - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_FIELD_PETNEXTLEVELEXP = EObjectFields.OBJECT_END + 0x8D,                 // 0x093 - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_DYNAMIC_FLAGS = EObjectFields.OBJECT_END + 0x8E,                         // 0x094 - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_CHANNEL_SPELL = EObjectFields.OBJECT_END + 0x8F,                         // 0x095 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_MOD_CAST_SPEED = EObjectFields.OBJECT_END + 0x90,                        // 0x096 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_CREATED_BY_SPELL = EObjectFields.OBJECT_END + 0x91,                      // 0x097 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_NPC_FLAGS = EObjectFields.OBJECT_END + 0x92,                             // 0x098 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_NPC_EMOTESTATE = EObjectFields.OBJECT_END + 0x93,                        // 0x099 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_TRAINING_POINTS = EObjectFields.OBJECT_END + 0x94,                       // 0x09A - Size: 1 - Type: TWO_SHORT - Flags: OWNER_ONLY
    UNIT_FIELD_STAT0 = EObjectFields.OBJECT_END + 0x95,                           // 0x09B - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT1 = EObjectFields.OBJECT_END + 0x96,                           // 0x09C - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT2 = EObjectFields.OBJECT_END + 0x97,                           // 0x09D - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT3 = EObjectFields.OBJECT_END + 0x98,                           // 0x09E - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT4 = EObjectFields.OBJECT_END + 0x99,                           // 0x09F - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_RESISTANCES = EObjectFields.OBJECT_END + 0x9A,                     // 0x0A0 - Size: 7 - Type: INT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_ATTACKPOWER = EObjectFields.OBJECT_END + 0xA1,                     // 0x0A7 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_BASE_MANA = EObjectFields.OBJECT_END + 0xA2,                       // 0x0A8 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_ATTACK_POWER_MODS = EObjectFields.OBJECT_END + 0xA3,               // 0x0A9 - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_BYTES_2 = EObjectFields.OBJECT_END + 0xA4,                         // 0x0AA - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_RANGEDATTACKPOWER = EObjectFields.OBJECT_END + 0xA5,               // 0x0AB - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_RANGED_ATTACK_POWER_MODS = EObjectFields.OBJECT_END + 0xA6,        // 0x0AC - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_MINRANGEDDAMAGE = EObjectFields.OBJECT_END + 0xA7,                 // 0x0AD - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_MAXRANGEDDAMAGE = EObjectFields.OBJECT_END + 0xA8,                 // 0x0AE - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_PADDING = EObjectFields.OBJECT_END + 0xA9,                         // 0x0AF - Size: 1 - Type: INT - Flags: NONE
    UNIT_END = EObjectFields.OBJECT_END + 0xAA                                    // 0x0B0
}
Public Enum EPlayerFields
{
    PLAYER_SELECTION = EUnitFields.UNIT_END + 0x0,                                // 0x0AA - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_DUEL_ARBITER = EUnitFields.UNIT_END + 0x2,                             // 0x0AC - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_FLAGS = EUnitFields.UNIT_END + 0x4,                                    // 0x0AE - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILDID = EUnitFields.UNIT_END + 0x5,                                  // 0x0AF - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILDRANK = EUnitFields.UNIT_END + 0x6,                                // 0x0B0 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_BYTES = EUnitFields.UNIT_END + 0x7,                                    // 0x0B1 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_2 = EUnitFields.UNIT_END + 0x8,                                  // 0x0B2 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_3 = EUnitFields.UNIT_END + 0x9,                                  // 0x0B3 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_DUEL_TEAM = EUnitFields.UNIT_END + 0xA,                                // 0x0B4 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILD_TIMESTAMP = EUnitFields.UNIT_END + 0xB,                          // 0x0B5 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_QUEST_LOG_1_1 = EUnitFields.UNIT_END + 0xC,                            // 0x0B6 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_1_2 = EUnitFields.UNIT_END + 0xD,                            // 0x0B7 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_2_1 = EUnitFields.UNIT_END + 0xF,                            // 0x0B9 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_2_2 = EUnitFields.UNIT_END + 0x10,                           // 0x0BA - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_3_1 = EUnitFields.UNIT_END + 0x12,                           // 0x0BC - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_3_2 = EUnitFields.UNIT_END + 0x13,                           // 0x0BD - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_4_1 = EUnitFields.UNIT_END + 0x15,                           // 0x0BF - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_4_2 = EUnitFields.UNIT_END + 0x16,                           // 0x0C0 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_5_1 = EUnitFields.UNIT_END + 0x18,                           // 0x0C2 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_5_2 = EUnitFields.UNIT_END + 0x19,                           // 0x0C3 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_6_1 = EUnitFields.UNIT_END + 0x1B,                           // 0x0C5 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_6_2 = EUnitFields.UNIT_END + 0x1C,                           // 0x0C6 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_7_1 = EUnitFields.UNIT_END + 0x1E,                           // 0x0C8 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_7_2 = EUnitFields.UNIT_END + 0x1F,                           // 0x0C9 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_8_1 = EUnitFields.UNIT_END + 0x21,                           // 0x0CB - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_8_2 = EUnitFields.UNIT_END + 0x22,                           // 0x0CC - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_9_1 = EUnitFields.UNIT_END + 0x24,                           // 0x0CE - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_9_2 = EUnitFields.UNIT_END + 0x25,                           // 0x0CF - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_10_1 = EUnitFields.UNIT_END + 0x27,                          // 0x0D1 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_10_2 = EUnitFields.UNIT_END + 0x28,                          // 0x0D2 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_11_1 = EUnitFields.UNIT_END + 0x2A,                          // 0x0D4 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_11_2 = EUnitFields.UNIT_END + 0x2B,                          // 0x0D5 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_12_1 = EUnitFields.UNIT_END + 0x2D,                          // 0x0D7 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_12_2 = EUnitFields.UNIT_END + 0x2E,                          // 0x0D8 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_13_1 = EUnitFields.UNIT_END + 0x30,                          // 0x0DA - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_13_2 = EUnitFields.UNIT_END + 0x31,                          // 0x0DB - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_14_1 = EUnitFields.UNIT_END + 0x33,                          // 0x0DD - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_14_2 = EUnitFields.UNIT_END + 0x34,                          // 0x0DE - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_15_1 = EUnitFields.UNIT_END + 0x36,                          // 0x0E0 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_15_2 = EUnitFields.UNIT_END + 0x37,                          // 0x0E1 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_16_1 = EUnitFields.UNIT_END + 0x39,                          // 0x0E3 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_16_2 = EUnitFields.UNIT_END + 0x3A,                          // 0x0E4 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_17_1 = EUnitFields.UNIT_END + 0x3C,                          // 0x0E6 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_17_2 = EUnitFields.UNIT_END + 0x3D,                          // 0x0E7 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_18_1 = EUnitFields.UNIT_END + 0x3F,                          // 0x0E9 - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_18_2 = EUnitFields.UNIT_END + 0x40,                          // 0x0EA - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_19_1 = EUnitFields.UNIT_END + 0x42,                          // 0x0EC - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_19_2 = EUnitFields.UNIT_END + 0x43,                          // 0x0ED - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_QUEST_LOG_20_1 = EUnitFields.UNIT_END + 0x45,                          // 0x0EF - Size: 1 - Type: INT - Flags: GROUP_ONLY
    PLAYER_QUEST_LOG_20_2 = EUnitFields.UNIT_END + 0x46,                          // 0x0F0 - Size: 2 - Type: INT - Flags: PRIVATE
    PLAYER_VISIBLE_ITEM_1_0 = EUnitFields.UNIT_END + 0x48,                        // 0x0F2 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_1_PROPERTIES = EUnitFields.UNIT_END + 0x50,               // 0x0FA - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_1_CREATOR = EUnitFields.UNIT_END + 0x51,                  // 0x0FB - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_2_0 = EUnitFields.UNIT_END + 0x53,                        // 0x0FD - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_2_PROPERTIES = EUnitFields.UNIT_END + 0x5B,               // 0x105 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_2_CREATOR = EUnitFields.UNIT_END + 0x5C,                  // 0x106 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_3_0 = EUnitFields.UNIT_END + 0x5E,                        // 0x108 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_3_PROPERTIES = EUnitFields.UNIT_END + 0x66,               // 0x110 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_3_CREATOR = EUnitFields.UNIT_END + 0x67,                  // 0x111 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_4_0 = EUnitFields.UNIT_END + 0x69,                        // 0x113 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_4_PROPERTIES = EUnitFields.UNIT_END + 0x71,               // 0x11B - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_4_CREATOR = EUnitFields.UNIT_END + 0x72,                  // 0x11C - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_5_0 = EUnitFields.UNIT_END + 0x74,                        // 0x11E - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_5_PROPERTIES = EUnitFields.UNIT_END + 0x7C,               // 0x126 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_5_CREATOR = EUnitFields.UNIT_END + 0x7D,                  // 0x127 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_6_0 = EUnitFields.UNIT_END + 0x7F,                        // 0x129 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_6_PROPERTIES = EUnitFields.UNIT_END + 0x87,               // 0x131 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_6_CREATOR = EUnitFields.UNIT_END + 0x88,                  // 0x132 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_7_0 = EUnitFields.UNIT_END + 0x8A,                        // 0x134 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_7_PROPERTIES = EUnitFields.UNIT_END + 0x92,               // 0x13C - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_7_CREATOR = EUnitFields.UNIT_END + 0x93,                  // 0x13D - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_8_0 = EUnitFields.UNIT_END + 0x95,                        // 0x13F - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_8_PROPERTIES = EUnitFields.UNIT_END + 0x9D,               // 0x147 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_8_CREATOR = EUnitFields.UNIT_END + 0x9E,                  // 0x148 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_9_0 = EUnitFields.UNIT_END + 0xA0,                        // 0x14A - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_9_PROPERTIES = EUnitFields.UNIT_END + 0xA8,               // 0x152 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_9_CREATOR = EUnitFields.UNIT_END + 0xA9,                  // 0x153 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_10_0 = EUnitFields.UNIT_END + 0xAB,                       // 0x155 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_10_PROPERTIES = EUnitFields.UNIT_END + 0xB3,              // 0x15D - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_10_CREATOR = EUnitFields.UNIT_END + 0xB4,                 // 0x15E - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_11_0 = EUnitFields.UNIT_END + 0xB6,                       // 0x160 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_11_PROPERTIES = EUnitFields.UNIT_END + 0xBE,              // 0x168 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_11_CREATOR = EUnitFields.UNIT_END + 0xBF,                 // 0x169 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_12_0 = EUnitFields.UNIT_END + 0xC1,                       // 0x16B - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_12_PROPERTIES = EUnitFields.UNIT_END + 0xC9,              // 0x173 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_12_CREATOR = EUnitFields.UNIT_END + 0xCA,                 // 0x174 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_13_0 = EUnitFields.UNIT_END + 0xCC,                       // 0x176 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_13_PROPERTIES = EUnitFields.UNIT_END + 0xD4,              // 0x17E - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_13_CREATOR = EUnitFields.UNIT_END + 0xD5,                 // 0x17F - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_14_0 = EUnitFields.UNIT_END + 0xD7,                       // 0x181 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_14_PROPERTIES = EUnitFields.UNIT_END + 0xDF,              // 0x189 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_14_CREATOR = EUnitFields.UNIT_END + 0xE0,                 // 0x18A - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_15_0 = EUnitFields.UNIT_END + 0xE2,                       // 0x18C - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_15_PROPERTIES = EUnitFields.UNIT_END + 0xEA,              // 0x194 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_15_CREATOR = EUnitFields.UNIT_END + 0xEB,                 // 0x195 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_16_0 = EUnitFields.UNIT_END + 0xED,                       // 0x197 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_16_PROPERTIES = EUnitFields.UNIT_END + 0xF5,              // 0x19F - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_16_CREATOR = EUnitFields.UNIT_END + 0xF6,                 // 0x1A0 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_17_0 = EUnitFields.UNIT_END + 0xF8,                       // 0x1A2 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_17_PROPERTIES = EUnitFields.UNIT_END + 0x100,             // 0x1AA - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_17_CREATOR = EUnitFields.UNIT_END + 0x101,                // 0x1AB - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_18_0 = EUnitFields.UNIT_END + 0x103,                      // 0x1AD - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_18_PROPERTIES = EUnitFields.UNIT_END + 0x10B,             // 0x1B5 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_18_CREATOR = EUnitFields.UNIT_END + 0x10C,                // 0x1B6 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_19_0 = EUnitFields.UNIT_END + 0x10E,                      // 0x1B8 - Size: 8 - Type: INT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_19_PROPERTIES = EUnitFields.UNIT_END + 0x116,             // 0x1C0 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    PLAYER_VISIBLE_ITEM_19_CREATOR = EUnitFields.UNIT_END + 0x117,                // 0x1C1 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_FIELD_PAD_0 = EUnitFields.UNIT_END + 0x119,                            // 0x1C3 - Size: 1 - Type: INT - Flags: NONE
    PLAYER_FIELD_INV_SLOT_HEAD = EUnitFields.UNIT_END + 0x11A,                    // 0x1C4 - Size: 46 - Type: GUID - Flags: PUBLIC
    PLAYER_FIELD_PACK_SLOT_1 = EUnitFields.UNIT_END + 0x148,                      // 0x1F2 - Size: 32 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANK_SLOT_1 = EUnitFields.UNIT_END + 0x168,                      // 0x212 - Size: 48 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANKBAG_SLOT_1 = EUnitFields.UNIT_END + 0x198,                   // 0x242 - Size: 12 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_VENDORBUYBACK_SLOT = EUnitFields.UNIT_END + 0x1A4,               // 0x24E - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_FARSIGHT = EUnitFields.UNIT_END + 0x1A6,                               // 0x250 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER__FIELD_COMBO_TARGET = EUnitFields.UNIT_END + 0x1A8,                    // 0x252 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_NPC = EUnitFields.UNIT_END + 0x1AA,                      // 0x254 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_XP = EUnitFields.UNIT_END + 0x1AC,                                     // 0x256 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_NEXT_LEVEL_XP = EUnitFields.UNIT_END + 0x1AD,                          // 0x257 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_SKILL_INFO_1_1 = EUnitFields.UNIT_END + 0x1AE,                         // 0x258 - Size: 384 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS1 = EUnitFields.UNIT_END + 0x32E,                      // 0x3D8 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS2 = EUnitFields.UNIT_END + 0x32F,                      // 0x3D9 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_CREATURES = EUnitFields.UNIT_END + 0x330,                        // 0x3DA - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_RESOURCES = EUnitFields.UNIT_END + 0x331,                        // 0x3DB - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_BLOCK_PERCENTAGE = EUnitFields.UNIT_END + 0x332,                       // 0x3DC - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_DODGE_PERCENTAGE = EUnitFields.UNIT_END + 0x333,                       // 0x3DD - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_PARRY_PERCENTAGE = EUnitFields.UNIT_END + 0x334,                       // 0x3DE - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_CRIT_PERCENTAGE = EUnitFields.UNIT_END + 0x335,                        // 0x3DF - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_RANGED_CRIT_PERCENTAGE = EUnitFields.UNIT_END + 0x336,                 // 0x3E0 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_EXPLORED_ZONES_1 = EUnitFields.UNIT_END + 0x337,                       // 0x3E1 - Size: 64 - Type: BYTES - Flags: PRIVATE
    PLAYER_REST_STATE_EXPERIENCE = EUnitFields.UNIT_END + 0x377,                  // 0x421 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_COINAGE = EUnitFields.UNIT_END + 0x378,                          // 0x422 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT0 = EUnitFields.UNIT_END + 0x379,                         // 0x423 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT1 = EUnitFields.UNIT_END + 0x37A,                         // 0x424 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT2 = EUnitFields.UNIT_END + 0x37B,                         // 0x425 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT3 = EUnitFields.UNIT_END + 0x37C,                         // 0x426 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT4 = EUnitFields.UNIT_END + 0x37D,                         // 0x427 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT0 = EUnitFields.UNIT_END + 0x37E,                         // 0x428 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT1 = EUnitFields.UNIT_END + 0x37F,                         // 0x429 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT2 = EUnitFields.UNIT_END + 0x380,                         // 0x42A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT3 = EUnitFields.UNIT_END + 0x381,                         // 0x42B - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT4 = EUnitFields.UNIT_END + 0x382,                         // 0x42C - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE = EUnitFields.UNIT_END + 0x383,       // 0x42D - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE = EUnitFields.UNIT_END + 0x38A,       // 0x434 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_POS = EUnitFields.UNIT_END + 0x391,              // 0x43B - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = EUnitFields.UNIT_END + 0x398,              // 0x442 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = EUnitFields.UNIT_END + 0x39F,              // 0x449 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BYTES = EUnitFields.UNIT_END + 0x3A6,                            // 0x450 - Size: 1 - Type: BYTES - Flags: PRIVATE
    PLAYER_AMMO_ID = EUnitFields.UNIT_END + 0x3A7,                                // 0x451 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_PVP_MEDALS = EUnitFields.UNIT_END + 0x3A8,                       // 0x452 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_ITEM_ID = EUnitFields.UNIT_END + 0x3A9,                  // 0x453 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_RANDOM_PROPERTIES_ID = EUnitFields.UNIT_END + 0x3AA,     // 0x454 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_SEED = EUnitFields.UNIT_END + 0x3AB,                     // 0x455 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_PRICE = EUnitFields.UNIT_END + 0x3AC,                    // 0x456 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_DURABILITY = EUnitFields.UNIT_END + 0x3AD,               // 0x457 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_COUNT = EUnitFields.UNIT_END + 0x3AE,                    // 0x458 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_SESSION_KILLS = EUnitFields.UNIT_END + 0x3AF,                    // 0x459 - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_FIELD_YESTERDAY_KILLS = EUnitFields.UNIT_END + 0x3B0,                  // 0x45A - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_FIELD_LAST_WEEK_KILLS = EUnitFields.UNIT_END + 0x3B1,                  // 0x45B - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_FIELD_LIFETIME_HONORBALE_KILLS = EUnitFields.UNIT_END + 0x3B2,         // 0x45C - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_LIFETIME_DISHONORBALE_KILLS = EUnitFields.UNIT_END + 0x3B3,      // 0x45D - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_YESTERDAY_CONTRIBUTION = EUnitFields.UNIT_END + 0x3B4,           // 0x45E - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_LAST_WEEK_CONTRIBUTION = EUnitFields.UNIT_END + 0x3B5,           // 0x45F - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_LAST_WEEK_RANK = EUnitFields.UNIT_END + 0x3B6,                   // 0x460 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_PADDING = EUnitFields.UNIT_END + 0x3B7,                          // 0x461 - Size: 1 - Type: INT - Flags: NONE
    PLAYER_END = EUnitFields.UNIT_END + 0x3B8                                     // 0x462
}
Public Enum EGameObjectFields
{
    GAMEOBJECT_DISPLAYID = EObjectFields.OBJECT_END + 0x0,                        // 0x006 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_FLAGS = EObjectFields.OBJECT_END + 0x1,                            // 0x007 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_ROTATION = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 4 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_STATE = EObjectFields.OBJECT_END + 0x6,                            // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_TIMESTAMP = EObjectFields.OBJECT_END + 0x7,                        // 0x00D - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_POS_X = EObjectFields.OBJECT_END + 0x8,                            // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_POS_Y = EObjectFields.OBJECT_END + 0x9,                            // 0x00F - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_POS_Z = EObjectFields.OBJECT_END + 0xA,                            // 0x010 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_FACING = EObjectFields.OBJECT_END + 0xB,                           // 0x011 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_DYN_FLAGS = EObjectFields.OBJECT_END + 0xC,                        // 0x012 - Size: 1 - Type: INT - Flags: DYNAMIC
    GAMEOBJECT_FACTION = EObjectFields.OBJECT_END + 0xD,                          // 0x013 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_TYPE_ID = EObjectFields.OBJECT_END + 0xE,                          // 0x014 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_LEVEL = EObjectFields.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_END = EObjectFields.OBJECT_END + 0x10                              // 0x016
}
Public Enum EDynamicObjectFields
{
    DYNAMICOBJECT_CASTER = EObjectFields.OBJECT_END + 0x0,                        // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    DYNAMICOBJECT_BYTES = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: BYTES - Flags: PUBLIC
    DYNAMICOBJECT_SPELLID = EObjectFields.OBJECT_END + 0x3,                       // 0x009 - Size: 1 - Type: INT - Flags: PUBLIC
    DYNAMICOBJECT_RADIUS = EObjectFields.OBJECT_END + 0x4,                        // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_X = EObjectFields.OBJECT_END + 0x5,                         // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_Y = EObjectFields.OBJECT_END + 0x6,                         // 0x00C - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_Z = EObjectFields.OBJECT_END + 0x7,                         // 0x00D - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_FACING = EObjectFields.OBJECT_END + 0x8,                        // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_PAD = EObjectFields.OBJECT_END + 0x9,                           // 0x00F - Size: 1 - Type: BYTES - Flags: PUBLIC
    DYNAMICOBJECT_END = EObjectFields.OBJECT_END + 0xA                            // 0x010
}
Public Enum ECorpseFields
{
    CORPSE_FIELD_OWNER = EObjectFields.OBJECT_END + 0x0,                          // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    CORPSE_FIELD_FACING = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_X = EObjectFields.OBJECT_END + 0x3,                          // 0x009 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_Y = EObjectFields.OBJECT_END + 0x4,                          // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_Z = EObjectFields.OBJECT_END + 0x5,                          // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_DISPLAY_ID = EObjectFields.OBJECT_END + 0x6,                     // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_ITEM = EObjectFields.OBJECT_END + 0x7,                           // 0x00D - Size: 19 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_BYTES_1 = EObjectFields.OBJECT_END + 0x1A,                       // 0x020 - Size: 1 - Type: BYTES - Flags: PUBLIC
    CORPSE_FIELD_BYTES_2 = EObjectFields.OBJECT_END + 0x1B,                       // 0x021 - Size: 1 - Type: BYTES - Flags: PUBLIC
    CORPSE_FIELD_GUILD = EObjectFields.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_FLAGS = EObjectFields.OBJECT_END + 0x1D,                         // 0x023 - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_END = EObjectFields.OBJECT_END + 0x1E                                  // 0x024
}
