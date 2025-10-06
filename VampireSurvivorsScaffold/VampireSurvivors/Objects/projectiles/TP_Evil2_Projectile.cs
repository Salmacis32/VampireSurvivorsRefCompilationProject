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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Evil2_Projectile : Projectile // TypeDefIndex: 15568
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _sprite1; // 0xD8
		private PhaserSprite _sprite2; // 0xE0
		private PhaserSprite _sprite3; // 0xE8
		private PhaserSprite _sprite4; // 0xF0
		private PhaserSprite _sprite5; // 0xF8
		private Tween _radiusTween; // 0x100
		private MultiTargetTween _scaleTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x118
		private MultiTargetTween _rotTween; // 0x120
		private MultiTargetTween _alphaTween; // 0x128
		private Vector2 startingVelocity; // 0x130
		private float _accel; // 0x138
		private MultiTargetTween _alphaTween2; // 0x140
		private MultiTargetTween _scaleTween2; // 0x148
		private List<bool> _cachedInRange; // 0x150
		private float _cachedArea; // 0x158
		private TP_Evil2_Weapon trueWeapon; // 0x160
	
		// Constructors
		public TP_Evil2_Projectile() {} // 0x0000000186CAD100-0x0000000186CAD200
	
		// Methods
		protected override void Awake() {} // 0x0000000186CAA6D0-0x0000000186CABD90
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CABD90-0x0000000186CACB30
		private void LateUpdate() {} // 0x0000000186CACB30-0x0000000186CACBE0
		private void StartDespawn() {} // 0x0000000186CACBE0-0x0000000186CACE70
		private void DoTwilightExplosions() {} // 0x0000000186CACE70-0x0000000186CAD0A0
		public override void Despawn() {} // 0x0000000186CAD0A0-0x0000000186CAD100
	}
}
