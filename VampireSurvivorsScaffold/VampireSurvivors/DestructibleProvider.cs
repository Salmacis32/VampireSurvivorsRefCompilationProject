/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class DestructibleProvider : INetworkObjectProvider // TypeDefIndex: 14061
	{
		// Fields
		[SerializeField]
		private PropType _propType; // 0x10
		[SerializeField]
		private bool _initialized; // 0x14
	
		// Constructors
		public DestructibleProvider() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void LoadAsset(string networkAssetId, Action<ICoherenceSync> onLoaded) {} // 0x0000000186C3F2E0-0x0000000186C3F360
		public ICoherenceSync LoadAsset(string networkAssetId) => default; // 0x0000000186C3F360-0x0000000186C3F3C0
		public void Release(ICoherenceSync obj) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(CoherenceSyncConfig entry) {} // 0x0000000180B15170-0x0000000180B15180
		public bool Validate(CoherenceSyncConfig entry) => default; // 0x000000018195FC30-0x000000018195FC40
	}
}
