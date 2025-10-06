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
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Signals;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_Death : EnemyController // TypeDefIndex: 17248
	{
		// Fields
		private Transform _cameraTarget; // 0x270
		private PhaserSprite _deathMask; // 0x278
		private PhaserSprite _deathSpine; // 0x280
		private PhaserSprite _deathCape; // 0x288
		private Enemy_TP_DeathArm _leftHand; // 0x290
		private Enemy_TP_DeathArm _rightHand; // 0x298
		private PhaserSprite _leftCracks; // 0x2A0
		private PhaserSprite _rightCracks; // 0x2A8
		private MultiTargetTween _leftCracksTween; // 0x2B0
		private MultiTargetTween _rightCracksTween; // 0x2B8
		private MultiTargetTween _screenShakeTween; // 0x2C0
		private MultiTargetTween _droppedRelicTween; // 0x2C8
		private List<PhaserSprite> _leftArmSprites; // 0x2D0
		private List<PhaserSprite> _rightArmSprites; // 0x2D8
		private ParticleSystem _rockParticles; // 0x2E0
		private PhaserSprite _leftEye; // 0x2E8
		private PhaserSprite _rightEye; // 0x2F0
		private float _crawlTimer; // 0x2F8
		private float _scytheTimer; // 0x2FC
		private float _bigScytheTimer; // 0x300
		private float _bigScytheScreamTime; // 0x304
		private float _bigScythePostScreamThrowTime; // 0x308
		public Enemy_TP_DeathScytheBig _currentBigScythe; // 0x310
		private DeathFightDirecter _directer; // 0x318
		private bool _isDirecterDead; // 0x320
		private List<VampireSurvivors.Data.ItemType> _relicsToDrop; // 0x328
		private PickupRelic _droppedRelic; // 0x330
		private float _relicDropTimer; // 0x338
		private ParticleSystem _deathZoneParticles; // 0x340
		private bool _hasSpawnedAllies; // 0x34D
		private bool _havingAChat; // 0x34E
		private bool _canDie; // 0x34F
		private bool _sentDeathCommand; // 0x350
		private float _damageZoneTimer; // 0x354
		[NonSerialized]
		public List<VampireSurvivors.Data.CharacterType> _Allies; // 0x358
		[NonSerialized]
		public Dictionary<VampireSurvivors.Data.CharacterType, VampireSurvivors.Objects.Characters.CharacterController> _AlliesControllers; // 0x360
	
		// Properties
		public int DirecterRevivals { get; set; } // 0x0000000185EAA040-0x0000000185EAA050 0x0000000185EAA050-0x0000000185EAA060
		public bool HasRemovedWeapons { get; set; } // 0x00000001870EE7C0-0x00000001870EE7D0 0x00000001870EE7D0-0x00000001870EE7E0
		public bool HasSpawnedAllies { get => default; } // 0x0000000187204A70-0x0000000187204A80 
	
		// Constructors
		public Enemy_TP_Death() {} // 0x00000001872146C0-0x00000001872155A0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187204A80-0x0000000187205DA0
		[Command]
		public void OnBigScytheSpawned(CoherenceSync enemy) {} // 0x0000000187205DA0-0x0000000187205E50
		private void SetupParticles() {} // 0x0000000187205E50-0x0000000187207020
		public void StartSequence() {} // 0x0000000187207020-0x0000000187207650
		[Command]
		public void EndSequence() {} // 0x0000000187207650-0x0000000187207B50
		private void DestructionEffects() {} // 0x0000000187207B50-0x0000000187209080
		private void ActuallyRemove() {} // 0x0000000187209080-0x0000000187209470
		private void FadeOut() {} // 0x0000000187209470-0x00000001872099B0
		private void OnItemReceived(UISignals.ReceivedNewItemSignal signal) {} // 0x00000001872099B0-0x000000018720B3F0
		public void RunBlackDiskCutscene() {} // 0x000000018720B3F0-0x000000018720B4A0
		private void SwitchToCredits() {} // 0x000000018720B4A0-0x000000018720B6F0
		private void HandleUnlocksAtStart() {} // 0x000000018720B6F0-0x000000018720B980
		private void HandleUnlocksAtEnd() {} // 0x000000018720B980-0x000000018720C0D0
		protected override void Die() {} // 0x000000018720C0D0-0x000000018720C0E0
		public override void Disappear() {} // 0x000000018720C0D0-0x000000018720C0E0
		private void TriggerDeath() {} // 0x000000018720C0E0-0x000000018720C210
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782FD */, float damageKb = 1f /* Metadata: 0x019782FE */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978302 */, bool hasKb = true /* Metadata: 0x01978303 */) {} // 0x00000001871F3DE0-0x00000001871F3E00
		protected override void OnUpdate() {} // 0x000000018720C210-0x000000018720D630
		private void TriggerDirecterBlock() {} // 0x000000018720D630-0x000000018720D9F0
		[Command]
		public void CreateDamageZone(Vector2 spawnPositionOffset) {} // 0x000000018720D9F0-0x000000018720DC40
		private void SetupDamageZoneVisuals(Vector3 pos, DamageZoneFlexible zone) {} // 0x000000018720DC40-0x000000018720DEC0
		private void UpdateEyes() {} // 0x000000018720DEC0-0x000000018720E3B0
		private void UpdateCrawling() {} // 0x000000018720E3B0-0x000000018720F710
		private void UpdateSpriteTrail() {} // 0x000000018720F710-0x000000018720FC30
		private void UpdateDeathArea() {} // 0x000000018720FC30-0x0000000187210150
		private float GetArmPhase(float timer, float period, float offset01) => default; // 0x0000000187210150-0x0000000187210180
		private float FindNextJointT(float2 start, float2 end, float2 lastJointPos, float lastJointT, float desiredDistance, float iterationStep = -0.01f /* Metadata: 0x01978304 */) => default; // 0x0000000187210180-0x00000001872102D0
		private void UpdateArm(float phase01, float lastPhase01, float xOffset, float yOffset, float reachDistance, Enemy_TP_DeathArm arm, PhaserSprite crackSprite, List<PhaserSprite> armSprites) {} // 0x00000001872102D0-0x0000000187210B30
		private void UpdateJoints(Enemy_TP_DeathArm arm, float xOffset, List<PhaserSprite> armSprites, float extraScale) {} // 0x0000000187210B30-0x00000001872111E0
		private float2 ArmSample(float2 start, float2 end, float t) => default; // 0x00000001872111E0-0x0000000187211360
		private void Cleanup() {} // 0x0000000187211360-0x0000000187211FF0
		public void ScreenShake(int repeats = 6 /* Metadata: 0x01978308 */) {} // 0x0000000187211FF0-0x0000000187212550
		public void SummonDirecter() {} // 0x0000000187212550-0x00000001872129F0
		public bool HasDirecterBeenSummoned() => default; // 0x00000001872129F0-0x0000000187212AC0
		public bool IsDirecterDead() => default; // 0x0000000187212AC0-0x0000000187212AD0
		public void DirecterStartBlocking(Transform target, EnemyController toBlock) {} // 0x0000000187212AD0-0x0000000187212BD0
		public void DoBlockingAnimation() {} // 0x0000000187212BD0-0x0000000187212C90
		public void DirecterDied() {} // 0x0000000187212C90-0x0000000187212DA0
		private void DropNextRelic() {} // 0x0000000187212DA0-0x0000000187213200
		private void DoDropAnimation(PickupRelic pickup) {} // 0x0000000187213200-0x0000000187213980
		public void SpawnAllies() {} // 0x0000000187213980-0x0000000187213BC0
		private bool DoWeHaveThisAllyAlready(VampireSurvivors.Data.CharacterType type) => default; // 0x0000000187213BC0-0x0000000187213D50
		public void PreSpawnAllies() {} // 0x0000000187213D50-0x00000001872140F0
		[IteratorStateMachine(typeof(__SpawnAllies_d__89))]
		private IEnumerator _SpawnAllies() => default; // 0x00000001872140F0-0x0000000187214190
		private void SpawnAlly(VampireSurvivors.Data.CharacterType charType) {} // 0x0000000187214190-0x00000001872146C0
	}
}
