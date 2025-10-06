/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Sample2Reactor : Projectile // TypeDefIndex: 15455
	{
		// Fields
		private ParticleSystem _pfxFireEmitterScreen; // 0xD0
		private ParticleSystem _pfxFireEmitterAdd; // 0xD8
		protected Sample2Weapon _trueWeapon; // 0xE0
		protected float reactorOffsetY; // 0xE8
		protected MultiTargetTween _scaleYTween; // 0xF0
		private float pixelWidth; // 0xF8
	
		// Constructors
		public Sample2Reactor() {} // 0x0000000186C12110-0x0000000186C12160
	
		// Methods
		protected override void Awake() {} // 0x0000000186C0F770-0x0000000186C0F810
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C0F810-0x0000000186C0FBD0
		public void FireProjectile(float totalDuration) {} // 0x0000000186C0FBD0-0x0000000186C0FC30
		protected void fireThruster(float duration) {} // 0x0000000186C0FC30-0x0000000186C10150
		protected void launchOffScreen() {} // 0x0000000186C10150-0x0000000186C103F0
		protected override void OnUpdate() {} // 0x0000000186C103F0-0x0000000186C105F0
		public override void Despawn() {} // 0x0000000186C105F0-0x0000000186C10620
		private void GenerateParticleSystems() {} // 0x0000000186C10620-0x0000000186C12110
	}
}
