/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_GreatswordProjectile : Projectile // TypeDefIndex: 15771
	{
		// Fields
		[SerializeField]
		protected SpriteRenderer _SwordSprite; // 0xD0
		[SerializeField]
		private ParticleSystem GroundHitFX; // 0xD8
		[SerializeField]
		private SpriteTrail _SpriteTrail; // 0xE0
		protected const float Radius = 28f; // Metadata: 0x019777FE
		protected const float ScaleModifier = 0.75f; // Metadata: 0x01977802
		protected const float Gravity = 6.25f; // Metadata: 0x01977806
		protected Sprite _swordSpriteFull; // 0xE8
		protected Sprite _swordSpriteGround; // 0xF0
		protected Vector2 _velocity; // 0xF8
		protected bool _hasLanded; // 0x100
		protected float _timeToLand; // 0x104
		protected VampireSurvivors.Framework.TimerSystem.Timer _landingTimer; // 0x108
		protected bool _isFlipped; // 0x110
		protected int _flipSwitch; // 0x114
		protected Tween _angleTween; // 0x118
		protected Tween _scaleTween; // 0x120
		protected Tween _fadeTween; // 0x128
		protected MultiTargetTween _screenShakeTween; // 0x130
	
		// Properties
		protected virtual float MinTimeToLand { get => default; } // 0x0000000186D6F330-0x0000000186D6F340 
		protected virtual float MaxTimeToLand { get => default; } // 0x0000000186D81AB0-0x0000000186D81AC0 
		public bool HasLanded { get => default; } // 0x00000001829080B0-0x00000001829080C0 
	
		// Constructors
		public EME_GreatswordProjectile() {} // 0x0000000186D83840-0x0000000186D83890
	
		// Methods
		protected override void Awake() {} // 0x0000000186D81AC0-0x0000000186D81AE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D81AE0-0x0000000186D81EA0
		private void SetupSwordSprites() {} // 0x0000000186D81EA0-0x0000000186D82120
		public override void InternalUpdate() {} // 0x0000000186D82120-0x0000000186D821A0
		protected virtual void InitVelocity() {} // 0x0000000186D821A0-0x0000000186D82260
		protected void UpdateVelocity() {} // 0x0000000186D82120-0x0000000186D821A0
		protected void StartSpinning() {} // 0x0000000186D82260-0x0000000186D82510
		protected void Land() {} // 0x0000000186D82510-0x0000000186D828E0
		protected virtual void DoGlimmerAttack() {} // 0x0000000186D828E0-0x0000000186D828F0
		protected void PlayLandingVfx() {} // 0x0000000186D828F0-0x0000000186D82A90
		protected void DoScreenShake() {} // 0x0000000186D82A90-0x0000000186D83020
		protected void EnableTrail(bool enable) {} // 0x0000000186D83020-0x0000000186D83120
		private void PlayThrowSfx() {} // 0x0000000186D83120-0x0000000186D83200
		private void PlayLandingSfx() {} // 0x0000000186D83200-0x0000000186D83320
		public void StartDespawn() {} // 0x0000000186D83320-0x0000000186D837D0
		public override void Despawn() {} // 0x0000000186D837D0-0x0000000186D83840
	}
}
