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
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_BloodProjectile_Special_ScarletHarbinger : Projectile // TypeDefIndex: 15752
	{
		// Fields
		[SerializeField]
		private List<Color> _tints; // 0xD0
		protected List<VampireSurvivors.Framework.Particles.BlendMode> _blendModes; // 0xD8
		protected MultiTargetTween _alphaTween; // 0xE0
		protected MultiTargetTween _scaleTween; // 0xE8
		protected ParticleSystem _damageVfx; // 0xF0
		protected ParticleEmitterManager _particlesManager; // 0xF8
		protected GravityWell _well; // 0x100
		protected VampireSurvivors.Framework.TimerSystem.Timer bloodTimer; // 0x108
		protected VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0x110
		protected PhaserSprite _displaySprite; // 0x118
		protected EnemyController _myTarget; // 0x120
		protected bool _targetFound; // 0x128
		protected bool isFirstUpdate; // 0x129
		private Tween _wellTween; // 0x130
		[SerializeField]
		private SpriteRenderer _rockSprite; // 0x138
		[SerializeField]
		private SpriteRenderer _starSprite; // 0x140
		[SerializeField]
		private SpriteRenderer _starSprite2; // 0x148
		[SerializeField]
		private SpriteRenderer _bubbleSprite; // 0x150
		[SerializeField]
		private SpriteAnimation _animation; // 0x158
		private bool _initialisedParticles; // 0x160
		private MultiTargetTween _tween; // 0x168
		private MultiTargetTween _tween2; // 0x170
		private MultiTargetTween _tween3; // 0x178
		private MultiTargetTween _tween4; // 0x180
		private MultiTargetTween _tween5; // 0x188
		private MultiTargetTween _tween6; // 0x190
	
		// Properties
		protected string FrameName { get => default; } // 0x0000000186D72B90-0x0000000186D72BD0 
		protected float ExpireTime { get => default; } // 0x0000000186D72BD0-0x0000000186D72BE0 
	
		// Constructors
		public EME_BloodProjectile_Special_ScarletHarbinger() {} // 0x0000000186D75E40-0x0000000186D760A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D72BE0-0x0000000186D72E90
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D72E90-0x0000000186D735A0
		protected void MakeEmitter() {} // 0x0000000186D735A0-0x0000000186D74330
		private void LateUpdate() {} // 0x0000000186D74330-0x0000000186D74350
		public void Activate() {} // 0x0000000186D74350-0x0000000186D74C90
		public override void Despawn() {} // 0x0000000186D6EAC0-0x0000000186D6EB40
		private void FadeOut() {} // 0x0000000186D74C90-0x0000000186D74F90
		private void OnRecycle(float salvoDuration) {} // 0x0000000186D74F90-0x0000000186D75350
		private void DisplayMe(float salvoDuration) {} // 0x0000000186D75350-0x0000000186D75E40
	}
}
