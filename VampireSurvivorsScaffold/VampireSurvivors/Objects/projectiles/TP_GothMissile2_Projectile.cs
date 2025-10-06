/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_GothMissile2_Projectile : Projectile // TypeDefIndex: 15573
	{
		// Fields
		private const float Radius = 12f; // Metadata: 0x019776F9
		private const float Speed = 4f; // Metadata: 0x019776FD
		private const float Scale = 2f; // Metadata: 0x01977701
		private bool _hasExploded; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfx; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		private PhaserSprite _missileSprite; // 0xF8
	
		// Constructors
		public TP_GothMissile2_Projectile() {} // 0x0000000186CB43B0-0x0000000186CB4400
	
		// Methods
		protected override void Awake() {} // 0x0000000186CB3090-0x0000000186CB3590
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CB3590-0x0000000186CB3780
		public override void InternalUpdate() {} // 0x0000000186CB3780-0x0000000186CB3930
		private void UpdatePfx() {} // 0x0000000186CB3780-0x0000000186CB3930
		public void SetAngle(float angleDeg) {} // 0x0000000186CB3930-0x0000000186CB3A00
		public override void Despawn() {} // 0x0000000186CB3A00-0x0000000186CB3A40
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CB3A40-0x0000000186CB3B30
		private void GenerateParticleSystem() {} // 0x0000000186CB3B30-0x0000000186CB43B0
	}
}
