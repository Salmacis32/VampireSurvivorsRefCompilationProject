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
	public class AchievementManagerOld : IInitializable, IDisposable // TypeDefIndex: 18486
	{
		// Fields
		public List<AchievementType> AchievementsUnlockedOnPlatform; // 0x10
		[Inject]
		private DataManager _dataManager; // 0x18
		[Inject]
		private AdventureProgressManager _adventureProgressManager; // 0x20
		[Inject]
		private AdventureManager _adventureManager; // 0x28
		private Dictionary<AchievementType, AchievementData> _achievements; // 0x30
		private List<AchievementData> _recentlyUnlocked; // 0x38
		private List<AchievementData> _recentlyUnlockedAdventureProgress; // 0x40
		private List<SecretType> _newSecrets; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private GameSessionData _sessionData; // 0x58
		private MultiplayerManager _multiplayer; // 0x60
		private AchievementManager_ThosePeople _AchievementManager_ThosePeople; // 0x68
	
		// Constructors
		public AchievementManagerOld() {} // 0x0000000186776C00-0x0000000186776F30
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, GameSessionData session, MultiplayerManager multi) {} // 0x00000001867686B0-0x00000001867687B0
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public int CountKilledEnemiesAndVariants(EnemyType enemyType) => default; // 0x00000001867687B0-0x0000000186768E50
		public void UnlockAchievement(AchievementType t) {} // 0x0000000186768E50-0x0000000186768ED0
		public void CheckForStartupAchievements() {} // 0x0000000186768ED0-0x0000000186769640
		public void FixUnlocks() {} // 0x0000000186769640-0x0000000186769FE0
		public Sprite GetSpriteForAchievement(AchievementData bad) => default; // 0x0000000186769FE0-0x000000018676A9D0
		public Sprite GetFrameForSprite(AchievementData bad) => default; // 0x000000018676A9D0-0x000000018676AD80
		public string GetUnlockText(AchievementData bad) => default; // 0x000000018676AD80-0x000000018676BBC0
		public List<AchievementData> CheckAllAchievements() => default; // 0x000000018676BBC0-0x000000018676BF60
		public List<SecretType> CheckAllSecrets() => default; // 0x000000018676BF60-0x000000018676C160
		public void AddRecentlyUnlockedAdventureProgress(AchievementData achievementData) {} // 0x000000018676C160-0x000000018676C1B0
		private void RunSecretsCheck(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x000000018676C1B0-0x000000018676D290
		private void RunCheck(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x000000018676D290-0x0000000186772120
		public bool CheckForCoffinOpen(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186772120-0x0000000186772260
		private void CheckAchievements_Moonspell(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x0000000186772260-0x00000001867727C0
		private void CheckAchievements_Foscari(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x00000001867727C0-0x0000000186772D80
		private void CheckAchievements_Chalcedony(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x0000000186772D80-0x00000001867732F0
		private void CheckAchievements_FirstBlood(VampireSurvivors.Objects.Characters.CharacterController currentCharacter) {} // 0x00000001867732F0-0x0000000186773A90
		private bool CheckSigmaUnlock() => default; // 0x0000000186773A90-0x0000000186774E60
		private bool HasAlreadyUnlocked(AchievementType t, PlayerOptionsData config) => default; // 0x0000000186774E60-0x0000000186774EC0
		public void Unlock(AchievementType t) {} // 0x0000000186774EC0-0x00000001867751D0
		private void PopPlatformAchievement(AchievementType t) {} // 0x00000001867751D0-0x00000001867752F0
		public void ApplyPlatformAchievementsRetroactively() {} // 0x00000001867752F0-0x0000000186775650
		public int GetKillCount(EnemyType t) => default; // 0x0000000186775650-0x0000000186775730
		private int GetKillCountIncludingVariants(EnemyType t) => default; // 0x0000000186775730-0x00000001867759F0
		private int GetDestroyCount(PropType t) => default; // 0x00000001867759F0-0x0000000186775AD0
		public int GetPlayerWeaponLevel(VampireSurvivors.Objects.Characters.CharacterController character, WeaponType t, bool checkRemovedEquipment = true /* Metadata: 0x0197A9C1 */, bool checkHiddenEquipment = false /* Metadata: 0x0197A9C2 */) => default; // 0x0000000186775AD0-0x0000000186776200
		public Equipment GetPlayerEquipment(VampireSurvivors.Objects.Characters.CharacterController character, WeaponType t, bool checkRemovedEquipment = false /* Metadata: 0x0197A9C3 */) => default; // 0x0000000186776200-0x00000001867766D0
		public int GetPickUpCount(VampireSurvivors.Data.ItemType t) => default; // 0x00000001867766D0-0x00000001867767B0
		private bool CheckForStage6Achievement() => default; // 0x00000001867767B0-0x0000000186776C00
	}
}
