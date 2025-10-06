/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class JetBlackProjectile : Projectile // TypeDefIndex: 15905
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _animation; // 0xD0
		[SerializeField]
		private SpriteRenderer _starSprite; // 0xD8
		[SerializeField]
		private SpriteRenderer _bubbleSprite; // 0xE0
		private bool _initialisedParticles; // 0xE8
		private GravityWell _gravityWell; // 0xF0
		private MultiTargetTween _tween; // 0xF8
		private MultiTargetTween _tween2; // 0x100
		private MultiTargetTween _tween3; // 0x108
		private float _radiusX; // 0x110
		private float _radiusY; // 0x114
		private float _offsetX; // 0x118
		private float _offsetY; // 0x11C
		private MultiTargetTween _tween4; // 0x120
		private Tween _dTween1; // 0x128
		private Tween _dTween2; // 0x130
		private float renderingAngle; // 0x138
		private float renderingAngle2; // 0x13C
		private float _radiusY2; // 0x140
		private float accelDuration; // 0x144
		private float accelTime; // 0x148
		private bool isActive; // 0x14C
		private ParticleEmitterManager _pfxManager; // 0x150
		private ParticleSystem _pfx; // 0x158
		private ParticleSystem _pfx2; // 0x160
		private float emissionTime; // 0x168
		private JetBlackWeapon _trueWeapon; // 0x170
	
		// Constructors
		public JetBlackProjectile() {} // 0x0000000186E38740-0x0000000186E387B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E36740-0x0000000186E368D0
		private void OnRecycle() {} // 0x0000000186E368D0-0x0000000186E36EE0
		private void FadeIn() {} // 0x0000000186E36EE0-0x0000000186E37210
		private void GenerateParticleSystem() {} // 0x0000000186E37210-0x0000000186E381F0
		public override void InternalUpdate() {} // 0x0000000186E381F0-0x0000000186E38740
	}
}
