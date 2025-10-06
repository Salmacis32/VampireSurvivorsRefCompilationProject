/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class ConeOfColdProjectile : Projectile // TypeDefIndex: 15414
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private ParticleEmitterManager _particleEmitterManager; // 0xD8
		private DG.Tweening.Sequence _scaleTween; // 0xE0
		private const float Radius = 16f; // Metadata: 0x01977616
		protected bool isPlayerFacing; // 0xE8
	
		// Constructors
		public ConeOfColdProjectile() {} // 0x0000000186BDB250-0x0000000186BDB2B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BDB2B0-0x0000000186BDB2E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BDB2E0-0x0000000186BDBD20
		public override void InternalUpdate() {} // 0x0000000186BDBD20-0x0000000186BDBED0
		private void AssignRandomColorToGroundFx() {} // 0x0000000186BDBED0-0x0000000186BDC120
		private void GenerateParticleSystems() {} // 0x0000000186BDC120-0x0000000186BDD190
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BDD190-0x0000000186BDD200
	}
}
