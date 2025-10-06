/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PausePage : BaseUIPage // TypeDefIndex: 14221
	{
		// Fields
		[SerializeField]
		private GameObject _Equipment; // 0xE0
		[SerializeField]
		private GameObject _MobileEquipment; // 0xE8
		[SerializeField]
		private GameObject _CharacterStatsPanel; // 0xF0
		[SerializeField]
		private GameObject _Options; // 0xF8
		[SerializeField]
		private List<PauseEquipmentPanel> _EquipmentPanels; // 0x100
		[SerializeField]
		private GrimoireManager _Grimoire; // 0x108
		[SerializeField]
		private GameObject _QuitDescriptionText; // 0x110
		[SerializeField]
		private GameObject _Fader; // 0x118
		[SerializeField]
		private VerticalLayoutGroup _LeftStatsLayoutGroup; // 0x120
		[FormerlySerializedAs("_DisplayContainer")]
		[SerializeField]
		private ArcanaDisplayContainer _arcanasDisplayContainer; // 0x128
		[FormerlySerializedAs("_survarrochiDisplayContainer")]
		[SerializeField]
		private SurvarotsDisplayContainer _survarotsDisplayContainer; // 0x130
		[Header("Arcanas")]
		[SerializeField]
		private GameObject _Arcanas; // 0x138
		[Header("Buttons")]
		[SerializeField]
		private RectTransform _ResumeButton; // 0x140
		[SerializeField]
		private RectTransform _OptionsButton; // 0x148
		[SerializeField]
		private RectTransform _QuitButton; // 0x150
		[SerializeField]
		private RectTransform _GuidesButton; // 0x158
		[SerializeField]
		private RectTransform _PickupsButton; // 0x160
		[SerializeField]
		private RectTransform _OpenMapButton; // 0x168
		[SerializeField]
		private RectTransform _OpenGrimoireButton; // 0x170
		[SerializeField]
		private RectTransform _ZoomInMapButton; // 0x178
		[SerializeField]
		private RectTransform _ZoomOutMapButton; // 0x180
		[SerializeField]
		private GameObject _Map; // 0x188
		[SerializeField]
		private MapManager _MapManager; // 0x190
		private SignalBus _signalBus; // 0x198
		private PlayerOptions _playerOptions; // 0x1A0
		private GameManager _gameManager; // 0x1A8
		private DataManager _dataManager; // 0x1B0
		private LobbiesManager _lobbiesManager; // 0x1B8
		private bool _hasGrimoire; // 0x1C0
		private bool _hasMap; // 0x1C1
		private bool _hasInitializedOptions; // 0x1C2
		private bool _arcanasActive; // 0x1C3
		private bool hadToDelayInitialization; // 0x1C4
		[SerializeField]
		private PausePageState _State; // 0x1C8
	
		// Properties
		protected override bool IsOnlineUi { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Nested types
		private enum PausePageState // TypeDefIndex: 14219
		{
			NONE = 0,
			MAP = 1,
			GRIMOIRE = 2,
			OPTIONS = 3
		}
	
		// Constructors
		public PausePage() {} // 0x0000000186EF5BE0-0x0000000186EF5CD0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, GameManager gameManager, DataManager dataManager, LobbiesManager lobbiesManager) {} // 0x0000000186EF1780-0x0000000186EF1960
		protected override void Awake() {} // 0x0000000186EF1960-0x0000000186EF1B90
		private void OnDestroy() {} // 0x0000000186EF1B90-0x0000000186EF1C40
		private void InitializePage() {} // 0x0000000186EF1C40-0x0000000186EF1D90
		protected override void OnShowStart(GameObject g) {} // 0x0000000186EF1D90-0x0000000186EF35C0
		[IteratorStateMachine(typeof(_ForceLeftLayoutDelayed_d__42))]
		private IEnumerator ForceLeftLayoutDelayed() => default; // 0x0000000186EF35C0-0x0000000186EF3660
		protected override void OnHideStart(GameObject g) {} // 0x0000000186EF3660-0x0000000186EF36E0
		protected override void OnHideFinish(GameObject g) {} // 0x0000000186EF36E0-0x0000000186EF37A0
		public void ReturnToGame() {} // 0x0000000186EF37A0-0x0000000186EF3850
		public void Quit() {} // 0x0000000186EF3850-0x0000000186EF3980
		public void OpenOptions() {} // 0x0000000186EF3980-0x0000000186EF3C00
		public void OpenEmpty() {} // 0x0000000186EF3C00-0x0000000186EF3C80
		public void OpenMap() {} // 0x0000000186EF3C80-0x0000000186EF3EB0
		public void ToggleGuides() {} // 0x0000000186EF3EB0-0x0000000186EF40C0
		public void TogglePickups() {} // 0x0000000186EF40C0-0x0000000186EF4230
		public void OpenGrimoire() {} // 0x0000000186EF4230-0x0000000186EF4450
		public void FormatButtons() {} // 0x0000000186EF4450-0x0000000186EF5980
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000186EF5980-0x0000000186EF59D0
		private void InitToggles() {} // 0x0000000186EF59D0-0x0000000186EF5A10
		private void UpdatePickupsToggleText() {} // 0x0000000186EF5A10-0x0000000186EF5AD0
		private void UpdateGuidesToggleText() {} // 0x0000000186EF5AD0-0x0000000186EF5B90
		private void HideAllPanels() {} // 0x0000000186EF5B90-0x0000000186EF5BE0
	}
}
