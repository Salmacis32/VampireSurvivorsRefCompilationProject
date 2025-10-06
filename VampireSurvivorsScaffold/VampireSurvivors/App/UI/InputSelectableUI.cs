/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class InputSelectableUI : MonoBehaviour, ISubmitHandler, IDeselectHandler, ISelectHandler // TypeDefIndex: 18511
	{
		// Fields
		[SerializeField]
		private TMP_InputField _InputField; // 0x20
		public bool _HasFocus; // 0x28
	
		// Constructors
		public InputSelectableUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void OnSubmit(BaseEventData eventData) {} // 0x00000001867BD570-0x00000001867BD5D0
		public void OnDeselect(BaseEventData eventData) {} // 0x00000001867BD5D0-0x00000001867BD630
		public void OnSelect(BaseEventData eventData) {} // 0x00000001867BD630-0x00000001867BD690
	}
}
