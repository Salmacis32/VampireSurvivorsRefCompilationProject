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
	public class BloodLaurelProjectile : Projectile // TypeDefIndex: 15388
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private MultiTargetTween _imageTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private float _amount; // 0xF0
		private BloodAstronomiaWeapon _trueWeapon; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0x100
	
		// Constructors
		public BloodLaurelProjectile() {} // 0x0000000186BB1E10-0x0000000186BB1E60
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB0EA0-0x0000000186BB0FD0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BB0FD0-0x0000000186BB1940
		public override void Despawn() {} // 0x0000000186BB1940-0x0000000186BB19B0
		public override bool CanExplode() => default; // 0x0000000181958370-0x0000000181958380
		public override void Explode(Vector2? position = default) {} // 0x0000000186BB19B0-0x0000000186BB1B30
		private void FadeOut() {} // 0x0000000186BB1B30-0x0000000186BB1E10
	}
}
