/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.Integration.UnityUI;
using UnityEngine;
using VampireSurvivors.App.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Saves;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PopupManager : MonoBehaviour // TypeDefIndex: 14226
	{
		// Fields
		[SerializeField]
		private GameObject _Fader; // 0x20
		[SerializeField]
		private AutomationPopup _AutomationPopup; // 0x28
		[SerializeField]
		private LargeMultiOptionPopup _LargeMultiOption; // 0x30
		[SerializeField]
		private LargeMultiOptionSavePopup _LargeMultiOptionSaves; // 0x38
		[SerializeField]
		private BlockingPopup _BlockingPopup; // 0x40
		[SerializeField]
		private OkCancelPopup _OkCancelPopup; // 0x48
		[SerializeField]
		private WarningPopup _WarningPopup; // 0x50
		[SerializeField]
		private ErrorPopup _ErrorPopup; // 0x58
		[SerializeField]
		private TwoButtonPopup _TwoButtonPopup; // 0x60
		[SerializeField]
		private TextInputPopup _TextInputPopup; // 0x68
		[SerializeField]
		private AdventureCompletedPopup _AdventureCompletedPopup; // 0x70
		[SerializeField]
		private TutorialPopup _TutorialPopup; // 0x78
		[SerializeField]
		private HelpPopup _HelpPopup; // 0x80
		[SerializeField]
		private AccountErrorPopup _AccountErrorPopup; // 0x88
		[SerializeField]
		private BlockingPopup _AccountBlockingPopup; // 0x90
		[SerializeField]
		private AdvancedMusicSelection _AdvancedMusicSelection; // 0x98
		[SerializeField]
		private EULAPopup _EULAPopup; // 0xA0
		private static PopupManager Instance; // 0x00
		private GameObject _currentFader; // 0xA8
		private static DataManager _dataManager; // 0x08
		private Dictionary<string, GameObject> _popups; // 0xB0
		private RewiredStandaloneInputModule _inputModule; // 0xB8
	
		// Properties
		public static bool IsShowingPopups { get => default; } // 0x0000000186EF99F0-0x0000000186EF9A60 
		private RewiredStandaloneInputModule InputModule { get => default; } // 0x0000000186EF9A60-0x0000000186EF9BC0 
	
		// Constructors
		public PopupManager() {} // 0x0000000186EFF4F0-0x0000000186EFF5F0
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager) {} // 0x0000000186EF9BC0-0x0000000186EF9C60
		private void Awake() {} // 0x0000000186EF9C60-0x0000000186EF9D00
		public static LargeMultiOptionPopup CreateLargeMultiOption(string id, string title, string description, List<OptionDataSet> options, Action<int> callback, Action closedCallback = null, bool textisLocalizationTerm = true /* Metadata: 0x01977064 */) => default; // 0x0000000186EF9D00-0x0000000186EFA2A0
		public static TutorialPopup CreateTutorialPopup(string id, string titleTerm, string descriptionTerm, string buttonTerm) => default; // 0x0000000186EFA2A0-0x0000000186EFA4C0
		private static void ApplyCanvasSettings(GameObject p, int sortingOrder = 11001 /* Metadata: 0x01977065 */) {} // 0x0000000186EFA4C0-0x0000000186EFA6A0
		public static void CreateBlockingPopup(string id, string title, string description, bool textisLocalizationTerm, Action onClose = null) {} // 0x0000000186EFA6A0-0x0000000186EFA8F0
		public static void CreateAccountBlockingPopup(string id, string title, string description, bool textisLocalizationTerm, Action onClose = null) {} // 0x0000000186EFA8F0-0x0000000186EFAB40
		public static void CreateSaveFileComparison(string id, string title, string description, List<SaveSummary> options, Action<int> callback, bool textIsLocalizationTerm = true /* Metadata: 0x01977069 */, bool hasCancelButton = false /* Metadata: 0x0197706A */, Action onCancel = null) {} // 0x0000000186EFAB40-0x0000000186EFB460
		public static void CreateOKCancelPopup(string id, string text, string description, Action<bool> callback, bool textIsLocalizationTerm = true /* Metadata: 0x0197706B */) {} // 0x0000000186EFB460-0x0000000186EFB690
		public static void CreateWarningPopup(string id, string text, string description, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197706C */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x0197706D */) {} // 0x0000000186EFB690-0x0000000186EFB9A0
		public static void CreateOnlineErrorPopup(string id, string text, string description, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197706E */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x0197706F */) {} // 0x0000000186EFB9A0-0x0000000186EFBCC0
		public static void CreateHelpPopup(string id, string text, string description, string helpText, string helpUrl, string qrCodeName, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x01977070 */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x01977071 */, bool helpTextIsLocalizationTerm = true /* Metadata: 0x01977072 */) {} // 0x0000000186EFBCC0-0x0000000186EFBF50
		public static void CreateAccountErrorPopup(string id, string text, string description, string helpText, Action callback, bool titleIsLocalizationTerm = true /* Metadata: 0x01977073 */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x01977074 */, bool helpTextIsLocalizationTerm = true /* Metadata: 0x01977075 */) {} // 0x0000000186EFBF50-0x0000000186EFC1D0
		public static void CreateErrorPopup(string id, string error, bool textIsLocalizationTerm = false /* Metadata: 0x01977076 */) {} // 0x0000000186EFC1D0-0x0000000186EFC520
		public static void CreateTwoButtonPopup(string id, string title, string description, string button1Text, string button2Text, Action button1Callback, Action button2Callback, bool titleIsLocalizationTerm = true /* Metadata: 0x01977077 */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x01977078 */, bool button1TextIsLocalizationTerm = true /* Metadata: 0x01977079 */, bool button2TextIsLocalizationTerm = true /* Metadata: 0x0197707A */) {} // 0x0000000186EFC520-0x0000000186EFC7C0
		public static void CreateEULAPopup(string id, string title, string button1Text, string button2Text, Action button1Callback, Action button2Callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197707B */, bool descriptionIsLocalizationTerm = true /* Metadata: 0x0197707C */, bool button1TextIsLocalizationTerm = true /* Metadata: 0x0197707D */, bool button2TextIsLocalizationTerm = true /* Metadata: 0x0197707E */) {} // 0x0000000186EFC7C0-0x0000000186EFCA50
		public static void CreateTextInputPopup(string id, string title, string button1Text, Action<string> button1Callback, bool titleIsLocalizationTerm = true /* Metadata: 0x0197707F */, bool button1TextIsLocalizationTerm = true /* Metadata: 0x01977080 */) {} // 0x0000000186EFCA50-0x0000000186EFCCA0
		public static void CreateAdventureCompletedPopup(string id) {} // 0x0000000186EFCCA0-0x0000000186EFCED0
		public static BasePopup CreateAdvancedMusicSelectionPopup(string id) => default; // 0x0000000186EFCED0-0x0000000186EFD1C0
		private void MakeFader(float targetAlpha = 0.5f /* Metadata: 0x01977081 */, float duration = 0.1f /* Metadata: 0x01977085 */) {} // 0x0000000186EFD1C0-0x0000000186EFD4B0
		public static void ClosePopup(string id) {} // 0x0000000186EFD4B0-0x0000000186EFD870
		public static bool PopupExists(string id) => default; // 0x0000000186EFD870-0x0000000186EFD900
		public static GameObject GetPopup(string id) => default; // 0x0000000186EFD900-0x0000000186EFD9A0
		public static T GetPopup<T>(string id)
			where T : Component => default;
		public static void SetAllowInput(bool val) {} // 0x0000000186EFD9A0-0x0000000186EFDBF0
		private static string Translate(string text) => default; // 0x0000000186EFDBF0-0x0000000186EFDC70
		private void TestLargeMultiOption() {} // 0x0000000186EFDC70-0x0000000186EFDFA0
		public static void MakeTESTLargeMultiOption() {} // 0x0000000186EFDFA0-0x0000000186EFDFF0
		private void TestTutorialPopup() {} // 0x0000000186EFDFF0-0x0000000186EFE080
		public static void MakeTESTTutorialPopup() {} // 0x0000000186EFE080-0x0000000186EFE150
		private void TestBlockingPopup() {} // 0x0000000186EFE150-0x0000000186EFE300
		public static void MakeTESTBlockingPopup() {} // 0x0000000186EFE300-0x0000000186EFE500
		private void TestAccountBlockingPopup() {} // 0x0000000186EFE500-0x0000000186EFE6B0
		public static void MakeTESTAccountBlockingPopup() {} // 0x0000000186EFE6B0-0x0000000186EFE8B0
		private void TestSaveFileComparison() {} // 0x0000000186EFE8B0-0x0000000186EFEBF0
		public static void MakeTESTSaveFileComparison() {} // 0x0000000186EFEBF0-0x0000000186EFEC40
		private void TestOKCancel() {} // 0x0000000186EFEC40-0x0000000186EFECC0
		public static void MakeTESTOKCancel() {} // 0x0000000186EFECC0-0x0000000186EFED80
		private void TestWarning() {} // 0x0000000186EFED80-0x0000000186EFEE00
		private void TestHelpError() {} // 0x0000000186EFEE00-0x0000000186EFEED0
		public static void MakeTESTWarning() {} // 0x0000000186EFEED0-0x0000000186EFEF90
		private void TestAccountError() {} // 0x0000000186EFEF90-0x0000000186EFF030
		public static void MakeTESTAccountError() {} // 0x0000000186EFF030-0x0000000186EFF110
		private void TestError() {} // 0x0000000186EFF110-0x0000000186EFF170
		public static void MakeTESTError() {} // 0x0000000186EFF170-0x0000000186EFF200
		private void TestTwoButton() {} // 0x0000000186EFF200-0x0000000186EFF2C0
		public static void MakeTESTTwoButton() {} // 0x0000000186EFF2C0-0x0000000186EFF3C0
		private void TestAdventureCompleted() {} // 0x0000000186EFF3C0-0x0000000186EFF400
		public static void MakeTESTAdventureCompleted() {} // 0x0000000186EFF400-0x0000000186EFF4F0
	}
}
