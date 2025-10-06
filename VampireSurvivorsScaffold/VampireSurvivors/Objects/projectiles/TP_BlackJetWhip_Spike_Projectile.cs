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
	public class TP_BlackJetWhip_Spike_Projectile : Projectile // TypeDefIndex: 15505
	{
		// Fields
		private float pxWidth; // 0xD0
		private float pxHeight; // 0xD4
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _scale2Tween; // 0xE0
		private PhaserSprite _animatedSprite; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		private float _currentScale; // 0xF8
		private MultiTargetTween _durationTween; // 0x100
	
		// Constructors
		public TP_BlackJetWhip_Spike_Projectile() {} // 0x0000000186C6BC20-0x0000000186C6BC90
	
		// Methods
		protected override void Awake() {} // 0x0000000186C6B150-0x0000000186C6B520
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6B520-0x0000000186C6BAF0
		private void LateUpdate() {} // 0x0000000186C6BAF0-0x0000000186C6BB80
		public override void Despawn() {} // 0x0000000186C6BB80-0x0000000186C6BC20
	}
}
