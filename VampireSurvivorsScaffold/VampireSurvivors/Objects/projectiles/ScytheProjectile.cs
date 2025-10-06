/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class ScytheProjectile : Projectile // TypeDefIndex: 15949
	{
		// Fields
		private Tween _angleTween; // 0xD0
	
		// Constructors
		public ScytheProjectile() {} // 0x0000000186E67860-0x0000000186E678B0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E66ED0-0x0000000186E67610
		public override void Despawn() {} // 0x0000000186DEBE00-0x0000000186DEBE80
		private void Bounce(Body body, bool up, bool down, bool left, bool right) {} // 0x0000000186E67610-0x0000000186E67700
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186E67700-0x0000000186E67860
	}
}
