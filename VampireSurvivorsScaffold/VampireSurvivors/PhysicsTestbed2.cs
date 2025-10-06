/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	[DefaultExecutionOrder(1000)]
	public class PhysicsTestbed2 : MonoBehaviour // TypeDefIndex: 14140
	{
		// Fields
		[SerializeField]
		private GameObject _EnemyPrefab; // 0x20
		[SerializeField]
		private GameObject _ProjectilePrefab; // 0x28
		[SerializeField]
		protected bool _freeze; // 0x30
		public PhysicsGroup Enemies; // 0x38
		public PhysicsGroup Projectiles; // 0x40
		public PhaserTilemap[] _tilemaps; // 0x48
		private static PhysicsTestbed2 _sInstance; // 0x00
		private List<ArcadeSprite> _spawned; // 0x50
		private List<Vector2> _spawnedPositions; // 0x58
	
		// Properties
		public static PhysicsTestbed2 Instance { get => default; } // 0x0000000186D9CFA0-0x0000000186D9CFE0 
	
		// Constructors
		public PhysicsTestbed2() {} // 0x0000000186D9E960-0x0000000186D9EAF0
	
		// Methods
		private void Awake() {} // 0x0000000186D9CFE0-0x0000000186D9D080
		private void Start() {} // 0x0000000186D9D080-0x0000000186D9D350
		private void InitPhysics() {} // 0x0000000186D9D350-0x0000000186D9DC40
		private void SpawnEnemies() {} // 0x0000000186D9DC40-0x0000000186D9E1C0
		private void SpawnProjectiles() {} // 0x0000000186D9E1C0-0x0000000186D9E6E0
		private void LateUpdate() {} // 0x0000000186D9E6E0-0x0000000186D9E960
	}
}
