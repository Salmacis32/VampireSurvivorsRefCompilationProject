/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Achievements
{
	[UsedImplicitly]
	public class AchievementManager : IInitializable, IDisposable // TypeDefIndex: 18484
	{
		// Fields
		public List<AchievementType> AchievementsUnlockedOnPlatform; // 0x10
		[Inject]
		private DataManager _dataManager; // 0x18
		[Inject]
		private AdventureProgressManager _adventureProgressManager; // 0x20
		[Inject]
		private AdventureManager _adventureManager; // 0x28
		private Dictionary<AchievementType, AchievementData> _Achievements; // 0x30
		private List<AchievementType> _UnAchievedAchievements; // 0x38
		private List<AchievementData> _recentlyUnlocked; // 0x40
		private List<AchievementData> _recentlyUnlockedAdventureProgress; // 0x48
		private List<SecretType> _newSecrets; // 0x50
		private List<VampireSurvivors.Objects.Characters.CharacterController> _Characters; // 0x58
		private List<AchievementType> _AchivementsToUnlock; // 0x60
		private List<ICustomAchievements> _CustomAchievementHandellers; // 0x68
		private PlayerOptions _playerOptions; // 0x70
		private GameSessionData _sessionData; // 0x78
		private MultiplayerManager _multiplayer; // 0x80
		public bool allowUnlocking; // 0x88
		private int _CollectionCount; // 0x8C
		private AchievementManager_ThosePeople _AchievementManager_ThosePeople; // 0x90
	
		// Properties
		public List<SecretType> NewSecrets { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public List<VampireSurvivors.Objects.Characters.CharacterController> Characters { get => default; } // 0x0000000180B15730-0x0000000180B15740 
	
		// Nested types
		[Serializable]
		public enum AchievementUnlockType // TypeDefIndex: 18482
		{
			KillXNumberOfEnemies = 1,
			KillXNumberOfEnemiesOfTypes = 2,
			KillXNumberOfEnemiesInRun = 3,
			KillBossTypesInRun = 4,
			PlayInStage = 5,
			SurviveXSeconds = 6,
			FindItems = 7,
			FindXNumberOfItems = 8,
			FindXNumberOfAnyItems = 9,
			HaveOpenedCoffinForXCharacter = 10,
			FindWeapons = 11,
			CollectedWeapons = 12,
			HaveLeveledWeaponToSpecificLevel = 13,
			HaveLeveledWeaponToSpecificLevelOrEvolved = 14,
			ReachedXLevel = 15,
			ReachedXLevelAsCharacter = 16,
			PlayXCharacter = 17,
			HaveModifiers = 18
		}
	
		[Serializable]
		public enum ModifierType // TypeDefIndex: 18483
		{
			Hyper = 1,
			Hurry = 2,
			LimitBreak = 3,
			Inverse = 4,
			Endless = 5
		}
	
		// Constructors
		public AchievementManager() {} // 0x00000001867682B0-0x00000001867686B0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, GameSessionData session, MultiplayerManager multi) {} // 0x000000018675FDB0-0x000000018675FEC0
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void Setup() {} // 0x000000018675FEC0-0x0000000186760280
		public void UnlockAchievement(AchievementType achievement) {} // 0x0000000186760280-0x0000000186760320
		public void UnlockAchievementDirectly(AchievementType t) {} // 0x0000000186760320-0x00000001867603A0
		public void CheckForStartupAchievements() {} // 0x00000001867603A0-0x0000000186760680
		public void FixUnlocks() {} // 0x0000000186760680-0x00000001867611C0
		public List<SecretType> CheckAllSecrets() => default; // 0x00000001867611C0-0x0000000186761410
		public List<AchievementData> CheckAllAchievements() => default; // 0x0000000186761410-0x0000000186761F10
		private List<AchievementData> BuildAchievedList(Dictionary<AdventureAchievementType, AchievementData> achieved) => default; // 0x0000000186761F10-0x00000001867624C0
		public void UnlockAchievementsAndGiveRewards() {} // 0x00000001867624C0-0x0000000186762760
		public bool Unlock(AchievementType t) => default; // 0x0000000186762760-0x0000000186762A90
		private void PopPlatformAchievement(AchievementType t) {} // 0x0000000186762A90-0x0000000186762BB0
		private bool CheckAchievement(AchievementData achievementData) => default; // 0x0000000186762BB0-0x0000000186762DC0
		private bool CheckUnlockCondition(AchievementUnlockConditionData unlockConditionData) => default; // 0x0000000186762DC0-0x00000001867630F0
		private bool CheckKillXNumberOfEnemies(int requiredNumberOfKills) => default; // 0x00000001867630F0-0x00000001867632B0
		private bool CheckKillXNumberOfEnemiesOfTypes(List<EnemyType> enemyTypes, int requiredNumberOfKills) => default; // 0x00000001867632B0-0x00000001867635C0
		private bool CheckKillXNumberOfEnemiesInRun(int requiredNumberOfKills) => default; // 0x00000001867635C0-0x0000000186763600
		private bool CheckKillBossTypesInRun(List<EnemyType> enemyTypes) => default; // 0x0000000186763600-0x0000000186763830
		private bool CheckPlayInStage(StageType requiredStage) => default; // 0x0000000186763830-0x00000001867638B0
		private bool CheckSurviveXSeconds(float requiredSurvivedSeconds) => default; // 0x00000001867638B0-0x0000000186763920
		private bool CheckFindItems(List<VampireSurvivors.Data.ItemType> requiredItemTypes) => default; // 0x0000000186763920-0x0000000186763B50
		private bool CheckFindXNumberOfItems(List<VampireSurvivors.Data.ItemType> requiredItemTypes, int requiredNumberOfItems) => default; // 0x0000000186763B50-0x0000000186763E70
		private bool CheckFindXNumberOfAnyItems(int requiredNumberOfItems) => default; // 0x0000000186763E70-0x0000000186763E80
		public bool CheckHaveOpenedCoffinForXCharacter(VampireSurvivors.Data.CharacterType requiredCharacterType) => default; // 0x0000000186763E80-0x0000000186763FC0
		private bool CheckFindWeapons(List<WeaponType> requiredWeapons) => default; // 0x0000000186763FC0-0x0000000186764340
		private bool CheckCollectedWeapons(List<WeaponType> requiredWeapons) => default; // 0x0000000186764340-0x0000000186764570
		private bool CheckHaveLeveledWeaponToSpecificLevel(WeaponType weaponType, int level) => default; // 0x0000000186764570-0x00000001867646F0
		private bool CheckHaveLeveledWeaponToSpecificLevelOrEvolved(WeaponType weaponType, int level, WeaponType evolvedWeaponType) => default; // 0x00000001867646F0-0x0000000186764890
		private bool CheckReachedXLevel(int requiredLevel) => default; // 0x0000000186764890-0x00000001867649F0
		private bool ReachedXLevelAsCharacter(VampireSurvivors.Data.CharacterType characterType, int requiredLevel) => default; // 0x00000001867649F0-0x0000000186764B80
		private bool CheckPlayXCharacter(VampireSurvivors.Data.CharacterType requiredCharacterType) => default; // 0x0000000186764B80-0x0000000186764CE0
		private bool CheckHaveModifiers(List<ModifierType> requiredModifierTypes) => default; // 0x0000000186764CE0-0x0000000186764FF0
		public void AddRecentlyUnlockedAdventureProgress(AchievementData achievementData) {} // 0x0000000186764FF0-0x0000000186765040
		public Sprite GetSpriteForAchievement(AchievementData bad) => default; // 0x0000000186765040-0x0000000186765A30
		public Sprite GetFrameForSprite(AchievementData bad) => default; // 0x0000000186765A30-0x0000000186765DE0
		public string GetUnlockText(AchievementData bad) => default; // 0x0000000186765DE0-0x0000000186766EB0
		public bool CheckForCoffinOpen(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186766EB0-0x0000000186766FF0
		public int GetPickUpCount(VampireSurvivors.Data.ItemType t) => default; // 0x0000000186766FF0-0x00000001867670D0
		public int GetPlayerWeaponLevel(VampireSurvivors.Objects.Characters.CharacterController character, WeaponType t, bool checkRemovedEquipment = true /* Metadata: 0x0197A9A8 */, bool checkHiddenEquipment = false /* Metadata: 0x0197A9A9 */) => default; // 0x00000001867670D0-0x0000000186767800
		public void ApplyPlatformAchievementsRetroactively() {} // 0x0000000186767800-0x0000000186767B60
		public int CountKilledEnemiesAndVariants(EnemyType enemyType) => default; // 0x0000000186767B60-0x0000000186768200
		public bool CheckRequiredCharacterUnlocked(AchievementType achievementType) => default; // 0x0000000186768200-0x00000001867682B0
	}
}
