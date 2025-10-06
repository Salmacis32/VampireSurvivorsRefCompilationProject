/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class BloodRapidusProjectile : Projectile // TypeDefIndex: 15391
	{
		// Fields
		private float _amount; // 0xD0
		private BloodAstronomiaWeapon _trueWeapon; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private MultiTargetTween _alphaTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0xF8
		private List<string> _frameNames; // 0x100
		private MultiTargetTween _localTween; // 0x108
	
		// Constructors
		public BloodRapidusProjectile() {} // 0x0000000186BB58E0-0x0000000186BB5EC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB4A10-0x0000000186BB4BA0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BB4BA0-0x0000000186BB53F0
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x0000000186BB53F0-0x0000000186BB5470
		public override bool CanExplode() => default; // 0x0000000181958370-0x0000000181958380
		public override void Explode(Vector2? pos = default) {} // 0x0000000186BB5470-0x0000000186BB55E0
		private void FadeOut() {} // 0x0000000186BB55E0-0x0000000186BB58E0
	}
}
