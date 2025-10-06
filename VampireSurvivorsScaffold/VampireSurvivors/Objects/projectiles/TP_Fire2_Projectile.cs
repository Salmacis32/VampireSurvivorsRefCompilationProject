/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Fire2_Projectile : Projectile // TypeDefIndex: 15571
	{
		// Fields
		private const float Radius = 24f; // Metadata: 0x019776F5
		private TP_Fire2_Weapon _parentWeapon; // 0xD0
		private bool _isDespawning; // 0xD8
		private PhaserSprite _headSprite; // 0xE0
		private float _scaledAlpha; // 0xE8
		private float _cachedProjSpeed; // 0xEC
		private float _cachedWeaponArea; // 0xF0
		private float _cachedWeaponHitBoxDelayOverSpeed; // 0xF4
		private float _cachedWeaponSpeed; // 0xF8
		private float _cachedWeaponSpeedRepeatInterval; // 0xFC
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _alphaTween; // 0x108
		private bool _cachedFlipX; // 0x110
		private float _turnAngle; // 0x114
		private float _turnSpeed; // 0x118
		private bool _isRotating; // 0x11C
		private List<Vector3> _positions; // 0x120
		private List<Quaternion> _rotations; // 0x128
		private List<float> _rotationPath; // 0x130
		private List<float> _forwardPath; // 0x138
		private int _rotationCounter; // 0x140
		private int _forwardCounter; // 0x144
		private bool _rotationTimerStarted; // 0x148
		private float _scale; // 0x14C
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x150
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _moveTimer; // 0x160
		private List<TP_Fire2Tail_Projectile> _tails; // 0x168
		private float2 _tailSpawnPos; // 0x170
		private float _tailSpawnTimer; // 0x178
	
		// Properties
		public List<Vector3> Positions { get => default; } // 0x00000001829475F0-0x0000000182947600 
		public List<Quaternion> Rotations { get => default; } // 0x0000000182937BD0-0x0000000182937BE0 
		public float Scale { get => default; } // 0x0000000186560A30-0x0000000186560A40 
		public float CachedWeaponArea { get => default; } // 0x000000018281C5E0-0x000000018281C5F0 
		public float CachedWeaponHitBoxDelayOverSpeed { get => default; } // 0x00000001866FAF80-0x00000001866FAFF0 
		public float ScaledAlpha { get => default; } // 0x00000001866FAF70-0x00000001866FAF80 
	
		// Constructors
		public TP_Fire2_Projectile() {} // 0x0000000186CB0F00-0x0000000186CB0F50
	
		// Methods
		protected override void Awake() {} // 0x0000000186CAEF70-0x0000000186CAF1E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CAF1E0-0x0000000186CAFC10
		public override void InternalUpdate() {} // 0x0000000186CAFC10-0x0000000186CB03D0
		public void SetMovementPath(List<float> rotations, List<float> forwards, bool isMirrored = false /* Metadata: 0x019776F4 */) {} // 0x0000000186CB03D0-0x0000000186CB04B0
		private void StartRotationTimer() {} // 0x0000000186CB04B0-0x0000000186CB0640
		private void StartForwardTimer() {} // 0x0000000186CB0640-0x0000000186CB07D0
		private void StartDespawn() {} // 0x0000000186CB07D0-0x0000000186CB0AF0
		public override void Despawn() {} // 0x0000000186CB0AF0-0x0000000186CB0E10
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CB0E10-0x0000000186CB0F00
	}
}
