/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_StarFlail1_Projectile : Projectile // TypeDefIndex: 15685
	{
		// Fields
		[SerializeField]
		private TrailRenderer _afterImageTrail; // 0xD0
		private float _angleTime; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _swingTimer; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private float _multiplier; // 0xF8
		private Projectile _swipeBody; // 0x100
		private float2 _playerOffset; // 0x108
		private int _flipNum; // 0x110
		private bool _isFlipped; // 0x114
		private bool _isMoving; // 0x115
		private float _attackDistance; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _starCreationTimer; // 0x120
		private float _swingTime; // 0x128
	
		// Constructors
		public TP_StarFlail1_Projectile() {} // 0x0000000186D2EE00-0x0000000186D2EE60
	
		// Methods
		protected override void Awake() {} // 0x0000000186D2DAE0-0x0000000186D2DB80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D2DB80-0x0000000186D2E490
		public override void InternalUpdate() {} // 0x0000000186D2E490-0x0000000186D2E510
		private void updateAttackAngle(float attackAngle) {} // 0x0000000186D2E510-0x0000000186D2E770
		private void LandHit() {} // 0x0000000186D2E770-0x0000000186D2EA30
		private void CreateStar() {} // 0x0000000186D2EA30-0x0000000186D2EC60
		public override void Despawn() {} // 0x0000000186D2EC60-0x0000000186D2EE00
	}
}
