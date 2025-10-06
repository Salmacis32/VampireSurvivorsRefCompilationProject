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
	public class AccountDetailUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14640
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0x20
		[SerializeField]
		private TextMeshProUGUI _Account; // 0x28
		[SerializeField]
		private TextMeshProUGUI _Detail; // 0x30
		[SerializeField]
		private TextMeshProUGUI _ButtonLabel; // 0x38
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0x40
	
		// Constructors
		public AccountDetailUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetAccountText(string text) {} // 0x0000000186932A40-0x0000000186932A70
		public void SetDetailText(string text) {} // 0x00000001867F5B50-0x00000001867F5B80
		public void SetButtonLabel(string text) {} // 0x000000018730A230-0x000000018730A280
		public void SetButtonCallback(Action cb) {} // 0x000000018730A280-0x000000018730A330
		public void SetLinkedIcon(bool linked) {} // 0x000000018730A330-0x000000018730A480
		public void RemoveButton() {} // 0x000000018730A480-0x000000018730A4B0
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public Selectable GetSelectable() => default; // 0x0000000180B15750-0x0000000180B15760
		public void UpdateNavigation(Selectable above, Selectable below, Selectable left, Selectable right) {} // 0x000000018730A4B0-0x000000018730A6B0
	}
}
