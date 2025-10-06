/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Platforms;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Platforms.Saves
{
	public interface IPlatformSaveUtils : ILastErrorProvider // TypeDefIndex: 18214
	{
		// Properties
		bool IsReady { get; }
		bool ContinuePlayingWithoutSaving { get; set; }
	
		// Methods
		void InitAsync(string containerName, string containerDisplayName, StorageOperationComplete onComplete);
		StorageResult SetBlob(string blobName, byte[] data);
		void CommitAsync(StorageOperationComplete onComplete, CommitOptions options = CommitOptions.Default /* Metadata: 0x019788B9 */, bool createBackup = false /* Metadata: 0x019788BA */);
		void GetBlobsAsync(string blobName, StorageOperationCompleteWithData onComplete, bool skipCache = false /* Metadata: 0x019788BB */);
		void RequestNoFreeSpaceToSaveSystemDialog(Action onComplete, bool canContinueWithoutSaving = true /* Metadata: 0x019788BC */);
		void EraseAllAsync(StorageOperationComplete onComplete);
		void Close();
	}
}
