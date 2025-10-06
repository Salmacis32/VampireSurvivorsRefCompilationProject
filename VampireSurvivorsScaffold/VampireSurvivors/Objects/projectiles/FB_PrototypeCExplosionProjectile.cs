/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_PrototypeCExplosionProjectile : Projectile // TypeDefIndex: 15486
	{
		// Fields
		private PhaserSprite _explosionSprite; // 0xD0
		private PhaserSprite _bombSprite; // 0xD8
		private MultiTargetTween _tweenPositionBomb; // 0xE0
		private MultiTargetTween _tweenAngleBomb; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _timerEvent; // 0xF0
	
		// Constructors
		public FB_PrototypeCExplosionProjectile() {} // 0x0000000186C2F4A0-0x0000000186C2F4F0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C2E730-0x0000000186C2F280
		public void explode() {} // 0x0000000186C2F280-0x0000000186C2F440
		public override void Despawn() {} // 0x0000000186C2F440-0x0000000186C2F4A0
	}
}
