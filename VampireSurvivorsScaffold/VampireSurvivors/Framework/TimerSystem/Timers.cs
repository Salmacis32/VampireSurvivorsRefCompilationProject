/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.TimerSystem
{
	public class Timers // TypeDefIndex: 18157
	{
		// Fields
		protected static TimerManagerGame _managerGame; // 0x00
		protected static TimerManagerUI _managerUI; // 0x08
		protected static TimerManagerAutomation _managerAutomation; // 0x10
	
		// Constructors
		public Timers() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public static Timer Register(float duration, Action onComplete, Action<float> onUpdate = null, bool isLooped = false /* Metadata: 0x01978746 */, bool useRealTime = false /* Metadata: 0x01978747 */, MonoBehaviour autoDestroyOwner = null, int repeat = 0 /* Metadata: 0x01978748 */, TimerType type = TimerType.GAME /* Metadata: 0x01978749 */, bool isOnlineTimer = false /* Metadata: 0x0197874A */, bool canPause = true /* Metadata: 0x0197874B */) => default; // 0x00000001866DDAC0-0x00000001866DDCA0
		public static void InitManagers() {} // 0x00000001866DDCA0-0x00000001866DE580
		public static void Cancel(Timer timer) {} // 0x00000001866DE580-0x00000001866DE590
		public static void Pause(Timer timer) {} // 0x00000001866DE590-0x00000001866DE5A0
		public static void Resume(Timer timer) {} // 0x00000001866DE5A0-0x00000001866DE5B0
		public static void CancelAllRegisteredTimers() {} // 0x00000001866DE5B0-0x00000001866DE780
		public static void PauseAllRegisteredTimers() {} // 0x00000001866DE780-0x00000001866DE950
		public static void ResumeAllRegisteredTimers() {} // 0x00000001866DE950-0x00000001866DEB20
	}
}
