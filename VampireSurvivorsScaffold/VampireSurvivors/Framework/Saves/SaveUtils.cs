/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public static class SaveUtils // TypeDefIndex: 18181
	{
		// Fields
		private static Dictionary<string, MethodInfo> _cachedParsers; // 0x00
		private static Dictionary<string, MethodInfo> _cachedSerializers; // 0x08
		public const string ADVENTURE_PROPERTY_PREFIX = "ADV_"; // Metadata: 0x0197876E
		public const string SaveDataFolderName = "Vampire_Survivors_Standalone"; // Metadata: 0x01978773
		public static Func<string> SaveFileNameSuffix; // 0x10
		public const string SaveDataFolderDisplayName = "Vampire Survivors Data"; // Metadata: 0x01978790
	
		// Properties
		public static Dictionary<string, MethodInfo> Serializers { get; } // 0x00000001866F1AD0-0x00000001866F1B30 
	
		// Constructors
		static SaveUtils() {} // 0x00000001866F3730-0x00000001866F38B0
	
		// Methods
		public static string GetSaveFileName() => default; // 0x00000001866F1B30-0x00000001866F1BE0
		public static MethodInfo GetParser(string property) => default; // 0x00000001866F1BE0-0x00000001866F1E70
		public static MethodInfo GetSerializer(string property) => default; // 0x00000001866F1E70-0x00000001866F20F0
		public static void PreCacheParsersAndSerializers() {} // 0x00000001866F20F0-0x00000001866F21C0
		private static bool CheckExists(string[] segments) => default; // 0x00000001866F21C0-0x00000001866F22B0
		private static string BuildPath(string[] segments) => default; // 0x00000001866F22B0-0x00000001866F2380
		private static string InitPath(string[] segments) => default; // 0x00000001866F2380-0x00000001866F2470
		public static string GetSaveFolderPath(string basePath) => default; // 0x00000001866F2470-0x00000001866F2530
		public static string GetSaveFilePath(string basePath) => default; // 0x00000001866F2530-0x00000001866F2600
		public static bool SaveExists(string basePath) => default; // 0x00000001866F2600-0x00000001866F2780
		public static void InitSavePath(string basePath) {} // 0x00000001866F2780-0x00000001866F2900
		public static bool ChecksumIsValid(string rawData, string checksum) => default; // 0x00000001866F2900-0x00000001866F2AA0
		public static string GenerateChecksum(string data) => default; // 0x00000001866F2AA0-0x00000001866F2B10
		public static string UpdateChecksum(string rawData) => default; // 0x00000001866F2B10-0x00000001866F2C20
		private static string ComputeHash(string secretKey, string data) => default; // 0x00000001866F2C20-0x00000001866F2F90
		private static string ByteArrayToString(byte[] ba) => default; // 0x00000001866F2F90-0x00000001866F3100
		public static byte[] JsonToBytes(string data) => default; // 0x00000001866F3100-0x00000001866F3140
		public static string JsonFromBytes(byte[] data) => default; // 0x00000001866F3140-0x00000001866F3180
		public static bool AreIdentical(PlayerOptionsData saveA, PlayerOptionsData saveB) => default; // 0x00000001866F3180-0x00000001866F31F0
		public static PlayerOptionsData TryParseData(byte[] data) => default; // 0x00000001866F31F0-0x00000001866F3360
		public static SaveSummary GetSaveSummary(PlayerOptionsData pod, byte[] data) => default; // 0x00000001866F3360-0x00000001866F3520
		public static SaveSummary GetSaveSummary(PlayerOptionsData pod) => default; // 0x00000001866F3520-0x00000001866F3620
		public static byte[] GetSerializedPlayerData(PlayerOptionsData data) => default; // 0x00000001866F3620-0x00000001866F36B0
		public static string GetSerializedPlayerDataAsString(PlayerOptionsData data) => default; // 0x00000001866F36B0-0x00000001866F3730
	}
}
