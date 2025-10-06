/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_SpearProjectile_Stardust : Projectile // TypeDefIndex: 15843
	{
		// Fields
		[SerializeField]
		protected SpriteRenderer _SpearSprite; // 0xD0
		[SerializeField]
		private TrailRenderer _LineTrail; // 0xD8
		[SerializeField]
		private TrailRenderer _vfxTrail; // 0xE0
		private const float Radius = 90f; // Metadata: 0x019778EA
		private const float ScaleMultiplier = 0.15f; // Metadata: 0x019778EE
		private string _spearSpriteName; // 0xE8
		private float _area; // 0xF0
		private MultiTargetTween _fadeTween; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
		private PhaserSprite _portalSprite; // 0x108
		private MultiTargetTween _portalTween; // 0x110
		private ParticleEmitterManager _pfxManager; // 0x118
		private ParticleSystem _pfx; // 0x120
	
		// Constructors
		public EME_SpearProjectile_Stardust() {} // 0x0000000186DE94E0-0x0000000186DE9530
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE6F90-0x0000000186DE7330
		public override void InternalUpdate() {} // 0x0000000186DE7330-0x0000000186DE7500
		private void UpdateParticles() {} // 0x0000000186DE7330-0x0000000186DE7500
		private void SetupTrail() {} // 0x0000000186DE7500-0x0000000186DE7A30
		private void SetupSpearSprite() {} // 0x0000000186DE7A30-0x0000000186DE7BF0
		protected virtual string GetSpearSpriteName(WeaponType weapon = WeaponType.VOID /* Metadata: 0x019778E9 */) => default; // 0x0000000186DE7BF0-0x0000000186DE7C80
		private void DoSpearFadeIn() {} // 0x0000000186DE7C80-0x0000000186DE7F80
		private void DoPortalVfx() {} // 0x0000000186DE7F80-0x0000000186DE8510
		private void GenerateParticleSystem() {} // 0x0000000186DE8510-0x0000000186DE8E50
		private void PlaySfx() {} // 0x0000000186DE8E50-0x0000000186DE8F30
		public void PlaySfxLong() {} // 0x0000000186DE8F30-0x0000000186DE9020
		private void StartDespawn() {} // 0x0000000186DE9020-0x0000000186DE9330
		private void WaitBeforeDespawn() {} // 0x0000000186DE9330-0x0000000186DE9430
		public override void Despawn() {} // 0x0000000186DE9430-0x0000000186DE94E0
	}
}
