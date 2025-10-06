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
	public class TP_RPG1_Explosion_Projectile : Projectile // TypeDefIndex: 15637
	{
		// Fields
		private bool _particlesGenerated; // 0xD0
		private ParticleEmitterManager _particlesManager; // 0xD8
		private ParticleSystem _pfxEmitter; // 0xE0
		private ParticleSystem _pfxEmitter2; // 0xE8
		private GravityWell _well; // 0xF0
		private Tween _timer; // 0xF8
		private Tween _alphaTween; // 0x100
		private Tween _radiusTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x110
		private float _radius; // 0x118
		private float _exploRadius; // 0x11C
		private EmitZone _explosionCircle; // 0x120
		private Tween _despawnTween; // 0x128
		private PhaserSprite _animatedSprite; // 0x130
	
		// Constructors
		public TP_RPG1_Explosion_Projectile() {} // 0x0000000186D00390-0x0000000186D00400
	
		// Methods
		protected override void Awake() {} // 0x0000000186CFD8C0-0x0000000186CFDC20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CFDC20-0x0000000186CFDE40
		private void HideExplosion() {} // 0x0000000186CFDE40-0x0000000186CFDE70
		private void Explode(bool flashingVFX) {} // 0x0000000186CFDE70-0x0000000186CFE730
		private void TriggerDespawnTimer() {} // 0x0000000186CFE730-0x0000000186CFE9F0
		private void GenerateParticleSystems() {} // 0x0000000186CFE9F0-0x0000000186D00390
		public override void Despawn() {} // 0x0000000186C8B7D0-0x0000000186C8B860
	}
}
