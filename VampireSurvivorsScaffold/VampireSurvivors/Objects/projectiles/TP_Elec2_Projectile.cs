/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Elec2_Projectile : Projectile // TypeDefIndex: 15561
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
	
		// Constructors
		public TP_Elec2_Projectile() {} // 0x0000000186CA0FF0-0x0000000186CA1050
	
		// Methods
		protected override void Awake() {} // 0x0000000186CA06B0-0x0000000186CA09E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CA09E0-0x0000000186CA0E80
		private void StartMoving() {} // 0x0000000186CA0E80-0x0000000186CA0F30
		private void StartDespawn() {} // 0x0000000186C6AF40-0x0000000186C6AF80
		public override void Despawn() {} // 0x0000000186CA0F30-0x0000000186CA0F60
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CA0F60-0x0000000186CA0FF0
	}
}
