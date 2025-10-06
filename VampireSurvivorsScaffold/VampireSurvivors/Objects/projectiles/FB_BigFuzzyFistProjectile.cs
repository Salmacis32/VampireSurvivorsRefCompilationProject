/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_BigFuzzyFistProjectile : Projectile // TypeDefIndex: 15459
	{
		// Fields
		private PhaserSprite _explosion; // 0xD0
		private PhaserSprite _crack; // 0xD8
		private ParticleEmitterManager _particlesManager; // 0xE0
		private ParticleSystem _pfxEmitter; // 0xE8
	
		// Constructors
		public FB_BigFuzzyFistProjectile() {} // 0x0000000186C17B10-0x0000000186C17B60
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C16220-0x0000000186C16C00
		private void GenerateParticleSystem() {} // 0x0000000186C16C00-0x0000000186C17550
		public override void Despawn() {} // 0x0000000186C17550-0x0000000186C175A0
		private void SetupVisuals() {} // 0x0000000186C175A0-0x0000000186C17AD0
		private void OnAnimationComplete() {} // 0x0000000186C17AD0-0x0000000186C17B10
	}
}
