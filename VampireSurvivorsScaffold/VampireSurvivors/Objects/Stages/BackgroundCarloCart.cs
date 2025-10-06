/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[DefaultExecutionOrder(1000)]
	public class BackgroundCarloCart : BackgroundManager // TypeDefIndex: 15258
	{
		// Fields
		[SerializeField]
		protected float2 CartOffset; // 0x80
		private Vector2 _initialOffset; // 0x88
		private TileSprite fb_bg_hw_Back; // 0x90
		private TileSprite fb_bg_hw_Front; // 0x98
		private TileSprite rainbowRoad; // 0xA0
		private float _speedFactor; // 0xA8
		private float _accelerationMul; // 0xAC
		private bool isFirstUpdate; // 0xB0
		private List<PhaserSprite> _frontCartSprites; // 0xB8
		private List<PhaserSprite> _backCartSprites; // 0xC0
		private List<float2> _cartOffsets; // 0xC8
		private PickupCoffin secretCoffin; // 0xD0
		private bool canSpawnSecretCoffin; // 0xD8
		private bool _isAccelerated; // 0xD9
		private float _accelTime; // 0xDC
		private float _accelDuration; // 0xE0
		private float _distanceTravelled; // 0xE4
		private int _loopLength; // 0xE8
		private int _loopsDone; // 0xEC
		private float _nextLoopDist; // 0xF0
		private TilingTileset _tilingTileset; // 0xF8
		private List<Vector2> _accelLocations; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _accelSpawnTimer; // 0x108
		private float _accelSpawnFrequency; // 0x110
		private float2 _GoalPosition; // 0x114
		private ParticleEmitterManager _particlesManager; // 0x120
		private ParticleSystem _glitchEmitter; // 0x128
		private ParticleSystem _glitchEmitter2; // 0x130
		private float _savedTimeScale; // 0x138
		private bool _wasPaused; // 0x13C
		private float _initialTimeScale; // 0x140
		private float _inversionMul; // 0x144
		private MapToken _mapToken; // 0x148
		private float _playerStartX; // 0x150
		private bool _canSpawnGoal; // 0x154
	
		// Constructors
		public BackgroundCarloCart() {} // 0x0000000186B08C10-0x0000000186B08D40
	
		// Methods
		public override void Create() {} // 0x0000000186B03130-0x0000000186B040A0
		private void SpawnCartForCharacter(VampireSurvivors.Objects.Characters.CharacterController character, float2 offset) {} // 0x0000000186B040A0-0x0000000186B04390
		private void OnRemoteItemInstantiated(Pickup item) {} // 0x0000000186B04390-0x0000000186B044A0
		public override void OnInitCompleted() {} // 0x0000000186B044A0-0x0000000186B04660
		public void TryToSpawnAccel() {} // 0x0000000186B04660-0x0000000186B04850
		protected override void OnDestroy() {} // 0x0000000186B04850-0x0000000186B049D0
		protected override void OnUpdate() {} // 0x0000000186B049D0-0x0000000186B05380
		public override void CustomPreload(Action onComplete) {} // 0x0000000186B05380-0x0000000186B05660
		public float GetDistanceTravelled() => default; // 0x0000000186B05660-0x0000000186B05700
		private void CheckDistanceTravelled() {} // 0x0000000186B05700-0x0000000186B057B0
		private void OnPassGoal() {} // 0x0000000186B057B0-0x0000000186B05860
		private void SpawnGoal() {} // 0x0000000186B05860-0x0000000186B05AD0
		private void LateUpdate() {} // 0x0000000186B05AD0-0x0000000186B05DA0
		private void MoveEnemies() {} // 0x0000000186B05DA0-0x0000000186B061A0
		private void MoveVehiclesAndPickups(float movement) {} // 0x0000000186B061A0-0x0000000186B06280
		public override void InitPickupForLoopingStage(Pickup pickup) {} // 0x0000000186B06280-0x0000000186B06430
		private void MoveCarts() {} // 0x0000000186B06430-0x0000000186B06790
		public void Accelerate() {} // 0x0000000186B06790-0x0000000186B06970
		public void StopAcceleration() {} // 0x0000000186B06970-0x0000000186B06A10
		public override void Cleanup() {} // 0x0000000186B06A10-0x0000000186B06B50
		public override void OnItemTriggered(VampireSurvivors.Data.ItemType itemType, Pickup pickup, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186B06B50-0x0000000186B07430
		public override void OnPlayerEnteringDifferentTilemap() {} // 0x0000000186B07430-0x0000000186B07440
		private void MakeEmitters() {} // 0x0000000186B07440-0x0000000186B08BF0
		public override void OnFollowerAdded(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B08BF0-0x0000000186B08C10
	}
}
