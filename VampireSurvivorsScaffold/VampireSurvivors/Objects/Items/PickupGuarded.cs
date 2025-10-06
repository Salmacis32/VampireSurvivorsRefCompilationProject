/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupGuarded : NetworkPickup // TypeDefIndex: 16051
	{
		// Fields
		protected Transform _cachedTransform; // 0x170
		protected VampireSurvivors.Objects.Stage _stage; // 0x178
		protected Camera _camera; // 0x180
		protected float _left; // 0x188
		protected float _right; // 0x18C
		protected float _top; // 0x190
		protected float _bottom; // 0x194
		protected bool _hasSpawned; // 0x198
		protected float _guardRadius; // 0x19C
		protected EnemyType _enemyType; // 0x1A0
		protected int _spawnQuantity; // 0x1A4
		protected bool _hasAssignedSpawnData; // 0x1A8
		protected int _eventID; // 0x1AC
		protected bool _vfxEnabled; // 0x1B0
		private float _totalTime; // 0x1B4
		private const float ParticlesInterval = 0.040000003f; // Metadata: 0x019779F4
		private const float Radius = 1.4399999f; // Metadata: 0x019779F8
		private readonly List<EnemyController> Guards; // 0x1C0
	
		// Properties
		[Sync]
		public bool IsAnyGuardAlive { get; set; } // 0x0000000186ECC310-0x0000000186ECC320 0x0000000186ECC320-0x0000000186ECC330
		public float SpawnAngle { get; set; } // 0x0000000186ECC330-0x0000000186ECC340 0x0000000186ECC340-0x0000000186ECC350
		[Sync]
		public bool HasSpawned { get => default; set {} } // 0x00000001853F8F90-0x00000001853F8FA0 0x00000001853F8FA0-0x00000001853F8FB0
		public bool SkipOnlineGuardsCheckOnDespawn { get; set; } // 0x0000000186ECC350-0x0000000186ECC360 0x0000000186ECC360-0x0000000186ECC370
	
		// Constructors
		public PickupGuarded() {} // 0x0000000186ECD700-0x0000000186ECD810
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000185637EC0-0x0000000185637F20
		protected override void Awake() {} // 0x0000000186ECC370-0x0000000186ECC460
		protected virtual void OnDrawGizmosSelected() {} // 0x0000000186ECC460-0x0000000186ECC860
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186ECC860-0x0000000186ECC8A0
		public override void InternalUpdate() {} // 0x0000000186ECC8A0-0x0000000186ECC8F0
		public void SetEnemySpawnType(EnemyType enemyType, int spawnQuantity) {} // 0x0000000186ECC8F0-0x0000000186ECC920
		public override void Despawn() {} // 0x0000000186ECC920-0x0000000186ECCA40
		protected void SetParticleEffectsActive(bool particleEffectsActive) {} // 0x0000000186ECCA40-0x0000000186ECCA50
		[IteratorStateMachine(typeof(_DeferredReturnToPool_d__41))]
		private IEnumerator DeferredReturnToPool() => default; // 0x0000000186ECCA50-0x0000000186ECCAF0
		private bool IsAnyPlayerInGuardSpawnRange() => default; // 0x0000000186ECCAF0-0x0000000186ECCD00
		protected virtual void OnRecycle() {} // 0x0000000186ECCD00-0x0000000186ECCEE0
		public void ChangeActiveRadius(float pixelRadius = 32f /* Metadata: 0x019779F0 */) {} // 0x0000000186ECCEE0-0x0000000186ECD000
		protected virtual void TriggerSpawn() {} // 0x0000000186ECD000-0x0000000186ECD450
		protected void CheckSpawnParticles() {} // 0x0000000186ECD450-0x0000000186ECD5A0
		protected bool AnyGuardsAlive() => default; // 0x0000000186ECD5A0-0x0000000186ECD700
	}
}
