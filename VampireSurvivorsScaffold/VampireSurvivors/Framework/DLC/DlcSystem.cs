/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	public static class DlcSystem // TypeDefIndex: 18337
	{
		// Fields
		private static DlcCatalog _dlcCatalog; // 0x00
		private static bool _initialised; // 0x08
		private static LicenseManager _licenseManager; // 0x10
		private static LoadingManager _loadingManager; // 0x18
		private static UpdateManager _updateManager; // 0x20
		private static DlcUtils _utils; // 0x28
		private const string DlcDownloadPopupId = "download-dlc"; // Metadata: 0x0197892E
		private const string DlcErrorPopupId = "error-dlc"; // Metadata: 0x0197893B
		public static List<DlcType> OnlineAvaliableDlcTypes; // 0x30
		public const string PERSISTENT_TAG = "persistent"; // Metadata: 0x01978945
		public const string DYNAMIC_TAG = "dynamic"; // Metadata: 0x01978950
		public const string LOCAL_GROUP = "vs_local"; // Metadata: 0x01978958
	
		// Properties
		public static DlcCatalog DlcCatalog { get; } // 0x00000001867303E0-0x0000000186730440 
		public static DlcUtils Utils { get; } // 0x0000000186730440-0x00000001867304A0 
		public static List<DlcType> OwnedDlc { get; } // 0x00000001867304A0-0x0000000186730580 
		public static List<DlcType> IncludedDlc { get; } // 0x0000000186730580-0x0000000186730660 
		public static Dictionary<DlcType, BundleManifestData> LoadedDlc { get; } // 0x0000000186730660-0x0000000186730740 
		public static Dictionary<DlcType, string> MountedPaths { get; } // 0x0000000186730740-0x0000000186730820 
	
		// Constructors
		static DlcSystem() {} // 0x0000000186732EE0-0x0000000186732FC0
	
		// Methods
		public static void Init(DlcCatalog catalog) {} // 0x0000000186730820-0x0000000186730E20
		public static void LicenseCheckDlc(Action callback) {} // 0x0000000186730E20-0x0000000186731120
		public static void UpdateDlc(Action callback) {} // 0x0000000186731120-0x0000000186731200
		public static void LoadDlc(Action callback) {} // 0x0000000186731200-0x0000000186731380
		public static void MountDlc(DlcType dlcType, Action callback) {} // 0x0000000186731380-0x0000000186731460
		public static bool IsFreeDlcActivated(DlcType dlcType) => default; // 0x0000000186731460-0x00000001867314D0
		public static void SetFreeDlcActivated(DlcType dlcType, bool activated = true /* Metadata: 0x0197892C */) {} // 0x00000001867314D0-0x00000001867316D0
		public static List<DlcType> GetMissingDlc() => default; // 0x00000001867316D0-0x0000000186731B00
		public static List<DlcType> GetDlcTypesToLoad() => default; // 0x0000000186731B00-0x0000000186731DC0
		public static void ReleaseGameplayDlc() {} // 0x0000000186731DC0-0x0000000186731E10
		public static void Reset(Action callback) {} // 0x00000001859AD060-0x00000001859AD090
		public static void ShowDlcDownload(DlcType dlcType) {} // 0x0000000186731E10-0x0000000186732050
		public static void UpdateDlcDownloadProgressText(DlcType dlcType, string progressPercentage) {} // 0x0000000186732050-0x0000000186732550
		public static void HideDlcDownload() {} // 0x0000000186732550-0x0000000186732590
		public static void ShowDlcDownloadError(DlcType dlcType, Action onRetry, Action onContinue, string info = "" /* Metadata: 0x0197892D */) {} // 0x0000000186732590-0x0000000186732970
		public static void PrepareBgmLoad(BgmType bgmType) {} // 0x0000000186732970-0x0000000186732E00
		public static void OpenDLCLink() {} // 0x0000000186732E00-0x0000000186732E60
		public static void Log(string message) {} // 0x0000000186732E60-0x0000000186732EE0
	}
}
