/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_PunchProjectile_Firefist : Projectile // TypeDefIndex: 15826
	{
		// Fields
		[SerializeField]
		private ParticleSystem firefistVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall firefistVFXparticleEventCall; // 0xD8
		private const float VFXDuration = 2000f; // Metadata: 0x019778D8
		private float height; // 0xE0
		private Vector3 _firefistPillarScale; // 0xE4
		private bool _hasExploded; // 0xF0
		private float2 _bodySize; // 0xF4
		private float2 _bodyOffset; // 0xFC
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
	
		// Constructors
		public EME_PunchProjectile_Firefist() {} // 0x0000000186DD8DB0-0x0000000186DD8E10
	
		// Methods
		protected override void Awake() {} // 0x0000000186DD8100-0x0000000186DD82F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD82F0-0x0000000186DD8570
		private void SetupMechanics() {} // 0x0000000186DD8570-0x0000000186DD8950
		private void SetupVFX() {} // 0x0000000186DD8950-0x0000000186DD8AB0
		public override void InternalUpdate() {} // 0x0000000186DD8AB0-0x0000000186DD8AC0
		private void UpdateBody() {} // 0x0000000186DD8AC0-0x0000000186DD8C00
		public override void Despawn() {} // 0x0000000186DD8C00-0x0000000186DD8C60
		private void DespawnAfterParticlesStopped() {} // 0x0000000186DD8C60-0x0000000186DD8CA0
		private void FinishDespawn() {} // 0x0000000186DD8C60-0x0000000186DD8CA0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD8CA0-0x0000000186DD8DB0
	}
}
