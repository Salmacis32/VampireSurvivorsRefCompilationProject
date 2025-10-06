/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Gun1_Projectile : Projectile // TypeDefIndex: 15581
	{
		// Fields
		protected VampireSurvivors.Framework.TimerSystem.Timer _despawnTimer; // 0xD0
		private List<Projectile> shrapnelHitboxes; // 0xD8
	
		// Constructors
		public TP_Gun1_Projectile() {} // 0x0000000186CBEFD0-0x0000000186CBF020
	
		// Methods
		protected override void Awake() {} // 0x0000000186CBE7F0-0x0000000186CBE890
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CBE890-0x0000000186CBEE50
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186CBEE50-0x0000000186CBEFD0
		public override void Despawn() {} // 0x0000000186C6F470-0x0000000186C6F4A0
	}
}
