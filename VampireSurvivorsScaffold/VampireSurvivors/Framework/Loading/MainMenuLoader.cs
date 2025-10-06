/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public class MainMenuLoader : IInitializable // TypeDefIndex: 18302
	{
		// Fields
		private static DataManager _dataManager; // 0x00
		private static PlayerOptions _playerOptions; // 0x08
		public const string CACHE_GROUP_NAME = "MainMenu"; // Metadata: 0x01978923
	
		// Constructors
		public MainMenuLoader() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, PlayerOptions playerOptions) {} // 0x000000018672B090-0x000000018672B1B0
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public static void Load(Action onComplete) {} // 0x000000018672B1B0-0x000000018672B580
		private static void LoadAlbumArt(AsyncLoader loader) {} // 0x000000018672B580-0x000000018672B870
		public static void Release(Action onComplete) {} // 0x000000018672B870-0x000000018672B910
	}
}
