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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class WarningPopup : BasePopup // TypeDefIndex: 15052
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _OkButton; // 0x48
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x58
		private PopupManager _manager; // 0x60
	
		// Constructors
		public WarningPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(PopupManager manager, string id, string title, string description, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197728F */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x01977290 */) {} // 0x00000001869CE040-0x00000001869CE490
		[IteratorStateMachine(typeof(_WaitAndSelect_d__5))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001869CE490-0x00000001869CE530
	}
}
