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
	public class FB_TimeWarpProjectile : Projectile // TypeDefIndex: 15489
	{
		// Fields
		private List<Sprite> _animationFrames; // 0xD0
		private float _animationProgress; // 0xD8
		private float _loopTimer; // 0xDC
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xE0
	
		// Properties
		private int FrameRate { get => default; } // 0x0000000180B22900-0x0000000180B22910 
	
		// Constructors
		public FB_TimeWarpProjectile() {} // 0x0000000186C32320-0x0000000186C32370
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C31530-0x0000000186C318E0
		public override void InternalUpdate() {} // 0x0000000186C318E0-0x0000000186C31CC0
		private void OnCircleComplete() {} // 0x0000000186C31CC0-0x0000000186C31EB0
		private void LateUpdate() {} // 0x0000000186C31EB0-0x0000000186C31F10
		private void InitAnimation() {} // 0x0000000186C31F10-0x0000000186C32000
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C32000-0x0000000186C322A0
		public override void Despawn() {} // 0x0000000186C322A0-0x0000000186C32320
	}
}
