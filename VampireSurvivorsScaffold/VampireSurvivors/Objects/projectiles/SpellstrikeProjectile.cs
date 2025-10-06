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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SpellstrikeProjectile : Projectile // TypeDefIndex: 15434
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0xD0
		private ParticleSystem _emitter2; // 0xD8
		private Circle _emitZone; // 0xE0
		private ParticleSystem _emitter1; // 0xE8
		private MultiTargetTween _strikeTween; // 0xF0
		private MultiTargetTween _emitterTween; // 0xF8
	
		// Constructors
		public SpellstrikeProjectile() {} // 0x0000000186BF93C0-0x0000000186BF9410
	
		// Methods
		protected override void Awake() {} // 0x0000000186BF7A90-0x0000000186BF8B20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BF8B20-0x0000000186BF9380
		public override void InternalUpdate() {} // 0x0000000186BF9380-0x0000000186BF93C0
	}
}
