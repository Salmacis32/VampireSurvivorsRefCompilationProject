/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI
{
	public class TextInputPopup : BasePopup // TypeDefIndex: 18527
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _Button1; // 0x48
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Button1Text; // 0x58
		[SerializeField]
		private TMP_InputField _InputField; // 0x60
	
		// Constructors
		public TextInputPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(PopupManager manager, string id, string title, string button1Text, Action<string> button1Callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197AA10 */, bool button1TextIsLocalizationTerm = true /* Metadata: 0x0197AA11 */) {} // 0x00000001867C0700-0x00000001867C0C60
		[IteratorStateMachine(typeof(_WaitAndSelect_d__5))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001867C0C60-0x00000001867C0D00
	}
}
