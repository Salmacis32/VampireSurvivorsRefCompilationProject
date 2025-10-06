/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MechProjectile : Projectile // TypeDefIndex: 15811
	{
		// Fields
		[SerializeField]
		private ParticleSystem _MissileVFX; // 0xD0
		[SerializeField]
		private TrailRenderer _Trail; // 0xD8
		private const float Radius = 12f; // Metadata: 0x01977874
		private const float DecelRate = 2f; // Metadata: 0x01977878
		private const float AccelRate = 5f; // Metadata: 0x0197787C
		private const float ArmingDuration = 500f; // Metadata: 0x01977880
		private const float VFXScale = 1f; // Metadata: 0x01977884
		private Vector2 _velocity; // 0xE0
		private Vector2 _cachedVelocity; // 0xE8
		private float _cachedWeaponSpeed; // 0xF0
		private bool _isDecelerating; // 0xF4
		private bool _isAccelerating; // 0xF5
		private bool _canExplode; // 0xF6
		private bool _explosionIsOnCooldown; // 0xF7
		private const float ExplosionCooldownDuration = 100f; // Metadata: 0x01977888
		private VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _explosionCooldownTimer; // 0x100
		private EME_Mech1Weapon _trueWeapon; // 0x108
	
		// Constructors
		public EME_MechProjectile() {} // 0x0000000186DCA0E0-0x0000000186DCA130
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC8DB0-0x0000000186DC9310
		public override void InternalUpdate() {} // 0x0000000186DC9310-0x0000000186DC9480
		protected virtual void SetupMovementPattern() {} // 0x0000000186DC9480-0x0000000186DC9740
		private void CaluclateInitialVelocity() {} // 0x0000000186DC9740-0x0000000186DC9820
		public void InvertVelocity() {} // 0x0000000186DC9820-0x0000000186DC9860
		public void MultiplyVelocity(float multiplier) {} // 0x0000000186DC9860-0x0000000186DC9890
		protected void UpdateVelocity() {} // 0x0000000186DC9890-0x0000000186DC9A00
		protected void SetupTrail() {} // 0x0000000186DC9A00-0x0000000186DC9B10
		protected void EnableTrail(bool enable) {} // 0x0000000186DC9B10-0x0000000186DC9C50
		private void PlaySfx() {} // 0x0000000186DC9C50-0x0000000186DC9D20
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DC9D20-0x0000000186DC9D30
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186DC9D30-0x0000000186DC9DB0
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186DC9DB0-0x0000000186DC9FB0
		public override void Despawn() {} // 0x0000000186DC9FB0-0x0000000186DCA0E0
	}
}
