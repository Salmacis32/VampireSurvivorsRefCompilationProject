/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Log;
using DG.Tweening;
using Newtonsoft.Json.Linq;
using QFSW.MOP2;
using SuperTiled2Unity;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors;
using VampireSurvivors.App.Data;
using VampireSurvivors.App.Framework;
using VampireSurvivors.App.Objects;
using VampireSurvivors.App.Scripts.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Stages;
using VampireSurvivorsDecompProject.Objects.Weapons;
using VampireSurvivors.Signals;
using Zenject;
using VampireSurvivors.Objects;

namespace VampireSurvivorsDecompProject.Objects
{
	public class Stage : GameMonoBehaviour
	{
		[SerializeField]
		private TilingBackground _TilingBackgroundPrefab;
		[SerializeField]
		private TilingTileset _TilingTilesetPrefab;
		[SerializeField]
		private Transform _LevelTransform;
		private static List<VampireSurvivors.Data.CharacterType> _validStageCharacters; // 0x00
		private StageType _stageType; // 0x40
		private int _currentMinute; // 0x44
		private int _maxStageDataMinute; // 0x48
		private int _maximum; // 0x4C
		private int _lastMinimum; // 0x50
		private int _lastMaximum; // 0x54
		private int _defaultMaximum; // 0x58
		private float _minMultiplier; // 0x5C
		private float _onlineEnemyMultiplier; // 0x60
		private float _effectiveSpawnFrequency; // 0x64
		private JObject _stageJsonData; // 0x68
		private StageData _stageData; // 0x70
		private StageData _baseStageData; // 0x78
		private Dictionary<int, JArray> _stageDataByBiome; // 0x80
		private bool _hasTileSet; // 0x88
		private VampireSurvivors.Data.SpawnType _spawnType; // 0x8C
		private bool _hasAttachedTreasure; // 0x90
		private bool _compressTime; // 0x91
		private float _pizzaDelay; // 0x94
		private const float PizzaIntervalMillis = 20000f; // Metadata: 0x01977377
		private const int BulletAllowance = 50; // Metadata: 0x0197737B
		private VampireSurvivors.Framework.TimerSystem.Timer _pauseTimer; // 0x98
		private VampireSurvivors.Framework.TimerSystem.Timer _spawnTimer; // 0xA0
		private VampireSurvivors.Framework.TimerSystem.Timer _destructibleTimer; // 0xA8
		private VampireSurvivors.Framework.TimerSystem.Timer _checkPizzasTimer; // 0xB0
		private readonly List<Vector2> _enemySpawnLocations; // 0xB8
		private readonly List<Vector2> _destructibleLocations; // 0xC0
		private List<Vector2> _cartLocations; // 0xC8
		private List<Vector2> _windowLocations; // 0xD0
		private List<Vector2> _pizzaLocations; // 0xD8
		private readonly List<PizzaCircle> _pizzaCircles; // 0xE0
		private List<Vector2> _tiledPositions; // 0xE8
		private List<Rectangle> _noShadowLocations; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _noShadowsTimer; // 0xF8
		private bool _shadowsVisible; // 0x100
		private MultiTargetTween _shadowsTween; // 0x108
		private Rect _spawnOuterRect; // 0x110
		private Rect _spawnInnerRect; // 0x120
		private Rect _containmentScreenRect; // 0x130
		private Rect _containmentExactRect; // 0x140
		private Rect _tiledOuterRect; // 0x150
		private Rect _tiledInnerRect; // 0x160
		private float _widthRect; // 0x170
		private float _heightRect; // 0x174
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, Rect> _spawnOuterRects; // 0x178
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, Rect> _spawnInnerRects; // 0x180
		private Dictionary<VampireSurvivors.Objects.Characters.CharacterController, Rect> _playerRects; // 0x188
		private readonly List<EnemyController> _spawnedEnemies; // 0x190
		private readonly HashSet<EnemyController> _authoritativePermanentEnemies; // 0x198
		private static Coherence.Log.Logger _logger; // 0x08
		private bool _hasWallsCheckDestructibleLogic; // 0x1A0
		private bool _isCharmApplied; // 0x1A1
		private bool _disableMinueteSpawning; // 0x1A2
		private Transform _cachedTransform; // 0x1A8
		private Camera _mainCamera; // 0x1B0
		private SignalBus _signalBus; // 0x1B8
		private DataManager _dataManager; // 0x1C0
		private PlayerOptions _playerOptions; // 0x1C8
		private StageEventManager _stageEventManager; // 0x1D0
		private StageEventTrisectionManager _trisection; // 0x1D8
		private GlimmerManager _glimmerManager; // 0x1E0
		private StageEventTwitchManager _stageEventTwitchManager; // 0x1E8
		private GameSessionData _gameSessionData; // 0x1F0
		private DiContainer _diContainer; // 0x1F8
		private TilingBackground _tilingBackground; // 0x200
		private TilingTileset _tilingTileset; // 0x208
		private EnemyFactory _enemyFactory; // 0x210
		private DestructibleFactory _destructibleFactory; // 0x218
		private ArcanaManager _arcanaManager; // 0x220
		private BackgroundManager _fancyBg; // 0x228
		private GameManager _gameManager; // 0x230
		private LobbiesManager _lobbiesManager; // 0x238
		private PhaserSprite _beam; // 0x240
		private PhaserSprite _whiteFader; // 0x248
		private List<EnemyType?> _enemyTypes; // 0x250
		private List<EnemyType?> _bossTypes; // 0x258
		private readonly Dictionary<EnemyType, bool> _enemyPoolStates; // 0x260
		private readonly Dictionary<EnemyType, bool> _bossPoolStates; // 0x268
		public float _ShadowAlpha; // 0x278
		public float _SoleShadowAlpha; // 0x27C
		private StageData _tmpStageData; // 0x2C8
		private static readonly ProfilerMarker MarkerSpawnEnemy; // 0x10
		private static readonly ProfilerMarker MarkerFindClosestEnemy; // 0x18
		private SortedList<uint, EnemyController> _queryEnemiesCache; // 0x2D0
		private List<EnemyController> _unsortedEnemiesCache; // 0x2D8
		private List<Pickup> _onScreenPickupsCache; // 0x2E0
		private static readonly ProfilerMarker MarkerHandleSpawning; // 0x20
		private static readonly ProfilerMarker MarkerSpawnEnemyUnit; // 0x28
		private static readonly ProfilerMarker MarkerSpawnEnemyResolve; // 0x30
		private static readonly ProfilerMarker MarkerUpdateCulling; // 0x38
		private int _cullIterator; // 0x2E8
		private List<EnemyController> _enemiesToCull; // 0x2F0
		private static readonly ProfilerMarker MarkerDespawnEnemyIfOutsideRect; // 0x40
		public PickupMerchant TrouserMerchant; // 0x2F8
	
