/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivorsDecompProject.Objects.Pools;
using VampireSurvivorsDecompProject.Objects.Weapons;
using System.Collections;
using Unity.Mathematics;
using PartyCSharpSDK;

namespace VampireSurvivorsDecompProject.Objects.Projectiles
{
	public class Projectile : ArcadeSprite, IDamageable // TypeDefIndex: 15940
	{
		// Fields
		[FormerlySerializedAs("_bounceOffWalls")]
		[SerializeField]
		private bool _BounceOffWalls; // 0x58
		protected Transform _cachedTransform; // 0x60
		protected Weapon _weapon; // 0x68
		protected int _indexInWeapon; // 0x70
		protected Transform _targetTransform; // 0x78
		protected SpriteRenderer _renderer; // 0x80
		protected GameSessionData _gameSessionData; // 0x88
		protected Camera _mainCamera; // 0x90
		protected SpriteTrail _spriteTrail; // 0x98
		private float _pauseWallChecksTimer; // 0xA0
		[NonSerialized]
		public float _speed; // 0xA4
		protected int _penetrating; // 0xA8
		protected int _bounces; // 0xAC
		protected bool _isCullable; // 0xB0
		protected bool _bounceActivated; // 0xB1
		protected ArcadeSprite _sprite; // 0xB8
		protected BulletPool _pool; // 0xC0
		protected readonly HashSet<IDamageable> _objectsHit; // 0xC8
		private static readonly ProfilerMarker _markerInitProjectile; // 0x00
	
		// Properties
		public HashSet<IDamageable> ObjectsHit { get => _objectsHit; } // 0x00000001827666D0-0x00000001827666E0 
		public virtual float ProjectileSpeed { get => Weapon.PSpeed() * GameManager.ProjectileSpeed * _speed; } // 0x0000000186E56590-0x0000000186E56630 
		public int IndexInWeapon { get => default; } // 0x00000001819A0220-0x00000001819A0230 
		public Weapon Weapon { get => default; } // 0x00000001819A0210-0x00000001819A0220 
		protected Vector2 Velocity { get => _sprite.body._velocity; private set { _sprite.body._velocity = value; } } // 0x0000000186E56630-0x0000000186E56660 0x0000000184C486A0-0x0000000184C486E0
	
		// Constructors
		public Projectile() 
		{
			_speed = 1.0f;
			_isCullable = true;
			_objectsHit = new HashSet<IDamageable>();
		} // 0x0000000186E5A4C0-0x0000000186E5A5D0
		static Projectile() {} // 0x0000000186E5A5D0-0x0000000186E5A640
	
		// Methods
		protected virtual new void Awake() 
		{
			_cachedTransform = this.GetComponent<Transform>();
			_renderer = this.GetComponentInChildren<SpriteRenderer>();
			_spriteTrail = this.GetComponentInChildren<SpriteTrail>();
			_mainCamera = Camera.main;
			_bounceActivated = false;
			_sprite = this;
		} // 0x0000000186E56660-0x0000000186E568B0
		protected override void OnUpdate() 
		{
			CheckIfVisibleOnScreen();
			if (_pauseWallChecksTimer > 0)
			{
				_pauseWallChecksTimer -= PauseSystem.DeltaTime;
			}
		} // 0x0000000186D95110-0x0000000186D95160
		public virtual void InitProjectile(BulletPool pool, Weapon weapon, int index) 
		{
			_gameSessionData = GM.Core.GameSessionData;
			_pool = pool;
			_weapon = weapon;
			_indexInWeapon = index;
			if (_objectsHit.Count >0)
				_objectsHit.Clear();
			_bounces = weapon.PBounces();
			if (body == null)
				ArcadePhysics.scene.physics.world.enableBody(this);

			PhysicsManager.Instance._bulletGroup.add(this._sprite);
			if (_spriteTrail)
				_spriteTrail.Reset();

			if (!weapon.SpawnedProjectiles.Contains(this))
				weapon.SpawnedProjectiles.Add(this);

			GM.Core.ParticleManager.RegisterParticleSystem(this.GetComponentInChildren<ParticleSystem>());
		} // 0x0000000186E568B0-0x0000000186E56CF0
		public virtual void SetNullTarget() 
		{
			_targetTransform = null;
		} // 0x0000000186E56CF0-0x0000000186E56D50
		public virtual void SetTarget(Transform target) 
		{
			_targetTransform = target;
		} // 0x0000000181917690-0x00000001819176F0
		public void SetVelocity(Vector2 velocity) 
		{
			_sprite.body._velocity = velocity;
		} // 0x0000000186E56D50-0x0000000186E56D90
		public virtual void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public bool HasAlreadyHitPickUpObject(IDamageable damageable)
        {
            return HasAlreadyHitObject(damageable);
        }// 0x0000000186E56D90-0x0000000186E56E40

