/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MagicProjectile_ChaosDisaster : Projectile // TypeDefIndex: 15806
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
		private Transform target; // 0x100
		private PhaserSprite _darkBGSprite; // 0x108
		private MultiTargetTween _bgFadeTween; // 0x110
	
		// Constructors
		public EME_MagicProjectile_ChaosDisaster() {} // 0x0000000186DC44D0-0x0000000186DC4520
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC3660-0x0000000186DC3A30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC3A30-0x0000000186DC4170
		private void HitEnemies() {} // 0x0000000186DC4170-0x0000000186DC4470
		public override void Despawn() {} // 0x0000000186DC4470-0x0000000186DC44D0
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC3540-0x0000000186DC3570
	}
}
