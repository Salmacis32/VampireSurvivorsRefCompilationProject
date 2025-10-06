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
	public class CrossProjectile : Projectile // TypeDefIndex: 15416
	{
		// Fields
		private float _acceleration; // 0xD0
		private Vector2 _velocity; // 0xD4
		private Tween _angleTween; // 0xE0
		private Tween _accelTween; // 0xE8
	
		// Constructors
		public CrossProjectile() {} // 0x0000000186BDF8E0-0x0000000186BDF980
	
		// Methods
		protected override void Awake() {} // 0x0000000186BDE960-0x0000000186BDE980
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BDE980-0x0000000186BDF500
		public override void InternalUpdate() {} // 0x0000000186BDF500-0x0000000186BDF550
		public override void Despawn() {} // 0x0000000186BDF550-0x0000000186BDF670
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186BDF670-0x0000000186BDF770
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186BDF770-0x0000000186BDF8E0
	}
}
