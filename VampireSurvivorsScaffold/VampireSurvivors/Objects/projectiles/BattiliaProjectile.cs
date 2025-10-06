/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BattiliaProjectile : Projectile // TypeDefIndex: 15382
	{
		// Fields
		protected float fixedDuration; // 0xD0
		protected uint shadowTint; // 0xD4
		private float _currentDirectionX; // 0xD8
		private float _currentDirectionY; // 0xDC
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		protected PhaserSprite _batSprite; // 0xE8
		protected PhaserSprite _shadowSprite; // 0xF0
		private float2 previousPosition; // 0xF8
		private BattiliaWeapon trueWeapon; // 0x100
		private bool isInitialised; // 0x108
		private bool isFirstUpdate; // 0x109
	
		// Properties
		public float TrueSpeed { get => default; } // 0x0000000186BABE30-0x0000000186BABF90 
	
		// Constructors
		public BattiliaProjectile() {} // 0x0000000186BAD3C0-0x0000000186BAD430
	
		// Methods
		protected override void Awake() {} // 0x0000000186BABF90-0x0000000186BAC480
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BAC480-0x0000000186BACC80
		protected virtual void SetAnims() {} // 0x0000000186BACC80-0x0000000186BACD50
		protected virtual void SetColors() {} // 0x0000000186BACD50-0x0000000186BACD80
		public override void ApplyInitialVelocity(Transform target, Transform playerTransform, bool rotate = true /* Metadata: 0x0197760C */, Vector3? customFromPosition = default) {} // 0x0000000186BACD80-0x0000000186BAD0E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186BAD0E0-0x0000000186BAD170
		public void RestoreVelocity() {} // 0x0000000186BAD170-0x0000000186BAD1B0
		public override void InternalUpdate() {} // 0x0000000186BAD1B0-0x0000000186BAD370
		public override void Despawn() {} // 0x0000000186BAD370-0x0000000186BAD3C0
	}
}
