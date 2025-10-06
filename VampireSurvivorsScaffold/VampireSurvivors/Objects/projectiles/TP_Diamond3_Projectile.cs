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
	public class TP_Diamond3_Projectile : Projectile // TypeDefIndex: 15973
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private readonly List<int> _targetAngles; // 0xE8
	
		// Constructors
		public TP_Diamond3_Projectile() {} // 0x0000000186E80A50-0x0000000186E80E60
	
		// Methods
		protected override void Awake() {} // 0x0000000186E7F540-0x0000000186E7F6D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E7F6D0-0x0000000186E7FD40
		public override void SetTarget(Transform target) {} // 0x0000000186E7FD40-0x0000000186E7FFD0
		public override void InternalUpdate() {} // 0x0000000186E7FFD0-0x0000000186E80110
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186E80110-0x0000000186E80170
		private void SetupTrails() {} // 0x0000000186E80170-0x0000000186E80630
		private void FadeOutAndDispose() {} // 0x0000000186E80630-0x0000000186E809C0
		public override void Despawn() {} // 0x0000000186BE1200-0x0000000186BE12D0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E809C0-0x0000000186E80A50
	}
}
