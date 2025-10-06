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
	public class PrivacyPolicyScrollerUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14927
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Text; // 0x20
		[SerializeField]
		private TextMeshProUGUI _LeftButtonLabel; // 0x28
		[SerializeField]
		private TextMeshProUGUI _RightButtonLabel; // 0x30
		[SerializeField]
		private UnityEngine.UI.Button _LeftButton; // 0x38
		[SerializeField]
		private UnityEngine.UI.Button _RightButton; // 0x40
		[SerializeField]
		private FakeSliderHandleController _SliderHandle; // 0x48
	
		// Constructors
		public PrivacyPolicyScrollerUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetLeftButtonLabel(string text) {} // 0x0000000186932270-0x00000001869322C0
		public void SetLeftButtonCallback(Action cb) {} // 0x00000001869322C0-0x0000000186932370
		public void SetRightButtonLabel(string text) {} // 0x0000000186932370-0x00000001869323C0
		public void SetRightButtonCallback(Action cb) {} // 0x00000001869323C0-0x0000000186932470
		public Selectable GetSelectable() => default; // 0x0000000186932470-0x0000000186932520
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000186932520-0x0000000186932A40
	}
}
