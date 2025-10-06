/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TouchControlCustomiser : MonoBehaviour // TypeDefIndex: 14555
	{
		// Fields
		[SerializeField]
		private TouchControlPrefabDictionary _joystickPrefabs; // 0x20
	
		// Nested types
		[Serializable]
		public class TouchControlPrefabDictionary : UnitySerializedDictionary<VisibleJoystickType, GameObject> // TypeDefIndex: 14554
		{
			// Constructors
			public TouchControlPrefabDictionary() {} // 0x00000001871B0DF0-0x00000001871B0E30
		}
	
		// Constructors
		public TouchControlCustomiser() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetupJoystick(PlayerOptions playerOptions) {} // 0x00000001871B0CA0-0x00000001871B0DF0
	}
}
