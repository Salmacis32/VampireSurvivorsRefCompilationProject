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
	public class LoadingManager // TypeDefIndex: 18363
	{
		// Properties
		public Dictionary<DlcType, string> MountedPaths { get; } // 0x0000000180B15C10-0x0000000180B15C20 
		public Dictionary<DlcType, BundleManifestData> LoadedDlc { get; } // 0x0000000180B15520-0x0000000180B15530 
	
		// Constructors
		public LoadingManager() {} // 0x000000018673BAB0-0x000000018673BC10
	
		// Methods
		public void LoadDlcs(Action callback) {} // 0x0000000186739DE0-0x000000018673A110
		public void MountDlc(DlcType dlcType, Action callback) {} // 0x000000018673A110-0x000000018673A360
		private void LogAllMountedPaths() {} // 0x000000018673A360-0x000000018673A680
		public void UnmountAllDlc(Action callback) {} // 0x000000018673A680-0x000000018673A8C0
		public void UnmountDlc(DlcType dlcType, Action callback) {} // 0x000000018673A8C0-0x000000018673AB10
		private void LoadDlc(int index, List<DlcType> dlcsToLoad, Action callback) {} // 0x000000018673AB10-0x000000018673AE60
		private void LoadIncludedDlc(int index, List<DlcType> dlcsToLoad, Action callback) {} // 0x000000018673AE60-0x000000018673B210
		private void LoadManifestDirect(DlcType dlcType, string path, Action<bool> callback) {} // 0x000000018673B210-0x000000018673B3D0
		public void ValidateDlcVersions(Action callback) {} // 0x000000018673B3D0-0x000000018673B550
		private void ValidateVersion(int index, DlcType[] dlcs, Action callback) {} // 0x000000018673B550-0x000000018673BAB0
	}
}
