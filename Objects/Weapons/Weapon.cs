using Coherence.Core;
using Newtonsoft.Json.Linq;
using Rewired.Demos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivorsDecompProject.Objects.Pools;
using VampireSurvivorsDecompProject.Objects.Projectiles;
using static Coherence.Core.NativeTransport;
using static UnityEngine.ParticleSystem;
using CharacterController = VampireSurvivors.Objects.Characters.CharacterController;

namespace VampireSurvivorsDecompProject.Objects.Weapons
{
	public class Weapon : Equipment
	{
		// Fields
		[FormerlySerializedAs("_projectilePrefab")]
		[SerializeField]
		private Projectile _ProjectilePrefab;
		protected GameManager _gameMan;
		protected PlayerOptions _playerOptions;
		protected GameSessionData _gameSessionData; // 0x80
		protected WeaponData _currentWeaponData; // 0x88
		protected bool _skipAddingEvolution; // 0x90
		protected readonly List<Projectile> _spawnedProjectiles; // 0x98
		protected Transform _cachedTransform; // 0xA0
		protected VampireSurvivors.Framework.TimerSystem.Timer _lastShotTimer; // 0xA8
		protected VampireSurvivors.Framework.TimerSystem.Timer _firingTimer; // 0xB0
		private VampireSurvivors.Framework.TimerSystem.Timer _firingAnimEvent; // 0xB8
		protected Transform _targetTransform; // 0xC0
		protected BulletPool _projectilePool; // 0xC8
		protected int _critIndex; // 0xD0
		protected List<float> _critChancesArray; // 0xD8
		protected int _bounces; // 0xE0
		protected int _bonusBounces; // 0xE4
		protected float _lastFiringInterval; // 0xE8
		protected bool _beginningArcana; // 0xEC
		protected int _beginningAmount; // 0xF0
		protected List<Collider> _wallsColliders; // 0xF8
		protected bool _isVisible; // 0x100
		protected WeaponType _explosionType; // 0x104
		[NonSerialized]
		public bool _explodeOnExpire; // 0x108
		protected BulletPool _secondaryPool; // 0x110
		protected ProjectileFactory _projectileFactory; // 0x118
		protected WeaponType _secondaryOvarlapDamageType; // 0x120
		[HideInInspector]
		public LimitBreakData accumulatedLimitBreaks; // 0x128
		[NonSerialized]
		public bool IsHoming; // 0x130
		[NonSerialized]
		public bool IsAdept; // 0x131
		public bool HasCooldownSpeedBonus; // 0x132
		private float _defangChance; // 0x144
		private static readonly ProfilerMarker _markerCleanup; // 0x00
		private static readonly ProfilerMarker _markerFireOneProjectile; // 0x08
	
