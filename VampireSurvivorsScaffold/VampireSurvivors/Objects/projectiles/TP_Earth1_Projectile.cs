/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Earth1_Projectile : Projectile // TypeDefIndex: 15558
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private float _startingAngle; // 0xE8
		private bool _isDespawning; // 0xEC
		private List<uint> _tints; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
	
		// Constructors
		public TP_Earth1_Projectile() {} // 0x0000000186C9D9A0-0x0000000186C9DDD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C9C930-0x0000000186C9CEC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C9CEC0-0x0000000186C9D5C0
		private void StartDespawn() {} // 0x0000000186C9D5C0-0x0000000186C9D870
		public override void Despawn() {} // 0x0000000186C9D870-0x0000000186C9D8E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C9D8E0-0x0000000186C9D9A0
	}
}
