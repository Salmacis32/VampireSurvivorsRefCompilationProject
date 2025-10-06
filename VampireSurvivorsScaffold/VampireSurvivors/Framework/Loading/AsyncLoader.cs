/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public class AsyncLoader // TypeDefIndex: 18272
	{
		// Fields
		private readonly List<Action<Action>> _loadCalls; // 0x10
		private int _remainingLoadCalls; // 0x18
		private Action _onComplete; // 0x20
	
		// Constructors
		public AsyncLoader() {} // Dummy constructor
		public AsyncLoader(Action onComplete) {} // 0x00000001867261B0-0x00000001867262D0
	
		// Methods
		private void OnLoad() {} // 0x00000001867262D0-0x00000001867264B0
		private async void Cleanup() {} // 0x00000001867264B0-0x0000000186726670
		public void Add(Action<Action> loadCall) {} // 0x0000000186726670-0x0000000186726710
		public void Load() {} // 0x0000000186726710-0x00000001867268E0
	}
}
