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
	public class BocceProjectile : Projectile // TypeDefIndex: 15395
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		public int _Radius; // 0xD8
	
		// Constructors
		public BocceProjectile() {} // 0x0000000186BB86D0-0x0000000186BB8730
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB8110-0x0000000186BB81B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BB81B0-0x0000000186BB8510
		public override void InternalUpdate() {} // 0x0000000186BB8510-0x0000000186BB86D0
	}
}
