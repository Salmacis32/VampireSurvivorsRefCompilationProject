/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Loading
{
	public class GameplayLoader // TypeDefIndex: 18296
	{
		// Fields
		public const string CACHE_GROUP_NAME = "Gameplay"; // Metadata: 0x0197891A
		private GameManager _gameManager; // 0x10
		private DataManager _dataManager; // 0x18
		private PlayerOptions _playerOptions; // 0x20
		private TilesetFactory _tilesetFactory; // 0x28
	
		// Constructors
		public GameplayLoader() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		[Inject]
		private void Construct(GameManager gameManager, DataManager dataManager, PlayerOptions playerOptions, TilesetFactory tilesetFactory) {} // 0x00000001827C42C0-0x00000001827C4410
		private Dictionary<StageType, StageData> GetAllUsedStageData() => default; // 0x0000000186726D30-0x00000001867270D0
		public void Preload(Action onComplete) {} // 0x00000001867270D0-0x00000001867276A0
		private void PreloadTilesets(AsyncLoader loader, StageType stageType) {} // 0x00000001867276A0-0x00000001867277D0
		private void PreloadCharacters(AsyncLoader loader) {} // 0x00000001867277D0-0x0000000186728020
		private void PreloadEnemies(AsyncLoader loader, StageType stageType) {} // 0x0000000186728020-0x00000001867281D0
		public void Load(Action onComplete) {} // 0x00000001867281D0-0x0000000186728820
		private async void WaitAndRunCallback(Action callback) {} // 0x0000000186728820-0x00000001867289E0
		private void LoadTextures(AsyncLoader loader, VampireSurvivors.Data.Stage.PreloadData preloadData, DlcType? stageDlcType) {} // 0x00000001867289E0-0x0000000186728CC0
		private void LoadBgm(AsyncLoader loader, VampireSurvivors.Data.Stage.PreloadData preloadData) {} // 0x0000000186728CC0-0x0000000186728FB0
		private void LoadCharacters(AsyncLoader loader, List<VampireSurvivors.Data.CharacterType> chars) {} // 0x0000000186728FB0-0x0000000186729480
		private void LoadVideos(AsyncLoader loader, VampireSurvivors.Data.Stage.PreloadData preloadData, DlcType? stageDlcType) {} // 0x0000000186729480-0x0000000186729760
		private List<VampireSurvivors.Data.CharacterType> GetTilesetCharacters(StageData stageData) => default; // 0x0000000186729760-0x0000000186729B40
		public static void LoadCoffinCharactersOnline() {} // 0x0000000186729B40-0x000000018672A050
		public void Release() {} // 0x000000018672A050-0x000000018672A110
	}
}
