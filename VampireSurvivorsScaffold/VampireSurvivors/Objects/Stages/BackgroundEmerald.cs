/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Scripts.UI;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundEmerald : BackgroundManager // TypeDefIndex: 15273
	{
		// Fields
		private EME_BiomeBounds _biomeBounds; // 0x80
		private EME_RibbonController _emeraldRibbonController; // 0x88
		private EME_TeleportFader _teleportFader; // 0x90
		private EME_BiomeNameUI _biomeNameUi; // 0x98
		private EmeraldsBiomes _nextBossBiome; // 0xA0
		private readonly Dictionary<EmeraldsBiomes, PizzaCircle> _bossPizzas; // 0xA8
		private VampireSurvivors.Framework.TimerSystem.Timer _checkBossPizzasTimer; // 0xB0
		private readonly Dictionary<EmeraldsBiomes, Pickup_EME_Teleporter> _biomeToJunctionTeleporterLookup; // 0xB8
		private readonly Dictionary<EmeraldsBiomes, Pickup_EME_Teleporter> _junctionToBiomeTeleporterLookup; // 0xC0
		private const string DestinationNameIsDestination = "isDestination"; // Metadata: 0x0197749F
		private const string EmeItems = "EME_items"; // Metadata: 0x019774AD
		private const string PizzasPoolName = "PizzaCircles"; // Metadata: 0x019774B7
		private const string JunctionDestination = "biome0"; // Metadata: 0x019774C4
		private readonly Dictionary<EmeraldsBiomes, string> _localizedBiomeNamesLookup; // 0xC8
		private bool _finalBossDefeated; // 0xD5
		private bool _ribbonTargetBossPizzas; // 0xD6
		private Transform _junctionSpawnTransform; // 0xD8
	
		// Properties
		public EmeraldsBiomes CurrentBiome { get; private set; } // 0x0000000181BDC430-0x0000000181BDC440 0x0000000181BDC440-0x0000000181BDC450
		public EME_BiomeBounds GetBiomeBounds { get => default; } // 0x00000001819A0370-0x00000001819A0380 
		public bool HasLeftJunction { get; private set; } // 0x0000000186B20100-0x0000000186B20110 0x0000000186B20110-0x0000000186B20120
		private bool IsStageInverted { get => default; } // 0x0000000186B202B0-0x0000000186B204B0 
	
		// Nested types
		public enum EmeraldsBiomes // TypeDefIndex: 15270
		{
			Biome1 = 0,
			Biome2 = 1,
			Biome3 = 2,
			Biome4 = 3,
			Biome5 = 4,
			Biome6 = 5,
			Junction = 6,
			nil = 7
		}
	
		// Constructors
		public BackgroundEmerald() {} // 0x0000000186B27740-0x0000000186B279C0
	
		// Methods
		public override bool HasCustomMapRules() => default; // 0x0000000181958370-0x0000000181958380
		public override bool HasCustomMadGrooveRestriction() => default; // 0x0000000181958370-0x0000000181958380
		public override bool IsPositionPulledByMadGroove(float2 position) => default; // 0x0000000186B20120-0x0000000186B20190
		public override bool ShouldShowPickupIconOnMap(Vector3 worldPosition) => default; // 0x0000000186B20190-0x0000000186B201F0
		private bool IsWithinAccessibleBounds(float2 position) => default; // 0x0000000186B20120-0x0000000186B20190
		public Bounds GetBoundsForCurrentBiome(float xPosition, float width) => default; // 0x0000000186B201F0-0x0000000186B202B0
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B204B0-0x0000000186B20530
		protected override void OnUpdate() {} // 0x0000000186B20530-0x0000000186B20A50
		public override void Create() {} // 0x0000000186B20A50-0x0000000186B21380
		private void OnRemoteItemInstantiated(Pickup item) {} // 0x0000000186B21380-0x0000000186B21410
		protected override void OnDestroy() {} // 0x0000000186B21410-0x0000000186B21590
		private void InitBiomeNames() {} // 0x0000000186B21590-0x0000000186B216D0
		private void AddBiomeNameToDictionary(EmeraldsBiomes biome, string localizationKey) {} // 0x0000000186B216D0-0x0000000186B218C0
		private void RemoveBonusesFromEggs() {} // 0x0000000186B218C0-0x0000000186B21960
		public override void OnInitCompleted() {} // 0x0000000186B21960-0x0000000186B22070
		public void TeleportBossKilled(EmeraldsBiomes bossBiome, string[] teleportKeys) {} // 0x0000000186B22070-0x0000000186B223A0
		private void IncrementNextBiome() {} // 0x0000000186B223A0-0x0000000186B223D0
		private void ActivateTeleporters(string[] teleportKeys) {} // 0x0000000186B223D0-0x0000000186B226F0
		private void SetBiomeDifficulty() {} // 0x0000000186B226F0-0x0000000186B22890
		private void SetUpTeleporters() {} // 0x0000000186B22890-0x0000000186B22B00
		private void SetupTeleporter(Pickup_EME_Teleporter emeTeleporter) {} // 0x0000000186B22B00-0x0000000186B230C0
		private static void DisableTeleporter(Pickup_EME_Teleporter emeTeleporter) {} // 0x0000000186B230C0-0x0000000186B23210
		private void ConfigureJunctionToBiomeTeleporter(EmeraldsBiomes targetBiome, Pickup_EME_Teleporter teleporter) {} // 0x0000000186B23210-0x0000000186B233D0
		private void OnTeleportStart(VampireSurvivors.Objects.Characters.CharacterController playerTeleported) {} // 0x0000000186B233D0-0x0000000186B238D0
		private void DisablePositionLimitingOnTeleportStart() {} // 0x0000000186B238D0-0x0000000186B23A50
		private void ActivateBiome(VampireSurvivors.Objects.Characters.CharacterController playerTeleported, EmeraldsBiomes biomeToActivate) {} // 0x0000000186B23A50-0x0000000186B248C0
		private void SetupTeleportFader() {} // 0x0000000186B248C0-0x0000000186B24FE0
		private void SetupBiomeNameUi() {} // 0x0000000186B24FE0-0x0000000186B25470
		private void CreateBossPizzas() {} // 0x0000000186B25470-0x0000000186B25A10
		private void CheckBossPizzas() {} // 0x0000000186B25A10-0x0000000186B26350
		public void DebugTeleportToNextBiome() {} // 0x0000000186B26350-0x0000000186B264C0
		public void DebugTeleportToPreviousBiome() {} // 0x0000000186B264C0-0x0000000186B26630
		private void DebugTeleportToBiomeEntrance() {} // 0x0000000186B26630-0x0000000186B26770
		public void DebugEnableAllTwoWayTeleporters() {} // 0x0000000186B26770-0x0000000186B26A20
		public override void Cleanup() {} // 0x0000000186B26A20-0x0000000186B26DE0
		private void Log(string message, GameObject debugGameObject = null) {} // 0x0000000186B26DE0-0x0000000186B26F10
		public override string GetDetailedMapStaticBackgroundImage(StageData stageData) => default; // 0x0000000186B26F10-0x0000000186B26FA0
		public override string GetDetailedMap(StageData stageData) => default; // 0x0000000186B26FA0-0x0000000186B27130
		public override float GetMap_SizeX() => default; // 0x0000000186B27130-0x0000000186B27140
		public override float GetMap_SizeY() => default; // 0x0000000186B27140-0x0000000186B27150
		public override int GetMap_SupportHorizontal() => default; // 0x0000000186B27150-0x0000000186B27170
		public override float2 GetMap_PlayerPos() => default; // 0x0000000186B27170-0x0000000186B27740
		public override bool GetMap_DrawGrid() => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}
