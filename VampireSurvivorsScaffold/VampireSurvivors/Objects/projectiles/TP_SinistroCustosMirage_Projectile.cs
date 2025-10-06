/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SinistroCustosMirage_Projectile : Projectile // TypeDefIndex: 15659
	{
		// Fields
		private MultiTargetTween _alphaTween; // 0xD0
		private SpriteAnimation _anim; // 0xD8
	
		// Constructors
		public TP_SinistroCustosMirage_Projectile() {} // 0x0000000186D18460-0x0000000186D184B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D17BE0-0x0000000186D17C80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D17C80-0x0000000186D183C0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D183C0-0x0000000186D18430
		public override void Despawn() {} // 0x0000000186D18430-0x0000000186D18460
	}
}
