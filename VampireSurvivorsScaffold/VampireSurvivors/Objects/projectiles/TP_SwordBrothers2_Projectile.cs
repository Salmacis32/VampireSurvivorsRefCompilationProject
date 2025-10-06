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
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SwordBrothers2_Projectile : Projectile // TypeDefIndex: 15695
	{
		// Fields
		[SerializeField]
		private SpriteScroller _SpriteScroller; // 0xD0
		[SerializeField]
		private SpriteRenderer _Graphics; // 0xD8
		[SerializeField]
		private SpriteRenderer _Graphics2; // 0xE0
		private const float BaseRadius = 16f; // Metadata: 0x019777B4
		private const int MiniSwordAmount = 32; // Metadata: 0x019777B8
		private TP_SwordBrothers2_Weapon _trueWeapon; // 0xE8
		private ParticleEmitterManager _PfxEmitterManager; // 0xF0
		private Tween _moveTween; // 0xF8
		private MultiTargetTween _despawnTween; // 0x100
		private MultiTargetTween _hitGroundTween; // 0x108
		private MultiTargetTween _chargeTween; // 0x110
		private MultiTargetTween _secondMoveTween; // 0x118
		private MultiTargetTween _finalScaleGroundTween; // 0x120
		private bool _isGrounded; // 0x128
		private ParticleSystem _PfxEmitter1; // 0x130
		private Circle _explosionCircle; // 0x138
		private Transform _target; // 0x140
		private PhaserSprite _swordSprite; // 0x148
		private List<PhaserSprite> _miniSwordSprites; // 0x150
		private List<VampireSurvivors.Framework.TimerSystem.Timer> _miniSwordTimers; // 0x158
		private bool _propelMiniSwords; // 0x160
		private float _miniSwordRendYOffset; // 0x164
	
		// Constructors
		public TP_SwordBrothers2_Projectile() {} // 0x0000000186D38490-0x0000000186D384E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D34590-0x0000000186D35AA0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D35AA0-0x0000000186D36860
		private void DoLightningTween() {} // 0x0000000186D36860-0x0000000186D36C80
		[IteratorStateMachine(typeof(_DespawnInAFrame_d__25))]
		private IEnumerator DespawnInAFrame() => default; // 0x0000000186D36C80-0x0000000186D36D20
		public override void Despawn() {} // 0x0000000186D36D20-0x0000000186D36DC0
		protected virtual void Strike(Transform target) {} // 0x0000000186D36DC0-0x0000000186D378E0
		private void DoSwordCircle() {} // 0x0000000186D378E0-0x0000000186D37CC0
		private void CancelMiniSwordTimers() {} // 0x0000000186D37CC0-0x0000000186D37D80
		public override void InternalUpdate() {} // 0x0000000186D37D80-0x0000000186D38290
		private void LateUpdate() {} // 0x0000000186D38290-0x0000000186D38490
	}
}
