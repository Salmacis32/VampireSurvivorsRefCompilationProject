/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HatProjectile : Projectile // TypeDefIndex: 15447
	{
		// Fields
		[NonSerialized]
		public float2 PosOffset; // 0xD0
		private List<HatType> _hatTypes; // 0xD8
		public float Acceleration; // 0xE0
		private float _accelerationOffset; // 0xE4
		private Vector2 _velocity; // 0xE8
		private MultiTargetTween _accelTween; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private bool _followOwner; // 0x100
		private HatWeapon _trueWeapon; // 0x108
		private HatType _hatType; // 0x110
		private int _moveDownCount; // 0x114
		private VampireSurvivors.Framework.TimerSystem.Timer _triggerTimer; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _accelTimer; // 0x120
		private MultiTargetTween _moveTween; // 0x128
		private float _hatLayerOffset; // 0x130
		private bool _shouldSpin; // 0x134
	
		// Constructors
		public HatProjectile() {} // 0x0000000186C08530-0x0000000186C08950
	
		// Methods
		protected override void Awake() {} // 0x0000000186BDE960-0x0000000186BDE980
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C061C0-0x0000000186C068D0
		private void setHatStats() {} // 0x0000000186C068D0-0x0000000186C07090
		private void triggerHat() {} // 0x0000000186C07090-0x0000000186C07110
		private void moveHatDown() {} // 0x0000000186C07110-0x0000000186C07140
		private void FireHat() {} // 0x0000000186C07140-0x0000000186C07BC0
		public override void InternalUpdate() {} // 0x0000000186C07BC0-0x0000000186C07D70
		private void LateUpdate() {} // 0x0000000186C07D70-0x0000000186C07FD0
		public override void Despawn() {} // 0x0000000186C07FD0-0x0000000186C08070
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186C08070-0x0000000186C08170
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C08170-0x0000000186C08210
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186C08210-0x0000000186C082B0
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186C082B0-0x0000000186C08530
	}
}
