/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_Rune2_SpinningProjectile : Projectile // TypeDefIndex: 15871
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		public Transform _toFollow; // 0xE0
		private bool _alreadyRecycled; // 0xE8
		private List<PhaserSprite> magicCircles; // 0xF0
		private int magicCircleIndex; // 0xF8
		private float _angle1; // 0xFC
		private float _angle2; // 0x100
		private float _angle3; // 0x104
	
		// Constructors
		public EX_Rune2_SpinningProjectile() {} // 0x0000000186E04CD0-0x0000000186E04DC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E041C0-0x0000000186E04620
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E04620-0x0000000186E048B0
		public void SetObjectToFollow(Transform toFollow) {} // 0x0000000184B1D020-0x0000000184B1D080
		public override void InternalUpdate() {} // 0x0000000186E048B0-0x0000000186E04CD0
		public override void Despawn() {} // 0x0000000186BFB6A0-0x0000000186BFB6E0
	}
}
