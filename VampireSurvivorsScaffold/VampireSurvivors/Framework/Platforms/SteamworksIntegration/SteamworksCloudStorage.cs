/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Platforms;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.SteamworksIntegration
{
	public class SteamworksCloudStorage : IPlatformSaveUtils // TypeDefIndex: 18206
	{
		// Fields
		private bool m_IsReady; // 0x11
		private ErroInfo m_LastError; // 0x18
		private byte[] m_LastBlobData; // 0x30
		private string m_LastBlobFilename; // 0x38
	
		// Properties
		public bool IsReady { get => default; } // 0x000000018195ABE0-0x000000018195ABF0 
		public bool ContinuePlayingWithoutSaving { get; set; } // 0x0000000180B15AC0-0x0000000180B15AD0 0x000000018195A980-0x000000018195A990
		public ErroInfo LastError { get => default; } // 0x00000001829ECFE0-0x00000001829ED000 
	
		// Constructors
		public SteamworksCloudStorage() {} // 0x00000001866FCB80-0x00000001866FCC40
	
		// Methods
		private void FailWithLastError(StorageResult result, string msg, StorageOperationComplete callback) {} // 0x00000001866FC180-0x00000001866FC2E0
		public void Close() {} // 0x00000001866FC2E0-0x00000001866FC2F0
		public void EraseAllAsync(StorageOperationComplete onComplete) {} // 0x00000001866FC2F0-0x00000001866FC590
		public void GetBlobsAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x01978883 */) {} // 0x00000001866FC590-0x00000001866FC7D0
		public void RequestNoFreeSpaceToSaveSystemDialog(Action onComplete, bool canContinueWithoutSaving = true /* Metadata: 0x01978884 */) {} // 0x0000000184F92570-0x0000000184F92590
		public void InitAsync(string containerName, string containerDisplayName, StorageOperationComplete onComplete) {} // 0x00000001866FC7D0-0x00000001866FC800
		public StorageResult SetBlob(string blobName, byte[] data) => default; // 0x00000001866FC800-0x00000001866FC8D0
		public void CommitAsync(StorageOperationComplete onComplete, CommitOptions options = CommitOptions.Default /* Metadata: 0x01978885 */, bool createBackup = false /* Metadata: 0x01978886 */) {} // 0x00000001866FC8D0-0x00000001866FCB80
	}
}
