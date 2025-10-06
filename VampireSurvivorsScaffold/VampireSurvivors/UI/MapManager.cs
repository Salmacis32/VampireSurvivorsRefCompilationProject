/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MapManager : MonoBehaviour // TypeDefIndex: 14856
	{
		// Fields
		[SerializeField]
		private GameObject _Grid; // 0x20
		[SerializeField]
		private GameObject _MapIcon; // 0x28
		[SerializeField]
		private GameObject _Player; // 0x30
		[SerializeField]
		private Image _Foreground; // 0x38
		[SerializeField]
		private List<Image> _ForegroundSupports; // 0x40
		[SerializeField]
		private Image _MapStaticBackgroundImage; // 0x48
		[SerializeField]
		private RectTransform _DetailedMapContainer; // 0x50
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0x58
		[SerializeField]
		private float _AlphaWhileArcanaInfoShown; // 0x60
		private GameSessionData _session; // 0x68
		private DataManager _data; // 0x70
		private GameManager _gameManager; // 0x78
		private PlayerOptions _playerOptions; // 0x80
		private List<GameObject> _smallSprites; // 0x88
		private List<GameObject> _spawned; // 0x90
		private List<GameObject> _gridLines; // 0x98
		private MultiTargetTween _pickupFadeTweens; // 0xA0
		private float _width; // 0xA8
		private float _height; // 0xAC
		private float _zoom; // 0xB0
		private float _manualZoomFactor; // 0xB4
		private float _manualZoomStep; // 0xB8
		private float _manualZoomOutCap; // 0xBC
		private float _manualZoomInCap; // 0xC0
		private float _mapRatioX; // 0xC4
		private float _mapRatioY; // 0xC8
		private float _mapSpriteWidth; // 0xCC
		private float _mapSpriteHeight; // 0xD0
		private Sprite _detailedMapSprite; // 0xD8
		private Dictionary<int2, int> _positionBuckets; // 0xE0
		private const float DefaultMapRatio = 1f; // Metadata: 0x0197721D
		private const float DefaultMapSize = 512f; // Metadata: 0x01977221
		private const float DefaultPhaserZoom = 0.17f; // Metadata: 0x01977225
		private const float BaselineMapScale = 5.882353f; // Metadata: 0x01977229
		private const float PhaserToUnityAdjustment = 9.625f; // Metadata: 0x0197722D
		private const float DefaultPixelsPerTile = 1.6f; // Metadata: 0x01977231
		private VampireSurvivors.Data.ItemType[] _minorItemTypes; // 0xE8
	
		// Properties
		private Dictionary<VampireSurvivors.Data.ItemType, ItemData> AllItemData { get => default; } // 0x00000001868DD010-0x00000001868DD030 
		private Dictionary<WeaponType, List<WeaponData>> AllWeaponData { get => default; } // 0x00000001868DD030-0x00000001868DD050 
	
		// Constructors
		public MapManager() {} // 0x00000001868E38F0-0x00000001868E3CC0
	
		// Methods
		[Inject]
		private void Construct(GameSessionData session, DataManager data, GameManager gameManager, PlayerOptions playerOptions) {} // 0x00000001868DD050-0x00000001868DD1B0
		private void Awake() {} // 0x00000001868DD1B0-0x00000001868DD220
		private void OnDisable() {} // 0x00000001868DD220-0x00000001868DD240
		private void OnDestroy() {} // 0x00000001868DD220-0x00000001868DD240
		public void SetPickups() {} // 0x00000001868DD240-0x00000001868DD4B0
		public void ReduceAlphaOnArcanaInfoShown() {} // 0x00000001868DD4B0-0x00000001868DD4E0
		public void ResetToDefaultAlpha() {} // 0x00000001868DD4E0-0x00000001868DD510
		private bool IsMinorItem(Pickup pickupItem) => default; // 0x00000001868DD510-0x00000001868DD620
		private List<Pickup> GetAllWorldItems() => default; // 0x00000001868DD620-0x00000001868DD680
		public void ZoomIn() {} // 0x00000001868DD680-0x00000001868DD6B0
		public void ZoomOut() {} // 0x00000001868DD6B0-0x00000001868DD6E0
		public void Populate() {} // 0x00000001868DD6E0-0x00000001868DDA90
		private void AddPickupFadingTweens() {} // 0x00000001868DDA90-0x00000001868DDF90
		private void DrawMapBackground(StageData stageData) {} // 0x00000001868DDF90-0x00000001868DE260
		private void MakeGrid() {} // 0x00000001868DE260-0x00000001868DEB30
		private GameObject MakeGridLine(bool vertical, float pos) => default; // 0x00000001868DEB30-0x00000001868DED80
		private void AddMinorItems() {} // 0x00000001868DED80-0x00000001868DF180
		private void AddPlayers() {} // 0x00000001868DF180-0x00000001868DF760
		private bool ShouldSkipDrawingPickup(Pickup pickupItem, Dictionary<int2, int> positionBuckets) => default; // 0x00000001868DF760-0x00000001868DF8F0
		private void AddTreasureChests() {} // 0x00000001868DF8F0-0x00000001868DFCA0
		private void AddStagePickups() {} // 0x00000001868DFCA0-0x00000001868E08E0
		private void AddMapTokens() {} // 0x00000001868E08E0-0x00000001868E0B00
		private void AddEventTargets() {} // 0x00000001868E0B00-0x00000001868E0F70
		private GameObject SpawnItemOnMap(Sprite s, Vector2 tPos, float scale = 1f /* Metadata: 0x01977219 */) => default; // 0x00000001868E0F70-0x00000001868E1720
		private void ClearIcons() {} // 0x00000001868E1720-0x00000001868E19A0
		private void ClearGrid() {} // 0x00000001868E19A0-0x00000001868E1BA0
		private void InitMultiMaps(StageData stageData) {} // 0x00000001868E1BA0-0x00000001868E2190
		private void InitDetailedMap(StageData stageData) {} // 0x00000001868E2190-0x00000001868E26A0
		private void ShowDetailedMap(StageData stageData) {} // 0x00000001868E26A0-0x00000001868E38F0
	}
}
