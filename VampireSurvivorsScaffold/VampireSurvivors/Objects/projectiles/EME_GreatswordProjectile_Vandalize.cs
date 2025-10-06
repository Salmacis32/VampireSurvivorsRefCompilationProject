/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_GreatswordProjectile_Vandalize : Projectile // TypeDefIndex: 15777
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _SwordSprite; // 0xD0
		[SerializeField]
		private ParticleSystem GroundHitFX; // 0xD8
		[SerializeField]
		private SpriteTrail _SpriteTrail; // 0xE0
		private const float ScaleModifier = 2f; // Metadata: 0x0197781E
		private const float MaxAreaLimit = 2.5f; // Metadata: 0x01977822
		private int _smashCounter; // 0xE8
		private int _maxSmashes; // 0xEC
		private Tween _fadeTween; // 0xF0
		private MultiTargetTween _angleTween; // 0xF8
		private MultiTargetTween _scaleTween; // 0x100
		private MultiTargetTween _screenShakeTween; // 0x108
	
		// Constructors
		public EME_GreatswordProjectile_Vandalize() {} // 0x0000000186D88950-0x0000000186D889A0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D86E70-0x0000000186D86F80
		public override void InternalUpdate() {} // 0x0000000186D86F80-0x0000000186D87190
		private void TweenIn() {} // 0x0000000186D87190-0x0000000186D87650
		private void DoSmash() {} // 0x0000000186D87650-0x0000000186D87960
		private void UpdatePosition() {} // 0x0000000186C974B0-0x0000000186C974F0
		private void PlaySfx() {} // 0x0000000186D87960-0x0000000186D87A50
		private void UpdateBody() {} // 0x0000000186D87A50-0x0000000186D87C30
		private void PlaySmashVfx() {} // 0x0000000186D87C30-0x0000000186D87D20
		private void DoScreenShake() {} // 0x0000000186D87D20-0x0000000186D882D0
		protected void EnableTrail(bool enable) {} // 0x0000000186D882D0-0x0000000186D883D0
		private void StartDespawn() {} // 0x0000000186D883D0-0x0000000186D888E0
		public override void Despawn() {} // 0x0000000186D888E0-0x0000000186D88950
	}
}
