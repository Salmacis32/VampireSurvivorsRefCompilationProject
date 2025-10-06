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
	public class EME_Blood_BloodRage_Weapon : Weapon // TypeDefIndex: 16557
	{
		// Fields
		[SerializeField]
		protected Projectile _BloodRageSpecialPrefab; // 0x158
		protected BulletPool _bloodRageSpecialPool; // 0x160
		protected readonly Dictionary<WeaponType, string> _glimmerNames; // 0x168
	
		// Constructors
		public EME_Blood_BloodRage_Weapon() {} // 0x000000018700CE50-0x000000018700CF40
	
		// Methods
		protected override void Awake() {} // 0x00000001870099F0-0x0000000187009A10
		protected override void OnStart() {} // 0x000000018700BAF0-0x000000018700BC50
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x000000018700BC50-0x000000018700BDA0
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018700BDA0-0x000000018700BF10
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D50 */) {} // 0x000000018700BF10-0x000000018700C2A0
		public void DoBloodRage(float2 position) {} // 0x000000018700C2A0-0x000000018700C2E0
		public void SpawnSpecialProjectiles(float2 position, BulletPool pool, float amountMul = 1f /* Metadata: 0x01977D51 */, float areaMul = 1f /* Metadata: 0x01977D55 */) {} // 0x000000018700C2E0-0x000000018700C960
		private void SetupSpecialBulletPools() {} // 0x000000018700C960-0x000000018700CCE0
		protected bool OnBulletOverlapsEnemyDamagex2(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700CCE0-0x000000018700CE50
	}
}
