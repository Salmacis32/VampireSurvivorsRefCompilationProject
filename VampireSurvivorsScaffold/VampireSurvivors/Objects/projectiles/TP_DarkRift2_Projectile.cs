/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DarkRift2_Projectile : Projectile // TypeDefIndex: 15531
	{
		// Fields
		[SerializeField]
		private SpriteTrail _Trail; // 0xD0
		private const float Radius = 16f; // Metadata: 0x019776B8
		private Tween _angleTween; // 0xD8
		private PhaserSprite _scytheSprite; // 0xE0
	
		// Constructors
		public TP_DarkRift2_Projectile() {} // 0x0000000186C807B0-0x0000000186C80800
	
		// Methods
		protected override void Awake() {} // 0x0000000186C7F380-0x0000000186C7FB70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C7FB70-0x0000000186C7FE50
		private void InitVelocity() {} // 0x0000000186C7FE50-0x0000000186C7FF60
		private void InitRotation() {} // 0x0000000186C7FF60-0x0000000186C80200
		private void InitBounce() {} // 0x0000000186C80200-0x0000000186C80450
		private void PlaySfx() {} // 0x0000000186C80450-0x0000000186C80530
		public override void Despawn() {} // 0x0000000186C80530-0x0000000186C80560
		private void Bounce(Body body, bool up, bool down, bool left, bool right) {} // 0x0000000186C80560-0x0000000186C80650
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C80650-0x0000000186C807B0
	}
}
