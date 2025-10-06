/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Ex_Ammo1Projectile : Projectile // TypeDefIndex: 15858
	{
		// Fields
		[SerializeField]
		private SpriteRenderer mainVisuals; // 0xD0
		[SerializeField]
		private SpriteTrail trail; // 0xD8
		private float _hitboxSize; // 0xE0
		private const float MAX_HOMING_ANGLE_CHANGE_PER_SECOND = 360f; // Metadata: 0x019778F8
		private float penetrationAmount; // 0xE4
		protected EnemyController _targetEnemyController; // 0xE8
		private SpriteAnimation _anims; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _prefireTimer; // 0xF8
		private Bounds _camBounds; // 0x100
		private Ex_Ammo1Weapon trueWeapon; // 0x118
		private bool _isMirrored; // 0x120
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186DF4110-0x0000000186DF4210 
	
		// Constructors
		public Ex_Ammo1Projectile() {} // 0x0000000186DF54C0-0x0000000186DF5520
	
		// Methods
		protected override void Awake() {} // 0x0000000186DF4210-0x0000000186DF42B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DF42B0-0x0000000186DF46A0
		private EnemyController FindTargetEnemy() => default; // 0x0000000186DF46A0-0x0000000186DF47C0
		private void SetupMechanics() {} // 0x0000000186DF47C0-0x0000000186DF4AE0
		private void ApplyInitialVelocity(Vector2 targetPosition, Vector2 firePosition, bool rotate = true /* Metadata: 0x019778F7 */, Vector3? customFromPosition = default) {} // 0x0000000186DF4AE0-0x0000000186DF4D80
		public override void Despawn() {} // 0x0000000186DF4D80-0x0000000186DF4E20
		private Vector2 GetLeadAimPosition(Vector2 firePosition, Vector2 targetPosition, Vector2 targetVelocity) => default; // 0x0000000186DF0500-0x0000000186DF0700
		private void SetProjectileVelocity(Vector2 projectileDirection, bool rotate) {} // 0x0000000186DF0700-0x0000000186DF08F0
		public override void InternalUpdate() {} // 0x0000000186DF4E20-0x0000000186DF5320
		private static void FireDirectlyAtTarget(Vector2 targetPosition, Vector2 playerPosition, ref Vector2 projectileDirection) {} // 0x0000000186DF1010-0x0000000186DF1050
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DF5320-0x0000000186DF54C0
	}
}
