/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MirageRobe2Projectile : MirageRobeProjectile // TypeDefIndex: 15926
	{
		// Fields
		private SpriteAnimation _spriteAnimation; // 0xF8
		private Color[][] _tints; // 0x100
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186E49860-0x0000000186E49920 
	
		// Constructors
		public MirageRobe2Projectile() {} // 0x0000000186E4A4D0-0x0000000186E4A790
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E49920-0x0000000186E4A270
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E4A270-0x0000000186E4A4D0
	}
}
