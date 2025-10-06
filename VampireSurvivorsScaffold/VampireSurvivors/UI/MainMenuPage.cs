/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.App.Framework.System;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Cheats;
using VampireSurvivors.Objects;
using VampireSurvivors.Signals;
using VampireSurvivors.Spells;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MainMenuPage : BaseUIPage // TypeDefIndex: 14854
	{
		// Fields
		[FormerlySerializedAs("FirstSelected")]
		[SerializeField]
		private Selectable _FirstSelected; // 0xE0
		[SerializeField]
		private GameObject _BestiaryButton; // 0xE8
		[SerializeField]
		private GameObject _SecretsButton; // 0xF0
		[SerializeField]
		private GameObject _PowerUpButton; // 0xF8
		[SerializeField]
		private GameObject _StartButton; // 0x100
		[SerializeField]
		private GameObject _UnlocksButton; // 0x108
		[SerializeField]
		private GameObject _CollectionButton; // 0x110
		[SerializeField]
		private GameObject _CreditsButton; // 0x118
		[SerializeField]
		private UnityEngine.UI.Button _QuickStartButton; // 0x120
		[SerializeField]
		private GameObject _QuitButton; // 0x128
		[SerializeField]
		private GameObject _DlcButton; // 0x130
		[SerializeField]
		private GameObject _DLCStoreButton; // 0x138
		[SerializeField]
		private GameObject LogoAnchor; // 0x140
		[SerializeField]
		private GameObject _AdventureButton; // 0x148
		[SerializeField]
		private GameObject _OnlineButton; // 0x150
		[SerializeField]
		private Image _AdventureFader; // 0x158
		[SerializeField]
		private Image _AdventureShadow; // 0x160
		[SerializeField]
		private ParticleSystem _DustParticles; // 0x168
		[SerializeField]
		private Transform _MiddleVampire; // 0x170
		[SerializeField]
		private Transform _TitleLogo; // 0x178
		[SerializeField]
		private PixelateEffect _pixelEffect; // 0x180
		[SerializeField]
		private AscensionPanel _AscensionPanel; // 0x188
		[SerializeField]
		private Transform _StartButtonDefaultAnchor; // 0x190
		[SerializeField]
		private Transform _AdventureButtonDefaultAnchor; // 0x198
		[SerializeField]
		private Transform _PowerUpButtonDefaultAnchor; // 0x1A0
		[SerializeField]
		private Transform _CollectionButtonDefaultAnchor; // 0x1A8
		[SerializeField]
		private Transform _BestiaryButtonDefaultAnchor; // 0x1B0
		[SerializeField]
		private Transform _CreditsButtonDefaultAnchor; // 0x1B8
		[SerializeField]
		private Transform _UnlocksButtonDefaultAnchor; // 0x1C0
		[SerializeField]
		private Transform _SecretsButtonDefaultAnchor; // 0x1C8
		[SerializeField]
		private Transform _DLCStoreButtonDefaultAnchor; // 0x1D0
		[SerializeField]
		private Transform _QuickStartButtonDefaultAnchor; // 0x1D8
		[SerializeField]
		private Transform _StartButtonAdventureAnchor; // 0x1E0
		[SerializeField]
		private Transform _AdventureButtonAdventureAnchor; // 0x1E8
		[SerializeField]
		private Transform _PowerUpButtonAdventureAnchor; // 0x1F0
		[SerializeField]
		private Transform _CollectionButtonAdventureAnchor; // 0x1F8
		[SerializeField]
		private Transform _BestiaryButtonAdventureAnchor; // 0x200
		[SerializeField]
		private Transform _CreditsButtonAdventureAnchor; // 0x208
		[SerializeField]
		private Transform _UnlocksButtonAdventureAnchor; // 0x210
		[SerializeField]
		private Transform _SecretsButtonAdventureAnchor; // 0x218
		[SerializeField]
		private Transform _DLCStoreButtonAdventureAnchor; // 0x220
		[SerializeField]
		private Transform _QuickStartButtonAdventureAnchor; // 0x228
		private DiContainer _diContainer; // 0x230
		private SignalBus _signalBus; // 0x238
		private PlayerOptions _playerOptions; // 0x240
		private DataManager _dataManager; // 0x248
		private MultiplayerManager _multiplayerManager; // 0x250
		private AdventureManager _adventureManager; // 0x258
		private UnityServicesManager _unityServicesManager; // 0x260
		private SpellsManager _spellsManager; // 0x268
		private Material _pixelizer; // 0x270
		private GameObject _automationButton; // 0x278
		private IntroSceneCheatManager _cheats; // 0x280
		private bool _doShadowGag; // 0x288
	
		// Constructors
		public MainMenuPage() {} // 0x00000001868DB860-0x00000001868DB8B0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, DiContainer container, PlayerOptions player, DataManager dataManager, MultiplayerManager multiplayerManager, AdventureManager adventureManager, UnityServicesManager unityServicesManager, SpellsManager spellsManager) {} // 0x00000001868D2FF0-0x00000001868D32F0
		protected override void Awake() {} // 0x00000001868D32F0-0x00000001868D3310
		private void Start() {} // 0x00000001868D3310-0x00000001868D3850
		protected override void Update() {} // 0x00000001868D3850-0x00000001868D3880
		private void OnDestroy() {} // 0x00000001868D3880-0x00000001868D3C60
		private void ReselectStartButton() {} // 0x00000001868D3C60-0x00000001868D3CD0
		private void Test(bool t) {} // 0x00000001868D3CD0-0x00000001868D3DA0
		private bool HasAdventuresUnlocked() => default; // 0x00000001868D3DA0-0x00000001868D3EB0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868D3EB0-0x00000001868D4D90
		private void SetMobileDlcStoreVisibility() {} // 0x0000000180B15170-0x0000000180B15180
		private void OnAdventureAscended(bool result) {} // 0x00000001868D4D90-0x00000001868D5030
		private void HideAscensionPanel() {} // 0x00000001868D5030-0x00000001868D5070
		private void ExitAdventureLayout() {} // 0x00000001868D5070-0x00000001868D5220
		[IteratorStateMachine(typeof(_WaitAndReShow_d__67))]
		private IEnumerator WaitAndReShow() => default; // 0x00000001868D5220-0x00000001868D52C0
		protected override void OnHideStart(GameObject g) {} // 0x00000001868D52C0-0x00000001868D52D0
		private void OnEnable() {} // 0x00000001868D52D0-0x00000001868D53F0
		private void OnDisable() {} // 0x00000001868D53F0-0x00000001868D5510
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868D5510-0x00000001868D5550
		private void PlayAdventureUnlockAnimation() {} // 0x00000001868D5550-0x00000001868D6850
		private void TweenButtonsDuringUnlockAnimation() {} // 0x00000001868D6850-0x00000001868D7640
		private void SetAdventuresLayout() {} // 0x00000001868D7640-0x00000001868D8690
		[IteratorStateMachine(typeof(_SetAdventuresPortraitLayout_d__75))]
		private IEnumerator SetAdventuresPortraitLayout() => default; // 0x00000001868D8690-0x00000001868D8730
		private void SetDefaultLayout() {} // 0x00000001868D8730-0x00000001868D9850
		public void ShowAchievements() {} // 0x00000001868D9850-0x00000001868D98A0
		public void ShowCollections() {} // 0x00000001868D98A0-0x00000001868D98F0
		public void ShowDLCStore() {} // 0x00000001868D98F0-0x00000001868D99E0
		private void SetVisibility(UISignals.SetMainMenuPageVisibility sig) {} // 0x00000001868D99E0-0x00000001868D9AA0
		public void GetDlc() {} // 0x00000001868D9AA0-0x00000001868D9B40
		public void ShowOptions() {} // 0x00000001868D9B40-0x00000001868D9B90
		public void ShowCredits() {} // 0x00000001868D9B90-0x00000001868D9C80
		public void ShowPowerUps() {} // 0x00000001868D9C80-0x00000001868D9CD0
		public void ShowCharacterSelect() {} // 0x00000001868D9CD0-0x00000001868D9D20
		public void ShowOnline() {} // 0x00000001868D9D20-0x00000001868D9E30
		private void ShowOnlineCheckAgeOKCallback(bool isAgeOk) {} // 0x00000001868D9E30-0x00000001868D9F90
		private void ShowOnlineCheckEntitlementCallback(bool hasEntitlement) {} // 0x00000001868D9F90-0x00000001868DA220
		private void CloseOnlineCommunicatingPopup() {} // 0x00000001868DA220-0x00000001868DA2B0
		private void OnOnlineNotAllowed() {} // 0x00000001868DA2B0-0x00000001868DA470
		public void ShowBestiary() {} // 0x00000001868DA470-0x00000001868DA4C0
		public void ShowSecrets() {} // 0x00000001868DA4C0-0x00000001868DA670
		public void ShowAdventuresView() {} // 0x00000001868DA670-0x00000001868DA6C0
		private void QuickStartGame() {} // 0x00000001868DA6C0-0x00000001868DAE50
		private List<VampireSurvivors.Data.CharacterType> GetValidQuickCharacters() => default; // 0x00000001868DAE50-0x00000001868DB180
		private List<StageType> GetValidQuickStages() => default; // 0x00000001868DB180-0x00000001868DB590
		private void UpdateUnlocksButtonText() {} // 0x00000001868DB590-0x00000001868DB740
		private void UpdateSecretsButtonVisibility() {} // 0x00000001868DB740-0x00000001868DB860
	}
}
