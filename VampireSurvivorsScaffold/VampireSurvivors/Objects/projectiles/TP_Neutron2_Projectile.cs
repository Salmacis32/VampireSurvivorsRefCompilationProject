/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Neutron2_Projectile : Projectile // TypeDefIndex: 15623
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private Tween _expireTimer; // 0xD8
		private Tween _explodeTimer; // 0xE0
		private bool _canExplode; // 0xE8
		private float _saveVelX; // 0xEC
		private float _saveVelY; // 0xF0
		private int _exploIndex; // 0xF4
	
		// Constructors
		public TP_Neutron2_Projectile() {} // 0x0000000186CED780-0x0000000186CED7D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CEC030-0x0000000186CEC150
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CEC150-0x0000000186CEC5B0
		public override void InternalUpdate() {} // 0x0000000186CEC5B0-0x0000000186CEC6F0
		public override void SetTarget(Transform target) {} // 0x0000000186CEC6F0-0x0000000186CEC9B0
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186CEC9B0-0x0000000186CECBE0
		public void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186CECBE0-0x0000000186CECC50
		private void SetupTrails() {} // 0x0000000186CECC50-0x0000000186CED010
		private void FadeOutAndDispose() {} // 0x0000000186CED010-0x0000000186CED350
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CED350-0x0000000186CED3E0
		private void Explode() {} // 0x0000000186CED3E0-0x0000000186CED780
		public override void Despawn() {} // 0x0000000186BC9A20-0x0000000186BC9B00
	}
}
