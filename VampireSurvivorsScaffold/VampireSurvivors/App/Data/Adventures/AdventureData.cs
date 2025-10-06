/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Data;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Data.Adventures
{
	[Serializable]
	public class AdventureData // TypeDefIndex: 18620
	{
		// Properties
		[JsonProperty("index")]
		[Title("Index")]
		public int Index { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[JsonProperty("progressKey")]
		[Title("Progress Key")]
		public string ProgressKey { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		[JsonProperty("coreAdventureData")]
		[Title("Core Adventure Data")]
		public CoreAdventureData CoreAdventureData { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[JsonProperty("CHARACTER_DATA")]
		[Title("Character Data")]
		public List<VampireSurvivors.Data.CharacterType> CharacterTypes { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[JsonProperty("STAGE_DATA")]
		[Title("Stage Data")]
		public StageSetType StageSetType { get; set; } // 0x0000000181953B80-0x0000000181953B90 0x0000000181953B90-0x0000000181953BA0
		[JsonProperty("WEAPON_DATA")]
		[Title("Weapon Data")]
		public List<WeaponType> WeaponTypes { get; set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		[JsonProperty("PROGRESS_DATA")]
		[Title("Progress Data")]
		public List<AchievementData> ProgressData { get; set; } // 0x0000000180B15750-0x0000000180B15760 0x000000018260F820-0x000000018260F880
		[JsonProperty("EXTRA_BESTIARY_TYPES")]
		[Title("Extra Bestiary Types")]
		public List<EnemyType> ExtraBestiaryTypes { get; set; } // 0x0000000180B15760-0x0000000180B15770 0x000000018268E650-0x000000018268E6B0
	
		// Constructors
		public AdventureData() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
