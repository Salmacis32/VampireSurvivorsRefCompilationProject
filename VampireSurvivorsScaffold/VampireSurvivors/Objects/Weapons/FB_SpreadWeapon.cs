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
	public class FB_SpreadWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16255
	{
		// Constructors
		public FB_SpreadWeapon() {} // 0x0000000186F6E850-0x0000000186F6E8A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F70BB0-0x0000000186F70BE0
		public override void CheckArcanas() {} // 0x0000000186F73070-0x0000000186F73210
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BEB */) {} // 0x0000000186F7CFA0-0x0000000186F7D160
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		public override float PAmount() => default; // 0x0000000186F7D160-0x0000000186F7D1D0
		public void FireSalvo(Vector2 pos, Transform target = null, BulletPool pool = null) {} // 0x0000000186F7D1D0-0x0000000186F7D8C0
	}
}
