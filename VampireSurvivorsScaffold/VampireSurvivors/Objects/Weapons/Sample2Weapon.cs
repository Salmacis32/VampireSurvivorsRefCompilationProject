/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Sample2Weapon : Weapon // TypeDefIndex: 16213
	{
		// Fields
		protected int _samplesAmount; // 0x158
		private ParticleSystem _pfxSnowEmitter; // 0x160
		protected List<float2> screenGrid; // 0x168
		private ParticleEmitterManager _particlesManager; // 0x170
		private ParticleSystem _pfxEmitter; // 0x178
		private ParticleSystem _pfxEmitter2; // 0x180
		protected uint[] tints; // 0x188
		protected bool _triggerReactor; // 0x190
		protected PhaserSprite _reactorSprite; // 0x198
		protected PhaserSprite _reactorHideCrimesSprite; // 0x1A0
		public float reactorSpriteOffsetY; // 0x1A8
		protected BulletPool _reactorPool; // 0x1B0
		public Projectile reactorPrefab; // 0x1B8
		protected float2 centrePos; // 0x1C0
		protected MultiTargetTween _moveReactorTween; // 0x1C8
		protected VampireSurvivors.Framework.TimerSystem.Timer _completeTimer; // 0x1D0
		private int lastIndex; // 0x1D8
		private int sequenceCounter; // 0x1DC
		private float[] _randomOffsets; // 0x1E0
		private int _randomOffsetsIndex; // 0x1E8
	
		// Constructors
		public Sample2Weapon() {} // 0x0000000186F667A0-0x0000000186F669E0
	
		// Methods
		public override float PPower() => default; // 0x0000000186F61EB0-0x0000000186F61F50
		public override float SecondaryPPower() => default; // 0x0000000186F61F50-0x0000000186F61FD0
		protected override void MakeLevelOne() {} // 0x0000000186F61FD0-0x0000000186F620F0
		protected override void OnStart() {} // 0x0000000186F620F0-0x0000000186F622E0
		public virtual void MakeReactor() {} // 0x0000000186F622E0-0x0000000186F62BB0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F62BB0-0x0000000186F62F60
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BC5 */) {} // 0x0000000186F62F60-0x0000000186F63520
		protected virtual void fireSample(int sampleInt, float2 position, float flashDelay, float activationDelay) {} // 0x0000000186F63520-0x0000000186F63780
		public void InputSequence(int index) {} // 0x0000000186F63780-0x0000000186F63950
		protected void startReactor() {} // 0x0000000186F63950-0x0000000186F63E70
		public void hideReactor() {} // 0x0000000186F63E70-0x0000000186F64290
		public void completeReactor() {} // 0x0000000186F64290-0x0000000186F642C0
		protected virtual void LateUpdate() {} // 0x0000000186F642C0-0x0000000186F64410
		public void SpawnExplosionClustersAt(float2 pos) {} // 0x0000000186F64410-0x0000000186F647E0
		public override Projectile SpawnExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977BC6 */, int damage = 1 /* Metadata: 0x01977BC7 */, float area = 1f /* Metadata: 0x01977BC8 */) => default; // 0x0000000186F647E0-0x0000000186F64C30
		protected override bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F64C30-0x0000000186F64E40
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F64E40-0x0000000186F65070
		public override void Cleanup() {} // 0x0000000186F65070-0x0000000186F65190
		private void GenerateParticleSystems() {} // 0x0000000186F65190-0x0000000186F667A0
	}
}
