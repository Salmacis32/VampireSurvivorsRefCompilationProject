/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Platforms.Saves;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms
{
	public class DummyStorage : IPlatformSaveUtils, IPlatformSaveBackup // TypeDefIndex: 18184
	{
		// Properties
		public ErroInfo LastError { get; } // 0x00000001830E71E0-0x00000001830E7200 
		public bool IsReady { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool ContinuePlayingWithoutSaving { get; set; } // 0x000000018195ADB0-0x000000018195ADC0 0x0000000182622760-0x0000000182622770
	
		// Constructors
		public DummyStorage() {} // 0x0000000183887950-0x0000000183887960
	
		// Methods
		public void InitAsync(string containerName, string containerDisplayName, StorageOperationComplete onComplete) {} // 0x00000001866F4C70-0x00000001866F4C90
		public StorageResult SetBlob(string blobName, byte[] data) => default; // 0x0000000180B15D70-0x0000000180B15D80
		public void CommitAsync(StorageOperationComplete onComplete, CommitOptions options = CommitOptions.Default /* Metadata: 0x0197883A */, bool createBackup = false /* Metadata: 0x0197883B */) {} // 0x00000001866F4C90-0x00000001866F4CB0
		public void GetBlobsAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x0197883C */) {} // 0x00000001866F4CB0-0x00000001866F4CD0
		public void RequestNoFreeSpaceToSaveSystemDialog(Action onComplete, bool canContinueWithoutSaving = true /* Metadata: 0x0197883D */) {} // 0x0000000184F92570-0x0000000184F92590
		public void EraseAllAsync(StorageOperationComplete onComplete) {} // 0x00000001866F4C90-0x00000001866F4CB0
		public void Close() {} // 0x0000000180B15170-0x0000000180B15180
		public void TryRestoreBlobAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x0197883E */) {} // 0x00000001866F4CD0-0x00000001866F4CF0
		public bool BackupExists(string blobName) => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}
