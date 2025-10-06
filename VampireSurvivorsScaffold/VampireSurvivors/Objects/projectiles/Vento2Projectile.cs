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
	public class Vento2Projectile : Projectile // TypeDefIndex: 15983
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
		public override float ProjectileSpeed { get => default; } // 0x0000000186E92840-0x0000000186E92920 
	
		// Constructors
		public Vento2Projectile() {} // 0x0000000186E941E0-0x0000000186E94230
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E92920-0x0000000186E93CE0
		public override void InternalUpdate() {} // 0x0000000186E93CE0-0x0000000186E94030
		public override void Despawn() {} // 0x0000000186E94030-0x0000000186E941E0
	}
}
