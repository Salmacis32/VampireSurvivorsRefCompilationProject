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
	public class LabeledButtonUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14814
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x20
		[SerializeField]
		private TextMeshProUGUI _ButtonLabel; // 0x28
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0x30
	
		// Constructors
		public LabeledButtonUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetLabel(string text) {} // 0x00000001867F5B20-0x00000001867F5B50
		public void SetButtonLabel(string text) {} // 0x00000001868B7BB0-0x00000001868B7C00
		public void SetButtonCallback(Action cb) {} // 0x00000001868B7C00-0x00000001868B7CB0
		public Selectable GetSelectable() => default; // 0x0000000180B15550-0x0000000180B15560
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
