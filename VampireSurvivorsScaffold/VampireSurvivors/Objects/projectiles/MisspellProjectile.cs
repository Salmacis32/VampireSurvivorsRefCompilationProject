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
	public class MisspellProjectile : Projectile // TypeDefIndex: 15929
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private ParticleEmitterManager _particleEmitterManager; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private const float Radius = 16f; // Metadata: 0x0197796C
		public bool isPlayerFacing; // 0xE8
		private bool _hasExploded; // 0xE9
	
		// Constructors
		public MisspellProjectile() {} // 0x0000000186E4EC70-0x0000000186E4ECD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E4CF30-0x0000000186E4CF60
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E4CF60-0x0000000186E4D960
		public override void InternalUpdate() {} // 0x0000000186E4D960-0x0000000186E4DB10
		private void AssignRandomColorToGroundFx() {} // 0x0000000186E4DB10-0x0000000186E4DD60
		private void GenerateParticleSystems() {} // 0x0000000186E4DD60-0x0000000186E4EB60
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E4EB60-0x0000000186E4EC70
	}
}
