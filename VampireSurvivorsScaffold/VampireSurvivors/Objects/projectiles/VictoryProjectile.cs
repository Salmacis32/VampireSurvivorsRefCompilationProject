/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VictoryProjectile : Projectile // TypeDefIndex: 15987
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private VictoryWeapon _trueWeapon; // 0xE0
		private ParticleEmitterManager _pfxEmitterManager; // 0xE8
		private ParticleSystem _pfxEmitter; // 0xF0
		private bool _initialisedParticles; // 0xF8
		private bool _isFinisher; // 0xF9
	
		// Constructors
		public VictoryProjectile() {} // 0x0000000186E98320-0x0000000186E98370
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E96C50-0x0000000186E976B0
		public override void Despawn() {} // 0x0000000186E976B0-0x0000000186E977C0
		public override void SetNullTarget() {} // 0x0000000186BB8730-0x0000000186BB8750
		public override void SetTarget(Transform target) {} // 0x0000000186E977C0-0x0000000186E98320
	}
}
