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
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "CharacterFactory", menuName = "VampireSurvivors/New CharacterFactory")]
	public class CharacterFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 17455
	{
		// Fields
		[SerializeField]
		private CharacterDictionary _characters; // 0x58
		[SerializeField]
		private VampireSurvivors.Objects.Characters.CharacterController _defaultCharacterController; // 0x60
		[SerializeField]
		private CharacterRefDictionary _CharacterRefs; // 0x68
		[SerializeField]
		private List<CharacterFactory> _LinkedFactories; // 0x70
	
		// Nested types
		[Serializable]
		public class CharacterDictionary : UnitySerializedDictionary<VampireSurvivors.Data.CharacterType, VampireSurvivors.Objects.Characters.CharacterController> // TypeDefIndex: 17451
		{
			// Constructors
			public CharacterDictionary() {} // 0x00000001872D2560-0x00000001872D25A0
		}
	
		[Serializable]
		public class CharacterRefDictionary : UnitySerializedDictionary<VampireSurvivors.Data.CharacterType, PrefabRefData> // TypeDefIndex: 17452
		{
			// Constructors
			public CharacterRefDictionary() {} // 0x00000001872D25A0-0x00000001872D25E0
		}
	
		[Serializable]
		public class PrefabRefData // TypeDefIndex: 17453
		{
			// Fields
			[SerializeField]
			private AssetReferenceT<GameObject> _PrefabRef; // 0x10
	
			// Properties
			public AssetReferenceT<GameObject> PrefabRef { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
	
			// Constructors
			public PrefabRefData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		[Serializable]
		public class PrefabPathData // TypeDefIndex: 17454
		{
			// Fields
			[SerializeField]
			private string _PrefabPath; // 0x10
	
			// Properties
			public string PrefabPath { get => default; set {} } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
			public string PathWithoutExtension { get => default; } // 0x00000001872D25E0-0x00000001872D2640 
			public string PathWithExtension { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
	
			// Constructors
			public PrefabPathData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public CharacterFactory() {} // 0x00000001872D23D0-0x00000001872D2560
	
		// Methods
		public VampireSurvivors.Objects.Characters.CharacterController GetCharacterPrefab(VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001872D1110-0x00000001872D1A90
		public bool ContainsCharacter(VampireSurvivors.Data.CharacterType characterType) => default; // 0x00000001872D1A90-0x00000001872D1B10
		public List<string> ValidateReferences() => default; // 0x00000001872D1B10-0x00000001872D23D0
	}
}
