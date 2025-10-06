/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Service;
using VampireSurvivors.App.Scripts.UI;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AccountPage : ProgrammaticUI // TypeDefIndex: 14570
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _AccountStatus; // 0x160
		[SerializeField]
		private UnityEngine.UI.Button _SpecialButton; // 0x168
		[SerializeField]
		private Image _SpecialButtonIcon; // 0x170
		[SerializeField]
		private Sprite _showHideSprite; // 0x178
		[SerializeField]
		private Sprite _infoSprite; // 0x180
		private PlayerOptions _playerOptions; // 0x188
		private AccountPageState accountPageState; // 0x190
		private AchievementManager _achievementManager; // 0x198
		private bool _backBeingBlockedByInput; // 0x1A0
		private const bool ACCOUNT_VERIFICATION_REQUIRED = true; // Metadata: 0x01977176
	
		// Constructors
		public AccountPage() {} // 0x00000001871B5730-0x00000001871B5AA0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, AchievementManager achievementManager) {} // 0x00000001871B3030-0x00000001871B3100
		protected override void Awake() {} // 0x00000001871B3100-0x00000001871B31C0
		private void ClearAndBuild() {} // 0x00000001871B31C0-0x00000001871B32E0
		private void Build() {} // 0x00000001871B32E0-0x00000001871B3360
		protected override async void OnShowStart(GameObject g) {} // 0x00000001871B3360-0x00000001871B3580
		protected override void OnHideStart(GameObject g) {} // 0x0000000186927040-0x0000000186927050
		public void LateUpdate() {} // 0x00000001871B3580-0x00000001871B3870
		public void AddBackButtonListener() {} // 0x00000001871B3870-0x00000001871B3910
		public bool GetFlag(string key) => default; // 0x00000001871B3910-0x00000001871B39C0
		public void SetFlag(string key, bool value) {} // 0x00000001871B39C0-0x00000001871B3A50
		private void BackButtonPress() {} // 0x00000001871B3A50-0x00000001871B3B80
		private void ClearHistory() {} // 0x00000001871B3B80-0x00000001871B3BE0
		public void AddLogoutButton() {} // 0x00000001871B3BE0-0x00000001871B3CC0
		public async Task DoLogout() => default; // 0x00000001871B3CC0-0x00000001871B3E70
		public void ChangeStateTo(UIState uiState) {} // 0x00000001871B3E70-0x00000001871B3EB0
		public void GoHome() {} // 0x00000001871B3EB0-0x00000001871B3F60
		public void SetTitle(string title) {} // 0x00000001871B3F60-0x00000001871B3F90
		public void HideLoggedInStatus() {} // 0x00000001871B3F90-0x00000001871B3FC0
		public static bool IsAccountVerificationRequired() => default; // 0x0000000181958370-0x0000000181958380
		public void SetLoggedInStatus() {} // 0x00000001871B3FC0-0x00000001871B4120
		public void SetGenericUnverifiedStatus() {} // 0x00000001871B4120-0x00000001871B41B0
		public void SetGenericLoggedInStatus() {} // 0x00000001871B41B0-0x00000001871B4240
		private void SetLoggedOutStatus() {} // 0x00000001871B4240-0x00000001871B42D0
		private BaseAccountPagePanel GetPanelForState(UIState state) => default; // 0x00000001871B42D0-0x00000001871B4B50
		public static string GetTranslation(string key) => default; // 0x00000001871B4B50-0x00000001871B4BF0
		public static string GetAccountTranslation(string key) => default; // 0x00000001871B4BF0-0x00000001871B4C90
		public static string GetAccountTranslation(string key, params string[] args) => default; // 0x00000001871B4C90-0x00000001871B4E40
		public void ShowSpecialButtonForShowHide(Action action) {} // 0x00000001871B4E40-0x00000001871B4E50
		public void ShowSpecialButtonForInformation(Action action) {} // 0x00000001871B4E50-0x00000001871B4E60
		public void DisableSpecialButton() {} // 0x00000001871B4E60-0x00000001871B4FE0
		private void EnableSpecialButton(Action action, Sprite sprite) {} // 0x00000001871B4FE0-0x00000001871B5290
		public void ReAddSpecialButtonNavigation() {} // 0x00000001871B5290-0x00000001871B53D0
		public override void Clear() {} // 0x00000001871B53D0-0x00000001871B5680
		public override void SelectFirstSelectable() {} // 0x00000001871B5680-0x00000001871B5730
	}
}
