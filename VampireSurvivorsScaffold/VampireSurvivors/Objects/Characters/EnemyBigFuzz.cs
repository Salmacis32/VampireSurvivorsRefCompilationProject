/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters.Enemies;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	[DefaultExecutionOrder(1003)]
	public class EnemyBigFuzz : EnemyController // TypeDefIndex: 17191
	{
		// Fields
		private PhaserSprite _body; // 0x270
		private PhaserSprite _leftHand; // 0x278
		private PhaserSprite _rightHand; // 0x280
		private PhaserSprite _leftEye; // 0x288
		private PhaserSprite _rightEye; // 0x290
		private PhaserSprite _leftDoor; // 0x298
		private PhaserSprite _rightDoor; // 0x2A0
		private PhaserSprite _doorFrame; // 0x2A8
		private PhaserSprite _doorSpace; // 0x2B0
		private PhaserSprite _doorMask; // 0x2B8
		private PhaserSprite _laserChargingLeft; // 0x2C0
		private PhaserSprite _laserChargingRight; // 0x2C8
		private FightPhase _phase; // 0x2D0
		private float _doorOpenAmount; // 0x2D4
		private float _firebreathRotationDegrees; // 0x2D8
		private float _firebreathProjectileCooldown; // 0x2DC
		private List<Sprite> _explosionFrames; // 0x2E0
		private List<PhaserSprite> _explosionSprites; // 0x2E8
		private List<PhaserSprite> _readyExplosionSprites; // 0x2F0
		private float _explosionTimer; // 0x2F8
		private VampireSurvivors.Framework.TimerSystem.Timer _laserHeadShakeTimer; // 0x300
		private VampireSurvivors.Framework.TimerSystem.Timer _laserChargeTimer; // 0x308
		private VampireSurvivors.Framework.TimerSystem.Timer _laserFireTimer; // 0x310
		private VampireSurvivors.Framework.TimerSystem.Timer _fireHeadShakeTimer; // 0x318
		private VampireSurvivors.Framework.TimerSystem.Timer _fireChargeTimer; // 0x320
		private VampireSurvivors.Framework.TimerSystem.Timer _fireRotationTimer; // 0x328
		private VampireSurvivors.Framework.TimerSystem.Timer _postFireHeadShakeTimer; // 0x330
		private VampireSurvivors.Framework.TimerSystem.Timer _blinkTimer; // 0x338
		private float2 _battleCenter; // 0x340
		private float _scale; // 0x348
		private List<StageEdge> _stageEdges; // 0x350
		private List<float> _characterFallingTimers; // 0x358
		private bool _usePolygonEdges; // 0x360
		private float _shieldedDamage; // 0x364
		private int _cycleCount; // 0x368
		private List<EquipmentInfo> _removedEquipment; // 0x370
	
		// Properties
		private float _relativeScale { get => default; } // 0x00000001871C78E0-0x00000001871C7900 
		[Sync]
		public Vector2 BattleCenter { get => default; set {} } // 0x00000001871C79B0-0x00000001871C79D0 0x00000001871C79D0-0x00000001871C7A00
	
		// Nested types
		private enum FightPhase // TypeDefIndex: 17178
		{
			AnimatingIn = 0,
			ClawingIn = 1,
			OpeningDoors = 2,
			ShakingHeadPreLasers = 3,
			GunnaFireLaser = 4,
			DidFireLaser = 5,
			ShakingHeadPreFire = 6,
			FireBreathCharging = 7,
			FireBreathRotation = 8,
			ShakesSheadPostFire = 9,
			ClosingDoors = 10,
			Exploding = 11,
			ChoppingHead = 12,
			HeadFalling = 13,
			Finished = 14
		}
	
		// Constructors
		public EnemyBigFuzz() {} // 0x00000001871D2C30-0x00000001871D2DB0
	
		// Methods
		private void CancelTimers() {} // 0x00000001871C7900-0x00000001871C79B0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871C7A00-0x00000001871C95A0
		[IteratorStateMachine(typeof(_WaitForStartCameraTransition_d__44))]
		private IEnumerator WaitForStartCameraTransition(float2 mainPosition) => default; // 0x00000001871C95A0-0x00000001871C9660
		private void DoStartCameraTransition(float2 mainPosition) {} // 0x00000001871C9660-0x00000001871CA060
		private void CreateStageEdges(float newScale) {} // 0x00000001871CA060-0x00000001871CAE10
		private Polygon CreatePhaserSpacePolygon(List<float2> points, float localScale) => default; // 0x00000001871CAE10-0x00000001871CB170
		private void AddExplosionEffect(float2 position) {} // 0x00000001871CB170-0x00000001871CB640
		protected override void OnUpdate() {} // 0x00000001871CB640-0x00000001871CCA90
		private void InitFireball(EnemyFBBulletFireball fireball, Vector2 velocity) {} // 0x00000001871CCA90-0x00000001871CCC00
		private void SetDoorOpenAmount(float amount01) {} // 0x00000001871CCC00-0x00000001871CCE40
		private void StartSequence() {} // 0x00000001871CCE40-0x00000001871CD830
		private void StartClawingIn() {} // 0x00000001871CD830-0x00000001871CDC50
		private void OpenDoors(bool firstTime) {} // 0x00000001871CDC50-0x00000001871CE210
		private float2 GetEyePos(bool left) => default; // 0x00000001871CE210-0x00000001871CE2A0
		private float2 GetMouthPos() => default; // 0x00000001871CE2A0-0x00000001871CE2F0
		private void FireLasers() {} // 0x00000001871CE2F0-0x00000001871CE420
		private void StartPreFireShaking() {} // 0x00000001871CE420-0x00000001871CE520
		private void CloseDoors() {} // 0x00000001871CE520-0x00000001871CE8F0
		private void SpawnMines() {} // 0x00000001871CE8F0-0x00000001871CEBF0
		[Command]
		public void SpawnMinesOnline(Vector2 target, float startAngleOffset) {} // 0x00000001871CEBF0-0x00000001871CEC00
		private void SpawnMinesAtTarget(Vector2 toTarget, float startAngleOffset) {} // 0x00000001871CEC00-0x00000001871CF200
		private void SpawnMineToLocation(float2 location, int countdownTimer) {} // 0x00000001871CF200-0x00000001871CFDF0
		public void ScreenShake(int repeats = 6 /* Metadata: 0x01978175 */) {} // 0x00000001871CFDF0-0x00000001871D0320
		private void LateUpdate() {} // 0x00000001871D0320-0x00000001871D0490
		private void RunEdgeLogic() {} // 0x00000001871D0490-0x00000001871D1120
		protected override void OnDestroy() {} // 0x00000001871D1120-0x00000001871D1140
		public override void Despawn() {} // 0x00000001871D1140-0x00000001871D1160
		private void Clearup() {} // 0x00000001871D1160-0x00000001871D1460
		private void DestroyComponentGO(Component sprite) {} // 0x00000001871D1460-0x00000001871D1640
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978176 */, float damageKb = 1f /* Metadata: 0x01978177 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197817B */, bool hasKb = true /* Metadata: 0x0197817C */) {} // 0x00000001871D1640-0x00000001871D1C60
		private void RestoreBodyTint() {} // 0x00000001871D1C60-0x00000001871D1DF0
		protected override void Die() {} // 0x00000001871D1DF0-0x00000001871D1F10
		[Command]
		public void StartExplodingOnline() {} // 0x00000001871D1F10-0x00000001871D1F20
		private void StartExploding() {} // 0x00000001871D1F20-0x00000001871D23E0
		private void ChopHead() {} // 0x00000001871D23E0-0x00000001871D26C0
		private void HeadFallenOff() {} // 0x00000001871D26C0-0x00000001871D2A10
		private void ScheduleHighBrowGag() {} // 0x00000001871D2A10-0x00000001871D2BA0
		public void CleanupFromStage() {} // 0x00000001871D2BA0-0x00000001871D2C30
	}
}
