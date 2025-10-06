/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Cheats;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Algorithm;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CharacterSelectionPage : BaseUIPage, ICharacterSelector // TypeDefIndex: 14732
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
		private Image PanelBackground; // 0x108
		[SerializeField]
		private TextMeshProUGUI _EggCount; // 0x110
		[SerializeField]
		private TextMeshProUGUI _EggCountTitle; // 0x118
		[SerializeField]
		private TickBoxUI _EggBox; // 0x120
		[SerializeField]
		private TextMeshProUGUI _MaxWeaponsText; // 0x128
		[SerializeField]
		private GameObject _EggWeaponBox; // 0x130
		[SerializeField]
		private GameObject _EggContainer; // 0x138
		[SerializeField]
		private GameObject _WeaponCountContainer; // 0x140
		[SerializeField]
		private Sprite _SkinOffIcon; // 0x148
		[SerializeField]
		private Sprite _SkinOnIcon; // 0x150
		[SerializeField]
		private RectTransform _SkinIndexContainer; // 0x158
		[SerializeField]
		private GameObject _SkinIndexPrefab; // 0x160
		[SerializeField]
		private RectTransform _Panel; // 0x168
		[SerializeField]
		private GameObject _MultiplayerTextPanel; // 0x170
		[SerializeField]
		private GameObject MPPlayerItemPrefab; // 0x178
		[SerializeField]
		private RectTransform MPPlayerContainer; // 0x180
		[SerializeField]
		private FakeSliderHandleController _StageCompletionScroller; // 0x188
		[SerializeField]
		private RectTransform _DoilieMask; // 0x190
		[SerializeField]
		private List<Sprite> _Doilies; // 0x198
		[SerializeField]
		private CharacterStageCompletionPanel _StageCompletionPanel; // 0x1A0
		[FormerlySerializedAs("Name")]
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x1A8
		[SerializeField]
		private TextMeshProUGUI Description; // 0x1B0
		[SerializeField]
		private Image Icon; // 0x1B8
		[SerializeField]
		private Image WeaponIcon; // 0x1C0
		[SerializeField]
		private Image _LockIcon; // 0x1C8
		[SerializeField]
		private StatsPanelUI StatsPanel; // 0x1D0
		[SerializeField]
		private PriceUI Price; // 0x1D8
		[SerializeField]
		private GameObject _WeaponFrame; // 0x1E0
		[SerializeField]
		private EnterCoopButton _EnterCoopButton; // 0x1E8
		[SerializeField]
		private GameObject _SwitchReassignControllersButton; // 0x1F0
		private GameObject _lastBonusButton; // 0x1F8
		private bool _wasAllowingMultiplayerJoining; // 0x200
		private bool _characterBoughtThisFrame; // 0x201
		private TextMeshProUGUI _buyButtonLabel; // 0x208
		private State state; // 0x210
		private Dictionary<VampireSurvivors.Data.CharacterType, CharacterItemUI> _characterItemUIs; // 0x218
		private List<MPPlayerItem> _playerSlots; // 0x220
		private CharacterItemUI _selectedCharacterItemUI; // 0x228
		private SignalBus _signalBus; // 0x230
		private DataManager _dataManager; // 0x238
		private DiContainer _diContainer; // 0x240
		private readonly List<GameObject> _spawned; // 0x248
		private PlayerOptions _playerOptions; // 0x250
		private MultiplayerManager _multiplayer; // 0x258
		private AdventureManager _adventureManager; // 0x260
		private CharacterData _currentData; // 0x268
		private VampireSurvivors.Data.CharacterType _currentType; // 0x270
		private LargeMultiOptionPopup _AISelectionPopup; // 0x278
		private LargeMultiOptionPopup _PartySizeSelectionPopup; // 0x280
		private CharSelectionCheatCodeManager _cheats; // 0x288
		private bool _characterConfirmed; // 0x290
		private bool _subscribedToMultiplayerRefresh; // 0x291
		private List<Image> _skinSlots; // 0x298
		private List<int> _weirdCharacters; // 0x2A0
		private List<VampireSurvivors.Data.CharacterType> _tempUnlockedCoopCharacters; // 0x2A8
		private readonly float _iconUIScale; // 0x2B0
		private int _selectedPlayerSlotIndex; // 0x2B4
		private int _partySize; // 0x2B8
		private List<AIType> _IndexTypes; // 0x2C0
	
		// Properties
		private bool _partyModeEnabled { get => default; } // 0x0000000186853890-0x0000000186853950 
	
		// Nested types
		private enum State // TypeDefIndex: 14723
		{
			SINGLEPLAYER = 0,
			MULTIPLAYER = 1
		}
	
		// Constructors
		public CharacterSelectionPage() {} // 0x0000000186868E60-0x00000001868696F0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, DataManager dataManager, DiContainer diContainer, MultiplayerManager multi, AdventureManager adventureManager) {} // 0x0000000186853950-0x0000000186853B90
		private void Start() {} // 0x0000000186853B90-0x0000000186853E80
		private void AllocatePlayersToSlots() {} // 0x0000000186853E80-0x0000000186854430
		private void RemovePlayersFromSlots() {} // 0x0000000186854430-0x0000000186854610
		private void HandleBackButton() {} // 0x0000000186854610-0x0000000186854CB0
		protected override void Update() {} // 0x0000000186854CB0-0x0000000186855540
		private void LateUpdate() {} // 0x0000000186855540-0x0000000186855550
		private void EnterCoopMode() {} // 0x0000000186855550-0x0000000186855620
		private void ClearPlayers() {} // 0x0000000186855620-0x0000000186855740
		private void OnDestroy() {} // 0x0000000186855740-0x0000000186855800
		public void RefreshCharacters() {} // 0x0000000186855800-0x0000000186856180
		[IteratorStateMachine(typeof(_SelectAfterFrameDelay_d__77))]
		private IEnumerator SelectAfterFrameDelay() => default; // 0x0000000186856180-0x0000000186856220
		public void ConfirmCharacter() {} // 0x0000000186856220-0x00000001868564B0
		private void GoToNextCharacterOrContinue() {} // 0x00000001868564B0-0x0000000186856E30
		public void SetEggs(bool b) {} // 0x0000000186856E30-0x0000000186856E80
		public void SelectCharacter(bool fromUnlock) {} // 0x0000000186856E80-0x0000000186857180
		public void BuyCharacter() {} // 0x0000000186857180-0x0000000186857900
		public void IncreaseMaxWeapons() {} // 0x0000000186857900-0x0000000186857A20
		private GameObject GetBonusButton() => default; // 0x0000000186857A20-0x0000000186857B30
		private void WrapNavigation() {} // 0x0000000186857B30-0x0000000186858030
		private bool HasCharUnlock(string characterToUnlock, List<VampireSurvivors.Data.CharacterType> charactersToUnlock = null) => default; // 0x0000000186858030-0x0000000186858160
		private bool HasSkinUnlock(List<SkinToUnlock> skinsToUnlock = null) => default; // 0x0000000186858160-0x0000000186858360
		private void SetVisualStateUnlockable() {} // 0x0000000186858360-0x00000001868586E0
		private void SetVisualStatePurchasable() {} // 0x00000001868586E0-0x0000000186858BD0
		private void SetVisualStateAvailable() {} // 0x0000000186858BD0-0x0000000186858ED0
		public void ShowCharacterInfo(CharacterData charData, VampireSurvivors.Data.CharacterType cType, CharacterItemUI character) {} // 0x0000000186858ED0-0x0000000186859ED0
		private void SetPanelVisualState() {} // 0x0000000186859ED0-0x000000018685A080
		private void UpdateNavigationOnCharSelected() {} // 0x000000018685A080-0x000000018685A590
		private void UpdateEggCount() {} // 0x000000018685A590-0x000000018685A790
		private void SetCharPanelDescription(string descText, bool isHidden = false /* Metadata: 0x019771EE */, bool isSecret = false /* Metadata: 0x019771EF */) {} // 0x000000018685A790-0x000000018685A8F0
		private void SetUnlockableDescription() {} // 0x000000018685A8F0-0x000000018685B220
		private void SetIconSizes() {} // 0x000000018685B220-0x000000018685B960
		private void ResetDisplay(bool playerLeftGame) {} // 0x000000018685B960-0x000000018685BE60
		private bool CanSeeSkins() => default; // 0x000000018685BE60-0x000000018685BFC0
		public void NextSkin() {} // 0x000000018685BFC0-0x000000018685C510
		private void SetSkinSlots() {} // 0x000000018685C510-0x000000018685D310
		protected override void OnShowStart(GameObject g) {} // 0x000000018685D310-0x000000018685E500
		private void OnPlayerButtonClicked(int index) {} // 0x000000018685E500-0x000000018685E700
		private LargeMultiOptionPopup ShowAISettingsPopup(int index) => default; // 0x000000018685E700-0x000000018685F490
		private void PlayerSlotSelection(int index, int aiTypeIndex) {} // 0x000000018685F490-0x0000000186860490
		private void SetVisibility(UISignals.SetCharacterSelectionPageVisibility sig) {} // 0x0000000186860490-0x0000000186860550
		private void ForceSelectCharacter(UISignals.ForceSelectionOnCharacterSelectionPageSignal sig) {} // 0x0000000186860550-0x0000000186860670
		private void AddCharactersFromSignal(UISignals.AddNewCharactersToSelectionPageSignal sig) {} // 0x0000000186860670-0x0000000186860C80
		private void RebuildNavigationAfterCreditsReveal() {} // 0x0000000186860C80-0x0000000186860E70
		public void SpawnDoilie(CharacterItemUI c) {} // 0x0000000186860E70-0x00000001868616B0
		public void SpawnMinorDoilie() {} // 0x00000001868616B0-0x0000000186862220
		private void SetDisplayType() {} // 0x0000000186862220-0x0000000186862520
		private void OnPlayerRemoved(global::Rewired.Player removedPlayer) {} // 0x0000000186862520-0x0000000186862710
		private void ResetPlayerSelections(global::Rewired.Player newPlayer) {} // 0x0000000186862710-0x0000000186862960
		protected override void OnEnterPressed() {} // 0x0000000186862960-0x0000000186862EA0
		private LargeMultiOptionPopup ShowPartySizePopup() => default; // 0x0000000186862EA0-0x00000001868633D0
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868633D0-0x0000000186864100
		protected override void OnHideStart(GameObject g) {} // 0x0000000186864100-0x00000001868641C0
		private void Detune() {} // 0x00000001868641C0-0x0000000186864260
		private void setupRNJ(CharacterData dat, VampireSurvivors.Data.CharacterType cType) {} // 0x0000000186864260-0x0000000186864DA0
		private void setupMIS(CharacterData ddata, VampireSurvivors.Data.CharacterType cType) {} // 0x0000000186864DA0-0x00000001868661E0
		private string CharCodeToString(int[] codes) => default; // 0x00000001868661E0-0x0000000186866330
		private void Populate() {} // 0x0000000186866330-0x0000000186867860
		private void UpdateStatsPanelVisibility() {} // 0x0000000186867860-0x0000000186867930
		private GameObject AddCharacter(CharacterItem cItem) => default; // 0x0000000186867930-0x0000000186867AB0
		[IteratorStateMachine(typeof(_WaitAndDo_d__127))]
		private IEnumerator WaitAndDo(Action cb) => default; // 0x0000000186867AB0-0x0000000186867B50
		private void SetCharacterSprite(VampireSurvivors.Data.CharacterType cType, CharacterData cData) {} // 0x0000000186867B50-0x0000000186867C50
		private void SetCharacterName(VampireSurvivors.Data.CharacterType cType, CharacterData cData) {} // 0x0000000186867C50-0x0000000186867D80
		private void SetWeaponIconSprite(CharacterData characterData) {} // 0x0000000186867D80-0x0000000186868150
		private void MakeDisplayMultiplayer() {} // 0x0000000186868150-0x00000001868684B0
		private void MakeDisplaySingleplayer() {} // 0x00000001868684B0-0x00000001868685D0
		private void RefreshMaxWeaponsAndEggsDisplay() {} // 0x00000001868685D0-0x0000000186868890
		private void SpawnPlayerItem(int index) {} // 0x0000000186868890-0x0000000186868E60
	}
}
