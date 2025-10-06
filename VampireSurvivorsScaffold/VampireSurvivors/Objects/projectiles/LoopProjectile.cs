/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class LoopProjectile : Projectile // TypeDefIndex: 15917
	{
		// Fields
		[SerializeField]
		private SpriteScroller _SpriteScroller; // 0xD0
		[SerializeField]
		private SpriteRenderer _Graphics; // 0xD8
		[SerializeField]
		private SpriteRenderer _Graphics2; // 0xE0
		private ParticleEmitterManager _PfxEmitterManager; // 0xE8
		private Tween _moveTween; // 0xF0
		private MultiTargetTween _despawnTween; // 0xF8
		private MultiTargetTween _hitGroundTween; // 0x100
		private MultiTargetTween _chargeTween; // 0x108
		private MultiTargetTween _secondMoveTween; // 0x110
		private MultiTargetTween _finalScaleGroundTween; // 0x118
		private bool _isGrounded; // 0x120
		private ParticleSystem _PfxEmitter1; // 0x128
		private Circle _explosionCircle; // 0x130
	
		// Constructors
		public LoopProjectile() {} // 0x0000000186E40030-0x0000000186E40080
	
		// Methods
		protected override void Awake() {} // 0x0000000186E3DA70-0x0000000186E3E750
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E3E750-0x0000000186E3F440
		[IteratorStateMachine(typeof(_DespawnInAFrame_d__15))]
		private IEnumerator DespawnInAFrame() => default; // 0x0000000186E3F440-0x0000000186E3F4E0
		public override void Despawn() {} // 0x0000000186E3F4E0-0x0000000186E3F560
		private void Strike(Transform target) {} // 0x0000000186E3F560-0x0000000186E3FE80
		public override void InternalUpdate() {} // 0x0000000186E3FE80-0x0000000186E40030
		private void LateUpdate() {} // 0x0000000186D38290-0x0000000186D38490
	}
}
