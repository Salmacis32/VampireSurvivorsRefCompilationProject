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
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Pools
{
	public class EnemyBulletPool : PhysicsGroup // TypeDefIndex: 16010
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
		public EnemyBulletPool() {} // Dummy constructor
		public EnemyBulletPool(EnemyProjectile projectilePrefab, int capacity = 50 /* Metadata: 0x019779DA */) {} // 0x0000000186EB27B0-0x0000000186EB2AA0
		static EnemyBulletPool() {} // 0x0000000186EB3300-0x0000000186EB3370
	
		// Methods
		public EnemyProjectile SpawnAt(float x, float y, float2 direction, int index = 0 /* Metadata: 0x019779DB */) => default; // 0x0000000186EB2AA0-0x0000000186EB2AD0
		public EnemyProjectile SpawnAt(float2 pos, float2 direction, int index = 0 /* Metadata: 0x019779DC */) => default; // 0x0000000186EB2AD0-0x0000000186EB2EF0
		public void Return(EnemyProjectile projectile) {} // 0x0000000186EB2EF0-0x0000000186EB2F30
		public void Cleanup() {} // 0x0000000186EB2F30-0x0000000186EB30E0
		public void Destroy() {} // 0x0000000186EB30E0-0x0000000186EB3300
	}
}
