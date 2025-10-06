/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundDevilRoom : BackgroundManager // TypeDefIndex: 15264
	{
		// Fields
		private TileSprite _carpet; // 0x80
		private TileSprite _Tile_H_Plain; // 0x88
		private TileSprite _Tile_V_Deco; // 0x90
		private TileSprite _Tile_V_Deco2; // 0x98
		private TileSprite _Tile_H_Border; // 0xA0
		private TileSprite _Tile_V_Border; // 0xA8
		private int[] _cachedPlayerCharm; // 0xB0
		private List<int> tresholds; // 0xB8
		private List<EnemyType?> enemies; // 0xC0
		private List<EnemyType?> bosses; // 0xC8
		private List<EnemyType?> _secondPhaseBosses; // 0xD0
		private List<EnemyType?> _secondPhaseEnemies; // 0xD8
		public int currentLevel; // 0xE0
		private List<PhaserSprite> walls; // 0xE8
		private List<Vector2> darkassoLoc; // 0xF0
		private BackgroundDevilRoom_Helper _helper; // 0xF8
		private PickupRelic _darkassoPickup; // 0x100
		private bool _hasTriggeredDarkassoCutscene; // 0x108
		private List<Rectangle> _darkassoCutsceneTriggerZones; // 0x110
		private VampireSurvivors.Objects.Characters.CharacterController _darkassoTargetPlayer; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer skullsTimer; // 0x120
		private bool _isSendingAdvanceLevel; // 0x128
		private int _lastEnemies; // 0x148
		private float _lastSeconds; // 0x14C
	
		// Properties
		public Camera MainCamera { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		public Bounds CamBounds { get => default; } // 0x0000000186B0F140-0x0000000186B0F160 
		public List<Vector2> WallEyesLocations { get; set; } // 0x0000000182A45B90-0x0000000182A45BA0 0x0000000182A45BA0-0x0000000182A45C00
		public List<Vector2> LeftEyesLocations { get; set; } // 0x0000000184F612E0-0x0000000184F612F0 0x0000000185D80170-0x0000000185D801D0
		public List<Vector2> RightEyesLocations { get; set; } // 0x0000000184F612F0-0x0000000184F61300 0x0000000185F85960-0x0000000185F859C0
	
		// Constructors
		public BackgroundDevilRoom() {} // 0x0000000186B145F0-0x0000000186B15790
	
		// Methods
		public override void Create() {} // 0x0000000186B0F160-0x0000000186B11060
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B11060-0x0000000186B11620
		private void OnRemoteItemInstantiated(Pickup pickup) {} // 0x0000000186B11620-0x0000000186B118B0
		public override void OnInitCompleted() {} // 0x0000000186B118B0-0x0000000186B119A0
		protected override void OnUpdate() {} // 0x0000000186B119A0-0x0000000186B11C40
		private bool CheckLevel() => default; // 0x0000000186B11C40-0x0000000186B12140
		public void AdvanceLevel() {} // 0x0000000186B12140-0x0000000186B12500
		private void LateUpdate() {} // 0x0000000186B12500-0x0000000186B12520
		private void ResumeEnemyWaves() {} // 0x0000000186B12520-0x0000000186B12640
		private void SpawnDarkasso(Vector2 location) {} // 0x0000000186B12640-0x0000000186B128B0
		private void OnDarkassoSpawned() {} // 0x0000000186B128B0-0x0000000186B12900
		private void CheckForDarkassoCutscene() {} // 0x0000000186B12900-0x0000000186B12C00
		public void TriggerCutscene(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B12C00-0x0000000186B12D20
		[IteratorStateMachine(typeof(__PlayDarkassoCutscene_d__51))]
		private IEnumerator _PlayDarkassoCutscene() => default; // 0x0000000186B12D20-0x0000000186B12DC0
		private void SpawnArcanaChestAt(Vector2 position) {} // 0x0000000186B12DC0-0x0000000186B133D0
		public override void CheckMinute(int minute) {} // 0x0000000186B133D0-0x0000000186B13830
		private void ExpandBounds(int level) {} // 0x0000000186B13830-0x0000000186B142A0
		private void CheckStageCosmetics(int level) {} // 0x0000000186B142A0-0x0000000186B142D0
		private void UpdateKillRatio(int level) {} // 0x0000000186B142D0-0x0000000186B14370
		public override float GetKillRatio() => default; // 0x0000000186B14370-0x0000000186B144B0
		public override void Cleanup() {} // 0x0000000185DED600-0x0000000185DED610
		public override void EnableMovingBackground() {} // 0x0000000180B15170-0x0000000180B15180
		public override void DisableMovingBackground() {} // 0x0000000186B144B0-0x0000000186B144E0
		public override bool ShouldPlayNormalMusic() => default; // 0x0000000186B144E0-0x0000000186B145F0
	}
}
