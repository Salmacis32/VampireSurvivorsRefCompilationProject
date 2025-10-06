/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Mace2_Projectile : Projectile // TypeDefIndex: 15621
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
		private bool _isflipped; // 0x108
		private int _flipNum; // 0x10C
		private float _extraDistTotal; // 0x110
		private float _extraDistSpacing; // 0x114
		protected bool _isCrit; // 0x118
		private bool _isMoving; // 0x119
		protected TP_Mace2_Weapon _trueWeapon; // 0x120
		private Tween _despawnTimer; // 0x128
	
		// Constructors
		public TP_Mace2_Projectile() {} // 0x0000000186CE9F80-0x0000000186CEA070
	
		// Methods
		protected override void Awake() {} // 0x0000000186CE8360-0x0000000186CE8460
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CE8460-0x0000000186CE8620
		public void SetCritical(bool isCritical) {} // 0x0000000186CE8620-0x0000000186CE8DC0
		public override void InternalUpdate() {} // 0x0000000186CE8DC0-0x0000000186CE8E90
		private void updateAttackAngle(float attackAngle) {} // 0x0000000186CE8E90-0x0000000186CE92E0
		private void LandHit() {} // 0x0000000186CE92E0-0x0000000186CE98B0
		public override void Despawn() {} // 0x0000000186CE98B0-0x0000000186CE9A50
		private void SetupTrails(TrailRenderer _trail) {} // 0x0000000186CE9A50-0x0000000186CE9F80
	}
}
