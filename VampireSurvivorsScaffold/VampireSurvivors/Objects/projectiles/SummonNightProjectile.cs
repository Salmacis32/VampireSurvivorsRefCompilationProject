/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SummonNightProjectile : Projectile // TypeDefIndex: 15971
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _HitboxTimer; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _ExpireTimer; // 0xD8
		private MultiTargetTween _ScaleTween; // 0xE0
		private PhaserSprite _fangSprite; // 0xE8
		private MultiTargetTween _fangTween; // 0xF0
		private ParticleEmitterManager _frontEmitterManager; // 0xF8
		private ParticleSystem _frontEmitter; // 0x100
		private Rectangle _explosionRect; // 0x108
		private ParticleEmitterManager _backEmitterManager; // 0x110
		private ParticleSystem _backEmitter; // 0x118
		private MultiTargetTween _fangTweenOut; // 0x120
		private ParticleEmitterManager _fragmentsEmitterManager; // 0x128
		private float _reach; // 0x130
		private ParticleSystem _fragmentsEmitter; // 0x138
		private EmitZone _emitZone; // 0x140
	
		// Constructors
		public SummonNightProjectile() {} // 0x0000000186E7CDE0-0x0000000186E7CE30
	
		// Methods
		protected override void Awake() {} // 0x0000000186E7A3E0-0x0000000186E7BEF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E7BEF0-0x0000000186E7CAF0
		public override void Despawn() {} // 0x0000000186E7CAF0-0x0000000186E7CBE0
		public override void InternalUpdate() {} // 0x0000000186E7CBE0-0x0000000186E7CDE0
	}
}
