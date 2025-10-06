/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BloodPentagramProjectile : Projectile // TypeDefIndex: 15389
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private BloodAstronomiaWeapon _trueWeapon; // 0xE0
		private float _amount; // 0xE8
	
		// Constructors
		public BloodPentagramProjectile() {} // 0x0000000186BB2750-0x0000000186BB27A0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB1EE0-0x0000000186BB1FF0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BB1FF0-0x0000000186BB22F0
		public override bool CanExplode() => default; // 0x0000000181958370-0x0000000181958380
		public override void Explode(Vector2? position = default) {} // 0x0000000186BB22F0-0x0000000186BB2470
		public override void Despawn() {} // 0x0000000186BB2470-0x0000000186BB24C0
		private void FadeOut() {} // 0x0000000186BB24C0-0x0000000186BB2750
	}
}
