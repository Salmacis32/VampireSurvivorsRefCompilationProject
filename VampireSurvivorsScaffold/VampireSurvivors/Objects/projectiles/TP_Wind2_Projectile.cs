/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Wind2_Projectile : Projectile // TypeDefIndex: 15721
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private float _startingAngle; // 0xD8
		private float _bodyRadius; // 0xDC
		private float _spriteSize; // 0xE0
		protected float[] _firingAngles; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private MultiTargetTween _fadeInTrailTween; // 0xF8
		protected float _trailAlpha; // 0x100
		private bool _mirrored; // 0x104
		private bool _flip; // 0x105
		private DG.Tweening.Sequence _windSequence; // 0x108
		private bool _isLight; // 0x110
		private float _waveAngle; // 0x114
		private float _waveIncrement; // 0x118
		private Vector3 _startingPosition; // 0x11C
		private Vector3 _startingOffset; // 0x128
		private float _height; // 0x134
		private Tween _heightTween; // 0x138
		private float _spriteRotateAngle; // 0x140
		private float _spriteRotateSpeed; // 0x144
	
		// Constructors
		public TP_Wind2_Projectile() {} // 0x0000000186D50D40-0x0000000186D50E70
	
		// Methods
		protected override void Awake() {} // 0x0000000186D4ED80-0x0000000186D4EF20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D4EF20-0x0000000186D4F060
		public void SetFlip(bool __flip, bool __horizontalMirror) {} // 0x0000000186D4F060-0x0000000186D4FFD0
		private void StartDespawn() {} // 0x0000000186D4FFD0-0x0000000186D503F0
		public override void InternalUpdate() {} // 0x0000000186D503F0-0x0000000186D50910
		private float UpdateTrailAlpha() => default; // 0x0000000186D50910-0x0000000186D509C0
		public override void Despawn() {} // 0x0000000186D509C0-0x0000000186D50B50
		private void SetupTrail() {} // 0x0000000186D50B50-0x0000000186D50D40
	}
}
