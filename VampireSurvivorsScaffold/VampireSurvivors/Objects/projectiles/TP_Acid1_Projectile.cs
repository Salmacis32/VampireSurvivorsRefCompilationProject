/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Acid1_Projectile : Projectile // TypeDefIndex: 15491
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private PhaserSprite _animatedSprite2; // 0xE0
		private Tween _radiusTween; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private float __force; // 0xF8
		private Tween _forceTween; // 0x100
		private float _saveVelX; // 0x108
		private float _saveVelY; // 0x10C
		private bool _isDespawning; // 0x110
	
		// Constructors
		public TP_Acid1_Projectile() {} // 0x0000000186C35420-0x0000000186C35480
	
		// Methods
		protected override void Awake() {} // 0x0000000186C33890-0x0000000186C34120
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C34120-0x0000000186C34E40
		private void StartDespawn() {} // 0x0000000186C34E40-0x0000000186C35180
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186C35180-0x0000000186C35280
		private void LateUpdate() {} // 0x0000000186C35280-0x0000000186C353D0
		public override void Despawn() {} // 0x0000000186C353D0-0x0000000186C35420
	}
}
