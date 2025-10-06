/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Custos_Weapon : Weapon // TypeDefIndex: 16304
	{
		// Fields
		protected BulletPool _fireHeadPool; // 0x158
		protected BulletPool _iceHeadPool; // 0x160
		protected BulletPool _lightningHeadPool; // 0x168
		protected BulletPool _fireTrailPool; // 0x170
		protected BulletPool _iceTrailPool; // 0x178
		protected BulletPool _lightningTrailPool; // 0x180
		protected BulletPool _fireExplosionPool; // 0x188
		protected BulletPool _iceExplosionPool; // 0x190
		protected BulletPool _lightningExplosionPool; // 0x198
		protected BulletPool _fireFireballPool; // 0x1A0
		protected BulletPool _iceFireballPool; // 0x1A8
		protected BulletPool _lightningFireballPool; // 0x1B0
	
		// Constructors
		public TP_Custos_Weapon() {} // 0x0000000186F8EA60-0x0000000186F8EAB0
	
		// Methods
		public override float PArea() => default; // 0x0000000186F89CC0-0x0000000186F89D20
		protected void InitAllBulletPools() {} // 0x0000000186F9B600-0x0000000186F9BAF0
		protected BulletPool InitBulletPool(WeaponType weaponType) => default; // 0x0000000186F9BAF0-0x0000000186F9BD70
		protected BulletPool InitSecondaryBulletPool(WeaponType weaponType) => default; // 0x0000000186F9BD70-0x0000000186F9BFF0
		public virtual Projectile AddFireTrailAt(Vector2 pos) => default; // 0x0000000186F9BFF0-0x0000000186F9C110
		public virtual Projectile AddFireExplosionAt(Vector2 pos) => default; // 0x0000000186F9C110-0x0000000186F9C230
		public virtual Projectile AddIceTrailAt(Vector2 pos) => default; // 0x0000000186F9C230-0x0000000186F9C350
		public virtual Projectile AddIceExplosionAt(Vector2 pos) => default; // 0x0000000186F9C350-0x0000000186F9C470
		public virtual Projectile AddLightningTrailAt(Vector2 pos) => default; // 0x0000000186F9C470-0x0000000186F9C590
		public virtual Projectile AddLightningExplosionAt(Vector2 pos) => default; // 0x0000000186F9C590-0x0000000186F9C6B0
		public override bool LevelUp() => default; // 0x0000000186F9C6B0-0x0000000186F9C6D0
		public override void Cleanup() {} // 0x0000000186F9C6D0-0x0000000186F9C7A0
	}
}
