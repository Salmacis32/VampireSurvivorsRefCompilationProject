/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Authentication;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.PlayFab
{
	public class PlayFabPlayerProfile : IPlayerProfile // TypeDefIndex: 18756
	{
		// Fields
		private string _contactEmailAddress; // 0x10
		private bool _isContactEmailAddressVerified; // 0x18
	
		// Constructors
		public PlayFabPlayerProfile() {} // Dummy constructor
		public PlayFabPlayerProfile(string contactEmailAddress = "" /* Metadata: 0x0197AFAE */, bool isContactEmailAddressVerified = false /* Metadata: 0x0197AFAF */) {} // 0x00000001831C0870-0x00000001831C08D0
	
		// Methods
		public override bool HasContactEmailAddress() => default; // 0x0000000184CFD7C0-0x0000000184CFD7E0
		public override string GetContactEmailAddress() => default; // 0x0000000180B15C10-0x0000000180B15C20
		public override bool IsContactEmailAddressVerified() => default; // 0x000000018195C490-0x000000018195C4A0
	}
}
