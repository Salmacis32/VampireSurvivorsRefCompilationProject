/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public class SaveSerializer // TypeDefIndex: 18172
	{
		// Fields
		private StringWriter _stringWriter; // 0x10
		private JsonTextWriter _writer; // 0x18
		private PlayerOptionsData _pod; // 0x20
	
		// Constructors
		public SaveSerializer() {} // 0x00000001866EAB90-0x00000001866EACE0
	
		// Methods
		public static string Serialize(PlayerOptionsData playerOptionsData) => default; // 0x00000001866EACE0-0x00000001866EAD70
		public string SerializePOD(PlayerOptionsData pod, string prefix = "" /* Metadata: 0x0197876A */) => default; // 0x00000001866EAD70-0x00000001866EB120
		private void SerializeEnumArray<T>(List<T> array, List<T> exclude = null) {}
		private void SerializeEnumArrayAsIntArray<T>(List<T> array, List<T> exclude = null) {}
		private void SerializeEnumValArray<T>(List<T> array) {}
		private void SerializeUIntArray(List<uint> array) {} // 0x00000001866EB120-0x00000001866EB360
		private void SerializeObjectEnumInt<T>(Dictionary<T, int> obj) {}
		private void SerializeObjectEnumEnum<T1, T2>(Dictionary<T1, T2> obj) {}
		private void SerializeObjectEnumEnumArray<T, T2>(Dictionary<T, List<T2>> obj) {}
		private void SerializeObjectEnumIntArray<T, T2>(Dictionary<T, List<T2>> obj) {}
		private void saveDate() {} // 0x00000001866EB360-0x00000001866EB3A0
		private void Platform() {} // 0x00000001866EB3A0-0x00000001866EB3E0
		private void SaveSyncPlatformAchievements() {} // 0x00000001866EB3E0-0x00000001866EB420
		private void SaveOriginalPlatform() {} // 0x00000001866EB420-0x00000001866EB4B0
		private void SaveTouchedPlatforms() {} // 0x00000001866EB4B0-0x00000001866EB510
		private void itemInCollection() {} // 0x00000001866EB510-0x00000001866EB550
		private void itemInUnlocks() {} // 0x00000001866EB550-0x00000001866EB590
		private void itemInSecrets() {} // 0x00000001866EB590-0x00000001866EB5D0
		private void SelectedCharacter() {} // 0x00000001866EB5D0-0x00000001866EB660
		private void SelectedStage() {} // 0x00000001866EB660-0x00000001866EB6F0
		private void SelectedHyper() {} // 0x00000001866EB6F0-0x00000001866EB730
		private void SelectedHurry() {} // 0x00000001866EB730-0x00000001866EB770
		private void AcceptedEULA() {} // 0x00000001866EB770-0x00000001866EB7B0
		private void SelectedMazzo() {} // 0x00000001866EB7B0-0x00000001866EB7F0
		private void SelectedLimitBreak() {} // 0x00000001866EB7F0-0x00000001866EB830
		private void SelectedInverse() {} // 0x00000001866EB830-0x00000001866EB870
		private void SelectedReapers() {} // 0x00000001866EB870-0x00000001866EB8B0
		private void SelectedGoldenEggs() {} // 0x00000001866EB8B0-0x00000001866EB8F0
		private void SelectedSharePassives() {} // 0x00000001866EB8F0-0x00000001866EB930
		private void SelectedArcana() {} // 0x00000001866EB930-0x00000001866EB970
		private void SelectedRandomEvents() {} // 0x00000001866EB970-0x00000001866EB9B0
		private void SelectedRandomLevels() {} // 0x00000001866EB9B0-0x00000001866EB9F0
		private void SelectedBGMSave() {} // 0x00000001866EB9F0-0x00000001866EBA30
		private void SelectedBGM() {} // 0x00000001866EBA30-0x00000001866EBAC0
		private void SelectedBGMMod() {} // 0x00000001866EBAC0-0x00000001866EBB50
		private void SelectedMaxWeapons() {} // 0x00000001866EBB50-0x00000001866EBB90
		private void Fullscreen() {} // 0x00000001866EBB90-0x00000001866EBBD0
		private void Version() {} // 0x00000001866EBBD0-0x00000001866EBC10
		private void Coins() {} // 0x00000001866EBC10-0x00000001866EBC70
		private void LifetimeCoins() {} // 0x00000001866EBC70-0x00000001866EBCD0
		private void TotalCoins() {} // 0x00000001866EBCD0-0x00000001866EBD30
		private void BeginnersLuck() {} // 0x00000001866EBD30-0x00000001866EBD70
		private void RunFever() {} // 0x00000001866EBD70-0x00000001866EBDB0
		private void LifetimeSurvived() {} // 0x00000001866EBDB0-0x00000001866EBE10
		private void LifetimeHeal() {} // 0x00000001866EBE10-0x00000001866EBE70
		private void TrainHazardEnemiesHit() {} // 0x00000001866EBE70-0x00000001866EBED0
		private void TopLapsCarlo() {} // 0x00000001866EBED0-0x00000001866EBF10
		private void TotalLapsCarlo() {} // 0x00000001866EBF10-0x00000001866EBF50
		private void TopLapsHighway() {} // 0x00000001866EBF50-0x00000001866EBF90
		private void TotalLapsHighway() {} // 0x00000001866EBF90-0x00000001866EBFD0
		private void OwO() {} // 0x00000001866EBFD0-0x00000001866EC030
		private void CompletedHurries() {} // 0x00000001866EC030-0x00000001866EC070
		private void ReducePhysics() {} // 0x00000001866EC070-0x00000001866EC0B0
		private void ClassicMusic() {} // 0x00000001866EC0B0-0x00000001866EC0F0
		private void VisuallyInvertStages() {} // 0x00000001866EC0F0-0x00000001866EC130
		private void HideProgress() {} // 0x00000001866EC130-0x00000001866EC170
		private void SoundsEnabled() {} // 0x00000001866EC170-0x00000001866EC1B0
		private void MusicEnabled() {} // 0x00000001866EC1B0-0x00000001866EC1F0
		private void SoundsVolume() {} // 0x00000001866EC1F0-0x00000001866EC230
		private void MusicVolume() {} // 0x00000001866EC230-0x00000001866EC270
		private void FlashingVFXEnabled() {} // 0x00000001866EC270-0x00000001866EC2B0
		private void JoystickVisible() {} // 0x00000001866EC2B0-0x00000001866EC2F0
		private void SelectedJoystickType() {} // 0x00000001866EC2F0-0x00000001866EC390
		private void DamageNumbersEnabled() {} // 0x00000001866EC390-0x00000001866EC3D0
		private void GlimmerCarouselEnabled() {} // 0x00000001866EC3D0-0x00000001866EC410
		private void StreamSafeEnabled() {} // 0x00000001866EC410-0x00000001866EC450
		private void hideXPBar() {} // 0x00000001866EC450-0x00000001866EC490
		private void CheatCodeUsed() {} // 0x00000001866EC490-0x00000001866EC4D0
		private void HasKilledTheFinalBoss() {} // 0x00000001866EC4D0-0x00000001866EC510
		private void HasSeenFinalFireworks() {} // 0x00000001866EC510-0x00000001866EC550
		private void Language() {} // 0x00000001866EC550-0x00000001866EC590
		private void ShowQuitDescription() {} // 0x00000001866EC590-0x00000001866EC5D0
		private void HideCompletedAchievements() {} // 0x00000001866EC5D0-0x00000001866EC610
		private void PlayedRNJ() {} // 0x00000001866EC610-0x00000001866EC650
		private void ShowPickups() {} // 0x00000001866EC650-0x00000001866EC690
		private void ShowSmallMapIcons() {} // 0x00000001866EC690-0x00000001866EC6D0
		private void LongestFever() {} // 0x00000001866EC6D0-0x00000001866EC710
		private void HighestFever() {} // 0x00000001866EC710-0x00000001866EC750
		private void HasUsedMirror() {} // 0x00000001866EC750-0x00000001866EC790
		private void HasUsedTrumpet() {} // 0x00000001866EC790-0x00000001866EC7D0
		private void BoughtCharacters() {} // 0x00000001866EC7D0-0x00000001866EC830
		private void BoughtPowerups() {} // 0x00000001866EC830-0x00000001866ECA60
		private void CollectedWeapons() {} // 0x00000001866ECA60-0x00000001866ECAC0
		private void UnlockedWeapons() {} // 0x00000001866ECAC0-0x00000001866ECB20
		private void UnlockedCharacters() {} // 0x00000001866ECB20-0x00000001866ECD70
		private void OpenedCoffins() {} // 0x00000001866ECD70-0x00000001866ECDD0
		private void CollectedItems() {} // 0x00000001866ECDD0-0x00000001866ECE30
		private void Achievements() {} // 0x00000001866ECE30-0x00000001866ECE90
		private void Secrets() {} // 0x00000001866ECE90-0x00000001866ECEF0
		private void UnlockedStages() {} // 0x00000001866ECEF0-0x00000001866ECF50
		private void UnlockedHypers() {} // 0x00000001866ECF50-0x00000001866ECFB0
		private void UnlockedPowerUpRanks() {} // 0x00000001866ECFB0-0x00000001866ED010
		private void DisabledPowerups() {} // 0x00000001866ED010-0x00000001866ED070
		private void UnlockedArcanas() {} // 0x00000001866ED070-0x00000001866ED0D0
		private void KillCount() {} // 0x00000001866ED0D0-0x00000001866ED130
		private void PickupCount() {} // 0x00000001866ED130-0x00000001866ED190
		private void DestroyedCount() {} // 0x00000001866ED190-0x00000001866ED1F0
		private void StageCompletionLog() {} // 0x00000001866ED1F0-0x00000001866ED250
		private void CharacterStageData() {} // 0x00000001866ED250-0x00000001866ED9D0
		private void CharacterEnemiesKilled() {} // 0x00000001866ED9D0-0x00000001866EDA30
		private void CharacterSurvivedMinutes() {} // 0x00000001866EDA30-0x00000001866EDA90
		private void MusicSelectionPerStage() {} // 0x00000001866EDA90-0x00000001866EDAE0
		private void checksum() {} // 0x00000001866EDAE0-0x00000001866EDB20
		private void EggData() {} // 0x00000001866EDB20-0x00000001866EE110
		private void Didit() {} // 0x00000001866EE110-0x00000001866EE150
		private void Seals() {} // 0x00000001866EE150-0x00000001866EE190
		private void SealedItems() {} // 0x00000001866EE190-0x00000001866EE1F0
		private void SealedWeapons() {} // 0x00000001866EE1F0-0x00000001866EE250
		private void UnlockedSkins() {} // 0x00000001866EE250-0x00000001866EE2B0
		private void UnlockedSkinsV2() {} // 0x00000001866EE2B0-0x00000001866EE310
		private void SelectedSkins() {} // 0x00000001866EE310-0x00000001866EE370
		private void SelectedSkinsV2() {} // 0x00000001866EE370-0x00000001866EE3D0
		private void HideAdsButtons() {} // 0x00000001866EE3D0-0x00000001866EE410
		private void ScreenShakeEnabled() {} // 0x00000001866EE410-0x00000001866EE450
		private void ControllerVibrationEnabled() {} // 0x00000001866EE450-0x00000001866EE490
		private void AssignControllerToPlayer1() {} // 0x00000001866EE490-0x00000001866EE4D0
		private void ShowPlayerIndicators() {} // 0x00000001866EE4D0-0x00000001866EE510
		private void PermanentCoopOutlines() {} // 0x00000001866EE510-0x00000001866EE550
		private void TintUISelection() {} // 0x00000001866EE550-0x00000001866EE590
		private void PlayerColours() {} // 0x00000001866EE590-0x00000001866EE630
		private void SequentialChestMode() {} // 0x00000001866EE630-0x00000001866EE670
		private void WriteFloat(float value) {} // 0x00000001866EE670-0x00000001866EE6C0
		private void DisableMovingBackground() {} // 0x00000001866EE6C0-0x00000001866EE700
		private void DisableBlood() {} // 0x00000001866EE700-0x00000001866EE740
		private void BorderType() {} // 0x00000001866EE740-0x00000001866EE7E0
		private void PixelFont() {} // 0x00000001866EE7E0-0x00000001866EE820
		private void DisplayDefangedEnemies() {} // 0x00000001866EE820-0x00000001866EE860
		private void SelectedAdventureType() {} // 0x00000001866EE860-0x00000001866EE8F0
		private void AdventureProgress() {} // 0x00000001866EE8F0-0x00000001866EE950
		private void AdventuresSaveData() {} // 0x00000001866EE950-0x00000001866EEC40
		private void HasSeenAdventureReveal() {} // 0x00000001866EEC40-0x00000001866EEC80
		private void AdventureCompletionCount() {} // 0x00000001866EEC80-0x00000001866EECC0
		private void CollectionFilterMode() {} // 0x00000001866EECC0-0x00000001866EED60
		private void HideUnavailableAdventures() {} // 0x00000001866EED60-0x00000001866EEDA0
		private void TotalAdventurePlaytime() {} // 0x00000001866EEDA0-0x00000001866EEDE0
		private void AllTimeAdventurePlaytime() {} // 0x00000001866EEDE0-0x00000001866EEE20
		private void AscensionPointsAllocation() {} // 0x00000001866EEE20-0x00000001866EEE80
		private void HasSeenAdventuresIntroTutorial() {} // 0x00000001866EEE80-0x00000001866EEEC0
		private void AdventureStars() {} // 0x00000001866EEEC0-0x00000001866EEF00
		private void HasPlayedStage3() {} // 0x00000001866EEF00-0x00000001866EEF40
		private void CompletedAdventures() {} // 0x00000001866EEF40-0x00000001866EEFA0
		private void HasSeenMerchantTutorial() {} // 0x00000001866EEFA0-0x00000001866EEFE0
		private void SeenAscensionPopups() {} // 0x00000001866EEFE0-0x00000001866EF040
		private void StageLighting() {} // 0x00000001866EF040-0x00000001866EF080
		private void HasSeenDarkanaTransition() {} // 0x00000001866EF080-0x00000001866EF0C0
		private void HasFixedSkinIds() {} // 0x00000001866EF0C0-0x00000001866EF100
		private void BoughtSkins() {} // 0x00000001866EF100-0x00000001866EF160
		private void BanishedContentGroups() {} // 0x00000001866EF160-0x00000001866EF1C0
		private void ContentGroupSealedItems() {} // 0x00000001866EF1C0-0x00000001866EF220
		private void ContentGroupSealedWeapons() {} // 0x00000001866EF220-0x00000001866EF280
		private void SelectedBGMPlayback() {} // 0x00000001866EF280-0x00000001866EF310
		private void PlayBGMOnlyDuringRun() {} // 0x00000001866EF310-0x00000001866EF350
		private void TP_FrozenShadesCount() {} // 0x00000001866EF350-0x00000001866EF390
		private void TP_AxeArmorCount() {} // 0x00000001866EF390-0x00000001866EF3D0
		private void TP_SniperCount() {} // 0x00000001866EF3D0-0x00000001866EF410
		private void TP_PortraitsCount() {} // 0x00000001866EF410-0x00000001866EF450
		private void LibraryMerchantGoldSpent() {} // 0x00000001866EF450-0x00000001866EF490
		private void EME_NextBossBiome() {} // 0x00000001866EF490-0x00000001866EF4D0
		private void WW_ZoneProgress() {} // 0x00000001866EF4D0-0x00000001866EF510
	}
}
