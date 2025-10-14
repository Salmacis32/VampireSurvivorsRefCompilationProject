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
using Unity.Mathematics;
using VampireSurvivors.Objects.Characters;

namespace VampireSurvivorsDecompProject.Objects.Projectiles
{
    public class Projectile : ArcadeSprite, IDamageable
    {
        [NonSerialized]
        public float _speed;
        protected readonly HashSet<IDamageable> _objectsHit;
        protected bool _bounceActivated;
        protected int _bounces;
        protected Transform _cachedTransform;
        protected GameSessionData _gameSessionData;
        protected int _indexInWeapon;
        protected bool _isCullable;
        protected Camera _mainCamera;
        protected int _penetrating;
        protected BulletPool _pool;
        protected SpriteRenderer _renderer;
        protected ArcadeSprite _sprite;
        protected SpriteTrail _spriteTrail;
        protected Transform _targetTransform;
        protected Weapon _weapon;
        private static readonly ProfilerMarker _markerInitProjectile;

        [FormerlySerializedAs("_bounceOffWalls")]
        [SerializeField]
        private bool _BounceOffWalls; // 0x58
        private float _pauseWallChecksTimer; // 0xA0
        static Projectile()
        {
        }

        // Constructors
        public Projectile()
        {
            _speed = 1.0f;
            _isCullable = true;
            _objectsHit = new HashSet<IDamageable>();
        }

        public int IndexInWeapon { get => default; }

        public HashSet<IDamageable> ObjectsHit { get => _objectsHit; }

        public virtual float ProjectileSpeed { get => Weapon.PSpeed() * GameManager.ProjectileSpeed * _speed; }

        public Weapon Weapon { get => default; }

        protected Vector2 Velocity
        { get => _sprite.body._velocity; private set { _sprite.body._velocity = value; } }

        public void AddObjectHit(IDamageable obj)
        {
            _objectsHit.Add(obj);
        }

        public virtual Transform AimForNearestEnemy(bool rotate = true)
        {
            return AimForNearestEnemyFrom(_cachedTransform, rotate, _cachedTransform.position);
        }

        public virtual Transform AimForNearestEnemyFrom(Transform targetT, bool rotate = true, Vector3? customFromPosition = default)
        {
            var closest = GetNearestEnemyTransform();

            if (closest == null)
            {
                ApplyPlayerFacingVelocity(_weapon.Owner.LastMovementDirection.ToVector3(), rotate);
                return null;
            }

            ApplyInitialVelocity(closest, targetT, rotate, customFromPosition);
            return closest;
        }

        public virtual Transform AimForNearestEnemyToPlayer(bool rotate = true)
        {
            var ownerPos = _weapon.Owner.position;
            var ownerRet = new Vector3(ownerPos.x, ownerPos.y);
            var closest = GM.Core.Stage.FindClosestEnemy(ownerRet, excludeDead: true);

            if (closest == null) return null;

            ApplyInitialVelocity(closest.EnemyRenderer.transform, _cachedTransform, rotate, ownerRet);
            return closest.EnemyRenderer.transform;
        }

        public virtual void AimForRandomDirection(bool rotate = false)
        {
            var rng = UnityEngine.Random.Range(0.0f, (float)(Math.PI * 2));
            var speedCos = ProjectileSpeed * Mathf.Cos(rng);
            var speedSin = ProjectileSpeed * Mathf.Sin(rng);
            SetInitialVelocity(rotate, new Vector2(speedCos, speedSin));
        }

        public float AlphaFromScale(float weaponArea, float maxScale, float minAlpha) => default;

        public float AngleFromTargetRadians(Transform target, Transform playerTransform)
        {
            if (target == null) target = PickRandomEnemy();

            return Mathf.Atan2(target.position.y - playerTransform.position.y, target.position.x - playerTransform.position.x);
        }

        public float AngleFromVelocity(Vector2 velocity) => Mathf.Atan2(velocity.x, velocity.y) * Mathf.Rad2Deg;

        public virtual void ApplyAngleVelocity(float angleAim, bool rotate = true)
        {
            SetInitialVelocity(rotate, new Vector2(Mathf.Cos(angleAim), Mathf.Sin(angleAim)));
        }

        public virtual void ApplyInitialVelocity(Transform target, Transform refTransform, bool rotate = true, Vector3? customFromPosition = default)
        {
            InitialVelocityApplication(target, refTransform, rotate, customFromPosition);
        }

