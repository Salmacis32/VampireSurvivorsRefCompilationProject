/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class AchievementManager_ThosePeople // TypeDefIndex: 18489
	{
		// Fields
		public AchievementManagerOld AM; // 0x10
		public CharacterController CC; // 0x18
		public PlayerOptions _playerOptions; // 0x20
	
		// Constructors
		public AchievementManager_ThosePeople() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void RunManualCreditsUnlockChecks(AchievementManager achievementManager, PlayerOptions playerOptions) {} // 0x00000001867788C0-0x00000001867789C0
		public void CheckAchievements_ThosePeople(CharacterController currentCharacter, AchievementManagerOld _achievementManager) {} // 0x00000001867789C0-0x000000018677A5D0
		public void Weapon_Unlock_Character_Achievement(VampireSurvivors.Data.CharacterType chara, AchievementType achi, int minutes = 10 /* Metadata: 0x0197A9C6 */) {} // 0x000000018677A5D0-0x000000018677A680
		public void Weapon_Unlock_Level_Achievement(WeaponType weapo, AchievementType achi, int level = 7 /* Metadata: 0x0197A9C7 */, bool checkhidden = true /* Metadata: 0x0197A9C8 */) {} // 0x000000018677A680-0x000000018677A6F0
		public void Weapon_Unlock_Character_Kills_Achievement(VampireSurvivors.Data.CharacterType chara, AchievementType achi, int kills = 1000 /* Metadata: 0x0197A9C9 */) {} // 0x000000018677A6F0-0x000000018677A7B0
		public void Weapon_Unlock_Damage_Achievement(List<WeaponType> weapons, AchievementType achi, float damage = 1000f /* Metadata: 0x0197A9CB */) {} // 0x000000018677A7B0-0x000000018677AB40
		public void Check_Weapons() {} // 0x000000018677AB40-0x000000018677BE00
		public void Check_MorningStar() {} // 0x000000018677BE00-0x000000018677C2E0
		public void Check_Spellbook() {} // 0x000000018677C2E0-0x000000018677C7C0
		public void Check_CoatOfArms() {} // 0x000000018677C7C0-0x000000018677CF40
		public void Check_Diabologue() {} // 0x000000018677CF40-0x000000018677D420
		public void Check_SpectralSword() {} // 0x000000018677D420-0x000000018677D900
		public void Check_CandyboxSkins() {} // 0x000000018677D900-0x000000018677DCE0
		public void CheckSecrets_ThosePeople(CharacterController currentCharacter, AchievementManager _achievementManager) {} // 0x000000018677DCE0-0x000000018677FF80
		private bool CheckForFireTypeWeapons(CharacterController currentCharacter) => default; // 0x000000018677FF80-0x00000001867802D0
		private bool CheckForCoatOfArmsEvos(CharacterController currentCharacter) => default; // 0x00000001867802D0-0x0000000186780900
	}
}
