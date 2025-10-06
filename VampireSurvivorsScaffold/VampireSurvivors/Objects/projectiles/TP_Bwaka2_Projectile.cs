/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_Bwaka2_Projectile : TP_Bwaka1_Projectile // TypeDefIndex: 15508
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0x108
	
		// Properties
		protected override string FrameName { get => default; } // 0x0000000186C6EC10-0x0000000186C6EC50 
		protected override bool InfiniteBounces { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected override float Radius { get => default; } // 0x0000000186C6EC50-0x0000000186C6EC60 
		protected override float OrbitRadius { get => default; } // 0x0000000186C6EC60-0x0000000186C6EC70 
	
		// Constructors
		public TP_Bwaka2_Projectile() {} // 0x0000000186C6EBC0-0x0000000186C6EC10
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6EC70-0x0000000186C6ED80
		private void SetupTrail() {} // 0x0000000186C6ED80-0x0000000186C6F230
	}
}
