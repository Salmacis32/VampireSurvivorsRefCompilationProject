/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Light1_Projectile : Projectile // TypeDefIndex: 15612
	{
		// Fields
		private List<Projectile> _orbiters; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private float2 _centralPos; // 0xE8
		private float _angleInc; // 0xF0
		private float _flipNum; // 0xF4
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		protected SpriteAnimation _spriteAnimator; // 0x100
		private float radiusMul; // 0x108
		private TweenerCore<float, float, FloatOptions> radiusTween; // 0x110
		private int _flipDir; // 0x118
		protected PhaserSprite _glowSprite; // 0x120
		private const float goldenRatio = 1.618034f; // Metadata: 0x01977782
		protected TP_Light1_Weapon _trueWeapon; // 0x128
	
		// Properties
		public virtual float BodyRadius { get => default; } // 0x0000000186C6EC50-0x0000000186C6EC60 
		public virtual float Scale { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual float Depth { get => default; } // 0x0000000185EC0950-0x0000000185EC0960 
		public virtual bool HasOrbiters { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public virtual int InvertMotion { get => default; } // 0x0000000180B209C0-0x0000000180B209D0 
	
		// Constructors
		public TP_Light1_Projectile() {} // 0x0000000186C7E5D0-0x0000000186C7E630
	
		// Methods
		protected override void Awake() {} // 0x0000000186CE0950-0x0000000186CE0AB0
		public virtual void MakeSpriteAnimation() {} // 0x0000000186CE0AB0-0x0000000186CE0E30
		protected virtual void InitAlpha() {} // 0x0000000186CE0E30-0x0000000186CE0EE0
		protected virtual void PlayFiringSfx() {} // 0x0000000186CE0EE0-0x0000000186CE0FC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CE0FC0-0x0000000186CE1D20
		public override void InternalUpdate() {} // 0x0000000186CE1D20-0x0000000186CE1E90
		private void StartDespawn() {} // 0x0000000186CE1E90-0x0000000186CE2140
		private void TryDespawn() {} // 0x0000000186CE2140-0x0000000186CE2160
		public override void Despawn() {} // 0x0000000186CE2160-0x0000000186CE2390
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
