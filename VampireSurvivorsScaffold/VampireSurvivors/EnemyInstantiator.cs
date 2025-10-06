/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class EnemyInstantiator : INetworkObjectInstantiator // TypeDefIndex: 13999
	{
		// Fields
		public static Action<EnemyController> OnRemoteEnemySpawned; // 0x00
	
		// Constructors
		public EnemyInstantiator() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public ICoherenceSync Instantiate(SpawnInfo spawnInfo) => default; // 0x0000000186985EB0-0x00000001869865F0
		public void Destroy(ICoherenceSync obj) {} // 0x00000001869865F0-0x00000001869867B0
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void WarmUpInstantiator(CoherenceBridge bridge, CoherenceSyncConfig config, INetworkObjectProvider assetLoader) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnUniqueObjectReplaced(ICoherenceSync instance) {} // 0x0000000180B15170-0x0000000180B15180
		private static object GetFieldValue(object obj, string fieldName) => default; // 0x00000001869867B0-0x0000000186986960
		private static FieldInfo GetFieldInfo(System.Type type, string fieldName) => default; // 0x0000000186986960-0x00000001869869F0
	}
}
