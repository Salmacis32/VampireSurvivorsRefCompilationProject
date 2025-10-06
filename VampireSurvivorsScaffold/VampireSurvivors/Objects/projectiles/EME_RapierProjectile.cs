/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_RapierProjectile : Projectile // TypeDefIndex: 15831
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private EME_RapierWeapon _trueWeapon; // 0xE0
		private ParticleEmitterManager _pfxEmitterManager; // 0xE8
		private ParticleSystem _pfxEmitter; // 0xF0
		private bool _initialisedParticles; // 0xF8
		[SerializeField]
		private MeshRenderer _Quad1; // 0x100
		[SerializeField]
		private MeshRenderer _Quad2; // 0x108
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private bool _isFinisher; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x118
		private PhaserSprite _displayImage; // 0x120
	
		// Constructors
		public EME_RapierProjectile() {} // 0x0000000186DDDA10-0x0000000186DDDA60
		static EME_RapierProjectile() {} // 0x0000000186DDDA60-0x0000000186DDDB20
	
		// Methods
		protected override void Awake() {} // 0x0000000186DDBC00-0x0000000186DDBE50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DDBE50-0x0000000186DDCAF0
		public override void Despawn() {} // 0x0000000186DDCAF0-0x0000000186DDCC20
		public override void SetNullTarget() {} // 0x0000000186BB8730-0x0000000186BB8750
		public override void SetTarget(Transform target) {} // 0x0000000186DDCC20-0x0000000186DDD980
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DDD980-0x0000000186DDDA10
	}
}
