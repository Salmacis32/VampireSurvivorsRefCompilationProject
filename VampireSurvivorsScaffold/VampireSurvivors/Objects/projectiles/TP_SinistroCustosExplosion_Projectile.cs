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
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SinistroCustosExplosion_Projectile : Projectile // TypeDefIndex: 15658
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private bool _particlesGenerated; // 0xD8
		private ParticleEmitterManager _particlesManager; // 0xE0
		private ParticleSystem _pfxEmitter; // 0xE8
		private ParticleSystem _pfxEmitter2; // 0xF0
		private Tween _timer; // 0xF8
		private Tween _alphaTween; // 0x100
		private Tween _radiusTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0x110
		private float _radius; // 0x118
		private float _exploRadius; // 0x11C
		private EmitZone _explosionCircle; // 0x120
		private Tween _despawnTween; // 0x128
	
		// Constructors
		public TP_SinistroCustosExplosion_Projectile() {} // 0x0000000186D17AC0-0x0000000186D17B30
	
		// Methods
		protected override void Awake() {} // 0x0000000186D153B0-0x0000000186D15650
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D15650-0x0000000186D15780
		private void Explode(bool flashingVFX) {} // 0x0000000186D15780-0x0000000186D163A0
		private void TriggerDespawnTimer() {} // 0x0000000186D163A0-0x0000000186D16690
		private void GenerateParticleSystems() {} // 0x0000000186D16690-0x0000000186D17A50
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D17A50-0x0000000186D17AC0
		public override void Despawn() {} // 0x0000000186C8B7D0-0x0000000186C8B860
	}
}
