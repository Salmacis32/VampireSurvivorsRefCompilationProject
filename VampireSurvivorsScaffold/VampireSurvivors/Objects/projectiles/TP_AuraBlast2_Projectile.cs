/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AuraBlast2_Projectile : Projectile // TypeDefIndex: 15503
	{
		// Fields
		private const float BodySizeX = 32f; // Metadata: 0x0197766B
		private const float BodySizeY = 80f; // Metadata: 0x0197766F
		private const float ScaleX = 20f; // Metadata: 0x01977673
		private const float HellfireBaseIntervalMS = 1500f; // Metadata: 0x01977677
		private const float VolcanoScale = 2f; // Metadata: 0x0197767B
		private const float VolcanoOffsetY = 0.6f; // Metadata: 0x0197767F
		private TP_AuraBlast2_Weapon _trueWeapon; // 0xD0
		private int _hellfireIndex; // 0xD8
		private PhaserSprite _volcanoSprite; // 0xE0
		private bool _initPfx; // 0xE8
		private bool _emitPfx; // 0xE9
		private ParticleEmitterManager _pfxManager; // 0xF0
		private ParticleSystem _pfxEmitter; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _volcanoTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _hitBoxTimer; // 0x110
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _hellfireTimer; // 0x120
	
		// Constructors
		public TP_AuraBlast2_Projectile() {} // 0x0000000186C6A6A0-0x0000000186C6A6F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C67670-0x0000000186C67D50
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C67D50-0x0000000186C68070
		private void ScaleIn() {} // 0x0000000186C68070-0x0000000186C68320
		private void StartTimers() {} // 0x0000000186C68320-0x0000000186C68590
		private void PlaySfx() {} // 0x0000000186C68590-0x0000000186C686C0
		private void InitVolcano() {} // 0x0000000186C686C0-0x0000000186C68AC0
		private void DoVolcanoShake() {} // 0x0000000186C68AC0-0x0000000186C69000
		private void FireHellfireProjectile() {} // 0x0000000186C69000-0x0000000186C691F0
		public override void InternalUpdate() {} // 0x0000000186C691F0-0x0000000186C69200
		private void UpdateParticles() {} // 0x0000000186C69200-0x0000000186C69450
		private void FadeOut() {} // 0x0000000186C69450-0x0000000186C69750
		public override void Despawn() {} // 0x0000000186C69750-0x0000000186C697F0
		private void GenerateParticleSystems() {} // 0x0000000186C697F0-0x0000000186C6A5B0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C6A5B0-0x0000000186C6A6A0
	}
}
