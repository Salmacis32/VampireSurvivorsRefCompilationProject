/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.Scripts.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.Cheats;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class StageSelectPage : BaseUIPage // TypeDefIndex: 14987
	{
		// Fields
		[SerializeField]
		private GameObject stagePrefab; // 0xE0
		[SerializeField]
		private RectTransform container; // 0xE8
		[SerializeField]
		private Image _BackgroundPanel; // 0xF0
		[SerializeField]
		private Localize nameText; // 0xF8
		[SerializeField]
		private Localize tips; // 0x100
		[SerializeField]
		private Localize hyperTips; // 0x108
		[SerializeField]
		private TextMeshProUGUI _PageTitle; // 0x110
		[SerializeField]
		private TickBoxUI _HyperModeTickBox; // 0x118
		[SerializeField]
		private TickBoxUI _HurryModeTickBox; // 0x120
		[SerializeField]
		private TickBoxUI _MazzoModeTickBox; // 0x128
		[SerializeField]
		private TickBoxUI _LimitBreakTickBox; // 0x130
		[SerializeField]
		private TickBoxUI _InverseModeTickBox; // 0x138
		[SerializeField]
		private TickBoxUI _EndlessModeTickBox; // 0x140
		[SerializeField]
		private TickBoxUI _LockSelectedTickBox; // 0x148
		[SerializeField]
		private UnityEngine.UI.Button _ConfirmButton; // 0x150
		[SerializeField]
		private UnityEngine.UI.Button _SelectButton; // 0x158
		[SerializeField]
		private StageStatsPanel _Stats; // 0x160
		[SerializeField]
		private SongSelectionPanel _SongPanel; // 0x168
		[SerializeField]
		private UnityEngine.UI.Button _SelectableSongButton; // 0x170
		[SerializeField]
		private UnityEngine.UI.Button _SelectableSpeedButton; // 0x178
		[SerializeField]
		private UnityEngine.UI.Button _AdvancedSettingsButton; // 0x180
		[SerializeField]
		private RelicPanel _RelicPanel; // 0x188
		[SerializeField]
		private RectTransform _InfoPanel; // 0x190
		[SerializeField]
		private RectTransform _SliderRect; // 0x198
		[SerializeField]
		private StageRandomPanel _StageRandomPanel; // 0x1A0
		[SerializeField]
		private GameObject _SharePassivesPanel; // 0x1A8
		[SerializeField]
		private TickBoxUI _SharePassivesBox; // 0x1B0
		[SerializeField]
		private GameObject _DescriptionPanelTextPage; // 0x1B8
		public SelectionPhase _selectionPhase; // 0x1C0
		private SignalBus _signalBus; // 0x1C8
		private List<GameObject> _spawned; // 0x1D0
		private StageItemUI _selectedStage; // 0x1D8
		private StageItemUI _highlightedStage; // 0x1E0
		private StageData _selectedData; // 0x1E8
		private DataManager _data; // 0x1F0
		private PlayerOptions _playerOptions; // 0x1F8
		private DiContainer _diContainer; // 0x200
		private StageSelectionCheatCodeManager _cheats; // 0x208
		private AdventureManager _adventureManager; // 0x210
		private AdvancedMusicSelection _advancedMusicPanel; // 0x218
		private bool _hurryModeAvailable; // 0x220
		private bool _hyperModeAvailable; // 0x221
		private bool _mazzoModeAvailable; // 0x222
		private bool _limitBreakAvailable; // 0x223
		private bool _inverseModeAvailable; // 0x224
		private bool _endlessModeAvailable; // 0x225
		private bool _hasConfirmed; // 0x226
		private bool _phase1Disabled; // 0x227
		private bool _phase2Disabled; // 0x228
		private List<Selectable> _availableOptions; // 0x230
		private bool _hasBanger; // 0x238
		private bool _hasRandomOptions; // 0x239
		private bool _hasRandomEvents; // 0x23A
		private bool _hasRandomLevelUps; // 0x23B
		private bool _hasToggles; // 0x23C
	
		// Nested types
		public enum SelectionPhase // TypeDefIndex: 14983
		{
			PHASE1 = 0,
			PHASE2 = 1
		}
	
		// Constructors
		public StageSelectPage() {} // 0x00000001869952F0-0x0000000186995490
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, DataManager data, PlayerOptions player, DiContainer diContainer, AdventureManager adventureManager) {} // 0x000000018698D1F0-0x000000018698D3D0
		private void Start() {} // 0x000000018698D3D0-0x000000018698D480
		protected override void Update() {} // 0x000000018698D480-0x000000018698D560
		private void OnDestroy() {} // 0x000000018698D560-0x000000018698D580
		private void BackPressed() {} // 0x000000018698D580-0x000000018698D6E0
		protected override void OnShowStart(GameObject g) {} // 0x000000018698D6E0-0x000000018698DA80
		[IteratorStateMachine(typeof(_WaitAndSelect_d__62))]
		private IEnumerator WaitAndSelect() => default; // 0x000000018698DA80-0x000000018698DB20
		private void AutoSizeStageDescriptions() {} // 0x000000018698DB20-0x000000018698E180
		protected override void OnEnterPressed() {} // 0x000000018698E180-0x000000018698E2F0
		private void OnDisable() {} // 0x000000018698E2F0-0x000000018698E390
		protected override void OnHideStart(GameObject g) {} // 0x000000018698E390-0x000000018698E450
		protected override void OnHideFinish(GameObject g) {} // 0x000000018698E450-0x000000018698E6B0
		public void OpenAdvancedMusicSelectionPanel() {} // 0x000000018698E6B0-0x000000018698EAE0
		private void ReEnable() {} // 0x000000018698EAE0-0x000000018698F030
		private void RefreshSongPanel() {} // 0x000000018698F030-0x000000018698F1A0
		public void ConfirmStage() {} // 0x000000018698F1A0-0x000000018698F420
		public void SelectStage() {} // 0x000000018698F420-0x000000018698F630
		public void HighlightStage(StageItemUI item) {} // 0x000000018698F630-0x000000018698F7B0
		public void SetInfoPanel(StageItemUI stageItemUI, StageData stage, StageType stageType) {} // 0x000000018698F7B0-0x000000018698FDC0
		public void SetHyper(bool b) {} // 0x000000018698FDC0-0x000000018698FE30
		public void SetHurry(bool b) {} // 0x000000018698FE30-0x000000018698FEA0
		public void SetArcanas(bool b) {} // 0x000000018698FEA0-0x000000018698FED0
		public void SetLimitBreak(bool b) {} // 0x000000018698FED0-0x000000018698FF00
		public void SetInverse(bool b) {} // 0x000000018698FF00-0x000000018698FF90
		public void SetEndless(bool b) {} // 0x000000018698FF90-0x000000018698FFC0
		public void ToggleHyper() {} // 0x000000018698FFC0-0x0000000186990030
		public void SetSharePassives(bool b) {} // 0x0000000186990030-0x0000000186990080
		private static Dictionary<StageType, List<StageData>> Stage6Checks(Dictionary<StageType, List<StageData>> STAGE_DATA, PlayerOptions playerOptions) => default; // 0x0000000186990080-0x00000001869905C0
		private void Populate() {} // 0x00000001869905C0-0x0000000186992720
		public static Dictionary<StageType, List<StageData>> GetAvailableStages(DataManager data, PlayerOptions playerOptions) => default; // 0x0000000186992720-0x00000001869934A0
		private void GenerateNavigation() {} // 0x00000001869934A0-0x0000000186993F80
		private GameObject CreateStageItem(StageData stage, StageType type, int index) => default; // 0x0000000186993F80-0x0000000186994230
		private void WaitAndDo(Action cb) {} // 0x0000000186994230-0x00000001869942E0
		[IteratorStateMachine(typeof(_WaitRoutine_d__89))]
		private static IEnumerator WaitRoutine(Action cb) => default; // 0x00000001869942E0-0x0000000186994380
		private void EnableInfoPanelNavigation() {} // 0x0000000186994380-0x0000000186994390
		private void SetNavigationPhase1() {} // 0x0000000186994390-0x00000001869943C0
		private void SetNavigationPhase2() {} // 0x00000001869943C0-0x00000001869943F0
		private void DisableFirstPhaseGroup() {} // 0x00000001869943F0-0x0000000186994760
		private void EnableFirstPhaseGroup() {} // 0x0000000186994760-0x0000000186994B50
		private void DisableSecondPhaseGroup() {} // 0x0000000186994B50-0x0000000186994E40
		private void EnableSecondPhaseGroup() {} // 0x0000000186994E40-0x0000000186995120
		public void SwitchInput(UIHelper.ActiveInputType input) {} // 0x0000000186995120-0x00000001869952F0
	}
}
