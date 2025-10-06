/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AlucardSword2_Projectile : Projectile // TypeDefIndex: 15500
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _AlucardSprite; // 0xD0
		[SerializeField]
		private SpriteRenderer _AlucardGlowSprite; // 0xD8
		[SerializeField]
		private SpriteRenderer _SwordSprite; // 0xE0
		private SpriteAnimation _alucardAnim; // 0xE8
		private SpriteAnimation _alucardGlowAnim; // 0xF0
		private SpriteAnimation _swordAnim; // 0xF8
		private const float SwordOffsetX = 0.16f; // Metadata: 0x01977657
		private const float SwordOffsetY = 0.08f; // Metadata: 0x0197765B
		private int _evoCount; // 0x100
		private List<string> _swordSpriteNames; // 0x108
		private List<uint> _glowTints; // 0x110
		private bool _initSpriteTrail; // 0x118
		private bool _cachedFlipX; // 0x119
		private const float DashDuration = 750f; // Metadata: 0x0197765F
		private int _numSlashes; // 0x11C
		private float _slashesRemaining; // 0x120
		private List<float> _ghostYOffsets; // 0x128
		private float _ghostYOffsetMul; // 0x130
		private TP_AlucardSword2_Weapon _trueWeapon; // 0x138
		private Tween _posTween; // 0x140
		private MultiTargetTween _alphaTween; // 0x148
		private VampireSurvivors.Framework.TimerSystem.Timer _slashTimer; // 0x150
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0x158
	
		// Properties
		private float ScaledAlpha { get => default; } // 0x0000000186C60DA0-0x0000000186C60E10 
	
		// Constructors
		public TP_AlucardSword2_Projectile() {} // 0x0000000186C63A70-0x0000000186C64370
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C60E10-0x0000000186C61A00
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Despawn() {} // 0x0000000186C61A00-0x0000000186C61A90
		private void LateUpdate() {} // 0x0000000186C61A90-0x0000000186C61BA0
		private void InitAnimations() {} // 0x0000000186C61BA0-0x0000000186C62290
		private void StartFadeIn() {} // 0x0000000186C62290-0x0000000186C624F0
		private void DashToPosition(Vector3 pos) {} // 0x0000000186C624F0-0x0000000186C62870
		private void SlashAttack() {} // 0x0000000186C62870-0x0000000186C62B10
		private void OnSlashComplete() {} // 0x0000000186C62B10-0x0000000186C631F0
		private void StartDespawn() {} // 0x0000000186C631F0-0x0000000186C63560
		private void SetBodyForAlucard() {} // 0x0000000186C63560-0x0000000186C63600
		private void SetBodyForSlash() {} // 0x0000000186C63600-0x0000000186C637E0
		private void SetSwordOffset() {} // 0x0000000186C637E0-0x0000000186C63A70
	}
}
