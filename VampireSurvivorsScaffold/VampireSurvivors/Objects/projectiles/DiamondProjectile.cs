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
	public class DiamondProjectile : Projectile // TypeDefIndex: 15417
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private float _saveVelX; // 0xE0
		private float _saveVelY; // 0xE4
		private readonly List<int> _targetAngles; // 0xE8
		private bool isFullColourRange; // 0xF0
	
		// Constructors
		public DiamondProjectile() {} // 0x0000000186BE1360-0x0000000186BE1770
	
		// Methods
		protected override void Awake() {} // 0x0000000186BDF980-0x0000000186BDFAA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BDFAA0-0x0000000186BE0290
		public override void SetTarget(Transform target) {} // 0x0000000186BE0290-0x0000000186BE0560
		public override void InternalUpdate() {} // 0x0000000186BE0560-0x0000000186BE06A0
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186BE06A0-0x0000000186BE0730
		private void SetupTrails() {} // 0x0000000186BE0730-0x0000000186BE0CF0
		public Color ColorFromUInt(uint value) => default; // 0x0000000186BE0CF0-0x0000000186BE0D60
		private void FadeOutAndDispose() {} // 0x0000000186BE0D60-0x0000000186BE10F0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BE10F0-0x0000000186BE1200
		public override void Despawn() {} // 0x0000000186BE1200-0x0000000186BE12D0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BE12D0-0x0000000186BE1360
	}
}
