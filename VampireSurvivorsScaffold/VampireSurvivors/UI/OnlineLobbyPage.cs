/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Connection;
using Coherence.Toolkit;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OnlineLobbyPage : BaseUIPage, ICharacterSelector // TypeDefIndex: 14885
	{
		// Fields
		[SerializeField]
		private GameObject CharacterPrefab; // 0xE0
		[SerializeField]
		private RectTransform Container; // 0xE8
		[SerializeField]
		private UnityEngine.UI.Button ConfirmButton; // 0xF0
		[SerializeField]
		private UnityEngine.UI.Button BuyButton; // 0xF8
		[SerializeField]
		private UnityEngine.UI.Button StartButton; // 0x100
		[SerializeField]
		private UnityEngine.UI.Button _collectionsButton; // 0x108
		[SerializeField]
		private UnityEngine.UI.Button _powerUpsButton; // 0x110
		[SerializeField]
		private UnityEngine.UI.Button _achievementButton; // 0x118
		[SerializeField]
		private Image PanelBackground; // 0x120
		[SerializeField]
		private Sprite _SkinOffIcon; // 0x128
		[SerializeField]
		private Sprite _SkinOnIcon; // 0x130
		[SerializeField]
		private RectTransform _SkinIndexContainer; // 0x138
		[SerializeField]
		private GameObject _SkinIndexPrefab; // 0x140
		[SerializeField]
		private CharacterStageCompletionPanel _StageCompletionPanel; // 0x148
		[FormerlySerializedAs("Name")]
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x150
		[SerializeField]
		private TextMeshProUGUI Description; // 0x158
		[SerializeField]
		private Image Icon; // 0x160
		[SerializeField]
		private Image WeaponIcon; // 0x168
		[SerializeField]
		private StatsPanelUI StatsPanel; // 0x170
		[SerializeField]
		private PriceUI Price; // 0x178
		[SerializeField]
		private Image _LockIcon; // 0x180
		[SerializeField]
		private GameObject _WeaponFrame; // 0x188
		[SerializeField]
		private List<OnlineMPPlayerItem> _players; // 0x190
		[SerializeField]
		private StageItemUI _stageItem; // 0x198
		[SerializeField]
		private GameObject _selectStageButton; // 0x1A0
		[SerializeField]
		private TextMeshProUGUI _latencyText; // 0x1A8
		private TextMeshProUGUI _buyButtonLabel; // 0x1B0
		private bool _characterBoughtThisFrame; // 0x1B8
		private Dictionary<VampireSurvivors.Data.CharacterType, CharacterItemUI> _characterItems; // 0x1C0
		private CharacterItemUI _selectedCharacter; // 0x1C8
		private SignalBus _signalBus; // 0x1D0
		private DataManager _dataManager; // 0x1D8
		private readonly List<GameObject> _spawned; // 0x1E0
		private PlayerOptions _playerOptions; // 0x1E8
		private AdventureManager _adventureManager; // 0x1F0
		private LobbiesManager _lobbiesManager; // 0x1F8
		private CharacterData _currentData; // 0x200
		private VampireSurvivors.Data.CharacterType _currentType; // 0x208
		private bool _characterConfirmed; // 0x20C
		private List<Image> _skinSlots; // 0x210
		private List<int> _weirdCharacters; // 0x218
		private List<VampireSurvivors.Data.CharacterType> _tempUnlockedCoopCharacters; // 0x220
		private int _selectedPlayerSlotIndex; // 0x228
		private bool _rnjSetup; // 0x22C
		private bool _missingNSetup; // 0x22D
		private bool _isUILocked; // 0x22E
		private static float ICON_UI_SCALE; // 0x08
		private bool _onlineInit; // 0x22F
	
		// Properties
		public static OnlineLobbyPage Instance { get; private set; } // 0x00000001868F86B0-0x00000001868F8710 0x00000001868F8710-0x00000001868F87C0
	
		// Constructors
		public OnlineLobbyPage() {} // 0x0000000186907D10-0x0000000186908390
		static OnlineLobbyPage() {} // 0x0000000186908390-0x0000000186908450
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, DataManager dataManager, AdventureManager adventureManager, LobbiesManager lobbiesManager) {} // 0x00000001868F87C0-0x00000001868F89A0
		public void RefreshCharacters() {} // 0x00000001868F89A0-0x00000001868F9350
		[IteratorStateMachine(typeof(_SelectAfterFrameDelay_d__53))]
		private IEnumerator SelectAfterFrameDelay() => default; // 0x00000001868F9350-0x00000001868F93F0
		public void StartGame() {} // 0x00000001868F93F0-0x00000001868F9680
		public void SelectCharacter(bool fromUnlock) {} // 0x00000001868F9680-0x00000001868F9AC0
		public void SelectStage() {} // 0x00000001868F9AC0-0x00000001868F9BD0
		private void UpdatePlayerInfoSelectedCharacter() {} // 0x00000001868F9BD0-0x00000001868F9E70
		public void BuyCharacter() {} // 0x00000001868F9E70-0x00000001868FA3A0
		private void WrapNavigation() {} // 0x00000001868FA3A0-0x00000001868FA800
		private bool IsCharacterHighlightedByOtherPlayer(VampireSurvivors.Data.CharacterType cType) => default; // 0x00000001868FA800-0x00000001868FAA50
		private void DisableButtons() {} // 0x00000001868FAA50-0x00000001868FAE80
		private bool ShouldSelectionChangesBeBlocked() => default; // 0x00000001868FAE80-0x00000001868FB1C0
		public void ShowCharacterInfo(CharacterData charData, VampireSurvivors.Data.CharacterType cType, CharacterItemUI character) {} // 0x00000001868FB1C0-0x00000001868FCE30
		private void SetVisualStatePurchasable() {} // 0x00000001868FCE30-0x00000001868FD2A0
		private void SetCharacterSprite(VampireSurvivors.Data.CharacterType cType, CharacterData cData) {} // 0x00000001868FD2A0-0x00000001868FD3A0
		private void SetCharPanelDescription(string descText, bool isHidden = false /* Metadata: 0x01977239 */, bool isSecret = false /* Metadata: 0x0197723A */) {} // 0x00000001868FD3A0-0x00000001868FD500
		private void SetIconSizes() {} // 0x00000001868FD500-0x00000001868FDAF0
		public void NextSkin() {} // 0x00000001868FDAF0-0x00000001868FE040
		public void SetSkinOnline(int character, int skinTypeAsInt) {} // 0x00000001868FE040-0x00000001868FE620
		private void SetWeaponIconSprite(CharacterData characterData) {} // 0x00000001868FE620-0x00000001868FEA60
		private bool CanSeeSkins() => default; // 0x00000001868FEA60-0x00000001868FEB40
		private void SetSkinSlots() {} // 0x00000001868FEB40-0x00000001868FF940
		public bool IsSecretAndNotUnlocked(CharacterData characterData, VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001868FF940-0x00000001868FF9F0
		public bool IsSecretChar(VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001868FF9F0-0x00000001868FFBE0
		protected override void Update() {} // 0x00000001868FFBE0-0x0000000186900350
		private void LateUpdate() {} // 0x0000000186900350-0x0000000186900360
		private void SetCharactersTaken() {} // 0x0000000186900360-0x0000000186900800
		protected override void OnShowStart(GameObject g) {} // 0x0000000186900800-0x0000000186901570
		private void LockOnlineUI() {} // 0x0000000186901570-0x0000000186901620
		private void MpPlayerItemOnOnAiSettingsButtonClicked(int index) {} // 0x0000000186901620-0x0000000186901910
		private void OnPlayerButtonClicked(int index) {} // 0x0000000186901910-0x0000000186901D30
		private LargeMultiOptionPopup ShowAISettingsPopup(int index) => default; // 0x0000000186901D30-0x00000001869021F0
		private void PlayerSlotSelection(int index, int aiTypeIndex) {} // 0x00000001869021F0-0x0000000186902680
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186902680-0x00000001869026C0
		private void ResetUi() {} // 0x00000001869026C0-0x0000000186903130
		private void OnBecomeAuthority() {} // 0x0000000186903130-0x0000000186903250
		private void OnStageSelected(UISignals.ConfirmStageSelectionSignal startingStage) {} // 0x0000000186903250-0x00000001869035F0
		private void PopulatePlayerUis() {} // 0x00000001869035F0-0x00000001869039C0
		private void OnSeatAssigned(int seatNumber, VampireSurvivors.PlayerInfo playerInfo) {} // 0x00000001869039C0-0x0000000186903A30
		protected override void OnEnterPressed() {} // 0x0000000186903A30-0x0000000186903CC0
		protected override void OnHideFinish(GameObject g) {} // 0x0000000186903CC0-0x0000000186903ED0
		private void Detune() {} // 0x0000000186903ED0-0x0000000186903FB0
		private void OnDestroy() {} // 0x0000000186903FB0-0x0000000186903FC0
		private void setupRNJ(CharacterData dat, VampireSurvivors.Data.CharacterType cType) {} // 0x0000000186903FC0-0x0000000186905140
		private static void SetDefaultCharacterName(CharacterData dat) {} // 0x0000000186905140-0x0000000186905220
		private void setupMIS(CharacterData ddata, VampireSurvivors.Data.CharacterType cType) {} // 0x0000000186905220-0x0000000186905300
		private void InitMisValues(CharacterData ddata, VampireSurvivors.Data.CharacterType cType) {} // 0x0000000186905300-0x0000000186906820
		private string CharCodeToString(int[] codes) => default; // 0x0000000186906820-0x0000000186906970
		private void Populate() {} // 0x0000000186906970-0x0000000186907640
		private void UpdateStatsPanelVisibility() {} // 0x0000000186907640-0x0000000186907710
		private GameObject AddCharacter(CharacterItem cItem) => default; // 0x0000000186907710-0x00000001869078B0
		[IteratorStateMachine(typeof(_WaitAndDo_d__103))]
		private IEnumerator WaitAndDo(Action cb) => default; // 0x00000001869078B0-0x0000000186907950
		public void GoBackOnline() {} // 0x0000000186907950-0x0000000186907A70
		public void ShowPowerUps() {} // 0x0000000186907A70-0x0000000186907B50
		public void ShowAchievements() {} // 0x0000000186907B50-0x0000000186907C30
		public void ShowCollections() {} // 0x0000000186907C30-0x0000000186907D10
	}
}
