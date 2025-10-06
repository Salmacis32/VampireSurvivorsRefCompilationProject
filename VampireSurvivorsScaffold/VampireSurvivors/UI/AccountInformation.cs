/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AccountInformation // TypeDefIndex: 14631
	{
		// Fields
		private static readonly AccountInformation _accountInformation; // 0x00
	
		// Properties
		private IPlayerProfile PlayerProfile { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		private string AccountEmailAddress { get; set; } // 0x0000000180B15520-0x0000000180B15530 0x0000000181957C80-0x0000000181957CE0
	
		// Constructors
		private AccountInformation() {} // 0x0000000180B15170-0x0000000180B15180
		static AccountInformation() {} // 0x0000000187307050-0x00000001873070F0
	
		// Methods
		public static AccountInformation Instance() => default; // 0x0000000187306C90-0x0000000187306CF0
		public IPlayerProfile GetPlayerProfile() => default; // 0x0000000187306CF0-0x0000000187306D60
		public string GetAccountEmailAddress() => default; // 0x0000000187306D60-0x0000000187306DE0
		public async Task Fetch() => default; // 0x0000000187306DE0-0x0000000187306F90
		public void Clear() {} // 0x0000000187306F90-0x0000000187307040
		private bool HasAccountEmailAddress() => default; // 0x0000000187307040-0x0000000187307050
		private bool HasPlayerProfile() => default; // 0x0000000182A3DCF0-0x0000000182A3DD00
	}
}
