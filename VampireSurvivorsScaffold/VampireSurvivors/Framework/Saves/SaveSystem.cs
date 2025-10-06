/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms.Saves;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public static class SaveSystem // TypeDefIndex: 18180
	{
		// Properties
		private static IPlatformSaveUtils SaveUtil { get; } // 0x00000001866EF930-0x00000001866EF9A0 
	
		// Constructors
		static SaveSystem() {} // 0x00000001866EF820-0x00000001866EF930
	
		// Methods
		public static void Save(PlayerOptionsData data, bool commitImmediately = true /* Metadata: 0x0197876B */, bool createBackup = false /* Metadata: 0x0197876C */, CommitOptions options = CommitOptions.Default /* Metadata: 0x0197876D */) {} // 0x00000001866EF9A0-0x00000001866EFCE0
		public static void LoadAsync(PlayerOptions playerOptions, Action<StorageResult> onComplete) {} // 0x00000001866EFCE0-0x00000001866EFF80
		private static void TryRestoreDataAsync(Action<StorageResult, PlayerOptionsData> onComplete) {} // 0x00000001866EFF80-0x00000001866F0200
		public static void DeleteSave() {} // 0x00000001866F0200-0x00000001866F0290
		public static bool BackupExists() => default; // 0x00000001866F0290-0x00000001866F03B0
		public static void TryRestoreBackup(PlayerOptions playerOptions, Action<bool> onComplete) {} // 0x00000001866F03B0-0x00000001866F0610
		public static void HandleConflictResolution(byte[] dataA, byte[] dataB, Action<byte[]> onComplete) {} // 0x00000001866F0610-0x00000001866F0AE0
	}
}
