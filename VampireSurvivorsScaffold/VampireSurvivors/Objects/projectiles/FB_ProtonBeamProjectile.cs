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
	public class FB_ProtonBeamProjectile : Projectile // TypeDefIndex: 15481
	{
		// Fields
		private SpriteRenderer _muzzleFlash; // 0xD0
		private SpriteRenderer _muzzleFlash2; // 0xD8
		private SpriteRenderer _line9Slice; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _destructionTimer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _canSplitTimer; // 0xF0
		private float _firingCountdown; // 0xF8
		private float2 _startPosition; // 0xFC
		private float _collisionTween; // 0x104
		private bool _hasSplit; // 0x108
		private bool _canSplit; // 0x109
		private float2 _lastOwnerPosition; // 0x10C
		private IDamageable _ignoreHitObject; // 0x118
		private float _MaxAlpha; // 0x120
		private float _AlphaDiff; // 0x124
	
		// Constructors
		public FB_ProtonBeamProjectile() {} // 0x0000000186C2CF10-0x0000000186C2CF80
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C2AA30-0x0000000186C2BB30
		public override void InternalUpdate() {} // 0x0000000186C2BB30-0x0000000186C2C450
		private void AdjustLine(float2 amount) {} // 0x0000000186C2C450-0x0000000186C2C690
		public override void Despawn() {} // 0x0000000186C2C690-0x0000000186C2C940
		private void ActuallyRemove() {} // 0x0000000186C2C940-0x0000000186C2CB00
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C2CB00-0x0000000186C2CF10
	}
}
