/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_CrushProjectile : Projectile // TypeDefIndex: 15465
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xD0
		private MultiTargetTween _flightPositionTween; // 0xD8
		private MultiTargetTween _flightScaleTween; // 0xE0
		private MultiTargetTween _scaleOutTween; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _appearTimer; // 0xF0
		private VampireSurvivors.Framework.TimerSystem.Timer _disappearTimer; // 0xF8
		private bool _hasHitGround; // 0x100
		private SpriteAnimation _spriteAnim; // 0x108
		private PhaserSprite _displaySprite; // 0x110
		private MultiTargetTween _blackBubbleTween; // 0x118
	
		// Constructors
		public FB_CrushProjectile() {} // 0x0000000186C1DDB0-0x0000000186C1DE00
	
		// Methods
		private void SetupAnimation() {} // 0x0000000186C1B6D0-0x0000000186C1BA50
		protected override void Awake() {} // 0x0000000186C1BA50-0x0000000186C1BBB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C1BBB0-0x0000000186C1CA30
		private void CreateBubble() {} // 0x0000000186C1CA30-0x0000000186C1CE20
		private void OnHitGround() {} // 0x0000000186C1CE20-0x0000000186C1D650
		private void PopBubble() {} // 0x0000000186C1D650-0x0000000186C1D9E0
		public override void InternalUpdate() {} // 0x0000000186C1D9E0-0x0000000186C1DA50
		private void Cleanup() {} // 0x0000000186C1DA50-0x0000000186C1DD10
		public override void Despawn() {} // 0x0000000186C1DD10-0x0000000186C1DD30
		protected override void OnDestroy() {} // 0x0000000186C1DD30-0x0000000186C1DDB0
	}
}
