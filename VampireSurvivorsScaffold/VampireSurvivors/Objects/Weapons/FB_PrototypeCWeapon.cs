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
	public class FB_PrototypeCWeapon : FB_SpreadWeapon // TypeDefIndex: 16249
	{
		// Fields
		private BulletPool _planePool; // 0x160
		private BulletPool _planeBulletsPool; // 0x168
		private int _planeProjectileAmount; // 0x170
		private FB_PlaneProjectile[] planeProjectiles; // 0x178
	
		// Constructors
		public FB_PrototypeCWeapon() {} // 0x0000000186F7C1B0-0x0000000186F7C290
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F7AC20-0x0000000186F7B360
		public override void CheckArcanas() {} // 0x0000000186F7B360-0x0000000186F7B810
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE9 */) {} // 0x0000000186F7B810-0x0000000186F7BB10
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F7BB10-0x0000000186F7BD50
		public Projectile FireOnePlaneProjectile(Vector2 pos, int index, Transform target, BulletPool pool, FB_PlaneProjectile planeProjectile) => default; // 0x0000000186F7BD50-0x0000000186F7C010
		public override void Cleanup() {} // 0x0000000186F7C010-0x0000000186F7C040
		public override void SetVisible(bool visible) {} // 0x0000000186F7C040-0x0000000186F7C1B0
	}
}
