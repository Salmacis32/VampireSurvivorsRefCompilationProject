/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SpiritGem_Projectile : Projectile // TypeDefIndex: 15673
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
		private Pickup _objectToFollow; // 0xE0
	
		// Constructors
		public TP_SpiritGem_Projectile() {} // 0x0000000186D222D0-0x0000000186D22320
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D213B0-0x0000000186D21870
		public void Follow(Pickup objectToFollow) {} // 0x0000000186D21870-0x0000000186D21910
		public override void InternalUpdate() {} // 0x0000000186D21910-0x0000000186D21C10
		private void GenerateParticleSystem() {} // 0x0000000186D21C10-0x0000000186D222D0
	}
}
