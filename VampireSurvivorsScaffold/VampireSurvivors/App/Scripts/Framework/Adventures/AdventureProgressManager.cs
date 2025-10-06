/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Adventures
{
	[UsedImplicitly]
	public class AdventureProgressManager : IInitializable, IDisposable // TypeDefIndex: 18836
	{
		// Fields
		[Inject]
		private DataManager _dataManager; // 0x10
		[Inject]
		private AdventureManager _adventureManager; // 0x18
		[Inject]
		private PlayerOptions _playerOptions; // 0x20
		private AchievementManager _achievementManager; // 0x28
	
		// Properties
		public Dictionary<AdventureAchievementType, AchievementData> Achieved { get; set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
	
		// Constructors
		public AdventureProgressManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void RunChecks(CharacterController currentCharacter, AchievementManager achievementManager, Dictionary<AdventureAchievementType, AchievementData> achieved, bool forceUnlockAll = false /* Metadata: 0x0197AFC9 */) {} // 0x000000018684C950-0x000000018684CB40
		public void RunProgressDataChecks(CharacterController currentCharacter, AdventureType adventureType, Dictionary<AdventureAchievementType, AchievementData> achieved, bool forceUnlockAll = false /* Metadata: 0x0197AFCA */) {} // 0x000000018684CB40-0x000000018684D100
		public void UnlockAll(Dictionary<AdventureAchievementType, AchievementData> achieved) {} // 0x000000018684D100-0x000000018684D380
		private bool UnlockRequirementsMet(AchievementData achievementData, CharacterController currentCharacter) => default; // 0x000000018684D380-0x000000018684E090
		private bool checkIfCharacterInPlay(VampireSurvivors.Data.CharacterType requiredCharacterType) => default; // 0x000000018684E090-0x000000018684E220
		private bool CheckPlayInStage(StageType requiredStage) => default; // 0x000000018684E220-0x000000018684E2A0
		private List<EnemyType> GetEnemyTypesIncludingVariants(EnemyType baseRequiredEnemyType) => default; // 0x000000018684E2A0-0x000000018684E650
		private void Unlock(AdventureAchievementType adventureAchievementType, AchievementData achievementData, AdventureData adventureData, PlayerOptionsData config) {} // 0x000000018684E650-0x000000018684E980
		private bool HasAlreadyUnlocked(AdventureAchievementType adventureAchievementType, PlayerOptionsData config) => default; // 0x000000018684E980-0x000000018684E9F0
	}
}
