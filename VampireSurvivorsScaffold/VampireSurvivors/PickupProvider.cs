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
	public class PickupProvider : INetworkObjectProvider // TypeDefIndex: 14062
	{
		// Fields
		[SerializeField]
		private VampireSurvivors.Data.ItemType _itemType; // 0x10
	
		// Constructors
		public PickupProvider() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void LoadAsset(string networkAssetId, Action<ICoherenceSync> onLoaded) {} // 0x0000000186C3F3C0-0x0000000186C3F4B0
		public ICoherenceSync LoadAsset(string networkAssetId) => default; // 0x0000000186C3F4B0-0x0000000186C3F580
		public void Release(ICoherenceSync obj) {} // 0x0000000180B15170-0x0000000180B15180
		public void OnApplicationQuit() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(CoherenceSyncConfig entry) {} // 0x0000000180B15170-0x0000000180B15180
		public bool Validate(CoherenceSyncConfig entry) => default; // 0x0000000184E43CA0-0x0000000184E43CB0
	}
}
