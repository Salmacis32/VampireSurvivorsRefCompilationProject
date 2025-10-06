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
	public class TP_Dominus1_Projectile : Projectile // TypeDefIndex: 15544
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private bool _isDespawning; // 0xE8
		private List<uint> _tints; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x100
		private bool _canMove; // 0x108
		private MultiTargetTween _speedTween; // 0x110
		private bool _isMoving; // 0x118
		private string start; // 0x120
		private string loop; // 0x128
		private string startInverse; // 0x130
		private string loopInverse; // 0x138
		private TP_Dominus1_Weapon _trueWeapon; // 0x140
		private bool inverted; // 0x148
		private Vector2 _initialVelocity; // 0x14C
		private ParticleEmitterManager _pfxManager; // 0x158
		private ParticleSystem _pfx; // 0x160
		private float _amount; // 0x168
		private List<InvisibleProjectile> _damageBoxes; // 0x170
		private float _targetRadius; // 0x178
		private ParticleSystem _pfxInverse; // 0x180
		private List<string> _normalPFXFrames; // 0x188
		private List<string> _inversePFXFrames; // 0x190
		private Tween speedTween; // 0x198
	
		// Constructors
		public TP_Dominus1_Projectile() {} // 0x0000000186C91800-0x0000000186C92690
	
		// Methods
		protected override void Awake() {} // 0x0000000186C8F1D0-0x0000000186C90430
		public void OverrideVelocity(Vector2 velocity) {} // 0x0000000186C90430-0x0000000186C90440
		public void SetDamageBoxes(List<InvisibleProjectile> invis) {} // 0x0000000186C90440-0x0000000186C908A0
		public void LoopAnim() {} // 0x0000000186C908A0-0x0000000186C90900
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C90900-0x0000000186C90F10
		private void LateUpdate() {} // 0x0000000186C90F10-0x0000000186C91350
		private void StartDespawn() {} // 0x0000000186C91350-0x0000000186C91610
		public override void Despawn() {} // 0x0000000186C91610-0x0000000186C91800
	}
}
