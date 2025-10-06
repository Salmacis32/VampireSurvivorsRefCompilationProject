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
	public class AccountErrorPopup : BasePopup // TypeDefIndex: 14643
	{
		// Fields
		private const string ACCOUNT_HELP_URL = "https://poncle.games/account-help"; // Metadata: 0x0197719B
		[SerializeField]
		private UnityEngine.UI.Button _OkButton; // 0x48
		[SerializeField]
		private UnityEngine.UI.Button _HelpButton; // 0x50
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x58
		[SerializeField]
		private TextMeshProUGUI _Description; // 0x60
		[SerializeField]
		private TextMeshProUGUI _HelpText; // 0x68
		[SerializeField]
		private TextMeshProUGUI _HelpButtonText; // 0x70
		private PopupManager _manager; // 0x78
	
		// Constructors
		public AccountErrorPopup() {} // 0x00000001867AC2E0-0x00000001867AC2F0
	
		// Methods
		public void Initialize(PopupManager manager, string id, string title, string description, string helpText, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x01977198 */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x01977199 */, bool helpTextIsLocalizationTerm = true /* Metadata: 0x0197719A */) {} // 0x000000018730A6B0-0x000000018730AC10
		[IteratorStateMachine(typeof(_WaitAndSelect_d__9))]
		private IEnumerator WaitAndSelect() => default; // 0x000000018730AC10-0x000000018730ACB0
	}
}