        public void ApplyInversePlayerFacingVelocity(Vector3 playerDirection, bool rotate = true)
        {
            PlayerFacingVelocityApplication(playerDirection, rotate, inverse: true);
        }

        public void ApplyPlayerFacingVelocity(Vector3 playerDirection, bool rotate = true)
        {
            PlayerFacingVelocityApplication(playerDirection, rotate);
        }

        public virtual bool CanExplode() => default;

        public float CurrentHealth() => default;

        public virtual void Despawn()
        {
            PhysicsManager.Instance._bulletGroup.remove(this._sprite);

            body._enable = false;

            if (Weapon.SpawnedProjectiles?.Contains(this) ?? false)
            {
                Weapon.SpawnedProjectiles.Remove(this);
            }

            _pool.Return(this);
        }
        public virtual void Explode(Vector2? position = default)
        { }

        public void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default, float damageKnockBack = 1f /* Metadata: 0x01977983 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01977987 */, bool hasKb = true /* Metadata: 0x01977988 */)
        { }

        public GameObject GetGameObject() => this.gameObject;

        public void GiveReward(Action<Pickup> onRewardGiven = null)
        { }

        public bool HasAlreadyHitObject(IDamageable damageable)
        {
            if (ObjectHitCheck(damageable)) return true;

            OnHasHitAnObject(damageable);

            return false;
        }

        public bool HasAlreadyHitPickUpObject(IDamageable damageable)
        {
            return HasAlreadyHitObject(damageable);
        }

        public bool HasAlreadyHitPlayerObject(IDamageable damageable)
        {
            if (ObjectHitCheck(damageable)) return true;

            OnHasHitAnotherPlayerObject(damageable);

            return false;
        }

        public virtual void InitProjectile(BulletPool pool, Weapon weapon, int index)
        {
            _gameSessionData = GM.Core.GameSessionData;
            _pool = pool;
            _weapon = weapon;
            _indexInWeapon = index;
            if (_objectsHit.Count > 0)
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
        }

        public virtual void InternalUpdate()
        { }

        public bool IsUnitDead() => default;

        public float MaxHp() => default;

        public void OnGetDamaged(HitVfxType hitVfxType, bool hasKb = true /* Metadata: 0x01977989 */)
        { }

        public virtual void OnHasHitWallPhaser(PhaserTile tile)
        { }

        public virtual void SetNullTarget()
        {
            _targetTransform = null;
        }

        public virtual void SetTarget(Transform target)
        {
            _targetTransform = target;
        }

        public void SetVelocity(Vector2 velocity)
        {
            _sprite.body._velocity = velocity;
        }

        public bool TryDefang(IDamageable target)
        {
            var chance = _weapon.GetChanceFromArray();
            var defang = _weapon.DefangChance;
            var owner = _weapon.Owner;
            var defanged = (owner.PLuck() * defang) > chance;
            if (!defanged)
                return false;

            var controller = target.GetGameObject()?.GetComponent<EnemyController>();
            if (controller != null)
            {
                return controller.DoDefang();
            }
            return false;
        }

        public bool TryFreeze(IDamageable target)
        {
            var chance = _weapon.GetChanceFromArray();
            var luck = _weapon.Owner.PLuck();
            var freezeChance = luck * _weapon.FreezeChance;
            if (freezeChance > chance)
            {
                var enemyCont = target.GetGameObject()?.GetComponent<EnemyController>();
                if (enemyCont != null)
                {
                    var duration = _weapon.PDuration();
                    if (!enemyCont.Freeze(duration, _weapon.FreezeChance))
                        return false;
                }

                if (!_weapon.HasActiveArcanaOfType(ArcanaType.T12_OUT_OF_TIME))
                    return false;

                var arcanaMan = _weapon.GameMan.ArcanaManager;
                if (enemyCont != null)
                {
                    arcanaMan.TriggerColdExplosion(enemyCont.transform.position);
                    return true;
                }
            }
            return false;
        }

        protected virtual Transform AimForRandomEnemy(bool rotate = true)
        {
            var randomEnemy = _weapon.GameMan.Stage.PickRandomEnemy(_weapon.Owner.RandomEnemyPickerGenerator);

            if (randomEnemy == null)
            {
                ApplyPlayerFacingVelocity(_weapon.Owner.LastMovementDirection.ToVector3(), rotate);
                return null;
            }

            ApplyInitialVelocity(randomEnemy, _cachedTransform, rotate);
            return randomEnemy;
        }

