/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Objects
{
	[Serializable]
	[Title("Stage Modifiers")]
	public class StageModifiers // TypeDefIndex: 18566
	{
		// Properties
		[Title("Time Limit")]
		public float? TimeLimit { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000182626A90-0x0000000182626AA0
		[Title("Clock Speed")]
		public float? ClockSpeed { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000182759640-0x0000000182759650
		[Title("Player Px Speed")]
		public float? PlayerPxSpeed { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000182759650-0x0000000182759660
		[Title("Enemy Speed")]
		public float? EnemySpeed { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		[Title("Projectile Speed")]
		public float? ProjectileSpeed { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x00000001847D19F0-0x00000001847D1A00
		[Title("Gold Multiplier")]
		public float? GoldMultiplier { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		[Title("Enemy Health Multiplier")]
		public float? EnemyHealthMultiplier { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018197EA90-0x000000018197EAA0
		[Title("Luck Bonus")]
		public float? LuckBonus { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018197EAA0-0x000000018197EAB0
		[Title("XP Bonus")]
		public float? XpBonus { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018197EAC0-0x000000018197EAD0
		[Title("Starting Spawns")]
		public float? StartingSpawns { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x0000000184BBA0D0-0x0000000184BBA0E0
		[Title("End Cycles")]
		public float? EndCycles { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x0000000184E2EFF0-0x0000000184E2F000
		public TimeMods TimeMods { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		[Title("Unlocked")]
		public bool unlocked { get; set; } // 0x00000001827B0910-0x00000001827B0920 0x0000000181918080-0x0000000181918090
		[Title("Enemy Minimum Mul")]
		public float EnemyMinimumMul { get; set; } // 0x000000018288A280-0x000000018288A290 0x000000018288A290-0x000000018288A2A0
		[Title("BGM Rate")]
		public float BGM_rate { get; set; } // 0x000000018599D600-0x000000018599D610 0x00000001867E3C40-0x00000001867E3C50
		[Title("BGM Detune")]
		public int BGM_detune { get; set; } // 0x0000000181BABDF0-0x0000000181BABE00 0x0000000181BABE00-0x0000000181BABE10
		[Title("BGM - Ignore Mods for New Soundtrack")]
		public bool BGM_ignoreModsForNewSoundtrack { get; set; } // 0x00000001831F88E0-0x00000001831F88F0 0x00000001831F88F0-0x00000001831F8900
		[Title("BGM New Rate")]
		public float BGM_new_rate { get; set; } // 0x0000000185D7E7E0-0x0000000185D7E7F0 0x0000000185D7E7F0-0x0000000185D7E800
		[Title("BGM New Detune")]
		public int BGM_new_detune { get; set; } // 0x0000000182518590-0x00000001825185A0 0x00000001825185A0-0x00000001825185B0
		[Title("Tint")]
		public uint? tint { get; set; } // 0x0000000184BDAFA0-0x0000000184BDAFB0 0x0000000183B898F0-0x0000000183B89900
	
		// Constructors
		public StageModifiers() {} // 0x00000001867E3C50-0x00000001867E3C70
	
		// Methods
		public void SetStageDefaults() {} // 0x00000001867E3C70-0x00000001867E3EB0
		public void Add(StageModifiers data) {} // 0x00000001867E3EB0-0x00000001867E4200
		public void Set(StageModifiers data) {} // 0x00000001867E4200-0x00000001867E44F0
	}
}
