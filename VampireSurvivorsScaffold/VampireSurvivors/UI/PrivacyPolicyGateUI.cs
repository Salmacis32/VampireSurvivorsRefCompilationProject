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
	public class PrivacyPolicyGateUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 14926
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _WarningMessage; // 0x20
		[SerializeField]
		private TextMeshProUGUI _CenterButtonLabel; // 0x28
		[SerializeField]
		private UnityEngine.UI.Button _CenterButton; // 0x30
	
		// Constructors
		public PrivacyPolicyGateUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetWarningMessage(string text) {} // 0x0000000186932170-0x00000001869321C0
		public void SetCenterButtonLabel(string text) {} // 0x00000001868B7BB0-0x00000001868B7C00
		public void SetCenterButtonCallback(Action cb) {} // 0x00000001869321C0-0x0000000186932270
		public Selectable GetSelectable() => default; // 0x0000000180B15550-0x0000000180B15560
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public void UpdateNavigation(Selectable up, Selectable down, Selectable left, Selectable right) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
