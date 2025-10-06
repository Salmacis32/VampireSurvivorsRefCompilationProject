/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_HomingAltWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16236
	{
		// Fields
		private IDamageable _targetDamagable; // 0x160
	
		// Constructors
		public FB_HomingAltWeapon() {} // 0x0000000186F6E850-0x0000000186F6E8A0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F59EB0-0x0000000186F59EC0
		public override void InternalUpdate() {} // 0x0000000186F73C10-0x0000000186F744C0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F744C0-0x0000000186F746D0
		private void UpdateTargeting() {} // 0x0000000186F746D0-0x0000000186F74C00
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE5 */) {} // 0x0000000186F74C00-0x0000000186F74C20
	}
}
