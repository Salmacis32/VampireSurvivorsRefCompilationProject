/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using QFSW.MOP2;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDirecter : EnemyController // TypeDefIndex: 17308
	{
		// Fields
		private MultiTargetTween _onEnterTween; // 0x280
		private bool _isInvul; // 0x288
		public float _Radius1; // 0x28C
		public float _Radius2; // 0x290
		public float _Radius3; // 0x294
		public float _Radius4; // 0x298
		public float _Radius5; // 0x29C
		public float _Radius6; // 0x2A0
		public float _Radius7; // 0x2A4
		private float _myAngle1; // 0x2A8
		private float _myAngle2; // 0x2AC
		private float _myAngle3; // 0x2B0
		private float _myAngle4; // 0x2B4
		private float _myAngle5; // 0x2B8
		private float _myAngle6; // 0x2BC
		private float _myAngle7; // 0x2C0
		private EnemyDMask _eye1; // 0x2C8
		private EnemyDMask _eye2; // 0x2D0
		private EnemyDMask _eye3; // 0x2D8
		private EnemyDMask _eye4; // 0x2E0
		private EnemyDMask _eye5; // 0x2E8
		private EnemyDMask _eye6; // 0x2F0
		private EnemyDMask _eye7; // 0x2F8
		private bool _spawnedMasks; // 0x300
		private TileSprite _stars1; // 0x308
		private TileSprite _stars2; // 0x310
		private PhaserSprite _LeftHand; // 0x318
		private PhaserSprite _RightHand; // 0x320
		public float _scale1; // 0x328
		public float _scale2; // 0x32C
		public float _scale3; // 0x330
		public float _scale4; // 0x334
		public float _scale5; // 0x338
		public float _scale6; // 0x33C
		public float _scale7; // 0x340
		private int _currentPhase; // 0x344
		public float _xOffset; // 0x348
		private MultiTargetTween _moveTween0; // 0x350
		public float _yOffset; // 0x358
		private float _breakTimer; // 0x35C
		private float _breakDelay; // 0x360
		private MultiTargetTween _moveTween3; // 0x368
		private MultiTargetTween _moveTween4; // 0x370
		private ShootingEyesManager _shootingEyesManager; // 0x378
		private float _attacksDurationMultiplier; // 0x380
		private float _attackDelay; // 0x384
		private float _attackTimer; // 0x388
		private int _attack1Index; // 0x38C
		private int _attack2Index; // 0x390
		private int _attack3Index; // 0x394
		private int _attack4Index; // 0x398
		private float _angleUnit; // 0x3B0
		private ObjectPool _explosionPool; // 0x3B8
		private SpriteMask _spriteMask; // 0x3C0
		private List<MultiTargetTween> _allTweens; // 0x3C8
		private float _movement0StartingOffset; // 0x3D0
		private float _movement0TargetOffset; // 0x3D4
		private float _movement3StartingOffset; // 0x3D8
		private float _movement3TargetOffset; // 0x3DC
		private float _movement4StartingOffset; // 0x3E0
		private float _movement4TargetOffset; // 0x3E4
	
		// Properties
		[Sync]
		public CoherenceSync Eye1 { get => default; set {} } // 0x000000018724A7D0-0x000000018724A8D0 0x000000018724A8D0-0x000000018724AAA0
		[Sync]
		public CoherenceSync Eye2 { get => default; set {} } // 0x000000018724AAA0-0x000000018724ABA0 0x000000018724ABA0-0x000000018724AD70
		[Sync]
		public CoherenceSync Eye3 { get => default; set {} } // 0x000000018724AD70-0x000000018724AE70 0x000000018724AE70-0x000000018724B040
		[Sync]
		public CoherenceSync Eye4 { get => default; set {} } // 0x000000018724B040-0x000000018724B140 0x000000018724B140-0x000000018724B310
		[Sync]
		public CoherenceSync Eye5 { get => default; set {} } // 0x000000018724B310-0x000000018724B410 0x000000018724B410-0x000000018724B5E0
		[Sync]
		public CoherenceSync Eye6 { get => default; set {} } // 0x000000018724B5E0-0x000000018724B6E0 0x000000018724B6E0-0x000000018724B8B0
		[Sync]
		public CoherenceSync Eye7 { get => default; set {} } // 0x000000018724B8B0-0x000000018724B9B0 0x000000018724B9B0-0x000000018724BB80
		public int StageIndex { get; set; } // 0x00000001871F7140-0x00000001871F7150 0x000000018724BB80-0x000000018724BB90
		public int BrokenMasks { get; set; } // 0x000000018724BB90-0x000000018724BBA0 0x000000018724BBA0-0x000000018724BBB0
		public bool BreakEnabled { get; set; } // 0x000000018724BBB0-0x000000018724BBC0 0x000000018724BBC0-0x000000018724BBD0
		private float TotalDamage { get; set; } // 0x000000018724BBD0-0x000000018724BBE0 0x000000018724BBE0-0x000000018724BBF0
		private int DirectHits { get; set; } // 0x000000018724BBF0-0x000000018724BC00 0x000000018724BC00-0x000000018724BC10
		private bool HasHands { get; set; } // 0x00000001870EF290-0x00000001870EF2A0 0x00000001870EF2A0-0x00000001870EF2B0
		private PhaserSprite WhiteHand { get; set; } // 0x000000018724BC10-0x000000018724BC20 0x000000018724BC20-0x000000018724BC80
	
		// Constructors
		public EnemyDirecter() {} // 0x00000001872591D0-0x0000000187259250
	
		// Methods
		private void MakeHandAnimations() {} // 0x000000018724BC80-0x000000018724C770
		protected override void Awake() {} // 0x000000018724C770-0x000000018724DF90
		private void MakeMasks() {} // 0x000000018724DF90-0x000000018724E710
		private void MakeSkulls() {} // 0x000000018724E710-0x000000018724F440
		private void DisappearEyes() {} // 0x000000018724F440-0x000000018724F590
		private void MakeTreasures() {} // 0x000000018724F590-0x000000018724FD10
		private void Shrink() {} // 0x000000018724FD10-0x0000000187250310
		private void SetupMovementTargetOffsetValues() {} // 0x0000000187250310-0x00000001872505A0
		private void Movement_Behaviour0(float deltaTime) {} // 0x00000001872505A0-0x0000000187250B40
		private void Movement_Behaviour3(float deltaTime) {} // 0x0000000187250B40-0x0000000187251150
		private void Movement_Behaviour4(float deltaTime) {} // 0x0000000187251150-0x0000000187251760
		private void CheckAttack() {} // 0x0000000187251760-0x0000000187251D20
		private void TriggerAttackBehaviour(Action singlePlayerTrigger, Action<long> onlineTrigger) {} // 0x0000000187251D20-0x0000000187251E60
		private void Attack_Behaviour0() {} // 0x0000000187251E60-0x0000000187252010
		private void Attack_Behaviour1() {} // 0x0000000187252010-0x00000001872520E0
		[Command]
		public void OnlineAttackBehaviour1(long startingSimFrame) {} // 0x00000001872520E0-0x00000001872521C0
		private void PerformAttackBehaviour1() {} // 0x00000001872521C0-0x0000000187252590
		private void Attack_Behaviour2() {} // 0x0000000187252590-0x0000000187252660
		[Command]
		public void OnlineAttackBehaviour2(long startingSimFrame) {} // 0x0000000187252660-0x0000000187252740
		private void PerformAttackBehaviour2() {} // 0x0000000187252740-0x0000000187252E40
		private void Attack_Behaviour3() {} // 0x0000000187252E40-0x0000000187253000
		[Command]
		public void OnlineAttackBehaviour3(long startingSimFrame, int rnd) {} // 0x0000000187253000-0x0000000187253160
		private void PerformAttackBehaviour3(int rnd) {} // 0x0000000187253160-0x0000000187253410
		private void DamagingZone_Explosions(float yOffset = 0f /* Metadata: 0x0197840E */, bool follow = false /* Metadata: 0x01978412 */, float duration = 10000f /* Metadata: 0x01978413 */) {} // 0x0000000187253410-0x0000000187253780
		private void Attack_Behaviour4() {} // 0x0000000187253780-0x0000000187253850
		[Command]
		public void OnlineAttackBehaviour4(long startingSimFrame) {} // 0x0000000187253850-0x0000000187253930
		private void PerformAttackBehaviour4() {} // 0x0000000187253930-0x0000000187254060
		public void TriggerPhase1() {} // 0x0000000187254060-0x0000000187254130
		[Command]
		public void OnlineTriggerPhase1(long startingSimFrame) {} // 0x0000000187254130-0x0000000187254210
		private void TriggerPhase1OnClient() {} // 0x0000000187254210-0x0000000187254320
		public void TriggerPhase2() {} // 0x0000000187254320-0x00000001872543F0
		[Command]
		public void OnlineTriggerPhase2(long startingSimFrame) {} // 0x00000001872543F0-0x00000001872544D0
		private void TriggerPhase2OnClient() {} // 0x00000001872544D0-0x00000001872547F0
		private void TriggerPhase(Action singlePlayerTrigger, Action<long> onlineTrigger) {} // 0x00000001872547F0-0x0000000187254930
		private void AutoPositionHands() {} // 0x0000000187254930-0x0000000187254F50
		public void MakeMasksBreakable() {} // 0x0000000187254F50-0x0000000187255090
		public void OnMaskBroken(EnemyDMask mask) {} // 0x0000000187255090-0x00000001872551F0
		[Command]
		public void OnMaskBrokenOnline(long startingSimFrame, CoherenceSync mask) {} // 0x00000001872551F0-0x00000001872553A0
		private void PerformMaskBroken(EnemyDMask mask) {} // 0x00000001872553A0-0x0000000187255570
		private void OnFreezeFinished() {} // 0x0000000187255570-0x0000000187255770
		public void TriggerPhase3() {} // 0x0000000187255770-0x0000000187255840
		[Command]
		public void OnlineTriggerPhase3(long startingSimFrame) {} // 0x0000000187255840-0x0000000187255920
		private void TriggerPhase3OnClient() {} // 0x0000000187255920-0x0000000187255BB0
		public void TriggerPhase4() {} // 0x0000000187255BB0-0x0000000187255C80
		[Command]
		public void OnlineTriggerPhase4(long startingSimFrame) {} // 0x0000000187255C80-0x0000000187255D60
		private void TriggerPhase4OnClient() {} // 0x0000000187255D60-0x0000000187255DF0
		public void TriggerPhase5() {} // 0x0000000187255DF0-0x0000000187255EC0
		[Command]
		public void OnlineTriggerPhase5(long startingSimFrame) {} // 0x0000000187255EC0-0x0000000187255FA0
		private void TriggerPhase5OnClient() {} // 0x0000000187255FA0-0x0000000187256020
		private void ThrowEggR(float x, float y) {} // 0x0000000187256020-0x0000000187256230
		private void ThrowEggL(float x, float y) {} // 0x0000000187256230-0x0000000187256440
		protected override void OnUpdate() {} // 0x0000000187256440-0x0000000187256B10
		private void UpdateEye(EnemyDMask eye, float2 playerPos, float scale, float angle1, float angle2, float radius) {} // 0x0000000187256B10-0x0000000187256CB0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187256CB0-0x0000000187257520
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978417 */, float damageKb = 1f /* Metadata: 0x01978418 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197841C */, bool hasKb = true /* Metadata: 0x0197841D */) {} // 0x0000000187257520-0x00000001872576F0
		private void MakeStars() {} // 0x00000001872576F0-0x00000001872581D0
		protected override void Die() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Disappear() {} // 0x0000000180B15170-0x0000000180B15180
		private float Approach(float start, float end, float shift) => default; // 0x0000000186BD8F50-0x0000000186BD8F70
		private void ShootEyes(int times, float delay, float radiusMul = 1f /* Metadata: 0x0197841E */) {} // 0x00000001872581D0-0x00000001872583B0
		private void MakeWhiteHand() {} // 0x00000001872583B0-0x00000001872587C0
		private void DragInWhiteHand() {} // 0x00000001872587C0-0x00000001872591D0
	}
}
