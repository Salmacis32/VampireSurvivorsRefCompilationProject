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
	public class TP_DragonWater1Head_Projectile : Projectile // TypeDefIndex: 15553
	{
		// Fields
		private const float Radius = 24f; // Metadata: 0x019776D3
		private TP_DragonWater1_Weapon _parentWeapon; // 0xD0
		private bool _isDespawning; // 0xD8
		private PhaserSprite _headSprite; // 0xE0
		private float _scaledAlpha; // 0xE8
		private float _cachedProjSpeed; // 0xEC
		private float _cachedWeaponArea; // 0xF0
		private float _cachedWeaponHitBoxDelayOverSpeed; // 0xF4
		private float _cachedWeaponSpeed; // 0xF8
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
		private bool _movementTimerStarted; // 0x148
		private float2 _rotationDurationRange; // 0x14C
		private float2 _forwardDurationRange; // 0x154
		private int _repeatInterval; // 0x15C
		private float _cachedWeaponSpeedRepeatInterval; // 0x160
		private int _rotationDirection; // 0x164
		private float _scale; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x170
		private VampireSurvivors.Framework.TimerSystem.Timer _moveTimer; // 0x178
		private List<TP_DragonWater1Tail_Projectile> _tails; // 0x180
		private int _tailAmount; // 0x188
		private float2 _tailSpawnPos; // 0x18C
		private float _tailSpawnTimer; // 0x194
	
		// Properties
		public List<Vector3> Positions { get => default; } // 0x00000001829475F0-0x0000000182947600 
		public List<Quaternion> Rotations { get => default; } // 0x0000000182937BD0-0x0000000182937BE0 
		public float Scale { get => default; } // 0x00000001829505F0-0x0000000182950600 
		public float CachedWeaponHitBoxDelayOverSpeed { get => default; } // 0x00000001866FAF80-0x00000001866FAFF0 
		public float ScaledAlpha { get => default; } // 0x00000001866FAF70-0x00000001866FAF80 
	
		// Constructors
		public TP_DragonWater1Head_Projectile() {} // 0x0000000186C9B070-0x0000000186C9B0F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C98ED0-0x0000000186C99140
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C99140-0x0000000186C99E10
		public override void InternalUpdate() {} // 0x0000000186C99E10-0x0000000186C9A580
		public void SetMovementPath(List<float> rotations, List<float> forwards, bool isMirrored = false /* Metadata: 0x019776D2 */) {} // 0x0000000186C9A580-0x0000000186C9A660
		private void StartRotationTimer() {} // 0x0000000186C9A660-0x0000000186C9A7F0
		private void StartForwardTimer() {} // 0x0000000186C9A7F0-0x0000000186C9A9B0
		private void StartDespawn() {} // 0x0000000186C9A9B0-0x0000000186C9ACD0
		public override void Despawn() {} // 0x0000000186C9ACD0-0x0000000186C9AFE0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C9AFE0-0x0000000186C9B070
	}
}
