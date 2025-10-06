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

namespace VampireSurvivors.App.UI
{
	[CreateAssetMenu(fileName = "MainMenuBackgroundFactory", menuName = "VampireSurvivors/New MainMenuBackgroundFactory")]
	public class MainMenuBackgroundFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 18516
	{
		// Fields
		[SerializeField]
		private BackgroundDictionary _Backgrounds; // 0x58
		[SerializeField]
		private BackgroundRefsDictionary _BackgroundRefs; // 0x60
		[SerializeField]
		private List<MainMenuBackgroundFactory> _LinkedFactories; // 0x68
	
		// Nested types
		[Serializable]
		public class BackgroundDictionary : UnitySerializedDictionary<AdventureType, GameObject> // TypeDefIndex: 18513
		{
			// Constructors
			public BackgroundDictionary() {} // 0x00000001867BEBF0-0x00000001867BEC30
		}
	
		[Serializable]
		public class BackgroundRefsDictionary : UnitySerializedDictionary<AdventureType, PrefabRefData> // TypeDefIndex: 18514
		{
			// Constructors
			public BackgroundRefsDictionary() {} // 0x00000001867BEC30-0x00000001867BEC70
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 18515
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
		public MainMenuBackgroundFactory() {} // 0x00000001867BEA60-0x00000001867BEBF0
	
		// Methods
		private GameObject LoadFromAddressables(DlcType? dlcType, AdventureType adventureType, MainMenuBackgroundFactory factory) => default; // 0x00000001867BD860-0x00000001867BDA40
		public GameObject GetBackgroundForAdventureType(AdventureType adventureType) => default; // 0x00000001867BDA40-0x00000001867BE1A0
		public List<string> ValidateReferences() => default; // 0x00000001867BE1A0-0x00000001867BEA60
	}
}
