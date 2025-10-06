/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Graphics;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	[UsedImplicitly]
	public class ManifestLoader : IInitializable, IDisposable // TypeDefIndex: 18346
	{
		// Fields
		[Inject]
		private DataManager _dataManager; // 0x10
		[Inject]
		private SpriteManager _spriteManager; // 0x18
		[Inject]
		private AdventureManager _adventureManager; // 0x20
		private static ManifestLoader _sInstance; // 0x00
	
		// Constructors
		public ManifestLoader() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x00000001867360B0-0x0000000186736150
		public void Dispose() {} // 0x0000000186736150-0x00000001867361F0
		public static AssetBundle LoadAssetBundleFromPath(string bundlePath) => default; // 0x00000001867361F0-0x0000000186736280
		public static void LoadManifest(BundleManifestData bundleManifestData, DlcType dlcType, Action<BundleManifestData> onComplete) {} // 0x0000000186736280-0x0000000186736590
		private static void ApplyBundleCore(DlcType dlcType, BundleManifestData manifest, Action<BundleManifestData> onComplete) {} // 0x0000000186736590-0x00000001867367F0
		public static void DoRuntimeReload() {} // 0x00000001867367F0-0x0000000186736BC0
	}
}
