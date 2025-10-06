/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundMazerella : BackgroundManager // TypeDefIndex: 15297
	{
		// Fields
		private const float DancerSpawnDistanceFromPlayerSpawn = 1f; // Metadata: 0x019774D8
		private const string LeftRelicName = "StartLeft"; // Metadata: 0x019774DC
		private const string RightRelicName = "StartRight"; // Metadata: 0x019774E6
		private const string PlayerSpawnName = "PlayerStart"; // Metadata: 0x019774F1
		private const string LeftDeadEndName = "DancerDeadEndLeft"; // Metadata: 0x019774FD
		private const string RightDeadEndName = "DancerDeadEndRight"; // Metadata: 0x0197750F
		private Bounds _leftDeadEndBounds; // 0x80
		private Bounds _rightDeadEndBounds; // 0x98
		private MazerellaDancerMazeNavigation _mazeNavigation; // 0xB0
		private const int PlayerStartNavigationNodeIndex = 84; // Metadata: 0x01977522
		private VampireSurvivors.Objects.Characters.CharacterController _player; // 0xB8
		private MazerellaTorinoSecretPositions _torinoSecretPositions; // 0xC0
		private EX_Boss_Colossus _colossus; // 0xC8
		private bool _colossusHasLeftMap; // 0xD0
		private bool _torinoUnlocked; // 0xD1
		private bool _isInverse; // 0xD2
	
		// Constructors
		public BackgroundMazerella() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		public override void Create() {} // 0x0000000186B4EF00-0x0000000186B4F870
		public void SetColossus(EX_Boss_Colossus colossus) {} // 0x0000000184BB7BF0-0x0000000184BB7C50
		private Bounds GenerateDeadEndBounds(EnemyMazerellaDancer.DancerSide dancerSide, TilingTileset tilingTileset) => default; // 0x0000000186B4F870-0x0000000186B4FAA0
		private void CreateBoss() {} // 0x0000000186B4FAA0-0x0000000186B4FE40
		private void SpawnDancers(TilingTileset tilingTileset) {} // 0x0000000186B4FE40-0x0000000186B4FFF0
		private void SpawnDancer(SuperObject playerSpawnPoint, EnemyMazerellaDancer.DancerSide dancerSide) {} // 0x0000000186B4FFF0-0x0000000186B50810
		private void CheckForTorinoUnlock() {} // 0x0000000186B50810-0x0000000186B50B10
		public void UnlockTorino() {} // 0x0000000186B50B10-0x0000000186B50C90
		protected override void OnUpdate() {} // 0x0000000186B50C90-0x0000000186B50DB0
	}
}
