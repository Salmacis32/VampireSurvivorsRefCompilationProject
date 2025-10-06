/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	public class VideoPlaybackManager // TypeDefIndex: 18558
	{
		// Fields
		private GameObject _videoPlayerPrefab; // 0x10
		private Dictionary<VideoClip, RenderTexture> _renderTextures; // 0x18
		private Dictionary<VideoClip, VideoPlayerHelper> _videoPlayerHelpers; // 0x20
	
		// Constructors
		public VideoPlaybackManager() {} // 0x00000001867DF790-0x00000001867DF8F0
	
		// Methods
		public VideoPlayerHelper GenerateVideoPlayerForRenderTexture(VideoClip videoClip) => default; // 0x00000001867DE720-0x00000001867DEB00
		public UnityEngine.Renderer GenerateQuadForVideoPlayback(VideoClip videoClip, Vector2 spawnPos, Vector3 scale, float alpha = 1f /* Metadata: 0x0197AA61 */) => default; // 0x00000001867DEB00-0x00000001867DEEE0
		public void ReleaseVideo(VideoClip videoClip) {} // 0x00000001867DEEE0-0x00000001867DF150
		public void Cleanup() {} // 0x00000001867DF150-0x00000001867DF420
		private GameObject GetVideoPlayerPrefab() => default; // 0x00000001867DF420-0x00000001867DF570
		private RenderTexture GenerateRenderTexture(VideoClip videoClip) => default; // 0x00000001867DF570-0x00000001867DF790
	}
}
