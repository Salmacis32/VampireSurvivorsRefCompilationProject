/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VentoProjectile : Projectile // TypeDefIndex: 15984
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private readonly uint[] _color; // 0xE0
		private SpriteAnimation _anims; // 0xE8
		private float prevArea; // 0xF0
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186E94230-0x0000000186E94310 
	
		// Constructors
		public VentoProjectile() {} // 0x0000000186E95180-0x0000000186E95270
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E94310-0x0000000186E95180
	}
}
