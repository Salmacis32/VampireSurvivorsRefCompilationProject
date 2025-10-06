/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Acid2_Projectile : Projectile // TypeDefIndex: 15493
	{
		// Fields
		private PhaserSprite _animatedSprite; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private float _radius; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private float _IndexOffsetScaleFactor; // 0xF0
		private MultiTargetTween _alphaTween; // 0xF8
	
		// Constructors
		public TP_Acid2_Projectile() {} // 0x0000000186C36880-0x0000000186C368F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C354E0-0x0000000186C35D40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C35D40-0x0000000186C36510
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C36510-0x0000000186C36580
		private void StartDespawn() {} // 0x0000000186C36580-0x0000000186C36820
		public override void Despawn() {} // 0x0000000186C36820-0x0000000186C36880
	}
}
