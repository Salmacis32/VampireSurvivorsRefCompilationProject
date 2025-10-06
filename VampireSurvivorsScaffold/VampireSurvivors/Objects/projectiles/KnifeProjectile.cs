/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class KnifeProjectile : Projectile // TypeDefIndex: 15909
	{
		// Constructors
		public KnifeProjectile() {} // 0x0000000186E3A710-0x0000000186E3A760
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E39EA0-0x0000000186E3A560
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E3A560-0x0000000186E3A570
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E3A570-0x0000000186E3A620
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186E3A620-0x0000000186E3A710
	}
}
