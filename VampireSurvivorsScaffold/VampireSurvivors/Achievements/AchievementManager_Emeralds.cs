/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	[UsedImplicitly]
	public class AchievementManager_Emeralds // TypeDefIndex: 18487
	{
		// Fields
		public AchievementManager AM; // 0x10
		public CharacterController CC; // 0x18
		public PlayerOptions _playerOptions; // 0x20
	
		// Constructors
		public AchievementManager_Emeralds() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void CheckAchievements_Emeralds(CharacterController currentCharacter, AchievementManager _achievementManager) {} // 0x0000000186776F70-0x0000000186778130
		public void CheckSecrets_Emeralds(CharacterController currentCharacter, AchievementManager _achievementManager) {} // 0x0000000186778130-0x0000000186778850
		public void Weapon_Unlock_Level_Achievement(WeaponType weapo, AchievementType achi, int level = 7 /* Metadata: 0x0197A9C4 */, bool checkhidden = true /* Metadata: 0x0197A9C5 */) {} // 0x0000000186778850-0x00000001867788C0
	}
}
