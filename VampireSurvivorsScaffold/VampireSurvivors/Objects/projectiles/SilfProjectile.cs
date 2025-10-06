/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SilfProjectile : Projectile // TypeDefIndex: 15955
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0xD0
		private PhaserSpline _spline; // 0xD8
		private float _totalTime; // 0xE0
		private float _duration; // 0xE4
		private bool _silfActive; // 0xE8
		private MultiTargetTween _hitScaleTween; // 0xF0
		private MultiTargetTween _hitFadeTween; // 0xF8
		private MultiTargetTween _hitFadeTrailTween; // 0x100
		private MultiTargetTween _fadeInTrailTween; // 0x108
		protected float _minAngleRotDeg; // 0x110
		protected float _maxAngleRotDeg; // 0x114
		protected Vector2 _targetPos; // 0x118
		protected SilfWeapon _trueWeapon; // 0x120
		protected float _trailAlpha; // 0x128
		protected float _startingAlpha; // 0x12C
	
		// Constructors
		public SilfProjectile() {} // 0x0000000186E6B100-0x0000000186E6B180
	
		// Methods
		protected override void Awake() {} // 0x0000000186E69550-0x0000000186E69640
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E69640-0x0000000186E69D60
		public override void InternalUpdate() {} // 0x0000000186E69D60-0x0000000186E69ED0
		protected virtual PhaserSpline GetSpline() => default; // 0x0000000186E69ED0-0x0000000186E6A230
		protected Vector2 RotatePoint(float targetX, float targetY, float angle, Vector2 origin) => default; // 0x0000000186BFAF80-0x0000000186BFB020
		private void OnHit() {} // 0x0000000186E6A230-0x0000000186E6A870
		public override void Despawn() {} // 0x0000000186E6A870-0x0000000186E6ABC0
		private void SetupTrail() {} // 0x0000000186E6ABC0-0x0000000186E6B040
		protected virtual string GetTrailTextureName() => default; // 0x0000000186E6B040-0x0000000186E6B100
	}
}
