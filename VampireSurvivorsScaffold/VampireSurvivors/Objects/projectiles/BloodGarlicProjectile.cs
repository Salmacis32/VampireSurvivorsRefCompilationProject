/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BloodGarlicProjectile : Projectile // TypeDefIndex: 15384
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private MultiTargetTween _angleTween; // 0xE0
	
		// Constructors
		public BloodGarlicProjectile() {} // 0x0000000186BAE500-0x0000000186BAE550
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BADAA0-0x0000000186BADAE0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BADAE0-0x0000000186BAE260
		private void FadeOut() {} // 0x0000000186BAE260-0x0000000186BAE500
	}
}
