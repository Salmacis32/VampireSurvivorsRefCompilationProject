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
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OpenTreasurePage : BaseUIPage // TypeDefIndex: 14893
	{
		// Fields
		[SerializeField]
		private bool _PauseOnAnimIntro; // 0xE0
		[SerializeField]
		private List<TreasurePlaybackSettings> PlaybackLevels; // 0xE8
		[SerializeField]
		private UISpriteAnimation _IdleTreasureChest; // 0xF0
		[SerializeField]
		private UISpriteAnimation _OpenTreasureChest; // 0xF8
		[SerializeField]
		private UISpriteAnimation _OpenTreasureChestFront; // 0x100
		[SerializeField]
		private Image _TreasureImage; // 0x108
		[SerializeField]
		private Image _OpenTreasureFrontImage; // 0x110
		[SerializeField]
		private Animator Animator; // 0x118
		[SerializeField]
		private TreasureRibbonTrailGenerator _Ribbons; // 0x120
		[SerializeField]
		private GameObject OpenButton; // 0x128
		[SerializeField]
		private GameObject DoneButton; // 0x130
		[SerializeField]
		private GameObject OpenButtonLeftArrow; // 0x138
		[SerializeField]
		private GameObject OpenButtonRightArrow; // 0x140
		[SerializeField]
		private GameObject DoneButtonLeftArrow; // 0x148
		[SerializeField]
		private GameObject DoneButtonRightArrow; // 0x150
		[SerializeField]
		private TextMeshProUGUI CoinsCount; // 0x158
		[SerializeField]
		private TextMeshProUGUI FinalCoins; // 0x160
		[SerializeField]
		private ParticleSystem PowerParticles; // 0x168
		[SerializeField]
		private TreasureInfoPanel InfoPanel; // 0x170
		[SerializeField]
		private TreasureFireworksManager Fireworks; // 0x178
		[SerializeField]
		private UISpriteAnimation VFXAnimation; // 0x180
		[SerializeField]
		private RectTransform Panel; // 0x188
		[SerializeField]
		private GameObject _Title; // 0x190
		[SerializeField]
		private Image _YellowBackground; // 0x198
		[SerializeField]
		private Image _HeatBackground; // 0x1A0
		[SerializeField]
		private RectTransform _Panel; // 0x1A8
		[SerializeField]
		private Image _BGOverlay; // 0x1B0
		[SerializeField]
		private RectTransform _FireworkContainer; // 0x1B8
		[SerializeField]
		private RectTransform _GravityWellPosition; // 0x1C0
		[SerializeField]
		private GameObject _CoopRandomPanel; // 0x1C8
		[SerializeField]
		private Image _CoopRandomCharacter; // 0x1D0
		[SerializeField]
		private ParticleSystem _CoopCharacterParticles; // 0x1D8
		private SignalBus _signalBus; // 0x1E0
		private TreasureFactory _treasureFactory; // 0x1E8
		private DataManager _data; // 0x1F0
		private PlayerOptions _playerOptions; // 0x1F8
		private GameSessionData _session; // 0x200
		private Treasure _currentTreasure; // 0x208
		private TreasurePlaybackSettings _currentPlayback; // 0x210
		private List<TreasurePrizeTypePair> _prizes; // 0x218
		private List<string> _weaponFrameNames; // 0x220
		private Dictionary<WeaponType, List<WeaponData>> _weaponData; // 0x228
		private static readonly int Play1; // 0x00
		private static readonly int Play2; // 0x04
		private static readonly int Play3; // 0x08
		private static readonly int NormalizedAnimationTimeParameter; // 0x0C
		private static readonly int BaseColorProperty; // 0x10
		private int _currentTreasureLevel; // 0x230
		private bool _openButtonPressed; // 0x234
		private bool _doneButtonPressed; // 0x235
		private bool _animationFinished; // 0x236
		private bool _receivedClaimRequest; // 0x237
		private float _outAnimationSpeed; // 0x238
		private float _inAnimationSpeed; // 0x23C
		private float _animationTime; // 0x240
		private float _normalizedAnimationTime; // 0x244
		private float _audioClipLength; // 0x248
		private bool _canSkip; // 0x24C
		private bool _isPlaying; // 0x24D
		private bool _animCanBeSkippedPastThisPoint; // 0x24E
		private bool _isSkipped; // 0x24F
		private Tween _heatTween; // 0x250
		private Tween _yellowTween; // 0x258
		private Tween _coinTween; // 0x260
		private Tween _bgTween; // 0x268
		private Tween _idleTimer; // 0x270
		private Tween _animFinishedTimer; // 0x278
		private Tween _coinSinTimer; // 0x280
		private SfxType _treasure1SfxType; // 0x288
		private SfxType _treasure2SfxType; // 0x28C
		private SfxType _treasure3SfxType; // 0x290
		private DG.Tweening.Sequence _randomCharacterSequence; // 0x298
		private Coroutine _winningPlayerRoutine; // 0x2A0
		private int _fireworksSortingOrder; // 0x2A8
		private Material _powerParticlesMaterial; // 0x2B0
		private string _treasureCacheGroupName; // 0x2B8
	
		// Constructors
		public OpenTreasurePage() {} // 0x0000000186913010-0x0000000186913350
		static OpenTreasurePage() {} // 0x0000000186913350-0x0000000186913470
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, TreasureFactory treasureFactory, DataManager data, PlayerOptions playerOptions, GameSessionData session) {} // 0x000000018690A940-0x000000018690AFA0
		private void OnDestroy() {} // 0x000000018690AFA0-0x000000018690B1E0
		protected override void Awake() {} // 0x000000018690B1E0-0x000000018690B290
		protected override void Update() {} // 0x000000018690B290-0x000000018690B7E0
		public void DoReelTrailAnimation() {} // 0x000000018690B7E0-0x000000018690B820
		public void OpenTreasure() {} // 0x000000018690B820-0x000000018690B9B0
		public void StartPlaying() {} // 0x000000018690B9B0-0x000000018690BA00
		public void PlayFireworks() {} // 0x000000018690BA00-0x000000018690BEA0
		public void ClaimTreasure() {} // 0x000000018690BEA0-0x000000018690C010
		public void ReceiveClaimTreasureRequest() {} // 0x000000018690C010-0x000000018690C130
		public void TreasureCompleted() {} // 0x000000018690C130-0x000000018690C170
		public void DoExtraFireworks() {} // 0x000000018690C170-0x000000018690C920
		public void FinishHeat() {} // 0x000000018690C920-0x000000018690CBC0
		public void AnimationFinished() {} // 0x000000018690CBC0-0x000000018690CD00
		public void OpenChest() {} // 0x000000018690CD00-0x000000018690CEB0
		public void StartPlayingCoins() {} // 0x000000018690CEB0-0x000000018690D130
		public void StopCoins() {} // 0x000000018690D130-0x000000018690D170
		public void StopScrollingReels() {} // 0x000000018690D170-0x000000018690D300
		public void StartScrollingReels() {} // 0x000000018690D300-0x000000018690D460
		public void HideBeams() {} // 0x000000018690D460-0x000000018690D680
		public void StopReels() {} // 0x000000018690D680-0x000000018690D810
		public void RevealReel1() {} // 0x000000018690D810-0x000000018690D890
		public void RevealReel2() {} // 0x000000018690D890-0x000000018690D910
		public void RevealReel3() {} // 0x000000018690D910-0x000000018690D990
		public void RevealReel4() {} // 0x000000018690D990-0x000000018690DA10
		public void RevealReel5() {} // 0x000000018690DA10-0x000000018690DA90
		private void CacheTreasure(GameplaySignals.OpenTreasureSignal sig) {} // 0x000000018690DA90-0x000000018690DCB0
		protected override void OnShowStart(GameObject g) {} // 0x000000018690DCB0-0x000000018690EBA0
		public void AnimateIn() {} // 0x000000018690EBA0-0x000000018690F570
		public void AnimateOut() {} // 0x000000018690F570-0x000000018690FA90
		public void MakeRibbons() {} // 0x000000018690FA90-0x000000018690FB10
		protected override void OnHideStart(GameObject g) {} // 0x000000018690FB10-0x000000018690FBA0
		protected override void OnHideFinish(GameObject g) {} // 0x000000018690FBA0-0x000000018690FBD0
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x000000018690FBD0-0x000000018690FBF0
		private void FireTreasureFinishedEvents() {} // 0x000000018690FBF0-0x000000018690FF80
		[IteratorStateMachine(typeof(_PlayMultiplayerRandomisation_d__111))]
		private IEnumerator PlayMultiplayerRandomisation() => default; // 0x000000018690FF80-0x0000000186910020
		private void Play(int level) {} // 0x0000000186910020-0x0000000186910790
		private void TweenCoins() {} // 0x0000000186910790-0x00000001869112F0
		private void SkipCoins(float skipTime, float animationLength) {} // 0x00000001869112F0-0x0000000186911890
		private void SetSkip(int level) {} // 0x0000000186911890-0x0000000186911A40
		private bool CheckLevel1Skip(PlayerOptionsData config) => default; // 0x0000000186911A40-0x0000000186911BB0
		private bool CheckLevel2Skip(PlayerOptionsData config) => default; // 0x0000000186911BB0-0x0000000186911D20
		private bool CheckLevel3Skip(PlayerOptionsData config) => default; // 0x0000000186911D20-0x0000000186911E40
		private void Reset() {} // 0x0000000186911E40-0x0000000186912A10
		private void Skip() {} // 0x0000000186912A10-0x0000000186912B70
		private void PerformSkip() {} // 0x0000000186912B70-0x0000000186913010
	}
}
