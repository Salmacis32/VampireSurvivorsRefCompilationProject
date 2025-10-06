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
	public class FB_PrototypeAWeapon : FB_FullAutoWeapon // TypeDefIndex: 16247
	{
		// Fields
		private BulletPool _planePool; // 0x178
		private BulletPool _planeBulletsPool; // 0x180
		private FB_PlaneProjectile[] planeProjectiles; // 0x188
	
		// Constructors
		public FB_PrototypeAWeapon() {} // 0x0000000186F795F0-0x0000000186F796D0
	
		// Methods
		public override void CheckArcanas() {} // 0x0000000186F77D70-0x0000000186F78220
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F78220-0x0000000186F78970
		public void startFiring(int planeIndex) {} // 0x0000000186F78970-0x0000000186F78B80
		public void stopFiring(int planeIndex) {} // 0x0000000186F78B80-0x0000000186F78BD0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE7 */) {} // 0x0000000186F78BD0-0x0000000186F79060
		public Projectile FireOnePlaneProjectile(Vector2 pos, int index, Transform target, BulletPool pool, FB_PlaneProjectile planeProjectile) => default; // 0x0000000186F79060-0x0000000186F79450
		public override void Cleanup() {} // 0x0000000186F79450-0x0000000186F794F0
		public override void SetVisible(bool visible) {} // 0x0000000186F794F0-0x0000000186F795F0
	}
}
