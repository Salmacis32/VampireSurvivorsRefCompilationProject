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
	public class EME_MagicProjectile_Sunlight : Projectile // TypeDefIndex: 15809
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
		private EME_SpiritRings1Weapon _trueWeapon; // 0x100
	
		// Constructors
		public EME_MagicProjectile_Sunlight() {} // 0x0000000186DC78E0-0x0000000186DC7930
	
		// Methods
		protected override void Awake() {} // 0x0000000186DC6610-0x0000000186DC66B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC66B0-0x0000000186DC7390
		private void GoToNearestEnemy() {} // 0x0000000186DC7390-0x0000000186DC7850
		public override void Despawn() {} // 0x0000000186DC7850-0x0000000186DC78A0
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DC78A0-0x0000000186DC78E0
	}
}
