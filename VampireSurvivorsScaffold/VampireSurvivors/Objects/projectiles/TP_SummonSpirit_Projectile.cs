/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SummonSpirit_Projectile : Projectile // TypeDefIndex: 15690
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private float _radius; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private float _IndexOffsetScaleFactor; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		public float2 _targetPosition; // 0xF8
		public float _timeSinceChangedTarget; // 0x100
		protected ParticleEmitterManager _pfxManager; // 0x108
		private ParticleSystem _pfx; // 0x110
		protected bool _emitParticles; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x120
		private bool _isDespawning; // 0x128
	
		// Properties
		protected virtual uint[] Tints { get => default; } // 0x0000000186D32450-0x0000000186D324B0 
	
		// Constructors
		public TP_SummonSpirit_Projectile() {} // 0x0000000186D323E0-0x0000000186D32450
	
		// Methods
		protected override void Awake() {} // 0x0000000186D324B0-0x0000000186D325B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D325B0-0x0000000186D32D40
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D32D40-0x0000000186D32E20
		private void StartDespawn() {} // 0x0000000186D32E20-0x0000000186D330E0
		public override void Despawn() {} // 0x0000000186D330E0-0x0000000186D33150
		private void GenerateParticleSystem() {} // 0x0000000186D33150-0x0000000186D33B10
		public override void InternalUpdate() {} // 0x0000000186D33B10-0x0000000186D33B30
		protected virtual void UpdatePfx() {} // 0x0000000186D33B30-0x0000000186D33CF0
	}
}
