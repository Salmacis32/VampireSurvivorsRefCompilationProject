/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using VampireSurvivorsDecompProject.Objects.Projectiles;
using VampireSurvivors.Objects.Weapons;

namespace VampireSurvivorsDecompProject.Objects.Pools
{
	public class BulletPool : PhysicsGroup // TypeDefIndex: 16008
	{
		// Fields
		private ObjectPool _pool; // 0x38
		public bool IsUncapped; // 0x40
		public int UpperLimit; // 0x44
		private static readonly ProfilerMarker _markerSpawnAt; // 0x00
	
		// Properties
		public int AliveObjectsCount { get => default; } // 0x0000000186EB11B0-0x0000000186EB1200 
		public Dictionary<int, GameObject> Spawned { get => default; } // 0x0000000186EB1200-0x0000000186EB1220 
	
		// Constructors
		public BulletPool() {} // Dummy constructor
		public BulletPool(Projectile projectilePrefab, int capacity = 50 /* Metadata: 0x019779D6 */) {} // 0x0000000186EB1220-0x0000000186EB1590
		static BulletPool() {} // 0x0000000186EB1F20-0x0000000186EB1F90
	
		// Methods
		public Projectile SpawnAt(float x, float y, Weapon weapon, int index = 0 /* Metadata: 0x019779D7 */) => default; // 0x0000000186EB1590-0x0000000186EB15B0
		public Projectile SpawnAt(float2 pos, Weapon weapon, int index = 0 /* Metadata: 0x019779D8 */) => default; // 0x0000000186EB15B0-0x0000000186EB19B0
		public void Return(Projectile projectile) {} // 0x0000000186EB19B0-0x0000000186EB1B50
		public void Cleanup() {} // 0x0000000186EB1B50-0x0000000186EB1D00
		public void Destroy() {} // 0x0000000186EB1D00-0x0000000186EB1F20
	}
}
