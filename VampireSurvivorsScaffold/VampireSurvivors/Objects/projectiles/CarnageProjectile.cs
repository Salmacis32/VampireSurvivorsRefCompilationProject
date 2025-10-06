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
	public class CarnageProjectile : Projectile // TypeDefIndex: 15405
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
		public CarnageProjectile() {} // 0x0000000186BC9B00-0x0000000186BC9B50
	
		// Methods
		protected override void Awake() {} // 0x0000000186BC82D0-0x0000000186BC83F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC83F0-0x0000000186BC8850
		public override void InternalUpdate() {} // 0x0000000186BC8850-0x0000000186BC8990
		public override void SetTarget(Transform target) {} // 0x0000000186BC8990-0x0000000186BC8C50
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BC8C50-0x0000000186BC8E80
		public void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186BC8E80-0x0000000186BC8EF0
		private void SetupTrails() {} // 0x0000000186BC8EF0-0x0000000186BC92B0
		private void FadeOutAndDispose() {} // 0x0000000186BC92B0-0x0000000186BC95F0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BC95F0-0x0000000186BC9680
		private void Explode() {} // 0x0000000186BC9680-0x0000000186BC9A20
		public override void Despawn() {} // 0x0000000186BC9A20-0x0000000186BC9B00
	}
}
