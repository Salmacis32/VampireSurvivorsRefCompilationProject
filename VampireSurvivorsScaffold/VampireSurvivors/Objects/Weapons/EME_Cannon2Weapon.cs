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
	public class EME_Cannon2Weapon : EME_Cannon1Weapon // TypeDefIndex: 16561
	{
		// Fields
		[Header("Bombarding Fire Explosion Projectile")]
		[SerializeField]
		private Projectile BombardingFireExplosionPrefab; // 0x1D8
		private BulletPool _bombardingFire_Explosion_Pool; // 0x1E0
		private VampireSurvivors.Framework.TimerSystem.Timer _bombardingFireTimer; // 0x1E8
		protected Camera _mainCamera; // 0x1F0
		protected Bounds _camBounds; // 0x1F8
	
		// Properties
		protected override int ComboIndexFinal { get => default; } // 0x0000000187009350-0x0000000187009360 
		protected override int GlimmerTier { get => default; } // 0x0000000180B21570-0x0000000180B21580 
		public BulletPool BombardingFireExplosionPool { get => default; } // 0x0000000185D98490-0x0000000185D984A0 
	
		// Constructors
		public EME_Cannon2Weapon() {} // 0x0000000187009980-0x0000000187009990
	
		// Methods
		protected override void Awake() {} // 0x000000018700EAC0-0x000000018700EBA0
		protected override void OnStart() {} // 0x000000018700EBA0-0x000000018700EEC0
		public override void Cleanup() {} // 0x000000018700EEC0-0x000000018700EF10
		private bool OnBulletOverlapsEnemyHighDamageWithSlow(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x000000018700EF10-0x000000018700F0F0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x000000018700F0F0-0x000000018700F120
		public void FireBombardment() {} // 0x000000018700F120-0x000000018700F600
		private List<float2> GenerateBombardmentTargets() => default; // 0x000000018700F600-0x000000018700F940
		private List<float2> GenerateBombardmentSpawnPoints(List<float2> targets) => default; // 0x000000018700F940-0x000000018700FB10
	}
}
