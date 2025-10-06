/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Shield1_Blade_Projectile : Projectile // TypeDefIndex: 15651
	{
		// Fields
		private MultiTargetTween _posTween; // 0xD0
		private SpriteAnimation _anim; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xE0
		private PhaserSprite _animatedSprite; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private float radius; // 0xF8
		private float _accelMul; // 0xFC
		private float maxDist; // 0x100
		private Vector2 initialVelocity; // 0x104
		private Tween accelTween; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x120
		private bool _isDespawning; // 0x128
	
		// Constructors
		public TP_Shield1_Blade_Projectile() {} // 0x0000000186D0C7A0-0x0000000186D0C800
	
		// Methods
		protected override void Awake() {} // 0x0000000186D0B7D0-0x0000000186D0BBE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D0BBE0-0x0000000186D0BD40
		public void SetAngleVelocity(float angle) {} // 0x0000000186D0BD40-0x0000000186D0C420
		private void StartDespawn() {} // 0x0000000186D0C420-0x0000000186D0C6C0
		private void LateUpdate() {} // 0x0000000186D0C6C0-0x0000000186D0C710
		public override void Despawn() {} // 0x0000000186D0C710-0x0000000186D0C7A0
	}
}
