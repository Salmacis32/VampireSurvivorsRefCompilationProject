/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Items;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[DefaultExecutionOrder(1003)]
	public class BackgroundTP_Basic : BackgroundManager // TypeDefIndex: 15309
	{
		// Fields
		private TilingTileset _tilingTileset; // 0x80
		private PlatformZoneMovement _platformMovement; // 0x88
		private DopplegangerGate _dopplegangerGate; // 0x90
		private TileSprite _AqueductBG; // 0x98
		private TileSprite _AqueductWater; // 0xA0
		private List<TileSprite> _AqueductWaters; // 0xA8
		private List<PizzaCircle> BossPizzas; // 0xB0
		private VampireSurvivors.Framework.TimerSystem.Timer checkBossPizzasTimer; // 0xB8
		private List<PickupTeleporter> cycleGates; // 0xC0
		private PolygonGroupComponent[] _polygonGroups; // 0xC8
		private PolygonGroupComponent _currentPlatformingArea; // 0xD0
		private List<Rectangle> _platformingZones; // 0xD8
		private bool _created; // 0xE0
		private List<TPSoftBound> _softBounds; // 0xE8
		private List<TPSoftBound> _awakeSoftBounds; // 0xF0
		private List<TPBiomeType> _unlockedBiomes; // 0xF8
		private List<TPBiomeType> _accessibleBiomes; // 0x100
		private TileSprite _deathFightBG; // 0x108
		private TileSprite _deathFightTile; // 0x110
		private PhaserSprite _deathFightTileTop; // 0x118
		private float2? _deathFightStartCameraPos; // 0x120
		private bool hasWater; // 0x12C
		private TPBiomeType? _currentBiome; // 0x130
	
		// Properties
		public TPBiomeType? CurrentBiome { get => default; } // 0x0000000182A45B90-0x0000000182A45BA0 
	
		// Constructors
		public BackgroundTP_Basic() {} // 0x0000000186B63B30-0x0000000186B63E40
	
		// Methods
		private void DifficultyModifier() {} // 0x0000000186B5A660-0x0000000186B5AD90
		private void SnapEggs() {} // 0x0000000186B5AD90-0x0000000186B5AE30
		public override string GetDetailedMap(StageData stageData) => default; // 0x0000000186B5AE30-0x0000000186B5AFB0
		public override void Create() {} // 0x0000000186B5AFB0-0x0000000186B5B810
		private TP_BossArena TryAddingBossArena(GameObject prefab, string enemyName, EnemyType enemyType) => default; // 0x0000000186B5B810-0x0000000186B5B9C0
		private void CreateAqueductWater() {} // 0x0000000186B5B9C0-0x0000000186B5C340
		private void CreateBossPizzas() {} // 0x0000000186B5C340-0x0000000186B5C980
		private void CheckBossPizzas() {} // 0x0000000186B5C980-0x0000000186B5D200
		public void CreateCycleGatesDelayed() {} // 0x0000000186B5D200-0x0000000186B5D2B0
		private void CreateCycleGates() {} // 0x0000000186B5D2B0-0x0000000186B5E2E0
		public Rect GetRectFromSuperObject(float xMin, float yMin, float xMax, float yMax, bool skipInverseCalculation = false /* Metadata: 0x0197752F */) => default; // 0x0000000186B5E2E0-0x0000000186B5E330
		private void LinkDoorsToBiomes() {} // 0x0000000186B5E330-0x0000000186B5E7C0
		private void CreateSoftBounds() {} // 0x0000000186B5E7C0-0x0000000186B5EF90
		private void GreenlightBiomes() {} // 0x0000000186B5EF90-0x0000000186B5F2F0
		private void TryGreenlight(List<VampireSurvivors.Data.ItemType> collected, VampireSurvivors.Data.ItemType item, TPBiomeType biome) {} // 0x0000000186B5F2F0-0x0000000186B5F690
		private void TryGreenlight(List<VampireSurvivors.Data.ItemType> collected, VampireSurvivors.Data.ItemType item) {} // 0x0000000186B5F690-0x0000000186B5F900
		public bool AwakeBoundsContainingPlayers() => default; // 0x0000000186B5F900-0x0000000186B5FD30
		public float2 RestrictInsideAwakeBounds(float2 pos) => default; // 0x0000000186B5FD30-0x0000000186B5FFA0
		public void ContainPlayersWithinSoftBounds() {} // 0x0000000186B5FFA0-0x0000000186B601C0
		private void UpdateAwakeBounds() {} // 0x0000000186B601C0-0x0000000186B603C0
		public void CreateTestDopplegangerGate() {} // 0x0000000186B603C0-0x0000000186B60460
		private void CreateDopplegangerGate(float2 position) {} // 0x0000000186B60460-0x0000000186B60540
		public override void OnInitCompleted() {} // 0x0000000186B60540-0x0000000186B60820
		protected override void OnUpdate() {} // 0x0000000186B60820-0x0000000186B609D0
		private bool IsAnyPlayerInAPlatformingZone() => default; // 0x0000000186B609D0-0x0000000186B60DD0
		public void DeactivatePlatformingAltogether() {} // 0x0000000186B60DD0-0x0000000186B60E40
		public void DisableAllSoftBounds() {} // 0x0000000186B60E40-0x0000000186B60EE0
		private void ExitPlatformingZone() {} // 0x0000000186B60EE0-0x0000000186B61200
		private void UpdateCurrentPlatformingArea() {} // 0x0000000186B61200-0x0000000186B61700
		private void LateUpdate() {} // 0x0000000186B61700-0x0000000186B61750
		public override void Cleanup() {} // 0x0000000186B61750-0x0000000186B617D0
		public override bool HasCustomMadGrooveRestriction() => default; // 0x0000000181958370-0x0000000181958380
		public override bool IsPositionPulledByMadGroove(float2 position) => default; // 0x0000000186B617D0-0x0000000186B617E0
		public override bool ShouldShowCursor(float2 position) => default; // 0x0000000186B617D0-0x0000000186B617E0
		private bool IsWithinAccessibleBounds(float2 position) => default; // 0x0000000186B617E0-0x0000000186B61C10
		private bool IsWithinUnlockedBounds(float2 position) => default; // 0x0000000186B61C10-0x0000000186B62040
		public override bool HasExtraSafeXYLogic() => default; // 0x0000000181958370-0x0000000181958380
		public override float2 ExtraSafeXY(float2 position, float2 playerPosition) => default; // 0x0000000186B62040-0x0000000186B622C0
		public void TestSpawnDeathFightBackground() {} // 0x0000000186B622C0-0x0000000186B625C0
		public void TestRemoveDeathFightBackground() {} // 0x0000000186B625C0-0x0000000186B625D0
		public void SpawnDeathFightBackground() {} // 0x0000000186B625D0-0x0000000186B62620
		public void SpawnDeathFightTile() {} // 0x0000000186B62620-0x0000000186B63020
		public void RemoveDeathFightBackground() {} // 0x0000000186B63020-0x0000000186B633C0
		private void UpdateBackground() {} // 0x0000000186B633C0-0x0000000186B63B30
	}
}
