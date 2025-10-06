/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.TimerSystem
{
	public class TimerManager : GameMonoBehaviour // TypeDefIndex: 18153
	{
		// Fields
		private List<Timer> _timers; // 0x28
		private List<Timer> _timersToAdd; // 0x30
	
		// Constructors
		public TimerManager() {} // 0x00000001866DD7C0-0x00000001866DD940
	
		// Methods
		public void RegisterTimer(Timer timer) {} // 0x00000001866DCA20-0x00000001866DCA80
		public void CancelAllTimers() {} // 0x00000001866DCA80-0x00000001866DCE70
		public void PauseAllTimers() {} // 0x00000001866DCE70-0x00000001866DD0E0
		public void ResumeAllTimers() {} // 0x00000001866DD0E0-0x00000001866DD350
		protected void UpdateAllTimers() {} // 0x00000001866DD350-0x00000001866DD7C0
	}
}
