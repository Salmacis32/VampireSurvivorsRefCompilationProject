/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Earth2_Projectile : Projectile // TypeDefIndex: 15559
	{
		// Fields
		private float _radius; // 0xD0
		private float _alpha; // 0xD4
		private PhaserSprite _animatedSprite; // 0xD8
		private float _startingAngle; // 0xE0
		private float _rotationSpeed; // 0xE4
		private bool _isDespawning; // 0xE8
		private TP_Earth2_Weapon _parentWeapon; // 0xF0
		private List<uint> _tints; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _tintTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
	
		// Constructors
		public TP_Earth2_Projectile() {} // 0x0000000186C9F4F0-0x0000000186C9F560
	
		// Methods
		protected override void Awake() {} // 0x0000000186C9DDD0-0x0000000186C9E360
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C9E360-0x0000000186C9F050
		public override void InternalUpdate() {} // 0x0000000186C9F050-0x0000000186C9F110
		private void StartDespawn() {} // 0x0000000186C9F110-0x0000000186C9F3C0
		public override void Despawn() {} // 0x0000000186C9F3C0-0x0000000186C9F430
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C9F430-0x0000000186C9F4F0
	}
}
