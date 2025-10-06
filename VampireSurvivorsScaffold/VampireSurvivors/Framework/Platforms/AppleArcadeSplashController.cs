/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public class AppleArcadeSplashController : MonoBehaviour // TypeDefIndex: 18198
	{
		// Fields
		[SerializeField]
		private VideoPlayer _VideoPlayer; // 0x20
		[SerializeField]
		private VideoClip _DefaultPortraitClip; // 0x28
		[SerializeField]
		private VideoClip _DefaultLandscapeClip; // 0x30
		public List<AspectRatioVideoHolder> _PortraitAspectRatioVideoHolders; // 0x38
		public List<AspectRatioVideoHolder> _LandscapeAspectRatioVideoHolders; // 0x40
		[SerializeField]
		private CanvasGroup _VampireSurvivorsSplashContainerPortrait; // 0x48
		[SerializeField]
		private CanvasGroup _VampireSurvivorsSplashContainerLandscape; // 0x50
		private bool _hasSkipped; // 0x58
	
		// Nested types
		[Serializable]
		public class AspectRatioVideoHolder // TypeDefIndex: 18195
		{
			// Fields
			public float _AspectRatio; // 0x10
			public VideoClip _VideoClip; // 0x18
	
			// Constructors
			public AspectRatioVideoHolder() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public AppleArcadeSplashController() {} // 0x00000001866F72C0-0x00000001866F7430
	
		// Methods
		private void Awake() {} // 0x00000001866F5F40-0x00000001866F5FD0
		private void Start() {} // 0x00000001866F5FD0-0x00000001866F61D0
		private void Update() {} // 0x00000001866F61D0-0x00000001866F6270
		private void SkipAppleSplash() {} // 0x00000001866F6270-0x00000001866F62D0
		private void OnLoopPointReached(VideoPlayer source) {} // 0x00000001866F62D0-0x00000001866F62E0
		private void ShowVampireSurvivorsSplash() {} // 0x00000001866F62E0-0x00000001866F6860
		private void LoadGame() {} // 0x00000001866F6860-0x00000001866F6910
		[IteratorStateMachine(typeof(_DelaySetVideoClip_d__15))]
		private IEnumerator DelaySetVideoClip() => default; // 0x00000001866F6910-0x00000001866F69B0
		private void SetVideoClipBasedOnAspectRatio() {} // 0x00000001866F69B0-0x00000001866F6F40
		private float GetAspectRatio() => default; // 0x00000001866F6F40-0x00000001866F7100
		private VideoClip GetVideoClipForAspectRatio(float aspectRatio, bool isPortrait) => default; // 0x00000001866F7100-0x00000001866F72C0
	}
}
