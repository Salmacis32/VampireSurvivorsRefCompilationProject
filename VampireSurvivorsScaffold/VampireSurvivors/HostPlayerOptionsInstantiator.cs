/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	[DisplayName("HostPlayerOptionsInstantiator", "Instances of this prefab will be instantiated and destroyed when they are no longer needed.")]
	public class HostPlayerOptionsInstantiator : INetworkObjectInstantiator // TypeDefIndex: 14000
	{
		// Constructors
		public HostPlayerOptionsInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x00000001869869F0-0x0000000186986E30
		public void Destroy(ICoherenceSync obj) {} // 0x0000000186986E30-0x0000000186986FB0
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
