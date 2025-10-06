/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Objects.Items;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class TilingTileset : GameMonoBehaviour // TypeDefIndex: 15167
	{
		// Fields
		private TilesetFactory _tilesetFactory; // 0x28
		private GameManager _gameManager; // 0x30
		private PlayerOptions _playerOptions; // 0x38
		private StageType _stageType; // 0x40
		private Stage _stage; // 0x48
		private readonly List<SuperMap> _maps; // 0x50
		private readonly List<GameObject> _supportMaps; // 0x58
		private readonly List<PhaserTilemap> _phaserTilemaps; // 0x60
		private readonly Dictionary<SuperMap, List<SuperTileLayer>> _cachedMapSuperTilesLayers; // 0x68
		private readonly Dictionary<SuperMap, List<PhaserTilemap>> _cachedCollisionTilemaps; // 0x70
		private readonly Dictionary<SuperMap, Tilemap> _cachedSpawningTilemap; // 0x78
		private readonly Dictionary<SuperMap, Tilemap> _cachedFloorLayers; // 0x80
		private List<Bounds> _bounds; // 0x88
		private Bounds _currentBounds; // 0x90
		private Vector3 _previousTilingCenter; // 0xA8
		private bool _hasMoongates; // 0xB4
		private bool _hasTeleporters; // 0xB5
		private readonly Dictionary<string, MoongateData> _moongates; // 0xB8
		private readonly Dictionary<string, TeleporterData> _teleporters; // 0xC0
		private float _sizeX; // 0xC8
		private float _sizeY; // 0xCC
		private AdventureManager _adventureManager; // 0xD0
		public bool _inverted; // 0xE0
		public bool _visuallyInverted; // 0xE1
		public List<SuperObject> SavedScripts; // 0xE8
		private float offset; // 0xF8
		private Bounds _previousFirstMap; // 0xFC
	
		// Properties
		public Vector2 StartPosition { get; private set; } // 0x0000000183726240-0x0000000183726260 0x0000000182A45A80-0x0000000182A45A90
		public SuperMap DefaultMap { get => default; } // 0x0000000186A608A0-0x0000000186A60920 
		public GameObject DefaultSupportMap { get => default; } // 0x0000000186A60920-0x0000000186A60A30 
		public float SizeX { get => default; } // 0x0000000183725DE0-0x0000000183725DF0 
		public float SizeY { get => default; } // 0x0000000183725E00-0x0000000183725E10 
		public Vector2 DefaultMapPosition { get => default; } // 0x0000000186A60A30-0x0000000186A60B10 
		public Bounds CurrentBounds { get => default; } // 0x0000000186A60B10-0x0000000186A60B30 
		public List<SuperMap> Tiles { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public List<PickupTeleporter> ListOfTeleporters { get; private set; } // 0x00000001819716C0-0x00000001819716D0 0x0000000180B3E860-0x0000000180B3E8C0
	
		// Nested types
		private struct MoongateData // TypeDefIndex: 15161
		{
			// Fields
			public Vector2 A; // 0x00
			public bool HasA; // 0x08
			public Vector2 B; // 0x0C
			public bool HasB; // 0x14
		}
	
		private struct TeleporterData // TypeDefIndex: 15162
		{
			// Fields
			public string TeleportKey; // 0x00
			public Vector2 A; // 0x08
			public bool HasA; // 0x10
			public Vector2 B; // 0x14
			public bool HasB; // 0x1C
			public string DestinationA; // 0x20
			public string DestinationB; // 0x28
		}
	
		// Constructors
		public TilingTileset() {} // 0x0000000186A71B30-0x0000000186A72360
	
		// Methods
		public Bounds GetTotalBounds() => default; // 0x0000000186A60B30-0x0000000186A60EE0
		[Inject]
		private void Construct(TilesetFactory tilesetFactory, GameManager gameManager, PlayerOptions playerOptions, AdventureManager adventureManager) {} // 0x0000000186A60EE0-0x0000000186A61040
		private void OnDrawGizmosSelected() {} // 0x0000000186A61040-0x0000000186A612D0
		protected override void OnDestroy() {} // 0x0000000186A612D0-0x0000000186A613C0
		public void Init(StageType stageType, Stage stage) {} // 0x0000000186A613C0-0x0000000186A61800
		public void InitPostLoad() {} // 0x0000000186A61800-0x0000000186A61890
		public void InternalUpdate() {} // 0x0000000186A61890-0x0000000186A61C20
		public List<Vector2> GetSpecialLocations(string scriptName) => default; // 0x0000000186A61C20-0x0000000186A61E90
		public List<SuperObject> GetScriptsFromName(string scriptName, string layerName = "Scripts" /* Metadata: 0x01977427 */) => default; // 0x0000000186A61E90-0x0000000186A620A0
		public List<Rectangle> GetScriptRectangularLocations(string objectName, bool autoScaleAndOffset = false /* Metadata: 0x0197742F */) => default; // 0x0000000186A620A0-0x0000000186A62530
		public Tilemap GetTilemapLayer(string layerName) => default; // 0x0000000186A62530-0x0000000186A62650
		public SuperTileLayer GetSuperTileLayer(SuperMap map, string layerName) => default; // 0x0000000186A62650-0x0000000186A62840
		public SuperTile GetSpawningLayerTile(float posX, float posY) => default; // 0x0000000186A62840-0x0000000186A62BC0
		public List<Tilemap> GetAllLayers(List<string> excludeLayers = null) => default; // 0x0000000186A62BC0-0x0000000186A62ED0
		public void SetAllLayersAlpha(float alpha) {} // 0x0000000186A62ED0-0x0000000186A631A0
		public void FadeAllLayers(float alpha, float durationMillis, Action onComplete = null) {} // 0x0000000186A631A0-0x0000000186A63640
		public void TintAllLayers(Color tint, float durationMillis, Action onComplete = null) {} // 0x0000000186A63640-0x0000000186A63BD0
		public bool IsPointWithinCollisionLayer(Vector2 spawnPoint) => default; // 0x0000000186A63BD0-0x0000000186A63CF0
		public bool IsPointWithinCollisionLayerWrapped(Vector2 spawnPoint) => default; // 0x0000000186A63CF0-0x0000000186A63EC0
		public bool HasEmptyFloorTile(Vector2 point) => default; // 0x0000000186A63EC0-0x0000000186A642A0
		public TileBase GetTileAtPosition(Vector2 point) => default; // 0x0000000186A642A0-0x0000000186A64680
		public PickupMerchant SpawnMerchant() => default; // 0x0000000186A64680-0x0000000186A649E0
		public void pianificami() {} // 0x0000000180B15170-0x0000000180B15180
		public void spianami() {} // 0x0000000186A649E0-0x0000000186A64D30
		public List<PhaserTilemap> GetPhaserTilemaps() => default; // 0x0000000180B15740-0x0000000180B15750
		public void SetTilemapCollisionsEnabled(bool isEnabled) {} // 0x0000000186A64D30-0x0000000186A64F50
		private void UpdateInversionBool() {} // 0x0000000186A64F50-0x0000000186A65040
		private void HandleInversion(SuperMap map, StageType type) {} // 0x0000000186A65040-0x0000000186A65520
		private void HandleNonInversionTint(List<SuperTileLayer> layers, StageData data) {} // 0x0000000186A65520-0x0000000186A65830
		private void HandleInversionTint(List<SuperTileLayer> layers, StageData data) {} // 0x0000000186A65830-0x0000000186A65B50
		private void GenerateMaps() {} // 0x0000000186A65B50-0x0000000186A66DF0
		private static Vector2 GetPosByIndex(int index, SuperMap map) => default; // 0x0000000186A66DF0-0x0000000186A66EC0
		public List<VampireSurvivors.Data.CharacterType> GetCharactersUsed(SuperMap map) => default; // 0x0000000186A66EC0-0x0000000186A67810
		public List<Tuple<SuperObject, SuperCustomProperties>> GetAllMerchants() => default; // 0x0000000186A67810-0x0000000186A67EC0
		private void HandleCustomScriptProperties(SuperMap map) {} // 0x0000000186A67EC0-0x0000000186A68880
		private SuperObjectLayer GetObjectLayer(SuperMap map, string layerName) => default; // 0x0000000186A68880-0x0000000186A689D0
		private void SetPlayerStartFromSuperObject(SuperObject superObject) {} // 0x0000000186A689D0-0x0000000186A68AC0
		private void SpawnWeaponAt(SuperObject superObject) {} // 0x0000000186A68AC0-0x0000000186A68F70
		private void SpawnItemAt(SuperObject superObject) {} // 0x0000000186A68F70-0x0000000186A69570
		private void SpawnRelicAt(SuperObject superObject) {} // 0x0000000186A69570-0x0000000186A69890
		private void SpawnYellowAt(SuperObject superObject) {} // 0x0000000186A69890-0x0000000186A69C20
		private void SpawnArcanaChestAt(SuperObject superObject) {} // 0x0000000186A69C20-0x0000000186A6A3B0
		private void SpawnCoffin(SuperObject superObject) {} // 0x0000000186A6A3B0-0x0000000186A6A910
		private void TrySpawnSpecialCoffin(SuperObject superObject) {} // 0x0000000186A6A910-0x0000000186A6AD00
		private void GetMoongateData(SuperObject superObject) {} // 0x0000000186A6AD00-0x0000000186A6B1A0
		private void LinkTeleporters(SuperObject superObject) {} // 0x0000000186A6B1A0-0x0000000186A6BA30
		private void SpawnMoongates() {} // 0x0000000186A6BA30-0x0000000186A6C0B0
		private void MakeTeleporters() {} // 0x0000000186A6C0B0-0x0000000186A6C620
		private PickupTeleporter MakeTeleporter(Vector2 gatePosition, VampireSurvivors.Data.ItemType teleporterType) => default; // 0x0000000186A6C620-0x0000000186A6C8C0
		private void Pianificami(SuperObject superObject) {} // 0x0000000180B15170-0x0000000180B15180
		public Vector2 GetSpawnPosFromSuperObject(SuperObject superObject, SuperCustomProperties scp) => default; // 0x0000000186A6C8C0-0x0000000186A6CB60
		private static void SetGuardedDataForItem(SuperCustomProperties scp, PickupGuarded item) {} // 0x0000000186A6CB60-0x0000000186A6CD00
		private void StoreScript(SuperObject superObject) {} // 0x0000000186A6CD00-0x0000000186A6CD60
		private void SpawnAdventureMerchant(SuperObject superObject) {} // 0x0000000186A6CD60-0x0000000186A6CF50
		private void SpawnCustomMerchant(SuperObject superObject) {} // 0x0000000186A6CF50-0x0000000186A6D120
		private void HandleSortingOrders(SuperMap map) {} // 0x0000000186A6D120-0x0000000186A6D7A0
		private void SetTilemapLayerSortingOrder(SuperMap map, string layerName, int sortingOrder, bool visible = true /* Metadata: 0x01977430 */) {} // 0x0000000186A6D7A0-0x0000000186A6D9A0
		private PhaserTilemap AddPhaserTilemap(SuperMap map, string layerName, int setID) => default; // 0x0000000186A6D9A0-0x0000000186A6DAD0
		private void HandleArcadePhysics(List<SuperMap> maps) {} // 0x0000000186A6DAD0-0x0000000186A6E2E0
		private PhaserTilemap GetPhaserTilemapFromLayer(SuperMap map, string layerName) => default; // 0x0000000186A6E2E0-0x0000000186A6E560
		private void ProcessTiling() {} // 0x0000000186A6E560-0x0000000186A6F800
		public void UpdateHorizontalTilesetOnTeleport(Vector2 playerPos, bool processTiling = true /* Metadata: 0x01977431 */) {} // 0x0000000186A6F800-0x0000000186A6FAE0
		public void UpdateVerticalTilesetOnTeleport(Vector2 playerPos, bool processTiling = true /* Metadata: 0x01977432 */) {} // 0x0000000186A6FAE0-0x0000000186A6FDC0
		public void MoveTilesetForHorizontalRoad(float speedMultiplier) {} // 0x0000000186A6FDC0-0x0000000186A71910
		private void UpdatePhaserTilemapBounds() {} // 0x0000000186A71910-0x0000000186A71B30
	}
}
