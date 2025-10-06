/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BloodLancetProjectile : Projectile // TypeDefIndex: 15387
	{
		// Fields
		[SerializeField]
		private Transform _NumbersParent; // 0xD0
		[SerializeField]
		private List<PhaserSprite> _Numbers; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private BloodAstronomiaWeapon _trueWeapon; // 0xE8
		public List<Radi> _radii; // 0xF0
		private float _amount; // 0xF8
		private float _slowPower; // 0xFC
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _imageTween; // 0x108
		private MultiTargetTween _angleTween; // 0x110
		private MultiTargetTween _alphaTween; // 0x118
		private List<Tweener> _radiusTween; // 0x120
	
		// Constructors
		public BloodLancetProjectile() {} // 0x0000000186BB0830-0x0000000186BB09D0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BAE5B0-0x0000000186BAE6D0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BAE6D0-0x0000000186BAFAC0
		public override void Despawn() {} // 0x0000000186BAFAC0-0x0000000186BAFB10
		public override bool CanExplode() => default; // 0x0000000181958370-0x0000000181958380
		public override void Explode(Vector2? position = default) {} // 0x0000000186BAFB10-0x0000000186BAFB60
		public override void InternalUpdate() {} // 0x0000000186BAFB60-0x0000000186BAFE20
		private void InitNumbers() {} // 0x0000000186BAFE20-0x0000000186BB0210
		private void FadeOut() {} // 0x0000000186BB0210-0x0000000186BB0670
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BB0670-0x0000000186BB0830
	}
}
