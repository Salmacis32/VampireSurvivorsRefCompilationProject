/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	public class VideoPlayerHelper : MonoBehaviour // TypeDefIndex: 18559
	{
		// Fields
		[SerializeField]
		private VideoPlayer _VideoPlayer; // 0x20
		private Material _videoMat; // 0x28
		private Action _onFrameReady; // 0x30
	
		// Properties
		public UnityEngine.Renderer VideoRenderer { get => default; } // 0x00000001867DF8F0-0x00000001867DF910 
	
		// Constructors
		public VideoPlayerHelper() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001867DF910-0x00000001867DF9E0
		public void SetClip(VideoClip clip) {} // 0x00000001867DF9E0-0x00000001867DFA00
		public void Play(Action onFrameReady = null) {} // 0x00000001867DFA00-0x00000001867DFE10
		public void Stop() {} // 0x00000001867DFE10-0x00000001867DFFE0
		public void SetDepth(float depth) {} // 0x00000001867DFFE0-0x00000001867E0020
		public void SetToRenderTextureMode(RenderTexture renderTexture) {} // 0x00000001867E0020-0x00000001867E02A0
		private void OnPrepareCompleted(VideoPlayer source) {} // 0x00000001867E02A0-0x00000001867E0360
	}
}
