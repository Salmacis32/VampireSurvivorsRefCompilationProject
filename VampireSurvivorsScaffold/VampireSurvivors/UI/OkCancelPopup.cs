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
	public class OkCancelPopup : BasePopup // TypeDefIndex: 14878
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Button _OkButton; // 0x48
		[SerializeField]
		private UnityEngine.UI.Button _CancelButton; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x58
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x60
		private PopupManager _manager; // 0x68
	
		// Constructors
		public OkCancelPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(string id, string title, string description, Action<bool> callback, bool textIsLocalizationTerm = true /* Metadata: 0x01977238 */) {} // 0x00000001868F69A0-0x00000001868F6E70
		[IteratorStateMachine(typeof(_WaitAndSelect_d__6))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001868F6E70-0x00000001868F6F10
	}
}
