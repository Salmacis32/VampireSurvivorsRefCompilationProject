/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Bwaka1_Projectile : Projectile // TypeDefIndex: 15507
	{
		// Fields
		private float _deltaTime; // 0xD0
		private const float _orbitPercentage = 0.125f; // Metadata: 0x01977687
		private const float _orbitModifier = 75f; // Metadata: 0x0197768B
		private const float _rotationModifier = 360f; // Metadata: 0x0197768F
		private Vector3 _centralPos; // 0xD4
		private Vector3 _velocity; // 0xE0
		private float _rotationInc; // 0xEC
		private float _flipSwitch; // 0xF0
		private bool _cachedFlipX; // 0xF4
		private VampireSurvivors.Framework.TimerSystem.Timer _durationTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0x100
		private const float _bodyDisableDuration = 250f; // Metadata: 0x01977693
	
		// Properties
		protected virtual string FrameName { get => default; } // 0x0000000186C6DB30-0x0000000186C6DB70 
		protected virtual bool InfiniteBounces { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual float Radius { get => default; } // 0x0000000186C6DB70-0x0000000186C6DB80 
		protected virtual float OrbitRadius { get => default; } // 0x0000000186C6DB70-0x0000000186C6DB80 
	
		// Constructors
		public TP_Bwaka1_Projectile() {} // 0x0000000186C6EBC0-0x0000000186C6EC10
	
		// Methods
		protected override void Awake() {} // 0x0000000186C6DB80-0x0000000186C6DC30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6DC30-0x0000000186C6E1A0
		public override void InternalUpdate() {} // 0x0000000186C6E1A0-0x0000000186C6E600
		private void StartDespawn() {} // 0x0000000186C6E600-0x0000000186C6E820
		public override void Despawn() {} // 0x0000000186C6E820-0x0000000186C6E860
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C6E860-0x0000000186C6E870
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C6E870-0x0000000186C6E910
		protected void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186C6E910-0x0000000186C6EA00
		private void OnBounce() {} // 0x0000000186C6EA00-0x0000000186C6EBC0
	}
}
