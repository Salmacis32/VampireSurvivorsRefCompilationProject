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
	public class TP_Shield2_Meteor_Projectile : Projectile // TypeDefIndex: 15654
	{
		// Fields
		[SerializeField]
		private SpriteTrail spriteTrail; // 0xD0
		private MultiTargetTween _posTween; // 0xD8
		private SpriteAnimation _anim; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xE8
		private PhaserSprite _animatedSprite; // 0xF0
		private PhaserSprite _animatedSprite2; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private float radius; // 0x108
		private float _accelMul; // 0x10C
		private float maxDist; // 0x110
		private Vector2 initialVelocity; // 0x114
		private Tween accelTween; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x128
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x130
		private bool _isDespawning; // 0x138
		private bool _increaseAngle; // 0x139
		private float _intendedAngle; // 0x13C
		private MultiTargetTween _alphaTween; // 0x140
	
		// Constructors
		public TP_Shield2_Meteor_Projectile() {} // 0x0000000186D104E0-0x0000000186D10540
	
		// Methods
		protected override void Awake() {} // 0x0000000186D0EC70-0x0000000186D0F230
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D0F230-0x0000000186D0F590
		protected override void OnUpdate() {} // 0x0000000186D0F590-0x0000000186D0F6E0
		public void SetAngleVelocity(float _angle) {} // 0x0000000186D0F6E0-0x0000000186D10190
		private void Spinnn() {} // 0x0000000186D10190-0x0000000186D101A0
		private void StartDespawn() {} // 0x0000000186D101A0-0x0000000186D10440
		public override void Despawn() {} // 0x0000000186D10440-0x0000000186D104E0
	}
}
