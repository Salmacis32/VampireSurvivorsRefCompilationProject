/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.Video;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class VideoLoader // TypeDefIndex: 18270
	{
		// Methods
		public static void LoadVideo(string videoName, string cacheGroupName, DlcType? dlcType, Action<VideoClip> onComplete = null) {} // 0x0000000186725620-0x0000000186725640
		public static void LoadVideoAsync(string videoName, string cacheGroupName, DlcType? dlcType, Action<VideoClip> onComplete = null) {} // 0x0000000186725640-0x0000000186725660
		private static void LoadVideoInternal(string videoName, string cacheGroupName, DlcType? dlcType, Action<VideoClip> onComplete = null, bool forceSync = false /* Metadata: 0x01978906 */) {} // 0x0000000186725660-0x0000000186725A20
		private static void LoadVideoFromResourceLocation(IResourceLocation videoLocation, string cacheGroupName, string videoName, DlcType? dlcType, Action<VideoClip> onComplete = null, bool forceSync = false /* Metadata: 0x01978907 */) {} // 0x0000000186725A20-0x0000000186725CD0
	}
}
