/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MechProjectile_BallisticMissile : Projectile // TypeDefIndex: 15813
	{
		// Fields
		[SerializeField]
		private ParticleSystem _MissileVFX; // 0xD0
		[SerializeField]
		private TrailRenderer _Trail; // 0xD8
		private const float VFXScale = 0.75f; // Metadata: 0x01977894
		private const float TrailDuration = 800f; // Metadata: 0x01977898
		protected VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0xE0
		protected VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
		private bool _cachedFlipX; // 0xF0
		private float _cachedWeaponSpeed; // 0xF4
		private float _cachedProjSpeed; // 0xF8
		private float _currentSpeed; // 0xFC
		private float _currentAngle; // 0x100
		protected float _scaledTurnSpeed; // 0x104
		protected float _scaledTurnDuration; // 0x108
		protected float _scaledTurnDelay; // 0x10C
		private bool _isDecelerating; // 0x110
		private bool _isTurning; // 0x111
		private bool _isAccelerating; // 0x112
		private bool _isDespawning; // 0x113
		private bool _hasExploded; // 0x114
	
		// Properties
		protected virtual float Radius { get => default; } // 0x0000000185C62C10-0x0000000185C62C20 
		protected virtual float2 SpawnOffset { get => default; } // 0x0000000186DCAF30-0x0000000186DCAF40 
		protected virtual List<float> SpawnAngles { get => default; } // 0x0000000186DCAF40-0x0000000186DCB490 
		protected virtual float TurnSpeed { get => default; } // 0x0000000186DCB490-0x0000000186DCB4A0 
		protected virtual float TurnDuration { get => default; } // 0x0000000186D7E010-0x0000000186D7E020 
		protected virtual float TurnDelay { get => default; } // 0x0000000186DCB4A0-0x0000000186DCB4B0 
		protected virtual float DecelRate { get => default; } // 0x0000000185EC0950-0x0000000185EC0960 
		protected virtual float AccelRate { get => default; } // 0x000000018652E810-0x000000018652E820 
	
		// Constructors
		public EME_MechProjectile_BallisticMissile() {} // 0x0000000186D7E1B0-0x0000000186D7E200
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DCB4B0-0x0000000186DCBB10
		public override void InternalUpdate() {} // 0x0000000186DCBB10-0x0000000186DCBB30
		private void CheckHittingScreenEdges() {} // 0x0000000186DCBB30-0x0000000186DCBD40
		protected virtual void OnHitScreenEdgeTop() {} // 0x0000000180B15170-0x0000000180B15180
		protected virtual void OnHitScreenEdgeBottom() {} // 0x0000000186DCBD40-0x0000000186DCBD50
		protected virtual void OnHitScreenEdgeRight() {} // 0x0000000186DCBD40-0x0000000186DCBD50
		protected virtual void OnHitScreenEdgeLeft() {} // 0x0000000186DCBD40-0x0000000186DCBD50
		protected virtual void SetMovementPattern() {} // 0x0000000186DCBD50-0x0000000186DCBE80
		protected void UpdateVelocity() {} // 0x0000000186DCBE80-0x0000000186DCC1C0
		protected void StartDecelerating() {} // 0x0000000186DCC1C0-0x0000000186DCC1D0
		protected void EnableTurning(bool enable) {} // 0x000000018675B850-0x000000018675B860
		protected void StartAccelerating() {} // 0x0000000186DCC1D0-0x0000000186DCC1E0
		protected void ResetMovementSpeed() {} // 0x0000000186DCC1E0-0x0000000186DCC1F0
		protected void EnableTrail(bool enable) {} // 0x0000000186DCC1F0-0x0000000186DCC2F0
		private void SetupTrail() {} // 0x0000000186DCC2F0-0x0000000186DCC770
		private void PlaySfx() {} // 0x0000000186DCC770-0x0000000186DCC840
		private void StartDespawn() {} // 0x0000000186DCC840-0x0000000186DCCA50
		public override void Despawn() {} // 0x0000000186DCCA50-0x0000000186DCCB70
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DCCB70-0x0000000186DCCC80
	}
}
