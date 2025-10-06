/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Characters.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class DopplegangerGate : GameMonoBehaviour // TypeDefIndex: 15338
	{
		// Fields
		public PhaserSprite _gatePortal; // 0x28
		private PhaserSprite _gateMask; // 0x30
		private PhaserSprite _gateRainbow; // 0x38
		private List<PhaserSprite> _gateDoors; // 0x40
		private GateState _gateState; // 0x48
		private int _howManyGates; // 0x4C
		private PhaserSprite _openingLight; // 0x50
		private PhaserSprite _fullscreenLight; // 0x58
		private List<PhaserSprite> _doorBlocks; // 0x60
		private List<Vector2> _doorLocations; // 0x68
		private Rectangle _doorTriggerArea; // 0x70
		private Rectangle _hardBoundsArea; // 0x78
		private Rect? _originalHardBounds; // 0x80
		private Rectangle _cameraLimitsRectangle; // 0x98
		private List<EnemyDoppleganger> _liveDopplegangers; // 0xA0
		private float _fightTimer; // 0xA8
		private MapToken _mapToken; // 0xB0
	
		// Nested types
		private enum GateState // TypeDefIndex: 15332
		{
			ClosedDoorsOpen = 0,
			ClosedAndReady = 1,
			Opening = 2,
			Open = 3,
			Closing = 4,
			ClosedForever = 5
		}
	
		// Constructors
		public DopplegangerGate() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void SetupGate(float2 position, float scale) {} // 0x0000000186B86E10-0x0000000186B88450
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186B88450-0x0000000186B885B0
		private void StopRegularSpawning() {} // 0x0000000186B885B0-0x0000000186B88750
		private void ResumeRegularSpawning() {} // 0x0000000186B88750-0x0000000186B887D0
		protected override void OnUpdate() {} // 0x0000000186B887D0-0x0000000186B88D50
		public void CloseDoors() {} // 0x0000000186B88D50-0x0000000186B89190
		public void OpenDoors() {} // 0x0000000186B89190-0x0000000186B893D0
		[IteratorStateMachine(typeof(__CloseDoors_d__25))]
		private IEnumerator _CloseDoors() => default; // 0x0000000186B893D0-0x0000000186B89470
		private void AwardChest(float2 location) {} // 0x0000000186B89470-0x0000000186B89AE0
		[IteratorStateMachine(typeof(__OpenDoors_d__27))]
		private IEnumerator _OpenDoors() => default; // 0x0000000186B89AE0-0x0000000186B89B80
		private void SetDoorOpenAmount(float amount, int doorID) {} // 0x0000000186B89B80-0x0000000186B89FB0
		public void StartOpening() {} // 0x0000000186B89FB0-0x0000000186B8A060
		[IteratorStateMachine(typeof(_RunOpeningAnimation_d__30))]
		private IEnumerator RunOpeningAnimation() => default; // 0x0000000186B8A060-0x0000000186B8A100
		private void SpawnDopplegangers() {} // 0x0000000186B8A100-0x0000000186B8A410
		[IteratorStateMachine(typeof(_RunClosingAnimation_d__32))]
		private IEnumerator RunClosingAnimation() => default; // 0x0000000186B8A410-0x0000000186B8A4B0
		public void OnDopplegangerDied(EnemyDoppleganger doppleganger) {} // 0x0000000186B8A4B0-0x0000000186B8A5E0
		protected override void OnDestroy() {} // 0x0000000186B8A5E0-0x0000000186B8A750
	}
}
