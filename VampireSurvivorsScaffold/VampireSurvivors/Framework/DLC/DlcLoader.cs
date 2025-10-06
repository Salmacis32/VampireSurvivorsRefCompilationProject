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

namespace VampireSurvivors.Framework.DLC
{
	public class DlcLoader // TypeDefIndex: 18345
	{
		// Fields
		private static Action<BundleManifestData> _onComplete; // 0x00
		private static DlcType? _dlcType; // 0x08
		private static int _initialProgress; // 0x10
		private static int _totalLocations; // 0x14
		private static int _completedLocations; // 0x18
		private static List<Sprite> _sprites; // 0x20
		private static BundleManifestData _manifest; // 0x28
		private static DlcLoadState _spritesState; // 0x30
		private static DlcLoadState _locationsState; // 0x34
		private static DlcLoadState _manifestState; // 0x38
	
		// Properties
		private static DlcType DlcType { get => default; } // 0x00000001867333A0-0x0000000186733400 
	
		// Constructors
		public DlcLoader() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public static void ResetLoader() {} // 0x0000000186733400-0x0000000186733630
		public static void LoadDlc(DlcType dlcType, Action<BundleManifestData> onComplete) {} // 0x0000000186733630-0x0000000186733AC0
		private static void LoadDlcComplete() {} // 0x0000000186733AC0-0x0000000186733C40
		private static void UpdateProgress() {} // 0x0000000186733C40-0x00000001867341A0
		private static bool IsTaskDone(DlcLoadState task) => default; // 0x00000001867341A0-0x00000001867341B0
		private static bool DidTaskError(DlcLoadState task) => default; // 0x00000001859A4560-0x00000001859A4570
		private static void LoadManifest(Action<BundleManifestData> onComplete) {} // 0x00000001867341B0-0x0000000186734710
		public static void LoadBundleManifestData(DlcType dlcType, Action<BundleManifestData> onComplete) {} // 0x0000000186734710-0x0000000186734BD0
		private static void LoadSpriteLocations(Action onComplete) {} // 0x0000000186734BD0-0x0000000186734FE0
		private static void IncrementAndCheckIfAllSpritesAreLoaded(Action onComplete) {} // 0x0000000186734FE0-0x0000000186735060
		private static void LoadSprites(IList<IResourceLocation> locations, Action onComplete) {} // 0x0000000186735060-0x00000001867355E0
		private static void WaitForAsyncLoad<T>(AsyncOperationHandle<T> operationHandle, Action<T> onComplete, Action<T> onError, string errorPrefix = "WaitForAsyncLoad" /* Metadata: 0x01978964 */) {}
	}
}
