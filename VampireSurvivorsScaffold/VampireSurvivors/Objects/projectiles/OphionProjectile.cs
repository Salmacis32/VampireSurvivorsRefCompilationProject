/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class OphionProjectile : Projectile // TypeDefIndex: 15426
	{
		// Fields
		private float _exploRadius; // 0xD0
		private PhaserSprite _snakeSprite; // 0xD8
		private MultiTargetTween _explosionTween; // 0xE0
		private bool _isExploding; // 0xE8
		private ShadowServantWeapon _trueWeaponShadowSerpant; // 0xF0
		private OphionWeapon _trueWeapon; // 0xF8
		private ParticleEmitterManager _particlesManager; // 0x100
		private Circle _explosionCircle; // 0x108
		private ParticleSystem _purpleEmitter1; // 0x110
		private ParticleSystem _purpleEmitter2; // 0x118
		private MultiTargetTween _displayScaleTween; // 0x120
		private MultiTargetTween _displayScaleTween2; // 0x128
		private PhaserSprite _displaySprite; // 0x130
		private MultiTargetTween _snakeTween; // 0x138
		private MultiTargetTween _scaleTween; // 0x140
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0x148
		private MultiTargetTween _implosionTween; // 0x150
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x158
		public float _explo1DUration; // 0x160
		public float _explo2DUration; // 0x164
		public float _explo3DUration; // 0x168
	
		// Constructors
		public OphionProjectile() {} // 0x0000000186BEC8A0-0x0000000186BEC920
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE8C50-0x0000000186BEA510
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BEA510-0x0000000186BEAC60
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BEAC60-0x0000000186BEAC70
		public void Explode() {} // 0x0000000186BEAC70-0x0000000186BEB810
		public void Implode() {} // 0x0000000186BEB810-0x0000000186BEBC90
		public void Explode2() {} // 0x0000000186BEBC90-0x0000000186BEC560
		protected override void OnUpdate() {} // 0x0000000186BEC560-0x0000000186BEC7F0
		public void Disable() {} // 0x0000000186BC81E0-0x0000000186BC8200
		public override void Despawn() {} // 0x0000000186BEC7F0-0x0000000186BEC8A0
	}
}
