/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HeavenSwordProjectile : Projectile // TypeDefIndex: 15895
	{
		// Fields
		[SerializeField]
		private SpriteTrail _Trail; // 0xD0
		private Tween _angleTween; // 0xD8
		private Tween _accelTween; // 0xE0
		private Tween _backwardsTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _cullingTimer; // 0xF0
		private float _acceleration; // 0xF8
		private Vector2 _velocity; // 0xFC
	
		// Constructors
		public HeavenSwordProjectile() {} // 0x0000000186E2D690-0x0000000186E2D730
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E2C210-0x0000000186E2CC50
		public override void InternalUpdate() {} // 0x0000000186E2CC50-0x0000000186E2CCA0
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186E2CCA0-0x0000000186E2CDA0
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E2CDA0-0x0000000186E2CF10
		private void GoBackwards() {} // 0x0000000186E2CF10-0x0000000186E2D5E0
		public override void Despawn() {} // 0x0000000186E2D5E0-0x0000000186E2D690
	}
}
