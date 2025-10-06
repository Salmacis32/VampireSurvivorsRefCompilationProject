/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Javelin1_Projectile : Projectile // TypeDefIndex: 15601
	{
		// Fields
		private const float Gravity = 4f; // Metadata: 0x01977766
		private const float InitialAngle = 30f; // Metadata: 0x0197776A
		private const float Radius = 12f; // Metadata: 0x0197776E
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _alphaTween; // 0xD8
		private Vector2 _velocity; // 0xE0
		private Vector2 _initialVelocity; // 0xE8
		private bool _cachedFlipX; // 0xF0
		private float _flipNum; // 0xF4
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
	
		// Properties
		protected virtual string FrameName { get => default; } // 0x0000000186CD5A60-0x0000000186CD5AA0 
		protected virtual bool IsEvolution { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool WrapX { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool WrapY { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public TP_Javelin1_Projectile() {} // 0x0000000186CD72B0-0x0000000186CD7300
	
		// Methods
		protected override void Awake() {} // 0x0000000186CD5AA0-0x0000000186CD5B50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CD5B50-0x0000000186CD64B0
		protected override void OnUpdate() {} // 0x0000000186CD64B0-0x0000000186CD6800
		private void CheckForDespawn() {} // 0x0000000186CD6800-0x0000000186CD6890
		private void CheckForScreenWrapping() {} // 0x0000000186CD6890-0x0000000186CD6B20
		private void UpdateBody() {} // 0x0000000186CD6B20-0x0000000186CD6D20
		private void StartDespawn() {} // 0x0000000186CD6D20-0x0000000186CD6FC0
		public override void Despawn() {} // 0x0000000186CD6FC0-0x0000000186CD7020
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CD7020-0x0000000186CD7160
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
		private void OnHasHitAnObjectLogic(IDamageable other, bool triggerHit) {} // 0x0000000186CD7160-0x0000000186CD72B0
	}
}
