/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PistolProjectile_FalconFireExplosion : Projectile // TypeDefIndex: 15824
	{
		// Fields
		[SerializeField]
		private ParticleSystem explosionVFX; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _damageTimer; // 0xE0
	
		// Constructors
		public EME_PistolProjectile_FalconFireExplosion() {} // 0x0000000186DD66B0-0x0000000186DD6700
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD62B0-0x0000000186DD66B0
		public void StopDamage() {} // 0x0000000186DD5A40-0x0000000186DD5A70
		public override void Despawn() {} // 0x0000000186DD5A70-0x0000000186DD5AE0
	}
}
