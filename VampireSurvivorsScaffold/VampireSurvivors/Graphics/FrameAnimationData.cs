/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	[Serializable]
	public class FrameAnimationData // TypeDefIndex: 14531
	{
		// Fields
		public string _name; // 0x10
		public List<Sprite> _frames; // 0x18
		public int _fps; // 0x20
		public bool _shouldLoop; // 0x24
		[HideInInspector]
		public float _frameInterval; // 0x28
		public bool _startOnRandomFrame; // 0x2C
		[HideInInspector]
		public bool _frameChanged; // 0x2D
		private int _frameIndex; // 0x30
		private float _currentTime; // 0x34
		private float _timeSinceFrameChange; // 0x38
		private Action _onComplete; // 0x40
		private bool _hasCompleted; // 0x48
	
		// Constructors
		public FrameAnimationData() {} // Dummy constructor
		public FrameAnimationData(string name, List<Sprite> frames, int fps, bool shouldLoop, bool startOnRandomFrame = false /* Metadata: 0x01977156 */, Action onComplete = null) {} // 0x000000018705DAA0-0x000000018705DC00
	
		// Methods
		public void AddTime(float deltaTime) {} // 0x000000018705DC00-0x000000018705DD10
		public void Reset() {} // 0x000000018705DD10-0x000000018705DD30
		public Sprite GetFrame() => default; // 0x000000018705DD30-0x000000018705DDA0
		public int GetFrameIndex() => default; // 0x0000000181953B80-0x0000000181953B90
		public void AddCompletionCallback(Action callback) {} // 0x000000018705DDA0-0x000000018705DE90
		public void RemoveCompletionCallback(Action callback) {} // 0x000000018705DE90-0x000000018705DF80
		public void ClearCallbacks() {} // 0x000000018705DF80-0x000000018705DFE0
		private void SetStartingFrame() {} // 0x000000018705DFE0-0x000000018705E090
	}
}
