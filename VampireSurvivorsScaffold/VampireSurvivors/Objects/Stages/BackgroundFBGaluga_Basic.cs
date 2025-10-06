/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundFBGaluga_Basic : BackgroundManager // TypeDefIndex: 15276
	{
		// Fields
		private TilingTileset _tilingTileset; // 0x80
		private float _mapHeight; // 0x88
		private bool _hasSpawnedBigFuzz; // 0x8C
		private EnemyBigFuzz _bigFuzz; // 0x90
		private Color _dayColor; // 0x98
		private Color _nightColor; // 0xA8
		private Light2D _globalLight; // 0xB8
		private List<Vector2> _exploCarLocations; // 0xC0
		private List<Vector2> _exploBarrelLocations; // 0xC8
		private VampireSurvivors.Framework.TimerSystem.Timer _destructibleTimer; // 0xD0
		private float DestructibleFrequency; // 0xD8
		[NonSerialized]
		public PhaserSprite _leftDoor; // 0xE0
		[NonSerialized]
		public PhaserSprite _rightDoor; // 0xE8
		[NonSerialized]
		public PhaserSprite _doorFrame; // 0xF0
		[NonSerialized]
		public PhaserSprite _doorSpace; // 0xF8
		[NonSerialized]
		public PhaserSprite _doorMask; // 0x100
		private PhaserSprite _waterAnim; // 0x108
		private TileSprite _water; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _simondoTimer; // 0x118
		private const float DayCycleDuration = 1800f; // Metadata: 0x019774D3
	
		// Constructors
		public BackgroundFBGaluga_Basic() {} // 0x0000000186B27C20-0x0000000186B27C40
	
		// Methods
		public override void Awake() {} // 0x0000000186B27C40-0x0000000186B28260
		public override void Create() {} // 0x0000000186B28260-0x0000000186B28950
		public override void OnInitCompleted() {} // 0x0000000186B28950-0x0000000186B28BE0
		protected void SpawnSimondo() {} // 0x0000000186B28BE0-0x0000000186B28E50
		protected void SpawnBigFuzzBattleLocation() {} // 0x0000000186B28E50-0x0000000186B29AF0
		protected void HandleDestructibleSpawning() {} // 0x0000000186B29AF0-0x0000000186B29BA0
		protected override void OnUpdate() {} // 0x0000000186B29BA0-0x0000000186B29D70
		private void UpdateDayNight() {} // 0x0000000186B29D70-0x0000000186B29EF0
		public void SetBigFuzzObject(EnemyBigFuzz bigFuzz) {} // 0x000000018198E590-0x000000018198E5F0
		private void LateUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Cleanup() {} // 0x0000000186B29EF0-0x0000000186B2A0A0
	}
}
