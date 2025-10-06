/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
	public class EME_Mech_Rave_Weapon : Weapon, EME_iCosmicRaveVFX // TypeDefIndex: 16606
	{
		// Fields
		private BulletPool _cosmicRaveVFXpool; // 0x158
		[SerializeField]
		private Projectile _CosmicRaveVFXPrefab; // 0x160
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x168
	
		// Constructors
		public EME_Mech_Rave_Weapon() {} // 0x000000018701ED10-0x000000018701EE00
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x000000018701E570-0x000000018701E790
		public void DisplayCosmicRaveVFX(float2 position) {} // 0x000000018701E790-0x000000018701E7D0
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x000000018701E7D0-0x000000018701E920
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018701E920-0x000000018701EA90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D76 */) {} // 0x000000018701EA90-0x000000018701ED10
	}
}
