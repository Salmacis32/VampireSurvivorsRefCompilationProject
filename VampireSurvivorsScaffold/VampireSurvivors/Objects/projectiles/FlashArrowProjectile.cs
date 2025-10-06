/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FlashArrowProjectile : Projectile // TypeDefIndex: 15419
	{
		// Fields
		private bool _hasHitFirstEnemy; // 0xD0
		private ParticleEmitterManager _pfxEmitter; // 0xD8
		private MultiTargetTween _lineTween; // 0xE0
		private MultiTargetTween _flashTween; // 0xE8
		private PhaserSprite _lineSprite; // 0xF0
		private PhaserSprite _flashSprite; // 0xF8
		private PhaserSprite _discSprite; // 0x100
		private IMillionaire _trueWeapon; // 0x108
		public bool _canMillionaire; // 0x110
	
		// Constructors
		public FlashArrowProjectile() {} // 0x0000000186BE32E0-0x0000000186BE3340
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE1770-0x0000000186BE21A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BE21A0-0x0000000186BE2730
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186BE2730-0x0000000186BE2830
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186BE2830-0x0000000186BE29A0
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186BE29A0-0x0000000186BE2BB0
		public override void InternalUpdate() {} // 0x0000000186BE2BB0-0x0000000186BE2C00
		private void PlayUselessVfx() {} // 0x0000000186BE2C00-0x0000000186BE32E0
	}
}
