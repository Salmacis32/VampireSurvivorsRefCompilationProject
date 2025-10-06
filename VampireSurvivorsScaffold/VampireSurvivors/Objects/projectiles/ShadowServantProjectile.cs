/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class ShadowServantProjectile : Projectile // TypeDefIndex: 15431
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		private PhaserSprite _displaySprite; // 0xD8
		private MultiTargetTween _explosionTween; // 0xE0
		private bool _isExploding; // 0xE8
		private ShadowServantWeapon _trueWeapon; // 0xF0
		private Transform _trailFollower; // 0xF8
		public float _trailFollowerCounter; // 0x100
	
		// Constructors
		public ShadowServantProjectile() {} // 0x0000000186BF36F0-0x0000000186BF3740
	
		// Methods
		protected override void Awake() {} // 0x0000000186BF3740-0x0000000186BF37F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BF37F0-0x0000000186BF4410
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BF4410-0x0000000186BF46B0
		public void Explode() {} // 0x0000000186BF46B0-0x0000000186BF5170
		public override void InternalUpdate() {} // 0x0000000186BF5170-0x0000000186BF52E0
		private void Disable() {} // 0x0000000186BC81E0-0x0000000186BC8200
		public override void Despawn() {} // 0x0000000186BF52E0-0x0000000186BF53D0
		private void LogTrailPositions() {} // 0x0000000186BF53D0-0x0000000186BF57C0
	}
}
