/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Cart2Projectile : Projectile // TypeDefIndex: 15407
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private SpriteAnimation _spriteAnimator; // 0xD8
		private float _defaultSpeed; // 0xE0
		private bool _makeSparks; // 0xE4
		private bool _enterTweenCompleted; // 0xE5
		private bool _isGoingRight; // 0xE6
		private float _save_vel_x; // 0xE8
		private float _save_vel_y; // 0xEC
		private Tween _enterTween; // 0xF0
		private DG.Tweening.Sequence _fadeOutTween; // 0xF8
		private Tween _scaleTween; // 0x100
		private Tween _xTween; // 0x108
		private bool _isFadingOut; // 0x110
	
		// Constructors
		public Cart2Projectile() {} // 0x0000000186BCD750-0x0000000186BCD7A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BCB440-0x0000000186BCB580
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BCB580-0x0000000186BCBEF0
		public override void InternalUpdate() {} // 0x0000000186BCBEF0-0x0000000186BCC440
		public override void OnHasHitWallPhaser(PhaserTile tile) {} // 0x0000000186BCC440-0x0000000186BCC590
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186BCC590-0x0000000186BCC6A0
		protected void Bounce(Body body, bool up, bool down, bool left, bool right) {} // 0x0000000186BCC6A0-0x0000000186BCC6E0
		private void FadeOut() {} // 0x0000000186BCC6E0-0x0000000186BCCCC0
		private void OnBounce() {} // 0x0000000186BCCCC0-0x0000000186BCCEA0
		private void GenerateAnims() {} // 0x0000000186BCCEA0-0x0000000186BCD090
		private void SetDepths() {} // 0x0000000186BCD090-0x0000000186BCD1D0
		private void GeneratePfx() {} // 0x0000000186BCD1D0-0x0000000186BCD750
	}
}
