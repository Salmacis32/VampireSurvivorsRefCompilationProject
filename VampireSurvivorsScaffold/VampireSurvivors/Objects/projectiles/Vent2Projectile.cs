/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Vent2Projectile : Projectile // TypeDefIndex: 16000
	{
		// Fields
		private Vent2Weapon _trueWeapon; // 0xD0
		private bool _hasInitialisedGraphics; // 0xD8
		private TileSprite _stars; // 0xE0
		private float _starsWidthPixels; // 0xE8
		private float _doorThickness; // 0xEC
		private float _extendingTime; // 0xF0
		private float _openingTime; // 0xF4
		private float _closingTime; // 0xF8
		private float _retractingTime; // 0xFC
		private MultiTargetTween _tween1; // 0x100
		private MultiTargetTween _tween2; // 0x108
		private MultiTargetTween _tween3; // 0x110
		private MultiTargetTween _tween4; // 0x118
		private MultiTargetTween _tween5; // 0x120
		private MultiTargetTween _tween6; // 0x128
		private MultiTargetTween _tween7; // 0x130
		private MultiTargetTween _tween8; // 0x138
		private PhaserSprite _topDoor; // 0x140
		private PhaserSprite _topDoorCap; // 0x148
		private PhaserSprite _bottomDoor; // 0x150
		private PhaserSprite _bottomDoorCap; // 0x158
		private ParticleEmitterManager _suckParticleManager; // 0x160
		private ParticleSystem _suckParticles; // 0x168
		private GravityWell _suckParticleWell; // 0x170
		public float _currentSuckLevel; // 0x178
		private bool _xFlip; // 0x17C
		private bool _shouldStopASAP; // 0x17D
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxDelayTimer; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _mainSuckingTimer; // 0x188
		private bool _firstFiring; // 0x190
		private HashSet<IDamageable> _objectsSucked; // 0x198
	
		// Constructors
		public Vent2Projectile() {} // 0x0000000186EA7220-0x0000000186EA7350
	
		// Methods
		private float ExtraneousAnimationTimeMultiplier() => default; // 0x0000000186EA1C70-0x0000000186EA1CC0
		private float BaseDoorHeight() => default; // 0x0000000186EA1CC0-0x0000000186EA1D50
		private float CapHeight() => default; // 0x0000000186EA1D50-0x0000000186EA1D80
		protected override void Awake() {} // 0x0000000186EA1D80-0x0000000186EA1E20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186EA1E20-0x0000000186EA29D0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186EA29D0-0x0000000186EA2A70
		[IteratorStateMachine(typeof(_SpawnParticles_d__37))]
		private IEnumerator SpawnParticles() => default; // 0x0000000186EA2A70-0x0000000186EA2B10
		private void StartSucking() {} // 0x0000000186EA2B10-0x0000000186EA2DC0
		private void ReturnToNormal() {} // 0x0000000186EA2DC0-0x0000000186EA3750
		private void DisplayKillCount() {} // 0x0000000186EA3750-0x0000000186EA3910
		[IteratorStateMachine(typeof(_AnimateKillCounter_d__41))]
		private IEnumerator AnimateKillCounter(int objectsSucked) => default; // 0x0000000186EA3910-0x0000000186EA39C0
		private void InitialiseGraphics() {} // 0x0000000186EA39C0-0x0000000186EA5990
		public override void Despawn() {} // 0x0000000186EA5990-0x0000000186EA5A30
		private void CleanupTweens() {} // 0x0000000186EA5A30-0x0000000186EA5AE0
		protected override void OnDestroy() {} // 0x0000000186EA5AE0-0x0000000186EA5B60
		private void Cleanup() {} // 0x0000000186EA5B60-0x0000000186EA6680
		private void UpdateParticleSuck() {} // 0x0000000186EA6680-0x0000000186EA6830
		private void LateUpdate() {} // 0x0000000186EA6830-0x0000000186EA70D0
		public void TryStoppingEarly() {} // 0x0000000186EA70D0-0x0000000186EA7220
	}
}
