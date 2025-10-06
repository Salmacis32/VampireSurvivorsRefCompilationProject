/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class CherryProjectile : Projectile // TypeDefIndex: 15409
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xD0
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xD8
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0xE0
		private Tween _angleTween; // 0xE8
		private Tween _speedTween; // 0xF0
		private Tween _scaleTween; // 0xF8
		private Tween _bodyScaleTween; // 0x100
		private DG.Tweening.Sequence _tween1; // 0x108
		private DG.Tweening.Sequence _tween2; // 0x110
		private Tween _tween3; // 0x118
		private DG.Tweening.Sequence _tween4; // 0x120
		private DG.Tweening.Sequence _tween5; // 0x128
		private Tween _tween6; // 0x130
		private VampireSurvivors.Framework.TimerSystem.Timer _bounceTimer; // 0x138
		private float _save_vel_x; // 0x140
		private float _save_vel_y; // 0x144
		private Vector2 _aimVector; // 0x148
		private bool _canBounce; // 0x150
		private float _bombDeceleration; // 0x154
		private uint[] _onEmitCustomTints; // 0x158
		private uint[] _onEmitcustomTint2; // 0x160
		private ParticleEmitterManager _particleEmitterManager; // 0x168
		private ParticleSystem _fwEmitter; // 0x170
		private ParticleSystem _fwEmitter2; // 0x178
		private Circle _a; // 0x180
		private bool _particlesGenerated; // 0x188
		private CherryWeapon _trueWeapon; // 0x190
	
		// Constructors
		public CherryProjectile() {} // 0x0000000186BD3AA0-0x0000000186BD3D20
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BCEA40-0x0000000186BCF6D0
		private void ResetRenderers() {} // 0x0000000186BCF6D0-0x0000000186BCF900
		private void GenerateParticleSystems() {} // 0x0000000186BCF900-0x0000000186BD10F0
		private void TryDetonate() {} // 0x0000000186BD10F0-0x0000000186BD2BE0
		public override void Despawn() {} // 0x0000000186BD2BE0-0x0000000186BD2C40
		private void PlayAudio() {} // 0x0000000186BD2C40-0x0000000186BD2DA0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BD2DA0-0x0000000186BD2F50
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BD2F50-0x0000000186BD3000
		public override void InternalUpdate() {} // 0x0000000186BD3000-0x0000000186BD3060
		public void SetIsStar() {} // 0x0000000186BD3060-0x0000000186BD3AA0
	}
}
