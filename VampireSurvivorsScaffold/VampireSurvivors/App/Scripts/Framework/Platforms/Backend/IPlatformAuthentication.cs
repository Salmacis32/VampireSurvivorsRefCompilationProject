/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend
{
	public interface IPlatformAuthentication // TypeDefIndex: 18678
	{
		// Methods
		Task<ILoginResult> LoginOrRegister();
		Task<ILoginResult> Login();
		Task<ILinkResult> LinkAccount(bool force);
		Task<bool> UnlinkAccount();
	}
}
