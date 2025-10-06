/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Wind1_Projectile : Projectile // TypeDefIndex: 15720
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private Vector2 _initialVel; // 0xD8
		private float _startingAngle; // 0xE0
		private float GravX; // 0xE4
		private float GravY; // 0xE8
		private float _bodyRadius; // 0xEC
		private float _spriteSize; // 0xF0
		protected float[] _firingAngles; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _fadeInTrailTween; // 0x108
		protected float _trailAlpha; // 0x110
		private bool _mirrored; // 0x114
		private bool _flip; // 0x115
		private DG.Tweening.Sequence _windSequence; // 0x118
	
		// Constructors
		public TP_Wind1_Projectile() {} // 0x0000000186D4EBE0-0x0000000186D4ED10
	
		// Methods
		protected override void Awake() {} // 0x0000000186D4D000-0x0000000186D4D1A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C93600-0x0000000186C93610
		public void SetFlip(bool __flip) {} // 0x0000000186D4D1A0-0x0000000186D4E010
		private void StartDespawn() {} // 0x0000000186D4E010-0x0000000186D4E430
		public override void InternalUpdate() {} // 0x0000000186D4E430-0x0000000186D4E6B0
		private float UpdateTrailAlpha() => default; // 0x0000000186D4E6B0-0x0000000186D4E760
		public override void Despawn() {} // 0x0000000186D4E760-0x0000000186D4E8E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D4E8E0-0x0000000186D4E9F0
		private void SetupTrail() {} // 0x0000000186D4E9F0-0x0000000186D4EBE0
	}
}
