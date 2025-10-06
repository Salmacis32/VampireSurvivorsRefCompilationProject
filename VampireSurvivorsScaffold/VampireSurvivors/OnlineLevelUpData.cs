/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public struct OnlineLevelUpData // TypeDefIndex: 14055
	{
		// Properties
		public List<WeaponType> ChosenLevelUpWeapons { [IsReadOnly] get; set; } // 0x000000018199AF30-0x000000018199AF40 0x00000001819A9080-0x00000001819A90E0
		public List<VampireSurvivors.Data.ItemType> ChosenLevelUpItems { [IsReadOnly] get; set; } // 0x000000018195ADA0-0x000000018195ADB0 0x00000001819A9E20-0x00000001819A9E80
		public List<CharacterController> ChosenAmuletTargets { [IsReadOnly] get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		public List<WeightedLimitBreak> ChosenLimitBreaks { [IsReadOnly] get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
		public bool ShouldSwapToLevelUpUi { [IsReadOnly] get; set; } // 0x0000000181E0A560-0x0000000181E0A570 0x0000000181E0A570-0x0000000181E0A580
		public CharacterController TargetCharacter { [IsReadOnly] get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public bool AdjustXpFactors { [IsReadOnly] get; set; } // 0x0000000180B1C110-0x0000000180B1C120 0x000000018197EA10-0x000000018197EA20
	}
}
