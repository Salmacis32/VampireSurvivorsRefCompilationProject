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
	public class Guns2Projectile : GunsProjectile // TypeDefIndex: 15891
	{
		// Constructors
		public Guns2Projectile() {} // 0x0000000186E2B560-0x0000000186E2B570
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E2B570-0x0000000186E2B580
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186E2B580-0x0000000186E2B590
		protected override void OnHasHitAnotherPlayerObject(IDamageable target) {} // 0x0000000186E2B590-0x0000000186E2B5A0
		private new void OnHasHitAnObjectLogic(IDamageable target, bool triggerHit) {} // 0x0000000186E2B5A0-0x0000000186E2B770
	}
}
