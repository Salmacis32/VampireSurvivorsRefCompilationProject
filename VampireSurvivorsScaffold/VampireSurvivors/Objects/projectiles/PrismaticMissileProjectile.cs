/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
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
	public class PrismaticMissileProjectile : Projectile // TypeDefIndex: 15428
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD8
		private MultiTargetTween _fadeInTween; // 0xE0
		private MultiTargetTween _fadeOutTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xF0
		private MultiTargetTween _despawnTween; // 0xF8
		private float _defaultFallDuration; // 0x100
		private float _fallDuration; // 0x104
		private PrismaticMissileWeapon _trueWeapon; // 0x108
		private MultiTargetTween _scaleTween; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _explodeTimer; // 0x118
		private string _frameNameBeam; // 0x120
		private float _startingAlpha; // 0x128
		private float _startingAngle; // 0x12C
		private float _startingX; // 0x130
		private float _angleIncrement; // 0x134
		private bool _showTrailOnSecondUpdate; // 0x138
		private float _updateTicks; // 0x13C
		private PhaserSprite _groundFx; // 0x140
		private ParticleEmitterManager _pfxManager; // 0x148
		private ParticleSystem _pfxEmitter; // 0x150
		private GravityWell _well; // 0x158
		private Circle _explosionCircle; // 0x160
		private float _exploRadius; // 0x168
		private MultiTargetTween _groundFxTween; // 0x170
		private float _angleUnit; // 0x178
		private float2 _pfxLocation; // 0x17C
		private uint[] _colors; // 0x188
		[NonSerialized]
		public float Radius; // 0x190
		[NonSerialized]
		public float _startingY; // 0x194
		private bool isHoming; // 0x198
	
		// Constructors
		public PrismaticMissileProjectile() {} // 0x0000000186BF2F40-0x0000000186BF3100
	
		// Methods
		protected override void Awake() {} // 0x0000000186BEFB40-0x0000000186BF0D00
		private void MakeTrail() {} // 0x0000000186BF0D00-0x0000000186BF0EB0
		private void SetTrailTextureFromIndex() {} // 0x0000000186BF0EB0-0x0000000186BF14A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BF14A0-0x0000000186BF27C0
		public void BeforeDespawn() {} // 0x0000000186BF27C0-0x0000000186BF2980
		public override void Despawn() {} // 0x0000000186BF2980-0x0000000186BF2A10
		public override void InternalUpdate() {} // 0x0000000186BF2A10-0x0000000186BF2E30
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BF2E30-0x0000000186BF2F40
	}
}
