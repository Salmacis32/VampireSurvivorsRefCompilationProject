/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_GothMissile_Projectile : Projectile // TypeDefIndex: 15575
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private Vector2 _direction; // 0xF0
	
		// Constructors
		public TP_GothMissile_Projectile() {} // 0x0000000186CB8680-0x0000000186CB86E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CB7790-0x0000000186CB7CF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CB7CF0-0x0000000186CB7F50
		public void SetDirection(Vector2 dir) {} // 0x0000000186CB7F50-0x0000000186CB7FB0
		private void OnShotFired() {} // 0x0000000186CB7FB0-0x0000000186CB85F0
		public override void Despawn() {} // 0x0000000186CB85F0-0x0000000186CB8680
	}
}
