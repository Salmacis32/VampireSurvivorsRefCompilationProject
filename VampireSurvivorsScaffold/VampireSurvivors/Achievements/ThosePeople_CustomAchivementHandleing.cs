/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	public class ThosePeople_CustomAchivementHandleing : ICustomAchievements // TypeDefIndex: 18502
	{
		// Constructors
		public ThosePeople_CustomAchivementHandleing() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public static void RunManualCreditsUnlockChecks(AchievementManager achievementManager, PlayerOptions playerOptions) {} // 0x00000001867895F0-0x00000001867896F0
		public List<AchievementType> CheckAchievements(PlayerOptions playerOptions, AchievementManager achievementManager, DataManager dataManager) => default; // 0x00000001867896F0-0x000000018678A850
		public List<AchievementType> GetUnlocksThatNeedFixing(PlayerOptions playerOptions) => default; // 0x000000018678A850-0x000000018678A8B0
		public List<AchievementType> CheckForStartupAchievements(PlayerOptions playerOptions) => default; // 0x000000018678A8B0-0x000000018678A910
		public void RunSecretsCheck(AchievementManager achievementManager, PlayerOptions playerOptions, DataManager dataManager) {} // 0x000000018678A910-0x000000018678D100
		public bool Check_MorningStar(PlayerOptions playerOptions) => default; // 0x000000018678D100-0x000000018678D5C0
		public bool Check_Spellbook(PlayerOptions playerOptions) => default; // 0x000000018678D5C0-0x000000018678DA80
		public bool Check_CoatOfArms(PlayerOptions playerOptions) => default; // 0x000000018678DA80-0x000000018678E1E0
		public bool Check_Diabologue(PlayerOptions playerOptions) => default; // 0x000000018678E1E0-0x000000018678E6A0
		public bool Check_SpectralSword(PlayerOptions playerOptions) => default; // 0x000000018678E6A0-0x000000018678EB60
		public bool Check_CandyboxSkins(PlayerOptions playerOptions) => default; // 0x000000018678EB60-0x000000018678EF20
		private bool CheckForFireTypeWeapons(CharacterController currentCharacter) => default; // 0x000000018678EF20-0x000000018678F210
		private bool CheckForCoatOfArmsEvos(CharacterController currentCharacter) => default; // 0x000000018678F210-0x000000018678F840
		public bool Weapon_Unlock_Damage_Achievement(AchievementManager achievementManager, List<WeaponType> weapons, float damage = 1000f /* Metadata: 0x0197A9D2 */) => default; // 0x000000018678F840-0x000000018678FC60
	}
}
