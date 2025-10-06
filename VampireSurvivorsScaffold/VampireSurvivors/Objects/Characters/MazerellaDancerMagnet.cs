/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class MazerellaDancerMagnet : MonoBehaviour // TypeDefIndex: 17207
	{
		// Fields
		[SerializeField]
		[Space]
		private ArcadeSprite _magnet; // 0x20
		[SerializeField]
		private float _magnetRadius; // 0x28
		[SerializeField]
		private float _maxPickupVacuumSpeed; // 0x2C
		[SerializeField]
		private float _pickupVacuumAcceleration; // 0x30
		[SerializeField]
		[Space]
		private float _pickupSpawnRadius; // 0x34
		[SerializeField]
		private float _maxExtraPickupSpawnDistance; // 0x38
		[SerializeField]
		private float _spawnTweenDuration; // 0x3C
		[SerializeField]
		[Space]
		private int _maxGemsToSpawn; // 0x40
		[SerializeField]
		private int _maxCoinsToSpawn; // 0x44
		[SerializeField]
		private int _maxFrozenSoulsToSpawn; // 0x48
		private bool _isEnabled; // 0x4C
		private int _numberOfPickupsToSpawn; // 0x50
		private int _spawningPickupIndex; // 0x54
		private ValuePickupSpawner _gemSpawner; // 0x58
		private ValuePickupSpawner _coinsSpawner; // 0x60
		private ValuePickupSpawner _frozenSoulSpawner; // 0x68
		private readonly List<Pickup> _collectedPickups; // 0x70
		private readonly List<VacuumedPickup> _vacuumedPickups; // 0x78
		private float _deltaTimeCounter; // 0x80
		private SfxType[] stealSounds; // 0x90
	
		// Events
		public event Action OnAllPickupsSpawned;
	
		// Nested types
		private struct VacuumedPickup // TypeDefIndex: 17203
		{
			// Fields
			public Pickup Pickup; // 0x00
			public float Speed; // 0x08
			public bool Collected; // 0x0C
	
			// Methods
			public void SetSpeed(float speed) {} // 0x00000001851C2E40-0x00000001851C2E50
			public void SetCollected(bool isCollected) {} // 0x0000000181BAD890-0x0000000181BAD8A0
		}
	
		private class ValuePickupSpawner // TypeDefIndex: 17204
		{
			// Fields
			private readonly int _maxPickupsToSpawn; // 0x10
			private readonly Action<Vector2, float, Action<Pickup>> _spawnPickupAction; // 0x18
			private readonly Action<Pickup> _startPickupSpawnTweenAction; // 0x20
			private float _valueCollected; // 0x28
			private float _valuePerPickupSpawned; // 0x2C
	
			// Constructors
			public ValuePickupSpawner() {} // Dummy constructor
			public ValuePickupSpawner(int maxPickupsToSpawn, Action<Vector2, float, Action<Pickup>> spawnPickupAction, Action<Pickup> startPickupSpawnTweenAction) {} // 0x000000018460BE70-0x000000018460BF20
	
			// Methods
			public void IncreaseValueCollected(int amount) {} // 0x00000001871E2600-0x00000001871E2620
			public int CalculateNumberOfPickupsToSpawn() => default; // 0x00000001871E2620-0x00000001871E2660
			private int CountPickupsToSpawnBasedOnValueCollected() => default; // 0x00000001871E2660-0x00000001871E2680
			public bool SpawnPickup(Vector3 spawnPosition) => default; // 0x00000001871E2680-0x00000001871E2700
		}
	
		// Constructors
		public MazerellaDancerMagnet() {} // 0x00000001871E2390-0x00000001871E2600
	
		// Methods
		private bool IsPickupMoney(VampireSurvivors.Data.ItemType itemType) => default; // 0x00000001871DFCA0-0x00000001871DFCC0
		private bool IsIgnoredItemType(VampireSurvivors.Data.ItemType pickupType) => default; // 0x00000001871DFCC0-0x00000001871DFCF0
		public void InitMagnet(Transform enemyTransform) {} // 0x00000001871DFCF0-0x00000001871E0470
		public void DisableMagnet() {} // 0x00000001871E0470-0x00000001871E0480
		public void Cleanup() {} // 0x00000001871E0480-0x00000001871E0580
		private bool OnDancerMagnetOverlapsPickup(CallbackContext context, ArcadeColliderType magnet, ArcadeColliderType pickup) => default; // 0x00000001871E0580-0x00000001871E0A00
		public void UpdateVacuumedPickups() {} // 0x00000001871E0A00-0x00000001871E10B0
		public void UpdatePickUpLocations() {} // 0x00000001871E10B0-0x00000001871E1560
		public void SetupPickupsToSpawnOnDeath() {} // 0x00000001871E1560-0x00000001871E1690
		public void SpawnPickups() {} // 0x00000001871E1690-0x00000001871E1A40
		private void StartPickupSpawnTween(Pickup pickup) {} // 0x00000001871E1A40-0x00000001871E2110
		private void SetPickupInteractionsActive(Pickup pickup, bool active) {} // 0x00000001871E2110-0x00000001871E2390
	}
}