		// Properties
		public static List<VampireSurvivors.Data.CharacterType> ValidStageCharacters { get => default; } // 0x0000000186A13070-0x0000000186A130D0 
		public float OnlineEnemyMultiplier { get => default; set {} } // 0x00000001832F7340-0x00000001832F7350 0x000000018474CF00-0x000000018474CF10
		public bool DisableMinueteSpawning { get => default; set {} } // 0x0000000186A130D0-0x0000000186A130E0 0x0000000186A130E0-0x0000000186A130F0
		public List<Weapon> StageHazardWeapons { get; set; } // 0x0000000186A130F0-0x0000000186A13100 0x0000000186A13100-0x0000000186A13160
		public DestructibleFactory DestructibleFactory { get => default; } // 0x00000001865DBE50-0x00000001865DBE60 
		public StageEventTrisectionManager Trisection { get => default; } // 0x0000000182766D00-0x0000000182766D10 
		public GlimmerManager GlimmerManager { get => default; } // 0x0000000185D98490-0x0000000185D984A0 
		public Rect ContainmentExactRect { get => default; } // 0x0000000182926E40-0x0000000182926E50 
		public bool HasInitialized { get; private set; } // 0x00000001867537D0-0x00000001867537E0 0x00000001867537E0-0x00000001867537F0
		public List<EnemyController> SpawnedEnemies { get => default; } // 0x0000000182766A50-0x0000000182766A60 
		public int EnemiesCount { get => default; } // 0x0000000186A13160-0x0000000186A131B0 
		public VampireSurvivors.Data.SpawnType SpawnType { get => default; set {} } // 0x0000000181BA6010-0x0000000181BA6020 0x0000000181BA6020-0x0000000181BA6030
		public int PermanentEnemiesNumber { get => default; } // 0x0000000186A131B0-0x0000000186A13290 
		public StageData ActiveStageData { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public Rect SpawnOuterRect { get => default; } // 0x0000000186A13290-0x0000000186A132A0 
		public Rect SpawnInnerRect { get => default; } // 0x0000000186A132A0-0x0000000186A132B0 
		public Rect ContainmentScreenRect { get => default; } // 0x0000000186A132B0-0x0000000186A132C0 
		public List<Vector2> EnemySpawnLocations { get => default; } // 0x00000001819A01A0-0x00000001819A01B0 
		public bool HasTileSet { get => default; } // 0x0000000182699300-0x0000000182699310 
		public StageEventManager StageEventManager { get => default; } // 0x0000000182766C90-0x0000000182766CA0 
		public StageEventTwitchManager StageEventTwitchManager { get => default; } // 0x0000000185D984A0-0x0000000185D984B0 
		public GameSessionData GameSessionData { get => default; } // 0x0000000186747270-0x0000000186747280 
		public TilingTileset TilingTileset { get => default; } // 0x00000001854006C0-0x00000001854006D0 
		public TilingBackground TilingBackground { get => default; } // 0x00000001858341D0-0x00000001858341E0 
		public float EnemyHealthMultiplier { get; set; } // 0x0000000185FB65C0-0x0000000185FB65D0 0x0000000186A132C0-0x0000000186A132D0
		public float EnemySpeedMultiplier { get; set; } // 0x0000000186A132D0-0x0000000186A132E0 0x0000000186A132E0-0x0000000186A132F0
		public List<VampireSurvivors.Data.ItemType> LootTable { get => default; } // 0x0000000186A132F0-0x0000000186A13310 
		public BackgroundManager FancyBg { get => default; } // 0x0000000186747010-0x0000000186747020 
		public LobbiesManager LobbiesManager { get => default; } // 0x0000000186753520-0x0000000186753530 
		public List<Vector2> DestructibleLocations { get => default; } // 0x00000001819A0460-0x00000001819A0470 
		public int MaxDestructibles { get; set; } // 0x0000000186A13310-0x0000000186A13320 0x0000000186A13320-0x0000000186A13330
		public float Pause { get; set; } // 0x0000000186A13330-0x0000000186A13340 0x0000000186A13340-0x0000000186A13350
		public bool HasLights { get => default; } // 0x0000000186A13350-0x0000000186A13370 
		public bool HasCharacterSpotlight { get => default; } // 0x0000000186A13370-0x0000000186A13390 
		public bool StopCheckingMinutes { get; set; } // 0x0000000186753900-0x0000000186753910 0x0000000186753910-0x0000000186753920
		public List<PizzaCircle> PizzaCircles { get => default; } // 0x000000018282D820-0x000000018282D830 
		public StageType StageType { get => default; } // 0x0000000181953C80-0x0000000181953C90 
		public PropType DestructibleType { get => default; } // 0x0000000186A13390-0x0000000186A13420 
		public StageModifiers StageMods { get; set; } // 0x0000000186A13420-0x0000000186A13430 0x0000000186A13430-0x0000000186A13490
		public List<EnemyType?> BossTypes { get => default; } // 0x00000001840DCD50-0x00000001840DCD60 
		public List<EnemyType?> EnemyTypes { get => default; set {} } // 0x00000001867535F0-0x0000000186753600 0x0000000186753600-0x0000000186753660
		public int Maximum { get => default; set {} } // 0x00000001819A01C0-0x00000001819A01D0 0x000000018395D5B0-0x000000018395D5C0
		public int LastMinimum { get => default; set {} } // 0x0000000180B15770-0x0000000180B15780 0x0000000182621130-0x0000000182621140
		public int LastMaximum { get => default; set {} } // 0x00000001819A01D0-0x00000001819A01E0 0x0000000181EDFC70-0x0000000181EDFC80
		public float? MinTreasureY { get; set; } // 0x0000000185EAA030-0x0000000185EAA040 0x0000000186A13490-0x0000000186A134A0
		public float? MaxTreasureY { get; set; } // 0x0000000186A134A0-0x0000000186A134B0 0x0000000186A134B0-0x0000000186A134C0
		public float? MinTreasureX { get; set; } // 0x0000000185FA2C80-0x0000000185FA2C90 0x0000000186A134C0-0x0000000186A134D0
		public float? MaxTreasureX { get; set; } // 0x0000000186A134D0-0x0000000186A134E0 0x0000000186A134E0-0x0000000186A134F0
		public Rect EnemiesDespawnRect { get => default; } // 0x0000000186A134F0-0x0000000186A13730 
		public EnemyFactory EnemyFactory { get => default; } // 0x0000000185FA1D70-0x0000000185FA1D80 
		public bool PoolsInitialized { get; private set; } // 0x0000000186753A20-0x0000000186753A30 0x0000000186753A30-0x0000000186753A40
		private float Frequency { get => default; } // 0x0000000186A13730-0x0000000186A13750 
		private float DestructibleFrequency { get => default; } // 0x0000000186A13750-0x0000000186A13770 
		private bool IsMerchantBanned { get => default; } // 0x0000000186A13770-0x0000000186A13790 
		public int CurrentMinute { get => default; } // 0x00000001828975B0-0x00000001828975C0 
		private int StartingSpawns { get => default; } // 0x0000000186A13790-0x0000000186A137B0 
	
		// Constructors
		public Stage() {} // 0x0000000186A35290-0x0000000186A361D0
		static Stage() {} // 0x0000000186A361D0-0x0000000186A36BE0
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, PlayerOptions playerOptions, SignalBus signalBus, GameSessionData gameSessionData, DiContainer diContainer, EnemyFactory enemyFactory, DestructibleFactory destructibleFactory, ArcanaManager arcanaManager, GameManager gameManager, LobbiesManager lobbiesManager) {} // 0x0000000186A137B0-0x0000000186A13C20
		private new void Awake() {} // 0x0000000186A13C20-0x0000000186A13D10
		private void Start() {} // 0x0000000186A13D10-0x0000000186A13EE0
		protected override void OnUpdate() {} // 0x0000000186A13EE0-0x0000000186A14030
		protected override void OnDestroy() {} // 0x0000000186A14030-0x0000000186A140E0
		private void OnDrawGizmosSelected() {} // 0x0000000186A140E0-0x0000000186A154E0
		public static List<VampireSurvivors.Data.CharacterType> GetValidStageXCharacters() => default; // 0x0000000186A154E0-0x0000000186A15540
		public static bool HasValidStageXCharacters() => default; // 0x0000000186A15540-0x0000000186A158C0
		public static bool HasAllNonVoidCharacters() => default; // 0x0000000186A158C0-0x0000000186A15AD0
		public static List<VampireSurvivors.Data.CharacterType> GetValidAnyStageCharacters() => default; // 0x0000000186A15AD0-0x0000000186A15CB0
		public static List<StageType> GetValidUnlockedHypers() => default; // 0x0000000186A15CB0-0x0000000186A15F00
		public static List<StageType> GetValidUnlockedStages() => default; // 0x0000000186A15F00-0x0000000186A16150
		public void InitStage(StageType stageType) {} // 0x0000000186A16150-0x0000000186A17AC0
		public void DoTeleportVfx(float2 position, TweenCallback onComplete, Action onYoyo) {} // 0x0000000186A17AC0-0x0000000186A17F90
		private void MakeDoorVfx() {} // 0x0000000186A17F90-0x0000000186A18510
		private static int AddFollower(FollowerData followerData, VampireSurvivors.Objects.Characters.CharacterController playerOne, int lastPlayerindex) => default; // 0x0000000186A18510-0x0000000186A189E0
		private void SetupStageDataByBiome(StageType stageType) {} // 0x0000000186A189E0-0x0000000186A18A70
		private void SetupStageDataByBiomeInternal<TBiome>(StageType stageType)
			where TBiome : struct, System.Enum {}
		public void InitStagePostLoad() {} // 0x0000000186A18A70-0x0000000186A19120
		public SuperObject GetHardBoundsObjFromTMX() => default; // 0x0000000186A19120-0x0000000186A196A0
		private void SetHardBoundsFromTMX() {} // 0x0000000186A196A0-0x0000000186A19CD0
		private void SetHardBoundsFromStageData() {} // 0x0000000186A19CD0-0x0000000186A19DA0
		public void CheckHalfMinute() {} // 0x0000000186A19DA0-0x0000000186A1A000
		public void CheckMinute() {} // 0x0000000186A1A000-0x0000000186A1A520
		public void OnCycleComplete() {} // 0x0000000186A1A520-0x0000000186A1A940
		public void DebugNextMinute() {} // 0x0000000186A1A940-0x0000000186A1A9E0
		public void DebugNextHalfMinute() {} // 0x0000000186A1A9E0-0x0000000186A1AA80
		public void DebugLastMinute() {} // 0x0000000186A1AA80-0x0000000186A1AB40
		public void Cleanup() {} // 0x0000000186A1AB40-0x0000000186A1B400
		public void CancelSpawnTimer() {} // 0x0000000186A1B400-0x0000000186A1B420
		public Weapon AddStageHazardWeapon(WeaponType weaponType) => default; // 0x0000000186A1B420-0x0000000186A1B590
		public GameObject SpawnEnemy(EnemyType enemyType, Vector2 spawnPos, bool asRemote = false /* Metadata: 0x0197733D */, bool forceSpawn = false /* Metadata: 0x0197733E */) => default; // 0x0000000186A1B590-0x0000000186A1B6C0
		public GameObject SpawnEnemyInOuterRect(EnemyType enemyType, bool checkWalls = false /* Metadata: 0x0197733F */, bool forceSpawn = false /* Metadata: 0x01977340 */) => default; // 0x0000000186A1B6C0-0x0000000186A1B7C0
		public T SpawnEnemy<T>(EnemyType enemyType, Vector2 spawnPos, bool asRemote = false /* Metadata: 0x01977341 */, bool forceSpawn = false /* Metadata: 0x01977342 */)
			where T : EnemyController => default;
		public void DebugSpawnMaxEnemies() {} // 0x0000000186A1B7C0-0x0000000186A1B7F0
		public void DebugSpawnAllEnemies() {} // 0x0000000186A1B7F0-0x0000000186A1B9A0
		public void CalculateEnemySpeed() {} // 0x0000000186A1B9A0-0x0000000186A1BAD0
		public void RecalculateCurseAndCharm() {} // 0x0000000186A1BAD0-0x0000000186A1BD00
		public void ResetStageMinimumSpawnToDefault() {} // 0x0000000186A1BD00-0x0000000186A1BEA0
		public void ResetStageMaximumSpawnToDefault() {} // 0x0000000186A1BEA0-0x0000000186A1BEB0
		public void SetSpawnType(VampireSurvivors.Data.SpawnType type) {} // 0x0000000181BA6020-0x0000000181BA6030
		public void SetWallsCheckDestructibleAndEnemiesLogic(bool value) {} // 0x0000000186A1BEB0-0x0000000186A1BEC0
		public void StartTimers() {} // 0x0000000186A1BEC0-0x0000000186A1C100
		public void CancelTimers() {} // 0x0000000186A1C100-0x0000000186A1C140
		public EnemyController ClosestAlive(Vector3 queryPos, float maxRange = 3.4028235E+38f /* Metadata: 0x01977343 */) => default; // 0x0000000186A1C140-0x0000000186A1C180
		public EnemyController FindClosestEnemy(Vector3 queryPos, bool excludeDead = false, float maxRange = 3.4028235E+38f)
		{
			if (_spawnedEnemies == null || _spawnedEnemies.Count == 0) return null;
			var range = (Math.Pow(maxRange, 2) >= 3.4028235E+38f) ? 3.4028235E+38f : maxRange;
			if (excludeDead)
			{
				
			}
        }
		public EnemyController FindClosestLateralEnemy(Vector3 queryPos, bool excludeDead = false /* Metadata: 0x0197734C */, float maxRange = 3.4028235E+38f /* Metadata: 0x0197734D */, bool checkLeft = true /* Metadata: 0x01977351 */) => default; // 0x0000000186A1C630-0x0000000186A1CB50
		public List<EnemyController> GetClosestEnemiesSorted(Vector3 queryPos, bool excludeDead = false /* Metadata: 0x01977352 */, float maxRange = 3.4028235E+38f /* Metadata: 0x01977353 */) => default; // 0x0000000186A1CB50-0x0000000186A1D280
		public EnemyController PickRandomEnemyController(Unity.Mathematics.Random? rng) => default; // 0x0000000186A1D280-0x0000000186A1D360
		public Transform PickRandomEnemy(Unity.Mathematics.Random? rng) => default; // 0x0000000186A1D360-0x0000000186A1D440
		public Transform PickRandomEnemyInScreenBounds(Unity.Mathematics.Random? rng) => default; // 0x0000000186A1D440-0x0000000186A1D560
		public Transform PickRandomEnemyInRectBounds(Rectangle _rect, Unity.Mathematics.Random? rng) => default; // 0x0000000186A1D560-0x0000000186A1DCA0
		public void GetEnemyBodiesInRect(Rectangle _rect, ref List<BaseBody> list) {} // 0x0000000186A1DCA0-0x0000000186A1DFF0
		private EnemyController PickRandomEnemyFromList(IList<EnemyController> enemiesList, Unity.Mathematics.Random? rng) => default; // 0x0000000186A1DFF0-0x0000000186A1E180
		public Transform PickRandomEnemyInCircle(float2 position, float radius, Unity.Mathematics.Random? rng) => default; // 0x0000000186A1E180-0x0000000186A1E2F0
		public List<EnemyController> GetEnemiesInCircle(float2 position, float radius) => default; // 0x0000000186A1E2F0-0x0000000186A1E640
		public List<EnemyController> GetAllEnemiesInScreenBounds() => default; // 0x0000000186A1E640-0x0000000186A1E650
		public List<EnemyController> GetAllEnemiesInScreenBounds(float excludedBorderPercentage01) => default; // 0x0000000186A1E650-0x0000000186A1EB50
		public void DebugSpawnDestructibles(float percentage = 1f /* Metadata: 0x01977357 */) {} // 0x0000000186A1EB50-0x0000000186A1EEB0
		public Destructible MakeDestructible(PropType destructibleType, Vector2 pos) => default; // 0x0000000186A1EEB0-0x0000000186A1F130
		public List<Destructible> GetAllDestructiblesInScreenBounds() => default; // 0x0000000186A1F130-0x0000000186A1F380
		public List<Pickup> GetAllPickupsInScreenBounds() => default; // 0x0000000186A1F380-0x0000000186A1F750
		public List<Pickup> GetAllGemsInScreenBounds() => default; // 0x0000000186A1F750-0x0000000186A1FAD0
		public List<Pickup> GetAllFrozenSoulsInScreenBounds() => default; // 0x0000000186A1FAD0-0x0000000186A1FE50
		public void FireEnemyBulletAt(Vector2 spawnPos, EnemyType bulletType = EnemyType.BULLET_1 /* Metadata: 0x0197735B */) {} // 0x0000000186A1FE50-0x0000000186A1FEC0
		private void SpawnEnemyBullet(Vector2 spawnPos, EnemyType bulletType = EnemyType.BULLET_1 /* Metadata: 0x0197735D */) {} // 0x0000000186A1FEC0-0x0000000186A1FEF0
		public Vector2 GetBossyPosition(VampireSurvivors.Objects.Characters.CharacterController player = null) => default; // 0x0000000186A1FEF0-0x0000000186A204D0
		public void SpawnMerchant() {} // 0x0000000186A204D0-0x0000000186A20710
		public PickupCustomMerchant SpawnStaticCustomMerchant(VampireSurvivors.Data.CharacterType merchantType, Vector2 spawnPos) => default; // 0x0000000186A20710-0x0000000186A20AB0
		public void SpawnCustomMerchants(List<VampireSurvivors.Data.CharacterType> merchantTypes) {} // 0x0000000186A20AB0-0x0000000186A20F60
		private bool ShouldWeSeeShadowLayer() => default; // 0x0000000186A20F60-0x0000000186A21280
		public void CheckShadows() {} // 0x0000000186A21280-0x0000000186A212F0
		public void ToggleShadows(bool value) {} // 0x0000000186A212F0-0x0000000186A21C30
		public int SetTreasureLevelFromChance(Treasure treasure) => default; // 0x0000000186A21C30-0x0000000186A21F30
		public void SpawnStaticAdventureMerchant(VampireSurvivors.Data.CharacterType merchantType, float2 spawnPos) {} // 0x0000000186A21F30-0x0000000186A221D0
		private void InitRects() {} // 0x0000000186A221D0-0x0000000186A22990
		private void LogRectInfo(string rectName, Rect rect) {} // 0x0000000186A22990-0x0000000186A22AB0
		private void InitTiledPositions() {} // 0x0000000186A22AB0-0x0000000186A22F20
		private void UpdateRectPositions() {} // 0x0000000186A22F20-0x0000000186A233A0
		private void UpdateRectForPlayer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186A233A0-0x0000000186A23A30
		private void PreloadAssets() {} // 0x0000000186A23A30-0x0000000186A23DC0
		private void UnloadAssets() {} // 0x0000000186A23DC0-0x0000000186A24070
		private void SetupFancyBackground() {} // 0x0000000186A24070-0x0000000186A24800
		private void UpdateTimers() {} // 0x0000000186A24800-0x0000000186A24950
		private void PlayEvents() {} // 0x0000000186A24950-0x0000000186A24AE0
		public bool GetStageDataForMinute(int minute, StageType stageType, out StageData stageData, out JObject stageJsonObject) {
			stageData = default;
			stageJsonObject = default;
			return default;
		} // 0x0000000186A24AE0-0x0000000186A24C80
		public bool GetStageDataForMinute(int minute, StageType stageType, out JObject stageJsonObject) {
			stageJsonObject = default;
			return default;
		} // 0x0000000186A24C80-0x0000000186A24F50
		public void RemoveCharm() {} // 0x0000000186A24F50-0x0000000186A25040
		public void ApplyCharm() {} // 0x0000000186A25040-0x0000000186A25130
		private void UpdateAllData(JObject stageJsonObject) {} // 0x0000000186A25130-0x0000000186A25380
		private int GetCharmForMinute(int minute) => default; // 0x0000000186A25380-0x0000000186A25670
		private void ResetStageDataForUpdate() {} // 0x0000000186A25670-0x0000000186A25910
		private void UpdateMinuteData() {} // 0x0000000186A25910-0x0000000186A25DF0
		private StageData CompressTime(JObject originalData) => default; // 0x0000000186A25DF0-0x0000000186A26EC0
		private void ReleasePool() {} // 0x0000000186A26EC0-0x0000000186A26EF0
		public void UpdateNormalEnemyPoolsOnly(List<EnemyType?> enemies) {} // 0x0000000186A26EF0-0x0000000186A27520
		public void UpdateEnemyPools(List<EnemyType?> enemies, List<EnemyType?> bosses) {} // 0x0000000186A27520-0x0000000186A28020
		public Vector2? GetPickupPositionOutOfSight(float _movementAngle = 45f /* Metadata: 0x0197735F */) => default; // 0x0000000186A28020-0x0000000186A28220
		private void HandleDestructibleSpawning() {} // 0x0000000186A28220-0x0000000186A28460
		public void SpawnChosenDestructiblesInClosestLocations(PropType _propType, int number) {} // 0x0000000186A28460-0x0000000186A284E0
		public void SpawnChosenDestructiblesInClosestLocations(PropType _propType, int number, Vector2 position) {} // 0x0000000186A284E0-0x0000000186A28780
		public void SortByDistance(Vector2 position) {} // 0x0000000180B15170-0x0000000180B15180
		public void SpawnChosenDestructibleInRandomLocation(PropType _propType) {} // 0x0000000186A28780-0x0000000186A28930
		private void SpawnDestructibleInRandomLocation() {} // 0x0000000186A28930-0x0000000186A28960
		public void SpawnChosenDestructibleWallsCheck(PropType _propType, bool force = false /* Metadata: 0x01977363 */) {} // 0x0000000186A28960-0x0000000186A28D60
		private void SpawnChosenDestructibleWallsCheckForPlayer(VampireSurvivors.Objects.Characters.CharacterController player, Rect spawnOuterRect, Rect spawnInnerRect, PropType _propType, bool force) {} // 0x0000000186A28D60-0x0000000186A28EC0
		private void SpawnDestructibleWallsCheck() {} // 0x0000000186A28EC0-0x0000000186A28EF0
		private void SpawnCartInRandomLocation() {} // 0x0000000186A28EF0-0x0000000186A29060
		private VampireSurvivors.Objects.Characters.CharacterController GetRandomCharacter() => default; // 0x0000000186A29060-0x0000000186A293C0
		private void SpawnWindowInRandomLocation() {} // 0x0000000186A293C0-0x0000000186A29570
		public Destructible SpawnPropInRandomLocation(float baseChance, PropType propType, ref List<Vector2> positions) => default; // 0x0000000186A29570-0x0000000186A29730
		public List<Destructible> SpawnPropInAllLocations(PropType propType, ref List<Vector2> positions) => default; // 0x0000000186A29730-0x0000000186A29AC0
		public int ActivateProps(PropType propType, ref List<SuperObject> scripts) => default; // 0x0000000186A29AC0-0x0000000186A29ED0
		private List<Vector2> GetLocationsOutOfSight(List<Vector2> locations, VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x0000000186A29ED0-0x0000000186A2A1C0
		public void SpawnChocenDestructibleOutOfSight(PropType propType, bool force = false /* Metadata: 0x01977364 */, float distance = 0f /* Metadata: 0x01977365 */) {} // 0x0000000186A2A1C0-0x0000000186A2A4E0
		public bool IsCharacterNearYourPlayer(VampireSurvivors.Objects.Characters.CharacterController character) => default; // 0x0000000186A2A4E0-0x0000000186A2A690
		private List<VampireSurvivors.Objects.Characters.CharacterController> GetGroupedPlayersBasedOnDistance() => default; // 0x0000000186A2A690-0x0000000186A2AF40
		private void SpawnDestructibleOutOfSight(bool force = false /* Metadata: 0x01977369 */) {} // 0x0000000186A2AF40-0x0000000186A2AF80
		private void DespawnFarDestructibles(ObjectPool pool) {} // 0x0000000186A2AF80-0x0000000186A2B530
		private void HandleSpawning(bool checkMaxEnemyCount = true /* Metadata: 0x0197736A */) {} // 0x0000000186A2B530-0x0000000186A2B660
		private bool HasReachedMaxEnemies() => default; // 0x0000000186A2B660-0x0000000186A2B680
		private bool SpawnEnemiesInOuterRect() => default; // 0x0000000186A2B680-0x0000000186A2B980
		private bool CanSpawnEnemies() => default; // 0x0000000186A2B980-0x0000000186A2BA80
		private void SpawnEnemiesTiled() {} // 0x0000000186A2BA80-0x0000000186A2BF10
		private void SpawnEnemiesMapped() {} // 0x0000000186A2BF10-0x0000000186A2C370
		private int UpdateCurrentEnemies() => default; // 0x0000000186A2C370-0x0000000186A2C400
		private int GetSpawnData(out int currentEnemies, out float minimumEnemies) {
			currentEnemies = default;
			minimumEnemies = default;
			return default;
		} // 0x0000000186A2C400-0x0000000186A2C590
		private List<EnemyType> GetAllEnabledPools() => default; // 0x0000000186A2C590-0x0000000186A2C7C0
		private void SpawnEnemiesInRandomLocationHorizontal() {} // 0x0000000186A2C7C0-0x0000000186A2CA50
		private void SpawnEnemiesInRandomLocationVertical() {} // 0x0000000186A2CA50-0x0000000186A2CCE0
		public void SwarmCheck() {} // 0x0000000186A2CCE0-0x0000000186A2CD90
		private EnemyController SpawnEnemyUnit(ObjectPool pool, EnemyType enemyType, Vector2 spawnPos, bool asRemote) => default; // 0x0000000186A2CD90-0x0000000186A2CEC0
		public void SpawnBoss() {} // 0x0000000186A2CEC0-0x0000000186A2D2F0
		public void SpawnBatGoblin() {} // 0x0000000186A2D2F0-0x0000000186A2E0C0
		public EnemyController SpawnMadMoonBlinder() => default; // 0x0000000186A2E0C0-0x0000000186A2EC90
		private GameObject SpawnOneUnitInOuterRect(EnemyType poolName, bool checkWalls = false /* Metadata: 0x0197736B */, bool forceSpawn = false /* Metadata: 0x0197736C */) => default; // 0x0000000186A2EC90-0x0000000186A2EDC0
		private bool IsPointWithinOtherPlayerRects(Vector2 point) => default; // 0x0000000186A2EDC0-0x0000000186A2F090
		private GameObject SpawnOneUnitInRandomLocationHorizontal(EnemyType poolName, bool forceSpawn = false /* Metadata: 0x0197736D */) => default; // 0x0000000186A2F090-0x0000000186A2F140
		private Vector2 GetHorizontalSpawnPosition() => default; // 0x0000000186A2F140-0x0000000186A2F290
		private GameObject SpawnOneUnitInRandomLocationVertical(EnemyType poolName, bool forceSpawn = false /* Metadata: 0x0197736E */) => default; // 0x0000000186A2F290-0x0000000186A2F340
		private Vector2 GetVerticalSpawnPosition() => default; // 0x0000000186A2F340-0x0000000186A2F490
		private GameObject SpawnOneUnitOutOfSight(EnemyType poolName) => default; // 0x0000000186A2F490-0x0000000186A2F5C0
		private void SpawnArcanaHolder() {} // 0x0000000186A2F5C0-0x0000000186A2F830
		public Vector2 GetPositionWithinSight(VampireSurvivors.Objects.Characters.CharacterController player, float inPlayerDirectionAngle, float distance = 0f /* Metadata: 0x0197736F */) => default; // 0x0000000186A2F830-0x0000000186A2FB40
		private Vector2 GetPositionOutOfSight(Vector2 playerPos) => default; // 0x0000000186A2FB40-0x0000000186A2FD20
		public Vector2 GetPositionOutOfSight(VampireSurvivors.Objects.Characters.CharacterController player, float inPlayerDirectionAngle, float distance = 0f /* Metadata: 0x01977373 */) => default; // 0x0000000186A2FD20-0x0000000186A300A0
		private void UpdateCulling() {} // 0x0000000186A300A0-0x0000000186A30490
		private bool ShouldDespawnEnemyOutsideRect(EnemyController element) => default; // 0x0000000186A30490-0x0000000186A308B0
		private void OnEnemyKilled(GameplaySignals.RemoveEnemyFromStageSignal signal) {} // 0x0000000186A308B0-0x0000000186A30940
		private void GenerateTilingTileset() {} // 0x0000000186A30940-0x0000000186A30B40
		private void InitTilingTileset() {} // 0x0000000186A30B40-0x0000000186A30F60
		public IEnumerable<Vector2> GetLocationsFromMapObjectLayer(string objectLayerName) => default; // 0x0000000186A30F60-0x0000000186A31590
		private void CalcMinMaxTreasures() {} // 0x0000000186A31590-0x0000000186A31A00
		private void HandleCartsAndPizzas() {} // 0x0000000186A31A00-0x0000000186A32120
		private void CheckPizzas() {} // 0x0000000186A32120-0x0000000186A32500
		private void TriggerPizzaEvent(PizzaCircle pizzaCircle, VampireSurvivors.Objects.Characters.CharacterController triggeringPlayer) {} // 0x0000000186A32500-0x0000000186A327E0
		public void ShowPizzaWarning(PizzaCircle pizzaCircle) {} // 0x0000000186A327E0-0x0000000186A32920
		private void GenerateTilingBackground() {} // 0x0000000186A32920-0x0000000186A32B50
		private void SpawnYellowItems() {} // 0x0000000186A32B50-0x0000000186A331C0
		private void SpawnAdventureMerchants() {} // 0x0000000186A331C0-0x0000000186A33340
		private void SpawnCustomAdventureMerchant(CustomMerchantData customMerchantData) {} // 0x0000000186A33340-0x0000000186A336A0
		private bool CheckCanSpawnAdventureMerchant(CustomMerchantData customMerchantData) => default; // 0x0000000186A336A0-0x0000000186A33A60
		public bool ShouldShowCursor(float2 position) => default; // 0x0000000186A33A60-0x0000000186A33B80
		private PickupCustomMerchant SpawnCustomMerchant(CustomMerchantData customMerchantData) => default; // 0x0000000186A33B80-0x0000000186A33F20
		private bool CheckCanSpawnCustomMerchant(CustomMerchantData customMerchantData) => default; // 0x0000000186A33F20-0x0000000186A34210
		private void ForceRepositionMerchants() {} // 0x0000000186A34210-0x0000000186A34640
		private void PositionAllCustomMerchants(List<PickupCustomMerchant> spawnedMerchants) {} // 0x0000000186A34640-0x0000000186A350E0
		private bool DoesNewPositionOverlapMerchants(List<float2> positionsToAvoid, float2 newPos) => default; // 0x0000000186A350E0-0x0000000186A35290
	}
}
