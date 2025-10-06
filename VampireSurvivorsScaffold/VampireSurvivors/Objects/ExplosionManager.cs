/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class ExplosionManager : IInitializable, IDisposable // TypeDefIndex: 15086
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private DiContainer _diContainer; // 0x18
		private ObjectPool _explosionPool; // 0x20
	
		// Constructors
		public ExplosionManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x00000001869F60F0-0x00000001869F61B0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void SpawnExplosion(Vector2 spawnPos, float damage, float radius) {} // 0x00000001869F61B0-0x00000001869F63F0
		public void InternalUpdate() {} // 0x00000001869F63F0-0x00000001869F6500
	}
}
