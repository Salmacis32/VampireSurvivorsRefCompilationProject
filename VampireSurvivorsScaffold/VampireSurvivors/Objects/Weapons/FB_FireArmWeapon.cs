/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_FireArmWeapon : Weapon // TypeDefIndex: 16229
	{
		// Constructors
		public FB_FireArmWeapon() {} // 0x0000000186F710F0-0x0000000186F711D0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F70BB0-0x0000000186F70BE0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE2 */) {} // 0x0000000186F70BE0-0x0000000186F70D10
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F70D10-0x0000000186F70E50
		public override void CheckArcanas() {} // 0x0000000186F70E50-0x0000000186F71030
		public override void SetVisible(bool visible) {} // 0x0000000186F71030-0x0000000186F710F0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
