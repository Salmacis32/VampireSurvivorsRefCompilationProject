/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MechProjectile_CosmicRave : Projectile // TypeDefIndex: 15815
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _CloneSprite; // 0xD0
		[SerializeField]
		private SpriteRenderer _BackgroundSprite; // 0xD8
		[SerializeField]
		private TrailRenderer _Trail; // 0xE0
		private const float Radius = 16f; // Metadata: 0x0197789C
		private const float DecelRate = 2f; // Metadata: 0x019778A0
		private const float AccelRate = 5f; // Metadata: 0x019778A4
		private const float TrailWidth = 0.05f; // Metadata: 0x019778A8
		private float _cachedWeaponSpeed; // 0xE8
		private float _currentSpeed; // 0xEC
		private float _turnSpeed; // 0xF0
		private float _scaledTurnSpeed; // 0xF4
		private float _currentAngle; // 0xF8
		private bool _isDecelerating; // 0xFC
		private bool _isTurning; // 0xFD
		private bool _isAccelerating; // 0xFE
		private VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0x100
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x110
		private SpriteAnimation _cloneAnim; // 0x118
		private EME_Mech1Weapon _trueWeapon; // 0x120
		private MaterialPropertyBlock _propBlock; // 0x128
		private MultiTargetTween _tintTween; // 0x130
		private MultiTargetTween _scaleTween; // 0x138
		private List<uint> _tints; // 0x140
		private VampireSurvivors.Framework.TimerSystem.Timer _vfxTimer; // 0x148
		private bool _canVFX; // 0x150
	
		// Constructors
		public EME_MechProjectile_CosmicRave() {} // 0x0000000186DD0230-0x0000000186DD0740
	
		// Methods
		protected override void Awake() {} // 0x0000000186DCD060-0x0000000186DCD150
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DCD150-0x0000000186DCD630
		public override void InternalUpdate() {} // 0x0000000186DCD630-0x0000000186DCD8F0
		private void ApplyVelocityTowardsScreenCentre() {} // 0x0000000186DCD8F0-0x0000000186DCDCC0
		private void SetMovementPattern() {} // 0x0000000186DCDCC0-0x0000000186DCDF60
		private void UpdateVelocity() {} // 0x0000000186DCDF60-0x0000000186DCE260
		private void StartHitboxTimer() {} // 0x0000000186DCE260-0x0000000186DCE3C0
		private void StopHitboxTimer() {} // 0x0000000186DCE3C0-0x0000000186DCE3E0
		private void SetupCloneSprite() {} // 0x0000000186DCE3E0-0x0000000186DCE8B0
		private void UpdateCloneSprite() {} // 0x0000000186DCE8B0-0x0000000186DCEA60
		private void SetupTrail() {} // 0x0000000186DCEA60-0x0000000186DCEFA0
		private void UpdateTrail() {} // 0x0000000186DCEFA0-0x0000000186DCF0E0
		private void SetCloneTintFill() {} // 0x0000000186DCF0E0-0x0000000186DCF310
		private void DoBackgroundTintTween() {} // 0x0000000186DCF310-0x0000000186DCF6C0
		private void DoScaleInTween(float duration) {} // 0x0000000186DCF6C0-0x0000000186DCF980
		private void DoScaleOutTween() {} // 0x0000000186DCF980-0x0000000186DCFC30
		private void StartDespawn() {} // 0x0000000186DCFC30-0x0000000186DCFEE0
		public override void Despawn() {} // 0x0000000186DCFEE0-0x0000000186DCFF60
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DCFF60-0x0000000186DD0230
	}
}
