/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Elevator_Projectile : Projectile // TypeDefIndex: 15563
	{
		// Fields
		private PhaserSprite _elevatorSprite; // 0xD0
		private PhaserSprite _weightSprite; // 0xD8
		private bool _isDespawning; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xF0
		private List<string> FrameNames_Elevators; // 0xF8
		private List<string> FrameNames_Weights; // 0x100
		private int repeats; // 0x108
		private float tripDuration; // 0x10C
		private int completedTrips; // 0x110
		private int directionMultiplier; // 0x114
		private bool isElevator; // 0x118
		private int _isRight; // 0x11C
		private MultiTargetTween _scaleTween; // 0x120
		private float initialPosX; // 0x128
		private float _speedMultiplier; // 0x12C
		private Tween yoyoTween; // 0x130
		private float _currentProjectileSpeed; // 0x138
		private DG.Tweening.Sequence _yoyoSequence; // 0x140
		private Tween accelTween; // 0x148
	
		// Constructors
		public TP_Elevator_Projectile() {} // 0x0000000186CA2CF0-0x0000000186CA3690
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA1630-0x0000000186CA19C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA19C0-0x0000000186CA1A00
		public override void SetTarget(Transform target) {} // 0x0000000186CA1A00-0x0000000186CA28D0
		private void StartDespawn() {} // 0x0000000186CA28D0-0x0000000186CA2C00
		public override void Despawn() {} // 0x0000000186CA2C00-0x0000000186CA2CB0
		private void LateUpdate() {} // 0x0000000186CA2CB0-0x0000000186CA2CF0
	}
}
