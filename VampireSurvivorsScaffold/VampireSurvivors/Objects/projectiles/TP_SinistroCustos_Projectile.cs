/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SinistroCustos_Projectile : TP_Custos_Projectile // TypeDefIndex: 15661
	{
		// Fields
		private TP_SinistroCustos_Weapon _baseWeapon; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x128
	
		// Constructors
		public TP_SinistroCustos_Projectile() {} // 0x0000000186C79780-0x0000000186C79790
	
		// Methods
		protected override void Awake() {} // 0x0000000186D18750-0x0000000186D18780
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D18780-0x0000000186D18BB0
		public override void InternalUpdate() {} // 0x0000000186D18BB0-0x0000000186D18D40
		private void UpdatePosition() {} // 0x0000000186D18BB0-0x0000000186D18D40
		public override void Bite() {} // 0x0000000186D18D40-0x0000000186D18DE0
		public override void Despawn() {} // 0x0000000186C8C050-0x0000000186C8C080
	}
}
