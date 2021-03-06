﻿using System.Runtime.InteropServices;

namespace DiabloInterface.D2.Struct
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    class D2SafeArray
    {
        public uint Length;
        public DataPointer Memory;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1, Size = 0x1A8)]
    public class D2ItemDescription
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string flippyFile;                   // 0x000
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string invFile;                      // 0x020
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string uniqueInvFile;                // 0x040
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string setInvFile;                   // 0x060
        public uint code;                           // 0x080
        public uint normCode;                       // 0x084
        public uint uberCode;                       // 0x088
        public uint ultraCode;                      // 0x08C
        public uint alternateGfx;                   // 0x090
        public uint spell;                          // 0x094
        public ushort state0;                       // 0x098
        public ushort state1;                       // 0x09A
        public ushort state2;                       // 0x09C
        public ushort stat1;                        // 0x09E
        public ushort stat2;                        // 0x0A0
        public ushort stat3;                        // 0x0A2
        public uint calc1;                          // 0x0A4
        public uint calc2;                          // 0x0A8
        public uint calc3;                          // 0x0AC
        public uint length;                         // 0x0B0
        public ushort spellDescription;             // 0x0B4
        public ushort spellDescString;              // 0x0B6
        public uint spellDescCalc;                  // 0x0B8
        public uint betterGem;                      // 0x0BC
        public uint weaponClass;                    // 0x0C0
        public uint weaponClassTwoHand;             // 0x0C4
        public uint TMogType;                       // 0x0C8
        public uint minAC;                          // 0x0CC
        public uint maxAC;                          // 0x0D0
        public uint gambleCost;                     // 0x0D4
        public uint speed;                          // 0x0D8
        public uint bitField1;                      // 0x0DC
        public uint cost;                           // 0x0E0
        public uint minStack;                       // 0x0E4
        public uint maxStack;                       // 0x0E8
        public uint spawnStack;                     // 0x0EC
        public uint gemOffset;                      // 0x0F0
        public ushort NameHashCode;                 // 0x0F4
        public ushort version;                      // 0x0F6
        public ushort autoPrefix;                   // 0x0F8
        public ushort missileType;                  // 0x0FA
        public byte rarity;                         // 0x0FC
        public byte level;                          // 0x0FD
        public byte minDamage;                      // 0x0FE
        public byte maxDamage;                      // 0x0FF
        public byte minMissDamage;                  // 0x100
        public byte maxMissDamage;                  // 0x101
        public byte minDamageTwoHand;               // 0x102
        public byte maxDamageTwoHand;               // 0x103
        public ushort rangeAdder;                   // 0x104
        public ushort strBonus;                     // 0x106
        public ushort dexBonus;                     // 0x108
        public ushort reqStr;                       // 0x10A
        public ushort reqDex;                       // 0x10C
        public byte absorbs;                        // 0x10E
        public byte invWidth;                       // 0x10F
        public byte invHeight;                      // 0x110
        public byte block;                          // 0x111
        public byte durability;                     // 0x112
        public byte noDurability;                   // 0x113
        public byte missile;                        // 0x114
        public byte component;                      // 0x115
        public byte lArm;                           // 0x116
        public byte rArm;                           // 0x117
        public byte torso;                          // 0x118
        public byte legs;                           // 0x119
        public byte lSpad;                          // 0x11A
        public byte rSpad;                          // 0x11B
        public byte TwoHanded;                      // 0x11C
        public byte Usable;                         // 0x11D
        public ushort ItemType;                     // 0x11E
        public ushort ItemType2;                    // 0x120
        public ushort ItemSubType;                  // 0x122
        public ushort DropSound;                    // 0x124
        public ushort UseSound;                     // 0x126
        public byte DropsFxFrame;                   // 0x128
        public byte Unique;                         // 0x129
        public byte Quest;                          // 0x12A
        public byte QuestDiffCheck;                 // 0x12B
        public byte Transparent;                    // 0x12C
        public byte TransTbl;                       // 0x12D
        public byte _1;                             // 0x12E
        public byte LightRadius;                    // 0x12F
        public byte Belt;                           // 0x130
        public byte AutoBelt;                       // 0x131
        public byte Stackable;                      // 0x132
        public byte Spawnable;                      // 0x133
        public byte SpellIcon;                      // 0x134
        public byte DurabilityWarning;              // 0x135
        public byte QuantityWarning;                // 0x136
        public byte HasInventory;                   // 0x137
        public byte GemSockets;                     // 0x138
        public byte Transmogrify;                   // 0x139
        public byte TransmogrifyMin;                // 0x13A
        public byte TransmogrifyMax;                // 0x13B
        public byte HitClass;                       // 0x13C
        public byte OneOrTwoHanded;                 // 0x13D
        public byte GemApplyType;                   // 0x13E
        public byte LevelRequirement;               // 0x13F
        public byte MagicLevel;                     // 0x140
        public byte Transform;                      // 0x141
        public byte InvTransform;                   // 0x142
        public byte CompactSave;                    // 0x143
        public byte SkipName;                       // 0x144
        public byte Nameable;                       // 0x145
        public byte AkaraMin;                       // 0x146
        public byte GheedMin;                       // 0x147
        public byte CharsiMin;                      // 0x148
        public byte FaraMin;                        // 0x149
        public byte LysanderMin;                    // 0x14A
        public byte DrognanMin;                     // 0x14B
        public byte HraltiMin;                      // 0x14C
        public byte AlkorMin;                       // 0x14D
        public byte OrmusMin;                       // 0x14E
        public byte ElzixMin;                       // 0x14F
        public byte AshearaMin;                     // 0x150
        public byte CainMin;                        // 0x151
        public byte HalbuMin;                       // 0x152
        public byte JamellaMin;                     // 0x153
        public byte MalahMin;                       // 0x154
        public byte LarzukMin;                      // 0x155
        public byte DrehyaMin;                      // 0x156
        public byte AkaraMax;                       // 0x157
        public byte GheedMax;                       // 0x158
        public byte CharsiMax;                      // 0x159
        public byte FaraMax;                        // 0x15A
        public byte LysanderMax;                    // 0x15B
        public byte DrognanMax;                     // 0x15C
        public byte HraltiMax;                      // 0x15D
        public byte AlkorMax;                       // 0x15E
        public byte OrmusMax;                       // 0x15F
        public byte ElzixMax;                       // 0x160
        public byte AshearaMax;                     // 0x161
        public byte CainMax;                        // 0x162
        public byte HalbuMax;                       // 0x163
        public byte JamellaMax;                     // 0x164
        public byte MalahMax;                       // 0x165
        public byte LarzukMax;                      // 0x166
        public byte DrehyaMax;                      // 0x167
        public byte AkaraMagicMin;                  // 0x168
        public byte GheedMagicMin;                  // 0x169
        public byte CharsiMagicMin;                 // 0x16A
        public byte FaraMagicMin;                   // 0x16B
        public byte LysanderMagicMin;               // 0x16C
        public byte DrognanMagicMin;                // 0x16D
        public byte HraltiMagicMin;                 // 0x16E
        public byte AlkorMagicMin;                  // 0x16F
        public byte OrmusMagicMin;                  // 0x170
        public byte ElzixMagicMin;                  // 0x171
        public byte AshearaMagicMin;                // 0x172
        public byte CainMagicMin;                   // 0x173
        public byte HalbuMagicMin;                  // 0x174
        public byte JamellaMagicMin;                // 0x175
        public byte MalahMagicMin;                  // 0x176
        public byte LarzukMagicMin;                 // 0x177
        public byte DrehyaMagicMin;                 // 0x178
        public byte AkaraMagicMax;                  // 0x179
        public byte GheedMagicMax;                  // 0x17A
        public byte CharsiMagicMax;                 // 0x17B
        public byte FaraMagicMax;                   // 0x17C
        public byte LysanderMagicMax;               // 0x17D
        public byte DrognanMagicMax;                // 0x17E
        public byte HraltiMagicMax;                 // 0x17F
        public byte AlkorMagicMax;                  // 0x180
        public byte OrmusMagicMax;                  // 0x181
        public byte ElzixMagicMax;                  // 0x182
        public byte AshearaMagicMax;                // 0x183
        public byte CainMagicMax;                   // 0x184
        public byte HalbuMagicMax;                  // 0x185
        public byte JamellaMagicMax;                // 0x186
        public byte MalahMagicMax;                  // 0x187
        public byte LarzukMagicMax;                 // 0x188
        public byte DrehyaMagicMax;                 // 0x189
        public byte AkaraMagicLvl;                  // 0x18A
        public byte GheedMagicLvl;                  // 0x18B
        public byte CharsiMagicLvl;                 // 0x18C
        public byte FaraMagicLvl;                   // 0x18D
        public byte LysanderMagicLvl;               // 0x18E
        public byte DrognanMagicLvl;                // 0x18F
        public byte HraltiMagicLvl;                 // 0x190
        public byte AlkorMagicLvl;                  // 0x191
        public byte OrmusMagicLvl;                  // 0x192
        public byte ElzixMagicLvl;                  // 0x193
        public byte AshearaMagicLvl;                // 0x194
        public byte CainMagicLvl;                   // 0x195
        public byte HalbuMagicLvl;                  // 0x196
        public byte JamellaMagicLvl;                // 0x197
        public byte MalahMagicLvl;                  // 0x198
        public byte LarzukMagicLvl;                 // 0x199
        public ushort bDrehyaMagicLvl;              // 0x19A
        public uint dwNightmareUpgrade;             // 0x19C
        public uint dwHellUpgrade;                  // 0x1A0
        public byte bPermStoreItem;                 // 0x1A4
        public byte bmultibuy;                      // 0x1A5
        public ushort __padding;                    // 0x1A6
    }
}
