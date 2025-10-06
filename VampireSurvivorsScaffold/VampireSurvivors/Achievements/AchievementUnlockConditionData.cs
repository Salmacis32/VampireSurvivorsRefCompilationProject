/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	public class AchievementUnlockConditionData // TypeDefIndex: 18490
	{
		// Fields
		public AchievementManager.AchievementUnlockType AchievementUnlockType; // 0x10
		public int RequiredNumEnemiesKilled; // 0x14
		public List<EnemyType> RequiredEnemyTypes; // 0x18
		public StageType RequiredStageType; // 0x20
		public float RequiredSurvivedSeconds; // 0x24
		public List<VampireSurvivors.Data.ItemType> RequiredItems; // 0x28
		public int RequiredNumberOfItems; // 0x30
		public VampireSurvivors.Data.CharacterType RequiredCharacterType; // 0x34
		public List<WeaponType> RequiredWeapons; // 0x38
		public List<WeaponType> RequiredEvolvedWeapons; // 0x40
		public int RequiredLevel; // 0x48
		public List<AchievementManager.ModifierType> RequiredMofiers; // 0x50
	
		// Constructors
		public AchievementUnlockConditionData() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
