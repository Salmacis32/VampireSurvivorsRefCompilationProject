/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using VampireSurvivors.App.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "AssetReferenceLibrary", menuName = "VampireSurvivors/New AssetReferenceLibrary")]
	public class AssetReferenceLibrary : SerializedScriptableObject // TypeDefIndex: 17450
	{
		// Fields
		[SerializeField]
		private AssetRefsDictionary _AssetRefs; // 0x58
	
		// Nested types
		[Serializable]
		public class AssetRefsDictionary : UnitySerializedDictionary<string, PrefabRefData> // TypeDefIndex: 17448
		{
			// Constructors
			public AssetRefsDictionary() {} // 0x00000001872D10D0-0x00000001872D1110
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 17449
		{
			// Fields
			[SerializeField]
			private AssetReference _PrefabRef; // 0x10
	
			// Properties
			public AssetReference PrefabRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public PrefabRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public AssetReferenceLibrary() {} // 0x00000001872D0FF0-0x00000001872D10D0
	
		// Methods
		[CanBeNull]
		public AssetReference GetAssetReference(string key) => default; // 0x00000001872D0C40-0x00000001872D0FF0
	}
}
