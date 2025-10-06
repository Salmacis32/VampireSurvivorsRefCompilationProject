/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Service;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ManageAccountPanel : BaseAccountPagePanel // TypeDefIndex: 14617
	{
		// Fields
		private AccountDetails _accountDetails; // 0x18
		private readonly AccountLinkService _accountLinkService; // 0x20
		private readonly AccountDeletionService _accountDeletionService; // 0x28
		private readonly SecretObscurer _secretObscurer; // 0x30
	
		// Constructors
		public ManageAccountPanel() {} // Dummy constructor
		public ManageAccountPanel(AccountPage accountPage) {} // 0x00000001871C0310-0x00000001871C0610
	
		// Methods
		public override async void Build() {} // 0x00000001871C0610-0x00000001871C07D0
		private void BuildAccountDetailsForCurrentPlatform() {} // 0x00000001871C07D0-0x00000001871C07E0
		private async Task<bool> LoadAccountDetail() => default; // 0x00000001871C07E0-0x00000001871C0960
		private void BuildAccountDetailsForEmail() {} // 0x00000001871C0960-0x00000001871C0AA0
		private void BuildAccountDetailsForPlatform(AccountDetailsType platform) {} // 0x00000001871C0AA0-0x00000001871C0F70
		private async Task LinkPlatform(AccountDetailsType platform, string platformAsString) => default; // 0x00000001871C0F70-0x00000001871C1190
		private void AddAccountAndEnvInfo() {} // 0x00000001871C1190-0x00000001871C14F0
		private async Task<bool> DoLink(AccountDetailsType platform) => default; // 0x00000001871C14F0-0x00000001871C1680
		private async Task DoForceLink(AccountDetailsType platform) => default; // 0x00000001871C1680-0x00000001871C1840
		private void ShowAlreadyLinkedPopup(AccountDetailsType platform) {} // 0x00000001871C1840-0x00000001871C1AC0
		private Task<int> ShowSaveDataConflictChoicePopup(ForceLinkConflictResponse conflictResponse) => default; // 0x00000001871C1AC0-0x00000001871C1F80
		private async Task AcceptMergeConflict() => default; // 0x00000001871C1F80-0x00000001871C2130
		private void HandleUnlink(AccountDetailsType platform) {} // 0x00000001871C2130-0x00000001871C23F0
	}
}
