/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Ice2_Projectile : Projectile // TypeDefIndex: 15593
	{
		// Fields
		private ParticleSystem _rainEmitter1; // 0xD0
		private ParticleSystem _rainEmitter2; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer rainStopTimer; // 0xE0
	
		// Constructors
		public TP_Ice2_Projectile() {} // 0x0000000186CCCD80-0x0000000186CCCDD0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CCAB90-0x0000000186CCABB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CCABB0-0x0000000186CCB2B0
		private void StartDespawn() {} // 0x0000000186CCB2B0-0x0000000186CCB3F0
		public override void Despawn() {} // 0x0000000186CCB3F0-0x0000000186CCB450
		private void MakeEmitters() {} // 0x0000000186CCB450-0x0000000186CCCD80
	}
}
