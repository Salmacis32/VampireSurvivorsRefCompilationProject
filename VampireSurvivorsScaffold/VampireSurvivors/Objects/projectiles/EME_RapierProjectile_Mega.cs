/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_RapierProjectile_Mega : Projectile // TypeDefIndex: 15836
	{
		// Fields
		private ParticleEmitterManager _pfxEmitterManager; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
		private bool _initialisedParticles; // 0xE0
		private EME_RapierWeapon _trueWeapon; // 0xE8
	
		// Constructors
		public EME_RapierProjectile_Mega() {} // 0x0000000186DE0BC0-0x0000000186DE0C10
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE0460-0x0000000186DE05D0
		public override void SetNullTarget() {} // 0x0000000186BB8730-0x0000000186BB8750
		public override void SetTarget(Transform target) {} // 0x0000000186DE05D0-0x0000000186DE0B30
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DE0B30-0x0000000186DE0BC0
	}
}
