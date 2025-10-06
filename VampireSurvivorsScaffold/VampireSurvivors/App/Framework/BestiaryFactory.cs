/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework
{
	[CreateAssetMenu(fileName = "BestiaryFactory", menuName = "VampireSurvivors/New BestiaryFactory")]
	public class BestiaryFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 18584
	{
		// Fields
		[SerializeField]
		private BestiaryEnemyPoolsDictionary _BestiaryEnemyPools; // 0x58
		[SerializeField]
		private BestiaryEnemyRefDictionary _BestiaryEnemyRefs; // 0x60
		[SerializeField]
		private List<BestiaryFactory> _LinkedFactories; // 0x68
		[HideInInspector]
		public string CACHE_GROUP; // 0x70
		[HideInInspector]
		public string CACHE_GROUP_UI; // 0x78
	
		// Nested types
		[Serializable]
		public class BestiaryEnemyPoolsDictionary : UnitySerializedDictionary<EnemyType, GameObject> // TypeDefIndex: 18581
		{
			// Constructors
			public BestiaryEnemyPoolsDictionary() {} // 0x00000001867EA4D0-0x00000001867EA510
		}
	
		[Serializable]
		public class BestiaryEnemyRefDictionary : UnitySerializedDictionary<EnemyType, PrefabRefData> // TypeDefIndex: 18582
		{
			// Constructors
			public BestiaryEnemyRefDictionary() {} // 0x00000001867EA510-0x00000001867EA550
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 18583
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
		public BestiaryFactory() {} // 0x00000001867EA260-0x00000001867EA4D0
	
		// Methods
		public GameObject GetBestiaryEnemyPrefab(EnemyType type) => default; // 0x00000001867E9050-0x00000001867E99A0
		public List<string> ValidateReferences() => default; // 0x00000001867E99A0-0x00000001867EA260
	}
}
