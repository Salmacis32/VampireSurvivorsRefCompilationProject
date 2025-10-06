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
	public class TP_DextroCustos_Projectile : TP_Custos_Projectile // TypeDefIndex: 15539
	{
		// Fields
		private TP_DextroCustos_Weapon _baseWeapon; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x128
	
		// Constructors
		public TP_DextroCustos_Projectile() {} // 0x0000000186C79780-0x0000000186C79790
	
		// Methods
		protected override void Awake() {} // 0x0000000186C8B980-0x0000000186C8B9B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C8B9B0-0x0000000186C8BDE0
		public override void InternalUpdate() {} // 0x0000000186C8BDE0-0x0000000186C8BDF0
		private void UpdatePosition() {} // 0x0000000186C8BDF0-0x0000000186C8BFB0
		public override void Bite() {} // 0x0000000186C8BFB0-0x0000000186C8C050
		public override void Despawn() {} // 0x0000000186C8C050-0x0000000186C8C080
	}
}