		public bool HasAlreadyHitObject(IDamageable damageable)
		{
			if (ObjectHitCheck(damageable)) return true;

			OnHasHitAnObject(damageable);

			return false;
		}// 0x0000000186E56E40-0x0000000186E56F00
		public bool HasAlreadyHitPlayerObject(IDamageable damageable) 
		{
            if (ObjectHitCheck(damageable)) return true;

            OnHasHitAnotherPlayerObject(damageable);

            return false;
        } // 0x0000000186E56F00-0x0000000186E56FC0
		public void AddObjectHit(IDamageable obj) 
		{
            _objectsHit.Add(obj);
        } // 0x0000000186E56FC0-0x0000000186E57030
		public float AngleFromTargetRadians(Transform target, Transform playerTransform)
		{
			if (target == null) target = PickRandomEnemy();

			return Mathf.Atan2(target.position.y - playerTransform.position.y, target.position.x - playerTransform.position.x);
		}// 0x0000000186E57030-0x0000000186E572A0
		public void ApplyPlayerFacingVelocity(Vector3 playerDirection, bool rotate = true /* Metadata: 0x01977975 */) 
		{
			var normal = playerDirection.normalized;
			if (normal.x == 0.0f && normal.y == 0.0f)
				normal.x = 1.0f;
			Velocity = new float2(ProjectileSpeed * normal.x, ProjectileSpeed * normal.y);

			if (rotate)
			{
				var angle = Mathf.Atan2(normal.y, normal.x);
				transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			}
		} // 0x0000000186E572A0-0x0000000186E57560
		public void ApplyInversePlayerFacingVelocity(Vector3 playerDirection, bool rotate = true /* Metadata: 0x01977976 */) 
		{
            var normal = playerDirection.normalized;
            if (normal.x == 0.0f && normal.y == 0.0f)
                normal.x = 1.0f;
            Velocity = new float2(ProjectileSpeed * -normal.x, ProjectileSpeed * -normal.y);

            if (rotate)
            {
                var angle = Mathf.Atan2(normal.y, normal.x);
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        } // 0x0000000186E57560-0x0000000186E57840
		public virtual void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BB8730-0x0000000186BB8750
		public virtual bool CanExplode() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual void Explode(Vector2? position = default) {} // 0x0000000180B15170-0x0000000180B15180
		private void CheckIfVisibleOnScreen() 
		{
			if (_mainCamera == null) throw new NullReferenceException();
			var camPos = _mainCamera.transform.position;
			var ortho = _mainCamera.orthographicSize;
			var aspect = _mainCamera.aspect;
			var view = (aspect * ortho);

            var yMinusOrtho = camPos.y - ortho;
			var xMinusAspectTimesOrtho = camPos.x - view;
			var aspectTimesOrthoTimes2 = view * 2;

            if (transform.position.x < xMinusAspectTimesOrtho
				|| aspectTimesOrthoTimes2 <= transform.position.x
				|| transform.position.y < yMinusOrtho
				|| yMinusOrtho + (ortho * 2) <= transform.position.y)
			{
				Despawn();
			}
		} // 0x0000000186E57840-0x0000000186E57AC0
		public virtual void Despawn()
		{
			PhysicsManager.Instance._bulletGroup.remove(this._sprite);

			body._enable = false;

			if (Weapon.SpawnedProjectiles?.Contains(this) ?? false)
			{
				Weapon.SpawnedProjectiles.Remove(this);
			}

			_pool.Return(this);
		} // 0x0000000186E57AC0-0x0000000186E57D40
		protected void SetScaleToArea(float multiplier = 1f /* Metadata: 0x01977977 */) 
		{
			var one = Vector3.one;
			var area = _weapon.PArea();
            _cachedTransform.localScale = new Vector3((one.x * area) * multiplier, (one.y * area) * multiplier, (one.z * area) * multiplier);
		} // 0x0000000186E57D40-0x0000000186E57E90
		protected Vector2 SetVelocityFromRotation(float rotation, float speed)
		{
			var vel = this.Velocity.ToFloat2();
			ArcadePhysics.Instance.velocityFromRotation(rotation, speed, ref vel);
			Velocity = vel;
			return vel;
		}// 0x0000000186E57E90-0x0000000186E57F20
		public bool TryFreeze(IDamageable target) => default; // 0x0000000186E57F20-0x0000000186E58310
		public bool TryDefang(IDamageable target) => default; // 0x0000000186E58310-0x0000000186E585C0
		protected virtual void OnHasHitAnObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
		public float AngleFromVelocity(Vector2 velocity) => default; // 0x0000000186E585C0-0x0000000186E585F0
		protected float AngleFromVelocityRadians(Vector2 velocity) => default; // 0x0000000186E585F0-0x0000000186E58610
		protected Transform SetForNearestEnemy(ref Vector2 v) => default; // 0x0000000186E58610-0x0000000186E58A30
		public virtual Transform AimForNearestEnemyToPlayer(bool rotate = true /* Metadata: 0x0197797B */) => default; // 0x0000000186E58A30-0x0000000186E58C20
		public virtual Transform AimForNearestEnemy(bool rotate = true /* Metadata: 0x0197797C */) => default; // 0x0000000186E58C20-0x0000000186E58EF0
		public virtual Transform AimForNearestEnemyFrom(Transform targetT, bool rotate = true /* Metadata: 0x0197797D */, Vector3? customFromPosition = default) => default; // 0x0000000186E58EF0-0x0000000186E591C0
		protected virtual Transform AimForRandomEnemy(bool rotate = true /* Metadata: 0x0197797E */) => default; // 0x0000000186E591C0-0x0000000186E59440
		protected virtual Transform GetNearestEnemyTransform() => default; // 0x0000000186E59440-0x0000000186E595D0
		protected virtual Transform AimForRandomEnemyInScreen([JetBrains.Annotations.CanBeNull] Rectangle _rect = null) => default; // 0x0000000186E595D0-0x0000000186E59660
		public virtual void AimForRandomDirection(bool rotate = false /* Metadata: 0x0197797F */) {} // 0x0000000186E59660-0x0000000186E598D0
		public virtual void ApplyInitialVelocity(Transform target, Transform playerTransform, bool rotate = true /* Metadata: 0x01977980 */, Vector3? customFromPosition = default) {} // 0x0000000186E598D0-0x0000000186E59D40
		public virtual void ApplyAngleVelocity(float angleAim, bool rotate = true /* Metadata: 0x01977981 */) {} // 0x0000000186E59D40-0x0000000186E59F60
		protected virtual float RotateTowardsEnemy() => default; // 0x0000000186E59F60-0x0000000186E5A460
		public void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01977982 */, float damageKnockBack = 1f /* Metadata: 0x01977983 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01977987 */, bool hasKb = true /* Metadata: 0x01977988 */) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x01977989 */) {} // 0x0000000180B15170-0x0000000180B15180
		public bool IsUnitDead() => default; // 0x0000000180B15290-0x0000000180B152A0
		public float MaxHp() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public float CurrentHealth() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void GiveReward(Action<Pickup> onRewardGiven = null) {} // 0x0000000180B15170-0x0000000180B15180
		public float AlphaFromScale(float weaponArea, float maxScale, float minAlpha) => default; // 0x0000000186E5A460-0x0000000186E5A4C0

