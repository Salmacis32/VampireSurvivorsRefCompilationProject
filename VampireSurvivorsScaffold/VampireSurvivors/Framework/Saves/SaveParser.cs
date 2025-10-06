/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public class SaveParser // TypeDefIndex: 18171
	{
		// Fields
		private JsonTextReader _reader; // 0x10
		private PlayerOptionsData _pod; // 0x18
	
		// Constructors
		public SaveParser() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public static PlayerOptionsData Parse(string data) => default; // 0x00000001866E3330-0x00000001866E3390
		public static PlayerOptionsData ParseAdventureData(JsonTextReader reader) => default; // 0x00000001866E3390-0x00000001866E33F0
		public PlayerOptionsData ParsePod(string data) => default; // 0x00000001866E33F0-0x00000001866E3750
		public PlayerOptionsData ParseAdventurePod(JsonTextReader reader) => default; // 0x00000001866E3750-0x00000001866E3A00
		private void PostParseFixes() {} // 0x00000001866E3A00-0x00000001866E48D0
		private void ParseProp(string propName) {} // 0x00000001866E48D0-0x00000001866E4990
		private T ParseEnum<T>(object value) => default;
		private T ParseIntToEnum<T>(object value) => default;
		private bool ParseBool(object value) => default; // 0x00000001866E4990-0x00000001866E4A70
		private int ParseInt(object value) => default; // 0x00000001866E4A70-0x00000001866E4BC0
		private uint ParseUInt(object value) => default; // 0x00000001866E4BC0-0x00000001866E4D10
		private float ParseFloat(object value) => default; // 0x00000001866E4D10-0x00000001866E5300
		private double ParseDouble(object value) => default; // 0x00000001866E5300-0x00000001866E5350
		private string ParseString(object value) => default; // 0x00000001866E5350-0x00000001866E53E0
		private void ParseEnumArray<T>(List<T> target, bool allowDuplicate = false /* Metadata: 0x01978768 */) {}
		private void ParseUIntArray(List<uint> target) {} // 0x00000001866E53E0-0x00000001866E54D0
		private void ParseObjectEnumInt<T>(Dictionary<T, int> target) {}
		private void ParseObjectEnumEnum<T1, T2>(Dictionary<T1, T2> target) {}
		private void ParseObjectEnumEnumArray<T1, T2>(Dictionary<T1, List<T2>> target, bool allowDuplicate = false /* Metadata: 0x01978769 */) {}
		private void ParseCharacterEggData() {} // 0x00000001866E54D0-0x00000001866E59E0
		private void ParseCharacterStageData() {} // 0x00000001866E59E0-0x00000001866E6280
		private void saveDate() {} // 0x00000001866E6280-0x00000001866E6320
		private void Platform() {} // 0x00000001866E6320-0x00000001866E63C0
		private void SaveSyncPlatformAchievements() {} // 0x00000001866E63C0-0x00000001866E6420
		private void SaveOriginalPlatform() {} // 0x00000001866E6420-0x00000001866E64D0
		private void SaveTouchedPlatforms() {} // 0x00000001866E64D0-0x00000001866E6520
		private void itemInCollection() {} // 0x00000001866E6520-0x00000001866E6580
		private void itemInUnlocks() {} // 0x00000001866E6580-0x00000001866E65E0
		private void itemInSecrets() {} // 0x00000001866E65E0-0x00000001866E6640
		private void SelectedCharacter() {} // 0x00000001866E6640-0x00000001866E66C0
		private void SelectedStage() {} // 0x00000001866E66C0-0x00000001866E6740
		private void SelectedHyper() {} // 0x00000001866E6740-0x00000001866E67A0
		private void SelectedHurry() {} // 0x00000001866E67A0-0x00000001866E6800
		private void AcceptedEULA() {} // 0x00000001866E6800-0x00000001866E6860
		private void SelectedMazzo() {} // 0x00000001866E6860-0x00000001866E68C0
		private void SelectedLimitBreak() {} // 0x00000001866E68C0-0x00000001866E6920
		private void SelectedInverse() {} // 0x00000001866E6920-0x00000001866E6980
		private void SelectedReapers() {} // 0x00000001866E6980-0x00000001866E69E0
		private void SelectedGoldenEggs() {} // 0x00000001866E69E0-0x00000001866E6A40
		private void SelectedSharePassives() {} // 0x00000001866E6A40-0x00000001866E6AA0
		private void SelectedArcana() {} // 0x00000001866E6AA0-0x00000001866E6B00
		private void SelectedRandomEvents() {} // 0x00000001866E6B00-0x00000001866E6B60
		private void SelectedRandomLevels() {} // 0x00000001866E6B60-0x00000001866E6BC0
		private void SelectedBGMSave() {} // 0x00000001866E6BC0-0x00000001866E6C20
		private void SelectedBGM() {} // 0x00000001866E6C20-0x00000001866E6CA0
		private void SelectedBGMMod() {} // 0x00000001866E6CA0-0x00000001866E6D20
		private void SelectedMaxWeapons() {} // 0x00000001866E6D20-0x00000001866E6D80
		private void Fullscreen() {} // 0x00000001866E6D80-0x00000001866E6DE0
		private void Version() {} // 0x00000001866E6DE0-0x00000001866E6E40
		private void Coins() {} // 0x00000001866E6E40-0x00000001866E6EA0
		private void LifetimeCoins() {} // 0x00000001866E6EA0-0x00000001866E6F00
		private void TotalCoins() {} // 0x00000001866E6F00-0x00000001866E6F60
		private void BeginnersLuck() {} // 0x00000001866E6F60-0x00000001866E6FC0
		private void RunFever() {} // 0x00000001866E6FC0-0x00000001866E7020
		private void LifetimeSurvived() {} // 0x00000001866E7020-0x00000001866E7080
		private void LifetimeHeal() {} // 0x00000001866E7080-0x00000001866E70E0
		private void TrainHazardEnemiesHit() {} // 0x00000001866E70E0-0x00000001866E7140
		private void TopLapsCarlo() {} // 0x00000001866E7140-0x00000001866E71A0
		private void TotalLapsCarlo() {} // 0x00000001866E71A0-0x00000001866E7200
		private void TopLapsHighway() {} // 0x00000001866E7200-0x00000001866E7260
		private void TotalLapsHighway() {} // 0x00000001866E7260-0x00000001866E72C0
		private void OwO() {} // 0x00000001866E72C0-0x00000001866E7320
		private void CompletedHurries() {} // 0x00000001866E7320-0x00000001866E7380
		private void ReducePhysics() {} // 0x00000001866E7380-0x00000001866E73E0
		private void ClassicMusic() {} // 0x00000001866E73E0-0x00000001866E7440
		private void VisuallyInvertStages() {} // 0x00000001866E7440-0x00000001866E74A0
		private void HideProgress() {} // 0x00000001866E74A0-0x00000001866E7500
		private void SoundsEnabled() {} // 0x00000001866E7500-0x00000001866E7560
		private void MusicEnabled() {} // 0x00000001866E7560-0x00000001866E75C0
		private void SoundsVolume() {} // 0x00000001866E75C0-0x00000001866E7620
		private void MusicVolume() {} // 0x00000001866E7620-0x00000001866E7680
		private void FlashingVFXEnabled() {} // 0x00000001866E7680-0x00000001866E76E0
		private void JoystickVisible() {} // 0x00000001866E76E0-0x00000001866E7740
		private void SelectedJoystickType() {} // 0x00000001866E7740-0x00000001866E77C0
		private void DamageNumbersEnabled() {} // 0x00000001866E77C0-0x00000001866E7820
		private void GlimmerCarouselEnabled() {} // 0x00000001866E7820-0x00000001866E7880
		private void StreamSafeEnabled() {} // 0x00000001866E7880-0x00000001866E78E0
		private void hideXPBar() {} // 0x00000001866E78E0-0x00000001866E7900
		private void CheatCodeUsed() {} // 0x00000001866E7900-0x00000001866E7960
		private void HasKilledTheFinalBoss() {} // 0x00000001866E7960-0x00000001866E79C0
		private void HasSeenFinalFireworks() {} // 0x00000001866E79C0-0x00000001866E7A20
		private void Language() {} // 0x00000001866E7A20-0x00000001866E7AD0
		private void ShowQuitDescription() {} // 0x00000001866E7AD0-0x00000001866E7B30
		private void HideCompletedAchievements() {} // 0x00000001866E7B30-0x00000001866E7B90
		private void PlayedRNJ() {} // 0x00000001866E7B90-0x00000001866E7BF0
		private void ShowPickups() {} // 0x00000001866E7BF0-0x00000001866E7C50
		private void ShowSmallMapIcons() {} // 0x00000001866E7C50-0x00000001866E7CB0
		private void LongestFever() {} // 0x00000001866E7CB0-0x00000001866E7D10
		private void HighestFever() {} // 0x00000001866E7D10-0x00000001866E7D70
		private void HasUsedMirror() {} // 0x00000001866E7D70-0x00000001866E7DD0
		private void HasUsedTrumpet() {} // 0x00000001866E7DD0-0x00000001866E7E30
		private void BoughtCharacters() {} // 0x00000001866E7E30-0x00000001866E7E80
		private void BoughtPowerups() {} // 0x00000001866E7E80-0x00000001866E8290
		private void CollectedWeapons() {} // 0x00000001866E8290-0x00000001866E82E0
		private void UnlockedWeapons() {} // 0x00000001866E82E0-0x00000001866E8330
		private void UnlockedCharacters() {} // 0x00000001866E8330-0x00000001866E8380
		private void OpenedCoffins() {} // 0x00000001866E8380-0x00000001866E83D0
		private void CollectedItems() {} // 0x00000001866E83D0-0x00000001866E8420
		private void Achievements() {} // 0x00000001866E8420-0x00000001866E8470
		private void Secrets() {} // 0x00000001866E8470-0x00000001866E84C0
		private void UnlockedStages() {} // 0x00000001866E84C0-0x00000001866E8510
		private void UnlockedHypers() {} // 0x00000001866E8510-0x00000001866E8560
		private void UnlockedPowerUpRanks() {} // 0x00000001866E8560-0x00000001866E85B0
		private void DisabledPowerups() {} // 0x00000001866E85B0-0x00000001866E8B50
		private void UnlockedArcanas() {} // 0x00000001866E8B50-0x00000001866E8DA0
		private void KillCount() {} // 0x00000001866E8DA0-0x00000001866E8E00
		private void PickupCount() {} // 0x00000001866E8E00-0x00000001866E8E60
		private void DestroyedCount() {} // 0x00000001866E8E60-0x00000001866E8EC0
		private void StageCompletionLog() {} // 0x00000001866E8EC0-0x00000001866E8F20
		private void CharacterStageData() {} // 0x00000001866E8F20-0x00000001866E90E0
		private void CharacterEnemiesKilled() {} // 0x00000001866E90E0-0x00000001866E9140
		private void CharacterSurvivedMinutes() {} // 0x00000001866E9140-0x00000001866E91A0
		private void MusicSelectionPerStage() {} // 0x0000000180B15170-0x0000000180B15180
		private void checksum() {} // 0x00000001866E91A0-0x00000001866E9250
		private void EggData() {} // 0x00000001866E9250-0x00000001866E93D0
		private void Didit() {} // 0x00000001866E93D0-0x00000001866E9430
		private void Seals() {} // 0x00000001866E9430-0x00000001866E9490
		private void SealedItems() {} // 0x00000001866E9490-0x00000001866E94E0
		private void SealedWeapons() {} // 0x00000001866E94E0-0x00000001866E9530
		private void UnlockedSkins() {} // 0x00000001866E9530-0x00000001866E9590
		private void UnlockedSkinsV2() {} // 0x00000001866E9590-0x00000001866E95F0
		private void SelectedSkins() {} // 0x00000001866E95F0-0x00000001866E9650
		private void SelectedSkinsV2() {} // 0x00000001866E9650-0x00000001866E96B0
		private void HideAdsButtons() {} // 0x00000001866E96B0-0x00000001866E9710
		private void ScreenShakeEnabled() {} // 0x00000001866E9710-0x00000001866E9770
		private void ControllerVibrationEnabled() {} // 0x00000001866E9770-0x00000001866E97D0
		private void AssignControllerToPlayer1() {} // 0x00000001866E97D0-0x00000001866E9830
		private void ShowPlayerIndicators() {} // 0x00000001866E9830-0x00000001866E9890
		private void PermanentCoopOutlines() {} // 0x00000001866E9890-0x00000001866E98F0
		private void TintUISelection() {} // 0x00000001866E98F0-0x00000001866E9950
		private void PlayerColours() {} // 0x00000001866E9950-0x00000001866E9B30
		private void SequentialChestMode() {} // 0x00000001866E9B30-0x00000001866E9B90
		private void DisableMovingBackground() {} // 0x00000001866E9B90-0x00000001866E9BF0
		private void DisableBlood() {} // 0x00000001866E9BF0-0x00000001866E9C50
		private void BorderType() {} // 0x00000001866E9C50-0x00000001866E9CD0
		private void PixelFont() {} // 0x00000001866E9CD0-0x00000001866E9D30
		private void DisplayDefangedEnemies() {} // 0x00000001866E9D30-0x00000001866E9D90
		private void StageLighting() {} // 0x00000001866E9D90-0x00000001866E9DF0
		private void SelectedAdventureType() {} // 0x00000001866E9DF0-0x00000001866E9EA0
		private void AdventureProgress() {} // 0x00000001866E9EA0-0x00000001866E9EF0
		private void AdventuresSaveData() {} // 0x00000001866E9EF0-0x00000001866EA120
		private void HasSeenAdventureReveal() {} // 0x00000001866EA120-0x00000001866EA180
		private void AdventureCompletionCount() {} // 0x00000001866EA180-0x00000001866EA1E0
		private void CollectionFilterMode() {} // 0x00000001866EA1E0-0x00000001866EA260
		private void HideUnavailableAdventures() {} // 0x00000001866EA260-0x00000001866EA2C0
		private void TotalAdventurePlaytime() {} // 0x00000001866EA2C0-0x00000001866EA320
		private void AllTimeAdventurePlaytime() {} // 0x00000001866EA320-0x00000001866EA380
		private void AscensionPointsAllocation() {} // 0x00000001866EA380-0x00000001866EA3E0
		private void HasSeenAdventuresIntroTutorial() {} // 0x00000001866EA3E0-0x00000001866EA440
		private void AdventureStars() {} // 0x00000001866EA440-0x00000001866EA4A0
		private void HasPlayedStage3() {} // 0x00000001866EA4A0-0x00000001866EA500
		private void CompletedAdventures() {} // 0x00000001866EA500-0x00000001866EA550
		private void HasSeenMerchantTutorial() {} // 0x00000001866EA550-0x00000001866EA5B0
		private void SeenAscensionPopups() {} // 0x00000001866EA5B0-0x00000001866EA600
		private void HasSeenDarkanaTransition() {} // 0x00000001866EA600-0x00000001866EA660
		private void HasFixedSkinIds() {} // 0x00000001866EA660-0x00000001866EA6C0
		private void BoughtSkins() {} // 0x00000001866EA6C0-0x00000001866EA710
		private void BanishedContentGroups() {} // 0x00000001866EA710-0x00000001866EA760
		private void ContentGroupSealedItems() {} // 0x00000001866EA760-0x00000001866EA7B0
		private void ContentGroupSealedWeapons() {} // 0x00000001866EA7B0-0x00000001866EA800
		private void SelectedBGMPlayback() {} // 0x00000001866EA800-0x00000001866EA880
		private void PlayBGMOnlyDuringRun() {} // 0x00000001866EA880-0x00000001866EA8E0
		private void TP_FrozenShadesCount() {} // 0x00000001866EA8E0-0x00000001866EA940
		private void TP_AxeArmorCount() {} // 0x00000001866EA940-0x00000001866EA9A0
		private void TP_SniperCount() {} // 0x00000001866EA9A0-0x00000001866EAA00
		private void TP_PortraitsCount() {} // 0x00000001866EAA00-0x00000001866EAA60
		private void LibraryMerchantGoldSpent() {} // 0x00000001866EAA60-0x00000001866EAAC0
		private void EME_NextBossBiome() {} // 0x00000001866EAAC0-0x00000001866EAB20
		private void WW_ZoneProgress() {} // 0x00000001866EAB20-0x00000001866EAB80
	}
}
