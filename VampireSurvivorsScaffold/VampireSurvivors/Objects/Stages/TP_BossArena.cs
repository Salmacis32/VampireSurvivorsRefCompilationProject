/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class TP_BossArena : GameMonoBehaviour // TypeDefIndex: 15361
	{
		// Fields
		private EnemyType _enemyType; // 0x28
		private float2 _spawnPosition; // 0x2C
		private List<PhaserSprite> _doorBlocks; // 0x38
		private List<Vector2> _doorLocations; // 0x40
		private Rectangle _doorTriggerArea; // 0x48
		private Rectangle _hardBoundsArea; // 0x50
		private Rect? _originalHardBounds; // 0x58
		private Rectangle _cameraLimitsRectangle; // 0x70
		private ArenaState _state; // 0x78
		private EnemyController _enemy; // 0x80
		private CoherenceSync _sync; // 0x88
		private int _loadAcks; // 0x90
		private float _ackTimeout; // 0x94
		private bool _isChangingState; // 0x98
		private const float MaxAckTimeout = 1.5f; // Metadata: 0x019775C2
		private MapToken _mapToken; // 0xA0
		[NonSerialized]
		[Sync]
		public bool _fadeToSilenceInsteadOfMusic; // 0xA8
		private const string BOSS_CACHE_GROUP_NAME = "TP_BOSS"; // Metadata: 0x019775C6
	
		// Nested types
		private enum ArenaState // TypeDefIndex: 15357
		{
			Unactivated = 0,
			Locked = 1,
			Complete = 2
		}
	
		// Constructors
		public TP_BossArena() {} // 0x0000000186B98DF0-0x0000000186B98E40
	
		// Methods
		private new void Awake() {} // 0x0000000186B96A60-0x0000000186B96B00
		public void Setup(EnemyType enemyType, string bossName) {} // 0x0000000186B96B00-0x0000000186B96C20
		[Command]
		public void PerformSetup(int enemy, string bossName) {} // 0x0000000186B96C20-0x0000000186B97550
		protected override void OnUpdate() {} // 0x0000000186B97550-0x0000000186B97990
		[Command]
		public void SwitchToCompletedState() {} // 0x0000000186B97990-0x0000000186B979B0
		[Command]
		public void SwitchToLockedState() {} // 0x0000000186B979B0-0x0000000186B979E0
		private void LoadBossTextureAndSpawn() {} // 0x0000000186B979E0-0x0000000186B97C00
		private void SpawnBoss() {} // 0x0000000186B97C00-0x0000000186B97D00
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void AckTake() {} // 0x0000000186B97D00-0x0000000186B97D10
		[IteratorStateMachine(typeof(_WaitForAcksAndLoadBoss_d__28))]
		private IEnumerator WaitForAcksAndLoadBoss() => default; // 0x0000000186B97D10-0x0000000186B97DB0
		public void CloseDoors() {} // 0x0000000186B97DB0-0x0000000186B98310
		public void OpenDoors() {} // 0x0000000186B98310-0x0000000186B985F0
		protected override void OnDestroy() {} // 0x0000000186B985F0-0x0000000186B98660
		[IteratorStateMachine(typeof(__CloseDoors_d__32))]
		private IEnumerator _CloseDoors() => default; // 0x0000000186B98660-0x0000000186B98700
		[IteratorStateMachine(typeof(__OpenDoors_d__33))]
		private IEnumerator _OpenDoors() => default; // 0x0000000186B98700-0x0000000186B987A0
		private void SetDoorOpenAmount(float amount, int doorID) {} // 0x0000000186B987A0-0x0000000186B98BD0
		private void StopRegularSpawning() {} // 0x0000000186B98BD0-0x0000000186B98D70
		private void ResumeRegularSpawning() {} // 0x0000000186B98D70-0x0000000186B98DF0
	}
}
