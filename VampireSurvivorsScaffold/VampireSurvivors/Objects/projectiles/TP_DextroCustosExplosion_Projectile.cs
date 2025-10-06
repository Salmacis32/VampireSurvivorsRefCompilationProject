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
	public class TP_DextroCustosExplosion_Projectile : Projectile // TypeDefIndex: 15536
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
		private EmitZone _explosionCircle; // 0x128
		private Tween _despawnTween; // 0x130
	
		// Constructors
		public TP_DextroCustosExplosion_Projectile() {} // 0x0000000186C88F70-0x0000000186C88FE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C866E0-0x0000000186C86980
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C86980-0x0000000186C86AB0
		private void Explode(bool flashingVFX) {} // 0x0000000186C86AB0-0x0000000186C876D0
		private void TriggerDespawnTimer() {} // 0x0000000186C876D0-0x0000000186C879C0
		private void GenerateParticleSystems() {} // 0x0000000186C879C0-0x0000000186C88EE0
		public override void Despawn() {} // 0x0000000186C88EE0-0x0000000186C88F70
	}
}
