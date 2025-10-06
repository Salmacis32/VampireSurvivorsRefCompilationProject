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
	public class CharacterInstantiator : INetworkObjectInstantiator // TypeDefIndex: 13995
	{
		// Constructors
		public CharacterInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x0000000186985480-0x00000001869857F0
		public void Destroy(ICoherenceSync obj) {} // 0x00000001869857F0-0x00000001869859A0
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
