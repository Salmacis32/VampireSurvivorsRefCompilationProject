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
	public class TP_AuraBig_Projectile : Projectile // TypeDefIndex: 15501
	{
		// Fields
		private float _radius; // 0xD0
		private Tween _radiusTween; // 0xD8
		private bool _hasExploded; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private PhaserSprite _animatedSprite; // 0xF0
		private PhaserSprite _animatedSprite2; // 0xF8
		private PhaserSprite _animatedSprite3; // 0x100
		private MultiTargetTween _enterTween; // 0x108
		private MultiTargetTween _alphaTween; // 0x110
		private MultiTargetTween _alphaTween2; // 0x118
		private MultiTargetTween _alphaTween3; // 0x120
	
		// Constructors
		public TP_AuraBig_Projectile() {} // 0x0000000186C65B00-0x0000000186C65B60
	
		// Methods
		protected override void Awake() {} // 0x0000000186C64380-0x0000000186C648B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C648B0-0x0000000186C656D0
		public override void Despawn() {} // 0x0000000186C656D0-0x0000000186C65760
		private void StartDespawn() {} // 0x0000000186C65760-0x0000000186C659F0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C659F0-0x0000000186C65B00
	}
}
