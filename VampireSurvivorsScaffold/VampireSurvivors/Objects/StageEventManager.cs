/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Scripts.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Cursors;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[UsedImplicitly]
	public class StageEventManager : IInitializable, IDisposable // TypeDefIndex: 15151
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private SignalBus _signalBus; // 0x20
		[Inject]
		private DiContainer _diContainer; // 0x28
		[Inject]
		private DestructibleFactory _destructibleFactory; // 0x30
		private Stage _ourStage; // 0x38
		private Camera _mainCamera; // 0x40
		private ShootingStarsManager _shootingStarsManager; // 0x48
		private ShootingStarsManager2 _shootingStarsManager2; // 0x50
		private static int RandomEventId; // 0x00
		private float _playDiamondGridStartX; // 0x58
		private float _playDiamondGridStartY; // 0x5C
		private List<List<int>> _playDiamondGrid; // 0x60
		[Nullable(new byte[3] {0, 0, 2 })]
		private List<List<EnemyDiamond>> _playDiamondEnemyGrid; // 0x68
		private bool _playDiamondActive; // 0x70
		private float _playDiamondDuration; // 0x74
		private VampireSurvivors.Framework.TimerSystem.Timer _playDiamondDisappearTimer; // 0x78
		private float _playDiamondPlayerAtGridPrevX; // 0x80
		private float _playDiamondPlayerAtGridPrevY; // 0x84
		private bool _stageEventsDisabled; // 0x88
		private bool _isTeleportingToRemotePlayer; // 0x89
		private bool _finishedTeleportingToRemotePlayer; // 0x8A
		private const float DontSpawnIfAbove = 500f; // Metadata: 0x01977415
		public EnemyType? _playDiamond_enemyType; // 0x90
		private List<EventTargetInstace> _eventTargets; // 0x98
	
		// Properties
		public int Spawned { get; set; } // 0x0000000181BA6010-0x0000000181BA6020 0x0000000181BA6020-0x0000000181BA6030
		public bool IsTeleportingToRemotePlayer { get => default; set {} } // 0x000000018272A910-0x000000018272A920 0x000000018272A920-0x000000018272A930
		public bool FinishedTeleportingToRemotePlayer { get => default; set {} } // 0x0000000186A39780-0x0000000186A39790 0x0000000186A39790-0x0000000186A397A0
		private Vector3 PlayerPos { get => default; } // 0x0000000186A397A0-0x0000000186A398D0 
	
		// Nested types
		private enum CardinalTypeEnum // TypeDefIndex: 15109
		{
			Cardinal = 0,
			SubCardinal = 1,
			All = 2
		}
	
		public class EventTargetInstace // TypeDefIndex: 15110
		{
			// Fields
			public int _eventTargetIndex; // 0x10
			public Vector2 _eventTargetPosition; // 0x14
	
			// Constructors
			public EventTargetInstace() {} // Dummy constructor
			public EventTargetInstace(int eventTargetIndex, Vector2 eventTargetPosition) {} // 0x0000000186A503D0-0x0000000186A503E0
		}
	
		// Constructors
		public StageEventManager() {} // 0x0000000186A4F8F0-0x0000000186A4F9B0
	
		// Methods
		public void Initialize() {} // 0x0000000186A398D0-0x0000000186A399D0
		public void Dispose() {} // 0x0000000186A399D0-0x0000000186A39A80
		public virtual void Init(Stage stage) {} // 0x0000000186A39A80-0x0000000186A39EA0
		public void DisableStageEvents() {} // 0x0000000185F20D70-0x0000000185F20D80
		public bool TriggerEvent(VampireSurvivors.Data.Stage.Event stageDataEvent, bool fromTrisection = false /* Metadata: 0x0197737C */) => default; // 0x0000000186A39EA0-0x0000000186A3A390
		public void InternalUpdate() {} // 0x0000000186A3A390-0x0000000186A3AC20
		public void PlaySwarm(float duration, int moreX, EnemyType moreY, float moreZ = 0.9f /* Metadata: 0x0197737D */) {} // 0x0000000186A3AC20-0x0000000186A3AC60
		public void PlayDiamond_RandomPattern(float? duration, int moreX = 0 /* Metadata: 0x01977381 */, EnemyType? moreY = default, float moreZ = 0f /* Metadata: 0x01977384 */) {} // 0x0000000186A3AC60-0x0000000186A3B160
		public void PlayDiamond_RandomPatternClear() {} // 0x0000000186A3B160-0x0000000186A3B450
		public void PlayDiamondConcrete(float? duration, float? moreX = default, float? moreY = default, EnemyType? moreZ = default) {} // 0x0000000186A3B450-0x0000000186A3B700
		private void Cleanup() {} // 0x0000000186A3B700-0x0000000186A3B710
		protected bool TriggerSwitchEvent(StageEventType eventType, float? chance, float? duration, int moreX, object moreY, float moreZ = 0f /* Metadata: 0x01977392 */, bool fromTrisection = false /* Metadata: 0x01977396 */) => default; // 0x0000000186A3B710-0x0000000186A3C750
		private static EnemyType ConvertToEnemyType(object moreY, EnemyType defaultEnemyType) => default; // 0x0000000186A3C750-0x0000000186A3C870
		public int GetRandomId() => default; // 0x0000000186A3C870-0x0000000186A3C8C0
		private void GenerateBoss(EnemyType enemyType = EnemyType.BATSWARM /* Metadata: 0x01977397 */) {} // 0x0000000186A3C8C0-0x0000000186A3CB80
		private void GenerateEnemySwarm(float duration, int count, EnemyType enemyType = EnemyType.BATSWARM /* Metadata: 0x01977398 */, float moreZ = 0.9f /* Metadata: 0x01977399 */, float rndDiv = 500f /* Metadata: 0x0197739D */) {} // 0x0000000186A3CB80-0x0000000186A3D150
		private void GenerateEnemyWall(float duration, int count = 100 /* Metadata: 0x019773A1 */, EnemyType enemyType = EnemyType.FLOWER /* Metadata: 0x019773A3 */, float moreZ = 0.9f /* Metadata: 0x019773A4 */, float radiusMul = 0.8f /* Metadata: 0x019773A8 */, float rndDiv = 50f /* Metadata: 0x019773AC */) {} // 0x0000000186A3D150-0x0000000186A3D7A0
		private void GenerateEnemyCardinalSpawn(float duration, CardinalTypeEnum cardinalType = CardinalTypeEnum.Cardinal /* Metadata: 0x019773B0 */, EnemyType enemyType = EnemyType.BATSWARM /* Metadata: 0x019773B1 */, float moreZ = 0.9f /* Metadata: 0x019773B2 */, float rndDiv = 500f /* Metadata: 0x019773B6 */) {} // 0x0000000186A3D7A0-0x0000000186A3DBE0
		private void SpawnCardinalDirections(List<float2> directions, EnemyType enemyType, float rndDiv = 500f /* Metadata: 0x019773BA */) {} // 0x0000000186A3DBE0-0x0000000186A3DE40
		public void PlayCircle(float? duration, int moreX = 100 /* Metadata: 0x019773BE */, EnemyType moreY = EnemyType.FLOWER /* Metadata: 0x019773C0 */, float moreZ = 0.9f /* Metadata: 0x019773C1 */) {} // 0x0000000186A3DE40-0x0000000186A3DF20
		private void PlayJellyfish(float? duration, int moreX = 80 /* Metadata: 0x019773C5 */, EnemyType moreY = EnemyType.JELLYFISH /* Metadata: 0x019773C7 */) {} // 0x0000000186A3DF20-0x0000000186A3E000
		private void PlayBatSwarm(float? duration) {} // 0x0000000186A3E000-0x0000000186A3E0C0
		private void PlayGhostSwarm(float? duration) {} // 0x0000000186A3E0C0-0x0000000186A3E180
		public void PlayMedusaSwarm(float? duration, int moreX = 1 /* Metadata: 0x019773C9 */, EnemyType enemyType = EnemyType.MEDUSA1 /* Metadata: 0x019773CA */) {} // 0x0000000186A3E180-0x0000000186A3E720
		private void PlayVerticalSwarm(float? duration, int moreX = 1 /* Metadata: 0x019773CB */, EnemyType enemyType = EnemyType.XLSWORDIAN_V /* Metadata: 0x019773CC */) {} // 0x0000000186A3E720-0x0000000186A3EC70
		private void PlayMedusaWall(float? duration, int moreX = 1 /* Metadata: 0x019773CE */, EnemyType enemyType = EnemyType.MEDUSA1 /* Metadata: 0x019773CF */) {} // 0x0000000186A3EC70-0x0000000186A3F1C0
		private void PlaySkullSwarm(float? duration, int moreX = 1 /* Metadata: 0x019773D0 */, EnemyType moreY = EnemyType.SKULL2_SWARM /* Metadata: 0x019773D1 */) {} // 0x0000000186A3F1C0-0x0000000186A3F290
		private void PlayPileAssault(float? duration, int moreX = 50 /* Metadata: 0x019773D2 */, EnemyType enemyType = EnemyType.PILE1 /* Metadata: 0x019773D3 */, float moreZ = 0.7f /* Metadata: 0x019773D5 */) {} // 0x0000000186A3F290-0x0000000186A3F950
		private void PlayMinoRush(float? duration, int moreX = 50 /* Metadata: 0x019773D9 */) {} // 0x0000000186A3F950-0x0000000186A3FA20
		private void PlayJellySwarm(float? duration, int moreX = 50 /* Metadata: 0x019773DA */) {} // 0x0000000186A3FA20-0x0000000186A3FAF0
		private void PlayEctoSwarm(float? duration, int moreX = 50 /* Metadata: 0x019773DB */) {} // 0x0000000186A3FAF0-0x0000000186A3FBC0
		private void PlayGenericBoss(object moreY) {} // 0x0000000186A3FBC0-0x0000000186A3FBF0
		private void PlayGenericSwarm(float? duration, int moreX, object moreY) {} // 0x0000000186A3FBF0-0x0000000186A3FCF0
		private void PlayGenericCardinalSpawn(float? duration, int moreX, object moreY) {} // 0x0000000186A3FCF0-0x0000000186A3FE10
		private void PlayDragonStream(float? duration, int moreX = 12 /* Metadata: 0x019773DC */, EnemyType moreY = EnemyType.XLDRAGON1_FLAG /* Metadata: 0x019773DD */, float moreZ = 4f /* Metadata: 0x019773DF */) {} // 0x0000000186A3FE10-0x0000000186A403B0
		private void PlaySkeleStream(float? duration, int moreX = 12 /* Metadata: 0x019773E3 */, EnemyType moreY = EnemyType.XLDRAGON3_FLAG /* Metadata: 0x019773E4 */, float moreZ = 4f /* Metadata: 0x019773E6 */) {} // 0x0000000186A403B0-0x0000000186A40960
		private void PlaySkullPilePile(float? duration, int moreX = 1 /* Metadata: 0x019773EA */, EnemyType moreY = EnemyType.PILE4_SCALED /* Metadata: 0x019773EB */, float moreZ = 12f /* Metadata: 0x019773EC */) {} // 0x0000000186A40960-0x0000000186A40FB0
		private void PlayPolterRoulette(float? duration, int moreX = 50 /* Metadata: 0x019773F0 */, EnemyType moreY = EnemyType.POLTER_DEST /* Metadata: 0x019773F1 */, float moreZ = 1f /* Metadata: 0x019773F3 */) {} // 0x0000000186A40FB0-0x0000000186A41890
		private void PlayImpSwarm(float? duration, int moreX = 50 /* Metadata: 0x019773F7 */) {} // 0x0000000186A41890-0x0000000186A41960
		private void PlaySkeletonSwarm(float? duration, int moreX = 50 /* Metadata: 0x019773F8 */, EnemyType moreY = EnemyType.BATSWARM /* Metadata: 0x019773F9 */) {} // 0x0000000186A41960-0x0000000186A41A30
		private void PlayShadeBomb(float? duration, int moreX = 1 /* Metadata: 0x019773FA */, EnemyType moreY = EnemyType.SHADERED /* Metadata: 0x019773FB */) {} // 0x0000000186A41A30-0x0000000186A42120
		private void ShootStars(int moreX, object moreY, float moreZ) {} // 0x0000000186A42120-0x0000000186A42350
		private void ShootStars2(int moreX, object moreY, float moreZ) {} // 0x0000000186A42350-0x0000000186A42580
		private void SummonTimedEnemy(float? duration, int moreX, EnemyType enemyType) {} // 0x0000000186A42580-0x0000000186A42B00
		private void PlayStalker(float? duration, int moreX = 1 /* Metadata: 0x019773FC */) {} // 0x0000000186A42B00-0x0000000186A43080
		private void PlaySleeper(float? duration, int moreX = 1 /* Metadata: 0x019773FD */) {} // 0x0000000186A43080-0x0000000186A435F0
		private void PlayDrowner(float? duration, bool fromTrisection = false /* Metadata: 0x019773FE */) {} // 0x0000000186A435F0-0x0000000186A43A70
		private void PlayEraseEnemies() {} // 0x0000000186A43A70-0x0000000186A44140
		private void PlayCycleComplete() {} // 0x0000000186A44140-0x0000000186A441D0
		private void SpawnInSteps(float? duration, int moreX = 24 /* Metadata: 0x019773FF */, EnemyType moreY = EnemyType.EX_AXE_BAT3 /* Metadata: 0x01977400 */, float moreZ = 0.9f /* Metadata: 0x01977402 */) {} // 0x0000000186A441D0-0x0000000186A44680
		private void PlayDiamondSquare(float? duration, int moreX = 1 /* Metadata: 0x01977406 */, EnemyType? moreY = default, float moreZ = 0f /* Metadata: 0x01977409 */) {} // 0x0000000186A44680-0x0000000186A44A10
		private void PlayDiamondRoad(float? duration, int moreX = 1 /* Metadata: 0x0197740D */, EnemyType? moreY = default, float moreZ = 0f /* Metadata: 0x01977410 */) {} // 0x0000000186A44A10-0x0000000186A44D60
		public List<EventTargetInstace> GetCurrentEventTargets() => default; // 0x0000000181971630-0x0000000181971640
		private void SabotagionEME(float? duration, int moreX, object moreY, float moreZ) {} // 0x0000000186A44D60-0x0000000186A44F00
		private void Sabotagion(float? duration, int moreX, object moreY, float moreZ) {} // 0x0000000186A44F00-0x0000000186A45110
		private int GetTargetLocation(out Vector2 targetLocation) {
			targetLocation = default;
			return default;
		} // 0x0000000186A45110-0x0000000186A451E0
		private void Sabotage_PickleRush(float? duration, int moreX, object moreY, float moreZ) {} // 0x0000000186A451E0-0x0000000186A45420
		private int ChooseEventTargetIndex(List<Vector2> eventTargets) => default; // 0x0000000186A45420-0x0000000186A45720
		public void StartSabotagion(float duration, int chosenEventTarget, Vector2 targetLocation, string newsFeed, bool isPickleRush) {} // 0x0000000186A45720-0x0000000186A45890
		[IteratorStateMachine(typeof(__SabotageWithCallbacks_d__98))]
		private IEnumerator _SabotageWithCallbacks(float duration, int chosenEventTarget, Vector2 targetLocation, int moreX, object moreY, float moreZ, Action<Vector2> onSuccess, Action onFailure) => default; // 0x0000000186A45890-0x0000000186A45A90
		private void OnSabotagionSuccess(Vector2 targetLocation) {} // 0x0000000186A45A90-0x0000000186A46160
		private void OnSabotagionFailure() {} // 0x0000000186A46160-0x0000000186A46960
		private void SpawnLava() {} // 0x0000000186A46960-0x0000000186A47BE0
		private void OnSabotage_PickleRushFailure() {} // 0x0000000186A47BE0-0x0000000186A47E70
		private int ChooseEMEEventTargetIndex(List<Vector2> eventTargets) => default; // 0x0000000186A47E70-0x0000000186A48170
		[IteratorStateMachine(typeof(__SabotageEMEWithCallbacks_d__104))]
		private IEnumerator _SabotageEMEWithCallbacks(float duration, int moreX, object moreY, float moreZ, Action<Vector2> onSuccess, Action onFailure) => default; // 0x0000000186A48170-0x0000000186A48340
		private void OnSabotagionEMESuccess(Vector2 targetLocation) {} // 0x0000000186A48340-0x0000000186A48A10
		private void OnSabotagionEMEFailure() {} // 0x0000000186A48A10-0x0000000186A48CA0
		private void FB_BigFuzz_Pointer(float? duration, int moreX, object moreY, float moreZ) {} // 0x0000000186A48CA0-0x0000000186A48F50
		[IteratorStateMachine(typeof(__FB_BigFuzz_Pointer_d__108))]
		private IEnumerator _FB_BigFuzz_Pointer(float duration, int moreX, object moreY, float moreZ, Action<Vector2> onSuccess, Action onFailure) => default; // 0x0000000186A48F50-0x0000000186A49120
		private void SpawnCircleWave(EnemyType enemyType, int eventID, int durationMillis = -1 /* Metadata: 0x01977414 */) {} // 0x0000000186A49120-0x0000000186A49710
		private static void InitEventEnemy(int eventID, EnemyController enemy, List<EnemyController> enemies) {} // 0x0000000186A49710-0x0000000186A49820
		private void FB_Capsule_Event() {} // 0x0000000186A49820-0x0000000186A49A70
		private void fnRosary() {} // 0x0000000186A49A70-0x0000000186A49CA0
		public void fnPet() {} // 0x0000000186A49CA0-0x0000000186A49D10
		public void fnPetPlayer(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186A49D10-0x0000000186A49DD0
		public void fnChicken() {} // 0x0000000186A49DD0-0x0000000186A4A110
		private void fnGoldFever() {} // 0x0000000186A4A110-0x0000000186A4A5D0
		private void fnPassive() {} // 0x0000000186A4A5D0-0x0000000186A4AE40
		private void fnLights() {} // 0x0000000186A4AE40-0x0000000186A4AEB0
		private void fnNduja() {} // 0x0000000186A4AEB0-0x0000000186A4B190
		private void fnClover() {} // 0x0000000186A4B190-0x0000000186A4B5E0
		private void fnSkull() {} // 0x0000000180B15170-0x0000000180B15180
		private void fnUltraWave() {} // 0x0000000186A4B5E0-0x0000000186A4B730
		private void fnSummonMolise() {} // 0x0000000186A4B730-0x0000000186A4BC40
		private void fnSummonNight() {} // 0x0000000186A4BC40-0x0000000186A4C110
		private void fnMinuteOfPanic() {} // 0x0000000186A4C110-0x0000000186A4C520
		private void fnCandybox() {} // 0x0000000186A4C520-0x0000000186A4C7E0
		private void fnHighGravity(float? duration) {} // 0x0000000180B15170-0x0000000180B15180
		private void fnCrabFest() {} // 0x0000000186A4C7E0-0x0000000186A4CAB0
		private void fnRemoveWalls() {} // 0x0000000180B15170-0x0000000180B15180
		private void fnInvaders(float? duration, int moreX, object moreY, float moreZ) {} // 0x0000000186A4CAB0-0x0000000186A4CF30
		private void DebugAddConsoleCommands() {} // 0x0000000186A4CF30-0x0000000186A4F8F0
	}
}
