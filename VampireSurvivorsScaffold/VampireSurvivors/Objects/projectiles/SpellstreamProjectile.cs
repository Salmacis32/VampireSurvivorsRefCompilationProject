/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SpellstreamProjectile : Projectile // TypeDefIndex: 15433
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0xD0
		private Circle _emitZone; // 0xD8
		private ParticleSystem _emitter1; // 0xE0
		private ParticleSystem _emitter2; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private MultiTargetTween _speedTween; // 0xF8
		private Vector2 _aimVec; // 0x100
		private float _setDuration; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTween; // 0x110
		[NonSerialized]
		public float Deceleration; // 0x118
	
		// Constructors
		public SpellstreamProjectile() {} // 0x0000000186BF7A30-0x0000000186BF7A90
	
		// Methods
		protected override void Awake() {} // 0x0000000186BF5C90-0x0000000186BF6D10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BF6D10-0x0000000186BF7700
		public override void InternalUpdate() {} // 0x0000000186BF7700-0x0000000186BF7A30
		public override void Despawn() {} // 0x0000000186BB7F80-0x0000000186BB7FE0
	}
}
