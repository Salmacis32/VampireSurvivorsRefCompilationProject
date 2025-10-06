/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SoleSolutionProjectile : Projectile // TypeDefIndex: 15967
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private MultiTargetTween _scaleTween2; // 0xE8
	
		// Constructors
		public SoleSolutionProjectile() {} // 0x0000000186E724E0-0x0000000186E72530
	
		// Methods
		protected override void Awake() {} // 0x0000000186E71B50-0x0000000186E71C00
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E71C00-0x0000000186E72320
		protected override void OnUpdate() {} // 0x0000000186E72320-0x0000000186E724E0
	}
}
