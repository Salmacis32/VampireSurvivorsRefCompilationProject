/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Service;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI.Account
{
	public class AdvancedSettingsPanel : BaseAccountPagePanel // TypeDefIndex: 18648
	{
		// Fields
		private readonly AccountDeletionService _accountDeletionService; // 0x18
		private AccountDetails _accountDetails; // 0x20
	
		// Constructors
		public AdvancedSettingsPanel() {} // Dummy constructor
		public AdvancedSettingsPanel(AccountPage accountPage) {} // 0x0000000186808B30-0x0000000186808BD0
	
		// Methods
		public override async void Build() {} // 0x0000000186808BD0-0x0000000186808D90
		private async Task<bool> LoadAccountDetail() => default; // 0x0000000186808D90-0x0000000186808F10
	}
}
