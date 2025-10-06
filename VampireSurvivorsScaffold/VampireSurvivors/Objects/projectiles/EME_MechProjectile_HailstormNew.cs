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
	public class EME_MechProjectile_HailstormNew : Projectile // TypeDefIndex: 15818
	{
		// Fields
		[SerializeField]
		private ParticleSystem _MissileVFX; // 0xD0
		[SerializeField]
		private TrailRenderer _Trail; // 0xD8
		private const float VFXScale = 0.75f; // Metadata: 0x019778B4
		private const float TrailDuration = 800f; // Metadata: 0x019778B8
		private const float AccelRate = 1.5f; // Metadata: 0x019778BC
		private const float BaseTurnSpeed = 425f; // Metadata: 0x019778C0
		private const float TurnSpeedModifier = 15f; // Metadata: 0x019778C4
		private const float InitialAngleModifier = 5f; // Metadata: 0x019778C8
		private const float MinTimeToExplode = 150f; // Metadata: 0x019778CC
		private const float MaxTimeToExplode = 250f; // Metadata: 0x019778D0
		private bool _isTurning; // 0xE0
		private float _currentTurnSpeed; // 0xE4
		private float _currentSpeed; // 0xE8
		private float _currentAngle; // 0xEC
		private float _scaledTurnSpeed; // 0xF0
		private float _cachedWeaponSpeed; // 0xF4
		private VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
	
		// Constructors
		public EME_MechProjectile_HailstormNew() {} // 0x0000000186DD2E40-0x0000000186DD2E90
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD1AD0-0x0000000186DD20D0
		public override void InternalUpdate() {} // 0x0000000186DD20D0-0x0000000186DD20E0
		private void UpdateVelocity() {} // 0x0000000186DD20E0-0x0000000186DD2360
		private void SetMovementPattern() {} // 0x0000000186DD2360-0x0000000186DD2490
		private void SetupTrail() {} // 0x0000000186DD2490-0x0000000186DD2900
		private void Explode() {} // 0x0000000186DD2900-0x0000000186DD2BB0
		private void PlaySfx() {} // 0x0000000186DD2BB0-0x0000000186DD2C90
		public override void Despawn() {} // 0x0000000186DD2C90-0x0000000186DD2DB0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD2DB0-0x0000000186DD2E40
	}
}
