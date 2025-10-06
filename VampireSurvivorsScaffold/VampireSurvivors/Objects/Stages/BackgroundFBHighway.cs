/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[DefaultExecutionOrder(1001)]
	public class BackgroundFBHighway : BackgroundManager // TypeDefIndex: 15277
	{
		// Fields
		private float2 BikeOffset; // 0x80
		private Vector2 _initialOffset; // 0x88
		private TileSprite fb_bg_hw_Back; // 0x90
		private TileSprite fb_bg_hw_Front; // 0x98
		private float _speedFactor; // 0xA0
		private float _accelerationMul; // 0xA4
		private float _currentAcceleration; // 0xA8
		private float _yMul; // 0xAC
		private bool isFirstUpdate; // 0xB0
		private bool _created; // 0xB1
		private List<PhaserSprite> _frontCartSprites; // 0xB8
		private List<PhaserSprite> _backCartSprites; // 0xC0
		private List<float2> _cartOffsets; // 0xC8
		private float _distanceTravelled; // 0xD0
		private int _loopLength; // 0xD4
		private TilingTileset _tilingTileset; // 0xD8
		private int _loopsDone; // 0xE0
		private float _nextLoopDist; // 0xE4
		private float _inversionMul; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _BarrelsSpawningTimer; // 0xF0
		private float _playerStartX; // 0xF8
	
		// Constructors
		public BackgroundFBHighway() {} // 0x0000000186B2C8F0-0x0000000186B2C960
	
		// Methods
		public override void Create() {} // 0x0000000186B2A160-0x0000000186B2B130
		private void SpawnBikeForCharacter(VampireSurvivors.Objects.Characters.CharacterController character, float2 offset) {} // 0x0000000186B2B130-0x0000000186B2B310
		private void HandleDestructibleSpawning() {} // 0x0000000186B2B310-0x0000000186B2B870
		public override void OnInitCompleted() {} // 0x0000000186B2B870-0x0000000186B2B900
		public void SetSpeedFactor(float factor) {} // 0x0000000186758970-0x0000000186758980
		protected override void OnUpdate() {} // 0x0000000186B2B900-0x0000000186B2BBB0
		public float GetDistanceTravelled() => default; // 0x0000000186B2BBB0-0x0000000186B2BC50
		private void CheckDistanceTravelled() {} // 0x0000000186B2BC50-0x0000000186B2BD60
		public override void InitPickupForLoopingStage(Pickup pickup) {} // 0x0000000186B2BD60-0x0000000186B2BF10
		private void MoveVehiclesAndPickups(float movement) {} // 0x0000000186B2BF10-0x0000000186B2C100
		private void LateUpdate() {} // 0x0000000186B2C100-0x0000000186B2C2B0
		private void UpdateCarts() {} // 0x0000000186B2C2B0-0x0000000186B2C7D0
		public override void Cleanup() {} // 0x0000000186B2C7D0-0x0000000186B2C8D0
		public override void OnFollowerAdded(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B2C8D0-0x0000000186B2C8F0
	}
}
