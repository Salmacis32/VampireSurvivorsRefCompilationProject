/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Connection;
using Coherence.Log;
using Coherence.Toolkit;
using Com.LuisPedroFonseca.ProCamera2D;
using DG.Tweening;
using QFSW.MOP2;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Data;
using VampireSurvivors.App.Objects;
using VampireSurvivors.App.Scripts.Framework;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.Scripts.Objects.VFX;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework.Cheats;
using VampireSurvivors.Framework.Loading;
using VampireSurvivors.Framework.Loot;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Algorithm;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Signals;
using VampireSurvivors.Spells;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class GameManager : GameMonoBehaviour // TypeDefIndex: 17486
	{
		// Fields
		public const float BASE_PLAYER_PX_SPEED = 0.82500005f; // Metadata: 0x0197861F
		public const float BASE_ENEMY_SPEED = 0.231f; // Metadata: 0x01978623
		public const float BASE_PROJECTILE_SPEED = 1.6500001f; // Metadata: 0x01978627
		public const int BASE_GOLD_MULTIPLIER = 1; // Metadata: 0x0197862B
		public const float BASE_ENEMY_HEALTH_MULTIPLIER = 1f; // Metadata: 0x0197862C
		public const float BASE_EXPERIENCE_MULTIPLIER = 1f; // Metadata: 0x01978630
		public const float BASE_MARKUP = 0.1f; // Metadata: 0x01978634
		public const float PPU = 100f; // Metadata: 0x01978638
		public const float UNITY_SCALE = 0.01f; // Metadata: 0x0197863C
		public const double INVERSE_UNITY_SCALE = 100; // Metadata: 0x01978640
		public const float PIXEL_SCALE = 1f; // Metadata: 0x01978648
		public const float R_PIXEL_SCALE = 1f; // Metadata: 0x0197864C
		public const float PPU_MUL = 0.01f; // Metadata: 0x01978650
		public const float MS_PER_SEC = 1000f; // Metadata: 0x01978654
		public const float MS_PER_SEC_MUL = 0.001f; // Metadata: 0x01978658
		public const int MAX_GEMS = 400; // Metadata: 0x0197865C
		public const int MAX_COINS = 200; // Metadata: 0x0197865E
		public const int MAX_REDCOINBAGS = 200; // Metadata: 0x01978660
		public const int MAX_FROZENSOULS = 200; // Metadata: 0x01978662
		public const int FIRST_ASCENSION_POINT_BONUS = 25; // Metadata: 0x01978664
		public const int SECOND_ASCENSION_POINT_BONUS = 25; // Metadata: 0x01978665
		public const int THIRD_ASCENSION_POINT_BONUS = 25; // Metadata: 0x01978666
		public const int MIN_SORTING_ORDER = -32768; // Metadata: 0x01978667
		public const int MAX_SORTING_ORDER = 32767; // Metadata: 0x0197866B
		public const int Z_DAMAGE_NUMBER = 22767; // Metadata: 0x0197866F
		public const int Z_IN_GAME_UI = 31767; // Metadata: 0x01978673
		public const string DEFAULT_GAME_TWEEN_ID = "DefaultGameTweenId"; // Metadata: 0x01978677
		public const string PAUSED_GAME_TWEEN_ID = "PausedGameTweenId"; // Metadata: 0x0197868A
		public static float PlayerPxSpeed; // 0x00
		public static float EnemySpeed; // 0x04
		public static float ProjectileSpeed; // 0x08
		public static float GoldMultiplier; // 0x0C
		public static float EnemyHealthMultiplier; // 0x10
		public static float ExperienceMultiplier; // 0x14
		public static float BaseMarkup; // 0x18
		public static float SfxVolumeFactor; // 0x1C
		public static float DifficultyAdjustmentEnemyHPMultiplier; // 0x20
		public static float DifficultyAdjustmentEnemyDamageMultiplier; // 0x24
		public static uint Tflag; // 0x28
		public static DamageNumberManager DamageNumberManager; // 0x30
		[SerializeField]
		private GameObject _Preloader; // 0x28
		[SerializeField]
		private MagnetZone _MagnetZonePrefab; // 0x30
		[SerializeField]
		private TouchControlCustomiser _TouchJoystick; // 0x38
		[SerializeField]
		private WhiteHandManager _WhiteHandManager; // 0x40
		[SerializeField]
		private Light2D _GlobalLight; // 0x48
		[SerializeField]
		private Light2D _BackgroundLight; // 0x50
		[SerializeField]
		private Light2D _Spotlight2D; // 0x58
		[SerializeField]
		private Light2D _Light2DPrefab; // 0x60
		[SerializeField]
		private Light2D _Light2DForTilemapPrefab; // 0x68
		[SerializeField]
		private Renderer2DData _Renderer2DData; // 0x70
		[SerializeField]
		private Canvas _GameCanvas; // 0x78
		private SignalBus _signalBus; // 0x80
		private DiContainer _diContainer; // 0x88
		private PlayerOptions _playerOptions; // 0x90
		private AssetReferenceLibrary _assetReferenceLibrary; // 0x98
		private LootManager _lootManager; // 0xA0
		private WeaponsFacade _weaponsFacade; // 0xA8
		private AccessoriesFacade _accessoriesFacade; // 0xB0
		private VampireSurvivors.Objects.Stage _stage; // 0xB8
		private AdventureManager _adventureManager; // 0xC0
		private GameplayLoader _gameplayLoader; // 0xC8
		private ShopFactory _shopFactory; // 0xD0
		private ParticleManager _particleManager; // 0xD8
		private GameSessionData _gameSessionData; // 0xE0
		private LevelUpFactory _levelUpFactory; // 0xE8
		private CharacterFactory _characterFactory; // 0xF0
		private TreasureFactory _treasureFactory; // 0xF8
		private LimitBreakManager _limitBreakManager; // 0x100
		private DataManager _dataManager; // 0x108
		private PlayerStats _playerStats; // 0x110
		private ArcanaManager _arcanaManager; // 0x118
		private PhysicsManager _physicsManager; // 0x120
		private ExplosionManager _explosionManager; // 0x128
		private EggManager _eggManager; // 0x130
		private ProjectileFactory _projectileFactory; // 0x138
		private GameplayCheatCodeManager _gameplayCheatCodeManager; // 0x140
		private GizmoManager _gizmoManager; // 0x148
		private CanvasGroup _touchJoystickCanvasGroup; // 0x150
		private SpellsManager _spellsManager; // 0x158
		private AchievementManager _achievementManager; // 0x160
		private MultiplayerManager _multiplayer; // 0x168
		private FontFactory _fontFactory; // 0x170
		private int _defangIndex; // 0x178
		private List<float> _defangChancesArray; // 0x180
		private CommonVfxManager _commonVfxManager; // 0x188
		private ParticleSystem _pickupVfx; // 0x190
		private ParticleSystem _jewelPickupVfx; // 0x198
		private Transform _blittersParent; // 0x1A0
		private bool _canRunTickerTimer; // 0x1A8
		private float _secondsTickerTimer; // 0x1AC
		private int _updateTicks; // 0x1B0
		private const int UpdateFreq = 4; // Metadata: 0x0197869C
		private float _targetTick; // 0x1B4
		private float? _preZoomOrthoSize; // 0x1B8
		private VampireSurvivors.Framework.TimerSystem.Timer _stopTimeTimer; // 0x1C0
		public List<PickupToSpawn> _gemsToSpawn; // 0x1C8
		public List<PickupToSpawn> _coinsToSpawn; // 0x1D0
		public List<PickupToSpawn> _redCoinBagsToSpawn; // 0x1D8
		public List<PickupToSpawn> _frozenSoulsToSpawn; // 0x1E0
		private bool _isPaused; // 0x1E8
		private bool _isGameRunning; // 0x1E9
		private readonly List<UiTransition> _queuedUiTransitions; // 0x1F0
		private List<Pickup> _stagePickups; // 0x1F8
		private List<MapToken> _mapTokens; // 0x200
		private Transform _candleLightsParent; // 0x208
		private Queue<Light2D> _candleLights; // 0x210
		private Dictionary<Destructible, Light2D> _candleLightsMapping; // 0x218
		private ObjectPool _gemPool; // 0x220
		private HashSet<Pickup> _gems; // 0x228
		private ObjectPool _coinPool; // 0x230
		private HashSet<Coin> _coins; // 0x238
		private float _defaultCoinValue; // 0x240
		private ObjectPool _redCoinBagPool; // 0x248
		private HashSet<CoinBag1> _redCoinBags; // 0x250
		private float _defaultRedCoinBagValue; // 0x258
		private ObjectPool _frozenSoulPool; // 0x260
		private HashSet<Pickup_Bonus_FrozenSoul> _frozenSouls; // 0x268
		private float _defaultFrozenSoulValue; // 0x270
		private TilingBackground _bgMan; // 0x278
		private VampireSurvivors.Framework.TimerSystem.Timer _safetyPause; // 0x280
		private bool _restartingGameScene; // 0x288
		private bool _inGameOverState; // 0x289
		private bool _inOnlineErrorState; // 0x28A
		private bool _hideLoadingVisuals; // 0x28B
		private Texture2D _recapTex; // 0x290
		private List<VampireSurvivors.Objects.Characters.CharacterController> _characters; // 0x298
		private List<VampireSurvivors.Objects.Characters.CharacterController> _mainCharacters; // 0x2A0
		private List<VampireSurvivors.Objects.Characters.CharacterController> _charactersLevelingUp; // 0x2A8
		private Coroutine _signalGameplayLoadedRoutine; // 0x2B0
		private bool _waitingForLevelUp; // 0x2B8
		private List<int> _coopChestRandomness; // 0x2C0
		private int _coopChestRandomnessIndex; // 0x2C8
		private bool _isLocalMultiplayer; // 0x2CC
		private Transform _coopCameraTarget; // 0x2D0
		private Coherence.Log.Logger _logger; // 0x2F0
		private EnemyType _latestKilledEnemyThatCanBeFollowerType; // 0x2F8
		private EnemyData _latestKilledEnemyThatCanBeFollowerData; // 0x300
		private bool _latestKilledEnemyWasCartRider; // 0x308
		private int _nextLevelUpAtLevel; // 0x30C
		private int _batchedOnlineLevelUpSkips; // 0x310
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, List<FollowerEnemy_CharacterController>> m_EnemyFollowerPools; // 0x318
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, int> m_NumAliveEnemyFollowers; // 0x320
		[NonSerialized]
		public bool BlockConnectionErrorPopups; // 0x348
		public CoopConfig CoopConfig; // 0x3B8
		public PhysicsGroup Enemies; // 0x3C0
		public PhysicsGroup EnemiesThatIgnoreProjectiles; // 0x3C8
		private static List<WeaponType> s_foscariEventWeapons; // 0x38
		private UiTransition _latestUITransition; // 0x3F0
		private List<bool> _cachedCharacterValidity; // 0x410
		private List<VampireSurvivors.Objects.Characters.CharacterController> _followerCache; // 0x420
		[SerializeField]
		private float _bossHealthMultiplier; // 0x428
		[SerializeField]
		private float _bossAttacksTriggerChance; // 0x42C
	
		// Properties
		public float? PreZoomOrthoSize { get => default; } // 0x0000000182766A60-0x0000000182766A70 
		public Transform CoopCameraTarget { get => default; } // 0x00000001872D2740-0x00000001872D2750 
		public Action ManualCameraTargetControl { get; set; } // 0x0000000186753AB0-0x0000000186753AC0 0x0000000186753AC0-0x0000000186753B20
		public GoldFingerManager GoldFingerManager { get; set; } // 0x0000000185FA3370-0x0000000185FA3380 0x0000000186753B20-0x0000000186753B80
		public bool HasGfBonus { get; set; } // 0x00000001872D2750-0x00000001872D2760 0x0000000185FA1610-0x0000000185FA1620
		public VampireSurvivors.Objects.Stage Stage { get => default; } // 0x00000001819A01A0-0x00000001819A01B0 
		public ArcanaManager ArcanaManager { get => default; } // 0x00000001829475E0-0x00000001829475F0 
		public PhysicsManager PhysicsManager { get => default; } // 0x00000001829475F0-0x0000000182947600 
		public Renderer2DData Renderer2DData { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public DataManager DataManager { get => default; } // 0x0000000182766870-0x0000000182766880 
		public GameSessionData GameSessionData { get => default; } // 0x000000018282D820-0x000000018282D830 
		public LevelUpFactory LevelUpFactory { get => default; } // 0x0000000182766DD0-0x0000000182766DE0 
		public PlayerOptions PlayerOptions { get => default; } // 0x0000000181919F80-0x0000000181919F90 
		public AssetReferenceLibrary AssetReferenceLibrary { get => default; } // 0x0000000181971630-0x0000000181971640 
		public EggManager EggManager { get => default; } // 0x0000000182A45B90-0x0000000182A45BA0 
		public TreasureFactory TreasureFactory { get => default; } // 0x0000000181945E90-0x0000000181945EA0 
		public SignalBus SignalBus { get => default; } // 0x00000001819A0370-0x00000001819A0380 
		public DiContainer DiContainer { get => default; } // 0x00000001819A03E0-0x00000001819A03F0 
		public TilingBackground BGMan { get => default; } // 0x0000000186753760-0x0000000186753770 
		public ProjectileFactory ProjectileFactory { get => default; } // 0x0000000184F612E0-0x0000000184F612F0 
		public SpellsManager SpellsManager { get => default; } // 0x0000000184755AB0-0x0000000184755AC0 
		public GizmoManager GizmoManager { get => default; } // 0x0000000184F54FC0-0x0000000184F54FD0 
		public AchievementManager AchievementManager { get => default; } // 0x00000001827668E0-0x00000001827668F0 
		public WeaponsFacade WeaponsFacade { get => default; } // 0x00000001819716D0-0x00000001819716E0 
		public AccessoriesFacade AccessoriesFacade { get => default; } // 0x00000001819A0190-0x00000001819A01A0 
		public AdventureManager AdventureManager { get => default; } // 0x00000001819A0460-0x00000001819A0470 
		public ShopFactory ShopFactory { get => default; } // 0x000000018291BA90-0x000000018291BAA0 
		public FontFactory FontFactory { get => default; } // 0x0000000182917880-0x0000000182917890 
		public CharacterFactory CharacterFactory { get => default; } // 0x00000001819716C0-0x00000001819716D0 
		public OpenTreasurePage OpenTreasurePage { get; set; } // 0x0000000185EAA020-0x0000000185EAA030 0x00000001872D2760-0x00000001872D27C0
		public ConnectionException ConnectionException { get; private set; } // 0x00000001872D27C0-0x00000001872D27D0 0x00000001872D27D0-0x00000001872D2830
		public ParticleManager ParticleManager { get => default; } // 0x0000000182A45A70-0x0000000182A45A80 
		public Light2D Spotlight2D { get => default; } // 0x0000000180B15730-0x0000000180B15740 
		public bool IsPaused { get => default; } // 0x0000000185C64850-0x0000000185C64860 
		public bool IsInPauseGameState { get; set; } // 0x00000001872D2830-0x00000001872D2840 0x00000001872D2840-0x00000001872D2850
		public bool RestartingGameScene { get => default; set {} } // 0x0000000185FA3660-0x0000000185FA3670 0x00000001870EF920-0x00000001870EF930
		public bool InGameOverState { get => default; set {} } // 0x00000001872D2850-0x00000001872D2860 0x00000001870EE7B0-0x00000001870EE7C0
		public bool InOnlineErrorState { get => default; set {} } // 0x00000001870EFC60-0x00000001870EFC70 0x00000001872D2860-0x00000001872D2870
		public bool HideLoadingVisuals { get => default; set {} } // 0x00000001872D2870-0x00000001872D2880 0x00000001872D2880-0x00000001872D2890
		public Texture2D RecapTex { get => default; set {} } // 0x00000001870EF5B0-0x00000001870EF5C0 0x00000001870EF5C0-0x00000001870EF620
		public bool CanInterrupt { get; set; } // 0x00000001872D2890-0x00000001872D28A0 0x00000001872D28A0-0x00000001872D28B0
		public bool CanPause { get; set; } // 0x00000001872D28B0-0x00000001872D28C0 0x00000001872D28C0-0x00000001872D28D0
		public bool FreezingFrame { get; set; } // 0x00000001872D28D0-0x00000001872D28E0 0x0000000186989540-0x0000000186989630
		public VampireSurvivors.Objects.Characters.CharacterController PausingPlayer { get; set; } // 0x00000001870EEC30-0x00000001870EEC40 0x00000001872D28E0-0x00000001872D2940
		public float BossAttacksTriggerChance { get => default; set {} } // 0x00000001872D2A50-0x00000001872D2A60 0x00000001872D2A60-0x00000001872D2A80
		public float BossHealthMultiplier { get => default; set {} } // 0x00000001872D2A80-0x00000001872D2A90 0x00000001872D2A90-0x00000001872D2AB0
		public bool StartedAsOnlineMultiplayerRun { get; set; } // 0x00000001872D2AB0-0x00000001872D2AC0 0x00000001872D2AC0-0x00000001872D2AD0
		public VampireSurvivors.Objects.Characters.CharacterController ChestWinnerPlayer { get; set; } // 0x000000018630D430-0x000000018630D440 0x000000018630D440-0x000000018630D4A0
		public int SurvarotsCardsToShow { get; set; } // 0x0000000185FB73F0-0x0000000185FB7400 0x00000001872D2AD0-0x00000001872D2AE0
		public bool CanShowGameOverRewardAd { get; set; } // 0x00000001872D2AE0-0x00000001872D2AF0 0x00000001872D2AF0-0x00000001872D2B00
		public bool CanShowArcadeReviveButton { get; set; } // 0x00000001872D2B00-0x00000001872D2B10 0x00000001872D2B10-0x00000001872D2B20
		public string WeaponSelectionType { get; set; } // 0x00000001872D2B20-0x00000001872D2B30 0x00000001872D2B30-0x00000001872D2B90
		public ArcanaUiType ArcanaUiType { get; set; } // 0x0000000185FB7560-0x0000000185FB7570 0x00000001872D2B90-0x00000001872D2BA0
		public Transform WorldSpritesTransform { get; private set; } // 0x00000001863118D0-0x00000001863118E0 0x00000001872D2BA0-0x00000001872D2C00
		public Rect? HardBounds { get; set; } // 0x00000001872D2C00-0x00000001872D2C20 0x00000001872D2C20-0x00000001872D2C40
		public List<Pickup> StagePickups { get => default; } // 0x0000000182767040-0x0000000182767050 
		public List<MapToken> MapTokens { get => default; } // 0x00000001858341D0-0x00000001858341E0 
		public LootManager LootManager { get => default; } // 0x00000001819A0250-0x00000001819A0260 
		public HashSet<Pickup> Gems { get => default; } // 0x0000000186747010-0x0000000186747020 
		public HashSet<Coin> Coins { get => default; } // 0x0000000186753520-0x0000000186753530 
		public HashSet<CoinBag1> RedCoinBags { get => default; } // 0x00000001867535F0-0x0000000186753600 
		public HashSet<Pickup_Bonus_FrozenSoul> FrozenSouls { get => default; } // 0x00000001840BCEF0-0x00000001840BCF00 
		public ParticleSystem PickupVfx { get => default; } // 0x0000000182766A50-0x0000000182766A60 
		public ParticleSystem JewelPickupVfx { get => default; } // 0x0000000186747020-0x0000000186747030 
		public MerchantInventoryType MerchantInventory { get; set; } // 0x00000001872D2C40-0x00000001872D2C50 0x00000001872D2C50-0x00000001872D2C60
		public PickupCustomMerchant CurrentCustomMerchant { get; private set; } // 0x00000001872D2C60-0x00000001872D2C70 0x00000001872D2C70-0x00000001872D2CD0
		public bool IsTimeStopped { get; set; } // 0x00000001872D2CD0-0x00000001872D2CE0 0x00000001872D2CE0-0x00000001872D2CF0
		public bool IgnoreMovementFreezeFromTimeStop { get; set; } // 0x00000001872D2CF0-0x00000001872D2D00 0x00000001872D2D00-0x00000001872D2D10
		public bool IsAllDefanged { get; set; } // 0x00000001872D2D10-0x00000001872D2D20 0x00000001872D2D20-0x00000001872D2D30
		public VampireSurvivors.Objects.Characters.CharacterController EnterWeaponSelectionPlayer { get; set; } // 0x00000001872D2D30-0x00000001872D2D40 0x00000001872D2D40-0x00000001872D2DA0
		public VampireSurvivors.Objects.Characters.CharacterController EnterBonusSelectionPlayer { get; private set; } // 0x000000018724BC10-0x000000018724BC20 0x000000018724BC20-0x000000018724BC80
		public VampireSurvivors.Data.ItemType CurrentFoundRelic { get; set; } // 0x00000001872D2DA0-0x00000001872D2DB0 0x00000001872D2DB0-0x00000001872D2DC0
		public bool IsHalloween { get; set; } // 0x00000001872D2DC0-0x00000001872D2DD0 0x00000001872D2DD0-0x00000001872D2DE0
		public bool IsLocalMultiplayer { get => default; } // 0x00000001872D2DE0-0x00000001872D2DF0 
		public bool IsOnlineMultiplayer { get => default; } // 0x00000001872D2DF0-0x00000001872D2EF0 
		public bool IsMultiplayer { get => default; } // 0x00000001872D2EF0-0x00000001872D2F10 
		public bool IsPartyOrOnline { get => default; } // 0x00000001872D2F10-0x00000001872D3110 
		public bool IsStageHost { get => default; } // 0x00000001872D3110-0x00000001872D3250 
		public bool HasMultipleMainCharacters { get => default; } // 0x00000001872D3250-0x00000001872D32A0 
		public int PlayerCount { get => default; } // 0x00000001872D32A0-0x00000001872D3400 
		public List<VampireSurvivors.Objects.Characters.CharacterController> AllPlayers { get => default; } // 0x0000000186A13420-0x0000000186A13430 
		public List<VampireSurvivors.Objects.Characters.CharacterController> MainPlayers { get => default; } // 0x0000000185EAA030-0x0000000185EAA040 
		public VampireSurvivors.Objects.Characters.CharacterController Player { get => default; } // 0x00000001865529A0-0x00000001865529C0 
		public VampireSurvivors.Objects.Characters.CharacterController PlayerOne { get => default; } // 0x00000001872D3400-0x00000001872D3590 
		public VampireSurvivors.Objects.Characters.CharacterController MyOnlinePlayer { get => default; } // 0x00000001872D3590-0x00000001872D3600 
		public PhaserScene scene { get => default; } // 0x0000000184C46A30-0x0000000184C46A70 
		public PhysicsGroup EnemyGroup { get => default; } // 0x00000001872D3600-0x00000001872D3620 
		public PhysicsGroup PlayerGroup { get => default; } // 0x00000001872D3620-0x00000001872D3640 
		public PhysicsGroup Destructibles { get => default; } // 0x00000001872D3640-0x00000001872D3660 
		public PhysicsGroup PickupGroup { get => default; } // 0x00000001872D3660-0x00000001872D3680 
		public GameEquipmentPanel GameEquipmentPanel { get; private set; } // 0x00000001872D3680-0x00000001872D3690 0x00000001872D3690-0x00000001872D36F0
		public MainGamePage MainUI { get; private set; } // 0x00000001872D36F0-0x00000001872D3700 0x00000001872D3700-0x00000001872D3760
		public float SurvivedSeconds { get; set; } // 0x0000000186723520-0x0000000186723590 0x00000001872D3760-0x00000001872D3770
		public List<Action<float>> OnCoinPickup { get; set; } // 0x00000001872D3770-0x00000001872D3780 0x00000001872D3780-0x00000001872D37E0
		public List<WeaponType> FoscariEventWeapons { get => default; set {} } // 0x00000001872D37E0-0x00000001872D3840 0x00000001872D3840-0x00000001872D3900
		public bool IsGameRunning { get => default; } // 0x0000000185C64790-0x0000000185C647A0 
		public CommonVfxManager CommonVfxManager { get => default; } // 0x00000001826DBA40-0x00000001826DBA50 
		private ObjectPool GemPool { get => default; } // 0x00000001872D3900-0x00000001872D3A90 
		private ObjectPool CoinPool { get => default; } // 0x00000001872D3A90-0x00000001872D3C20 
		private ObjectPool RedCoinBagPool { get => default; } // 0x00000001872D3C20-0x00000001872D3DB0 
		private ObjectPool FrozenSoulPool { get => default; } // 0x00000001872D3DB0-0x00000001872D3F40 
		public VampireSurvivors.Objects.Characters.CharacterController InteractingPlayer { get => default; } // 0x00000001872D78E0-0x00000001872D79E0 
		public int FreeRoamCameraTargetWhenDead { get; set; } // 0x0000000187300240-0x0000000187300250 0x0000000187300250-0x0000000187300260
	
		// Nested types
		public class ZoomSize // TypeDefIndex: 17466
		{
			// Fields
			public float _currentSize; // 0x10
	
			// Constructors
			public ZoomSize() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public GameManager() {} // 0x0000000187302400-0x0000000187302FE0
		static GameManager() {} // 0x0000000187302FE0-0x00000001873031A0
	
		// Methods
		public bool IsStageVisuallyInverted() => default; // 0x00000001872D2940-0x00000001872D2A50
		[Inject]
		private void Construct(SignalBus signalBus, DiContainer diContainer, PlayerOptions playerOptions, LootManager lootManager, WeaponsFacade weaponsFacade, VampireSurvivors.Objects.Stage stage, GameSessionData gameSessionData, LevelUpFactory levelUpFactory, CharacterFactory characterFactory, AccessoriesFacade accessoriesFacade, DataManager dataManager, PlayerStats playerStats, ArcanaManager arcanaManager, PhysicsManager physicsManager, EggManager egg, LimitBreakManager limitBreakManager, GizmoManager gizmoManager, TreasureFactory treasureFactory, ProjectileFactory projectileFactory, SpellsManager spellsManager, AchievementManager achievementManager, MainGamePage mainGamePage, MultiplayerManager multiplayer, AdventureManager adventureManager, FontFactory fontFactory, AssetReferenceLibrary assetReferenceLibrary, ParticleManager particleManager, ShopFactory shopFactory) {} // 0x00000001872D3F40-0x00000001872D5700
		private new void Awake() {} // 0x00000001872D5700-0x00000001872D5A40
		private void InitializeGame() {} // 0x00000001872D5A40-0x00000001872D5BB0
		private void InitiateGameplayPreload() {} // 0x00000001872D5BB0-0x00000001872D5C90
		protected override void OnDestroy() {} // 0x00000001872D5C90-0x00000001872D6CE0
		protected override void OnUpdate() {} // 0x00000001872D6CE0-0x00000001872D78E0
		public void OverrideLatestUIPlayer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000187139AB0-0x0000000187139B10
		private void HandleIngamePopup() {} // 0x00000001872D79E0-0x00000001872D8420
		private void ProcessUITransition(UiTransition uiTransition) {} // 0x00000001872D8420-0x00000001872D8A50
		public bool ShouldShowArcanaPanel() => default; // 0x00000001872D8A50-0x00000001872D8C80
		public void MovePickupsAndDestructibles(float2 offset) {} // 0x00000001872D8C80-0x00000001872D92C0
		private void RunLocalOrOnlineLevelUp() {} // 0x00000001872D92C0-0x00000001872D98C0
		private void AdjustNextLevelUpAtLevel() {} // 0x00000001872D98C0-0x00000001872D9920
		private void OnlineLevelUp(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872D9920-0x00000001872D9DD0
		private void RunOnlineLevelUpLogic(bool shouldSwapToLevelUpUi, bool adjustXpFactors, VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872D9DD0-0x00000001872D9E70
		private void GrantSkipsExperience(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872D9E70-0x00000001872DA080
		private void RunLocalLevelUpLogic() {} // 0x00000001872DA080-0x00000001872DA0E0
		private void SwapToLevelUpScreenOnline(bool shouldSwapToLevelUpUi, VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872DA0E0-0x00000001872DA3F0
		public void HandleLevelUp() {} // 0x00000001872DA3F0-0x00000001872DA550
		private void OnDrawGizmos() {} // 0x00000001872DA550-0x00000001872DAB40
		public void DeactivatePreloader() {} // 0x00000001872DAB40-0x00000001872DAB70
		public void PauseGame() {} // 0x00000001872DAB70-0x00000001872DAEF0
		public void ResumeGame() {} // 0x00000001872DAEF0-0x00000001872DB380
		public void RemoveTickerTimer() {} // 0x00000001872DB380-0x00000001872DB390
		public void ResumeTickerTimer() {} // 0x00000001872DB390-0x00000001872DB3A0
		public void SummonWhiteHand(bool forceStageTimerEnd = false /* Metadata: 0x019785C4 */) {} // 0x00000001872DB3A0-0x00000001872DB3C0
		public void ForceStageTimerEnd() {} // 0x00000001872DB3C0-0x00000001872DB5C0
		public void TransitionToFoscari2() {} // 0x00000001872DB5C0-0x00000001872DB7D0
		public void RestartGameScene(bool shouldShowTransition = false /* Metadata: 0x019785C5 */) {} // 0x00000001872DB7D0-0x00000001872DB8D0
		[IteratorStateMachine(typeof(_WaitForEveryoneToResetGameSession_d__454))]
		private static IEnumerator WaitForEveryoneToResetGameSession() => default; // 0x00000001872DB8D0-0x00000001872DB910
		public void ResetGameToMenu() {} // 0x00000001872DB910-0x00000001872DB9F0
		private void GoToPreloadScene() {} // 0x00000001872DB9F0-0x00000001872DBD80
		[IteratorStateMachine(typeof(_SnapshotRecap_d__457))]
		public IEnumerator SnapshotRecap(Action onComplete) => default; // 0x00000001872DBD80-0x00000001872DBE80
		public void ClearRecapScreenshot() {} // 0x00000001872DBE80-0x00000001872DC010
		public void EnterCreditEndingScene() {} // 0x00000001872DC010-0x00000001872DC100
		public void EnterGameEndScene() {} // 0x00000001872DC100-0x00000001872DC1F0
		public bool TeleportMyPlayerToRemotePlayer(VampireSurvivors.Objects.Characters.CharacterController remotePlayer, Action onYoyo) => default; // 0x00000001872DC1F0-0x00000001872DC600
		public void TeleportPlayers(float2 position, float2 offsetForEachPlayer, bool centered = false /* Metadata: 0x019785C6 */, bool focusCameraOnPlayer = true /* Metadata: 0x019785C7 */) {} // 0x00000001872DC600-0x00000001872DCAB0
		[IteratorStateMachine(typeof(_RemoveManualCameraControl_d__463))]
		private IEnumerator RemoveManualCameraControl() => default; // 0x00000001872DCAB0-0x00000001872DCB50
		private bool IsAnyPlayerOutsideBounds(ArcadeBodyBounds bounds) => default; // 0x00000001872DCB50-0x00000001872DCD00
		private void OnlineFocusCameraOnMyPlayer() {} // 0x00000001872DCD00-0x00000001872DCF70
		public VampireSurvivors.Objects.Characters.CharacterController GetClosestPlayer(float2 position, PlayerInclusionMode inclusionMode = PlayerInclusionMode.AliveOrDead /* Metadata: 0x019785C8 */, float maxRangeSqrd = 3.4028235E+38f /* Metadata: 0x019785C9 */, bool includeFollowers = true /* Metadata: 0x019785CD */) => default; // 0x00000001872DCF70-0x00000001872DD410
		public int GetAlivePlayerCount(bool countRevivingPlayerAsAlive = false /* Metadata: 0x019785CE */, bool includeOnlyMainCharacters = false /* Metadata: 0x019785CF */) => default; // 0x00000001872DD410-0x00000001872DD5B0
		public int GetMainPlayersEligibleForLevelUp() => default; // 0x00000001872DD5B0-0x00000001872DD7B0
		public void ClearAllPlayerRevives() {} // 0x00000001872DD7B0-0x00000001872DD8B0
		public void RosaryDamage(bool showVfx = true /* Metadata: 0x019785D0 */, float volume = 1.8f /* Metadata: 0x019785D1 */, WeaponType damageType = WeaponType.ROSARY /* Metadata: 0x019785D5 */, bool setDark = false /* Metadata: 0x019785D6 */) {} // 0x00000001872DD8B0-0x00000001872DDD10
		private void StopTime(GameplaySignals.TimeStopSignal signal) {} // 0x00000001872DDD10-0x00000001872DE590
		private void StopTimeForMilliseconds(float milliseconds) {} // 0x00000001872DE590-0x00000001872DE950
		public void SpawnPickupEffectsParticles(Vector2 pos) {} // 0x00000001872DE950-0x00000001872DEA90
		public void ShowHitVfxAt(Vector2 pos, HitVfxType showHitVfx) {} // 0x00000001872DEA90-0x00000001872DEB00
		public void ShowDamageAt(Vector2 pos, float value) {} // 0x00000001872DEB00-0x00000001872DEBA0
		public void ShowRecoveryAt(Vector2 pos, float value) {} // 0x00000001872DEBA0-0x00000001872DEC70
		public Transform FindClosestEnemyToPlayer(VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872DEC70-0x00000001872DEE60
		public void AddOnlineLevelUpToQueue(OnlineLevelUpData levelUpData) {} // 0x00000001872DEE60-0x00000001872DF2B0
		public void AddTreasureToQueue(Treasure treasure) {} // 0x00000001872DF2B0-0x00000001872DF550
		public void AddCharacterTypeToQueue(VampireSurvivors.Data.CharacterType characterType, VampireSurvivors.Objects.Characters.CharacterController targetPlayer) {} // 0x00000001872DF550-0x00000001872DF810
		public void AddRelicToQueue(VampireSurvivors.Data.ItemType itemType, VampireSurvivors.Objects.Characters.CharacterController targetPlayer) {} // 0x00000001872DF810-0x00000001872DFAE0
		public void AddFoundWeaponToQueue(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController targetPlayer) {} // 0x00000001872DFAE0-0x00000001872DFDB0
		public void MakeExplosion(Vector2 spawnPos, int moreX, int moreY) {} // 0x00000001872DFDB0-0x00000001872DFDF0
		public Pickup MakeStagePickup(Vector2 pos, VampireSurvivors.Data.ItemType itemType = VampireSurvivors.Data.ItemType.COIN /* Metadata: 0x019785D7 */, WeaponType weaponType = WeaponType.VOID /* Metadata: 0x019785D8 */, float value = 0f /* Metadata: 0x019785D9 */, VampireSurvivors.Data.ItemType relicType = VampireSurvivors.Data.ItemType.VOID /* Metadata: 0x019785DD */, bool validatePickups = true /* Metadata: 0x019785DE */) => default; // 0x00000001872DFDF0-0x00000001872DFF20
		public void RegisterStagePickup(Pickup pickup) {} // 0x00000001872DFF20-0x00000001872E0020
		public void MakeGem(Vector2 pos, float xp, Action<Pickup> callback = null) {} // 0x00000001872E0020-0x00000001872E0130
		public void MakeCoin(Vector2 pos, float value = 0f /* Metadata: 0x019785DF */, Action<Pickup> callback = null) {} // 0x00000001872E0130-0x00000001872E0240
		public void MakeRedCoinBag(Vector2 pos, float value = 0f /* Metadata: 0x019785E3 */, Action<Pickup> callback = null) {} // 0x00000001872E0240-0x00000001872E0350
		public void MakeFrozenSoul(Vector2 pos, float value = 0f /* Metadata: 0x019785E7 */, Action<Pickup> callback = null) {} // 0x00000001872E0350-0x00000001872E0460
		public Gem MakeGemIgnoreAllTheLimits(Vector2 pos, float xp) => default; // 0x00000001872E0460-0x00000001872E06B0
		public TreasureChest MakeTreasure(Vector2 pos, Treasure treasure, bool isRemote = false /* Metadata: 0x019785EB */) => default; // 0x00000001872E06B0-0x00000001872E0B30
		public void MakeAndActivatePickup(VampireSurvivors.Data.ItemType itemType, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter) {} // 0x00000001872E0B30-0x00000001872E0D20
		public Pickup MakePickup(Vector2 pos, VampireSurvivors.Data.ItemType itemType = VampireSurvivors.Data.ItemType.COIN /* Metadata: 0x019785EC */, WeaponType weaponType = WeaponType.VOID /* Metadata: 0x019785ED */, float value = 0f /* Metadata: 0x019785EE */, VampireSurvivors.Data.ItemType relicType = VampireSurvivors.Data.ItemType.VOID /* Metadata: 0x019785F2 */, bool shouldCallValidatePickups = true /* Metadata: 0x019785F3 */, bool isRemote = false /* Metadata: 0x019785F4 */) => default; // 0x00000001872E0D20-0x00000001872E1240
		public void ReturnGem(Gem gem) {} // 0x00000001872E1240-0x00000001872E12E0
		public void ReturnCoin(Coin coin) {} // 0x00000001872E12E0-0x00000001872E1380
		public void ReturnRedCoinBag(CoinBag1 coinBag) {} // 0x00000001872E1380-0x00000001872E1420
		public void ReturnFrozenSoul(Pickup_Bonus_FrozenSoul soul) {} // 0x00000001872E1420-0x00000001872E14C0
		public void StopTrackingFrozenSoul(Pickup_Bonus_FrozenSoul soul) {} // 0x00000001872E14C0-0x00000001872E1520
		public void TurnOnVacuum(VampireSurvivors.Objects.Characters.CharacterController target = null) {} // 0x00000001872E1520-0x00000001872E17C0
		public void TurnOnVacuumForGold() {} // 0x00000001872E17C0-0x00000001872E1A10
		public void ZoomOnPlayer() {} // 0x00000001872E1A10-0x00000001872E1F10
		public void ZoomZoomOnPlayer() {} // 0x00000001872E1F10-0x00000001872E2410
		public void ZoomCamera(float zoomAmount, float duration, EaseType easeType = EaseType.Linear /* Metadata: 0x019785F5 */) {} // 0x00000001872E2410-0x00000001872E24B0
		public void SetCanvasRenderMode(RenderMode renderMode) {} // 0x00000001872E24B0-0x00000001872E24D0
		public void RemoveAllPlayersAsCameraTargets(float removePlayerTargetDuration) {} // 0x00000001872E24D0-0x00000001872E2550
		public void AddAllPlayersAsCameraTargets(float transitionDuration = 0f /* Metadata: 0x019785F6 */) {} // 0x00000001872E2550-0x00000001872E25F0
		public void SetPlayerWorldBoundCollision(bool on) {} // 0x00000001872E25F0-0x00000001872E2790
		public void StopCamera(Vector2 center, float removePlayerTargetDuration = 1f /* Metadata: 0x019785FA */) {} // 0x00000001872E2790-0x00000001872E2AC0
		public void ResumeCamera() {} // 0x00000001872E2AC0-0x00000001872E2BE0
		public void SetHardBoundsMinMax(float xMin, float yMin, float xMax, float yMax, bool skipInverseCalculation = false /* Metadata: 0x019785FE */) {} // 0x00000001872E2BE0-0x00000001872E2E30
		public void RemoveHardBounds() {} // 0x00000001872E2E30-0x00000001872E2E50
		public void CoinPickedup(Pickup pickup) {} // 0x00000001872E2E50-0x00000001872E2F30
		public Blitter CreateBlitter(Vector2 pos, string blitterName = null) => default; // 0x00000001872E2F30-0x00000001872E32F0
		public void SetLatestKilledEnemy(EnemyController _enemyController) {} // 0x00000001872E32F0-0x00000001872E3660
		private bool CheckIfFrameListIsValid(List<string> frameList) => default; // 0x00000001872E3660-0x00000001872E36F0
		public EnemyData GetLatestKilledEnemyThatCanBeFollower() => default; // 0x000000018726E490-0x000000018726E4A0
		public EnemyType GetLatestKilledEnemyThatCanBeFollowerType() => default; // 0x00000001872E36F0-0x00000001872E3700
		public bool GetLatestKilledEnemyWasCartRider() => default; // 0x00000001872A9C70-0x00000001872A9C80
		public void EraseEnemies(bool showVfx = true /* Metadata: 0x019785FF */) {} // 0x00000001872E3700-0x00000001872E3B30
		public void EnterTheBossi() {} // 0x00000001872E3B30-0x00000001872E3C20
		public void SetupMusicBanger(bool loop = true /* Metadata: 0x01978600 */) {} // 0x00000001872E3C20-0x00000001872E4020
		public VampireSurvivors.Objects.Characters.CharacterController PullRandomChestWinner() => default; // 0x00000001872E4020-0x00000001872E43B0
		public void OnCharacterDestroyed(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872E43B0-0x00000001872E4900
		private void RedistributeEquipment(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872E4900-0x00000001872E5300
		public void InitializeCharacterSpawnedRemotely(GameObject characterInstance, VampireSurvivors.Data.CharacterType characterType) {} // 0x00000001872E5300-0x00000001872E5420
		public void AddPlayerXp(float xp, XPMultiplierMode multiplierMode = XPMultiplierMode.Normal /* Metadata: 0x01978601 */) {} // 0x00000001872E5420-0x00000001872E5710
		public void UpdatePlayerUI() {} // 0x00000001872E5710-0x00000001872E5720
		public void TogglePlayerHealthBar(bool visible) {} // 0x00000001872E5720-0x00000001872E5810
		public List<Weapon> RemoveAllWeaponsFromPlayer(VampireSurvivors.Objects.Characters.CharacterController owner) => default; // 0x00000001872E5810-0x00000001872E5B40
		public void SetAllPlayersWeaponsActive(bool active) {} // 0x00000001872E5B40-0x00000001872E5CD0
		public void SetOnlySomePlayersWeaponsActive(int maxActive) {} // 0x00000001872E5CD0-0x00000001872E5E70
		public List<EquipmentInfo> RemoveAllEquipmentFromPlayers(bool addToRemovedList = false /* Metadata: 0x01978602 */) => default; // 0x00000001872E5E70-0x00000001872E6850
		public void GiveBackAllEquipmentToPlayers(List<EquipmentInfo> playerEquipment) {} // 0x00000001872E6850-0x00000001872E6B20
		public Weapon RemoveWeaponFromPlayer(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController owner) => default; // 0x00000001872E6B20-0x00000001872E6B50
		public void RemoveHiddenWeaponFromPlayer(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController owner) {} // 0x00000001872E6B50-0x00000001872E6B80
		public void FinishLevelUp(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872E6B80-0x00000001872E6CE0
		public void OnlineFinishLevelUp(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter) {} // 0x00000001872E6CE0-0x00000001872E6ED0
		public void LevelWeaponUp(WeaponType weaponType, bool removeFromStore = true /* Metadata: 0x01978603 */, VampireSurvivors.Objects.Characters.CharacterController player = null) {} // 0x00000001872E6ED0-0x00000001872E7120
		public void OnReRollLevelUp() {} // 0x00000001872E7120-0x00000001872E7270
		public void OnLevelUpBanish() {} // 0x00000001872E7270-0x00000001872E73D0
		public int GetWeaponLevel(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872E73D0-0x00000001872E74E0
		public Weapon GetWeapon(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872E74E0-0x00000001872E7510
		public int GetAccessoryLevel(WeaponType accessoryType, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872E7510-0x00000001872E7620
		public bool HasCharacterInPlay(VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001872E7620-0x00000001872E76F0
		public bool HasWeaponInPlay(WeaponType weaponType) => default; // 0x00000001872E76F0-0x00000001872E7990
		public PickupWeapon TryGiveWeaponToPlayer(WeaponType weaponToGive, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872E7990-0x00000001872E7DD0
		public void DoPraise(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872E7DD0-0x00000001872E8560
		public Light2D GetLight(Destructible destructible) => default; // 0x00000001872E8560-0x00000001872E86F0
		public void ReturnLight(Destructible destructible) {} // 0x00000001872E86F0-0x00000001872E8800
		public bool LimitBreakWeaponUp(WeightedLimitBreak limitBreakData, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter) => default; // 0x00000001872E8800-0x00000001872E8B60
		public void FrameFreeze(Action onComplete = null, float milliseconds = 120f /* Metadata: 0x01978604 */, bool pauseTweens = false /* Metadata: 0x01978608 */) {} // 0x00000001872E8B60-0x00000001872E8DE0
		public void TriggerGoldFever(float durationMillis) {} // 0x00000001872E8DE0-0x00000001872E8E50
		public void TriggerFakeGoldFever(float durationMillis) {} // 0x00000001872E8E50-0x00000001872E8ED0
		public void QueueEnterPianoScene(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872E8ED0-0x00000001872E9080
		public void EnterPianoScene(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872E9080-0x00000001872E9170
		public void ExitPianoScene() {} // 0x0000000180B15170-0x0000000180B15180
		public bool CheckValidToastieInputs() => default; // 0x00000001872E9170-0x00000001872E92B0
		public bool HasAnimaWeapon(VampireSurvivors.Objects.Characters.CharacterController player) => default; // 0x00000001872E92B0-0x00000001872E9720
		public void CheckAllWeaponsForTeleport(float2 destinationPos) {} // 0x00000001872E9720-0x00000001872E9D00
		public FollowerEnemy_CharacterController AddLastEnemyFollower(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) => default; // 0x00000001872E9D00-0x00000001872E9E40
		public int GetNumAliveEnemyFollowers(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) => default; // 0x00000001872E9E40-0x00000001872E9EF0
		public void RefreshEnemyFollowersList(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) {} // 0x00000001872E9EF0-0x00000001872EA200
		public void FromOnlineSetEnemyFollowerDataOnly(short enemyType, bool wasCartRider) {} // 0x00000001872EA200-0x00000001872EA330
		public void FromOnlineSetRecycledEnemyFollowerData(short enemyType, bool wasCartRider, CoherenceSync newFollowerSync) {} // 0x00000001872EA330-0x00000001872EA540
		public FollowerEnemy_CharacterController AddNewEnemyFollower(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) => default; // 0x00000001872EA540-0x00000001872EB040
		public void KillAllFollowers(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) {} // 0x00000001872EB040-0x00000001872EB240
		public bool IsWeaponTypeAvailable(WeaponType element) => default; // 0x00000001872EB240-0x00000001872EB440
		public void DebugCharShowcase() {} // 0x00000001872EB440-0x00000001872EBAC0
		public void DebugCoopShowcase(bool prioritiseEvolvablePairings, long seed = -1 /* Metadata: 0x01978609 */, int minusMaxLevel = 0 /* Metadata: 0x01978611 */) {} // 0x00000001872EBAC0-0x00000001872EC980
		public void DebugGiveAllWeapons(bool includeSealedWeapons = true /* Metadata: 0x01978612 */) {} // 0x00000001872EC980-0x00000001872ECFE0
		public void DestroyOnlineConfigs() {} // 0x00000001872ECFE0-0x00000001872ED010
		public void InitializeStageLogicOnline() {} // 0x00000001872ED010-0x00000001872ED360
		private void LoadRestOfStageOnline() {} // 0x00000001872ED360-0x00000001872ED4B0
		public void StartOnlineGame() {} // 0x00000001872ED4B0-0x00000001872ED750
		public void LevelUpWithoutScreen() {} // 0x00000001872ED750-0x00000001872ED880
		public static bool IsOnMobile() => default; // 0x0000000180B15290-0x0000000180B152A0
		public static int GetAscensionBonusPercentage(int assignedPoints) => default; // 0x00000001872ED880-0x00000001872ED8B0
		[IteratorStateMachine(typeof(_InitRemoteCharacterWhenGameplayLoaded_d__579))]
		private IEnumerator InitRemoteCharacterWhenGameplayLoaded(GameObject characterInstance, VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001872ED8B0-0x00000001872ED9C0
		private void GeneratePickupVfx() {} // 0x00000001872ED9C0-0x00000001872EE9E0
		private void InitializeGameSession() {} // 0x00000001872EE9E0-0x00000001872EFB30
		private void InitializeGameSessionPostLoad() {} // 0x00000001872EFB30-0x00000001872F06C0
		[IteratorStateMachine(typeof(_WaitForAllCharactersToBeLoaded_d__583))]
		private IEnumerator WaitForAllCharactersToBeLoaded() => default; // 0x00000001872F06C0-0x00000001872F0760
		private void AddStartingWeaponsForAllCharacters() {} // 0x00000001872F0760-0x00000001872F08F0
		private void StageInit(StageType stageType) {} // 0x00000001872F08F0-0x00000001872F0BF0
		private void PostStageInit() {} // 0x00000001872F0BF0-0x00000001872F13C0
		private void InitCoopChestRandomness() {} // 0x00000001872F13C0-0x00000001872F1510
		[IteratorStateMachine(typeof(_SignalGameplayLoaded_d__588))]
		private IEnumerator SignalGameplayLoaded() => default; // 0x00000001872F1510-0x00000001872F15B0
		private void AddLocalCharacter(VampireSurvivors.Objects.Characters.CharacterController playerOne) {} // 0x00000001872F15B0-0x00000001872F1620
		private void RefreshCoopChestRandomisation() {} // 0x00000001872F1620-0x00000001872F16A0
		private VampireSurvivors.Objects.Characters.CharacterController FindNextValidWinner(Predicate<VampireSurvivors.Objects.Characters.CharacterController> isValid, bool saveChances) => default; // 0x00000001872F16A0-0x00000001872F1A10
		private void SetupGattiCustomBgmRate() {} // 0x00000001872F1A10-0x00000001872F1B70
		private void Cleanup() {} // 0x00000001872F1B70-0x00000001872F1E50
		public void FastForwardOneDay() {} // 0x00000001872F1E50-0x00000001872F1EC0
		private void OnTickerCallback() {} // 0x00000001872F1EC0-0x00000001872F2040
		private void ResetGameSessionCallback() {} // 0x00000001872F2040-0x00000001872F2050
		private void ResetGameSession(bool disconnectFromCoherence = true /* Metadata: 0x01978613 */) {} // 0x00000001872F2050-0x00000001872F2A20
		public void ReleaseGameplayLoader() {} // 0x00000001872F2A20-0x00000001872F2B60
		private void FinishLevelUpActions(WeaponType weaponType, bool setInvincibility, VampireSurvivors.Objects.Characters.CharacterController receivingCharacter = null) {} // 0x00000001872F2B60-0x00000001872F2C70
		private ArcadeSprite InitPlayerPhysics(GameObject characterInstance) => default; // 0x00000001872F2C70-0x00000001872F2EE0
		private VampireSurvivors.Objects.Characters.CharacterController GeneratePlayerCharacter(VampireSurvivors.Data.CharacterType characterType, int playerIndex) => default; // 0x00000001872F2EE0-0x00000001872F3600
		public void RemoveWallCollisionFromCharacter(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872F3600-0x00000001872F3730
		private void ApplyStatModifiers(VampireSurvivors.Objects.Characters.CharacterController newCharacter) {} // 0x00000001872F3730-0x00000001872F3780
		public VampireSurvivors.Objects.Characters.CharacterController AddFollower(VampireSurvivors.Data.CharacterType characterType, VampireSurvivors.Objects.Characters.CharacterController followedCharacter, AIType aiType, bool manualLevelups = false /* Metadata: 0x01978614 */, int EveryXLevels = 1 /* Metadata: 0x01978615 */, bool spawnWithoutAuthority = false /* Metadata: 0x01978616 */) => default; // 0x00000001872F3780-0x00000001872F3C30
		private void AddMainCharacter(VampireSurvivors.Objects.Characters.CharacterController newCharacter) {} // 0x00000001872F3C30-0x00000001872F3CB0
		private void AddInitialPresetLoadout(VampireSurvivors.Objects.Characters.CharacterController newCharacter) {} // 0x00000001872F3CB0-0x00000001872F3F50
		private void AddStartingWeapon(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872F3F50-0x00000001872F45A0
		private void GenerateMagnetZone(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872F45A0-0x00000001872F4790
		public void FirePlayerXpUpdatedFromOnline() {} // 0x00000001872F4790-0x00000001872F4840
		[IteratorStateMachine(typeof(_FirePlayerXpUpdatedFromOnlineRoutine_d__611))]
		private IEnumerator FirePlayerXpUpdatedFromOnlineRoutine() => default; // 0x00000001872F4840-0x00000001872F48E0
		public void FirePlayerXpUpdated() {} // 0x00000001872F48E0-0x00000001872F49E0
		private void AddWeaponToPlayer(GameplaySignals.AddWeaponToCharacterSignal signal) {} // 0x00000001872F49E0-0x00000001872F4B00
		private void AddAccessoryToPlayer(GameplaySignals.AddAccessoryToCharacterSignal signal) {} // 0x00000001872F4B00-0x00000001872F4B70
		public void SetSeenWeapon(WeaponType weaponType) {} // 0x00000001872F4B70-0x00000001872F4C90
		public Weapon AddWeapon(WeaponType weapon, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x00000001872F4C90-0x00000001872F4CF0
		private void RemoveWeaponFromPlayer(GameplaySignals.RemoveWeaponFromCharacterSignal signal) {} // 0x00000001872F4CF0-0x00000001872F5130
		public Weapon AddHiddenWeapon(WeaponType weapon, VampireSurvivors.Objects.Characters.CharacterController character, bool allowDuplicates = false /* Metadata: 0x01978617 */) => default; // 0x00000001872F5130-0x00000001872F5170
		private void AddHiddenWeaponToPlayer(GameplaySignals.AddHiddenWeaponToCharacterSignal signal) {} // 0x00000001872F5170-0x00000001872F51B0
		private void RemoveHiddenWeaponFromPlayer(GameplaySignals.RemoveHiddenWeaponFromCharacterSignal signal) {} // 0x00000001872F51B0-0x00000001872F51E0
		public void SetPlayersVisible(bool visible) {} // 0x00000001872F51E0-0x00000001872F52E0
		public void SetPlayersInvulForMillisecondsAndRestoreTints(float milliseconds) {} // 0x00000001872F52E0-0x00000001872F5610
		public void SetPlayersInvulForMilliSecondsNonCumulative(float milliseconds) {} // 0x00000001872F5610-0x00000001872F5720
		private void SetPlayerInvincibility(GameplaySignals.SetCharacterInvincibilityForMillisSignal signal) {} // 0x00000001872F5720-0x00000001872F58F0
		private void SetPlayerInvincibilityNonCumulative(GameplaySignals.SetCharacterInvincibilityForMillisNonCumulativeSignal signal) {} // 0x00000001872F58F0-0x00000001872F5AC0
		private void LetPlayersGetTheirBearings() {} // 0x00000001872F5AC0-0x00000001872F5B00
		private void OnReviveCharacter(GameplaySignals.ReviveCharacterSignal signal) {} // 0x00000001872F5B00-0x00000001872F5D90
		public void RunAllPostRevivialActions(VampireSurvivors.Objects.Characters.CharacterController revived, bool instantRevival = false /* Metadata: 0x01978618 */) {} // 0x00000001872F5D90-0x00000001872F5F10
		private void ApplyAscensionPoints(VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872F5F10-0x00000001872F62E0
		private void ApplyPurchasedPowerUpData(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872F62E0-0x00000001872F65B0
		private void ApplyPlayerStat(PlayerStat playerStat, VampireSurvivors.Objects.Characters.CharacterController characterController) {} // 0x00000001872F65B0-0x00000001872F6780
		private void OnLevelUpSkipped(GameplaySignals.SkipLevelUpSignal signal) {} // 0x00000001872F6780-0x00000001872F6B40
		private float GetLevelUpSkipXpToGrant(VampireSurvivors.Objects.Characters.CharacterController player) => default; // 0x00000001872F6B40-0x00000001872F6B80
		private void OnLevelUpCompleted() {} // 0x00000001872F6B80-0x00000001872F6D30
		public void CycleActivePlayer() {} // 0x00000001872F6D30-0x00000001872F6F20
		private void UpdateTouchControls(bool isOn) {} // 0x00000001872F6F20-0x00000001872F6F60
		private void OnJoystickOptionsChanged(UISignals.SetVisibleJoysticksSignal signal) {} // 0x00000001872F6F20-0x00000001872F6F60
		private void SetupMusicNormal() {} // 0x00000001872F6F60-0x00000001872F71C0
		private bool SetupCharacterMusic() => default; // 0x00000001872F71C0-0x00000001872F7470
		private bool GetMusicData(BgmType bgmType, out MusicData musicData) {
			musicData = default;
			return default;
		} // 0x00000001872F7470-0x00000001872F7600
		public void DisableBuiltInLighting() {} // 0x00000001872F7600-0x00000001872F77A0
		public bool HasSpecialStageLighting() => default; // 0x00000001872F77A0-0x00000001872F7870
		public Light2D GetGlobalLight() => default; // 0x0000000180B15760-0x0000000180B15770
		public void SetSpecialStageLightingEnabled(bool enabled) {} // 0x00000001872F7870-0x00000001872F79C0
		[IteratorStateMachine(typeof(_ReenableBrokenShadowCasterGroup2DsBecauseUnity_d__645))]
		private IEnumerator ReenableBrokenShadowCasterGroup2DsBecauseUnity() => default; // 0x00000001872F79C0-0x00000001872F7A60
		private void SetupLighting() {} // 0x00000001872F7A60-0x00000001872F7EF0
		private void AddLightsToPool(int count) {} // 0x00000001872F7EF0-0x00000001872F8790
		private Light2D AddLight(Vector2 pos, float radius, float intensity) => default; // 0x00000001872F8790-0x00000001872F8A70
		private void OnFireEnemyBullet(GameplaySignals.FireEnemyBulletSignal signal) {} // 0x00000001872F8A70-0x00000001872F8AE0
		public void OnStagePickupCallback(Pickup pickup) {} // 0x00000001872F8AE0-0x00000001872F8B70
		private void SpawnGems() {} // 0x00000001872F8B70-0x00000001872F9180
		private void CondenseGems(int maxGems = 400 /* Metadata: 0x01978619 */) {} // 0x00000001872F9180-0x00000001872F9640
		private void SpawnPickups<T>(List<PickupToSpawn> toSpawn, HashSet<T> pickupSet, int MAX_COUNT, float defaultValue, ObjectPool pool, VampireSurvivors.Data.ItemType itemType)
			where T : Pickup, ICountedPickup {}
		private void CondensePickups<T>(HashSet<T> pickupSet, int maxPickups)
			where T : Pickup, ICountedPickup {}
		public void QueueGenericResume(VampireSurvivors.Objects.Characters.CharacterController pausingPlayer) {} // 0x00000001872F9640-0x00000001872F97E0
		private void PerformGenericResume(VampireSurvivors.Objects.Characters.CharacterController pausingPlayer, Dictionary<string, object> args) {} // 0x00000001872F97E0-0x00000001872F9850
		public void QueueGenericPause(VampireSurvivors.Objects.Characters.CharacterController pausingPlayer) {} // 0x00000001872F9850-0x00000001872F99F0
		private void GenericOnlinePause(VampireSurvivors.Objects.Characters.CharacterController pausingPlayer, Dictionary<string, object> args) {} // 0x00000001872F99F0-0x00000001872F9D30
		public void QueueOpenWeaponSelection(VampireSurvivors.Objects.Characters.CharacterController player, string weaponSelectionType) {} // 0x00000001872F9D30-0x00000001872F9FD0
		private void OpenWeaponSelection(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872F9FD0-0x00000001872FA2E0
		public void QueueEnterSkillSelection(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FA2E0-0x00000001872FA480
		private void EnterSkillSelection(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FA480-0x00000001872FA5E0
		public void QueueEnterShop(VampireSurvivors.Objects.Characters.CharacterController player, MerchantInventoryType inventoryType, PickupCustomMerchant customMerchant) {} // 0x00000001872FA5E0-0x00000001872FA8D0
		private void EnterShop(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FA8D0-0x00000001872FABD0
		public void QueueEnterHealer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FABD0-0x00000001872FAD70
		private void EnterHealer(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FAD70-0x00000001872FAE60
		public void QueueEnterDirecter(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FAE60-0x00000001872FB000
		private void EnterDirecter(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FB000-0x00000001872FB0F0
		public void QueueOpenArcana(ArcanaUiType type, VampireSurvivors.Objects.Characters.CharacterController chestWinner = null) {} // 0x00000001872FB0F0-0x00000001872FB5D0
		private void OpenMainArcana(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FB5D0-0x00000001872FB7C0
		public void QueueOpenSurvarots(int cardsToShow, VampireSurvivors.Objects.Characters.CharacterController chestWinner) {} // 0x00000001872FB7C0-0x00000001872FBAC0
		private void OpenSurvarots(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FBAC0-0x00000001872FBD20
		public void QueueReportBody(VampireSurvivors.Objects.Characters.CharacterController reporter, VampireSurvivors.Objects.Characters.CharacterController reportedPlayer) {} // 0x00000001872FBD20-0x00000001872FBFB0
		private void TransitionToReportBody(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FBFB0-0x00000001872FC1C0
		private void SwapToRelicFoundScreen(VampireSurvivors.Objects.Characters.CharacterController targetPlayer, Dictionary<string, object> args) {} // 0x00000001872FC1C0-0x00000001872FC320
		private void SwapToItemFoundScreen(VampireSurvivors.Objects.Characters.CharacterController targetPlayer, Dictionary<string, object> args) {} // 0x00000001872FC320-0x00000001872FC5F0
		private void SwapToCharFoundScreen(VampireSurvivors.Objects.Characters.CharacterController targetPlayer, Dictionary<string, object> args) {} // 0x00000001872FC5F0-0x00000001872FC740
		public void PreManipulateLevelUpOptionsForSpecialWeapons() {} // 0x00000001872FC740-0x00000001872FCEF0
		public void PostManipulateLevelUpOptionsForSpecialWeapons() {} // 0x00000001872FCEF0-0x00000001872FD630
		private void SwapToLevelUpScreen(bool adjustXpFactors) {} // 0x00000001872FD630-0x00000001872FD9B0
		private void StartOnlineLevelUpFromHost(bool shouldSendLevelUpSignal, bool adjustXpFactors, WeaponType? randomWeapon, WeightedLimitBreak randomLimitBreak, bool roastLevelUp, bool coinBagLevelUp) {} // 0x00000001872FD9B0-0x00000001872FDD30
		private bool CanLimitBreak() => default; // 0x00000001872FDD30-0x00000001872FDE40
		private void GetLevelUpChoices(out List<WeaponType> chosenWeapons, out List<VampireSurvivors.Objects.Characters.CharacterController> amuletTargets, out List<WeightedLimitBreak> limitBreaks, out List<VampireSurvivors.Data.ItemType> chosenItems) {
			chosenWeapons = default;
			amuletTargets = default;
			limitBreaks = default;
			chosenItems = default;
		} // 0x00000001872FDE40-0x00000001872FE240
		private bool ApplyOfflineLevelUp(WeaponType? randomWeapon, VampireSurvivors.Objects.Characters.CharacterController player, WeightedLimitBreak randomLimitBreak, bool shouldSendLevelUpSignal, bool roastLevelUp, bool coinBagLevelUp) => default; // 0x00000001872FE240-0x00000001872FE350
		private void ApplyCoinBagLevelUp(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FE350-0x00000001872FE690
		private void ApplyRoastLevelUp(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FE690-0x00000001872FE7C0
		private bool ApplyRandomLevelUpLimitBreak(WeightedLimitBreak lBreakData, VampireSurvivors.Objects.Characters.CharacterController player) => default; // 0x00000001872FE7C0-0x00000001872FEA00
		private void ApplyRandomLevelUpWeapon(WeaponType choice, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872FEA00-0x00000001872FED80
		private void SwapToTreasureScreen(VampireSurvivors.Objects.Characters.CharacterController player, Dictionary<string, object> args) {} // 0x00000001872FED80-0x00000001872FF130
		public bool CanPlayQuickTreasureAnim(List<TreasurePrizeTypePair> prizes) => default; // 0x00000001872FF130-0x00000001872FF1C0
		private void PlayQuickTreasureAnim(Treasure treasure, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872FF1C0-0x00000001872FF5B0
		private bool CanSkipTreasureLevel3(PlayerOptionsData config) => default; // 0x00000001872FF5B0-0x00000001872FF700
		private bool AllPrizesAreFillerOrArcana(List<TreasurePrizeTypePair> prizes) => default; // 0x00000001872FF700-0x00000001872FF870
		private void GenerateCheatCodeManager() {} // 0x00000001872FF870-0x00000001872FF920
		private void ClearTimeStop() {} // 0x00000001872FF920-0x00000001872FFB00
		public void OnConnectionError(CoherenceBridge _, ConnectionException connectionException) {} // 0x00000001872FFB00-0x00000001872FFDF0
		public void HandleCameraUpdate() {} // 0x00000001872FFDF0-0x0000000187300020
		public bool IsNormalCameraTarget() => default; // 0x0000000187300020-0x0000000187300240
		private Transform GetFreeRoamCameraTarget() => default; // 0x0000000187300260-0x0000000187300540
		private void UpdateCameraTarget() {} // 0x0000000187300540-0x0000000187301150
		public float AveragePlayerCurse() => default; // 0x0000000187301150-0x0000000187301360
		public bool HasAPlayerGotRevivals() => default; // 0x0000000187301360-0x0000000187301550
		public double GetMaxReviveCount() => default; // 0x0000000187301550-0x00000001873017E0
		public float GetDefangChanceFromArray() => default; // 0x00000001873017E0-0x0000000187301880
		public bool HasRandomazzoEnabled() => default; // 0x0000000187301880-0x0000000187301A30
		public float GetKillRatio() => default; // 0x0000000187301A30-0x0000000187301A90
		public List<VampireSurvivors.Objects.Characters.CharacterController> GetFollowers(VampireSurvivors.Objects.Characters.CharacterController followedCharacter) => default; // 0x0000000187301A90-0x0000000187301D80
		public void DoRemovePowersEffect(List<string> frames, List<string> textureNames = null, float scale = 1f /* Metadata: 0x0197861B */, float2? center = default) {} // 0x0000000187301D80-0x00000001873023A0
		public void ClearCurrentCustomMerchant() {} // 0x00000001873023A0-0x0000000187302400
	}
}
