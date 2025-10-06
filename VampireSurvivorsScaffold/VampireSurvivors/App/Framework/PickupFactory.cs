/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework
{
	[CreateAssetMenu(fileName = "PickupFactory", menuName = "VampireSurvivors/New PickupFactory")]
	public class PickupFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 18599
	{
		// Fields
		[SerializeField]
		private PickupsDictionary _Pickups; // 0x58
		[SerializeField]
		private PickupRefsDictionary _PickupRefs; // 0x60
		[SerializeField]
		private List<PickupFactory> _LinkedFactories; // 0x68
		private readonly Dictionary<VampireSurvivors.Data.ItemType, ObjectPool> _cachedPools; // 0x70
	
		// Nested types
		[Serializable]
		public class PickupsDictionary : UnitySerializedDictionary<VampireSurvivors.Data.ItemType, GameObject> // TypeDefIndex: 18596
		{
			// Constructors
			public PickupsDictionary() {} // 0x00000001867EF470-0x00000001867EF4B0
		}
	
		[Serializable]
		public class PickupRefsDictionary : UnitySerializedDictionary<VampireSurvivors.Data.ItemType, PrefabRefData> // TypeDefIndex: 18597
		{
			// Constructors
			public PickupRefsDictionary() {} // 0x00000001867EF4B0-0x00000001867EF4F0
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 18598
		{
			// Fields
			[SerializeField]
			private AssetReferenceT<GameObject> _PrefabRef; // 0x10
	
			// Properties
			public AssetReferenceT<GameObject> PrefabRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public PrefabRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public PickupFactory() {} // 0x00000001867EF250-0x00000001867EF470
	
		// Methods
		public void GeneratePools() {} // 0x00000001867EE110-0x00000001867EE6E0
		public ObjectPool GetPool(VampireSurvivors.Data.ItemType itemType) => default; // 0x00000001867EE6E0-0x00000001867EE790
		public void PurgePools() {} // 0x00000001867EE790-0x00000001867EEA20
		private void GeneratePool(VampireSurvivors.Data.ItemType itemType, GameObject prefab, int poolSize = 50 /* Metadata: 0x0197AD82 */) {} // 0x00000001867EEA20-0x00000001867EEC30
		private void MergeFactoryAndGenerate(PickupFactory other, DlcType? dlcType) {} // 0x00000001867EEC30-0x00000001867EF1F0
		public List<string> ValidateReferences() => default; // 0x00000001867EF1F0-0x00000001867EF250
	}
}
