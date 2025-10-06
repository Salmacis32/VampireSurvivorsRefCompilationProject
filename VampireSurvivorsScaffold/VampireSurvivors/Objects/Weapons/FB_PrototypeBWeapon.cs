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
	public class FB_PrototypeBWeapon : FB_RapidFireWeapon // TypeDefIndex: 16248
	{
		// Fields
		private BulletPool _planePool; // 0x168
		private BulletPool _planeBulletsPool; // 0x170
		private int _planeProjectileAmount; // 0x178
		private FB_PlaneProjectile[] planeProjectiles; // 0x180
	
		// Constructors
		public FB_PrototypeBWeapon() {} // 0x0000000186F7AB30-0x0000000186F7AC20
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F797A0-0x0000000186F79EE0
		public override void CheckArcanas() {} // 0x0000000186F79EE0-0x0000000186F7A390
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE8 */) {} // 0x0000000186F7A390-0x0000000186F7A630
		public Projectile FireOnePlaneProjectile(Vector2 pos, int index, Transform target, BulletPool pool, FB_PlaneProjectile planeProjectile) => default; // 0x0000000186F7A630-0x0000000186F7A970
		public override void Cleanup() {} // 0x0000000186F7A970-0x0000000186F7A9C0
		public override void SetVisible(bool visible) {} // 0x0000000186F7A9C0-0x0000000186F7AB30
	}
}
