/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MagicProjectile_AquaSphere : Projectile // TypeDefIndex: 15805
	{
		// Fields
		[SerializeField]
		protected ParticleSystem _particleSystem; // 0xD0
		[SerializeField]
		protected ParticleEventCall _particleEventCall; // 0xD8
		private MultiTargetTween _despawnTween; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xF0
		private MultiTargetTween _moveTween; // 0xF8
		private Tween _angleTween; // 0x100
		private Tween _scaleTween; // 0x108
		private float _saveVelX; // 0x110
		private float _saveVelY; // 0x114
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0x118
		private bool _canBounce; // 0x120
	
		// Constructors
		public EME_MagicProjectile_AquaSphere() {} // 0x0000000186DC3570-0x0000000186DC35C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC2710-0x0000000186DC28B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC28B0-0x0000000186DC30F0
		public override void InternalUpdate() {} // 0x0000000186DC30F0-0x0000000186DC3150
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DC3150-0x0000000186DC33B0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186DC33B0-0x0000000186DC3490
		private void Bounce(Body bdy, bool up, bool down, bool left, bool right) {} // 0x0000000186DC3490-0x0000000186DC34F0
		public override void Despawn() {} // 0x0000000186DC34F0-0x0000000186DC3540
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC3540-0x0000000186DC3570
	}
}
