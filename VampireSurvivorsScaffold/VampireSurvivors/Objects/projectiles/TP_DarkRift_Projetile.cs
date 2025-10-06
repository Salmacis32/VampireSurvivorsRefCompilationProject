/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DarkRift_Projetile : Projectile // TypeDefIndex: 15533
	{
		// Fields
		private float pxWidth; // 0xD0
		private float pxHeight; // 0xD4
		private MultiTargetTween _scaleTween; // 0xD8
		private MultiTargetTween _scale2Tween; // 0xE0
		private PhaserSprite _displaySprite; // 0xE8
		private PhaserSprite _animatedSprite; // 0xF0
		private MultiTargetTween _alphaTween; // 0xF8
		private float _currentScale; // 0x100
		private MultiTargetTween _durationTween; // 0x108
	
		// Constructors
		public TP_DarkRift_Projetile() {} // 0x0000000186C82C60-0x0000000186C82CD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C816E0-0x0000000186C81D20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C81D20-0x0000000186C82410
		private void ShootWave() {} // 0x0000000186C82410-0x0000000186C82820
		private void LateUpdate() {} // 0x0000000186C82820-0x0000000186C828C0
		private void StartDespawn() {} // 0x0000000186C828C0-0x0000000186C82B70
		public override void Despawn() {} // 0x0000000186C82B70-0x0000000186C82C10
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C82C10-0x0000000186C82C60
	}
}
