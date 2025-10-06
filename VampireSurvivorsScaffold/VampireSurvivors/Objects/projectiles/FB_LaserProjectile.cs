/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_LaserProjectile : Projectile // TypeDefIndex: 15474
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		private SpriteRenderer _muzzleFlash; // 0xD8
		private SpriteRenderer _muzzleFlash2; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _destructionTimer; // 0xE8
		private float _firingCountdown; // 0xF0
		private float2 _startPosition; // 0xF4
		private float _collisionTween; // 0xFC
		private float2 _lastOwnerPosition; // 0x100
		private float _MaxAlpha; // 0x108
		private float _AlphaDiff; // 0x10C
	
		// Properties
		private Vector2 TrailTextureScale { get => default; } // 0x0000000186C23190-0x0000000186C231B0 
	
		// Constructors
		public FB_LaserProjectile() {} // 0x0000000186C25500-0x0000000186C25570
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C231B0-0x0000000186C24100
		public override void InternalUpdate() {} // 0x0000000186C24100-0x0000000186C249B0
		private void AdjustLine(float2 amount) {} // 0x0000000186C249B0-0x0000000186C24F50
		public override void Despawn() {} // 0x0000000186C24F50-0x0000000186C25260
		private void ActuallyRemove() {} // 0x0000000186C25260-0x0000000186C25420
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C25420-0x0000000186C25500
	}
}
