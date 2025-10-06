/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MagicProjectile_VermillionSands : Projectile // TypeDefIndex: 15810
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
		private VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0x100
	
		// Constructors
		public EME_MagicProjectile_VermillionSands() {} // 0x0000000186DC8B80-0x0000000186DC8BD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC7AC0-0x0000000186DC7B60
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC7B60-0x0000000186DC8620
		private void GoToNearestEnemy() {} // 0x0000000186DC8620-0x0000000186DC8A30
		public override void Despawn() {} // 0x0000000186DC8A30-0x0000000186DC8AF0
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC8AF0-0x0000000186DC8B80
	}
}
