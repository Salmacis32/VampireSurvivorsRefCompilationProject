/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "AccessoriesFactory", menuName = "VampireSurvivors/New AccessoriesFactory")]
	public class AccessoriesFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 17433
	{
		// Fields
		[SerializeField]
		private AccessoryDictionary _accessories; // 0x58
		[SerializeField]
		private Accessory _defaultAccessory; // 0x60
		[SerializeField]
		private List<AccessoriesFactory> _LinkedFactories; // 0x68
	
		// Nested types
		[Serializable]
		public class AccessoryDictionary : UnitySerializedDictionary<WeaponType, Accessory> // TypeDefIndex: 17432
		{
			// Constructors
			public AccessoryDictionary() {} // 0x00000001872C0910-0x00000001872C0950
		}
	
		// Constructors
		public AccessoriesFactory() {} // 0x00000001872C0830-0x00000001872C0910
	
		// Methods
		public Accessory GetAccessoryPrefab(WeaponType accessoryType) => default; // 0x00000001872BFC60-0x00000001872C0250
		public List<string> ValidateReferences() => default; // 0x00000001872C0250-0x00000001872C0830
	}
}
