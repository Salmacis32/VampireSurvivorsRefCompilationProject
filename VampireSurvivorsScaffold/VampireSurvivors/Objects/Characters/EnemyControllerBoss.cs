/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EnemyControllerBoss : EnemyController // TypeDefIndex: 17166
	{
		// Fields
		[SerializeField]
		protected bool bossSpawnsBullets; // 0x270
		[SerializeField]
		protected float bulletSpawnInterval; // 0x274
		[SerializeField]
		protected bool bulletSpawnLooping; // 0x278
		[SerializeField]
		protected EnemyType bulletType; // 0x27C
		protected VampireSurvivors.Framework.TimerSystem.Timer BulletSpawnTimer; // 0x280
		[SerializeField]
		protected bool bossSpawnsMinions; // 0x288
		[SerializeField]
		protected float minionSpawnInterval; // 0x28C
		[SerializeField]
		protected int minionSpawnAmount; // 0x290
		[SerializeField]
		protected bool minionSpawnLooping; // 0x294
		[SerializeField]
		protected EnemyType minionType; // 0x298
		protected VampireSurvivors.Framework.TimerSystem.Timer MinionSpawnTimer; // 0x2A0
		[SerializeField]
		protected bool bossSpawnsMinionsOnDeath; // 0x2A8
		[SerializeField]
		protected int minionSpawnOnDeathAmount; // 0x2AC
		[SerializeField]
		protected EnemyType minionOnDeathType; // 0x2B0
		[SerializeField]
		protected bool bossSpawnsSwarms; // 0x2B4
		[SerializeField]
		protected float swarmSpawnInterval; // 0x2B8
		[SerializeField]
		protected bool swarmSpawnLooping; // 0x2BC
		[SerializeField]
		protected EnemyType swarmType; // 0x2C0
		[SerializeField]
		protected float swarmSpawnDelay; // 0x2C4
		[SerializeField]
		protected int swarmRepeatAmount; // 0x2C8
		[SerializeField]
		protected float swarmDistance; // 0x2CC
		protected VampireSurvivors.Framework.TimerSystem.Timer SwarmSpawnTimer; // 0x2D0
		[SerializeField]
		protected bool bossSpawnsWave; // 0x2D8
		[SerializeField]
		protected float waveSpawnInterval; // 0x2DC
		[SerializeField]
		protected bool waveSpawnLooping; // 0x2E0
		[SerializeField]
		protected EnemyType waveType; // 0x2E4
		[SerializeField]
		protected float waveSpawnDuration; // 0x2E8
		[SerializeField]
		protected int waveAmount; // 0x2EC
		protected VampireSurvivors.Framework.TimerSystem.Timer WaveSpawnTimer; // 0x2F0
		[SerializeField]
		protected bool bossSpawnsCircle; // 0x2F8
		[SerializeField]
		protected bool spawnCircleInstant; // 0x2F9
		[SerializeField]
		protected float circleSpawnInterval; // 0x2FC
		[SerializeField]
		protected bool circleSpawnLooping; // 0x300
		[SerializeField]
		protected float circleDuration; // 0x304
		[SerializeField]
		protected EnemyType circleEnemy; // 0x308
		[SerializeField]
		protected int circleEnemyAmount; // 0x30C
		[SerializeField]
		protected float circleDiameter; // 0x310
		protected VampireSurvivors.Framework.TimerSystem.Timer CircleSpawnTimer; // 0x318
		protected VampireSurvivors.Framework.TimerSystem.Timer CircleInstantSpawnTimer; // 0x320
		[SerializeField]
		protected bool bossHasDamageZones; // 0x328
		[SerializeField]
		private bool sequentialZoneSpawns; // 0x329
		[SerializeField]
		private List<DamagingZonePrefab> damagingZones; // 0x330
		[Header("Rewards")]
		[SerializeField]
		private WeaponType _weaponToDrop; // 0x338
		[SerializeField]
		private bool _hasTreasureChest; // 0x33C
		[SerializeField]
		private List<float> _treasureChances; // 0x340
		[Header("Death VFX")]
		[SerializeField]
		private bool _playRingDeathVfx; // 0x348
		[SerializeField]
		private bool _playPosterDeathVfx; // 0x349
		[SerializeField]
		private bool _playFireballDeath; // 0x34A
		private List<float> _zoneTimers; // 0x350
		private List<float> _zoneRespawnTimers; // 0x358
		private float _sequentialRespawnTimer; // 0x360
		private int _currentZoneIndex; // 0x364
		private int _zoneLongestRespawner; // 0x368
		private readonly List<PrizeType?> _treasurePrizeTypes; // 0x370
		private bool _hasDroppedTreasure; // 0x378
		private SpriteRenderer _ringSprite; // 0x380
		private MultiTargetTween _deathVfxRingTween; // 0x388
		private SpriteRenderer _posterSprite; // 0x390
		private SpriteMask _posterMask; // 0x398
		private Tween _posterTween; // 0x3A0
		private bool _isRunningDeathAnimation; // 0x3A8
		private ParticleSystem _deathVfxParticleSystem1; // 0x3B0
		private ParticleSystem _deathVfxParticleSystem2; // 0x3B8
		private VampireSurvivors.Framework.TimerSystem.Timer _deathAnimTimer; // 0x3C0
		protected MultiTargetTween _deathScaleTween; // 0x3C8
		private VampireSurvivors.Framework.TimerSystem.Timer exploTimer1; // 0x3D0
		private VampireSurvivors.Framework.TimerSystem.Timer exploTimer2; // 0x3D8
		private VampireSurvivors.Framework.TimerSystem.Timer deathTimer1; // 0x3E0
		private VampireSurvivors.Framework.TimerSystem.Timer deathTimer2; // 0x3E8
		protected uint _damagingZoneSeed; // 0x3F0
		private const string VfxTextureName = "vfx"; // Metadata: 0x01978159
		private const string PosterSpriteName = "CirclePoster01"; // Metadata: 0x0197815D
	
		// Properties
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint DamagingZoneSeed { get => default; set {} } // 0x0000000187106AD0-0x0000000187106AE0 0x0000000187106AE0-0x0000000187106AF0
	
		// Constructors
		public EnemyControllerBoss() {} // 0x0000000187199360-0x0000000187199A20
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187194600-0x00000001871946B0
		protected override void OnUpdate() {} // 0x00000001871946B0-0x00000001871946E0
		protected virtual void InitSpawnBossBullets() {} // 0x00000001871946E0-0x0000000187194800
		protected virtual void InitSpawnBossMinions() {} // 0x0000000187194800-0x0000000187194930
		protected virtual void InitSpawnBossSwarm() {} // 0x0000000187194930-0x0000000187194A50
		protected virtual void InitSpawnBossCircle() {} // 0x0000000187194A50-0x0000000187194C60
		protected virtual void InitSpawnWaveEvent() {} // 0x0000000187194C60-0x0000000187194D80
		protected virtual void InitSpawnDamageZones(bool asRemote) {} // 0x0000000187194D80-0x0000000187195170
		private void InitDeathVfx() {} // 0x0000000187195170-0x0000000187195DA0
		protected virtual void SpawnBossBullets() {} // 0x0000000187195DA0-0x0000000187195E80
		protected virtual void SpawnBossMinions(EnemyType type, int spawnAmount) {} // 0x0000000187195E80-0x00000001871960E0
		private static void ScaleSpawnedEnemy(EnemyController spawned) {} // 0x00000001871960E0-0x0000000187196320
		protected virtual void SpawnBossSwarms() {} // 0x0000000187196320-0x0000000187196410
		protected virtual void SpawnBossWave() {} // 0x0000000187196410-0x0000000187196500
		protected virtual void SpawnBossCircle() {} // 0x0000000187196500-0x0000000187196600
		protected virtual void UpdateSpawnDamageZones() {} // 0x0000000187196600-0x0000000187196A50
		protected override void Die() {} // 0x0000000187196A50-0x0000000187196C20
		private void DropTreasure() {} // 0x0000000187196C20-0x0000000187196EA0
		private void DropWeapon() {} // 0x0000000187196EA0-0x0000000187197010
		private void PlayDeathVfx() {} // 0x0000000187197010-0x00000001871976E0
		protected virtual void DoDeathAnimation() {} // 0x00000001871976E0-0x0000000187198C20
		private void PlayPosterAnimation(Transform t) {} // 0x0000000187198C20-0x00000001871992D0
		public override void Despawn() {} // 0x00000001871992D0-0x0000000187199360
	}
}
