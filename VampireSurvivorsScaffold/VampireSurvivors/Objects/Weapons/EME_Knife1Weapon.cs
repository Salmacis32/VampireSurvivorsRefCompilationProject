/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Knife1Weapon : EME_Weapon // TypeDefIndex: 16583
	{
		// Fields
		[SerializeField]
		protected Projectile _MoonfallPrefab; // 0x1C8
		[SerializeField]
		protected Projectile _KaleidoscopePrefab; // 0x1D0
		protected BulletPool _moonfallPool; // 0x1D8
		protected BulletPool _kaleidoscopePool; // 0x1E0
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x0000000180B22260-0x0000000180B22270 
		protected override int _comboIndex1 { get => default; } // 0x0000000181F01BA0-0x0000000181F01BB0 
		protected override int _comboIndex2 { get => default; } // 0x0000000181DEFEC0-0x0000000181DEFED0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181B669B0-0x0000000181B669C0 
		protected override int ComboIndexFinal { get => default; } // 0x000000018700A1C0-0x000000018700A1D0 
		protected virtual bool IsEvolved { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public EME_Knife1Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187017B00-0x0000000187017B20
		protected override void OnStart() {} // 0x0000000187017B20-0x00000001870181D0
		public void DoMoonfall(float2 position) {} // 0x00000001870181D0-0x0000000187018220
		public void DoKaleidoscope(float2 position) {} // 0x0000000187018220-0x0000000187018270
		protected override float CalcCritMul() => default; // 0x0000000187018270-0x0000000187018440
		private void ActivateKnifeInvul() {} // 0x0000000187018440-0x00000001870184A0
	}
}
