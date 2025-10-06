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
	public class ShootingEyesManager : IInitializable, IDisposable // TypeDefIndex: 15096
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private DiContainer _diContainer; // 0x18
		private Camera _mainCamera; // 0x20
		private ObjectPool _explosionEyesPool; // 0x28
		private const float Damage = 15f; // Metadata: 0x0197730B
		private const float Radius = 0.6f; // Metadata: 0x0197730F
	
		// Constructors
		public ShootingEyesManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000186A37130-0x0000000186A37260
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void ShootOne(float radiusMul = 1f /* Metadata: 0x01977307 */) {} // 0x0000000186A37260-0x0000000186A374E0
		public void Stop() {} // 0x0000000186A374E0-0x0000000186A37680
		public void InternalUpdate() {} // 0x0000000186A37680-0x0000000186A37790
		private void ShootOneAt(Vector2 spawnPos) {} // 0x0000000186A37790-0x0000000186A379A0
	}
}
