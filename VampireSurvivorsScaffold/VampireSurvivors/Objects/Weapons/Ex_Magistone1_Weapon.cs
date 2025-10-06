/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Ex_Magistone1_Weapon : Weapon // TypeDefIndex: 16662
	{
		// Fields
		[SerializeField]
		private Projectile _FragmentPrefab; // 0x158
		[SerializeField]
		private bool _OverrideFragmentBounceY; // 0x160
		[SerializeField]
		private float _FragmentBounceY; // 0x164
		[SerializeField]
		private bool _OverrideFragmentSpeed; // 0x168
		[SerializeField]
		private float _FragmentSpeed; // 0x16C
		private BulletPool _fragmentPool; // 0x170
		private int _baseFragmentAmount; // 0x178
		protected List<uint> _tints; // 0x180
		private int _spawnCounter; // 0x188
	
		// Properties
		public bool InverseAreaScalingForFragments { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool SimulateZPlaneMovementForFragments { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool EnableShadows { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool EnableFragmentShadows { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool UseSantaWaterTargeting { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool FragmentsOnlyHitOnBounce { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool OverrideFragmentBounceY { get => default; } // 0x0000000187038510-0x0000000187038520 
		public float FragmentBounceY { get => default; } // 0x00000001829505B0-0x00000001829505C0 
		public bool OverrideFragmentSpeed { get => default; } // 0x0000000182766960-0x0000000182766970 
		public float FragmentSpeed { get => default; } // 0x0000000182950630-0x0000000182950640 
		public BulletPool FragmentPool { get => default; } // 0x0000000182917880-0x0000000182917890 
		public int FragmentAmount { get => default; } // 0x0000000187038520-0x0000000187038550 
		public float ProjectileScaleMultiplier { get => default; } // 0x0000000186C7DEF0-0x0000000186C7DF00 
		public List<uint> Tints { get => default; } // 0x00000001826DB9D0-0x00000001826DB9E0 
		public int SpawnCounter { get => default; } // 0x0000000185FA32F0-0x0000000185FA3300 
	
		// Constructors
		public Ex_Magistone1_Weapon() {} // 0x000000018703A290-0x000000018703A2F0
	
		// Methods
		public override float PPower() => default; // 0x0000000187038550-0x0000000187038560
		protected override void OnStart() {} // 0x0000000187038560-0x0000000187038860
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187038860-0x00000001870388A0
		protected virtual void SetTints() {} // 0x00000001870388A0-0x0000000187038A80
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DC2 */) {} // 0x0000000187038A80-0x0000000187038DC0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000187038DC0-0x0000000187038FD0
		private Vector2 GetSpawnPosition(int index, out float spawnOffsetY) {
			spawnOffsetY = default;
			return default;
		} // 0x0000000187038FD0-0x0000000187039620
		private bool OnFragmentOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187039620-0x00000001870398C0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870398C0-0x0000000187039AF0
		private Color32 GetDamageColor(float value) => default; // 0x0000000187039AF0-0x0000000187039C40
		private void ShowDamage(float value, Vector3 position) {} // 0x0000000187039C40-0x0000000187039E30
		public override void CheckArcanas() {} // 0x0000000187039E30-0x0000000187039EF0
		public override void ParadoxFire() {} // 0x0000000187039EF0-0x000000018703A100
		public override void SetVisible(bool visible) {} // 0x000000018703A100-0x000000018703A1D0
		private void DespawnAllProjectiles() {} // 0x000000018703A1D0-0x000000018703A290
	}
}
