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
	public class EME_SpiritRings1Weapon : Weapon // TypeDefIndex: 16637
	{
		// Fields
		[SerializeField]
		protected Projectile _SunlightPrefab; // 0x158
		[SerializeField]
		protected Projectile _AquaSpherePrefab; // 0x160
		[SerializeField]
		protected Projectile _HeavensThunderPrefab; // 0x168
		[SerializeField]
		protected Projectile _HyperGravityPrefab; // 0x170
		[SerializeField]
		protected Projectile _VermillionSandsPrefab; // 0x178
		[SerializeField]
		protected Projectile _ChaosDisasterPrefab; // 0x180
		[SerializeField]
		[Space]
		private int _sunlightPoolCount; // 0x188
		[SerializeField]
		private int _aquaSpherePoolCount; // 0x18C
		[SerializeField]
		private int _heavensThunderPoolCount; // 0x190
		[SerializeField]
		private int _hyperGravityPoolCount; // 0x194
		[SerializeField]
		private int _vermillionSandsPoolCount; // 0x198
		[SerializeField]
		private int _chaosDisasterPoolCount; // 0x19C
		private BulletPool _sunlightPool; // 0x1A0
		private BulletPool _aquaSpherePool; // 0x1A8
		private BulletPool _heavensThunderPool; // 0x1B0
		private BulletPool _hyperGravityPool; // 0x1B8
		private BulletPool _vermillionSandsPool; // 0x1C0
		private BulletPool _chaosDisasterPool; // 0x1C8
		private BulletPool _fireExplosionPool; // 0x1D0
		protected const float IntervalMul_Water = 3f; // Metadata: 0x01977D94
		protected const float IntervalMul_WoodA = 5f; // Metadata: 0x01977D98
		protected const float IntervalMul_Earth = 7f; // Metadata: 0x01977D9C
		protected const float IntervalMul_Metal = 11f; // Metadata: 0x01977DA0
		protected const float IntervalMul_Chaos = 13f; // Metadata: 0x01977DA4
		protected float _elapsed_Firee; // 0x1D8
		protected float _elapsed_Water; // 0x1DC
		protected float _elapsed_Earth; // 0x1E0
		protected float _elapsed_WoodA; // 0x1E4
		protected float _elapsed_Metal; // 0x1E8
		protected float _elapsed_Chaos; // 0x1EC
		private readonly Dictionary<WeaponType, string> _glimmerNames; // 0x1F0
	
		// Properties
		protected virtual bool IsEvolved { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public EME_SpiritRings1Weapon() {} // 0x000000018702C720-0x000000018702C850
	
		// Methods
		protected override void OnStart() {} // 0x0000000187029330-0x000000018702A250
		private void AddGlimmerName(WeaponType glimmerWeaponType) {} // 0x000000018702A250-0x000000018702A3A0
		private string GetGlimmerName(WeaponType weaponType) => default; // 0x000000018702A3A0-0x000000018702A510
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D92 */) {} // 0x000000018702A510-0x000000018702A610
		private void FireSpell(BulletPool spellPool, bool skipTriggers = false /* Metadata: 0x01977D93 */) {} // 0x000000018702A610-0x000000018702AA30
		public override void InternalUpdate() {} // 0x000000018702AA30-0x000000018702B420
		private void Fire_Fire() {} // 0x000000018702B420-0x000000018702B550
		private void Fire_Water() {} // 0x000000018702B550-0x000000018702B700
		private void Fire_WoodA() {} // 0x000000018702B700-0x000000018702B860
		private void Fire_Earth() {} // 0x000000018702B860-0x000000018702BA10
		private void Fire_Metal() {} // 0x000000018702BA10-0x000000018702BBC0
		private void Fire_Chaos() {} // 0x000000018702BBC0-0x000000018702BD50
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		private bool OnBulletOverlapsEnemyDamagex15(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018702BD50-0x000000018702BEC0
		private bool OnBulletOverlapsEnemyDamagex2(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018702BEC0-0x000000018702C030
		private bool OnBulletOverlapsEnemyDamagex3(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018702C030-0x000000018702C1A0
		public override void CheckArcanas() {} // 0x000000018702C1A0-0x000000018702C3F0
		public void SpawnFireExplosionAt(float2 pos) {} // 0x000000018702C3F0-0x000000018702C720
	}
}
