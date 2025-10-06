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
	public class TP_Aura_Projectile : Projectile // TypeDefIndex: 15504
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private bool _hasExploded; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
	
		// Constructors
		public TP_Aura_Projectile() {} // 0x0000000186C6B0F0-0x0000000186C6B150
	
		// Methods
		protected override void Awake() {} // 0x0000000186C6A740-0x0000000186C6AA70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6AA70-0x0000000186C6AF40
		private void StartDespawn() {} // 0x0000000186C6AF40-0x0000000186C6AF80
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C6AF80-0x0000000186C6B090
		public override void Despawn() {} // 0x0000000186C6B090-0x0000000186C6B0F0
	}
}
