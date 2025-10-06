/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Valmanway2_Projectile : Projectile // TypeDefIndex: 15705
	{
		// Fields
		private const float Radius = 36f; // Metadata: 0x019777B9
		private const float Speed = 4f; // Metadata: 0x019777BD
		private PhaserSprite _slashSprite; // 0xD0
		private PhaserSprite _ghostSprite1; // 0xD8
		private PhaserSprite _ghostSprite2; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private MultiTargetTween _spriteScaleTween; // 0xF0
		private MultiTargetTween _alphaTween; // 0xF8
	
		// Constructors
		public TP_Valmanway2_Projectile() {} // 0x0000000186D41E10-0x0000000186D41E60
	
		// Methods
		protected override void Awake() {} // 0x0000000186D3FA00-0x0000000186D405A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D405A0-0x0000000186D407F0
		private void InitSprites() {} // 0x0000000186D407F0-0x0000000186D41810
		private void InitBounce() {} // 0x0000000186D41810-0x0000000186D41A60
		private void InitAiming() {} // 0x0000000186CF3C30-0x0000000186CF3CB0
		private void PlaySfx() {} // 0x0000000186D41A60-0x0000000186D41B40
		public override void InternalUpdate() {} // 0x0000000186D41B40-0x0000000186D41CE0
		private void UpdateRotation() {} // 0x0000000186D41B40-0x0000000186D41CE0
		public override void Despawn() {} // 0x0000000186D41CE0-0x0000000186D41D40
		private void Bounce(Body body, bool up, bool down, bool left, bool right) {} // 0x0000000186D41D40-0x0000000186D41E10
	}
}
