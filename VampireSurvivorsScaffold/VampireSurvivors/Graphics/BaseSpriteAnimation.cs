/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public abstract class BaseSpriteAnimation : GameMonoBehaviour // TypeDefIndex: 14530
	{
		// Fields
		public List<FrameAnimationData> _defaultAnimations; // 0x28
		private readonly Dictionary<string, FrameAnimationData> _animations; // 0x30
		private FrameAnimationData _currentAnimation; // 0x38
		private FrameAnimationData _localAnimation; // 0x40
		private Action<string> _onUpdate; // 0x48
		private static ProfilerMarker internalUpdateMarker; // 0x00
		private static readonly ProfilerMarker MarkerAddAnimation; // 0x08
		private static readonly ProfilerMarker MarkerCleanAnimations; // 0x10
	
		// Properties
		public bool IsPaused { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		public string CurrentAnim { get; } // 0x000000018705C140-0x000000018705C150 
	
		// Constructors
		protected BaseSpriteAnimation() {} // 0x000000018705D770-0x000000018705D9B0
		static BaseSpriteAnimation() {} // 0x000000018705D9B0-0x000000018705DAA0
	
		// Methods
		protected virtual new void Awake() {} // 0x000000018705C150-0x000000018705C2E0
		protected override void OnEnable() {} // 0x000000018705C2E0-0x000000018705C470
		protected override void OnDisable() {} // 0x000000018705C470-0x000000018705C5F0
		public void InternalUpdate(float deltaTime) {} // 0x00000001865DBDB0-0x00000001865DBE50
		public void create(string animName, List<Sprite> frames, int frameRate, bool shouldLoop, bool startRandomFrame = false /* Metadata: 0x01977152 */, Action onComplete = null, bool autoSetAnimation = true /* Metadata: 0x01977153 */) {} // 0x000000018705C5F0-0x000000018705C620
		public void AddAnimation(string animName, List<Sprite> frames, int fps, bool shouldLoop, bool startRandomFrame = false /* Metadata: 0x01977154 */, Action onComplete = null, bool autoSetAnimation = true /* Metadata: 0x01977155 */) {} // 0x000000018705C620-0x000000018705C960
		public void SetAnimation(FrameAnimationData newAnim, string animName) {} // 0x000000018705C960-0x000000018705CB30
		public void SetLocalAnimation(FrameAnimationData newAnim, string animName) {} // 0x000000018705CB30-0x000000018705CD80
		public FrameAnimationData GetCurrentAnimation() => default; // 0x0000000180B15560-0x0000000180B15570
		public Sprite GetCurrentFrame() => default; // 0x000000018705CD80-0x000000018705CDA0
		public void SetAnimation(string animName) {} // 0x000000018705CDA0-0x000000018705CFC0
		public void Play(string animName) {} // 0x000000018705CFC0-0x000000018705CFD0
		public void Play(string animName, int frameRate) {} // 0x000000018705CFD0-0x000000018705D110
		public FrameAnimationData GetAnimation(string animName) => default; // 0x000000018705D110-0x000000018705D190
		public bool ContainsAnim(string animName) => default; // 0x000000018705D190-0x000000018705D210
		public void AddCompletionCallback(string animName, Action callback) {} // 0x000000018705D210-0x000000018705D2A0
		public void RemoveCompletionCallback(string animName, Action callback) {} // 0x000000018705D2A0-0x000000018705D330
		public void AddUpdateCallback(Action<string> callback) {} // 0x000000018705D330-0x000000018705D430
		public void RemoveUpdateCallback(Action<string> callback) {} // 0x000000018705D430-0x000000018705D530
		public void ClearCallbacksForAnim(string animName) {} // 0x000000018705D530-0x000000018705D600
		public void CleanAnimations() {} // 0x000000018705D600-0x000000018705D6C0
		public void Stop() {} // 0x000000018705D6C0-0x000000018705D720
		public void Pause() {} // 0x00000001858CC910-0x00000001858CC920
		public void Resume() {} // 0x0000000185DED600-0x0000000185DED610
		private static bool IsAnimDataValid(FrameAnimationData frameAnimationData) => default; // 0x000000018705D720-0x000000018705D770
		protected abstract void ApplySpriteFrame(Sprite sprite);
	}
}
