/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class MaskInstantiator : INetworkObjectInstantiator // TypeDefIndex: 14002
	{
		// Fields
		public static Action<EnemyController> OnRemoteEnemySpawned; // 0x00
	
		// Constructors
		public MaskInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x0000000186987230-0x0000000186987390
		public void Destroy(ICoherenceSync obj) {} // 0x0000000186987390-0x0000000186987440
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
