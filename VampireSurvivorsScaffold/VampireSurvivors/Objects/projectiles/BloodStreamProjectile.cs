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
	public class BloodStreamProjectile : Projectile // TypeDefIndex: 15394
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
		public BloodStreamProjectile() {} // 0x0000000186BB7FE0-0x0000000186BB8040
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB5FA0-0x0000000186BB7100
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB7100-0x0000000186BB72F0
		public void OverrideWeaponData(Weapon weapon) {} // 0x0000000186BB72F0-0x0000000186BB7C50
		public override void InternalUpdate() {} // 0x0000000186BB7C50-0x0000000186BB7F80
		public override void Despawn() {} // 0x0000000186BB7F80-0x0000000186BB7FE0
	}
}
