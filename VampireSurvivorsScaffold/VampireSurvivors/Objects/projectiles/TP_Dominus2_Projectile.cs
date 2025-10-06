/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Dominus2_Projectile : Projectile // TypeDefIndex: 15545
	{
		// Fields
		private float _radius; // 0xD0
		private PhaserSprite _animatedSprite; // 0xD8
		private bool _isDespawning; // 0xE0
		private bool _hasHitBottom; // 0xE1
		private string idle; // 0xE8
		private string burst; // 0xF0
		private string idleInverse; // 0xF8
		private string burstInverse; // 0x100
		private bool inverted; // 0x108
		private TP_Dominus2_Weapon _trueWeapon; // 0x110
	
		// Constructors
		public TP_Dominus2_Projectile() {} // 0x0000000186C933E0-0x0000000186C93600
	
		// Methods
		protected override void Awake() {} // 0x0000000186C926A0-0x0000000186C92B70
		public void Invert(bool value) {} // 0x00000001828080E0-0x00000001828080F0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C92B70-0x0000000186C93030
		private void LateUpdate() {} // 0x0000000186C93030-0x0000000186C93180
		private void OnHittingScreenBottom() {} // 0x0000000186C93180-0x0000000186C93310
		public override void Despawn() {} // 0x0000000186C93310-0x0000000186C93360
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C93360-0x0000000186C933E0
	}
}
