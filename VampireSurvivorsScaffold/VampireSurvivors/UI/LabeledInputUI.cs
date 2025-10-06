/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class LabeledInputUI : MonoBehaviour, ISelectableUI, ISubmitHandler, IDeselectHandler // TypeDefIndex: 14815
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Label; // 0x20
		[SerializeField]
		private TMP_InputField _Input; // 0x28
		[SerializeField]
		private TouchScreenKeyboardType _KeyboardType; // 0x30
		private bool _HasBeenActivated; // 0x34
		private TouchScreenKeyboard _softKeyboard; // 0x38
	
		// Properties
		public TextMeshProUGUI Label { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public TMP_InputField Input { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	
		// Constructors
		public LabeledInputUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void OnEnable() {} // 0x00000001868B7CB0-0x00000001868B7EA0
		private void OnDisable() {} // 0x00000001868B7EA0-0x00000001868B8090
		private void LateUpdate() {} // 0x00000001868B8090-0x00000001868B8180
		public void SetKeyboardType(TouchScreenKeyboardType t) {} // 0x0000000180B15170-0x0000000180B15180
		public void SetContentType(TMP_InputField.ContentType contentType) {} // 0x00000001868B8180-0x00000001868B81A0
		public void SetLabel(string text) {} // 0x00000001867F5B20-0x00000001867F5B50
		public bool IsFocused() => default; // 0x00000001868B81A0-0x00000001868B81C0
		public void SetInputPlaceholderText(string value) {} // 0x00000001868B81C0-0x00000001868B82E0
		public string GetText() => default; // 0x00000001868B82E0-0x00000001868B8300
		public Selectable GetSelectable() => default; // 0x00000001868B8300-0x00000001868B8340
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000180B15170-0x0000000180B15180
		public void ActivateInputField() {} // 0x00000001868B8340-0x00000001868B8380
		public void OnSubmit(BaseEventData eventData) {} // 0x00000001868B8380-0x00000001868B8430
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000180B15170-0x0000000180B15180
		private void OnFloatingGamepadTextInputDismissed() {} // 0x00000001868B8430-0x00000001868B8480
	}
}
