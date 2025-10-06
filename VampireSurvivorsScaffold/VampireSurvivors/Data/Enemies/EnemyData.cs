/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Enemies
{
	[Serializable]
	public class EnemyData // TypeDefIndex: 18466
	{
		// Fields
		[JsonIgnore]
		public List<string> Internal_FrameNamesAnim; // 0x160
		[JsonIgnore]
		public List<List<string>> Internal_IdleAnimFrameNames; // 0x168
		[JsonIgnore]
		public List<List<string>> Internal_DeathAnimFrameNames; // 0x170
	
		// Properties
		[Title("Level")]
		public int level { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[Title("Max HP")]
		public float maxHp { get; set; } // 0x00000001828A3D30-0x00000001828A3D40 0x00000001828A3D40-0x00000001828A3D50
		[Title("Speed")]
		public float speed { get; set; } // 0x000000018264AEB0-0x000000018264AEC0 0x0000000183E6B500-0x0000000183E6B510
		[Title("Max Speed")]
		public float maxSpeed { get; set; } // 0x0000000182A6AC90-0x0000000182A6ACA0 0x0000000184F379E0-0x0000000184F379F0
		[Title("Power")]
		public float power { get; set; } // 0x0000000181967D10-0x0000000181967D20 0x0000000184C5EF70-0x0000000184C5EF80
		[Title("Skills")]
		public List<EnemySkillType> skills { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Minimum HP Scale Level")]
		public int? minimumHpScalingLevel { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x00000001847D19F0-0x00000001847D1A00
		[Title("Maximum HP Scale Level")]
		public int? maximumHpScalingLevel { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x000000018197EA80-0x000000018197EA90
		[Title("Shield Duration")]
		public float shieldDuration { get; set; } // 0x000000018275A5A0-0x000000018275A5B0 0x000000018275A5B0-0x000000018275A5C0
		[Title("Knockback")]
		public float knockback { get; set; } // 0x000000018275A5C0-0x000000018275A5D0 0x000000018275A5D0-0x000000018275A5E0
		[Title("Max Knockback")]
		public float maxKnockback { get; set; } // 0x000000018275A5E0-0x000000018275A5F0 0x000000018275A5F0-0x000000018275A600
		[Title("Death KB")]
		public float deathKB { get; set; } // 0x000000018288BAA0-0x000000018288BAB0 0x000000018289F1C0-0x000000018289F1D0
		[Title("Tint")]
		public uint? tint { get; set; } // 0x000000018197EAB0-0x000000018197EAC0 0x000000018197EAC0-0x000000018197EAD0
		[Title("XP")]
		public float xp { get; set; } // 0x00000001850805A0-0x00000001850805B0 0x00000001863ED450-0x00000001863ED460
		[Title("More X")]
		public int moreX { get; set; } // 0x00000001819A01F0-0x00000001819A0200 0x0000000181C2BFF0-0x0000000181C2C000
		[Title("More Y")]
		public int moreY { get; set; } // 0x00000001819A0200-0x00000001819A0210 0x0000000181C2C000-0x0000000181C2C010
		[Title("Alpha")]
		public float alpha { get; set; } // 0x000000018289FD70-0x000000018289FD80 0x00000001840BD5F0-0x00000001840BD600
		[Title("Scale")]
		public float? scale { get; set; } // 0x00000001819A0210-0x00000001819A0220 0x0000000184235400-0x0000000184235410
		[Title("Res Freeze")]
		public float? res_Freeze { get; set; } // 0x00000001826E99F0-0x00000001826E9A00 0x0000000183BF5D20-0x0000000183BF5D30
		[Title("Res Rosary")]
		public float? res_Rosary { get; set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000185776850-0x0000000185776860
		[Title("Res Debuffs")]
		public float? res_Debuffs { get; set; } // 0x00000001819A0370-0x00000001819A0380 0x000000018655F360-0x000000018655F370
		[Title("Res Knockback")]
		public float? res_Knockback { get; set; } // 0x00000001819A03E0-0x00000001819A03F0 0x0000000184BBA3E0-0x0000000184BBA3F0
		[Title("Res Corridor")]
		public float? res_Corridor { get; set; } // 0x0000000181919F80-0x0000000181919F90 0x000000018272A990-0x000000018272A9A0
		[Title("Res Defang")]
		public float? res_Defang { get; set; } // 0x0000000181971630-0x0000000181971640 0x0000000184BBA3F0-0x0000000184BBA400
		[Title("Pass Through Walls")]
		public bool passThroughWalls { get; set; } // 0x0000000181971640-0x0000000181971650 0x0000000181971650-0x0000000181971660
		[Title("Cannot Be Follower")]
		public bool CannotBeFollower { get; set; } // 0x0000000184BE30A0-0x0000000184BE30B0 0x0000000184BE30B0-0x0000000184BE30C0
		public ColliderOverride colliderOverride { get; set; } // 0x00000001819716D0-0x00000001819716E0 0x00000001819716E0-0x0000000181971740
		[Title("Weak Fire")]
		public float? weak_Fire { get; set; } // 0x00000001819A0190-0x00000001819A01A0 0x000000018675C900-0x000000018675C910
		[Title("Skip Credits")]
		public bool skipCredits { get; set; } // 0x00000001847A2F00-0x00000001847A2F10 0x00000001857FB7A0-0x00000001857FB7B0
		[Title("Idle Frame Count")]
		public int idleFrameCount { get; set; } // 0x00000001829379A0-0x00000001829379B0 0x000000018613E3E0-0x000000018613E3F0
		[Title("Killed Amount")]
		public float killedAmount { get; set; } // 0x0000000183725DA0-0x0000000183725DB0 0x0000000183725DB0-0x0000000183725DC0
		[Required]
		[Title("Texture Name")]
		public string textureName { get; set; } // 0x00000001827666D0-0x00000001827666E0 0x0000000184BB7BF0-0x0000000184BB7C50
		[Title("End")]
		public int end { get; set; } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		[Required]
		[Title("Frame Names")]
		public List<string> frameNames { get; set; } // 0x0000000182A45A70-0x0000000182A45A80 0x00000001826AC0D0-0x00000001826ACAE0
		[Title("Patrol Duration")]
		public float patrolDuration { get; set; } // 0x0000000185138410-0x0000000185138420 0x0000000185138420-0x0000000185138430
		[Title("Fire Delay")]
		public float? fireDelay { get; set; } // 0x0000000184BBA470-0x0000000184BBA480 0x0000000184BBA480-0x0000000184BBA490
		[Title("Fire Delay Randomness")]
		public float? fireDelayRandomness { get; set; } // 0x00000001867589C0-0x00000001867589D0 0x00000001867589D0-0x00000001867589E0
		[Title("Firing Range Min")]
		public float? firingRangeMin { get; set; } // 0x00000001867589E0-0x00000001867589F0 0x00000001867589F0-0x0000000186758A00
		[Title("Firing Range Max")]
		public float? firingRangeMax { get; set; } // 0x000000018675C910-0x000000018675C920 0x000000018675C920-0x000000018675C930
		[Title("Bullet Type")]
		public EnemyType? bulletType { get; set; } // 0x000000018675C930-0x000000018675C940 0x0000000186560880-0x0000000186560890
		[Title("Lives")]
		public int? lives { get; set; } // 0x000000018675C940-0x000000018675C950 0x00000001865608B0-0x00000001865608C0
		[Title("Flag Name")]
		public string flagName { get; set; } // 0x00000001829475E0-0x00000001829475F0 0x0000000184BDAFE0-0x0000000184BDB040
		[Title("Alias")]
		public EnemyData alias { get; set; } // 0x00000001829475F0-0x0000000182947600 0x0000000184EC37A0-0x0000000184EC3800
		[Title("Fever Value")]
		public float feverValue { get; set; } // 0x0000000185D80140-0x0000000185D80150 0x0000000186758A40-0x0000000186758A50
		[Title("Name")]
		public string bName { get; set; } // 0x0000000182A45B90-0x0000000182A45BA0 0x0000000182A45BA0-0x0000000182A45C00
		[Title("Description")]
		public string bDesc { get; set; } // 0x0000000184F612E0-0x0000000184F612F0 0x0000000185D80170-0x0000000185D801D0
		[Title("Places")]
		public List<StageType> bPlaces { get; set; } // 0x0000000184F612F0-0x0000000184F61300 0x0000000185F85960-0x0000000185F859C0
		[Title("Include")]
		public bool bInclude { get; set; } // 0x000000018675C950-0x000000018675C960 0x000000018675C960-0x000000018675C970
		[Title("Ignore")]
		public bool bIgnore { get; set; } // 0x000000018675C970-0x000000018675C980 0x000000018675C980-0x000000018675C990
		[Title("Highlight")]
		public bool bHighlight { get; set; } // 0x000000018675C990-0x000000018675C9A0 0x000000018675C9A0-0x000000018675C9B0
		[Title("Variants")]
		public List<EnemyType> bVariants { get; set; } // 0x0000000184F54BD0-0x0000000184F54BE0 0x00000001864D7EE0-0x00000001864D7F40
		[Title("Include Color Variants")]
		public bool bIncludeColorVariants { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
		[Title("Material Type")]
		public MaterialType materialType { get; set; } // 0x0000000182950560-0x0000000182950570 0x0000000185F8DFC0-0x0000000185F8DFD0
	
		// Constructors
		public EnemyData() {} // 0x000000018675CEA0-0x000000018675D2C0
	
		// Methods
		public string GetLocalizedDescription(EnemyType type) => default; // 0x000000018675C9C0-0x000000018675CAD0
		public string GetLocalizedTips(EnemyType type) => default; // 0x000000018675CAD0-0x000000018675CBE0
		public string GetLocalizedDescriptionTerm(EnemyType type) => default; // 0x000000018675CBE0-0x000000018675CC40
		public string GetLocalizedNameTerm(EnemyType type) => default; // 0x000000018675CC40-0x000000018675CCA0
		public string GetLocalizedBestiaryNameTerm(EnemyType type) => default; // 0x000000018675CCA0-0x000000018675CD00
		public string GetLocalizedBestiaryDescription(EnemyType type) => default; // 0x000000018675CD00-0x000000018675CDB0
		public string GetLocalizedTipsTerm(EnemyType type) => default; // 0x000000018675CDB0-0x000000018675CE10
		public string GetLocalPrefix(EnemyType t) => default; // 0x000000018675CE10-0x000000018675CEA0
	}
}
