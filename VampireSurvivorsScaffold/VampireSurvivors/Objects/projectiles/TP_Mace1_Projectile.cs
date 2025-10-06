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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Mace1_Projectile : Projectile // TypeDefIndex: 15618
	{
		// Fields
		[SerializeField]
		private TrailRenderer _afterImageTrail; // 0xD0
		private float _angleTime; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _swingTimer; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private float _multiplier; // 0xF0
		private List<List<Projectile>> _swipeBodies; // 0xF8
		private float2 _playerOffset; // 0x100
		private int _flipNum; // 0x108
		private float _extraDistTotal; // 0x10C
		private float _extraDistSpacing; // 0x110
		private bool _isMoving; // 0x114
	
		// Constructors
		public TP_Mace1_Projectile() {} // 0x0000000186CE7A30-0x0000000186CE7B20
	
		// Methods
		protected override void Awake() {} // 0x0000000186CE6230-0x0000000186CE6330
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CE6330-0x0000000186CE6B40
		public override void InternalUpdate() {} // 0x0000000186CE6B40-0x0000000186CE6C10
		private void updateAttackAngle(float attackAngle) {} // 0x0000000186CE6C10-0x0000000186CE7020
		private void LandHit() {} // 0x0000000186CE7020-0x0000000186CE7330
		public override void Despawn() {} // 0x0000000186CE7330-0x0000000186CE7500
		private void SetupTrails(TrailRenderer _trail) {} // 0x0000000186CE7500-0x0000000186CE7A30
	}
}
