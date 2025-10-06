/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_AxeProjectile_ReverseDelta : Projectile // TypeDefIndex: 15745
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private EME_RapierWeapon _trueWeapon; // 0xE0
		private ParticleEmitterManager _pfxEmitterManager; // 0xE8
		private ParticleSystem _pfxEmitter; // 0xF0
		[SerializeField]
		private TrailRenderer _Trail1; // 0xF8
		[SerializeField]
		private TrailRenderer _Trail2; // 0x100
		[SerializeField]
		private TrailRenderer _Trail3; // 0x108
		[SerializeField]
		private ParticleSystem punchVFX; // 0x110
		[SerializeField]
		private MeshRenderer _Quad1; // 0x118
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private VampireSurvivors.Framework.TimerSystem.Timer _DespawnTimer; // 0x120
		private PhaserSprite _displayImage; // 0x128
		private float _offsetX; // 0x130
		private MultiTargetTween slashTween; // 0x138
		private MultiTargetTween modelTween1; // 0x140
		private MultiTargetTween modelTween2; // 0x148
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x150
		private PhaserSprite cloneImage1; // 0x158
		private PhaserSprite cloneImage2; // 0x160
		private PhaserSprite cloneImage3; // 0x168
		private MultiTargetTween clonesAlphaTween; // 0x170
		private Vector2[] _deltaPoints; // 0x178
		private List<Vector2> _currentDelta; // 0x180
		private float _radius; // 0x188
		private bool _isAttacking; // 0x18C
		private float _attackTime; // 0x190
		private VampireSurvivors.Framework.TimerSystem.Timer _attackAnimTimer; // 0x198
		private Tween _materialFadeTween; // 0x1A0
		private MultiTargetTween _blockAlphaTween; // 0x1A8
		private int _strikeTimes; // 0x1B0
	
		// Constructors
		public EME_AxeProjectile_ReverseDelta() {} // 0x0000000186D6C8A0-0x0000000186D6CAE0
		static EME_AxeProjectile_ReverseDelta() {} // 0x0000000186D6CAE0-0x0000000186D6CBA0
	
		// Methods
		private void LateUpdate() {} // 0x0000000186D698D0-0x0000000186D6A1E0
		private void MakeCloneSprites() {} // 0x0000000186D6A1E0-0x0000000186D6ACE0
		protected override void Awake() {} // 0x0000000186D6ACE0-0x0000000186D6B030
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D6B030-0x0000000186D6BC10
		private void Activate() {} // 0x0000000186D6BC10-0x0000000186D6C060
		public void StartDespawn() {} // 0x0000000186D6C060-0x0000000186D6C430
		public override void Despawn() {} // 0x0000000186D6C430-0x0000000186D6C4C0
		private void FadeClonesAlphaTo(float fadeToValue) {} // 0x0000000186D6C4C0-0x0000000186D6C770
		private void PlayStrikeAnim(float delay) {} // 0x0000000186D6C770-0x0000000186D6C8A0
	}
}
