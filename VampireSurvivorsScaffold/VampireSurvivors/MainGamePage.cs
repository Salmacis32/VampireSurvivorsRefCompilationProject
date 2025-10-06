/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.UI.Twitch;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class MainGamePage : BaseUIPage // TypeDefIndex: 14211
	{
		// Fields
		[SerializeField]
		private Image _ExperienceProgress; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _EnemiesText; // 0xE8
		[SerializeField]
		private Image _KillsIcon; // 0xF0
		[SerializeField]
		private TextMeshProUGUI _CoinsText; // 0xF8
		[SerializeField]
		private TextMeshProUGUI _TimeText; // 0x100
		[SerializeField]
		private TextMeshProUGUI _LevelText; // 0x108
		[SerializeField]
		private GoldFeverUIManager _GoldFever; // 0x110
		[SerializeField]
		private GameObject _CheatsPanel; // 0x118
		[SerializeField]
		private GameObject _OnlineCheatsPanel; // 0x120
		[SerializeField]
		private GameObject _XPBar; // 0x128
		[SerializeField]
		private RectTransform _EquipmentPanelContainer; // 0x130
		[SerializeField]
		private GameObject _PlayerEquipmentPanelPrefab; // 0x138
		[SerializeField]
		private UnityEngine.UI.Button _PauseButton; // 0x140
		[SerializeField]
		private UnityEngine.UI.Button _FastForwardButton; // 0x148
		[SerializeField]
		private TwitchStageEventsPanel _TwitchStageEventsPanel; // 0x150
		[SerializeField]
		private GameObject _SceneTransitionFader; // 0x158
		[SerializeField]
		private GlimmerTechniqueCarousel _GlimmerTechniqueCarousel; // 0x160
		[SerializeField]
		private GameObject _SpectateModeContainer; // 0x168
		[SerializeField]
		private Image _SpectateModeIcon; // 0x170
		[SerializeField]
		private TextMeshProUGUI _SpectateModePlayerName; // 0x178
		private SignalBus _signalBus; // 0x180
		private GameSessionData _session; // 0x188
		private readonly LocalizedString _levelString; // 0x190
		private PlayerOptions _playerOptions; // 0x1A8
		private StringBuilder _timeFormatStringBuilder; // 0x1B0
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, GameObject> _uiPanels; // 0x1B8
	
		// Properties
		public TextMeshProUGUI SurvivedSecondsText { get => default; } // 0x0000000182766860-0x0000000182766870 
		public Image KillsIcon { get => default; } // 0x00000001819716C0-0x00000001819716D0 
		public TextMeshProUGUI KillsText { get => default; } // 0x0000000182766DD0-0x0000000182766DE0 
		public GoldFeverUIManager GoldFever { get => default; } // 0x0000000182A45AF0-0x0000000182A45B00 
		public TwitchStageEventsPanel TwitchStageEventsPanel { get => default; } // 0x0000000184F54BD0-0x0000000184F54BE0 
		protected override bool IsOnlineUi { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public MainGamePage() {} // 0x0000000186DB9A30-0x0000000186DB9C10
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, GameSessionData session, PlayerOptions playerOptions) {} // 0x0000000186DB61B0-0x0000000186DB6450
		protected override void Awake() {} // 0x0000000186DB6450-0x0000000186DB66C0
		private void Start() {} // 0x0000000186DB66C0-0x0000000186DB66D0
		private void OnEnable() {} // 0x0000000186DB66D0-0x0000000186DB76C0
		[IteratorStateMachine(typeof(_WaitForConfig_d__42))]
		private IEnumerator WaitForConfig() => default; // 0x0000000186DB76C0-0x0000000186DB7760
		private void OnDisable() {} // 0x0000000186DB7760-0x0000000186DB80E0
		public bool ArePanelsInitialized() => default; // 0x0000000186DB80E0-0x0000000186DB8130
		public void ReinitializeEquipment() {} // 0x0000000186DB8130-0x0000000186DB84A0
		public void UpdateKills() {} // 0x0000000186DB84A0-0x0000000186DB85D0
		public void PerformSceneTransition(Action onCompleteCallback, float durationMillis = 3000f /* Metadata: 0x01977057 */) {} // 0x0000000186DB85D0-0x0000000186DB8810
		public void ForceEquipmentLayoutRebuild() {} // 0x0000000186DB8810-0x0000000186DB8920
		protected override void OnShowStart(GameObject g) {} // 0x0000000186DB8920-0x0000000186DB8940
		private void UpdateExperienceProgress(GameplaySignals.CharacterXpChangedSignal sig) {} // 0x0000000186DB8940-0x0000000186DB8980
		private void LevelUp() {} // 0x0000000186DB8980-0x0000000186DB8AF0
		private void ToggleXPBar(UISignals.ToggleXPBarSignal sig) {} // 0x0000000186DB8AF0-0x0000000186DB8B20
		private void ToggleWeaponSlots(UISignals.ToggleWeaponSlotsSignal sig) {} // 0x0000000186DB8B20-0x0000000186DB8B60
		private void FireNewGlimmerTechnique(UISignals.FireNewGlimmerTechnique sig) {} // 0x0000000186DB8B60-0x0000000186DB8B90
		private void AssignLevel() {} // 0x0000000186DB8B90-0x0000000186DB8CF0
		protected override void Update() {} // 0x0000000186DB8CF0-0x0000000186DB90A0
		private void ChangeSpectateTargetUi() {} // 0x0000000186DB90A0-0x0000000186DB92C0
		private void CheckSpectateMode() {} // 0x0000000186DB92C0-0x0000000186DB94C0
		private bool IsSpectateModeActive() => default; // 0x0000000186DB94C0-0x0000000186DB9560
		private void UpdateCoins() {} // 0x0000000186DB9560-0x0000000186DB9660
		private void ActivateGoldFever() {} // 0x0000000186DB9660-0x0000000186DB96A0
		private void DeactivateGoldFever() {} // 0x0000000186DB96A0-0x0000000186DB9730
		private void InitializeEquipment() {} // 0x0000000186DB9730-0x0000000186DB9A30
	}
}
