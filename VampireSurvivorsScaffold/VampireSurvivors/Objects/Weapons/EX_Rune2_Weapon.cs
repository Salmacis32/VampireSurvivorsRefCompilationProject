/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EX_Rune2_Weapon : Weapon // TypeDefIndex: 16677
	{
		// Fields
		private ParticleEmitterManager _pfxManager; // 0x158
		private ParticleSystem _emitter1; // 0x160
		private ParticleSystem _emitter2; // 0x168
		private Circle _emitZone; // 0x170
		private GravityWell _well1; // 0x178
		private GravityWell _well2; // 0x180
		private ParticleSystem.MainModule _mainModule1; // 0x188
		private ParticleSystem.MainModule _mainModule2; // 0x190
		private float _angleValue; // 0x198
		private ParticleEmitterManager _fixedCircleManager; // 0x1A0
		private ParticleSystem _fixedCircleEmitter; // 0x1A8
		private Circle _circleEmitCircle; // 0x1B0
		private EmitZone _circleEmitZone; // 0x1B8
		private MultiTargetTween _singularityTween; // 0x1C0
		private float _singularityTime; // 0x1C8
		private bool _doingSingularity; // 0x1CC
		private MultiTargetTween _restoreTween; // 0x1D0
		private float _singularityTimes; // 0x1D8
		private bool _skipEmitUpdate; // 0x1DC
		private bool _hasBullets; // 0x1DD
		private MultiTargetTween _singularityExplosionTween; // 0x1E0
		private MultiTargetTween _screenShakeTween; // 0x1E8
		private EX_Rune2_SpinningProjectile _bulletA; // 0x1F0
		private EX_Rune2_SpinningProjectile _bulletB; // 0x1F8
		private bool _totalDamageCalculated; // 0x200
		[NonSerialized]
		public float Radius; // 0x204
		[NonSerialized]
		public float SingularityExplosionValue; // 0x208
		public int AccumulatedProjectiles; // 0x20C
		private int activations; // 0x210
		private ParticleSystem.Particle[] _activeParticles1; // 0x218
		private ParticleSystem.Particle[] _activeParticles2; // 0x220
		private float Lifetime1_Min; // 0x228
		private float Lifetime1_Max; // 0x22C
		private float Lifetime2_Min; // 0x230
		private float Lifetime2_Max; // 0x234
		[SerializeField]
		private Projectile _SpinningPrefab; // 0x238
		private BulletPool _spinningPool; // 0x240
		[SerializeField]
		private Projectile InvisProjectilePrefab; // 0x248
		private BulletPool InvisProjectilesPool; // 0x250
		private bool _playerControlled; // 0x258
	
		// Constructors
		public EX_Rune2_Weapon() {} // 0x000000018706DA40-0x000000018706DAC0
	
		// Methods
		protected override void Awake() {} // 0x00000001870669F0-0x00000001870685D0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870685D0-0x00000001870692E0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DC7 */) {} // 0x00000001870692E0-0x0000000187069B40
		public override void InternalUpdate() {} // 0x0000000187069B40-0x000000018706A7E0
		public override void Cleanup() {} // 0x000000018706A7E0-0x000000018706AA60
		protected virtual float SingularityPower() => default; // 0x000000018706AA60-0x000000018706AB40
		protected virtual float SingularityDelay() => default; // 0x000000018706AB40-0x000000018706ABB0
		private void InitBullets() {} // 0x000000018706ABB0-0x000000018706B180
		private void DoSingularity() {} // 0x000000018706B180-0x000000018706BFD0
		private void ExplodeSingularity() {} // 0x000000018706BFD0-0x000000018706CAA0
		protected override void OnStart() {} // 0x0000000186FE2450-0x0000000186FE2460
		private void ScreenShake() {} // 0x000000018706CAA0-0x000000018706D030
		public override void SetVisible(bool visible) {} // 0x000000018706D030-0x000000018706D3C0
		protected float StripLength() => default; // 0x0000000187064DC0-0x0000000187064E40
		private void FireStripAtEnemy(EnemyController enemy, int index, Vector2 startPosition, bool flipMyY = false /* Metadata: 0x01977DC8 */) {} // 0x000000018706D3C0-0x000000018706D900
		protected virtual bool OnBulletOverlapsEnemy_AllDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018706D900-0x000000018706DA40
	}
}
