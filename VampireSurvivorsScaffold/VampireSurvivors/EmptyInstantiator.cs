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
	[DisplayName("EmptyInstantiator", "Instantiator that will do nothing.")]
	public class EmptyInstantiator : INetworkObjectInstantiator // TypeDefIndex: 13998
	{
		// Constructors
		public EmptyInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x0000000180B15D70-0x0000000180B15D80
		public void Destroy(ICoherenceSync obj) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
