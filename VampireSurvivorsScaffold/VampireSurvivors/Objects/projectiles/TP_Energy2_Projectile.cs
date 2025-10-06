/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Energy2_Projectile : Projectile // TypeDefIndex: 15565
	{
		// Fields
		private TP_Energy2_Weapon _trueWeapon; // 0xD0
		private float _cachedArea; // 0xD8
		private bool _isBeamInfinite; // 0xDC
		private PhaserSprite _beamSprite; // 0xE0
		private PhaserSprite _shotSprite; // 0xE8
		private PhaserSprite _chargeSprite; // 0xF0
		private const float SpriteWidth = 120f; // Metadata: 0x019776D8
		private const float SpriteHeight = 25f; // Metadata: 0x019776DC
		private const int SpriteDepth = 5000; // Metadata: 0x019776E0
		private const int AnimFPS = 50; // Metadata: 0x019776E2
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _sfxTimer; // 0x108
		private const float SfxStartDuration = 600f; // Metadata: 0x019776E3
		private const float SfxLoopDuration = 400f; // Metadata: 0x019776E7
		private float SfxVolume; // 0x110
		private MultiTargetTween _scaleTween; // 0x118
		private MultiTargetTween _alphaTween; // 0x120
		private MultiTargetTween _chargeAlphaTween; // 0x128
		private MultiTargetTween _chargeScaleTween; // 0x130
		private const float ScaleTweenDuration = 200f; // Metadata: 0x019776EB
		private const float ChargeTweenDuration = 500f; // Metadata: 0x019776EF
		private bool _scaleInFinished; // 0x138
	
		// Constructors
		public TP_Energy2_Projectile() {} // 0x0000000186CA6C40-0x0000000186CA6C90
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA4B40-0x0000000186CA5130
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA5130-0x0000000186CA5DC0
		public override void InternalUpdate() {} // 0x0000000186CA5DC0-0x0000000186CA5E40
		private void StartExpireTimer() {} // 0x0000000186CA5E40-0x0000000186CA5F90
		private void UpdatePosition() {} // 0x0000000186CA5F90-0x0000000186CA6450
		private void StartHitboxTimer() {} // 0x0000000186CA6450-0x0000000186CA6620
		private void PlaySfxLoop() {} // 0x0000000186CA6620-0x0000000186CA67F0
		private void StopSfxLoop() {} // 0x0000000186CA67F0-0x0000000186CA6860
		private void StartDespawn() {} // 0x0000000186CA6860-0x0000000186CA6B00
		public override void Despawn() {} // 0x0000000186CA6B00-0x0000000186CA6C40
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
