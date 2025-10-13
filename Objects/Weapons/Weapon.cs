/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Core;
using Newtonsoft.Json.Linq;
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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivorsDecompProject.Objects.Weapons
{
	public class Weapon : Equipment // TypeDefIndex: 16805
	{
		// Fields
		[FormerlySerializedAs("_projectilePrefab")]
		[SerializeField]
		private Projectile _ProjectilePrefab; // 0x68
		protected GameManager _gameMan; // 0x70
		protected PlayerOptions _playerOptions; // 0x78
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
	
		// Properties
		protected virtual int ProjectilePoolSize { get => default; } // 0x0000000182111EF0-0x0000000182111F00 
		public PhysicsGroup ProjectileGroup { get => default; } // 0x00000001827666D0-0x00000001827666E0 
		public List<Projectile> SpawnedProjectiles { get => default; } // 0x0000000181971630-0x0000000181971640 
		public GameManager GameMan { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		protected HitVfxType VfxType { get => default; } // 0x00000001870CAEA0-0x00000001870CAEC0 
		protected virtual bool UseOnlineTimer { get => default; } // 0x0000000181958370-0x0000000181958380 
		public float StatsInflictedDamage { get; set; } // 0x0000000186560970-0x0000000186560980 0x0000000186560980-0x0000000186560990
		public float StatsLifetime { get; private set; } // 0x0000000186758A90-0x0000000186758AA0 0x0000000186758AA0-0x0000000186758AB0
		public virtual float Chance { get => default; } // 0x00000001870CAEC0-0x00000001870CAEF0 
		public int Penetrating { get => default; protected set {} } // 0x00000001870CAF30-0x00000001870CAF60 0x00000001870CAF60-0x00000001870CAF90
		public float Interval { get => default; set {} } // 0x0000000186FA1B70-0x0000000186FA1BA0 0x00000001870CAF90-0x00000001870CAFC0
		protected float Duration { get => default; } // 0x00000001870CAFC0-0x00000001870CB040 
		public float RepeatInterval { get => default; } // 0x00000001870CB040-0x00000001870CB070 
		public WeaponData CurrentWeaponData { get => default; } // 0x00000001819A03E0-0x00000001819A03F0 
		public float HitBoxDelay { get => default; } // 0x00000001870CB070-0x00000001870CB0F0 
		public float Knockback { get => default; } // 0x00000001870CB0F0-0x00000001870CB170 
		public PlayerOptions PlayerOptions { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public bool CanCrit { get; protected set; } // 0x0000000182917560-0x0000000182917570 0x00000001870CB170-0x00000001870CB180
		public List<float> CritChancesArray { get => default; } // 0x0000000182A45A70-0x0000000182A45A80 
		public float FreezeChance { get; set; } // 0x0000000184F54B50-0x0000000184F54B60 0x000000018628F1E0-0x000000018628F1F0
		public virtual float DefangChance { get => default; set {} } // 0x0000000184F54B90-0x0000000184F54BA0 0x0000000186758AB0-0x0000000186758AC0
		public int CritIndex { get => default; set {} } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		protected Vector2 PlayerPos { get => default; } // 0x00000001870CB180-0x00000001870CB1C0 
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
		public virtual float StatsGetDps() => default; // 0x00000001870CAEF0-0x00000001870CAF30
		protected override void FakeConstruct() {} // 0x00000001870CB1E0-0x00000001870CB560
		protected virtual new void Awake() 
		{
			_cachedTransform = transform;
			LimitBreakLevel = 0;
			_wallsColliders = new List<Collider>();
			accumulatedLimitBreaks = new LimitBreakData();
		}
		protected override void OnDestroy() {} // 0x00000001870CB710-0x00000001870CB840
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
		protected virtual void OnStart() {} // 0x00000001870CBA50-0x00000001870CC270
		public virtual float2 GetFiringVector() => default; // 0x00000001870CC270-0x00000001870CC2B0
		protected virtual bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CC2B0-0x00000001870CC3D0
		protected virtual bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CC3D0-0x00000001870CC640
		protected virtual bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CC640-0x00000001870CC7E0
		protected virtual bool OnSecondaryBulletOverlapsEnemyCurse(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CC7E0-0x00000001870CC980
		protected virtual bool OnBulletOverlapsEnemyRetaliation(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018706F9E0-0x000000018706FB00
		protected virtual bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CC980-0x00000001870CCAE0
		protected virtual bool OnBulletOverlapsWall(CallbackContext context, ArcadeColliderType bullet, ArcadeColliderType tile) => default; // 0x00000001870CCAE0-0x00000001870CCBD0
		public override void InternalUpdate() {} // 0x00000001870CCBD0-0x00000001870CCCF0
		public virtual int ActiveProjectileCount() => default; // 0x00000001870CCCF0-0x00000001870CCD10
		public void AddSpawnedProjectile(Projectile projectile) {} // 0x00000001870CCD10-0x00000001870CCD90
		public void DespawnProjectile(Projectile projectile) {} // 0x00000001870CCD90-0x00000001870CCE20
		public override void Cleanup() {} // 0x00000001870CCE20-0x00000001870CCEB0
		public Vector2 GetPlayerCurrentDirection() => default; // 0x00000001870CCEB0-0x00000001870CCEE0
		public virtual bool LevelUp() => default; // 0x0000000184C0C910-0x0000000184C0C930
		public void EnableAdept() {} // 0x00000001870CCEE0-0x00000001870CCF20
		public override bool LevelUp(bool skipFire) => default; // 0x00000001870CCF20-0x00000001870CD490
		public virtual void HandlePlayerTeleport(float2 destinationPos) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual float PArea() => default; // 0x00000001870CD490-0x00000001870CD4E0
		public virtual int PBounces() => default; // 0x00000001870CD4E0-0x00000001870CD4F0
		public virtual float PAmount() => default; // 0x0000000186FD21D0-0x0000000186FD2230
		public virtual float SecondaryPAmount() => default; // 0x00000001870CD4F0-0x00000001870CD510
		public virtual float PPower() => default; // 0x0000000186F61F50-0x0000000186F61FD0
		public virtual float SecondaryPPower() => default; // 0x00000001870CD510-0x00000001870CD590
		public virtual float SecondaryCursePPower() => default; // 0x00000001870CD590-0x00000001870CD640
		public virtual float PSpeed() => default; // 0x00000001870CD640-0x00000001870CD790
		public virtual float PHitBoxDelayOverSpeed() => default; // 0x00000001870CD790-0x00000001870CD7E0
		public virtual float PSpeedRepeatInterval() => default; // 0x00000001870CD7E0-0x00000001870CD840
		public virtual float PInterval() => default; // 0x00000001870CD840-0x00000001870CD900
		public virtual float PDuration() => default; // 0x00000001870CD900-0x00000001870CDA70
		public virtual void ParadoxFire() {} // 0x0000000186F29A40-0x0000000186F29A60
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
		public override void CheckArcanas() {} // 0x0000000186F6A610-0x0000000186F6A620
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
		protected override Dictionary<WeaponType, JArray> GetDataDictionary() => default; // 0x00000001869D49A0-0x00000001869D49C0
		private void ApplyLimitBreakStatsToWeaponStats(LimitBreakData limitBreakData) {} // 0x00000001870D0960-0x00000001870D0980
	}
}
