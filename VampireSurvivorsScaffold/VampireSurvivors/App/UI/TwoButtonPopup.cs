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
	public class TwoButtonPopup : BasePopup // TypeDefIndex: 18533
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _Button1; // 0x48
		[SerializeField]
		private UnityEngine.UI.Button _Button2; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x58
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x60
		[SerializeField]
		private TextMeshProUGUI _Button1Text; // 0x68
		[SerializeField]
		private TextMeshProUGUI _Button2Text; // 0x70
	
		// Constructors
		public TwoButtonPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(PopupManager manager, string id, string title, string description, string button1Text, string button2Text, Action button1Callback, Action button2Callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197AA12 */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x0197AA13 */, bool button1TextIsLocalizationTerm = true /* Metadata: 0x0197AA14 */, bool button2TextIsLocalizationTerm = true /* Metadata: 0x0197AA15 */) {} // 0x00000001867C1B30-0x00000001867C2250
		[IteratorStateMachine(typeof(_WaitAndSelect_d__7))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001867C2250-0x00000001867C22F0
	}
}
