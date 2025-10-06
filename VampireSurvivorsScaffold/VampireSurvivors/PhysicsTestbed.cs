/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PhysicsTestbed : MonoBehaviour // TypeDefIndex: 14139
	{
		// Fields
		[SerializeField]
		private GameObject _EnemyPrefab; // 0x20
		public PhysicsGroup Enemies; // 0x28
		public PhysicsGroup _enemyGroup; // 0x30
		private static PhysicsTestbed _sInstance; // 0x00
	
		// Properties
		public static PhysicsTestbed Instance { get => default; } // 0x0000000186D9C760-0x0000000186D9C7A0 
	
		// Constructors
		public PhysicsTestbed() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186D9C7A0-0x0000000186D9C840
		private void Start() {} // 0x0000000186D9C840-0x0000000186D9C860
		private void InitPhysics() {} // 0x0000000186D9C860-0x0000000186D9CD00
		private void SpawnEnemies() {} // 0x0000000186D9CD00-0x0000000186D9CFA0
	}
}
