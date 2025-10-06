/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Platforms.Saves;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Saves
{
	public static class Migrator // TypeDefIndex: 18169
	{
		// Nested types
		private class MigratorLoadingState // TypeDefIndex: 18161
		{
			// Fields
			public bool loadedOldSave; // 0x10
			public bool showedDialog; // 0x11
	
			// Constructors
			public MigratorLoadingState() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Methods
		[IteratorStateMachine(typeof(_AttemptMigration_d__1))]
		public static IEnumerator AttemptMigration(PlayerOptions playerOptions) => default; // 0x00000001866E0FC0-0x00000001866E1060
		[IteratorStateMachine(typeof(_TryLoadingFromLocations_d__2))]
		private static IEnumerator TryLoadingFromLocations(List<string> directoriesToTry, byte[] currentData, PlayerOptions playerOptions, MigratorLoadingState state, string filename = "SaveData.sav" /* Metadata: 0x0197875B */) => default; // 0x00000001866E1060-0x00000001866E1270
		private static byte[] SerializeCurrentData(PlayerOptionsData currentData) => default; // 0x00000001866E1270-0x00000001866E1300
		[IteratorStateMachine(typeof(_TryLoadFromPath_d__4))]
		private static IEnumerator TryLoadFromPath(string filePath, byte[] currentData, PlayerOptions playerOptions, Action<StorageResult> onComplete) => default; // 0x00000001866E1300-0x00000001866E14C0
		[IteratorStateMachine(typeof(_TryLoadFromBytes_d__5))]
		private static IEnumerator TryLoadFromBytes(byte[] data, byte[] currentData, PlayerOptions playerOptions, Action<StorageResult> onComplete) => default; // 0x00000001866E14C0-0x00000001866E1680
		private static bool DoDirectLoad(byte[] data, PlayerOptions playerOptions) => default; // 0x00000001866E1680-0x00000001866E1760
		private static string GetPlatformSpecificParentPath() => default; // 0x00000001866E1760-0x00000001866E1980
	}
}
