/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	internal class SecretObscurer // TypeDefIndex: 14619
	{
		// Fields
		private bool _shouldObscure; // 0x10
		private readonly Dictionary<Secret, string> _secrets; // 0x18
	
		// Constructors
		public SecretObscurer() {} // 0x00000001873038C0-0x0000000187303980
	
		// Methods
		public void Toggle() {} // 0x0000000187303580-0x0000000187303590
		public void AddSecret(Secret key, string plaintext) {} // 0x0000000187303590-0x0000000187303690
		public string Get(Secret key) => default; // 0x0000000187303690-0x00000001873037A0
		private string GetPlaintext(Secret key) => default; // 0x00000001873037A0-0x0000000187303800
		private string GetObscured(Secret key) => default; // 0x0000000187303800-0x00000001873038C0
	}
}
