/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public struct ErroInfo // TypeDefIndex: 18190
	{
		// Fields
		public static readonly ErroInfo NonError; // 0x00
		public readonly int NativeErrorCode; // 0x00
		public readonly Exception NativeException; // 0x08
		public readonly string Message; // 0x10
	
		// Constructors
		public ErroInfo(int nativeErrorCode, string msg = null) {
			NativeErrorCode = default;
			NativeException = default;
			Message = default;
		} // 0x00000001866F4D40-0x00000001866F4DF0
		public ErroInfo(Exception ex, string msg = null) {
			NativeErrorCode = default;
			NativeException = default;
			Message = default;
		} // 0x00000001866F4DF0-0x00000001866F4EB0
		static ErroInfo() {
			NonError = default;
		} // 0x00000001866F5040-0x00000001866F51C0
	
		// Methods
		public override string ToString() => default; // 0x00000001866F4EB0-0x00000001866F5040
	}
}
