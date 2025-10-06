/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLegion : EnemyController // TypeDefIndex: 17238
	{
		// Fields
		private LegionBossPhase _phase; // 0x270
		private ArcadeRect _activationRect; // 0x274
		private List<EnemyLegionSection> _sections; // 0x288
		private float _colourLerp; // 0x290
		private float _colourLerpSpeed; // 0x294
		private float2 _spawnLocation; // 0x298
		private float2 _floorPosition; // 0x2A0
		private float2 _startPosition; // 0x2A8
		private float _movementTimer; // 0x2B0
		private float _spawnTimer; // 0x2B4
		private List<EnemyLegionZombie> _zombieList; // 0x2B8
		private List<Tentacle> _tentacles; // 0x2C0
		private MultiTargetTween _activationTween; // 0x2C8
		public float _timeUntilSectionsVulnerable; // 0x2D0
	
		// Properties
		public LegionBossPhase Phase { get => default; } // 0x00000001871F7140-0x00000001871F7150 
		public float FloorHeight { get => default; } // 0x00000001871F7150-0x00000001871F7160 
	
		// Nested types
		public enum LegionBossPhase // TypeDefIndex: 17231
		{
			Unactivated = 0,
			Activating = 1,
			Normal = 2,
			Spewing = 3,
			Dying = 4,
			Dead = 5
		}
	
		private class Tentacle // TypeDefIndex: 17232
		{
			// Fields
			public PhaserSprite _arm; // 0x10
			public PhaserSprite _head; // 0x18
			public float _aimCounter; // 0x20
			public float _chargeCounter; // 0x24
			public bool _isFiring; // 0x28
			public PhaserSprite _laser; // 0x30
			public PhaserSprite _laserCap; // 0x38
	
			// Constructors
			public Tentacle() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public EnemyLegion() {} // 0x00000001871FE720-0x00000001871FE780
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871F7160-0x00000001871F7A90
		private void InstantiateSections() {} // 0x00000001871F7A90-0x00000001871F7D10
		private void SetupTentacles() {} // 0x00000001871F7D10-0x00000001871F86F0
		private void UpdateTentacles() {} // 0x00000001871F86F0-0x00000001871F9190
		private bool IsMiddleSectionDead() => default; // 0x00000001871F9190-0x00000001871F93A0
		[Command]
		public void ChangeTentacleHeadFrame(int tentacleIndex, string spriteName, string textureName, bool isFiring, bool stopFiring) {} // 0x00000001871F93A0-0x00000001871F94E0
		[Command]
		public void FireTentacleLaser(int tentacleIndex) {} // 0x00000001871F94E0-0x00000001871F9DF0
		private void SpawnZombies() {} // 0x00000001871F9DF0-0x00000001871FA260
		private void SpawnZombie(float2 position) {} // 0x00000001871FA260-0x00000001871FA5B0
		public List<EnemyLegionSection> GetSections() => default; // 0x00000001871FA5B0-0x00000001871FA5C0
		public override void Despawn() {} // 0x00000001871FA5C0-0x00000001871FA820
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782DD */, float damageKb = 1f /* Metadata: 0x019782DE */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782E2 */, bool hasKb = true /* Metadata: 0x019782E3 */) {} // 0x00000001871FA820-0x00000001871FAA90
		public override void Disappear() {} // 0x00000001871FAA90-0x00000001871FAAB0
		protected override void Die() {} // 0x00000001871FAA90-0x00000001871FAAB0
		private void DoDeathAnimation() {} // 0x00000001871FAAB0-0x00000001871FC9E0
		private void DropReward() {} // 0x00000001871FC9E0-0x00000001871FD0E0
		protected override void OnUpdate() {} // 0x00000001871FD0E0-0x00000001871FDB90
		private void Activate() {} // 0x00000001871FDB90-0x00000001871FDF70
		private void ActivationFinish() {} // 0x00000001871FDF70-0x00000001871FE1F0
		public void ScreenShake(int repeats = 6 /* Metadata: 0x019782E4 */) {} // 0x00000001871FE1F0-0x00000001871FE720
	}
}
