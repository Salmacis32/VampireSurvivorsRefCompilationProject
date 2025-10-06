/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ForcedNavigationConfig : MonoBehaviour // TypeDefIndex: 14775
	{
		// Fields
		[SerializeField]
		private Selectable _Target; // 0x20
		[SerializeField]
		private Selectable _OnDown; // 0x28
		[SerializeField]
		private Selectable _OnUp; // 0x30
		[SerializeField]
		private Selectable _OnLeft; // 0x38
		[SerializeField]
		private Selectable _OnRight; // 0x40
		[SerializeField]
		private List<Selectable> _FallbackUpSelections; // 0x48
		private Navigation.Mode _cachedMode; // 0x50
		private Selectable _cachedLeft; // 0x58
		private Selectable _cachedRight; // 0x60
		private Selectable _cachedUp; // 0x68
		private Selectable _cachedDown; // 0x70
		public bool isLive; // 0x78
	
		// Constructors
		public ForcedNavigationConfig() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnEnable() {} // 0x0000000186893D60-0x0000000186894480
		private void OnDisable() {} // 0x0000000186894480-0x0000000186894680
	}
}
