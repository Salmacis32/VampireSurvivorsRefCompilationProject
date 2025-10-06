/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_RapidFireProjectile : Projectile // TypeDefIndex: 15487
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _timerEvent; // 0xD0
		private MultiTargetTween _hideTween; // 0xD8
		private float _save_vel_x; // 0xE0
		private float _save_vel_y; // 0xE4
		private Vector2 _aimVector; // 0xE8
		private float _bulletDeceleration; // 0xF0
		private TweenerCore<float, float, FloatOptions> _speedTween; // 0xF8
		protected Sprite cachedSprite; // 0x100
	
		// Constructors
		public FB_RapidFireProjectile() {} // 0x0000000186C30620-0x0000000186C306E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C2F4F0-0x0000000186C2F5E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C2F5E0-0x0000000186C301A0
		protected virtual Vector2 calDirection() => default; // 0x0000000186C301A0-0x0000000186C30200
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C30200-0x0000000186C30210
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C30210-0x0000000186C302F0
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186C302F0-0x0000000186C304C0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186C304C0-0x0000000186C30570
		public override void InternalUpdate() {} // 0x0000000186C30570-0x0000000186C305D0
		public override void Despawn() {} // 0x0000000186C305D0-0x0000000186C30620
	}
}
