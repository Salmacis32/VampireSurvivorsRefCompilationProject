/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using VampireSurvivors;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public abstract class BaseAccountPagePanel // TypeDefIndex: 14579
	{
		// Fields
		private AccountPage _accountPage; // 0x10
	
		// Constructors
		protected BaseAccountPagePanel() {} // Dummy constructor
		protected BaseAccountPagePanel(AccountPage accountPage) {} // 0x00000001871B7D40-0x00000001871B7DB0
	
		// Methods
		public abstract void Build();
		protected void HideLoading() {} // 0x00000001871B7DB0-0x00000001871B7E00
		protected void ShowLoading(string message) {} // 0x00000001871B7E00-0x00000001871B7E70
		protected void ShowLoadingImmediate(string message) {} // 0x00000001871B7E70-0x00000001871B7E90
		[IteratorStateMachine(typeof(_ShowLoadingRoutine_d__6))]
		private IEnumerator ShowLoadingRoutine(string message) => default; // 0x00000001871B7E90-0x00000001871B7F90
		protected void ShowOkPopup(string title, string description, Action callback) {} // 0x00000001871B7F90-0x00000001871B8000
		[IteratorStateMachine(typeof(_ShowOKRoutine_d__8))]
		private IEnumerator ShowOKRoutine(string title, string description, Action callback) => default; // 0x00000001871B8000-0x00000001871B81C0
		protected void ShowYesNoPopup(string title, string description, Action yesCallback, Action noCallback) {} // 0x00000001871B81C0-0x00000001871B8230
		[IteratorStateMachine(typeof(_ShowYesNoRoutine_d__10))]
		private IEnumerator ShowYesNoRoutine(string title, string description, Action yesCallback, Action noCallback) => default; // 0x00000001871B8230-0x00000001871B8440
		protected void ShowOkPopupForSuccess(string description, Action callback) {} // 0x00000001871B8440-0x00000001871B8500
		protected void ShowAccountErrorPopup(string title, string description, string helpText, Action callback) {} // 0x00000001871B8500-0x00000001871B8570
		[IteratorStateMachine(typeof(_AccountErrorPopupRoutine_d__13))]
		private IEnumerator AccountErrorPopupRoutine(string title, string description, string helpText, Action callback) => default; // 0x00000001871B8570-0x00000001871B8780
		protected void ShowOkPopupForError(string description, Exception e, Action callback) {} // 0x00000001871B8780-0x00000001871B89A0
		protected bool GetFlag(string key) => default; // 0x00000001871B89A0-0x00000001871B8A60
		protected void SetFlag(string key, bool value) {} // 0x00000001871B8A60-0x00000001871B8B00
		protected void ChangeStateTo(UIState uiState) {} // 0x00000001871B8B00-0x00000001871B8B40
		protected void ClearAndBuild() {} // 0x00000001871B8B40-0x00000001871B8B90
		protected void GoHome() {} // 0x00000001871B8B90-0x00000001871B8BB0
		protected void HideLoggedInStatus() {} // 0x00000001871B8BB0-0x00000001871B8BE0
		protected void SetGenericLoggedInStatus() {} // 0x00000001871B8BE0-0x00000001871B8C00
		protected void SetLoggedInStatus() {} // 0x00000001871B8C00-0x00000001871B8C20
		protected void SetTitle(string title) {} // 0x00000001871B8C20-0x00000001871B8C50
		protected async void Logout() {} // 0x00000001871B8C50-0x00000001871B8E10
		protected void AddBackButtonListener() {} // 0x00000001871B8E10-0x00000001871B8EC0
		protected void AddLogoutButton() {} // 0x00000001871B8EC0-0x00000001871B8FB0
		protected LabeledButtonUI AddLabeledButton(string labelText, string buttonText, Action callback, bool textIsLocalizationTerm = true /* Metadata: 0x01977177 */, bool isEnabledByDefault = true /* Metadata: 0x01977178 */) => default; // 0x00000001871B8FB0-0x00000001871B8FF0
		protected LabeledInputUI AddLabeledEmailInput(string labelText, string defaultValue = "" /* Metadata: 0x01977179 */, string placeholder = "" /* Metadata: 0x0197717A */, bool textIsLocalizationTerm = true /* Metadata: 0x0197717B */, UnityAction<string> onChange = null) => default; // 0x00000001871B8FF0-0x00000001871B9040
		protected LabeledInputUI AddLabeledPasswordInput(string labelText, string defaultValue = "" /* Metadata: 0x0197717C */, string placeholder = "" /* Metadata: 0x0197717D */, bool textIsLocalizationTerm = true /* Metadata: 0x0197717E */, UnityAction<string> onChange = null) => default; // 0x00000001871B9040-0x00000001871B9090
		protected void AddLabel(string labelText) {} // 0x00000001871B9090-0x00000001871B90B0
		protected void AddSaveSlot(string title, string savedata, string buttonText = "" /* Metadata: 0x0197717F */, Action callback = null) {} // 0x00000001871B90B0-0x00000001871B90E0
		protected void AddAccountDetail(bool linked, string account, string detail, string buttonText = "" /* Metadata: 0x01977180 */, Action callback = null) {} // 0x00000001871B90E0-0x00000001871B9110
		protected void AddPrivacyPolicyGate(string warningMessage, string centerButtonText, Action centerButtonCallback) {} // 0x00000001871B9110-0x00000001871B9140
		protected void AddPrivacyPolicyScroller(string leftButtonText, Action leftButtonCallback, string rightButtonText, Action rightButtonCallback) {} // 0x00000001871B9140-0x00000001871B9180
		protected DateOfBirthField AddDateOfBirth(string label, Action onAllFieldsFilled) => default; // 0x00000001871B9180-0x00000001871B92F0
		protected void AddHelpAndSupport(string helpText, string privacyPolicyText) {} // 0x00000001871B92F0-0x00000001871B9310
		protected void PostBuildGeneration() {} // 0x00000001871B9310-0x00000001871B9350
	}
}