		protected virtual int ProjectilePoolSize { get => default; } // 0x0000000182111EF0-0x0000000182111F00 
		public PhysicsGroup ProjectileGroup { get => default; } // 0x00000001827666D0-0x00000001827666E0 
		public List<Projectile> SpawnedProjectiles { get => default; } // 0x0000000181971630-0x0000000181971640 
		public GameManager GameMan { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		protected HitVfxType VfxType { get => _currentWeaponData?.hitVFX ?? HitVfxType.Default; }
		protected virtual bool UseOnlineTimer { get => default; } // 0x0000000181958370-0x0000000181958380 
		public float StatsInflictedDamage { get; set; } // 0x0000000186560970-0x0000000186560980 0x0000000186560980-0x0000000186560990
		public float StatsLifetime { get; private set; } // 0x0000000186758A90-0x0000000186758AA0 0x0000000186758AA0-0x0000000186758AB0
		public virtual float Chance { get => _currentWeaponData.chance; }
		public int Penetrating { get => _currentWeaponData.penetrating; protected set { _currentWeaponData.penetrating = value; } }
		public float Interval { get => _currentWeaponData.interval; set { _currentWeaponData.interval = value; } }
		protected float Duration { get => _currentWeaponData.duration.GetValueOrDefault(1000.0f); }
		public float RepeatInterval { get => _currentWeaponData.repeatInterval; } // 0x00000001870CB040-0x00000001870CB070 
		public WeaponData CurrentWeaponData { get => default; } // 0x00000001819A03E0-0x00000001819A03F0 
		public float HitBoxDelay { get => _currentWeaponData.hitBoxDelay.GetValueOrDefault(1000.0f); } // 0x00000001870CB070-0x00000001870CB0F0 
		public float Knockback { get => _currentWeaponData.knockback.GetValueOrDefault(5.0f); } // 0x00000001870CB0F0-0x00000001870CB170 
		public PlayerOptions PlayerOptions { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public bool CanCrit { get; protected set; } // 0x0000000182917560-0x0000000182917570 0x00000001870CB170-0x00000001870CB180
		public List<float> CritChancesArray { get => default; } // 0x0000000182A45A70-0x0000000182A45A80 
		public float FreezeChance { get; set; } // 0x0000000184F54B50-0x0000000184F54B60 0x000000018628F1E0-0x000000018628F1F0
		public virtual float DefangChance { get => default; set {} } // 0x0000000184F54B90-0x0000000184F54BA0 0x0000000186758AB0-0x0000000186758AC0
		public int CritIndex { get => default; set {} } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		protected Vector2 PlayerPos { get => Owner.position.ToVector2(); } // 0x00000001870CB180-0x00000001870CB1C0 
		public float TotalTime { get; set; } // 0x0000000185F859C0-0x0000000185F859D0 0x0000000185F859D0-0x0000000185F859E0
		public int LimitBreakLevel { get; private set; } // 0x00000001870CB1C0-0x00000001870CB1D0 0x00000001870CB1D0-0x00000001870CB1E0
		public bool SkipAddingEvolution { get => default; set {} } // 0x00000001819643B0-0x00000001819643C0 0x00000001826FAF20-0x00000001826FAF30
		public bool SkipAddingNormalWeapon { get; set; } // 0x000000018578E980-0x000000018578E990 0x000000018578E990-0x000000018578E9A0
		public bool IsVisible { get => default; } // 0x00000001829080B0-0x00000001829080C0 
		public bool ShowAsDisabledOnEquipmentPanel { get; set; } // 0x000000018578E9A0-0x000000018578E9B0 0x000000018578E9B0-0x000000018578E9C0
	
		// Nested types
		public enum FiringAnimation // TypeDefIndex: 16801
		{
			None = 0,
			Melee = 1,
			Ranged = 2,
			Magic = 3,
			Bazooka = 4,
			GlyphAbs = 5,
			Axe = 6,
			ConeOfCold = 7
		}
	
		// Constructors
		public Weapon() {} // 0x00000001870D0980-0x00000001870D0BB0
		static Weapon() {} // 0x00000001870D0BB0-0x00000001870D0C60
	
		// Methods
		public override bool IsPowerup() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual float StatsGetDps() => (StatsLifetime == 0.0f) ? 0.0f : StatsInflictedDamage / StatsLifetime;
		protected override void FakeConstruct()
		{
			_dataManager = GM.Core.DataManager;
			_signalBus = GM.Core.SignalBus;
			_levelUpFactory = GM.Core.LevelUpFactory;
			_gameMan = GM.Core;
			_playerOptions = GM.Core.PlayerOptions;
			_gameSessionData = GM.Core.GameSessionData;
			_projectileFactory = GM.Core.ProjectileFactory;
		}
		protected virtual new void Awake() 
		{
			_cachedTransform = transform;
			LimitBreakLevel = 0;
			_wallsColliders = new List<Collider>();
			accumulatedLimitBreaks = new LimitBreakData();
		}
		protected override void OnDestroy()
		{
			if (_firingAnimEvent != null) _firingAnimEvent.Cancel();
			if (_firingTimer != null) _firingTimer.Cancel();
			if (_projectilePool != null) _projectilePool.Destroy();
			_projectilePool = null;
			if (_secondaryPool != null) _secondaryPool.Destroy();
			_secondaryPool = null;
		}
		public virtual void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType)
		{
			FakeConstruct();
			Owner = characterController;
			Type = weaponType;
			StatsInflictedDamage = 0;
			TotalTime = 0;
			_beginningAmount = 0;
			if (_projectilePool == null)
			{
				_projectilePool = new BulletPool(projectilePrefab: _ProjectilePrefab, ProjectilePoolSize);
			}
			_isVisible = true;
			MakeLevelOne();
			OnStart();
			GM.Core.ParticleManager.RegisterParticleSystem(this.GetComponentInChildren<ParticleSystem>());
		}
		public virtual void OnMirrorData(Vector2 position) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnWeaponAdded() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual float CalculateTotalDamage() => default; // 0x0000000186560970-0x0000000186560980
		protected virtual void OnStart()
		{
			if (GetFiringAnimation != null) PlayNextAttackAnim();
			ResetFiringTimer();

			var enemies = _gameMan.Enemies;
			var overlapEnemy = ArcadePhysics.scene.physics.add.overlap(_projectilePool, enemies, OnBulletOverlapsEnemy);
			overlapEnemy.setName("Projectiles>Enemies");
            var overlapDestructibles = ArcadePhysics.scene.physics.add.overlap(_projectilePool, _gameMan.PhysicsManager._destructiblesGroup, OnBulletOverlapsDestructible);
            overlapDestructibles.setName("Projectiles>Destructibles");

			if (GM.Core.IsLocalMultiplayer)
			{
                var overlapPlayers = ArcadePhysics.scene.physics.add.overlap(_projectilePool, _gameMan.PhysicsManager._playerGroup, OnBulletOverlapsPlayer);
                overlapPlayers.setName("Projectiles>Players");
            }

			if (!_currentWeaponData.hitsWalls) return;

			if (!_gameMan.Stage.HasTileSet) return;
			var tiling = _gameMan.Stage.TilingTileset;

			if (tiling == null) return;

			var tileMaps = _gameMan.Stage.TilingTileset.GetPhaserTilemaps();
			var world = ArcadePhysics.s_world;
			var setCollider = new TilemapSetCollider(world, false, _projectilePool, null, collideCallback: OnBulletOverlapsWall);

			setCollider.setName("Projectiles>Tilemap");
			foreach (var tile in tileMaps)
			{
				setCollider.AddTilemap(tile._parentSetID, tile);
			}

			if (ArcadePhysics.scene?.physics?.world != null)
			{
				ArcadePhysics.scene.physics.world.addColliderDirect(setCollider);
			}
			else
			{
				world.addColliderDirect(setCollider);
			}
        }
		public virtual float2 GetFiringVector() => new float2(Owner.LastFacingDirection.x, Owner.LastFacingDirection.y);
		protected virtual bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
		{
            var enemy = first.gameObject.GetComponent<EnemyController>();
            if (enemy.IsDead) return false;

            var projectile = second.gameObject.GetComponent<Projectile>();
            if (!projectile.HasAlreadyHitObject(enemy))
            {
				DealDamage(enemy);
            }
            return false;
        }
		protected virtual bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
		{
			var character = first.gameObject.GetComponent<CharacterController>();
			if (character.IsDead || character.IsDisconnectedFromOnlinePlay || character == Owner) return false;
			
			var projectile = second.gameObject.GetComponent<Projectile>();
			return projectile.HasAlreadyHitPlayerObject(character);
        }
		protected virtual bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
        {
            return EnemyBulletOverlap(second, first, SecondaryPPower());
        }

        protected virtual bool OnSecondaryBulletOverlapsEnemyCurse(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
		{
            return EnemyBulletOverlap(second, first, SecondaryCursePPower());
        }
		protected virtual bool OnBulletOverlapsEnemyRetaliation(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
        {
            var enemy = first.gameObject.GetComponent<EnemyController>();
            if (enemy.IsDead) return false;

            var projectile = second.gameObject.GetComponent<Projectile>();
            if (!projectile.HasAlreadyHitObject(enemy)) DealDamageRetaliation(enemy);
            return false;
        }

        protected virtual bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first)
		{
            var destruct = first.gameObject.GetComponent<Destructible>();

            var projectile = second.gameObject.GetComponent<Projectile>();
            if (!projectile.HasAlreadyHitObject(destruct)) 
				destruct.GetDamaged(PPower(), HitVfxType.None, 0.0f, _currentWeaponData.bulletType, true);
            return false;
        }
		protected virtual bool OnBulletOverlapsWall(CallbackContext context, ArcadeColliderType bullet, ArcadeColliderType tile)
		{
			var wall = tile as PhaserTile;
			if (wall == null) return false;

            var projectile = bullet.gameObject.GetComponent<Projectile>();
			projectile.OnHasHitWallPhaser(wall);
            return false;
        }
		public override void InternalUpdate()
		{
			StatsLifetime += Time.deltaTime;

			foreach (var projectile in _spawnedProjectiles)
			{
				projectile.InternalUpdate();
			}
		}
		public virtual int ActiveProjectileCount() => _projectilePool?.countActive() ?? 0;
		public void AddSpawnedProjectile(Projectile projectile)
		{
			if (!_spawnedProjectiles.Contains(projectile)) _spawnedProjectiles.Add(projectile);
		}
		public void DespawnProjectile(Projectile projectile)
		{
            if (!_spawnedProjectiles.Contains(projectile)) _spawnedProjectiles.Remove(projectile);
        }
		public override void Cleanup()
		{
			_firingAnimEvent.Cancel();
			_firingTimer.Cancel();
			_lastShotTimer.Cancel();
			_projectilePool.Cleanup();
			_secondaryPool.Cleanup();
			this.gameObject.SetActive(false);
		}
		public Vector2 GetPlayerCurrentDirection() => Owner.LastMovementDirection;
		public virtual bool LevelUp() => default; // 0x0000000184C0C910-0x0000000184C0C930
		public void EnableAdept()
		{
			IsAdept = true;
			_currentWeaponData.interval *= 0.5f;
		}
		public override bool LevelUp(bool skipFire)
		{
			if (GetDataForLevel(Type, Level, out JObject newLevelData, true))
			{

			};
		}
		public virtual void HandlePlayerTeleport(float2 destinationPos) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual float PArea() => default; // 0x00000001870CD490-0x00000001870CD4E0
		public virtual int PBounces() => default; // 0x00000001870CD4E0-0x00000001870CD4F0
		public virtual float PAmount() => _currentWeaponData.amount + Mathf.Min(10.0f, Owner.PAmount()); // 0x0000000186FD21D0-0x0000000186FD2230
		public virtual float SecondaryPAmount() => default; // 0x00000001870CD4F0-0x00000001870CD510
		public virtual float PPower() => Owner.BloodlineDamage + (_currentWeaponData.power * Owner.PPowerFinal());
		public virtual float SecondaryPPower() => default; // 0x00000001870CD510-0x00000001870CD590
		public virtual float SecondaryCursePPower() => default; // 0x00000001870CD590-0x00000001870CD640
		public virtual float PSpeed() => default; // 0x00000001870CD640-0x00000001870CD790
		public virtual float PHitBoxDelayOverSpeed() => default; // 0x00000001870CD790-0x00000001870CD7E0
		public virtual float PSpeedRepeatInterval() => default; // 0x00000001870CD7E0-0x00000001870CD840
		public virtual float PInterval() => default; // 0x00000001870CD840-0x00000001870CD900
		public virtual float PDuration() => default; // 0x00000001870CD900-0x00000001870CDA70
		public virtual void ParadoxFire() => Fire(true);
		public virtual void Fire() {} // 0x00000001870CDA70-0x00000001870CDA90
		public virtual void Fire(bool skipTriggers = false /* Metadata: 0x01977E63 */) {} // 0x00000001870CDA90-0x00000001870CDDF0
		public virtual Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x00000001870CDDF0-0x00000001870CE060
		public virtual Projectile FireOneProjectileIgnoreDistanceToPlayer(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x00000001870CE060-0x00000001870CE270
		public Projectile FireOneBullet(float x, float y, int index, Transform target) => default; // 0x00000001870CE270-0x00000001870CE2B0
		public virtual void DealDamage(IDamageable other) {} // 0x00000001870CE2B0-0x00000001870CE320
		public virtual void DealDamageRetaliation(IDamageable other) {} // 0x00000001870CE320-0x00000001870CE490
		public virtual void DealDamage(IDamageable other, float damage) {} // 0x00000001870CE490-0x00000001870CE550
		public void DamageAllEnemies(float value) {} // 0x00000001870CE550-0x00000001870CE920
		public virtual void StandardCritical(ArcadeColliderType second, ArcadeColliderType first) {} // 0x00000001870CE920-0x00000001870CEC00
		public override void CheckArcanas() => CheckBeginningArcana();
		public void CheckBeginningArcana() {} // 0x00000001870CEC00-0x00000001870CECE0
		public bool HasActiveArcanaOfType(ArcanaType arcanaType) => default; // 0x00000001870CECE0-0x00000001870CED50
		public bool CheckFreeze() => default; // 0x00000001870CED50-0x00000001870CEE90
		public bool CheckDefang() => default; // 0x00000001870CEE90-0x00000001870CEFE0
		public virtual void CopyAccumulatedLimitBreaks(Weapon from, Weapon to) {} // 0x00000001870CEFE0-0x00000001870CF050
		public virtual bool ApplyLimitBreak(WeightedLimitBreak weightedLimitBreak) => default; // 0x00000001870CF050-0x00000001870CF180
		public virtual Projectile SpawnExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977E64 */, int damage = 1 /* Metadata: 0x01977E65 */, float area = 1f /* Metadata: 0x01977E66 */) => default; // 0x00000001870CF180-0x00000001870CF570
		public virtual void ResetFiringTimer() {} // 0x00000001870CF570-0x00000001870CF820
		protected void FireAndQueueAnimation() {} // 0x00000001870CF820-0x00000001870CF850
		protected void PlayNextAttackAnim() {} // 0x00000001870CF850-0x00000001870CFC60
		protected virtual FiringAnimation GetFiringAnimation() => default; // 0x0000000180B15D70-0x0000000180B15D80
		public void RemoveFiringTimer() {} // 0x00000001870CFC60-0x00000001870CFCA0
		public virtual void SetVisible(bool visible) {} // 0x00000001864B9290-0x00000001864B92A0
		public static List<float> MakeChanceArray(int amount = 100 /* Metadata: 0x01977E6A */) => default; // 0x00000001870CFCA0-0x00000001870CFDE0
		protected virtual float CalcCritMul() => default; // 0x00000001870CFDE0-0x00000001870CFF50
		public virtual float GetChanceFromArray() => default; // 0x00000001870CFF50-0x00000001870CFFF0
		protected override void MakeLevelOne() {} // 0x00000001870CFFF0-0x00000001870D0790
		public void ReloadCurrentData() {} // 0x00000001870D0790-0x00000001870D0960
		protected override Dictionary<WeaponType, JArray> GetDataDictionary() => _dataManager.AllWeaponData;
		private void ApplyLimitBreakStatsToWeaponStats(LimitBreakData limitBreakData) {} // 0x00000001870D0960-0x00000001870D0980
        private bool EnemyBulletOverlap(ArcadeColliderType second, ArcadeColliderType first, float damage)
        {
            var enemy = first.gameObject.GetComponent<EnemyController>();
            if (enemy.IsDead) return false;

            var projectile = second.gameObject.GetComponent<Projectile>();
            if (!projectile.HasAlreadyHitObject(enemy))
			{
                enemy.GetDamaged(damage, VfxType, Knockback, Type, true);
                StatsInflictedDamage += damage;
            }
            return false;
        }
    }
}
