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

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab.Platforms
{
	public class PlayFabApple : IPlatform, IPlatformAuthentication // TypeDefIndex: 18761
	{
		// Constructors
		public PlayFabApple() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000181F01BA0-0x0000000181F01BB0
		public Task<ILoginResult> Login() => default; // 0x0000000186833D90-0x0000000186833DA0
		public Task<ILoginResult> LoginOrRegister() => default; // 0x0000000186833DA0-0x0000000186833DB0
		private Task<ILoginResult> LoginOrRegisterInternal(bool createAccount) => default; // 0x0000000186833DB0-0x0000000186833FF0
		public Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AFB0 */) => default; // 0x0000000186833FF0-0x0000000186834230
		public Task<bool> UnlinkAccount() => default; // 0x0000000186834230-0x0000000186834610
	}
}
