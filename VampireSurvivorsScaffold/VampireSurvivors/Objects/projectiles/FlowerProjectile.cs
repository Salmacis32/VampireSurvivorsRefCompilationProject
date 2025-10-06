/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
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
	public class FlowerProjectile : Projectile // TypeDefIndex: 15876
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		[SerializeField]
		private PhaserSprite _FlowerSprite; // 0xD8
		private Circle _a; // 0xE0
		private bool _particlesGenerated; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0xF0
		private MultiTargetTween _angleTween; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private float _saveVelX; // 0x108
		private float _saveVelY; // 0x10C
		private MultiTargetTween _speedTween; // 0x110
		private float _initialVelocityX; // 0x118
		private float _initialVelocityY; // 0x11C
		public float _BombDeceleration; // 0x120
		private GravityWell _well; // 0x128
		private Vector2 _aimVec; // 0x130
		private bool _canBounce; // 0x138
		private MultiTargetTween _tween2; // 0x140
		private MultiTargetTween _tween1; // 0x148
		private float _bounceAreaMod; // 0x150
		private int _radius; // 0x154
		private List<string> _flowerNames; // 0x158
		private ParticleEmitterManager _particles; // 0x160
		private ParticleSystem _fwEmitter2; // 0x168
		private Vector2 _previousVector; // 0x170
		private Vector2 _newAim; // 0x178
		public float _ScaleAfterBounceMod; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x188
		private uint[] _onEmitCustomTint; // 0x190
		private SfxType[] _soundArray; // 0x198
		private Transform _cachedRendererTransform; // 0x1A0
		private Transform _cachedFlowerTransform; // 0x1A8
		private Tween _colliderTween; // 0x1B0
	
		// Properties
		public HashSet<IDamageable> objectsHit { get => default; } // 0x00000001827666D0-0x00000001827666E0 
	
		// Constructors
		public FlowerProjectile() {} // 0x0000000186E15A60-0x0000000186E15D60
	
		// Methods
		protected override void Awake() {} // 0x0000000186E11800-0x0000000186E131D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E131D0-0x0000000186E14B10
		public void SizeUp() {} // 0x0000000186E14B10-0x0000000186E14E50
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186E14E50-0x0000000186E14F00
		public override void InternalUpdate() {} // 0x0000000186E14F00-0x0000000186E156F0
		private void FadeOut() {} // 0x0000000186E156F0-0x0000000186E159C0
		private float MyScale() => default; // 0x0000000186E10B00-0x0000000186E10B50
		public override void Despawn() {} // 0x0000000186E10B50-0x0000000186E10DF0
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E159C0-0x0000000186E15A60
	}
}
