/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WhipMemory_Projectile : Projectile // TypeDefIndex: 15719
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private Tween _radiusTween; // 0xE0
		private bool trailInit; // 0xE8
		private List<SfxType> sfx; // 0xF0
	
		// Constructors
		public TP_WhipMemory_Projectile() {} // 0x0000000186D4CDE0-0x0000000186D4D000
	
		// Methods
		protected override void Awake() {} // 0x0000000186D4C0C0-0x0000000186D4C5F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D4C5F0-0x0000000186D4CDE0
		private void StartDespawn() {} // 0x0000000186C6AF40-0x0000000186C6AF80
		public override void Despawn() {} // 0x0000000186CADAB0-0x0000000186CADAE0
	}
}
