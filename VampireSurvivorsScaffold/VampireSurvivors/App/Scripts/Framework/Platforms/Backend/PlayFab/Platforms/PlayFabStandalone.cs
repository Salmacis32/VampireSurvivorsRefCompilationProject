/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Core;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab.Platforms
{
	public class PlayFabStandalone : IPlatform, IPlatformAuthentication // TypeDefIndex: 18770
	{
		// Constructors
		public PlayFabStandalone() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public PlatformType GetPlatformName() => default; // 0x0000000180B15D70-0x0000000180B15D80
		public Task<ILoginResult> LoginOrRegister() => default; // 0x0000000186838B00-0x0000000186838B50
		public Task<ILoginResult> Login() => default; // 0x0000000186838B50-0x0000000186838BA0
		public Task<ILinkResult> LinkAccount(bool force) => default; // 0x0000000186838BA0-0x0000000186838BF0
		public Task<bool> UnlinkAccount() => default; // 0x0000000186838BF0-0x0000000186838C40
	}
}
