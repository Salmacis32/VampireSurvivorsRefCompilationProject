/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[DefaultExecutionOrder(1002)]
	public class BackgroundFoscariRun : BackgroundManager // TypeDefIndex: 15287
	{
		// Fields
		protected float2 CartOffset; // 0x80
		private Vector2 _initialOffset; // 0x88
		private TileSprite fb_bg_hw_Back; // 0x90
		private TileSprite fb_bg_hw_Front; // 0x98
		private TileSprite rainbowRoad; // 0xA0
		private float _speedFactor; // 0xA8
		private float _accelerationMul; // 0xAC
		private bool isFirstUpdate; // 0xB0
		private bool _hasAlteredPrismaticMissile; // 0xB1
		private List<PhaserSprite> _frontCartSprites; // 0xB8
		private List<PhaserSprite> _backCartSprites; // 0xC0
		private List<float2> _cartOffsets; // 0xC8
		private float _distanceTravelled; // 0xD0
		private int _loopLength; // 0xD4
		private int _loopsDone; // 0xD8
		private float _nextLoopDist; // 0xDC
		private TilingTileset _tilingTileset; // 0xE0
		private ParticleEmitterManager _particlesManager; // 0xE8
		private ParticleSystem _glitchEmitter; // 0xF0
		private ParticleSystem _glitchEmitter2; // 0xF8
		private bool _wasPaused; // 0x100
		private float _inversionMul; // 0x104
		private MapToken _mapToken; // 0x108
		private float _playerStartX; // 0x110
		private float _waterOffset; // 0x114
		private TileSprite _water; // 0x118
		private SpriteRenderer _waterFG; // 0x120
		private VampireSurvivors.Objects.Characters.CharacterController _Luminaire; // 0x128
		private VampireSurvivors.Framework.TimerSystem.Timer _pickupsLoopTimer; // 0x130
		private float _itemLoopTimer; // 0x138
		private float _itemLoopDelay; // 0x13C
	
		// Constructors
		public BackgroundFoscariRun() {} // 0x0000000186B43120-0x0000000186B431E0
	
		// Methods
		public void MakeWaterFallBackground() {} // 0x0000000186B3EE80-0x0000000186B3FAB0
		public override void Create() {} // 0x0000000186B3FAB0-0x0000000186B400A0
		private void SpawnCartForCharacter(VampireSurvivors.Objects.Characters.CharacterController character, float2 offset) {} // 0x0000000186B400A0-0x0000000186B40390
		public override void OnInitCompleted() {} // 0x0000000186B40390-0x0000000186B40440
		protected override void OnUpdate() {} // 0x0000000186B40440-0x0000000186B40D50
		public float GetDistanceTravelled() => default; // 0x0000000186B40D50-0x0000000186B40DF0
		private void CheckDistanceTravelled() {} // 0x0000000180B15170-0x0000000180B15180
		private void OnLoopDone() {} // 0x0000000186B40DF0-0x0000000186B40E30
		public override void LoopPickupPositions() {} // 0x0000000186B40E30-0x0000000186B412D0
		private void LateUpdate() {} // 0x0000000186B412D0-0x0000000186B41500
		private void MoveVehiclesAndPickups(float movement) {} // 0x0000000186B41500-0x0000000186B415B0
		private void MoveCarts() {} // 0x0000000186B415B0-0x0000000186B418D0
		public override void Cleanup() {} // 0x0000000186B418D0-0x0000000186B41950
		private void MakeEmitters() {} // 0x0000000186B41950-0x0000000186B43100
		public override void OnFollowerAdded(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186B43100-0x0000000186B43120
	}
}
