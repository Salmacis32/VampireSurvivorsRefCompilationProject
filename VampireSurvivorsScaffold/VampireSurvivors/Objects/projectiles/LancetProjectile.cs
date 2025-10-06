/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class LancetProjectile : Projectile // TypeDefIndex: 15910
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
	
		// Constructors
		public LancetProjectile() {} // 0x0000000186E3AD30-0x0000000186E3AD80
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E3A760-0x0000000186E3A8E0
		public void SetTargetPosition(Vector2 targetPos) {} // 0x0000000186E3A8E0-0x0000000186E3AAA0
		public override void Despawn() {} // 0x0000000186C6F470-0x0000000186C6F4A0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E3AAA0-0x0000000186E3AD30
	}
}
