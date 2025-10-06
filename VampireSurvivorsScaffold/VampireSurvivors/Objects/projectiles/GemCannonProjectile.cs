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
	public class GemCannonProjectile : Projectile // TypeDefIndex: 15886
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
	
		// Constructors
		public GemCannonProjectile() {} // 0x0000000186E25F60-0x0000000186E25FB0
	
		// Methods
		private void Start() {} // 0x0000000180B15170-0x0000000180B15180
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E25000-0x0000000186E25590
		public override void InternalUpdate() {} // 0x0000000186E25590-0x0000000186E25810
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E25810-0x0000000186E258A0
		private void GenerateParticleSystem() {} // 0x0000000186E258A0-0x0000000186E25F60
	}
}
