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
	public class Timer // TypeDefIndex: 18151
	{
		// Fields
		protected static TimerManager _manager; // 0x00
		protected readonly Action _onComplete; // 0x18
		protected readonly Action<float> _onUpdate; // 0x20
		protected float _startTime; // 0x28
		protected float _lastUpdateTime; // 0x2C
		protected int _repeat; // 0x30
		protected float? _timeElapsedBeforeCancel; // 0x34
		protected float? _timeElapsedBeforePause; // 0x3C
		protected readonly MonoBehaviour _autoDestroyOwner; // 0x48
		protected readonly bool _hasAutoDestroyOwner; // 0x50
		protected bool _isOnlineTimer; // 0x51
		protected bool _canPause; // 0x52
	
		// Properties
		public float Duration { get; protected set; } // 0x0000000182740170-0x0000000182740180 0x0000000182740190-0x00000001827401A0
		public bool IsLooped { get; set; } // 0x000000018195FC30-0x000000018195FC40 0x000000018195FC40-0x000000018195FC50
		public bool IsCompleted { get; protected set; } // 0x0000000181B59560-0x0000000181B59570 0x0000000181B59570-0x0000000181B59580
		public bool UsesRealTime { get; protected set; } // 0x0000000181DF61D0-0x0000000181DF61E0 0x0000000181DF61E0-0x0000000181DF61F0
		public bool IsPaused { get => default; } // 0x00000001866DBDD0-0x00000001866DBE10 
		public bool IsCancelled { get => default; } // 0x00000001866DBE10-0x00000001866DBE50 
		public bool IsDone { get => default; } // 0x00000001866DBE50-0x00000001866DBF60 
		public int RepeatCount { get => default; } // 0x0000000181953B80-0x0000000181953B90 
		protected bool IsOwnerDestroyed { get => default; } // 0x00000001866DC3B0-0x00000001866DC490 
	
		// Constructors
		public Timer() {} // Dummy constructor
		public Timer(float duration, Action onComplete, Action<float> onUpdate, bool isLooped, bool usesRealTime, MonoBehaviour autoDestroyOwner, int repeat = 0 /* Metadata: 0x01978743 */, bool isMultiplayer = false /* Metadata: 0x01978744 */, bool canPause = true /* Metadata: 0x01978745 */) {} // 0x00000001866DC490-0x00000001866DC6D0
	
		// Methods
		public void Cancel() {} // 0x00000001866DBF60-0x00000001866DBFD0
		public void Complete(bool runAllRepeats = false /* Metadata: 0x01978742 */) {} // 0x00000001866DBFD0-0x00000001866DC0A0
		public void Pause() {} // 0x00000001866DC0A0-0x00000001866DC140
		public void Resume() {} // 0x00000001866DC140-0x00000001866DC1F0
		public float GetTimeElapsed() => default; // 0x00000001866DC1F0-0x00000001866DC290
		public float GetTimeRemaining() => default; // 0x00000001866DC290-0x00000001866DC370
		public float GetRatioComplete() => default; // 0x00000001866DC370-0x00000001866DC390
		public float GetRatioRemaining() => default; // 0x00000001866DC390-0x00000001866DC3B0
		private void InitializeTime() {} // 0x00000001866DC6D0-0x00000001866DC780
		private void AdjustStartTimeForOnlineDeSync() {} // 0x00000001866DC780-0x00000001866DC820
		private float GetAdjustTime(float adjustTime) => default; // 0x00000001866DC820-0x00000001866DC840
		protected float GetWorldTime() => default; // 0x00000001866DC840-0x00000001866DC8D0
		protected float GetFireTime() => default; // 0x00000001866DC8D0-0x00000001866DC8E0
		protected float GetTimeDelta() => default; // 0x00000001866DC8E0-0x00000001866DC900
		public void Update() {} // 0x00000001866DC900-0x00000001866DCA20
	}
}
