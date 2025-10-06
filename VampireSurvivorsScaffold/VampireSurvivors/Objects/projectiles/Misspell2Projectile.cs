/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Misspell2Projectile : Projectile // TypeDefIndex: 15928
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private ParticleEmitterManager _particleEmitterManager; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private const float Radius = 16f; // Metadata: 0x01977968
		public bool isPlayerFacing; // 0xE8
		private bool _hasExploded; // 0xE9
	
		// Constructors
		public Misspell2Projectile() {} // 0x0000000186E4CED0-0x0000000186E4CF30
	
		// Methods
		protected override void Awake() {} // 0x0000000186E4B190-0x0000000186E4B1C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E4B1C0-0x0000000186E4BBB0
		public override void InternalUpdate() {} // 0x0000000186E4BBB0-0x0000000186E4BD60
		private void AssignRandomColorToGroundFx() {} // 0x0000000186E4BD60-0x0000000186E4BFB0
		private void GenerateParticleSystems() {} // 0x0000000186E4BFB0-0x0000000186E4CDC0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E4CDC0-0x0000000186E4CED0
	}
}
