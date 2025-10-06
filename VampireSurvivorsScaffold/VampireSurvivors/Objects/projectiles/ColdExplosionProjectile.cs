/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class ColdExplosionProjectile : Projectile // TypeDefIndex: 15412
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private bool _particlesGenerated; // 0xD8
		private ParticleEmitterManager _particlesManager; // 0xE0
		private ParticleSystem _pfxEmitter; // 0xE8
		private ParticleSystem _pfxEmitter2; // 0xF0
		private GravityWell _well; // 0xF8
		private Tween _timer; // 0x100
		private Tween _alphaTween; // 0x108
		private Tween _radiusTween; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x118
		private float _radius; // 0x120
		private float _exploRadius; // 0x124
	
		// Constructors
		public ColdExplosionProjectile() {} // 0x0000000186BDB110-0x0000000186BDB180
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BD9100-0x0000000186BD9180
		private void Explode(bool flashingVFX) {} // 0x0000000186BD9180-0x0000000186BD9A50
		private void TriggerDespawnTimer() {} // 0x0000000186BD9A50-0x0000000186BD9D20
		private void GenerateParticleSystems() {} // 0x0000000186BD9D20-0x0000000186BDB110
	}
}
