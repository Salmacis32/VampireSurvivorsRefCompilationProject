/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_LongswordProjectile_SwallowSlice : Projectile // TypeDefIndex: 15801
	{
		// Fields
		[SerializeField]
		private ParticleSystem swallowSliceVFX; // 0xD0
	
		// Constructors
		public EME_LongswordProjectile_SwallowSlice() {} // 0x0000000186DC1380-0x0000000186DC13D0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DC0F70-0x0000000186DC1040
		public void SetDirection(Vector3 direction) {} // 0x0000000186DC1040-0x0000000186DC1260
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DC1260-0x0000000186DC1310
		private void DeactivateProjectile() {} // 0x0000000186DC1310-0x0000000186DC1380
	}
}
