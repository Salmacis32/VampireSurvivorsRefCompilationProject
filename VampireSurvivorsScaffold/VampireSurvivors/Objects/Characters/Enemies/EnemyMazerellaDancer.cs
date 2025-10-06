/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyMazerellaDancer : EnemyController // TypeDefIndex: 17355
	{
		// Fields
		[SerializeField]
		private MazerellaDancerMagnet _magnet; // 0x270
		[SerializeField]
		private float _maxMovementSpeed; // 0x278
		[SerializeField]
		private float _movementSmoothing; // 0x27C
		[SerializeField]
		[Space]
		private float _distanceFromPlayer; // 0x280
		[SerializeField]
		private float _regularLerpAmount; // 0x284
		[SerializeField]
		[Space]
		private float _moveToRelicDuration; // 0x288
		[SerializeField]
		private AnimationCurve _moveToRelicCurve; // 0x290
		[SerializeField]
		[Space]
		private float _moveToScreenEdgeDuration; // 0x298
		[SerializeField]
		private AnimationCurve _moveToScreenEdgeCurve; // 0x2A0
		[SerializeField]
		[Space]
		private float _moveToDanceFloorDuration; // 0x2A8
		[SerializeField]
		private AnimationCurve _moveToDanceFloorCurve; // 0x2B0
		[SerializeField]
		private Vector3 _danceFloorTargetPositionOffset; // 0x2B8
		private CoherenceSync _sync; // 0x2C8
		private readonly MazerellaDancerAnimation _mazerellaDancerAnimation; // 0x2D0
		private MazerellaDancerMazeNavigation _mazeNavigation; // 0x2D8
		private DancerState _currentState; // 0x2E0
		private DancerSide _dancerSide; // 0x2E4
		private Vector3 _movementStartPosition; // 0x2E8
		private Vector3 _movementTargetPosition; // 0x2F4
		private float _movementTimer; // 0x300
		private Bounds _danceFloorBounds; // 0x304
		private float _mazePathPosition; // 0x31C
		private VampireSurvivors.Objects.Characters.CharacterController _targetPlayer; // 0x320
	
		// Properties
		private float MaxMoveSpeed { get => default; } // 0x0000000187283570-0x00000001872836A0 
	
		// Nested types
		public enum DancerSide // TypeDefIndex: 17353
		{
			Left = 0,
			Right = 1
		}
	
		private enum DancerState // TypeDefIndex: 17354
		{
			Uninitialized = 0,
			MovingToRelic = 1,
			MovingToPath = 2,
			MovingAlongPath = 3,
			MovingToDanceFloor = 4,
			DancingOnDanceFloor = 5,
			SpawningPickupsOnDeath = 6,
			Dead = 7
		}
	
		// Constructors
		public EnemyMazerellaDancer() {} // 0x0000000187284E00-0x0000000187284FB0
	
		// Methods
		public void SetMovementTargetPosition(Vector3 targetPosition) {} // 0x00000001872836A0-0x00000001872836C0
		public void SetDanceFloorBounds(Bounds bounds) {} // 0x00000001872836C0-0x00000001872836E0
		[Command]
		public void InitAnimsCommand(bool isLeft) {} // 0x00000001872836E0-0x0000000187283730
		public void InitDancer(DancerSide dancerSide, MazerellaDancerMazeNavigation mazeNavigation, MazerellaDancerMazeNavigation.NavigationNode playerStartNavigationNode) {} // 0x0000000187283730-0x0000000187283900
		public override void InitEnemy(EnemyType enemyType, bool asRemote = false /* Metadata: 0x01978497 */) {} // 0x0000000187283900-0x0000000187283A40
		private void SetCurrentState(DancerState newState) {} // 0x0000000187283A40-0x0000000187283E00
		protected override void OnUpdate() {} // 0x0000000187283E00-0x0000000187284490
		public void InitMagnet() {} // 0x0000000187284490-0x0000000187284620
		public void InitMazePathPosition(float mazePathPosition) {} // 0x0000000187284620-0x0000000187284630
		private Vector3 TargetPositionOnPathOffsetFromPlayer() => default; // 0x0000000187284630-0x0000000187284890
		private void LerpToPosition(Vector3 startPosition, Vector3 targetPosition, float duration, AnimationCurve movementCurve, Action onMovementComplete = null) {} // 0x0000000187284890-0x0000000187284C00
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978498 */, float damageKb = 1f /* Metadata: 0x01978499 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197849D */, bool hasKb = true /* Metadata: 0x0197849E */) {} // 0x0000000187284C00-0x0000000187284C30
		public override void GetDamagedSpecial(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x0197849F */, float damageKb = 1f /* Metadata: 0x019784A0 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784A4 */, bool hasKb = true /* Metadata: 0x019784A5 */, Vector3? damagePosition = default) {} // 0x0000000187284C30-0x0000000187284C90
		protected override void Die() {} // 0x0000000187284C90-0x0000000187284E00
	}
}
