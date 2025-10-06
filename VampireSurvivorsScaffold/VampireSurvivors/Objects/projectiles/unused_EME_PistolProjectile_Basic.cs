/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class unused_EME_PistolProjectile_Basic : Projectile // TypeDefIndex: 15851
	{
		// Fields
		[SerializeField]
		private ParticleSystem pistolBasicVFX; // 0xD0
		[SerializeField]
		private ParticleSystem pistolTargetingVFX; // 0xD8
		[SerializeField]
		private ParticleEventCall pistolBasicParticleEventCall; // 0xE0
		[SerializeField]
		private ParticleEventCall pistolTargetingParticleEventCall; // 0xE8
		private const float MAX_HOMING_ANGLE_CHANGE_PER_SECOND = 360f; // Metadata: 0x019778F3
		private bool _projectileLaunched; // 0xF0
		private float penetrationAmount; // 0xF4
		protected EnemyController _targetEnemyController; // 0xF8
		private SpriteAnimation _anims; // 0x100
		private bool _useHoming; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _prefireTimer; // 0x110
	
		// Constructors
		public unused_EME_PistolProjectile_Basic() {} // 0x0000000186DF15C0-0x0000000186DF1620
	
		// Methods
		protected override void Awake() {} // 0x0000000186DEF7D0-0x0000000186DEF870
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DEF870-0x0000000186DEFC20
		private void SetupMechanics() {} // 0x0000000186DEFC20-0x0000000186DEFE20
		private void SetupVisuals() {} // 0x0000000186DEFE20-0x0000000186DEFF80
		public void EnableProjectileLaunch() {} // 0x0000000186DEFF80-0x0000000186DF0150
		private void ApplyInitialVelocity(Vector2 targetPosition, Transform playerTransform, bool rotate = true /* Metadata: 0x019778F2 */, Vector3? customFromPosition = default) {} // 0x0000000186DF0150-0x0000000186DF0470
		public override void Despawn() {} // 0x0000000186DF0470-0x0000000186DF0500
		private void DespawnAfterParticlesStopped() {} // 0x0000000186C60D40-0x0000000186C60D50
		private void FinishDespawn() {} // 0x0000000186C60D40-0x0000000186C60D50
		private Vector2 GetLeadAimPosition(Vector2 firePosition, Vector2 targetPosition, Vector2 targetVelocity) => default; // 0x0000000186DF0500-0x0000000186DF0700
		private void SetProjectileVelocity(Vector2 projectileDirection, bool rotate) {} // 0x0000000186DF0700-0x0000000186DF08F0
		public override void InternalUpdate() {} // 0x0000000186DF08F0-0x0000000186DF1010
		private static void FireDirectlyAtTarget(Vector2 targetPosition, Vector2 playerPosition, ref Vector2 projectileDirection) {} // 0x0000000186DF1010-0x0000000186DF1050
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DF1050-0x0000000186DF1290
		private static EnemyController GetRandomEnemyControllerOnScreen(Rectangle _rect) => default; // 0x0000000186DF1290-0x0000000186DF15C0
	}
}
