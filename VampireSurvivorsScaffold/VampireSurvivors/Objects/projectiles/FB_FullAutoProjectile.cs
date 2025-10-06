/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_FullAutoProjectile : Projectile // TypeDefIndex: 15471
	{
		// Fields
		private static string[] s_frameNames; // 0x00
		private float _MaxAlpha; // 0xD0
		private float _AlphaDiff; // 0xD4
	
		// Constructors
		public FB_FullAutoProjectile() {} // 0x0000000186C221F0-0x0000000186C22260
		static FB_FullAutoProjectile() {} // 0x0000000186C22260-0x0000000186C223C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C21B90-0x0000000186C21C40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C21C40-0x0000000186C21F50
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186C21F50-0x0000000186C21F60
		protected override void OnHasHitAnotherPlayerObject(IDamageable target) {} // 0x0000000186C21F60-0x0000000186C22030
		private void OnHasHitAnObjectLogic(IDamageable target, bool triggerHit) {} // 0x0000000186C22030-0x0000000186C221F0
	}
}
