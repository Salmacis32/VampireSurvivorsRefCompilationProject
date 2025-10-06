/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public class PhaserSaveDataUtils // TypeDefIndex: 18182
	{
		// Fields
		private const string ElectronDataFolderName = "Vampire_Survivors"; // Metadata: 0x019787A8
		private const string SaveDataFolderName = "Vampire_Survivors_Data"; // Metadata: 0x019787BA
		private const string SavesFolderName = "saves"; // Metadata: 0x019787D1
		private const string BackupsFolderName = "backups"; // Metadata: 0x019787D7
		private const string SaveFileName = "SaveData.sav"; // Metadata: 0x019787DF
		private const string SaveBackupFileName = "SaveDataBackup.sav"; // Metadata: 0x019787EC
		private const string LastRunBackupFileName = "LastRunBackup.sav"; // Metadata: 0x019787FF
		private const string LastRunBackupBakFileName = "LastRunBackup.bak.sav"; // Metadata: 0x01978811
		private const string DeletedSaveFileName = "deleted_SaveData"; // Metadata: 0x01978827
		private const bool IPCRENDERER = true; // Metadata: 0x01978838
		private static PlayerOptions _playerOptions; // 0x00
	
		// Constructors
		public PhaserSaveDataUtils() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions) {} // 0x00000001866F38B0-0x00000001866F3950
		private static bool UsesLocalSaves() => default; // 0x0000000181958370-0x0000000181958380
		private static bool CheckExists(string[] segments) => default; // 0x00000001866F3950-0x00000001866F3A30
		private static string BuildPath(string[] segments) => default; // 0x00000001866F3A30-0x00000001866F3AF0
		private static string InitPath(string[] segments) => default; // 0x00000001866F3AF0-0x00000001866F3BD0
		private static string GetSaveDataPath() => default; // 0x00000001866F3BD0-0x00000001866F3C50
		private static string GetSaveDataPathWithSave() => default; // 0x00000001866F3C50-0x00000001866F3CF0
		private static string InitSaveDataPath() => default; // 0x00000001866F3CF0-0x00000001866F3E30
		private static bool SaveDataHasSave() => default; // 0x00000001866F3E30-0x00000001866F3ED0
		private static bool SaveDataPathExists() => default; // 0x00000001866F3ED0-0x00000001866F3F50
		private static string GetElectronDataPath() => default; // 0x00000001866F3F50-0x00000001866F3FD0
		private static string GetElectronDataSavesPath() => default; // 0x00000001866F3FD0-0x00000001866F4070
		private static bool ElectronDataHasSave() => default; // 0x00000001866F4070-0x00000001866F4140
		private static string GetTempDataPath(string tempFolderName) => default; // 0x00000001866F4140-0x00000001866F41B0
		private static string GetTempDataPathWithSavesFolder(string tempFolderName) => default; // 0x00000001866F41B0-0x00000001866F4250
		private static string GetBackupsPath() => default; // 0x00000001866F4250-0x00000001866F42C0
		private static bool LastRunBackupExists() => default; // 0x0000000180B15290-0x0000000180B152A0
		private static string GetLastRunBackupPath() => default; // 0x00000001866F42C0-0x00000001866F4300
		private static string GetLastRunBackupBakPath() => default; // 0x00000001866F4300-0x00000001866F4340
		private static string GetBaseDataPath() => default; // 0x00000001866F4340-0x00000001866F4350
		private static string[] GetTempFolders() => default; // 0x00000001866F4350-0x00000001866F4390
		public static object[] GetLocalBackupsList() => default; // 0x00000001866F4390-0x00000001866F43D0
		public static void RestoreLocalBackup(string filename) {} // 0x00000001866F43D0-0x00000001866F45C0
		public static bool HasBackup() => default; // 0x0000000182D70A20-0x0000000182D70A30
		public static void RestoreLastRunBackup(bool bypassReload = false /* Metadata: 0x019787A7 */) {} // 0x00000001866F45C0-0x00000001866F4650
		private static bool HasNewSaveFiles() => default; // 0x00000001866F4650-0x00000001866F4660
		public static PlayerOptionsData LoadSaveFiles() => default; // 0x00000001866F4660-0x00000001866F4750
		private static bool MakeNewSaveFiles() => default; // 0x0000000180B15290-0x0000000180B152A0
		private static string LoadNewSaves() => default; // 0x00000001866F4750-0x00000001866F47D0
	}
}
