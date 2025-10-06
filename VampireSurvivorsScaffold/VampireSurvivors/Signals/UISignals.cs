/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Cursors;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Signals
{
	public static class UISignals // TypeDefIndex: 14514
	{
		// Nested types
		public struct OnEnteredUISignal // TypeDefIndex: 14395
		{
		}
	
		public struct LandingScreenCompletedSignal // TypeDefIndex: 14396
		{
		}
	
		public struct IntroAnimCompletedSignal // TypeDefIndex: 14397
		{
		}
	
		public struct ShowOptionsScreenSignal // TypeDefIndex: 14398
		{
		}
	
		public struct ShowAchievementsScreenSignal // TypeDefIndex: 14399
		{
		}
	
		public struct ShowCollectionsScreenSignal // TypeDefIndex: 14400
		{
		}
	
		public struct ShowCreditsScreenSignal // TypeDefIndex: 14401
		{
		}
	
		public struct OpenGameWeaponSelectionSignal // TypeDefIndex: 14402
		{
		}
	
		public struct OpenTPWeaponSelectionSignal // TypeDefIndex: 14403
		{
			// Fields
			public VampireSurvivors.Objects.Characters.CharacterController Character; // 0x00
			public TPWeaponGroup WeaponGroup; // 0x08
		}
	
		public struct ShowDLCStoreSignal // TypeDefIndex: 14404
		{
		}
	
		public struct OpenHealerSignal // TypeDefIndex: 14405
		{
		}
	
		public struct CloseHealerSignal // TypeDefIndex: 14406
		{
		}
	
		public struct OpenArcanaSignal // TypeDefIndex: 14407
		{
		}
	
		public struct OpenSurvarotsSignal // TypeDefIndex: 14408
		{
		}
	
		public struct CloseArcanaSignal // TypeDefIndex: 14409
		{
		}
	
		public struct ShowPowerUpsScreenSignal // TypeDefIndex: 14410
		{
		}
	
		public struct ShowTPCreditsSignal // TypeDefIndex: 14411
		{
		}
	
		public struct CloseTPCreditsSignal // TypeDefIndex: 14412
		{
		}
	
		public struct AddNewCharactersToSelectionPageSignal // TypeDefIndex: 14413
		{
			// Fields
			public List<VampireSurvivors.Data.CharacterType> CharactersToAdd; // 0x00
		}
	
		public struct SpawnMinorDoilieSignal // TypeDefIndex: 14414
		{
		}
	
		public struct SetCharacterSelectionPageVisibility // TypeDefIndex: 14415
		{
			// Fields
			public bool Visible; // 0x00
		}
	
		public struct SetMainMenuPageVisibility // TypeDefIndex: 14416
		{
			// Fields
			public bool Visible; // 0x00
		}
	
		public struct StartTPUnlockSequenceSignal // TypeDefIndex: 14417
		{
		}
	
		public struct ForceSelectionOnCharacterSelectionPageSignal // TypeDefIndex: 14418
		{
			// Fields
			public VampireSurvivors.Data.CharacterType CharacterToselect; // 0x00
		}
	
		public struct ShowSecretsScreenSignal // TypeDefIndex: 14419
		{
		}
	
		public struct LaunchGameplaySignal // TypeDefIndex: 14420
		{
		}
	
		public struct ShowCharacterSelectScreenSignal // TypeDefIndex: 14421
		{
		}
	
		public struct ShowOnlineScreenSignal // TypeDefIndex: 14422
		{
		}
	
		public struct ShowOnlineLobbyScreenSignal // TypeDefIndex: 14423
		{
		}
	
		public struct GoBackOnlineSignal // TypeDefIndex: 14424
		{
		}
	
		public struct ShowOnlineErrorScreenSignal // TypeDefIndex: 14425
		{
			// Fields
			public string ErrorTitle; // 0x00
			public string ErrorMessage; // 0x08
		}
	
		public struct ShowAdventuresSelectionViewSignal // TypeDefIndex: 14426
		{
		}
	
		public struct ShowAdventuresAscensionSignal // TypeDefIndex: 14427
		{
		}
	
		public struct ToggleGuidesSignal // TypeDefIndex: 14428
		{
			// Fields
			public bool IsOn; // 0x00
		}
	
		public struct TogglePickupsSignal // TypeDefIndex: 14429
		{
			// Fields
			public bool IsOn; // 0x00
		}
	
		public struct GoldFeverStartedSignal // TypeDefIndex: 14430
		{
			// Fields
			public float Duration; // 0x00
			public bool IsFake; // 0x04
		}
	
		public struct GoldFeverEndedSignal // TypeDefIndex: 14431
		{
		}
	
		public struct EmitGoldFeverParticleSignal // TypeDefIndex: 14432
		{
			// Fields
			public Vector3 WorldPosition; // 0x00
		}
	
		public struct GoldFeverCoinCollectedSignal // TypeDefIndex: 14433
		{
		}
	
		public struct CloseDirectorSignal // TypeDefIndex: 14434
		{
		}
	
		public struct ShowBackButtonSignal // TypeDefIndex: 14435
		{
			// Fields
			public bool ShouldAutoSelect; // 0x00
		}
	
		public struct ForceBackButtonNavigation // TypeDefIndex: 14436
		{
			// Fields
			public Selectable Up; // 0x00
			public Selectable Down; // 0x08
			public Selectable Left; // 0x10
			public Selectable Right; // 0x18
		}
	
		public struct ResetBackButtonNavigation // TypeDefIndex: 14437
		{
		}
	
		public struct HideBackButtonSignal // TypeDefIndex: 14438
		{
		}
	
		public struct OpenDirectorSignal // TypeDefIndex: 14439
		{
		}
	
		public struct OpenPianoSignal // TypeDefIndex: 14440
		{
		}
	
		public struct ClosePianoSignal // TypeDefIndex: 14441
		{
		}
	
		public struct ShowFinalFireworksSignal // TypeDefIndex: 14442
		{
		}
	
		public struct CloseFinalFireworksSignal // TypeDefIndex: 14443
		{
		}
	
		public struct PianoTuneCompleteSignal // TypeDefIndex: 14444
		{
		}
	
		public struct FadeScreenSignal // TypeDefIndex: 14445
		{
			// Fields
			public float From; // 0x00
			public float To; // 0x04
			public float Duration; // 0x08
			public Ease Ease; // 0x0C
			public Action OnComplete; // 0x10
		}
	
		public struct BackButtonPressedSignal // TypeDefIndex: 14446
		{
		}
	
		public struct ConfirmCharacterSignal // TypeDefIndex: 14447
		{
			// Properties
			public VampireSurvivors.Data.CharacterType SelectedCharacter { [IsReadOnly] get; set; } // 0x000000018195AD90-0x000000018195ADA0 0x0000000181963E50-0x0000000181963E60
		}
	
		public struct ConfirmStageSelectionSignal // TypeDefIndex: 14448
		{
			// Properties
			public StageType SelectedStage { [IsReadOnly] get; set; } // 0x000000018195AD90-0x000000018195ADA0 0x0000000181963E50-0x0000000181963E60
		}
	
		public struct SelectOnlineStageSignal // TypeDefIndex: 14449
		{
		}
	
		public struct StartOnlineGame // TypeDefIndex: 14450
		{
		}
	
		public struct LockOnlineUI // TypeDefIndex: 14451
		{
		}
	
		public struct QuickStartGameSignal // TypeDefIndex: 14452
		{
		}
	
		public struct RecapPageCompletedSignal // TypeDefIndex: 14453
		{
		}
	
		public struct SkipWeaponSelectionSignal // TypeDefIndex: 14454
		{
		}
	
		public struct SetDamageNumbersSignal // TypeDefIndex: 14455
		{
			// Fields
			public bool isOn; // 0x00
		}
	
		public struct SetGlimmerCarouselSignal // TypeDefIndex: 14456
		{
			// Fields
			public bool isOn; // 0x00
		}
	
		public struct ToggleMovingBackgroundSignal // TypeDefIndex: 14457
		{
			// Fields
			public bool isOn; // 0x00
		}
	
		public struct SetFullscreenSignal // TypeDefIndex: 14458
		{
			// Fields
			public bool isOn; // 0x00
		}
	
		public struct ToggleStageProgressionSignal // TypeDefIndex: 14459
		{
			// Fields
			public bool Hide; // 0x00
		}
	
		public struct ToggleHideDebugUISignal // TypeDefIndex: 14460
		{
			// Fields
			public bool Hide; // 0x00
		}
	
		public struct ToggleHideGameUISignal // TypeDefIndex: 14461
		{
			// Fields
			public bool Hide; // 0x00
		}
	
		public struct ToggleXPBarSignal // TypeDefIndex: 14462
		{
			// Fields
			public bool Hidden; // 0x00
		}
	
		public struct ToggleWeaponSlotsSignal // TypeDefIndex: 14463
		{
			// Fields
			public bool Hidden; // 0x00
		}
	
		public struct FireNewGlimmerTechnique // TypeDefIndex: 14464
		{
			// Fields
			public string glimmerText; // 0x00
		}
	
		public struct SetVisibleJoysticksSignal // TypeDefIndex: 14465
		{
			// Fields
			public bool _IsOn; // 0x00
		}
	
		public struct ReceivedNewItemSignal // TypeDefIndex: 14466
		{
			// Fields
			public VampireSurvivors.Data.ItemType _Item; // 0x00
		}
	
		public struct DiscardNewItemSignal // TypeDefIndex: 14467
		{
		}
	
		public struct OpenBestiarySignal // TypeDefIndex: 14468
		{
		}
	
		public struct SetFlashingVFXSignal // TypeDefIndex: 14469
		{
			// Fields
			public bool isOn; // 0x00
		}
	
		public struct SetStreamerSafeMusicSignal // TypeDefIndex: 14470
		{
			// Fields
			public bool IsOn; // 0x00
		}
	
		public struct SetSFXVolumeSignal // TypeDefIndex: 14471
		{
			// Fields
			public float Volume; // 0x00
		}
	
		public struct SetMusicVolumeSignal // TypeDefIndex: 14472
		{
			// Fields
			public float Volume; // 0x00
		}
	
		public struct SyncSteamAchievementsSignal // TypeDefIndex: 14473
		{
		}
	
		public struct RefundPowerUpsSignal // TypeDefIndex: 14474
		{
		}
	
		public struct CreateDamageNumberSignal // TypeDefIndex: 14475
		{
			// Fields
			public Vector3 WorldPosition; // 0x00
			public int Damage; // 0x0C
		}
	
		public struct CreateSpecialDamageNumberSignal // TypeDefIndex: 14476
		{
			// Fields
			public Vector3 WorldPosition; // 0x00
			public int Damage; // 0x0C
			public float Size; // 0x10
			public bool HasCustomColor; // 0x14
			public Color32 Color; // 0x18
			public int FontOffset; // 0x1C
			public bool Randomize; // 0x20
		}
	
		public struct CreateImpactVFXSignal // TypeDefIndex: 14477
		{
			// Fields
			public HitVfxType type; // 0x00
			public Vector2 WorldPos; // 0x04
		}
	
		public struct OpenLanguagePageSignal // TypeDefIndex: 14478
		{
		}
	
		public struct LanguageSelectedSignal // TypeDefIndex: 14479
		{
			// Fields
			public string languageCode; // 0x00
		}
	
		public struct QuitGameSignal // TypeDefIndex: 14480
		{
		}
	
		public struct CharacterUnlockedSignal // TypeDefIndex: 14481
		{
			// Fields
			public VampireSurvivors.Data.CharacterType character; // 0x00
		}
	
		public struct WarningShownSignal // TypeDefIndex: 14482
		{
		}
	
		public struct StageUnlockedSignal // TypeDefIndex: 14483
		{
			// Fields
			public StageType stage; // 0x00
		}
	
		public struct WeaponUnlockedSignal // TypeDefIndex: 14484
		{
			// Fields
			public WeaponType weapon; // 0x00
		}
	
		public struct CharacterBoughtSignal // TypeDefIndex: 14485
		{
			// Fields
			public VampireSurvivors.Data.CharacterType character; // 0x00
		}
	
		public struct SkinBoughtSignal // TypeDefIndex: 14486
		{
			// Fields
			public SkinType skin; // 0x00
		}
	
		public struct BuyPowerUpSignal // TypeDefIndex: 14487
		{
			// Fields
			public PowerUpType Powerup; // 0x00
			public int Price; // 0x04
		}
	
		public struct ShowItemFoundScreenSignal // TypeDefIndex: 14488
		{
			// Fields
			public WeaponType Type; // 0x00
		}
	
		public struct TreasureChestSpawnedSignal // TypeDefIndex: 14489
		{
			// Fields
			public GameObject Treasure; // 0x00
		}
	
		public struct TreasureChestCollectedSignal // TypeDefIndex: 14490
		{
			// Fields
			public GameObject Treasure; // 0x00
		}
	
		public struct SpawnOffScreenCursorSignal // TypeDefIndex: 14491
		{
			// Fields
			public GameObject Target; // 0x00
			public CursorData Data; // 0x08
		}
	
		public struct CharacterCollectedSignal // TypeDefIndex: 14492
		{
		}
	
		public class OpenMerchantSignal // TypeDefIndex: 14493
		{
			// Properties
			public VampireSurvivors.Objects.Characters.CharacterController Character { get; } // 0x0000000180B15C10-0x0000000180B15C20 
	
			// Constructors
			public OpenMerchantSignal() {} // Dummy constructor
			public OpenMerchantSignal(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x0000000181958310-0x0000000181958370
		}
	
		public struct MerchantClosedSignal // TypeDefIndex: 14494
		{
		}
	
		public struct HideAllCursorsSignal // TypeDefIndex: 14495
		{
		}
	
		public struct ShowCursorSignal // TypeDefIndex: 14496
		{
			// Fields
			public GameObject Target; // 0x00
		}
	
		public struct HideCursorSignal // TypeDefIndex: 14497
		{
			// Fields
			public GameObject Target; // 0x00
		}
	
		public struct UnhideCursorsSignal // TypeDefIndex: 14498
		{
		}
	
		public struct RemoveOffScreenCursorSignal // TypeDefIndex: 14499
		{
			// Fields
			public GameObject Target; // 0x00
		}
	
		public struct ArcanaSelectedSignal // TypeDefIndex: 14500
		{
			// Fields
			public ArcanaType Type; // 0x00
		}
	
		public struct CharacterCardSelectedSignal // TypeDefIndex: 14501
		{
			// Fields
			public CharacterSkillCard_Base Card; // 0x00
		}
	
		public struct ArcanaSkippedSignal // TypeDefIndex: 14502
		{
		}
	
		public struct SurvarotsSkippedSignal // TypeDefIndex: 14503
		{
		}
	
		public struct ShowEndCreditsSignal // TypeDefIndex: 14504
		{
		}
	
		public struct RemoveWeaponFromEquipmentPanel // TypeDefIndex: 14505
		{
			// Fields
			public WeaponType Weapon; // 0x00
		}
	
		public struct ShowGameOverinoSceneSignal // TypeDefIndex: 14506
		{
		}
	
		public struct ShowAccountPageSignal // TypeDefIndex: 14507
		{
		}
	
		public struct ShowLevelBonusSelectionSignal // TypeDefIndex: 14508
		{
		}
	
		public struct LevelUpBonusSelectedSignal // TypeDefIndex: 14509
		{
			// Fields
			public PowerUpType SelectedBonus; // 0x00
		}
	
		public struct SkipLevelUpBonusSignal // TypeDefIndex: 14510
		{
		}
	
		public struct CharacterFoundPageClosedSignal // TypeDefIndex: 14511
		{
		}
	
		public struct RefreshCursorsSignal // TypeDefIndex: 14512
		{
		}
	
		public struct BanishWeaponLevelUpSignal // TypeDefIndex: 14513
		{
			// Fields
			public WeaponType BanishedWeapon; // 0x00
		}
	}
}
