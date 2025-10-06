/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SpellstromProjectile : Projectile // TypeDefIndex: 15436
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		public Transform _toFollow; // 0xE0
		private bool _alreadyRecycled; // 0xE8
	
		// Constructors
		public SpellstromProjectile() {} // 0x0000000186BFB6E0-0x0000000186BFB730
	
		// Methods
		protected override void Awake() {} // 0x0000000186BFB150-0x0000000186BFB210
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BFB210-0x0000000186BFB500
		public void SetObjectToFollow(Transform toFollow) {} // 0x0000000184B1D020-0x0000000184B1D080
		public override void InternalUpdate() {} // 0x0000000186BFB500-0x0000000186BFB6A0
		public override void Despawn() {} // 0x0000000186BFB6A0-0x0000000186BFB6E0
	}
}
