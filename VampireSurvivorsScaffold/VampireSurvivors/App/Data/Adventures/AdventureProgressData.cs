/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Data.Adventures
{
	[Serializable]
	public class AdventureProgressData // TypeDefIndex: 18621
	{
		// Properties
		[JsonProperty("Type")]
		[Title("Type")]
		public AdventureAchievementType Type { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[JsonProperty("iconSpriteName")]
		[Title("Icon Sprite Name")]
		public string IconSpriteName { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[JsonProperty("iconTextureName")]
		[Title("Icon Texture Name")]
		public string IconTextureName { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[JsonProperty("requiredLevel")]
		[Title("Required Level")]
		public int? RequiredLevel { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000185A2C780-0x0000000185A2C790
		[JsonProperty("requiredMinute")]
		[Title("Required Minute")]
		public int? RequiredMinute { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x00000001847D19F0-0x00000001847D1A00
		[JsonProperty("requiredCharacter")]
		[Title("Required Character")]
		public VampireSurvivors.Data.CharacterType? RequiredCharacter { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		[JsonProperty("requiredStage")]
		[Title("Required Stage")]
		public StageType? RequiredStage { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018197EA90-0x000000018197EAA0
		[JsonProperty("requiredEnemyKillType")]
		[Title("Required Enemy Kill Type")]
		public EnemyType? RequiredEnemyKillType { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018197EAA0-0x000000018197EAB0
		[JsonProperty("requiredEnemyKillCount")]
		[Title("Required Enemy Kill Count")]
		public int? RequiredEnemyKillCount { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018197EAC0-0x000000018197EAD0
		[JsonProperty("foundWeaponType")]
		[Title("Required Found Weapon Type")]
		public WeaponType? RequiredFoundWeaponType { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x0000000184BBA0D0-0x0000000184BBA0E0
		[JsonProperty("foundCoffin")]
		[Title("Required Found Coffin Type")]
		public VampireSurvivors.Data.CharacterType? RequiredFoundCoffinType { get; set; } // 0x0000000180B15740-0x0000000180B15750 0x0000000184E2EFF0-0x0000000184E2F000
	
		// Constructors
		public AdventureProgressData() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
