/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using Coherence.Toolkit.Bindings.TransformBindings;
using DG.Tweening;
using Newtonsoft.Json.Linq;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemyController : BasePoolableSpriteBehaviour, IDamageable // TypeDefIndex: 17163
	{
		// Fields
		private const uint DefangTint = 4521864; // Metadata: 0x01978148
		[FormerlySerializedAs("_enemyRenderer")]
		[SerializeField]
		protected SpriteRenderer _EnemyRenderer; // 0x68
		[FormerlySerializedAs("_alertSpriteRenderer")]
		[SerializeField]
		protected SpriteRenderer _AlertSpriteRenderer; // 0x70
		[FormerlySerializedAs("_spriteAnimation")]
		[SerializeField]
		protected SpriteAnimation _SpriteAnimation; // 0x78
		protected SignalBus _signalBus; // 0x80
		protected Transform _cachedTransform; // 0x88
		protected GameSessionData _gameSessionData; // 0x90
		protected GameManager _gameManager; // 0x98
		protected DataManager _dataManager; // 0xA0
		private JObject _currentJsonData; // 0xA8
		protected EnemyData _currentEnemyData; // 0xB0
		protected bool _hasInitializedData; // 0xB8
		protected PlayerOptions _playerOptions; // 0xC0
		protected CoherenceSync _coherenceSync; // 0xC8
		private PositionBinding _positionBinding; // 0xD0
		protected Unity.Mathematics.Random _deathRng; // 0xD8
		protected EnemyDeathStyle _deathStyle; // 0xDC
		protected uint _deathSeed; // 0xE0
		private Vector2 _networkErrorVector; // 0xE4
		private Vector2 _errorVelocity; // 0xEC
		private Transform _targetTransform; // 0xF8
		protected bool _receivingDamage; // 0x100
		private bool _passThroughWalls; // 0x101
		protected Treasure _treasure; // 0x108
		protected bool _selfDestruct; // 0x110
		protected bool _isSelfDestructionTriggered; // 0x111
		private float _startingAngle; // 0x114
		protected DG.Tweening.Sequence _alertTween; // 0x118
		protected uint _saveTint; // 0x120
		public bool _hasATreasure; // 0x124
		protected Transform _enemyRendererTransform; // 0x128
		private float _wiggleProgress; // 0x130
		private bool _wiggleForward; // 0x134
		private bool _wiggleInit; // 0x135
		private readonly Quaternion _wiggleStartRot; // 0x138
		private readonly Quaternion _wiggleEndRot; // 0x148
		protected VampireSurvivors.Framework.TimerSystem.Timer _selfDestructTimer; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _pushbackTimer; // 0x160
		private VampireSurvivors.Framework.TimerSystem.Timer _freezeTimer; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _slowedTimer; // 0x170
		protected VampireSurvivors.Framework.TimerSystem.Timer _blinkTimeout; // 0x178
		protected Vector2 _spritePivot; // 0x180
		protected bool _canBeDamagedByBloodline; // 0x188
		protected VampireSurvivors.Framework.TimerSystem.Timer _divineBloodlineDamageTimer; // 0x190
		protected bool _allowAnimationPauseResume; // 0x198
		protected EnemyType _enemyType; // 0x19C
		protected float _damageKb; // 0x1A0
		protected float _defaultSpeed; // 0x1A4
		protected float _scaleMul; // 0x1A8
		protected bool _hpXLevel; // 0x1AC
		private bool _fixedDirection; // 0x1AD
		protected bool _medusa; // 0x1AE
		protected float _medusaElapsed; // 0x1B0
		protected GameObject _owner; // 0x1B8
		private float _alpha; // 0x1C0
		protected string _defaultName; // 0x1C8
		protected float _damageWeakness; // 0x1D0
		protected float _maxDamageWeakness; // 0x1D4
		private int _multiplayerCorpseFeedingCounter; // 0x1D8
		protected bool _isImmuneToModification; // 0x1DC
		protected Vector2 _currentDirection; // 0x1E0
		protected float _hp; // 0x1E8
		protected float _maxHp; // 0x1EC
		private static readonly int ApplyTintFill; // 0x00
		private static readonly int TintFillColor; // 0x04
		public const string ANIM_IDLE = "idle"; // Metadata: 0x0197814C
		public const string ANIM_DIE = "die"; // Metadata: 0x01978151
		[NonSerialized]
		public float Distance; // 0x1F0
		private VampireSurvivors.Framework.TimerSystem.Timer DefangTimer; // 0x258
		private const float _defaultCorrectionFactor = 0.85f; // Metadata: 0x01978155
		public static WeaponType[] FireDamageTypes; // 0x08
		private static readonly ProfilerMarker MarkerInitEnemy; // 0x10
		private static readonly ProfilerMarker MarkerDespawn; // 0x18
		private static readonly ProfilerMarker MarkerInitialiseLocalData; // 0x20
		private static readonly ProfilerMarker MarkerOnRecycleEnemy; // 0x28
		private static readonly ProfilerMarker MarkerSetEnemySpriteAndAnimations; // 0x30
		private static ProfilerMarker updateDepthMarker; // 0x38
		private int currentDepthEnemy; // 0x264
		private int currentDepthAlert; // 0x268
		private static ProfilerMarker setTintFillMarker; // 0x40
	
		// Properties
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public int SyncedEnemyType { get => default; set {} } // 0x00000001851325D0-0x00000001851325E0 0x000000018718A8A0-0x000000018718A8B0
		[Sync]
		public byte SyncedDeathStyle { get => default; set {} } // 0x0000000184EB8690-0x0000000184EB86A0 0x0000000184EB86A0-0x0000000184EB86B0
		public EnemyDeathStyle DeathStyle { get => default; } // 0x0000000184EB8690-0x0000000184EB86A0 
		[Sync]
		public Transform TargetTransform { get => default; set {} } // 0x0000000181945E90-0x0000000181945EA0 0x0000000180B3E800-0x0000000180B3E860
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public GameObject Owner { get => default; set {} } // 0x0000000182766A60-0x0000000182766A70 0x000000018718A8B0-0x000000018718A8D0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint DeathSeed { get => default; set {} } // 0x0000000181E31910-0x0000000181E31920 0x0000000181E31920-0x0000000181E31930
		public bool KilledByAuthority { get; set; } // 0x000000018289FD40-0x000000018289FD50 0x0000000184EC0B20-0x0000000184EC0B30
		public float AttackPower { get => default; } // 0x000000018718A8D0-0x000000018718A960 
		public float Speed { get; set; } // 0x000000018718A960-0x000000018718A970 0x000000018718A970-0x000000018718A980
		public float DefaultSpeed { get => default; } // 0x000000018718A980-0x000000018718A990 
		private Vector2 CurrentPos { get => default; } // 0x000000018718A990-0x000000018718AA60 
		public Vector2 Velocity { get => default; } // 0x0000000186E56630-0x0000000186E56660 
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool IsTeleportOnCull { get; set; } // 0x0000000185FA2570-0x0000000185FA2580 0x0000000186ED28A0-0x0000000186ED28B0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public bool IsBoss { get; set; } // 0x0000000186ED28B0-0x0000000186ED28C0 0x0000000186ED28C0-0x0000000186ED28D0
		public bool DontTeleportOnFreeRoam { get; set; } // 0x000000018718AA60-0x000000018718AA70 0x000000018718AA70-0x000000018718AA80
		public float ScaleMul { get => default; } // 0x000000018718AA80-0x000000018718AA90 
		public bool IgnoreNetworkError { get; set; } // 0x000000018718AA90-0x000000018718AAA0 0x000000018718AAA0-0x000000018718AAB0
		public Tween ScaleTween { get; set; } // 0x00000001858341D0-0x00000001858341E0 0x0000000186753320-0x0000000186753380
		public bool CannotBeFollower { get => default; set {} } // 0x000000018718AAB0-0x000000018718AAE0 0x000000018718AAE0-0x000000018718AB10
		public bool IsCullable { get; set; } // 0x000000018718AB10-0x000000018718AB20 0x000000018718AB20-0x000000018718AB30
		public bool IsStatic { get; set; } // 0x000000018718AB30-0x000000018718AB40 0x000000018718AB40-0x000000018718AB50
		public float FeverValue { get => default; set {} } // 0x000000018718AB50-0x000000018718AB90 0x000000018718AB90-0x000000018718ABC0
		public Vector3 CurrentDirection { get => default; protected set {} } // 0x000000018718ABC0-0x000000018718ABF0 0x000000018718ABF0-0x000000018718AC20
		public bool FixedDirection { get => default; } // 0x000000018718AC20-0x000000018718AC30 
		public float? ResRosary { get; private set; } // 0x000000018718AC30-0x000000018718AC40 0x000000018718AC40-0x000000018718AC50
		public float? ResDebuffs { get; private set; } // 0x000000018718AC50-0x000000018718AC60 0x000000018718AC60-0x000000018718AC70
		public float? ResCorridor { get; private set; } // 0x000000018718AC70-0x000000018718AC80 0x000000018718AC80-0x000000018718AC90
		public float? ResFreeze { get; set; } // 0x000000018718AC90-0x000000018718ACA0 0x000000018718ACA0-0x000000018718ACB0
		public float? ResDefang { get; set; } // 0x000000018718ACB0-0x000000018718ACC0 0x000000018718ACC0-0x000000018718ACD0
		public float WeakFire { get; private set; } // 0x000000018718ACD0-0x000000018718ACE0 0x000000018718ACE0-0x000000018718ACF0
		public SpriteRenderer EnemyRenderer { get => default; } // 0x00000001819A0210-0x00000001819A0220 
		public SpriteRenderer AlertSpriteRenderer { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public float Slow { get; set; } // 0x000000018718ACF0-0x000000018718AD00 0x000000018718AD00-0x000000018718AD10
		public bool IsPatrolling { get; set; } // 0x000000018718AD10-0x000000018718AD20 0x000000018718AD20-0x000000018718AD30
		public float KnockBack { get; set; } // 0x0000000186753590-0x00000001867535A0 0x00000001867535A0-0x00000001867535B0
		public EnemyData CurrentEnemyData { get => default; } // 0x00000001819A0190-0x00000001819A01A0 
		public bool IsDefanged { get; private set; } // 0x00000001867535B0-0x00000001867535C0 0x00000001867535C0-0x00000001867535D0
		public bool IsTimeStopped { get; private set; } // 0x000000018718AD30-0x000000018718AD40 0x000000018718AD40-0x000000018718AD50
		public bool IsTimeSlowed { get; private set; } // 0x000000018718AD50-0x000000018718AD60 0x000000018718AD60-0x000000018718AD70
		protected Camera MainCamera { get => default; } // 0x000000018678FD00-0x000000018678FD10 
		public float SelfDestDistance { get; set; } // 0x000000018718AD70-0x000000018718AD80 0x000000018718AD80-0x000000018718AD90
		public SpriteAnimation SpriteAnimation { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public SpriteAnimation anims { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public EnemyType EnemyType { get => default; } // 0x00000001851325D0-0x00000001851325E0 
		public int StageEventId { get; set; } // 0x000000018718AD90-0x000000018718ADA0 0x000000018718ADA0-0x000000018718ADB0
		public bool ConditionalCanMove { get; set; } // 0x000000018718ADB0-0x000000018718ADC0 0x000000018718ADC0-0x000000018718ADD0
		public bool IgnoreMovementFreezeFromTimeStop { get; set; } // 0x000000018718ADD0-0x000000018718ADE0 0x000000018718ADE0-0x000000018718ADF0
		public CoherenceSync Sync { get => default; } // 0x00000001827666D0-0x00000001827666E0 
		public float Hp { get => default; set {} } // 0x000000018718ADF0-0x000000018718AE00 0x000000018718AE00-0x000000018718AE10
		public bool IsDead { get; set; } // 0x0000000185FA1F50-0x0000000185FA1F60 0x000000018718AE10-0x000000018718AE20
		public float NormalizedHp { get => default; } // 0x000000018718AE20-0x000000018718AE40 
		public float DamageWeakness { get => default; set {} } // 0x000000018718AE40-0x000000018718AE50 0x000000018718AE50-0x000000018718AE60
		public float MaxDamageWeakness { get => default; set {} } // 0x000000018718AE60-0x000000018718AE70 0x000000018718AE70-0x000000018718AE80
	
		// Constructors
		public EnemyController() {} // 0x0000000187193D20-0x0000000187193FB0
		static EnemyController() {} // 0x0000000187193FB0-0x00000001871942B0
	
		// Methods
		protected virtual void FakeConstruct() {} // 0x000000018718AE80-0x000000018718B120
		protected virtual new void Awake() {} // 0x000000018718B120-0x000000018718B3D0
		protected override void OnEnable() {} // 0x000000018718B3D0-0x000000018718B400
		protected virtual void Start() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnDestroy() {} // 0x000000018718B400-0x000000018718B4A0
		protected virtual void OnDrawGizmosSelected() {} // 0x000000018718B4A0-0x000000018718B6B0
		public virtual void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018718B6B0-0x000000018718BB10
		protected virtual void UpdateBaseHealth() {} // 0x000000018718BB10-0x000000018718BBB0
		protected virtual bool CanUseAbility() => default; // 0x000000018718BBB0-0x000000018718BC70
		public void SetTargetTransform(Transform target) {} // 0x0000000180B3E800-0x0000000180B3E860
		public virtual void SetOwner(GameObject owner) {} // 0x0000000182766A70-0x0000000182766AD0
		public virtual void OnTeleportOnCull() {} // 0x000000018718BC70-0x000000018718BE90
		public virtual bool CanEnemyTeleport() => default; // 0x0000000181958370-0x0000000181958380
		public void AttachTreasure(Treasure treasure) {} // 0x000000018718BE90-0x000000018718BF00
		public virtual void Disappear() {} // 0x000000018718BF00-0x000000018718BF80
		public virtual void Despawn() {} // 0x000000018718BF80-0x000000018718C260
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void FeedOnPlayer() {} // 0x000000018718C260-0x000000018718C560
		public bool IsPlayingDeathAnimation() => default; // 0x000000018718C560-0x000000018718C610
		public bool WouldEat() => default; // 0x000000018718C610-0x000000018718C680
		public bool IsBossEnemy() => default; // 0x000000018718C680-0x000000018718C6F0
		public bool IsBullet() => default; // 0x000000018718C6F0-0x000000018718C720
		public bool IsFlying() => default; // 0x000000018718C720-0x000000018718C750
		public virtual void OnPlayerOverlap(CharacterController player) {} // 0x000000018718C750-0x000000018718CC20
		public virtual void SetFlipX(bool flip) {} // 0x000000018718CC20-0x000000018718CC40
		public bool IsValid() => default; // 0x000000018718CC40-0x000000018718CC60
		public override SpriteRenderer GetAttachedRenderer() => default; // 0x00000001819A0210-0x00000001819A0220
		public void InitialiseLocalData(EnemyType enemyType) {} // 0x000000018718CC60-0x000000018718D170
		protected override void OnUpdate() {} // 0x000000018718D170-0x000000018718DE30
		private static float GetCorrectionFactor() => default; // 0x000000018718DE30-0x000000018718DF30
		protected void RetargetIfNecessary() {} // 0x000000018718DF30-0x000000018718E040
		public void TargetClosestPlayer() {} // 0x000000018718E040-0x000000018718E130
		protected virtual void CalculateCurrentDirection() {} // 0x000000018718E130-0x000000018718E330
		protected virtual void CalculateDirectionAndVelocity() {} // 0x000000018718E330-0x000000018718E430
		public bool Freeze(float duration, float chance = 1f /* Metadata: 0x01978115 */) => default; // 0x000000018718E430-0x000000018718E680
		public bool Freeze_WithoutTint(float duration, float chance = 1f /* Metadata: 0x01978119 */) => default; // 0x000000018718E680-0x000000018718E890
		public void TimeStop(bool ignoreMovementFreezeFromTimeStop = false /* Metadata: 0x0197811D */) {} // 0x000000018718E890-0x000000018718E990
		public void ResumeFromTimeStop() {} // 0x000000018718E990-0x000000018718EA00
		public bool SlowEnemy(float duration, float chance = 1f /* Metadata: 0x0197811E */, float slowAmount = 0.5f /* Metadata: 0x01978122 */) => default; // 0x000000018718EA00-0x000000018718EBC0
		public void ResumeFromSlow() {} // 0x000000018718EBC0-0x000000018718EBE0
		public virtual void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978126 */, float damageKb = 1f /* Metadata: 0x01978127 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197812B */, bool hasKb = true /* Metadata: 0x0197812C */) {} // 0x000000018718EBE0-0x000000018718F030
		public virtual void GetDamagedSpecial(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197812D */, float damageKb = 1f /* Metadata: 0x0197812E */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978132 */, bool hasKb = true /* Metadata: 0x01978133 */, Vector3? damagePosition = default) {} // 0x000000018718F030-0x000000018718F3B0
		public void PlayVFXFlash(HitVfxType showHitVfx) {} // 0x000000018718F3B0-0x000000018718F600
		public virtual void OnGetDamaged(HitVfxType showHitVfx, bool hasKb = true /* Metadata: 0x01978134 */) {} // 0x000000018718F600-0x000000018718F630
		public bool IsUnitDead() => default; // 0x0000000185FA1F50-0x0000000185FA1F60
		public float MaxHp() => default; // 0x000000018718F630-0x000000018718F640
		public float CurrentHealth() => default; // 0x000000018718ADF0-0x000000018718AE00
		public void ChangeMaxHealth(float maxHP) {} // 0x000000018718F640-0x000000018718F670
		public void RandomizeCurrentHp(float min = 0.1f /* Metadata: 0x01978135 */) {} // 0x000000018718F670-0x000000018718F6A0
		public void SetHealth(float health) {} // 0x000000018718F6A0-0x000000018718F6E0
		public void Kill() {} // 0x000000018718F6E0-0x000000018718F720
		public virtual void OnMusicBeat() {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnRecycleEnemy() {} // 0x000000018718F720-0x00000001871901E0
		protected virtual void InitWiggle() {} // 0x00000001871901E0-0x0000000187190310
		protected virtual void ProcessWiggle() {} // 0x0000000187190310-0x0000000187190620
		protected void FireKilledSignal() {} // 0x0000000187190620-0x0000000187190780
		protected void OnSelfDestruct() {} // 0x0000000187190780-0x0000000187190950
		private void UpdateScale() {} // 0x0000000187190950-0x0000000187190A60
		private void UpdateAlpha() {} // 0x0000000187190A60-0x0000000187190C00
		private void DetectMisprediction(object sampleData, bool stopped, long simulationFrame) {} // 0x0000000187190C00-0x0000000187190E00
		private void SnapPosition(Vector3 networkPosition) {} // 0x0000000187190E00-0x0000000187190EB0
		protected void DealDamage(float damage) {} // 0x0000000187190EB0-0x0000000187190EF0
		private void InitLayer() {} // 0x0000000187190EF0-0x0000000187190F70
		private void InitSkills() {} // 0x0000000187190F70-0x0000000187191220
		private bool GetEnemyDataForCurrentLevel(int level) => default; // 0x0000000187191220-0x00000001871918F0
		protected static void PlayHitSfx() {} // 0x00000001871918F0-0x0000000187191A10
		protected virtual void Die() {} // 0x0000000187191A10-0x0000000187191C90
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x0000000187191C90-0x0000000187192370
		public void GiveFullReward(Action<Pickup> onRewardGiven = null) {} // 0x0000000187192370-0x0000000187192A10
		protected virtual void SetEnemySpriteAndAnimations() {} // 0x0000000187192A10-0x0000000187192FB0
		protected virtual void UpdateDepth() {} // 0x0000000187192FB0-0x0000000187193050
		private void PauseAnimations() {} // 0x0000000187193050-0x0000000187193090
		private void ResumeAnimations() {} // 0x0000000187193090-0x00000001871930D0
		protected void PlayDeathAnimation() {} // 0x00000001871930D0-0x00000001871932D0
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void OnlineKill() {} // 0x000000018718F6E0-0x000000018718F720
		protected virtual void OnDeathAnimationComplete() {} // 0x00000001871932D0-0x0000000187193400
		private void ResumeFromFreeze() {} // 0x000000018718E990-0x000000018718EA00
		public bool DoDefang(float duration = -1f /* Metadata: 0x01978139 */, uint defangColorTint = 4521864 /* Metadata: 0x0197813D */, bool stopAnimation = false /* Metadata: 0x01978141 */) => default; // 0x0000000187193400-0x00000001871936C0
		public void ResumeFromDefang(uint fakeFreezeDisplay = 4521864 /* Metadata: 0x01978142 */, bool stopAnimation = false /* Metadata: 0x01978146 */) {} // 0x00000001871936C0-0x0000000187193720
		protected void SetTintFill(bool isEnabled, HitVfxType? hitVfxType = default) {} // 0x0000000187193720-0x00000001871938E0
		private void RestoreTint() {} // 0x00000001871938E0-0x00000001871939F0
		public void ForceDefaultTint() {} // 0x00000001871939F0-0x0000000187193AD0
		public void ForceTint(uint tintValue, bool isTintFill = false /* Metadata: 0x01978147 */) {} // 0x0000000187193AD0-0x0000000187193B50
		protected virtual void FireEnemyAsBullet(Vector2 spawnPos, EnemyType bulletType) {} // 0x0000000187193B50-0x0000000187193C90
		protected Vector2 SetVelocityFromRotation(float rotation, float speed) => default; // 0x0000000187193C90-0x0000000187193D10
		public void ReloadCurrentData() {} // 0x0000000187193D10-0x0000000187193D20
	}
}
