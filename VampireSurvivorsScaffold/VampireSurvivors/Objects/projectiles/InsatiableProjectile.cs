/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class InsatiableProjectile : Projectile // TypeDefIndex: 15420
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private float _radius; // 0xD8
	
		// Constructors
		public InsatiableProjectile() {} // 0x0000000186BE39C0-0x0000000186BE3A10
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE3340-0x0000000186BE33E0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BE33E0-0x0000000186BE37E0
		protected override void OnUpdate() {} // 0x0000000186BE37E0-0x0000000186BE39C0
	}
}