        private bool ObjectHitCheck(IDamageable damageable)
        {
            if (_objectsHit.Contains(damageable)) return true;

            AddObjectHit(damageable);

            return false;
        }

		private Transform PickRandomEnemy()
		{
			return _weapon.GameMan.Stage.PickRandomEnemy(_weapon.Owner.RandomEnemyPickerGenerator);
		}

        #region Decompiled Psuedocode Reference
        /*
		// Void OnUpdate()
		void __fastcall VampireSurvivors::Objects::Projectiles::Projectile::OnUpdate(Projectile *this)
		{
			float pauseWallChecksTimer; // xmm1_4

			VampireSurvivors::Objects::Projectiles::Projectile::CheckIfVisibleOnScreen((VampireSurvivors::Objects::Projectiles::Projectile *)this);
			pauseWallChecksTimer = this->fields._pauseWallChecksTimer;
			if ( pauseWallChecksTimer > 0.0 )
			{
				PauseSystem::get_DeltaTime(0);
				this->fields._pauseWallChecksTimer = pauseWallChecksTimer - 0.0;
			}
		}	

		// Void Awake()
		void __fastcall VampireSurvivors::Objects::Projectiles::Projectile::Awake(Projectile *this)
		{
		  struct Transform *trans; // rax
		  bool v3; // zf
		  __int64 *v4; // rdx
		  signed __int64 v5; // rtt
		  struct SpriteRenderer *renderer; // rax
		  __int64 *v7; // rdx
		  signed __int64 v8; // rtt
		  struct SpriteTrail *v9; // rax
		  __int64 *v10; // rdx
		  signed __int64 v11; // rtt
		  int v12; // eax
		  __int64 *v13; // rdx
		  signed __int64 v14; // rtt
		  unsigned int v15; // ebx
		  unsigned __int64 v16; // rax
		  char v17; // bl
		  __int64 *v18; // rdx
		  signed __int64 v19; // rtt
		  signed __int32 v20[10]; // [rsp+0h] [rbp-28h] BYREF

		  if...
		  trans = (struct Transform *)UnityEngine::Component::GetComponent<System::Object>(
										this,
										MethodInfo::UnityEngine::Component::GetComponent<UnityEngine::Transform>);
		  v3 = dword_189483790 == 0;
		  this->fields._cachedTransform = trans;
		  if...
		  renderer = (struct SpriteRenderer *)UnityEngine::Component::GetComponentInChildren<System::Object>((UnityEngine::Component *)this);
		  v3 = dword_189483790 == 0;
		  this->fields._renderer = renderer;
		  if...
		  v9 = (struct SpriteTrail *)UnityEngine::Component::GetComponentInChildren<System::Object>((UnityEngine::Component *)this);
		  v3 = dword_189483790 == 0;
		  this->fields._spriteTrail = v9;
		  if...
		  this->fields._mainCamera = (struct Camera *)UnityEngine::Camera::get_main(0);
		  v12 = dword_189483790;
		  if...
		  this->fields._bounceActivated = 0;
		  this->fields._sprite = (struct ArcadeSprite *)this;
		  if...
		}

		*/
        #endregion Decompiled Psuedocode Reference
    }
}
