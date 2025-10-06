/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[UsedImplicitly]
	public class ShootingStarsManager : IInitializable, IDisposable // TypeDefIndex: 15098
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private DiContainer _diContainer; // 0x18
		private Camera _mainCamera; // 0x20
		private ObjectPool _explosionStarsPool; // 0x28
		private const float Damage = 30f; // Metadata: 0x01977320
		private const float Radius = 0.6f; // Metadata: 0x01977324
	
		// Constructors
		public ShootingStarsManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000186A379A0-0x0000000186A37AD0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void AimRandom(int times = 1 /* Metadata: 0x01977313 */, float delay = 100f /* Metadata: 0x01977314 */, float radiusMul = 1f /* Metadata: 0x01977318 */) {} // 0x0000000186A37AD0-0x0000000186A37CB0
		public void InternalUpdate() {} // 0x0000000186A37CB0-0x0000000186A37DC0
		private void ShootOne(float radiusMul = 1f /* Metadata: 0x0197731C */) {} // 0x0000000186A37DC0-0x0000000186A38040
		private void ShootStarAt(Vector2 spawnPos) {} // 0x0000000186A38040-0x0000000186A38250
	}
}
