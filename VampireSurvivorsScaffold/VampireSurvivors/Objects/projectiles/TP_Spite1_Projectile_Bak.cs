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
	public class TP_Spite1_Projectile_Bak : Projectile // TypeDefIndex: 15679
	{
		// Fields
		[SerializeField]
		private TrailRenderer _LightTrail; // 0xD0
		[SerializeField]
		private TrailRenderer _DarkTrail; // 0xD8
		[SerializeField]
		private Transform _Light; // 0xE0
		[SerializeField]
		private Transform _Dark; // 0xE8
		private Vector2 _initialVel; // 0xF0
		private float _startingAngle; // 0xF8
		private float _bodyRadius; // 0xFC
		protected float[] _firingAngles; // 0x100
		private MultiTargetTween _scaleTween; // 0x108
		private MultiTargetTween _fadeInTrailTween; // 0x110
		protected float _trailAlpha; // 0x118
		private bool _mirrored; // 0x11C
		private bool _flip; // 0x11D
		private DG.Tweening.Sequence _windSequence; // 0x120
		private float _waveAngle; // 0x128
		private float _waveIncrement; // 0x12C
	
		// Constructors
		public TP_Spite1_Projectile_Bak() {} // 0x0000000186D278C0-0x0000000186D279D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D264B0-0x0000000186D264D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D264D0-0x0000000186D26500
		public void SetFlip(bool __flip) {} // 0x0000000186D26500-0x0000000186D26DE0
		private void StartDespawn() {} // 0x0000000186D26DE0-0x0000000186D27070
		public override void InternalUpdate() {} // 0x0000000186D27070-0x0000000186D27240
		public override void Despawn() {} // 0x0000000186D27240-0x0000000186D27460
		private void SetupTrail() {} // 0x0000000186D27460-0x0000000186D278C0
	}
}
