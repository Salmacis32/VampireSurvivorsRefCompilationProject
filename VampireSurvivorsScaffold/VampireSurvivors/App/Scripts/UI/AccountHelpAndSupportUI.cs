/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public class AccountHelpAndSupportUI : MonoBehaviour, ISelectableUI // TypeDefIndex: 18625
	{
		// Fields
		private const string ACCOUNT_HELP_URL = "https://poncle.games/account-help"; // Metadata: 0x0197AEA1
		private const string PRIVACY_POLICY_URL = "https://poncle.games/privacy-policy"; // Metadata: 0x0197AEC3
		[SerializeField]
		private TextMeshProUGUI _HelpText; // 0x20
		[SerializeField]
		private TextMeshProUGUI _HelpButtonText; // 0x28
		[SerializeField]
		private TextMeshProUGUI _PrivacyPolicyText; // 0x30
		[SerializeField]
		private TextMeshProUGUI _PrivacyPolicyButtonText; // 0x38
		[SerializeField]
		private UnityEngine.UI.Button _HelpButton; // 0x40
		[SerializeField]
		private UnityEngine.UI.Button _PrivacyPolicyButton; // 0x48
	
		// Constructors
		public AccountHelpAndSupportUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001867F5800-0x00000001867F5B20
		public void SetHelpText(string text) {} // 0x00000001867F5B20-0x00000001867F5B50
		public void SetPrivacyPolicyText(string text) {} // 0x00000001867F5B50-0x00000001867F5B80
		public GameObject GetGameObject() => default; // 0x0000000182774DD0-0x0000000182774DE0
		public Selectable GetSelectable() => default; // 0x0000000180B15750-0x0000000180B15760
		public void UpdateNavigation(Selectable above, Selectable below, Selectable left, Selectable right) {} // 0x00000001867F5B80-0x00000001867F5D80
	}
}
