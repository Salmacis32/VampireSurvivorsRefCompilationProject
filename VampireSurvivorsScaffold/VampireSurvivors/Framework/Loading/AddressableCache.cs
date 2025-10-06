/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using VampireSurvivors.Framework.DLC.Types;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public static class AddressableCache // TypeDefIndex: 18243
	{
		// Fields
		private static readonly List<AsyncOperationHandle> PersistentOperationHandles; // 0x00
		private static readonly Dictionary<AssetReference, AsyncOperationHandle> DynamicOperationHandles; // 0x08
		private static readonly Dictionary<IResourceLocation, AsyncOperationHandle> DynamicLocationOperationHandles; // 0x10
		private static readonly Dictionary<string, Dictionary<string, AsyncOperationHandle>> CustomOperationHandles; // 0x18
		private static readonly Dictionary<string, List<string>> TextureCache; // 0x20
	
		// Constructors
		static AddressableCache() {} // 0x000000018671E2E0-0x000000018671E6A0
	
		// Methods
		public static List<AsyncOperationHandle> GetPersistentOperationHandles() => default; // 0x000000018671A1D0-0x000000018671A230
		public static Dictionary<AssetReference, AsyncOperationHandle> GetDynamicOperationHandles() => default; // 0x000000018671A230-0x000000018671A290
		public static Dictionary<IResourceLocation, AsyncOperationHandle> GetDynamicLocationOperationHandles() => default; // 0x000000018671A290-0x000000018671A2F0
		public static Dictionary<string, Dictionary<string, AsyncOperationHandle>> GetCustomOperationHandles() => default; // 0x000000018671A2F0-0x000000018671A350
		public static void ReleaseAll() {} // 0x000000018671A350-0x000000018671A3B0
		public static void ReleaseAllCustomOperationHandles() {} // 0x000000018671A3B0-0x000000018671A7F0
		public static void ReleaseCustomOperationHandleGroups(List<string> groupNames) {} // 0x000000018671A7F0-0x000000018671A960
		public static void ReleaseCustomOperationHandleGroup(string groupName) {} // 0x000000018671A960-0x000000018671AE30
		public static void ReleaseCustomOperationHandleGroupExcludingKeys(string groupName, List<string> excludedKeys) {} // 0x000000018671AE30-0x000000018671B4B0
		public static void ReleaseCustomOperationHandles(string groupName, List<string> keys) {} // 0x000000018671B4B0-0x000000018671B630
		public static void ReleaseCustomOperationHandle(string groupName, string key) {} // 0x000000018671B630-0x000000018671B990
		public static List<string> GetCustomOperationHandleKeys(string groupName) => default; // 0x000000018671B990-0x000000018671BCB0
		public static void ReleasePersistentOperationHandles() {} // 0x000000018671BCB0-0x000000018671C040
		public static void ReleaseDynamicOperationHandles() {} // 0x000000018671C040-0x000000018671C750
		public static void SavePersistentHandle(AsyncOperationHandle handle) {} // 0x000000018671C750-0x000000018671C7F0
		public static AsyncOperationHandle? TryAndGetFromCache(AssetReference assetReference, AddressableType handleType, string customGroupName, string customHandleKey) => default; // 0x000000018671C7F0-0x000000018671CA40
		public static AsyncOperationHandle? TryAndGetFromCache(IResourceLocation assetResourceLocation, AddressableType handleType, string customGroupName, string customHandleKey) => default; // 0x000000018671CA40-0x000000018671CC90
		public static void SaveHandle(AssetReference assetReference, AsyncOperationHandle op, AddressableType handleType, string customGroupName, string customHandleKey) {} // 0x000000018671CC90-0x000000018671CE10
		public static void SaveHandle(IResourceLocation assetResourceLocation, AsyncOperationHandle op, AddressableType handleType, string customGroupName, string customHandleKey) {} // 0x000000018671CE10-0x000000018671CF90
		private static AsyncOperationHandle? TryAndGetFromCustomCache(string customGroupName, string customHandleKey) => default; // 0x000000018671CF90-0x000000018671D260
		private static void SaveCustomHandle(AsyncOperationHandle op, string customGroupName, string customHandleKey) {} // 0x000000018671D260-0x000000018671D5B0
		public static Dictionary<string, List<string>> GetTextureCache() => default; // 0x000000018671D5B0-0x000000018671D610
		public static void SaveTexture(string cacheGroup, string textureName) {} // 0x000000018671D610-0x000000018671D8B0
		public static bool TextureExistsInCache(string cacheGroup, string texture) => default; // 0x000000018671D8B0-0x000000018671D9E0
		public static List<string> GetTexturesInGroup(string cacheGroup) => default; // 0x000000018671D9E0-0x000000018671DB20
		public static void RemoveTexture(string cacheGroup, string texture) {} // 0x000000018671DB20-0x000000018671DCD0
		public static void RemoveTextures(string cacheGroup, List<string> textures) {} // 0x000000018671DCD0-0x000000018671DFB0
		public static void RemoveTextureGroup(string cacheGroup) {} // 0x000000018671DFB0-0x000000018671E040
		public static void RemoveTexturesFromCacheAndSpriteManager(string cacheGroup) {} // 0x000000018671E040-0x000000018671E2E0
	}
}
