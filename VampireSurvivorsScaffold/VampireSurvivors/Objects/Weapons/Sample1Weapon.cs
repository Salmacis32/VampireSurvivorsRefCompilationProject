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
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Sample1Weapon : Weapon // TypeDefIndex: 16209
	{
		// Fields
		protected int _samplesAmount; // 0x158
		protected List<float2> screenGrid; // 0x160
		private ParticleEmitterManager _particlesManager; // 0x168
		private ParticleSystem _pfxEmitter; // 0x170
		private ParticleSystem _pfxEmitter2; // 0x178
		protected uint[] tints; // 0x180
		private float[] _randomOffsets; // 0x188
		private int _randomOffsetsIndex; // 0x190
	
		// Constructors
		public Sample1Weapon() {} // 0x0000000186F61A40-0x0000000186F61C60
	
		// Methods
		public override float SecondaryPPower() => default; // 0x0000000184E5D5E0-0x0000000184E5D600
		protected override void MakeLevelOne() {} // 0x0000000186F5EC80-0x0000000186F5EDA0
		protected override void OnStart() {} // 0x0000000186F5EDA0-0x0000000186F5EF90
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F5EF90-0x0000000186F5F2A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BBE */) {} // 0x0000000186F5F2A0-0x0000000186F5F560
		public void FireSample(Vector2 pos, int index, Transform target = null) {} // 0x0000000186F5F560-0x0000000186F5F7D0
		public void SpawnExplosionClustersAt(float2 pos) {} // 0x0000000186F5F7D0-0x0000000186F5FBA0
		public override Projectile SpawnExplosionAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977BBF */, int damage = 1 /* Metadata: 0x01977BC0 */, float area = 1f /* Metadata: 0x01977BC1 */) => default; // 0x0000000186F5FBA0-0x0000000186F5FFF0
		protected override bool OnBulletOverlapsPlayer(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F5FFF0-0x0000000186F60200
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F60200-0x0000000186F60430
		private void GenerateParticleSystems() {} // 0x0000000186F60430-0x0000000186F61A40
	}
}
