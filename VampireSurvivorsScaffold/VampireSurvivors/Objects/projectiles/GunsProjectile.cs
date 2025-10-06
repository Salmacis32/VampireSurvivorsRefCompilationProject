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
	public class GunsProjectile : Projectile // TypeDefIndex: 15894
	{
		// Fields
		protected float[] _firingAngles; // 0xD0
		private GunsWeapon _trueWeapon; // 0xD8
	
		// Constructors
		public GunsProjectile() {} // 0x0000000186E2C120-0x0000000186E2C210
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E2BB10-0x0000000186E2BE80
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186E2BE80-0x0000000186E2BE90
		protected override void OnHasHitAnotherPlayerObject(IDamageable target) {} // 0x0000000186E2BE90-0x0000000186E2BF60
		private void OnHasHitAnObjectLogic(IDamageable target, bool triggerHit) {} // 0x0000000186E2BF60-0x0000000186E2C120
	}
}
