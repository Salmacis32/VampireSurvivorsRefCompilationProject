/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.ClientModels;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Core;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework.Platforms.Backend.PlayFab.Platforms
{
	public class PlayFabPlayStation : IPlatform, IPlatformAuthentication // TypeDefIndex: 18610
	{
		// Constructors
		public PlayFabPlayStation() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x00000001819170A0-0x00000001819170B0
		public Task<ILoginResult> LoginOrRegister() => default; // 0x00000001867F2240-0x00000001867F2250
		public Task<ILoginResult> Login() => default; // 0x00000001867F2250-0x00000001867F2260
		public Task<ILinkResult> LinkAccount(bool force) => default; // 0x00000001867F2260-0x00000001867F24A0
		public Task<bool> UnlinkAccount() => default; // 0x00000001867F24A0-0x00000001867F2880
		private static Task<ILoginResult> LoginOrRegisterInternal(bool createAccount) => default; // 0x00000001867F2880-0x00000001867F2AC0
	}
}
