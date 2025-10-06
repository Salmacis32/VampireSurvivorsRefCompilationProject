/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class SpriteLoader // TypeDefIndex: 18267
	{
		// Methods
		public static bool LoadTexture(string textureName, string cacheGroupName, DlcType? dlcType, Action<bool> onComplete = null) => default; // 0x0000000186724270-0x0000000186724460
		public static void LoadTextureAsync(string textureName, string cacheGroupName, DlcType? dlcType, Action<bool> onComplete = null) {} // 0x0000000186724460-0x0000000186724640
		private static void Log(string message) {} // 0x0000000186724640-0x00000001867246C0
		private static void LoadTextureInternal(string textureName, string cacheGroupName, DlcType? dlcType, Action<bool> onComplete = null, bool forceSync = false /* Metadata: 0x01978904 */) {} // 0x00000001867246C0-0x0000000186724B00
		private static void LoadSpritesFromTexture(IResourceLocation textureLocation, string cacheGroupName, string textureName, DlcType? dlcType, Action<bool> onComplete = null, bool forceSync = false /* Metadata: 0x01978905 */) {} // 0x0000000186724B00-0x0000000186724EB0
	}
}
