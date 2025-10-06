/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PistolProjectile_FalconFire : Projectile // TypeDefIndex: 15823
	{
		// Fields
		[SerializeField]
		private ParticleSystem boundingShotVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall boundingShotParticleEventCall; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xE8
		private EME_Pistol1Weapon _trueWeapon; // 0xF0
		private bool _hasExploded; // 0xF8
	
		// Constructors
		public EME_PistolProjectile_FalconFire() {} // 0x0000000186DD6260-0x0000000186DD62B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD5B30-0x0000000186DD5F80
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD5F80-0x0000000186DD61F0
		public override void Despawn() {} // 0x0000000186DD61F0-0x0000000186DD6260
	}
}
