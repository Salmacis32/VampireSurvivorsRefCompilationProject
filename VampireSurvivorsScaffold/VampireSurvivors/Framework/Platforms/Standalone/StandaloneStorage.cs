/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Platforms;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.Standalone
{
	public class StandaloneStorage : IPlatformSaveUtils, IPlatformSaveBackup // TypeDefIndex: 18209
	{
		// Fields
		private const string SAV_EXTENSION = ".sav"; // Metadata: 0x0197888D
		private const string BAK_EXTENSION = ".bak.sav"; // Metadata: 0x01978892
		private Dictionary<string, Blob> _mData; // 0x10
		private string _targetPath; // 0x18
		private ErroInfo _mLastError; // 0x20
		private bool _mInitialized; // 0x38
		private const int HR_ERROR_HANDLE_DISK_FULL = -2147024857; // Metadata: 0x0197889B
		private const int HR_ERROR_DISK_FULL = -2147024784; // Metadata: 0x019788A0
		private const int HR_ERROR_SHARING_VIOLATION = -2147024864; // Metadata: 0x019788A5
	
		// Properties
		public ErroInfo LastError { get => default; } // 0x00000001866FD8D0-0x00000001866FD8F0 
		public bool IsReady { get => default; } // 0x000000018274EAA0-0x000000018274EAB0 
		public bool ContinuePlayingWithoutSaving { get; set; } // 0x000000018289C540-0x000000018289C550 0x0000000180B1D590-0x0000000180B1D5A0
	
		// Nested types
		public class Blob // TypeDefIndex: 18208
		{
			// Fields
			private bool _mDirtyFlag; // 0x10
			private byte[] _mData; // 0x18
	
			// Properties
			public bool IsDirty { get => default; } // 0x0000000180B15AC0-0x0000000180B15AD0 
			public bool IsEmpty { get => default; } // 0x000000018461D480-0x000000018461D490 
			public byte[] Data { get => default; } // 0x0000000180B15520-0x0000000180B15530 
	
			// Constructors
			public Blob() {} // Dummy constructor
			public Blob(byte[] data, bool dirtyFlag = true /* Metadata: 0x019788AA */) {} // 0x00000001866FF2F0-0x00000001866FF350
	
			// Methods
			public void SetData(byte[] data) {} // 0x00000001866FF290-0x00000001866FF2F0
			public void ClearDirty() {} // 0x00000001827813C0-0x00000001827813D0
		}
	
		// Constructors
		public StandaloneStorage() {} // 0x00000001866FF1D0-0x00000001866FF290
	
		// Methods
		public void EraseAllAsync(StorageOperationComplete onComplete) {} // 0x00000001866FD8F0-0x00000001866FDCD0
		private string GetBackupBlobName(string orgBlobName) => default; // 0x00000001866FDCD0-0x00000001866FDD40
		public void CommitAsync(StorageOperationComplete onComplete, CommitOptions options, bool createBackup = false /* Metadata: 0x01978888 */) {} // 0x00000001866FDD40-0x00000001866FE3B0
		private string GetBlobPath(string blobName) => default; // 0x00000001866FE3B0-0x00000001866FE420
		public void TryRestoreBlobAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x01978889 */) {} // 0x00000001866FE420-0x00000001866FE610
		public bool BackupExists(string blobName) => default; // 0x00000001866FE610-0x00000001866FE780
		public void GetBlobsAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x0197888A */) {} // 0x00000001866FE780-0x00000001866FE810
		private void GetBlobsAsyncDirect(string blobNameWithExtension, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x0197888B */) {} // 0x00000001866FE810-0x00000001866FEC30
		public void RequestNoFreeSpaceToSaveSystemDialog(Action onComplete, bool canContinueWithoutSaving = true /* Metadata: 0x0197888C */) {} // 0x0000000184F92570-0x0000000184F92590
		public StorageResult SetBlob(string containerName, byte[] data) => default; // 0x00000001866FEC30-0x00000001866FEF70
		protected virtual string GetTargetSavePath(string containerName) => default; // 0x00000001866FEF70-0x00000001866FEF80
		public static string GetTargetPath(string containerName) => default; // 0x00000001866FEF80-0x00000001866FEFF0
		public void InitAsync(string containerName, string containerDisplayName, StorageOperationComplete onComplete) {} // 0x00000001866FEFF0-0x00000001866FF120
		private StorageResult ToStorageResult(Exception ex) => default; // 0x00000001866FF120-0x00000001866FF1D0
		public void Close() {} // 0x0000000184A2CBD0-0x0000000184A2CBE0
	}
}
