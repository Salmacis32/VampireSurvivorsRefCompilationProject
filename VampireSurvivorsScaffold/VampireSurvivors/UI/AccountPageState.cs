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
	public class AccountPageState // TypeDefIndex: 14632
	{
		// Fields
		private LoginType loginState; // 0x10
		private LinkedList<UIState> stateHistory; // 0x18
		private Dictionary<string, bool> flags; // 0x20
	
		// Constructors
		public AccountPageState() {} // 0x0000000187307D60-0x0000000187307EB0
	
		// Methods
		public void SetFlag(string key, bool value) {} // 0x00000001873076C0-0x0000000187307750
		public bool GetFlag(string key) => default; // 0x0000000187307750-0x0000000187307800
		public UIState GetState() => default; // 0x0000000187307800-0x0000000187307840
		public void ClearHistory() {} // 0x0000000187307840-0x0000000187307890
		public void ChangeStateTo(UIState uiState) {} // 0x0000000187307890-0x0000000187307A60
		public bool CanGoBack() => default; // 0x0000000187307A60-0x0000000187307AB0
		public void GoBack() {} // 0x0000000187307AB0-0x0000000187307B80
		public void GoHome() {} // 0x0000000187307B80-0x0000000187307BC0
		public void SetLoginState(LoginType newState) {} // 0x0000000180B19030-0x0000000180B19040
		private string StringifyHistory() => default; // 0x0000000187307BC0-0x0000000187307D60
	}
}
