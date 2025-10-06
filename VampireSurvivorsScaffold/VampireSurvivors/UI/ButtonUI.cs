/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ButtonUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14709
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _ButtonLabel; // 0x20
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0x28
	
		// Constructors
		public ButtonUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetButtonLabel(string text) {} // 0x00000001867ADB50-0x00000001867ADBA0
		public void SetButtonCallback(Action cb) {} // 0x00000001867ADBA0-0x00000001867ADC50
		public Selectable GetSelectable() => default; // 0x0000000180B15540-0x0000000180B15550
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
