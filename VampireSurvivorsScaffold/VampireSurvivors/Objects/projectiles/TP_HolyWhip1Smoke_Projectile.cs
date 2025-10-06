/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_HolyWhip1Smoke_Projectile : Projectile // TypeDefIndex: 15586
	{
		// Fields
		private bool _particlesGenerated; // 0xD0
		private ParticleEmitterManager _particlesManager; // 0xD8
		private ParticleSystem _pfxEmitter; // 0xE0
		private Tween _timer; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xF0
		private float _exploRadius; // 0xF8
		private EmitZone _explosionCircle; // 0x100
		private Tween _despawnTween; // 0x108
		private PhaserSprite _animatedSprite; // 0x110
	
		// Constructors
		public TP_HolyWhip1Smoke_Projectile() {} // 0x0000000186CC65F0-0x0000000186CC6650
	
		// Methods
		protected override void Awake() {} // 0x0000000186CC4EC0-0x0000000186CC5220
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CC5220-0x0000000186CC55C0
		private void Explode(bool flashingVFX) {} // 0x0000000186CC55C0-0x0000000186CC5760
		private void TriggerDespawnTimer() {} // 0x0000000186CC5760-0x0000000186CC5930
		private void GenerateParticleSystems() {} // 0x0000000186CC5930-0x0000000186CC64E0
		public override void Despawn() {} // 0x0000000186CC64E0-0x0000000186CC65F0
	}
}
