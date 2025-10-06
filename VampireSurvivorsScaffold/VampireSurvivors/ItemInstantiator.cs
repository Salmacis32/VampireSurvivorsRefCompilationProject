/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class ItemInstantiator : INetworkObjectInstantiator // TypeDefIndex: 14001
	{
		// Fields
		public static Action<Pickup> OnRemoteItemInstantiated; // 0x00
	
		// Constructors
		public ItemInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x0000000186986FB0-0x0000000186987110
		public void Destroy(ICoherenceSync obj) {} // 0x0000000186987110-0x0000000186987230
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
