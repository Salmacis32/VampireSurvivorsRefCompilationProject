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
	public class SaveSlotContainerUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14953
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x20
		[SerializeField]
		private TextMeshProUGUI _SaveData; // 0x28
		[SerializeField]
		private TextMeshProUGUI _ButtonLabel; // 0x30
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0x38
	
		// Constructors
		public SaveSlotContainerUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetLabel(string title) {} // 0x00000001867F5B20-0x00000001867F5B50
		public void SetSaveData(string text) {} // 0x0000000186932A40-0x0000000186932A70
		public void RemoveButton() {} // 0x000000018694E8A0-0x000000018694E8D0
		public void SetButtonLabel(string text) {} // 0x000000018694E8D0-0x000000018694E920
		public void SetButtonCallback(Action cb) {} // 0x000000018694E920-0x000000018694E9D0
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public Selectable GetSelectable() => default; // 0x0000000180B15560-0x0000000180B15570
		public void UpdateNavigation(Selectable above, Selectable below, Selectable left, Selectable right) {} // 0x000000018694E9D0-0x000000018694EBD0
	}
}
