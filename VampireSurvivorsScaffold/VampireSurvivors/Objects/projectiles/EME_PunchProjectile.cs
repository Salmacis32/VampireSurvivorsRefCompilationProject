/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PunchProjectile : Projectile // TypeDefIndex: 15825
	{
		// Fields
		[SerializeField]
		private SpriteRenderer groundVFX; // 0xD0
		[SerializeField]
		private ParticleSystem punchVFX; // 0xD8
		[SerializeField]
		private ParticleSystem dustVFX; // 0xE0
		[SerializeField]
		private ParticleEventCall dustVFXparticleEventCall; // 0xE8
		[SerializeField]
		private float Radius; // 0xF0
		private const float FRONT_OFFSET = 30f; // Metadata: 0x019778D4
		private bool flipVerticalVFX; // 0xF4
		private Vector3 _punchScale; // 0xF8
		private Vector3 _dustScale; // 0x104
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
		private float _totalTime; // 0x120
		private float _elapsedTime; // 0x124
		private bool _showVFX; // 0x128
		private bool _hasExploded; // 0x129
		private bool _cachedFlipX; // 0x12A
	
		// Constructors
		public EME_PunchProjectile() {} // 0x0000000186DD8040-0x0000000186DD80B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DD6700-0x0000000186DD68C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD68C0-0x0000000186DD6D90
		public override void InternalUpdate() {} // 0x0000000186DD6D90-0x0000000186DD7150
		private void SetupMechanics() {} // 0x0000000186DD7150-0x0000000186DD7280
		private void SetupTimers() {} // 0x0000000186DD7280-0x0000000186DD73C0
		private void SetupVFX() {} // 0x0000000186DD73C0-0x0000000186DD79C0
		public void PlayPunch() {} // 0x0000000186DD79C0-0x0000000186DD7DE0
		public void SetFlipDirection(bool flip) {} // 0x0000000184EB8720-0x0000000184EB8730
		public void EnableGroundVFX() {} // 0x0000000186DD7DE0-0x0000000186DD7E10
		public override void Despawn() {} // 0x0000000186DD7E10-0x0000000186DD7EE0
		private void DespawnAfterParticlesStopped() {} // 0x0000000186DD7EE0-0x0000000186DD7F30
		private void FinishDespawn() {} // 0x0000000186DD7EE0-0x0000000186DD7F30
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD7F30-0x0000000186DD8040
	}
}
