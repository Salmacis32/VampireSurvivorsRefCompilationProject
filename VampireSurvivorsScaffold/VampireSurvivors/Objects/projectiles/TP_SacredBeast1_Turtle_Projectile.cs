/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SacredBeast1_Turtle_Projectile : Projectile // TypeDefIndex: 15645
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private readonly List<int> _targetAngles; // 0xE8
	
		// Constructors
		public TP_SacredBeast1_Turtle_Projectile() {} // 0x0000000186D05B80-0x0000000186D05F90
	
		// Methods
		protected override void Awake() {} // 0x0000000186D04960-0x0000000186D04AF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D04AF0-0x0000000186D04ED0
		public override void SetTarget(Transform target) {} // 0x0000000186D04ED0-0x0000000186D05020
		public override void InternalUpdate() {} // 0x0000000186D05020-0x0000000186D05160
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186D05160-0x0000000186D051C0
		private void SetupTrails() {} // 0x0000000186D051C0-0x0000000186D05680
		private void FadeOutAndDispose() {} // 0x0000000186D05680-0x0000000186D05A10
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186D05A10-0x0000000186D05AF0
		public override void Despawn() {} // 0x0000000186BE1200-0x0000000186BE12D0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D05AF0-0x0000000186D05B80
	}
}
