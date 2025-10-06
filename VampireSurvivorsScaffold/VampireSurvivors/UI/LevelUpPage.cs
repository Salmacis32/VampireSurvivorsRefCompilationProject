/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Log;
using DG.Tweening;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.UI.Twitch;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class LevelUpPage : BaseUIPage // TypeDefIndex: 14843
	{
		// Fields
		[SerializeField]
		private GameObject _luck; // 0xE0
		[SerializeField]
		private RectTransform Container; // 0xE8
		[SerializeField]
		private GameObject LevelUpItemPrefab; // 0xF0
		[SerializeField]
		private Image ProgressBar; // 0xF8
		[SerializeField]
		private RectTransform _Panel; // 0x100
		[SerializeField]
		private UISpriteAnimation _ExplosionVFX; // 0x108
		[SerializeField]
		private GameObject _SkipButton; // 0x110
		[SerializeField]
		private TextMeshProUGUI _SkipRemainingText; // 0x118
		[SerializeField]
		private GameObject _RerollButton; // 0x120
		[SerializeField]
		private TextMeshProUGUI _RerollRemainingText; // 0x128
		[SerializeField]
		private GameObject _BanishButton; // 0x130
		[SerializeField]
		private TextMeshProUGUI _BanishRemainingText; // 0x138
		[SerializeField]
		private GameObject _PassButton; // 0x140
		[SerializeField]
		private TextMeshProUGUI _PassRemainingText; // 0x148
		[SerializeField]
		private ParticleSystem _Gems; // 0x150
		[SerializeField]
		private GameObject _CancelButton; // 0x158
		[SerializeField]
		private Image _RedFadey; // 0x160
		[SerializeField]
		private Localize _Title; // 0x168
		[SerializeField]
		private UISpriteAnimation _BanishVFX; // 0x170
		[SerializeField]
		private GameObject _Equipment; // 0x178
		[SerializeField]
		private List<PauseEquipmentPanel> _EquipmentPanels; // 0x180
		[SerializeField]
		private GameObject _CharacterStatsPanel; // 0x188
		[SerializeField]
		private GameObject _LimitBreakRandomOnce; // 0x190
		[SerializeField]
		private GameObject _LimitBreakRandomAlways; // 0x198
		[SerializeField]
		private RectTransform _BanishedWeaponsContainer; // 0x1A0
		[SerializeField]
		private GameObject _BanishedWeaponPrefab; // 0x1A8
		[SerializeField]
		private ParticleEmitterManager _GemManager; // 0x1B0
		[SerializeField]
		private SpriteReel _LeftBanner; // 0x1B8
		[SerializeField]
		private SpriteReel _RightBanner; // 0x1C0
		[SerializeField]
		private VerticalLayoutGroup _LeftStatsLayoutGroup; // 0x1C8
		[SerializeField]
		private TwitchLevelUpPanel _TwitchLevelUpPanel; // 0x1D0
		[SerializeField]
		private GameObject _SuggestText; // 0x1D8
		private SignalBus _signalBus; // 0x1E0
		private LevelUpFactory _levelUpFactory; // 0x1E8
		private DataManager _data; // 0x1F0
		private GameSessionData _gameSession; // 0x1F8
		private PlayerOptions _playerOptions; // 0x200
		private LimitBreakManager _limitBreakManager; // 0x208
		private bool _isBanishMode; // 0x210
		private readonly List<LevelUpItemUI> _spawnedItems; // 0x218
		private Dictionary<WeaponType, List<WeaponData>> _weaponData; // 0x220
		private List<WeaponType> _currentWeapons; // 0x228
		private List<GameObject> _banishedWeaponList; // 0x230
		private DG.Tweening.Sequence _colorTween; // 0x238
		private ParticleSystem _Cats; // 0x240
		private bool _hasReRolls; // 0x248
		private bool _hasSkips; // 0x249
		private bool _hasBanish; // 0x24A
		private bool _canPass; // 0x24B
		private bool _canLimitBreak; // 0x24C
		private bool _isDoingALimitBreak; // 0x24D
		private bool _particlesBuilt; // 0x24E
		private List<Tween> _activeTweens; // 0x250
		private bool _hasPassed; // 0x258
		private bool _hasSelected; // 0x259
		private Coherence.Log.Logger _logger; // 0x260
	
		// Properties
		public List<LevelUpItemUI> LevelUpItems { get => default; } // 0x00000001865DBE50-0x00000001865DBE60 
		public bool HasReRolls { get => default; set {} } // 0x00000001868BE160-0x00000001868BE170 0x00000001868BE170-0x00000001868BE180
		public bool HasSkips { get => default; set {} } // 0x00000001868BE180-0x00000001868BE190 0x00000001868BE190-0x00000001868BE1A0
		public bool HasBanish { get => default; set {} } // 0x00000001868BE1A0-0x00000001868BE1B0 0x00000001868BE1B0-0x00000001868BE1C0
		public bool CanPass { get => default; set {} } // 0x00000001868BE1C0-0x00000001868BE1D0 0x00000001868BE1D0-0x00000001868BE1E0
		public GameObject RerollButton { get => default; } // 0x00000001829475F0-0x0000000182947600 
		public GameObject SkipButton { get => default; } // 0x0000000182A45AF0-0x0000000182A45B00 
		public GameObject BanishButton { get => default; } // 0x0000000182A45B90-0x0000000182A45BA0 
		public GameObject CancelButton { get => default; } // 0x0000000184755AB0-0x0000000184755AC0 
		public GameObject PassButton { get => default; } // 0x0000000184F612F0-0x0000000184F61300 
	
		// Constructors
		public LevelUpPage() {} // 0x00000001868D0090-0x00000001868D0470
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, LevelUpFactory levelUpFactory, DataManager data, GameSessionData session, PlayerOptions playerOptions, LimitBreakManager limitBreak) {} // 0x00000001868BE1E0-0x00000001868BE420
		private void OnDestroy() {} // 0x00000001868BE420-0x00000001868BEC00
		public void Reroll() {} // 0x00000001868BEC00-0x00000001868BEF50
		public void SetBanishMode() {} // 0x00000001868BEF50-0x00000001868BF3F0
		private void UpdateFriendshipAmuletForBanishState(bool isInBanishMode) {} // 0x00000001868BF3F0-0x00000001868BF570
		public void CancelBanishMode() {} // 0x00000001868BF570-0x00000001868BF8A0
		[IteratorStateMachine(typeof(_DelaySetFooter_d__86))]
		private IEnumerator DelaySetFooter(bool enabled) => default; // 0x00000001868BF8A0-0x00000001868BF950
		[IteratorStateMachine(typeof(_WaitSelectBanish_d__87))]
		private IEnumerator WaitSelectBanish(bool isOn) => default; // 0x00000001868BF950-0x00000001868BFA00
		public void SelectWeapon(WeaponType type, LevelUpItemUI ui) {} // 0x00000001868BFA00-0x00000001868BFD00
		private void BlockAllSelectables() {} // 0x00000001868BFD00-0x00000001868BFE80
		private void BlockAllButtons() {} // 0x00000001868BFE80-0x00000001868C00B0
		private void EnableLevelupOptions() {} // 0x00000001868C00B0-0x00000001868C02C0
		private void DisableLevelupOptions() {} // 0x00000001868C02C0-0x00000001868C04D0
		public void SelectLimitBreak(WeightedLimitBreak wl, int index) {} // 0x00000001868C04D0-0x00000001868C0750
		private void HandleLimitBreakLevelUp(WeightedLimitBreak wl, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter) {} // 0x00000001868C0750-0x00000001868C0A80
		public void BanishWeapon(WeaponType type, LevelUpItemUI ui) {} // 0x00000001868C0A80-0x00000001868C12B0
		public void SelectItem(ItemData item, VampireSurvivors.Data.ItemType type) {} // 0x00000001868C12B0-0x00000001868C1590
		private void ProcessItemLevelUp(VampireSurvivors.Data.ItemType type, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter) {} // 0x00000001868C1590-0x00000001868C16C0
		private void ProcessFriendshipAmuletLevelup() {} // 0x00000001868C16C0-0x00000001868C1760
		public void Skip() {} // 0x00000001868C1760-0x00000001868C18C0
		public void LevelUpSkip() {} // 0x00000001868C18C0-0x00000001868C1B00
		private void CheckIfPassAvailable() {} // 0x00000001868C1B00-0x00000001868C1E10
		private bool CanCharacterReceivePass(VampireSurvivors.Objects.Characters.CharacterController chara) => default; // 0x00000001868C1E10-0x00000001868C2290
		public void Pass() {} // 0x00000001868C2290-0x00000001868C2580
		private bool FindViablePassPlayer() => default; // 0x00000001868C2580-0x00000001868C26E0
		private void PerformPass(bool showStats) {} // 0x00000001868C26E0-0x00000001868C3990
		private void ShowMultiplayerBanners() {} // 0x00000001868C3990-0x00000001868C3AB0
		[IteratorStateMachine(typeof(_SelectElementLater_d__107))]
		private IEnumerator SelectElementLater(Selectable s) => default; // 0x00000001868C3AB0-0x00000001868C3B50
		public void LimitBreakRandomOnce() {} // 0x00000001868C3B50-0x00000001868C3B60
		public void LimitBreakRandomAlways() {} // 0x00000001868C3B60-0x00000001868C3BA0
		protected override void Awake() {} // 0x00000001868C3BA0-0x00000001868C4AF0
		private void OnLevelUpWithLimitBreak(OnlineSignals.OnlineLevelUpWithLimitBreak levelUpWithLimitBreak) {} // 0x00000001868C4AF0-0x00000001868C4F60
		private void OnLevelUpWithItem(OnlineSignals.OnlineLevelUpWithItem levelUpWithItem) {} // 0x00000001868C4F60-0x00000001868C4F70
		private void OnLevelUpWithFriendshipAmulet(OnlineSignals.OnlineLevelUpWithFriendshipAmulet levelUpWithAmulet) {} // 0x00000001868C16C0-0x00000001868C1760
		private void OnLevelUpPassRequested() {} // 0x00000001868C4F70-0x00000001868C5000
		private void OnLevelUpPass(OnlineSignals.OnlineLevelUpPass pass) {} // 0x00000001868C5000-0x00000001868C51B0
		private void OnLevelUpReRoll(OnlineSignals.OnlineLevelUpReRoll reRoll) {} // 0x00000001868C51B0-0x00000001868C5210
		private void OnLevelUpReRollRequest() {} // 0x00000001868C5210-0x00000001868C5370
		private void OnWeaponBanishedRemotely(UISignals.BanishWeaponLevelUpSignal banishedSignal) {} // 0x00000001868C5370-0x00000001868C5520
		protected override void Update() {} // 0x00000001868C5520-0x00000001868C56D0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868C56D0-0x00000001868C6940
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x00000001868C6940-0x00000001868C69D0
		[IteratorStateMachine(typeof(_ForceLeftLayoutDelayed_d__122))]
		private IEnumerator ForceLeftLayoutDelayed() => default; // 0x00000001868C69D0-0x00000001868C6A70
		private void BuildParticles() {} // 0x00000001868C6A70-0x00000001868C7D20
		private void BuildBanishedWeaponsList() {} // 0x00000001868C7D20-0x00000001868C8AD0
		private void UpdateButtonsUI() {} // 0x00000001868C8AD0-0x00000001868C90A0
		private void ValidateButtonStates() {} // 0x00000001868C90A0-0x00000001868C9520
		private void DoIntroEffects() {} // 0x00000001868C9520-0x00000001868C99D0
		[IteratorStateMachine(typeof(_TweenButtonsNextFrame_d__128))]
		private IEnumerator TweenButtonsNextFrame() => default; // 0x00000001868C99D0-0x00000001868C9A70
		private DG.Tweening.Sequence TweenButtonIn(GameObject g, float baseScale = 1f /* Metadata: 0x01977214 */) => default; // 0x00000001868C9A70-0x00000001868C9EC0
		private void Animate() {} // 0x00000001868C9EC0-0x00000001868CA6D0
		private void OnLevelUpPageIntroAnimComplete() {} // 0x00000001868CA6D0-0x00000001868CA790
		protected override void OnHideStart(GameObject g) {} // 0x00000001868CA790-0x00000001868CAA30
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868CAA30-0x00000001868CB700
		private void Populate() {} // 0x00000001868CB700-0x00000001868CC810
		private void PickRandomLimitBreaks() {} // 0x00000001868CC810-0x00000001868CC8D0
		private void PickRandomLevelUps() {} // 0x00000001868CC8D0-0x00000001868CD290
		private void ResetLevelUpViewsAfterReRoll() {} // 0x00000001868CD290-0x00000001868CE2B0
		private void PickItemLevelUps() {} // 0x00000001868CE2B0-0x00000001868CE520
		private void SpawnItem(VampireSurvivors.Data.ItemType type, ItemData data, int index, List<VampireSurvivors.Objects.Characters.CharacterController> affectedCharacters = null) {} // 0x00000001868CE520-0x00000001868CE650
		private void SpawnLimitBreak(WeightedLimitBreak d, int index) {} // 0x00000001868CE650-0x00000001868CE8E0
		private List<Sprite> AddEvoSpritesForPlayer(WeaponData data, WeaponType type, VampireSurvivors.Objects.Characters.CharacterController player, bool checkSlotLimits = false /* Metadata: 0x01977218 */) => default; // 0x00000001868CE8E0-0x00000001868CF430
		private bool IsEvolutionUnlocked(WeaponData data) => default; // 0x00000001868CF430-0x00000001868CF570
		private void SpawnWeapon(WeaponData data, WeaponType type, int index) {} // 0x00000001868CF570-0x00000001868CFCC0
		private void ChooseRandomLimitBreak() {} // 0x00000001868CFCC0-0x00000001868D0080
		private void EditorSkipLevelUp() {} // 0x00000001868D0080-0x00000001868D0090
	}
}
