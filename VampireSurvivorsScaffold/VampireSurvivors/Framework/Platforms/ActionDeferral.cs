/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public class ActionDeferral // TypeDefIndex: 18192
	{
		// Fields
		private Action m_OnUnlock; // 0x10
		private int m_Locks; // 0x18
	
		// Constructors
		public ActionDeferral() {} // Dummy constructor
		public ActionDeferral(Action onUnlock) {} // 0x0000000181958310-0x0000000181958370
	
		// Methods
		public void Lock() {} // 0x00000001866F51C0-0x00000001866F52E0
		public bool Unlock() => default; // 0x00000001866F52E0-0x00000001866F5460
	}
}
