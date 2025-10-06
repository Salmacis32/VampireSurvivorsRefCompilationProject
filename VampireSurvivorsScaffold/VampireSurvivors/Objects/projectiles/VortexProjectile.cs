/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VortexProjectile : Projectile // TypeDefIndex: 15988
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private const float Radius = 16f; // Metadata: 0x019779CE
	
		// Constructors
		public VortexProjectile() {} // 0x0000000186E98950-0x0000000186E989A0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E98490-0x0000000186E98670
		public override void InternalUpdate() {} // 0x0000000186E203C0-0x0000000186E20560
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186E98670-0x0000000186E98950
		public override void Despawn() {} // 0x0000000186C6F470-0x0000000186C6F4A0
	}
}
