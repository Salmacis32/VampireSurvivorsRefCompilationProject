/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Cannon3Weapon : EME_Cannon2Weapon // TypeDefIndex: 16564
	{
		// Fields
		[Header("Sunlight Shower Explosion Projectile")]
		[SerializeField]
		private Projectile _sunlightShowerExplosionPrefab; // 0x210
		private BulletPool _sunlightShower_Explosion_Pool; // 0x218
		private VampireSurvivors.Framework.TimerSystem.Timer _sunlightShowerTimer; // 0x220
	
		// Properties
		protected override int ComboIndexFinal { get => default; } // 0x000000018700FE40-0x000000018700FE50 
		protected override int GlimmerTier { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		public BulletPool SunlightShowerExplosionPool { get => default; } // 0x00000001865DBE50-0x00000001865DBE60 
	
		// Constructors
		public EME_Cannon3Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override void OnStart() {} // 0x000000018700FE50-0x0000000187010140
		public override void Cleanup() {} // 0x0000000187010140-0x00000001870101A0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x00000001870101A0-0x00000001870101E0
		public void FireSunlightShower() {} // 0x00000001870101E0-0x00000001870106C0
		private List<float2> GenerateShowerTargets() => default; // 0x00000001870106C0-0x00000001870109E0
		private List<float2> GenerateShowerSpawnPoints(List<float2> targets) => default; // 0x00000001870109E0-0x0000000187010C60
	}
}
