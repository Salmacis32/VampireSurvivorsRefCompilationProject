/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EnemyWeapon // TypeDefIndex: 16115
	{
		// Fields
		public EnemyProjectile _projectilePrefab; // 0x10
		private EnemyBulletPool _projectilePool; // 0x18
	
		// Constructors
		public EnemyWeapon() {} // Dummy constructor
		public EnemyWeapon(EnemyProjectile projectilePrefab) {} // 0x0000000186F11A20-0x0000000186F120B0
	
		// Methods
		public void Fire(float2 position) {} // 0x0000000186F120B0-0x0000000186F12260
		private bool OnPlayerOverlapsEnemyBullet(CallbackContext context, ArcadeColliderType first, ArcadeColliderType second) => default; // 0x0000000186F12260-0x0000000186F12360
		protected virtual bool OnBulletOverlapsWall(CallbackContext context, ArcadeColliderType bullet, ArcadeColliderType tile) => default; // 0x0000000186F12360-0x0000000186F12470
	}
}
