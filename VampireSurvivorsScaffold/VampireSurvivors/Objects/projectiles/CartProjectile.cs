/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class CartProjectile : Projectile // TypeDefIndex: 15408
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private float _defaultSpeed; // 0xD8
	
		// Constructors
		public CartProjectile() {} // 0x0000000186BCE9F0-0x0000000186BCEA40
	
		// Methods
		protected override void Awake() {} // 0x0000000186BCD7F0-0x0000000186BCD820
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BCD820-0x0000000186BCDF90
		public override void InternalUpdate() {} // 0x0000000186BCDF90-0x0000000186BCE2E0
		private void SetDepths() {} // 0x0000000186BCE2E0-0x0000000186BCE470
		private void GeneratePfx() {} // 0x0000000186BCE470-0x0000000186BCE9F0
	}
}
