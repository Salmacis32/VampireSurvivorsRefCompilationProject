/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HellfireProjectile : Projectile // TypeDefIndex: 15896
	{
		// Fields
		private ParticleSystem _pfx; // 0xD0
		private Tween _scaleTween; // 0xD8
	
		// Constructors
		public HellfireProjectile() {} // 0x0000000186E2EF50-0x0000000186E2EFA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E2D730-0x0000000186E2D750
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E2D750-0x0000000186E2DDF0
		public override void SetTarget(Transform target) {} // 0x0000000186E2DDF0-0x0000000186E2E470
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186E2E470-0x0000000186E2E710
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E2E710-0x0000000186E2E7B0
		private void SetDepth() {} // 0x0000000186E2E7B0-0x0000000186E2E920
		public override void Despawn() {} // 0x0000000186E2E920-0x0000000186E2E980
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E2E980-0x0000000186E2EA70
		private void GenerateParticleSystem() {} // 0x0000000186E2EA70-0x0000000186E2EF50
	}
}
