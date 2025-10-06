/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Vento2ExtraProjectile : Projectile // TypeDefIndex: 15982
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private SpriteAnimation _anims; // 0xE0
		private PhaserSprite _ghost1; // 0xE8
		private PhaserSprite _ghost2; // 0xF0
		private float _previousPArea; // 0xF8
		private float _previousPDuration; // 0xFC
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186E91100-0x0000000186E911E0 
	
		// Constructors
		public Vento2ExtraProjectile() {} // 0x0000000186E927D0-0x0000000186E92840
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E911E0-0x0000000186E92330
		public override void InternalUpdate() {} // 0x0000000186E92330-0x0000000186E92620
		public override void Despawn() {} // 0x0000000186E92620-0x0000000186E927D0
	}
}
