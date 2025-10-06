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
	public class PlayFabGoogle : IPlatform, IPlatformAuthentication // TypeDefIndex: 18765
	{
		// Constructors
		public PlayFabGoogle() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000180B21B50-0x0000000180B21B60
		public Task<ILoginResult> Login() => default; // 0x0000000186835760-0x0000000186835770
		public Task<ILoginResult> LoginOrRegister() => default; // 0x0000000186835770-0x0000000186835780
		private Task<ILoginResult> LoginOrRegisterInternal(bool createAccount) => default; // 0x0000000186835780-0x00000001868359C0
		public Task<ILinkResult> LinkAccount(bool force = false /* Metadata: 0x0197AFB1 */) => default; // 0x00000001868359C0-0x0000000186835C00
		public Task<bool> UnlinkAccount() => default; // 0x0000000186835C00-0x0000000186835FE0
	}
}
