/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class EME_Greatsword1Weapon : EME_Weapon // TypeDefIndex: 16569
	{
		// Fields
		[Header("Additional Projectile Prefabs")]
		[SerializeField]
		private Projectile _AbsetzenBeamPrefab; // 0x1C8
		private BulletPool _absetzenBeamPool; // 0x1D0
		private VampireSurvivors.Framework.TimerSystem.Timer _glimmerShotTimer; // 0x1D8
		private float _absetzenAmount; // 0x1E0
		private const float _abzentzenFireDelay = 250f; // Metadata: 0x01977D62
		private readonly List<AbsetzenInstance> _absetzenInstances; // 0x1E8
	
		// Properties
		protected override int EvolutionLevel { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex1 { get => default; } // 0x0000000181BA4B30-0x0000000181BA4B40 
		protected override int _comboIndex2 { get => default; } // 0x00000001819170A0-0x00000001819170B0 
		protected override int _comboIndex3 { get => default; } // 0x0000000181BA6070-0x0000000181BA6080 
		protected override int ComboIndexFinal { get => default; } // 0x0000000187011AB0-0x0000000187011AD0 
		public float AbzentzenFireDelay { get => default; } // 0x0000000186F8EB60-0x0000000186F8EB70 
	
		// Constructors
		public EME_Greatsword1Weapon() {} // 0x0000000187012ED0-0x0000000187012FA0
	
		// Methods
		protected override WeaponType GetWeaponTypeForGlimmerLevel(int level) => default; // 0x0000000187011AD0-0x0000000187011B00
		protected override void OnStart() {} // 0x0000000187011B00-0x0000000187011E30
		protected override void Fire_FireBasicProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187011E30-0x0000000187011EE0
		protected override void Fire_FireGlimmerProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) {} // 0x0000000187011EE0-0x00000001870124D0
		public override void InternalUpdate() {} // 0x00000001870124D0-0x0000000187012840
		public override void Cleanup() {} // 0x0000000187012840-0x00000001870129E0
		protected override void InitGlimmer1BulletPool() {} // 0x00000001870129E0-0x0000000187012D60
		private bool OnBulletOverlapsEnemyHighDamage(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187012D60-0x0000000187012ED0
		public override void CheckArcanas() {} // 0x0000000186FDD1D0-0x0000000186FDD290
	}
}
