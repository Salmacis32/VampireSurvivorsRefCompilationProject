/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
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
	public class ArcanaMainSelectionPage : BaseUIPage, ISetArcanaInfo // TypeDefIndex: 14684
	{
		// Fields
		[SerializeField]
		private ArcanaInfoPanel _ArcanaInfoPanel; // 0xE0
		[SerializeField]
		private Localize _Count; // 0xE8
		[FormerlySerializedAs("_TitlePanel")]
		[SerializeField]
		private RectTransform _TitleGroup; // 0xF0
		[SerializeField]
		private RectTransform _CardContainer; // 0xF8
		[SerializeField]
		private RectTransform _MinorCardContainer; // 0x100
		[SerializeField]
		private GameObject _ArcanaCardPrefab; // 0x108
		[SerializeField]
		private GameObject _RandomButton; // 0x110
		[SerializeField]
		private GameObject _GetButton; // 0x118
		[SerializeField]
		private ParticleEmitterManager _TopParticles; // 0x120
		[SerializeField]
		private ParticleEmitterManager _BottomParticles; // 0x128
		[SerializeField]
		private RectTransform _CardOrigin; // 0x130
		[SerializeField]
		private RectTransform _SelectedCardOrigin; // 0x138
		[SerializeField]
		private Image _BlackFader; // 0x140
		[SerializeField]
		private Image _CollectRandomButton; // 0x148
		[SerializeField]
		private GameObject _MajorSelectionGroup; // 0x150
		[SerializeField]
		private GameObject _MinorSelectionGroup; // 0x158
		[SerializeField]
		private GameObject _BigArcanaCard; // 0x160
		[SerializeField]
		private RectTransform _StripContainer; // 0x168
		[SerializeField]
		private RectTransform _MinorGetButton; // 0x170
		[SerializeField]
		private RectTransform _SkipButton; // 0x178
		[SerializeField]
		private RectTransform _RerollButton; // 0x180
		[SerializeField]
		private TextMeshProUGUI _RerollCountText; // 0x188
		[SerializeField]
		private TextMeshProUGUI _SkipCountText; // 0x190
		[SerializeField]
		private PauseEquipmentPanel _EquipmentPanel; // 0x198
		[SerializeField]
		private GameObject _CharacterStatsPanel; // 0x1A0
		[SerializeField]
		private bool _DEBUGPAGE2; // 0x1A8
		[SerializeField]
		private RectTransform _RerollAnimContainer; // 0x1B0
		[FormerlySerializedAs("_InfoPanel")]
		[SerializeField]
		private RectTransform _InfoGroup; // 0x1B8
		[FormerlySerializedAs("_MinorPanel")]
		[SerializeField]
		private RectTransform _MinorBackground; // 0x1C0
		[FormerlySerializedAs("_MajorPanel")]
		[SerializeField]
		private RectTransform _MajorBackground; // 0x1C8
		[FormerlySerializedAs("_HeaderPanel")]
		[SerializeField]
		private RectTransform _TitleBackground; // 0x1D0
		[SerializeField]
		private RectTransform _CharacterPanelBackground; // 0x1D8
		[SerializeField]
		private GameObject _CharacterPanel; // 0x1E0
		[SerializeField]
		private Image _CharacterImage; // 0x1E8
		[SerializeField]
		private List<SpinningRingOfCards> _CardRings; // 0x1F0
		[SerializeField]
		private int _MaxWeaponsBeforeCarousel; // 0x1F8
		[SerializeField]
		private ArcanaDisplayContainer _DisplayContainer; // 0x200
		[Header("Darkana")]
		[SerializeField]
		private GameObject _TentaclePrefab; // 0x208
		[SerializeField]
		private RectTransform _TentacleSpawnRotator; // 0x210
		[SerializeField]
		private RectTransform _TentacleSpawnAnchor; // 0x218
		[SerializeField]
		private TextMeshProUGUI _TitleText; // 0x220
		[SerializeField]
		private GameObject _TitleBloodMask; // 0x228
		[SerializeField]
		private GameObject _PanelBloodMask; // 0x230
		[SerializeField]
		private GameObject _InfoBloodMask; // 0x238
		[SerializeField]
		private GameObject _MinorBloodMask; // 0x240
		[SerializeField]
		private GameObject _CharacterPanelBloodMask; // 0x248
		[SerializeField]
		private RectTransform _D20; // 0x250
		[SerializeField]
		private ParticleEmitterManager _TopDarkanaParticles; // 0x258
		[SerializeField]
		private ParticleEmitterManager _BottomDarkanaParticles; // 0x260
		[SerializeField]
		private RectTransform _Skull; // 0x268
		[SerializeField]
		private GameObject _DarkButton; // 0x270
		[SerializeField]
		private Image _DarkButtonIcon; // 0x278
		[SerializeField]
		private Image _TitleIcon; // 0x280
		private List<GameObject> _darkSpawned; // 0x288
		private List<GameObject> _spawned; // 0x290
		private List<GameObject> _weaponSpawned; // 0x298
		private List<ArcanaCardUI> _unlockedCards; // 0x2A0
		private List<ArcanaCardUI> _darkUnlockedCards; // 0x2A8
		private List<GameObject> _tentacles; // 0x2B0
		private List<GameObject> _allSpawnedInOrder; // 0x2B8
		private DataManager _data; // 0x2C0
		private PlayerOptions _playerOptions; // 0x2C8
		private SignalBus _signalBus; // 0x2D0
		private ArcanaManager _arcanaManager; // 0x2D8
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x2E0
		private Dictionary<VampireSurvivors.Data.ItemType, ItemData> _items; // 0x2E8
		private ArcanaType _currentSelected; // 0x2F0
		private string _arcanaCacheGroupName; // 0x2F8
		private Material _defaultGameRenderMaterial; // 0x300
		private bool _hasUnlockedDarkanas; // 0x308
		private int _draftCardCount; // 0x30C
		private Tween _d20Tween; // 0x310
		private Selectable previouslyHighlightedDraftCard; // 0x318
		private List<ArcanaType> _draftMajors; // 0x320
		private List<ArcanaType> _discarded; // 0x328
		private int _lastSelected; // 0x330
		private ArcanaCardUI _selected; // 0x338
		private bool _hasPickedRandom; // 0x340
		private bool _hasFreeReroll; // 0x341
		private VampireSurvivors.Objects.Characters.CharacterController _controllingCharacter; // 0x348
		private bool isShowingMinor; // 0x350
		private bool _hasFinishedPopulationAnimation; // 0x351
		private bool _ShowDarkanaFirst; // 0x352
		private bool _willPlayDarkanaIntro; // 0x353
		private ArcanaMode _arcanaMode; // 0x354
		public TentacleMode _tentacleMode; // 0x358
	
		// Events
		public static event OnArcanaModeChange ArcanaModeChanged;
	
		// Nested types
		public delegate void OnArcanaModeChange(ArcanaMode m); // TypeDefIndex: 14667; 0x000000018196C5F0-0x000000018196C600
	
		public enum ArcanaMode // TypeDefIndex: 14668
		{
			LIGHT = 0,
			DARK = 1
		}
	
		public enum TentacleMode // TypeDefIndex: 14669
		{
			TOP = 0,
			ENCIRCLING = 1
		}
	
		// Constructors
		public ArcanaMainSelectionPage() {} // 0x00000001865F3CE0-0x00000001865F42C0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player, ArcanaManager arcana, SignalBus signalBus) {} // 0x00000001865E2CE0-0x00000001865E33C0
		protected override void Awake() {} // 0x00000001865E33C0-0x00000001865E34C0
		[IteratorStateMachine(typeof(_SpawnContent_d__94))]
		public IEnumerator SpawnContent() => default; // 0x00000001865E34C0-0x00000001865E3560
		private void OnDestroy() {} // 0x00000001865E3560-0x00000001865E3890
		protected override void OnShowStart(GameObject g) {} // 0x00000001865E3890-0x00000001865E3CA0
		private void GetControllingCharacter() {} // 0x00000001865E3CA0-0x00000001865E4DB0
		protected override void OnShowFinish(GameObject g) {} // 0x00000001865E4DB0-0x00000001865E4E30
		private void InitializeRingsOfCards() {} // 0x00000001865E4E30-0x00000001865E4FB0
		protected override void Update() {} // 0x00000001865E4FB0-0x00000001865E5540
		private void SetMinorGetNavigation() {} // 0x00000001865E5540-0x00000001865E56E0
		private void PopulateSecondMenu() {} // 0x00000001865E56E0-0x00000001865E7220
		private void EnableInputSecondMenu() {} // 0x00000001865E7220-0x00000001865E72B0
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x00000001865E72B0-0x00000001865E72C0
		private void UpdateButtonNavigation() {} // 0x00000001865E72C0-0x00000001865E7820
		public void Skip() {} // 0x00000001865E7820-0x00000001865E79F0
		private void PerformSkip() {} // 0x00000001865E79F0-0x00000001865E7A80
		private void SetReRollButton() {} // 0x00000001865E7A80-0x00000001865E7F40
		private void PerformReRoll() {} // 0x00000001865E7F40-0x00000001865E94E0
		public void Reroll() {} // 0x00000001865E94E0-0x00000001865E9710
		private void SetBigCardNavigation() {} // 0x00000001865E9710-0x00000001865E9970
		protected override void OnHideFinish(GameObject g) {} // 0x00000001865E9970-0x00000001865E9CA0
		private GameObject SpawnBigCard(ArcanaData data, ArcanaType type, bool isDum = false /* Metadata: 0x019771CC */) => default; // 0x00000001865E9CA0-0x00000001865E9DD0
		private void PopulateFirstMenu() {} // 0x00000001865E9DD0-0x00000001865EBEF0
		private void EnableInputFirstMenu() {} // 0x00000001865EBEF0-0x00000001865EBF80
		private void SetRandomButton() {} // 0x00000001865EBF80-0x00000001865EC030
		[IteratorStateMachine(typeof(_WaitAndConfigureRandomButton_d__117))]
		private IEnumerator WaitAndConfigureRandomButton() => default; // 0x00000001865EC030-0x00000001865EC0D0
		[IteratorStateMachine(typeof(_WaitAndSelect_d__118))]
		private IEnumerator WaitAndSelect(GameObject forcedSelect = null) => default; // 0x00000001865EC0D0-0x00000001865EC170
		[IteratorStateMachine(typeof(_WaitAndForceSelect_d__119))]
		private IEnumerator WaitAndForceSelect(GameObject cardToSelect) => default; // 0x00000001865EC170-0x00000001865EC270
		private void InitializeNormalArcanaParticles() {} // 0x00000001865EC270-0x00000001865ED3B0
		private void InitializeDarkanaParticles() {} // 0x00000001865ED3B0-0x00000001865EE510
		private void InitializeTicklers() {} // 0x00000001865EE510-0x00000001865EEC00
		private ArcanaCardUI SpawnArcanaCard(ArcanaData data, ArcanaType type) => default; // 0x00000001865EEC00-0x00000001865EEFF0
		private void AddStrips() {} // 0x00000001865EEFF0-0x00000001865F00A0
		private void ClearSpawned() {} // 0x00000001865F00A0-0x00000001865F04E0
		private void SelectArcana() {} // 0x00000001865F04E0-0x00000001865F0660
		private void OnSelectedArcanaRemotely(OnlineSignals.OnlineSelectedArcana arcana) {} // 0x00000001865F0660-0x00000001865F0670
		private void OnReRolledArcanasRemotely() {} // 0x00000001865F0670-0x00000001865F0680
		private void OnTransitionArcanaModeRemotely() {} // 0x00000001865F0680-0x00000001865F0690
		public void GoToDarkana() {} // 0x00000001865F0690-0x00000001865F07F0
		private void SwitchArcanaMode() {} // 0x00000001865F07F0-0x00000001865F0F60
		private void PlayJingle() {} // 0x00000001865F0F60-0x00000001865F1040
		private void PlayDarkSound() {} // 0x00000001865F1040-0x00000001865F1100
		private void PlayLightSound() {} // 0x00000001865F1100-0x00000001865F1280
		private void SetDarkDesign() {} // 0x00000001865F1280-0x00000001865F1780
		public void SetLightDesign() {} // 0x00000001865F1780-0x00000001865F1C80
		private void SetCount() {} // 0x00000001865F1C80-0x00000001865F2010
		private void RandomD20Fall() {} // 0x00000001865F2010-0x00000001865F2480
		public void SetInfo(ArcanaData data, ArcanaType type, ArcanaCardUI UI) {} // 0x00000001865F2480-0x00000001865F27E0
		public void Select() {} // 0x00000001865F27E0-0x00000001865F2A50
		public void Random() {} // 0x00000001865F2A50-0x00000001865F3CE0
	}
}
