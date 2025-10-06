/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MechProjectile_UNUSED_QuadMissile : EME_MechProjectile_BallisticMissile // TypeDefIndex: 15819
	{
		// Properties
		protected override float Radius { get => default; } // 0x0000000186C6EC50-0x0000000186C6EC60 
		protected override float2 SpawnOffset { get => default; } // 0x0000000186DD3010-0x0000000186DD3030 
		protected override List<float> SpawnAngles { get => default; } // 0x0000000186DD3030-0x0000000186DD3210 
		protected override float TurnSpeed { get => default; } // 0x0000000186DD3210-0x0000000186DD3220 
		protected override float TurnDuration { get => default; } // 0x0000000186D7E010-0x0000000186D7E020 
		protected override float TurnDelay { get => default; } // 0x00000001826256C0-0x00000001826256D0 
	
		// Constructors
		public EME_MechProjectile_UNUSED_QuadMissile() {} // 0x0000000186D7E1B0-0x0000000186D7E200
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD3220-0x0000000186DD3230
		protected override void SetMovementPattern() {} // 0x0000000186DD3230-0x0000000186DD3360
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000180B15170-0x0000000180B15180
	}
}
