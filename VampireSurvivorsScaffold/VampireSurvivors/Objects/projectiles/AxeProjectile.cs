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
	public class AxeProjectile : Projectile // TypeDefIndex: 15380
	{
		// Fields
		private Tween _angleTween; // 0xD0
		private Tween _scaleTween; // 0xD8
		private Vector2 _initialVel; // 0xE0
		private float _startingAngle; // 0xE8
		private const float Grav = 6.25f; // Metadata: 0x01977608
	
		// Constructors
		public AxeProjectile() {} // 0x0000000186BABB10-0x0000000186BABB60
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BAAEA0-0x0000000186BAB6E0
		public override void InternalUpdate() {} // 0x0000000186BAB6E0-0x0000000186BAB880
		public override void Despawn() {} // 0x0000000186BAB880-0x0000000186BAB990
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BAB990-0x0000000186BAB9A0
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186BAB9A0-0x0000000186BAB9B0
		private void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186BAB9B0-0x0000000186BABB10
	}
}
