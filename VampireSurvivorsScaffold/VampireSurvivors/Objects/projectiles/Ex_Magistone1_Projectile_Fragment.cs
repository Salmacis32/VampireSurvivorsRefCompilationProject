/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Ex_Magistone1_Projectile_Fragment : Projectile // TypeDefIndex: 15866
	{
		// Fields
		[SerializeField]
		private List<MeshRenderer> _FragmentMeshes; // 0xD0
		[SerializeField]
		private GameObject _MeshContainer; // 0xD8
		[SerializeField]
		private SpriteRenderer _ShadowSprite; // 0xE0
		private const float Radius = 56f; // Metadata: 0x01977919
		private const float Gravity = 6.25f; // Metadata: 0x0197791D
		private const float MinInitialSpeed = 2.5f; // Metadata: 0x01977921
		private const float MaxInitialSpeed = 3.5f; // Metadata: 0x01977925
		private const float ExtraSpeedForEvo = 1f; // Metadata: 0x01977929
		private const float BouncePosYVarianceLimit = 0.25f; // Metadata: 0x0197792D
		private Ex_Magistone1_Weapon _trueWeapon; // 0xE8
		private MeshRenderer _fragmentMesh; // 0xF0
		private Vector2 _velocity; // 0xF8
		private float _initialSpeed; // 0x100
		private int _flipSwitch; // 0x104
		private float _bouncePosY; // 0x108
		private float _bouncePosYVariance; // 0x10C
		private bool _hasBounced; // 0x110
		private bool _isDespawning; // 0x111
		private Vector3 _rotationEulers; // 0x114
		private float _scaleMultiplier; // 0x120
		private Tween _fadeTween; // 0x128
		private Tween _scaleTween; // 0x130
		private Tween _shadowFadeTween; // 0x138
		private Tween _shadowScaleTween; // 0x140
	
		// Properties
		public bool HasBounced { get => default; } // 0x0000000184BB1F80-0x0000000184BB1F90 
	
		// Constructors
		public Ex_Magistone1_Projectile_Fragment() {} // 0x0000000186E02230-0x0000000186E02280
	
		// Methods
		protected override void Awake() {} // 0x0000000186DFFFB0-0x0000000186E00120
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E00120-0x0000000186E00480
		public override void InternalUpdate() {} // 0x0000000186E00480-0x0000000186E00630
		private void InitVelocity() {} // 0x0000000186E00630-0x0000000186E00890
		private void UpdateVelocity() {} // 0x0000000186E00890-0x0000000186E009A0
		private void UpdateRotation() {} // 0x0000000186E009A0-0x0000000186E00A60
		private void InitShadow() {} // 0x0000000186E00A60-0x0000000186E00E00
		private void UpdateShadow() {} // 0x0000000186E00E00-0x0000000186E010B0
		private void InitRotation() {} // 0x0000000186E010B0-0x0000000186E01200
		private void CheckForBounce() {} // 0x0000000186E01200-0x0000000186E012A0
		private void FadeOut() {} // 0x0000000186E012A0-0x0000000186E01570
		public void SetupFragmentMesh(int index, uint tint) {} // 0x0000000186E01570-0x0000000186E01DF0
		public void SetFragmentScale(float scaleMultiplier) {} // 0x0000000186E01DF0-0x0000000186E02190
		private float GetScaledAlpha() => default; // 0x0000000186DFFB70-0x0000000186DFFBE0
		public override void Despawn() {} // 0x0000000186E02190-0x0000000186E02230
	}
}
