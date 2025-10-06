/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayFab;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Exceptions
{
	public class PlayFabApiException : Exception // TypeDefIndex: 18788
	{
		// Fields
		private PlayFabError _error; // 0x90
	
		// Properties
		public override string Message { get => default; } // 0x0000000185DEC020-0x0000000185DEC040 
	
		// Constructors
		private PlayFabApiException() {} // 0x000000018683D800-0x000000018683D850
	
		// Methods
		public static PlayFabApiException FromPlayFabError(PlayFabError error) => default; // 0x000000018683D850-0x000000018683D940
		public int GetErrorCode() => default; // 0x000000018683D940-0x000000018683D960
		public string GetErrorMessage() => default; // 0x000000018683D960-0x000000018683DD20
	}
}
