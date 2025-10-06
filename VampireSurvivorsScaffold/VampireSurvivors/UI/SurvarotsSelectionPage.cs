/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SurvarotsSelectionPage : BaseUIPage, ISetArcanaInfo // TypeDefIndex: 15009
	{
		// Fields
		[SerializeField]
		private Transform _cardInfoPanelsRoot; // 0xE0
		[FormerlySerializedAs("_TitleGroup")]
		[FormerlySerializedAs("_TitlePanel")]
		[SerializeField]
		private RectTransform _titleGroup; // 0xE8
		[FormerlySerializedAs("_CardContainer")]
		[SerializeField]
		private RectTransform _cardContainer; // 0xF0
		[FormerlySerializedAs("_MinorCardContainer")]
		[SerializeField]
		private RectTransform _minorCardContainer; // 0xF8
		[FormerlySerializedAs("_ArcanaCardPrefab")]
		[SerializeField]
		private GameObject _arcanaCardPrefab; // 0x100
		[SerializeField]
		private GameObject _boosterButton; // 0x108
		[SerializeField]
		private TextMeshProUGUI _boosterPriceText; // 0x110
		[SerializeField]
		private RectTransform _CurrencyPanel; // 0x118
		[FormerlySerializedAs("_GetButton")]
		[SerializeField]
		private GameObject _getButton; // 0x120
		[FormerlySerializedAs("_TopParticles")]
		[SerializeField]
		private ParticleEmitterManager _topParticles; // 0x128
		[FormerlySerializedAs("_BottomParticles")]
		[SerializeField]
		private ParticleEmitterManager _bottomParticles; // 0x130
		[FormerlySerializedAs("_CardOrigin")]
		[SerializeField]
		private RectTransform _cardOrigin; // 0x138
		[FormerlySerializedAs("_SelectedCardOrigin")]
		[SerializeField]
		private RectTransform _selectedCardOrigin; // 0x140
		[FormerlySerializedAs("_BlackFader")]
		[SerializeField]
		private Image _blackFader; // 0x148
		[FormerlySerializedAs("_CollectRandomButton")]
		[SerializeField]
		private Image _collectRandomButton; // 0x150
		[FormerlySerializedAs("_MajorSelectionGroup")]
		[SerializeField]
		private GameObject _majorSelectionGroup; // 0x158
		[FormerlySerializedAs("_MinorSelectionGroup")]
		[SerializeField]
		private GameObject _minorSelectionGroup; // 0x160
		[FormerlySerializedAs("_BigArcanaCard")]
		[SerializeField]
		private GameObject _bigArcanaCard; // 0x168
		[FormerlySerializedAs("_StripContainer")]
		[SerializeField]
		private RectTransform _stripContainer; // 0x170
		[FormerlySerializedAs("_MinorGetButton")]
		[SerializeField]
		private RectTransform _minorGetButton; // 0x178
		[FormerlySerializedAs("_SkipButton")]
		[SerializeField]
		private RectTransform _skipButton; // 0x180
		[FormerlySerializedAs("_RerollButton")]
		[SerializeField]
		private RectTransform _rerollButton; // 0x188
		[FormerlySerializedAs("_RerollCountText")]
		[SerializeField]
		private TextMeshProUGUI _rerollCountText; // 0x190
		[FormerlySerializedAs("_SkipCountText")]
		[SerializeField]
		private TextMeshProUGUI _skipCountText; // 0x198
		[FormerlySerializedAs("_EquipmentPanel")]
		[SerializeField]
		private PauseEquipmentPanel _equipmentPanel; // 0x1A0
		[FormerlySerializedAs("_CharacterStatsPanel")]
		[SerializeField]
		private GameObject _characterStatsPanel; // 0x1A8
		[FormerlySerializedAs("_DEBUGPAGE2")]
		[SerializeField]
		private bool _debugpage2; // 0x1B0
		[FormerlySerializedAs("_RerollAnimContainer")]
		[SerializeField]
		private RectTransform _rerollAnimContainer; // 0x1B8
		[FormerlySerializedAs("_InfoGroup")]
		[FormerlySerializedAs("_InfoPanel")]
		[SerializeField]
		private RectTransform _infoGroup; // 0x1C0
		[FormerlySerializedAs("_MinorBackground")]
		[FormerlySerializedAs("_MinorPanel")]
		[SerializeField]
		private RectTransform _minorBackground; // 0x1C8
		[FormerlySerializedAs("_MajorBackground")]
		[FormerlySerializedAs("_MajorPanel")]
		[SerializeField]
		private RectTransform _majorBackground; // 0x1D0
		[SerializeField]
		private RectTransform _majorForeground; // 0x1D8
		[FormerlySerializedAs("_TitleBackground")]
		[FormerlySerializedAs("_HeaderPanel")]
		[SerializeField]
		private RectTransform _titleBackground; // 0x1E0
		[FormerlySerializedAs("_CharacterPanelBackground")]
		[SerializeField]
		private RectTransform _characterPanelBackground; // 0x1E8
		[FormerlySerializedAs("_CharacterPanel")]
		[SerializeField]
		private GameObject _characterPanel; // 0x1F0
		[FormerlySerializedAs("_CharacterImage")]
		[SerializeField]
		private Image _characterImage; // 0x1F8
		[FormerlySerializedAs("_CardRings")]
		[SerializeField]
		private List<SpinningRingOfCards> _cardRings; // 0x200
		[FormerlySerializedAs("_MaxWeaponsBeforeCarousel")]
		[SerializeField]
		private int _maxWeaponsBeforeCarousel; // 0x208
		[SerializeField]
		private CardInfoUI _cardInfoUI; // 0x210
		[SerializeField]
		private CardRiskInfoUI _survarotInfoRisk; // 0x218
		[SerializeField]
		private CardEditionInfoUI _survarotInfoEdition; // 0x220
		private List<GameObject> _spawned; // 0x228
		private List<GameObject> _allSpawnedInOrder; // 0x230
		private DataManager _data; // 0x238
		private PlayerOptions _playerOptions; // 0x240
		private SignalBus _signalBus; // 0x248
		private CharacterSkillCard_Base _currentSelected; // 0x250
		private string _arcanaCacheGroupName; // 0x258
		private Selectable _previouslyHighlightedDraftCard; // 0x260
		private int _lastSelected; // 0x268
		private ArcanaCardUI _selected; // 0x270
		private bool _hasPickedRandom; // 0x278
		private bool _hasFreeReroll; // 0x279
		private VampireSurvivors.Objects.Characters.CharacterController _controllingCharacter; // 0x280
		private bool _hasFinishedPopulationAnimation; // 0x288
		private bool _rngInit; // 0x289
		private Unity.Mathematics.Random _random; // 0x28C
		private int _boostersBought; // 0x290
	
		// Constructors
		public SurvarotsSelectionPage() {} // 0x00000001869AADD0-0x00000001869AB050
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player, SignalBus signalBus) {} // 0x000000018699E380-0x000000018699EA00
		protected override void Awake() {} // 0x000000018699EA00-0x000000018699EB00
		[IteratorStateMachine(typeof(_SpawnContent_d__60))]
		public IEnumerator SpawnContent() => default; // 0x000000018699EB00-0x000000018699EBA0
		private void OnDestroy() {} // 0x000000018699EBA0-0x000000018699EED0
		protected override void OnShowStart(GameObject g) {} // 0x000000018699EED0-0x000000018699F6C0
		private void GetControllingCharacter() {} // 0x000000018699F6C0-0x00000001869A0620
		protected override void OnShowFinish(GameObject g) {} // 0x00000001869A0620-0x00000001869A06A0
		private void InitializeRingsOfCards() {} // 0x00000001869A06A0-0x00000001869A0820
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x00000001869A0820-0x00000001869A0830
		private void UpdateButtonNavigation() {} // 0x00000001869A0830-0x00000001869A0A10
		public void Skip() {} // 0x00000001869A0A10-0x00000001869A0BE0
		private void PerformSkip() {} // 0x00000001869A0BE0-0x00000001869A0C70
		private void SetReRollButton() {} // 0x00000001869A0C70-0x00000001869A10C0
		private void SetBoosterButton() {} // 0x00000001869A10C0-0x00000001869A1270
		private float CurrentBoosterCost() => default; // 0x00000001869A1270-0x00000001869A14D0
		public void Booster() {} // 0x00000001869A14D0-0x00000001869A1690
		private void PerformBooster() {} // 0x00000001869A1690-0x00000001869A2D30
		private void PurchaseBooster() {} // 0x00000001869A2D30-0x00000001869A2D70
		private void PerformReRoll() {} // 0x00000001869A2D70-0x00000001869A4390
		public void Reroll() {} // 0x00000001869A4390-0x00000001869A4550
		protected override void OnHideFinish(GameObject g) {} // 0x00000001869A4550-0x00000001869A45C0
		private void PopulateMenu() {} // 0x00000001869A45C0-0x00000001869A60E0
		private void EnableInputFirstMenu() {} // 0x00000001869A60E0-0x00000001869A6170
		private void SetRandomButton() {} // 0x00000001869A6170-0x00000001869A6220
		[IteratorStateMachine(typeof(_WaitAndConfigureRandomButton_d__82))]
		private IEnumerator WaitAndConfigureRandomButton() => default; // 0x00000001869A6220-0x00000001869A62C0
		[IteratorStateMachine(typeof(_WaitAndSelect_d__83))]
		private IEnumerator WaitAndSelect(GameObject forcedSelect = null) => default; // 0x00000001869A62C0-0x00000001869A6360
		private void InitializeNormalArcanaParticles() {} // 0x00000001869A6360-0x00000001869A74A0
		private ArcanaCardUI SpawnCharacterCard(ArcanaData data, ArcanaType type, SkillCardEdition edition) => default; // 0x00000001869A74A0-0x00000001869A7830
		private void AddStrips() {} // 0x00000001869A7830-0x00000001869A8A40
		private void ClearSpawned() {} // 0x00000001869A8A40-0x00000001869A8C70
		private void SelectArcana() {} // 0x00000001869A8C70-0x00000001869A8E20
		private void OnSelectedCharacterCardRemotely(OnlineSignals.OnlineSelectedCharacterCard cardInfo) {} // 0x00000001869A8E20-0x00000001869A8F10
		private void OnReRolledCharacterCardsRemotely() {} // 0x00000001869A8F10-0x00000001869A8F20
		private void OnBoosterSurvarotsRemotely() {} // 0x00000001869A8F20-0x00000001869A8F30
		private void PlayJingle() {} // 0x00000001869A8F30-0x00000001869A90B0
		private void PlayLightSound() {} // 0x00000001869A8F30-0x00000001869A90B0
		public void SetInfo(ArcanaData data, ArcanaType type, ArcanaCardUI ui) {} // 0x00000001869A90B0-0x00000001869A9520
		public void Select() {} // 0x00000001869A9520-0x00000001869A96C0
		public void Random() {} // 0x00000001869A96C0-0x00000001869AACD0
		private void OpenMenu() {} // 0x00000001869AACD0-0x00000001869AADD0
	}
}
