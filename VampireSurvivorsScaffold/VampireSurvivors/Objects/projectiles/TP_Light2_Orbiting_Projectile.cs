/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Light2_Orbiting_Projectile : Projectile // TypeDefIndex: 15613
	{
		// Fields
		[SerializeField]
		protected TrailRenderer _LightTrail; // 0xD0
		private float _orbitRadius; // 0xD8
		private float _bodyRadius; // 0xDC
		private MultiTargetTween _scaleTween; // 0xE0
		protected MultiTargetTween _fadeInTrailTween; // 0xE8
		private bool _isLight; // 0xF0
		private float _waveAngle1; // 0xF4
		private float _waveAngle2; // 0xF8
		protected Sprite _cachedLightSprite; // 0x100
		protected PhaserSprite _animatedSprite; // 0x108
		protected PhaserSprite _glowSprite; // 0x110
	
		// Constructors
		public TP_Light2_Orbiting_Projectile() {} // 0x0000000186C7EB70-0x0000000186C7EBD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CE23A0-0x0000000186CE24B0
		public virtual void MakeTrailAndSprites() {} // 0x0000000186CE24B0-0x0000000186CE2A20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CE2A20-0x0000000186CE2F20
		protected virtual void InitLightTrail(float multiplier) {} // 0x0000000186CE2F20-0x0000000186CE3230
		private void StartDespawn() {} // 0x0000000186CE3230-0x0000000186CE34C0
		public override void InternalUpdate() {} // 0x0000000186CE34C0-0x0000000186CE3640
		public override void Despawn() {} // 0x0000000186CE3640-0x0000000186CE3740
	}
}
