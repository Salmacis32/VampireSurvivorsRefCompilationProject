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
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "WeaponFactory", menuName = "VampireSurvivors/New WeaponFactory")]
	public class WeaponFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 17538
	{
		// Fields
		[SerializeField]
		private WeaponsDictionary _weapons; // 0x58
		[SerializeField]
		private List<WeaponFactory> _LinkedFactories; // 0x60
	
		// Nested types
		[Serializable]
		public class WeaponsDictionary : UnitySerializedDictionary<WeaponType, Weapon> // TypeDefIndex: 17537
		{
			// Constructors
			public WeaponsDictionary() {} // 0x00000001873548E0-0x0000000187354920
		}
	
		// Constructors
		public WeaponFactory() {} // 0x0000000187354800-0x00000001873548E0
	
		// Methods
		public Weapon GetWeaponPrefab(WeaponType weaponType, out WeaponType forcedWeaponType) {
			forcedWeaponType = default;
			return default;
		} // 0x0000000187353C20-0x0000000187354220
		public List<string> ValidateReferences() => default; // 0x0000000187354220-0x0000000187354800
	}
}