        protected virtual Transform AimForRandomEnemyInScreen(Rectangle? _rect = null)
        {
            if (_rect != null)
                return _weapon.GameMan.Stage.PickRandomEnemyInRectBounds(_rect, _weapon.Owner.RandomEnemyPickerGenerator);

            return _weapon.GameMan.Stage.PickRandomEnemyInScreenBounds(_weapon.Owner.RandomEnemyPickerGenerator);
        }

        // 0x0000000186E585C0-0x0000000186E585F0
        protected float AngleFromVelocityRadians(Vector2 velocity) => Mathf.Atan2(velocity.x, velocity.y);

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

        protected virtual Transform GetNearestEnemyTransform()
        {
            return GM.Core.Stage.FindClosestEnemy(_cachedTransform.position, excludeDead: true).EnemyRenderer.transform;
        }

        protected virtual void OnHasHitAnObject(IDamageable other)
        { }

        protected virtual void OnHasHitAnotherPlayerObject(IDamageable other)
        { }

        protected override void OnUpdate()
        {
            CheckIfVisibleOnScreen();
            if (_pauseWallChecksTimer > 0)
            {
                _pauseWallChecksTimer -= PauseSystem.DeltaTime;
            }
        }

        protected virtual float RotateTowardsEnemy()
        {
            var closest = GetNearestEnemyTransform();

            if (closest == null)
            {
                return PlayerFacingVelocityApplication(_weapon.Owner.LastMovementDirection.ToVector3(), true).GetValueOrDefault();
            }

            return InitialVelocityApplication(closest, this._cachedTransform, true, null).GetValueOrDefault();
        }

        protected Transform SetForNearestEnemy(ref Vector2 v)
        {
            var newDirection = new Vector2();
            var closest = GM.Core.Stage.FindClosestEnemy(_cachedTransform.position);

            if (closest != null)
            {
                var ownerPos = _weapon.Owner.position;
                var enemyBody = closest.body;
                if (enemyBody != null)
                {
                    var distanceX = enemyBody._position.x - ownerPos.x;
                    var distanceY = enemyBody._position.y - ownerPos.y;
                    newDirection = new Vector2(distanceX, distanceY).normalized;
                    v.x = ProjectileSpeed * newDirection.x;
                    v.y = ProjectileSpeed * newDirection.y;
                    return closest.transform;
                }
            }

            var lastFacing = _weapon.Owner.LastFacingDirection;
            newDirection = lastFacing.normalized;
            if (newDirection.x == 0 && newDirection.y == 0)
                newDirection.x = 1.0f;
            v.x = ProjectileSpeed * newDirection.x;
            v.y = ProjectileSpeed * newDirection.y;
            return null;
        }

        protected void SetScaleToArea(float multiplier = 1f /* Metadata: 0x01977977 */)
        {
            var one = Vector3.one;
            var area = _weapon.PArea();
            _cachedTransform.localScale = new Vector3((one.x * area) * multiplier, (one.y * area) * multiplier, (one.z * area) * multiplier);
        }

        protected Vector2 SetVelocityFromRotation(float rotation, float speed)
        {
            var vel = this.Velocity.ToFloat2();
            ArcadePhysics.Instance.velocityFromRotation(rotation, speed, ref vel);
            Velocity = vel;
            return vel;
        }

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
        }

        private float? InitialVelocityApplication(Transform target, Transform refTransform, bool rotate, Vector3? customFromPosition)
        {
            Vector3 initial = Vector3.zero;
            if (customFromPosition.HasValue)
                initial = customFromPosition.Value;
            else
                initial = refTransform.position;

            return SetInitialVelocity(rotate, new Vector2(target.position.x - initial.x, target.position.y - initial.y));
        }

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

        private float? PlayerFacingVelocityApplication(Vector3 playerDirection, bool rotate, bool inverse = false)
        {
            var normal = playerDirection.normalized;
            if (normal.x == 0.0f && normal.y == 0.0f)
                normal.x = 1.0f;
            if (inverse) normal.y *= -1.0f; normal.x *= -1.0f;
            Velocity = new float2(ProjectileSpeed * normal.x, ProjectileSpeed * normal.y);

            if (rotate)
            {
                var angle = Mathf.Atan2(normal.y, normal.x);
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                return angle;
            }
            return null;
        }

        private float? SetInitialVelocity(bool rotate, Vector2 difference)
        {
            Velocity = new Vector2(difference.x, difference.y).normalized;

            if (rotate)
            {
                var angle = Mathf.Atan2(difference.y, difference.x);
                var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = rotation;
                return angle;
            }
            return null;
        }
    }
}