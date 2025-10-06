/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Profiling;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[UsedImplicitly]
	public class PlayerOptions : IInitializable, IDisposable // TypeDefIndex: 15095
	{
		// Fields
		[Inject]
		private SignalBus _signalBus; // 0x28
		[Inject]
		private GameSessionData _gameSessionData; // 0x30
		[Inject]
		private DataManager _dataManager; // 0x38
		[Inject]
		private PlayerStats _playerStats; // 0x40
		[Inject]
		private AdventureManager _adventureManager; // 0x48
		private PlayerOptionsData _mainGameConfig; // 0x50
		private PlayerOptionsData _hostGameConfig; // 0x58
		private PlayerOptionsData _hostGameConfigAtRunStart; // 0x60
		private PlayerOptionsData _onlineClientWithRunDataConfig; // 0x68
		public const string USER_OPTIONS = "USER_OPTIONS"; // Metadata: 0x019772FA
		private static readonly ProfilerMarker MarkerSave; // 0x10
		private PlayerOptionsData _currentAdventureSaveData; // 0x78
	
		// Properties
		public DataManager dataManager { get => default; } // 0x0000000180B15560-0x0000000180B15570 
		public PlayerOptionsData MainGameConfig { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public bool IsConfigReady { get => default; } // 0x0000000186A03760-0x0000000186A037C0 
		public PlayerOptionsData ConfigDuringRun { get => default; } // 0x0000000186A037C0-0x0000000186A03820 
		public PlayerOptionsData Config { get => default; } // 0x0000000186A03820-0x0000000186A03890 
		public PlayerStats PlayerStats { get => default; } // 0x0000000180B15750-0x0000000180B15760 
		public bool JustGotTrumpet { get; set; } // 0x00000001831F88E0-0x00000001831F88F0 0x00000001831F88F0-0x00000001831F8900
		public bool JustGotMirror { get; set; } // 0x0000000184BBA180-0x0000000184BBA190 0x0000000184BBA190-0x0000000184BBA1A0
		public bool JustGotJubilee { get; set; } // 0x0000000184B5DE30-0x0000000184B5DE40 0x0000000184B5DE40-0x0000000184B5DE50
		public bool IsInitialized { get; set; } // 0x0000000184BBA1A0-0x0000000184BBA1B0 0x0000000184BBA1B0-0x0000000184BBA1C0
		public bool IsInvertedWithVisuals { get => default; } // 0x0000000186A03890-0x0000000186A038E0 
		public PlayerOptionsData CurrentAdventureSaveData { get => default; set {} } // 0x00000001819A0360-0x00000001819A0370 0x0000000186A038E0-0x0000000186A039B0
	
		// Events
		public static event OnValueChanged GoldUpdated;
		public event OnValueChanged RunGoldUpdated;
		public event OnValueChanged PowerUpPurchased;
		public event OnValueChanged PowerUpsRefunded;
		public static event OnValueChanged AdventureStarsUpdated;
		public event OnInitialized PlayerOptionsInitialized;
	
		// Nested types
		public delegate void OnValueChanged(); // TypeDefIndex: 15093; 0x000000018196C270-0x000000018196C280
	
		public delegate void OnInitialized(); // TypeDefIndex: 15094; 0x000000018196C270-0x000000018196C280
	
		// Constructors
		public PlayerOptions() {} // 0x0000000180B15170-0x0000000180B15180
		static PlayerOptions() {} // 0x0000000186A12FA0-0x0000000186A13070
	
		// Methods
		public void Initialize() {} // 0x0000000186A039B0-0x0000000186A053B0
		public void Dispose() {} // 0x0000000186A053B0-0x0000000186A06620
		public void AutoSelectStage() {} // 0x0000000186A06620-0x0000000186A066A0
		public void ClearSaveData(bool deleteAdventureData = false /* Metadata: 0x019772F0 */) {} // 0x0000000186A066A0-0x0000000186A068A0
		public void ApplyClientConfigWithRunProgress() {} // 0x0000000186A068A0-0x0000000186A069B0
		public void ApplyConfig(PlayerOptionsData config, bool adventureMode = false /* Metadata: 0x019772F1 */, bool hostConfig = false /* Metadata: 0x019772F2 */, bool onlineClientWithRunData = false /* Metadata: 0x019772F3 */) {} // 0x0000000186A069B0-0x0000000186A06E20
		private void FixCoinOverflow() {} // 0x0000000186A06E20-0x0000000186A070E0
		public void FixPlayerOptionsData() {} // 0x0000000186A070E0-0x0000000186A08190
		private SkinType FixSkinMapping(VampireSurvivors.Data.CharacterType characterType, SkinType id) => default; // 0x0000000186A08190-0x0000000186A082A0
		private void TouchPlatform() {} // 0x0000000186A082A0-0x0000000186A08470
		public void ApplyUnlocksToData() {} // 0x0000000186A08470-0x0000000186A09BE0
		public void ApplyLoadedOptions() {} // 0x0000000186A09BE0-0x0000000186A09EC0
		public void AddRunHunger(int amount) {} // 0x0000000186A09EC0-0x0000000186A09EF0
		public void SetShowGuides(bool b) {} // 0x0000000186A09EF0-0x0000000186A0A030
		public void SetShowPickups(bool b) {} // 0x0000000186A0A030-0x0000000186A0A160
		public int GetMaxSeals() => default; // 0x0000000186A0A160-0x0000000186A0A520
		public int GetUsedSeals() => default; // 0x0000000186A0A520-0x0000000186A0A5B0
		public int GetPowerUpMaxRank(PowerUpType type) => default; // 0x0000000186A0A5B0-0x0000000186A0AB20
		public void AddHeal(float value) {} // 0x0000000186A0AB20-0x0000000186A0AB60
		public void TrackEnemyKill(EnemyType enemyType) {} // 0x0000000186A0AB60-0x0000000186A0AB90
		public void TrackEnemyKill(EnemyType enemyType, PlayerOptionsData config) {} // 0x0000000186A0AB90-0x0000000186A0AD70
		public void TrackItemPickup(VampireSurvivors.Data.ItemType itemType, PlayerOptionsData config, bool trackRunPickup = true /* Metadata: 0x019772F4 */) {} // 0x0000000186A0AD70-0x0000000186A0AF70
		public void TrackItemPickup(VampireSurvivors.Data.ItemType itemType, bool trackRunPickup = true /* Metadata: 0x019772F5 */) {} // 0x0000000186A0AF70-0x0000000186A0AFC0
		public void IncreaseDestroyedPropCount(PropType propType) {} // 0x0000000186A0AFC0-0x0000000186A0B220
		public void ResetDestroyedPropCount(PropType propType) {} // 0x0000000186A0B220-0x0000000186A0B360
		public void UnlockArcana(ArcanaType arcanaType, PlayerOptionsData config) {} // 0x0000000186A0B360-0x0000000186A0B3F0
		public void UnlockArcana(ArcanaType arcanaType) {} // 0x0000000186A0B3F0-0x0000000186A0B480
		public void UnlockSkin(VampireSurvivors.Data.CharacterType c, SkinType t, PlayerOptionsData config = null) {} // 0x0000000186A0B480-0x0000000186A0B8E0
		public void ClearRunData() {} // 0x0000000186A0B8E0-0x0000000186A0BB80
		public HashSet<AchievementType> GetUnlockedAchievements() => default; // 0x0000000186A0BB80-0x0000000186A0BDF0
		public Dictionary<PowerUpType, PowerUpLevel> GetBoughtPowerUps() => default; // 0x0000000186A0BDF0-0x0000000186A0BFF0
		public void Save(bool commitImmediately = true /* Metadata: 0x019772F6 */, bool createBackup = false /* Metadata: 0x019772F7 */) {} // 0x0000000186A0BFF0-0x0000000186A0C480
		public void BuildHostPlayerConfig(HostPlayerOptions hostPlayerOptions) {} // 0x0000000186A0C480-0x0000000186A0CE10
		public PlayerOptionsData GetClientPlayerOptionsWithRunDataApplied() => default; // 0x0000000186A0CE10-0x0000000186A0E600
		public void RemoveOnlineClientRunDataConfig() {} // 0x00000001828DC130-0x00000001828DC190
		public void DestroyOnlineConfigs() {} // 0x0000000186A0E600-0x0000000186A0E840
		public bool IsBought(VampireSurvivors.Data.CharacterType characterType, bool ignoreSkins, PlayerOptionsData config) => default; // 0x0000000186A0E840-0x0000000186A0E9B0
		public bool IsBought(VampireSurvivors.Data.CharacterType characterType, bool ignoreSkins = false /* Metadata: 0x019772F8 */) => default; // 0x0000000186A0E9B0-0x0000000186A0EB30
		public bool IsUnlocked(VampireSurvivors.Data.CharacterType characterType, PlayerOptionsData config) => default; // 0x0000000186A0EB30-0x0000000186A0EB90
		public bool IsUnlocked(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186A0EB90-0x0000000186A0EC00
		public void UnlockCharacter(VampireSurvivors.Data.CharacterType characterType, PlayerOptionsData config) {} // 0x0000000186A0EC00-0x0000000186A0EC90
		public void UnlockCharacter(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186A0EC90-0x0000000186A0ED20
		public void RegisterCoffinOpen(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186A0ED20-0x0000000186A0EE10
		public void BuyCharacter(VampireSurvivors.Data.CharacterType characterType, PlayerOptionsData config) {} // 0x0000000186A0EE10-0x0000000186A0EEA0
		public void BuyCharacter(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186A0EEA0-0x0000000186A0EF40
		public void BuySkin(SkinType skinType, PlayerOptionsData config) {} // 0x0000000186A0EF40-0x0000000186A0F060
		public void BuySkin(SkinType skinType) {} // 0x0000000186A0F060-0x0000000186A0F1A0
		public void RevealCharacter(VampireSurvivors.Data.CharacterType characterType, PlayerOptionsData config) {} // 0x0000000186A0F1A0-0x0000000186A0F230
		public void RevealCharacter(VampireSurvivors.Data.CharacterType characterType) {} // 0x0000000186A0F230-0x0000000186A0F2D0
		public void AddGoldenEggToCharacter(VampireSurvivors.Data.CharacterType character, string attribute, float value) {} // 0x0000000186A0F2D0-0x0000000186A0F800
		public SkinType GetSkinTypeForCharacter(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186A0F800-0x0000000186A0FA10
		public Skin GetSkinForCharacter(VampireSurvivors.Data.CharacterType characterType) => default; // 0x0000000186A0FA10-0x0000000186A0FA50
		public Skin GetSkinForCharacter(VampireSurvivors.Data.CharacterType characterType, SkinType id) => default; // 0x0000000186A0FA50-0x0000000186A100D0
		public bool HasUnlockedSkin(VampireSurvivors.Data.CharacterType characterType, SkinType skinType) => default; // 0x0000000186A100D0-0x0000000186A101D0
		public void ClearEggsOnSigma() {} // 0x0000000186A101D0-0x0000000186A10370
		public List<VampireSurvivors.Data.CharacterType> GetCustomMerchantCharacters() => default; // 0x0000000186A10370-0x0000000186A10760
		public void UnlockWeapon(WeaponType weaponType, PlayerOptionsData config) {} // 0x0000000186A10760-0x0000000186A107F0
		public void UnlockWeapon(WeaponType weaponType) {} // 0x0000000186A107F0-0x0000000186A10880
		public void UnlockStage(StageType stageType, PlayerOptionsData config) {} // 0x0000000186A10880-0x0000000186A10910
		public void UnlockStage(StageType stageType) {} // 0x0000000186A10910-0x0000000186A109A0
		public void UnlockHyper(StageType stageType, PlayerOptionsData config) {} // 0x0000000186A109A0-0x0000000186A10A30
		public void UnlockHyper(StageType stageType) {} // 0x0000000186A10A30-0x0000000186A10AC0
		public void UnlockItem(VampireSurvivors.Data.ItemType itemType, PlayerOptionsData config) {} // 0x0000000186A10AC0-0x0000000186A10B70
		public void UnlockItem(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186A10B70-0x0000000186A10BA0
		public void UnlockPowerUp(PowerUpType powerUpType, PlayerOptionsData config) {} // 0x0000000186A10BA0-0x0000000186A10C30
		public void UnlockPowerUp(PowerUpType powerUpType) {} // 0x0000000186A10C30-0x0000000186A10CC0
		public void AddDisabledPowerUp(PowerUpType type) {} // 0x0000000186A10CC0-0x0000000186A10DF0
		public void RemoveDisabledPowerup(PowerUpType type) {} // 0x0000000186A10DF0-0x0000000186A10F30
		public void RestoreUnlockablePowerups() {} // 0x0000000180B15170-0x0000000180B15180
		public bool UnlockSecret(SecretType secretType, PlayerOptionsData config) => default; // 0x0000000186A10F30-0x0000000186A114E0
		public bool UnlockSecret(SecretType secretType) => default; // 0x0000000186A114E0-0x0000000186A11510
		public bool UnlockSecretInBaseGame(SecretType secretType) => default; // 0x0000000186A11510-0x0000000186A11520
		public static void AddCoinsFlat(float value, PlayerOptionsData config) {} // 0x0000000186A11520-0x0000000186A11670
		public void AddCoinsFlat(float value) {} // 0x0000000186A11670-0x0000000186A116E0
		public void AddCoinsNoRun(float value, CharacterController player = null) {} // 0x0000000186A116E0-0x0000000186A11A00
		public float RemoveCoinsFlat(float value) => default; // 0x0000000186A11A00-0x0000000186A11BA0
		public float AddCoins(float value, CharacterController player = null) => default; // 0x0000000186A11BA0-0x0000000186A12080
		public void RemoveCoins(int value, bool removeFromLifetime, PlayerOptionsData config) {} // 0x0000000186A12080-0x0000000186A12170
		public void RemoveCoins(int value, bool removeFromLifetime = false /* Metadata: 0x019772F9 */) {} // 0x0000000186A12170-0x0000000186A122A0
		public void AwardAdventureStar() {} // 0x0000000186A122A0-0x0000000186A12350
		private void InitSession() {} // 0x0000000186A12350-0x0000000186A12380
		private void UnlockCharacter(UISignals.CharacterUnlockedSignal sig) {} // 0x0000000186A12380-0x0000000186A12390
		private void BuyCharacter(UISignals.CharacterBoughtSignal sig) {} // 0x0000000186A12390-0x0000000186A123A0
		private void BuySkin(UISignals.SkinBoughtSignal sig) {} // 0x0000000186A0F060-0x0000000186A0F1A0
		private void UnlockStage(UISignals.StageUnlockedSignal sig) {} // 0x0000000186A123A0-0x0000000186A12450
		private void UnlockWeapon(UISignals.WeaponUnlockedSignal sig) {} // 0x0000000186A12450-0x0000000186A12500
		private void LanguageSelected(UISignals.LanguageSelectedSignal sig) {} // 0x0000000186A12500-0x0000000186A12660
		private void FullScreenChanged(UISignals.SetFullscreenSignal sig) {} // 0x0000000186A12660-0x0000000186A126D0
		private void BuyPowerUp(UISignals.BuyPowerUpSignal sig) {} // 0x0000000186A126D0-0x0000000186A128F0
		private void OnCharacterSelectionUpdated(UISignals.ConfirmCharacterSignal signal) {} // 0x0000000186A128F0-0x0000000186A12920
		private void OnStageSelectionChanged(UISignals.ConfirmStageSelectionSignal signal) {} // 0x0000000186A12920-0x0000000186A12950
		private void ApplySoundsVolume(UISignals.SetSFXVolumeSignal sig) {} // 0x0000000186A12950-0x0000000186A12A30
		private void ApplyMusicVolume(UISignals.SetMusicVolumeSignal sig) {} // 0x0000000186A12A30-0x0000000186A12BF0
		private void ApplyDamageNumbers(UISignals.SetDamageNumbersSignal sig) {} // 0x0000000186A12BF0-0x0000000186A12C20
		private void ApplyGlimmerCarousel(UISignals.SetGlimmerCarouselSignal sig) {} // 0x0000000186A12C20-0x0000000186A12C50
		private void ApplyVisibleJoysticks(UISignals.SetVisibleJoysticksSignal sig) {} // 0x0000000186A12C50-0x0000000186A12C80
		private void RefundPowerups(UISignals.RefundPowerUpsSignal sig) {} // 0x0000000186A12C80-0x0000000186A12E90
		private void ApplyFlashingVFX(UISignals.SetFlashingVFXSignal sig) {} // 0x0000000186A12E90-0x0000000186A12EC0
		private void ApplyHideStageProgression(UISignals.ToggleStageProgressionSignal sig) {} // 0x0000000186A12EC0-0x0000000186A12EF0
		private void ToggleMovingBackground(UISignals.ToggleMovingBackgroundSignal sig) {} // 0x0000000186A12EF0-0x0000000186A12F20
		private void ApplyHideXpBar(UISignals.ToggleXPBarSignal sig) {} // 0x0000000180B15170-0x0000000180B15180
		private void ApplyStreamerSafeMusic(UISignals.SetStreamerSafeMusicSignal signal) {} // 0x0000000186A12F20-0x0000000186A12F50
		private void ApplyPixelFontDefault() {} // 0x0000000186A12F50-0x0000000186A12FA0
	}
}
