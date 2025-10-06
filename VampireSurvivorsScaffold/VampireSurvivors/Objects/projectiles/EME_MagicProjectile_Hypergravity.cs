/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MagicProjectile_Hypergravity : Projectile // TypeDefIndex: 15808
	{
		// Fields
		[SerializeField]
		protected ParticleSystem _particleSystem; // 0xD0
		private MultiTargetTween _despawnTween; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE8
		private MultiTargetTween _moveTween; // 0xF0
		private Transform target; // 0xF8
	
		// Constructors
		public EME_MagicProjectile_Hypergravity() {} // 0x0000000186DC65A0-0x0000000186DC65F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC5710-0x0000000186DC57B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC57B0-0x0000000186DC5DB0
		private void FadeOut() {} // 0x0000000186DC5DB0-0x0000000186DC6050
		private void HitEnemies() {} // 0x0000000186DC6050-0x0000000186DC63B0
		private void LateUpdate() {} // 0x0000000186C974B0-0x0000000186C974F0
		public override void Despawn() {} // 0x0000000186DC63B0-0x0000000186DC64B0
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC64B0-0x0000000186DC65A0
	}
}
