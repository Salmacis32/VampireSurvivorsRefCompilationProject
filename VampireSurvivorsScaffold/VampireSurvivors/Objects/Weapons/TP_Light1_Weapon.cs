/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Light1_Weapon : Weapon // TypeDefIndex: 16421
	{
		// Fields
		private BulletPool _orbitersPool; // 0x158
		[SerializeField]
		protected Projectile _orbiterPrefab; // 0x160
		[NonSerialized]
		public int OrbitAmount; // 0x168
		private WeaponType[] _lightDarkWeapons; // 0x170
	
		// Properties
		public float ProjScaledAlpha { get; set; } // 0x0000000182950630-0x0000000182950640 0x0000000186FD5900-0x0000000186FD5910
	
		// Constructors
		public TP_Light1_Weapon() {} // 0x0000000186FD6700-0x0000000186FD6800
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FD5910-0x0000000186FD5C10
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD5C10-0x0000000186FD61C0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FD61C0-0x0000000186FD6300
		public override void SetVisible(bool visible) {} // 0x0000000186FD6300-0x0000000186FD63C0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CA3 */) {} // 0x0000000186FD63C0-0x0000000186FD66C0
		public Projectile SpawnOrbitProjectile(float2 pos, int index) => default; // 0x0000000186FD66C0-0x0000000186FD6700
		public override bool LevelUp() => default; // 0x0000000186F9C6B0-0x0000000186F9C6D0
	}
}
