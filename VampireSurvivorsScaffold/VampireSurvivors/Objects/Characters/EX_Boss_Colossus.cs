/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EX_Boss_Colossus : EnemyControllerBoss_TerrainBreaker // TypeDefIndex: 17198
	{
		// Fields
		private const string AsleepAnimationName = "Asleep"; // Metadata: 0x019781A1
		private const string MovingAnimName = "Moving"; // Metadata: 0x019781A8
		private Vector2 _roamingTargetPosition; // 0x428
		private int currentLocationOfInterest; // 0x430
		[Header("HP Thresholds")]
		[SerializeField]
		private float awakenThresholdPercentage; // 0x434
		[SerializeField]
		private float enragedThresholdPercentage; // 0x438
		[SerializeField]
		[Space]
		[Tooltip("If the Colossus hasn\'t been damaged for this long after being aggro\'d, it will return to the roaming state")]
		private float _aggroDuration; // 0x43C
		private float _aggroTimer; // 0x440
		private float awakenThresholdHP; // 0x444
		private float enragedThresholdHP; // 0x448
		private Colossus_Mode_Types Colossus_Mode; // 0x44C
		private Vector2 _chargeStartingPosition; // 0x450
		private Vector2 _chargeEndingLocation; // 0x458
		private Camera _mainCamera; // 0x460
		private float _cameraOrthographicSizeX; // 0x468
		private float _cameraOrthographicSizeY; // 0x46C
		[Header("Charge Timer")]
		[SerializeField]
		private float chargeMechanicInterval; // 0x470
		[SerializeField]
		private float chargeActivationDelay; // 0x474
		[SerializeField]
		private float chargeActiveDuration; // 0x478
		[Space]
		private VampireSurvivors.Framework.TimerSystem.Timer _chargerMechanicTimer; // 0x480
		private VampireSurvivors.Framework.TimerSystem.Timer _chargeDelayTimer; // 0x488
		private VampireSurvivors.Framework.TimerSystem.Timer _chargeFinishTimer; // 0x490
		[Header("Charge Mechanics")]
		[SerializeField]
		private float chargeSpeedModifier; // 0x498
		[Space]
		private Vector2 chargeDirection; // 0x49C
		[Header("Charge Visuals")]
		[SerializeField]
		private SpriteTrail trail; // 0x4A8
		[Header("Charge Warning")]
		[SerializeField]
		[Space]
		private float flashRepeatingInterval; // 0x4B0
		[Space]
		private VampireSurvivors.Framework.TimerSystem.Timer _warningFlashTimer; // 0x4B8
		private bool _toggleWarningColour; // 0x4C0
		private PhaserSprite _exclamationMark; // 0x4C8
		private MultiTargetTween _warningTween; // 0x4D0
		private List<Sprite> _asleepSprites; // 0x4D8
		private List<Sprite> _mainSprites; // 0x4E0
		private CoherenceSync _sync; // 0x4E8
	
		// Properties
		public bool IsLeavingMap { get => default; } // 0x00000001871DBC30-0x00000001871DBC40 
	
		// Nested types
		private enum Colossus_Mode_Types // TypeDefIndex: 17197
		{
			SETUP = 0,
			ASLEEP = 1,
			ROAMING = 2,
			ENRAGED = 3,
			POSITIONING = 4,
			WINDUP = 5,
			CHARGING = 6,
			LEAVING_MAP = 7
		}
	
		// Constructors
		public EX_Boss_Colossus() {} // 0x00000001871DE330-0x00000001871DE510
	
		// Methods
		protected override void Awake() {} // 0x00000001871DBC40-0x00000001871DBF40
		public override void InitEnemy(EnemyType enemyType, bool asRemote = false /* Metadata: 0x0197819B */) {} // 0x00000001871DBF40-0x00000001871DC1C0
		private void SetupLocationOfInterest() {} // 0x00000001871DC1C0-0x00000001871DC3A0
		protected override void OnUpdate() {} // 0x00000001871DC3A0-0x00000001871DCB60
		[Command]
		public void SetRoaming() {} // 0x00000001871DCB60-0x00000001871DCBC0
		[Command]
		public void SetLeavingMap() {} // 0x00000001871DCBC0-0x00000001871DCBD0
		public override void OnGetDamaged(HitVfxType showHitVfx, bool hasKb = true /* Metadata: 0x0197819C */) {} // 0x00000001871DCBD0-0x00000001871DCC10
		protected override void UpdateTileDestructionList() {} // 0x00000001871DCC10-0x00000001871DCC30
		private bool CheckHasReachedBottomOfMap() => default; // 0x00000001871DCC30-0x00000001871DCD40
		private void ChargingMovementBehaviour() {} // 0x00000001871DCD40-0x00000001871DCDF0
		private void StandardMovementBehaviour(Vector2 targetPosition, float speedModification = 1f /* Metadata: 0x0197819D */) {} // 0x00000001871DCDF0-0x00000001871DCFD0
		private void PositioningBehaviour() {} // 0x00000001871DCFD0-0x00000001871DD250
		private void WindUpBehaviour() {} // 0x00000001871DD250-0x00000001871DDBE0
		private void ChargeAtPlayer() {} // 0x00000001871DDBE0-0x00000001871DDEC0
		private void RestartMovement() {} // 0x00000001871DDEC0-0x00000001871DE010
		private void ToggleWarningTint() {} // 0x00000001871DE010-0x00000001871DE0F0
		private Vector2 AdjustedMarkPositionY(float x, float y) => default; // 0x00000001871DB4C0-0x00000001871DB510
		public override void Despawn() {} // 0x00000001871DE0F0-0x00000001871DE330
	}
}
