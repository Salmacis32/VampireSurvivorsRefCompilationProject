/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.DLC.Types;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public class AddressableLoader // TypeDefIndex: 18246
	{
		// Fields
		public static bool SimulateThrottle; // 0x00
		public static int ThrottleAmount; // 0x04
		public static readonly string DefaultPath; // 0x08
		private static string _currentAssetBundlePath; // 0x10
		public static bool UseSyncLoad; // 0x18
	
		// Properties
		public static string CurrentPath { get => default; } // 0x000000018671E6A0-0x000000018671E700 
	
		// Constructors
		public AddressableLoader() {} // 0x0000000180B15170-0x0000000180B15180
		static AddressableLoader() {} // 0x000000018671F080-0x000000018671F1F0
	
		// Methods
		private static string ReplaceAssetBundlePaths(IResourceLocation location) => default; // 0x000000018671E700-0x000000018671EBE0
		[RuntimeInitializeOnLoadMethod]
		public static void SetInternalIdTransform() {} // 0x000000018671EBE0-0x000000018671ED50
		public static void SetPath(string path) {} // 0x000000018671ED50-0x000000018671EE60
		public static void PointAtDlc(DlcType dlcType) {} // 0x000000018671EE60-0x000000018671F050
		public static T LoadAsset<T>(DlcType? dlcType, AssetReferenceT<T> assetReference, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788EC */, string customGroupName = null, string customHandleKey = null)
			where T : UnityEngine.Object => default;
		public static T LoadAsset<T>(DlcType? dlcType, AssetReference assetReference, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788ED */, string customGroupName = null, string customHandleKey = null) => default;
		public static T LoadAsset<T>(DlcType? dlcType, IResourceLocation assetLocation, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788EE */, string customGroupName = null, string customHandleKey = null) => default;
		public static void LoadAssetAsync<T>(DlcType? dlcType, AssetReferenceT<T> assetReference, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788EF */, string customGroupName = null, string customHandleKey = null, Action<T> onComplete = null)
			where T : UnityEngine.Object {}
		public static void LoadAssetAsync<T>(DlcType? dlcType, AssetReference assetReference, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788F0 */, string customGroupName = null, string customHandleKey = null, Action<T> onComplete = null) {}
		public static void LoadAssetAsync<T>(DlcType? dlcType, IResourceLocation assetLocation, AddressableType handleType = AddressableType.DYNAMIC /* Metadata: 0x019788F1 */, string customGroupName = null, string customHandleKey = null, Action<T> onComplete = null) {}
		public static void DoAssetLoad<T>(AsyncOperationHandle<T> op, Action<T> onComplete = null) {}
		public static bool CheckValidAssetReference(AssetReference assetReference) => default; // 0x000000018671F050-0x000000018671F080
	}
}
