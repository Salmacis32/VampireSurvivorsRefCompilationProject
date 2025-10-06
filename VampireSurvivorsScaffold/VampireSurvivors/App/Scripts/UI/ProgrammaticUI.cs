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
using UnityEngine.Events;
using UnityEngine.UI;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public abstract class ProgrammaticUI : BaseUIPage // TypeDefIndex: 18632
	{
		// Fields
		[SerializeField]
		protected TextMeshProUGUI _Title; // 0xE0
		[SerializeField]
		protected RectTransform _Content; // 0xE8
		[SerializeField]
		protected GameObject _LabelledButtonPrefab; // 0xF0
		[SerializeField]
		protected GameObject _LabelPrefab; // 0xF8
		[SerializeField]
		protected GameObject _InputPrefab; // 0x100
		[SerializeField]
		protected GameObject _ButtonPrefab; // 0x108
		[SerializeField]
		protected GameObject _SaveSlotPrefab; // 0x110
		[SerializeField]
		protected GameObject _AccountDetailPrefab; // 0x118
		[SerializeField]
		protected GameObject _PrivacyPolicyGatePrefab; // 0x120
		[SerializeField]
		protected GameObject _PrivacyPolicyScrollerPrefab; // 0x128
		[SerializeField]
		protected GameObject _DateOfBirthPrefab; // 0x130
		[SerializeField]
		protected GameObject _HelpAndSupportPrefab; // 0x138
		protected List<ISelectableUI> _spawnedSelectables; // 0x140
		protected List<IUIObject> _spawnedUnselectables; // 0x148
		[SerializeField]
		private Selectable OnUp; // 0x150
		[SerializeField]
		private Selectable OnDown; // 0x158
	
		// Constructors
		protected ProgrammaticUI() {} // 0x00000001868027E0-0x0000000186802980
	
		// Methods
		protected override void Update() {} // 0x00000001867FE640-0x00000001867FE930
		[IteratorStateMachine(typeof(_WaitAndActivateInputField_d__17))]
		private IEnumerator WaitAndActivateInputField(TMP_InputField field) => default; // 0x00000001867FE930-0x00000001867FE9D0
		public void AddAccountDetail(bool linked, string account, string detail, string buttonText = "" /* Metadata: 0x0197AEEB */, Action callback = null) {} // 0x00000001867FE9D0-0x00000001867FEF90
		public void AddSaveSlot(string title, string savedata, string buttonText = "" /* Metadata: 0x0197AEEC */, Action callback = null) {} // 0x00000001867FEF90-0x00000001867FF420
		public LabeledButtonUI AddLabeledButton(string labelText, string buttonText, Action callback, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEED */, bool isEnabledByDefault = true /* Metadata: 0x0197AEEE */) => default; // 0x00000001867FF420-0x00000001867FF7E0
		public AccountHelpAndSupportUI AddHelpAndSupport(string helpText, string privacyPolicyText) => default; // 0x00000001867FF7E0-0x00000001867FFB30
		public void AddPrivacyPolicyGate(string warningMessage, string centerButtonText, Action centerButtonCallback, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEEF */) {} // 0x00000001867FFB30-0x00000001867FFF50
		public void AddPrivacyPolicyScroller(string leftButtonText, Action leftButtonCallback, string rightButtonText, Action rightButtonCallback, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEF0 */) {} // 0x00000001867FFF50-0x0000000186800410
		public GameObject AddDateOfBirth(string label, Action onAllFieldsFilled) => default; // 0x0000000186800410-0x0000000186800530
		public ButtonUI AddButton(string buttonText, Action callback, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEF1 */) => default; // 0x0000000186800530-0x0000000186800920
		public void AddLabel(string labelText) {} // 0x0000000186800920-0x0000000186800C50
		public LabeledInputUI AddLabeledEmailInput(string labelText, string defaultValue = "" /* Metadata: 0x0197AEF2 */, string placeholder = "" /* Metadata: 0x0197AEF3 */, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEF4 */, UnityAction<string> onChange = null) => default; // 0x0000000186800C50-0x0000000186800C90
		public LabeledInputUI AddLabeledPasswordInput(string labelText, string defaultValue = "" /* Metadata: 0x0197AEF5 */, string placeholder = "" /* Metadata: 0x0197AEF6 */, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEF7 */, UnityAction<string> onChange = null) => default; // 0x0000000186800C90-0x0000000186800CD0
		private LabeledInputUI AddLabeledInput(string labelText, string defaultValue = "" /* Metadata: 0x0197AEF8 */, string placeholder = "" /* Metadata: 0x0197AEF9 */, bool textIsLocalizationTerm = true /* Metadata: 0x0197AEFA */, TMP_InputField.ContentType contentType = TMP_InputField.ContentType.Alphanumeric /* Metadata: 0x0197AEFB */, UnityAction<string> onChange = null) => default; // 0x0000000186800CD0-0x00000001868010C0
		public virtual void Clear() {} // 0x00000001868010C0-0x0000000186801600
		private string Translate(string term) => default; // 0x0000000186801600-0x0000000186801680
		public void ShowLoading(string message) {} // 0x0000000186801680-0x0000000186801740
		public virtual void SelectFirstSelectable() {} // 0x0000000186801740-0x0000000186801A60
		public void SelectFirstSelectable(List<GameObject> ignoreObjects) {} // 0x0000000186801A60-0x0000000186801D50
		public void HideLoading() {} // 0x0000000186801D50-0x0000000186801D90
		public void ShowOkPopup(string title, string description, Action callback) {} // 0x0000000186801D90-0x0000000186801E10
		public void ShowAccountErrorPopup(string title, string description, string helpText, Action callback) {} // 0x0000000186801E10-0x0000000186801EA0
		public void ShowYesNoPopup(string title, string description, Action yesCallback, Action noCallback) {} // 0x0000000186801EA0-0x0000000186801F80
		public void GenerateNavigation() {} // 0x0000000186801F80-0x00000001868027E0
	}
}
