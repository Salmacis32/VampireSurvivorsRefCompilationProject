/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class TP_JetBlackWhip1_Weapon : TP_WhipCore1_Weapon // TypeDefIndex: 16415
	{
		// Fields
		[SerializeField]
		private Projectile _impactProjectile; // 0x178
		protected BulletPool _impactPool; // 0x180
	
		// Constructors
		public TP_JetBlackWhip1_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		protected override void Awake() {} // 0x0000000186FD3830-0x0000000186FD3860
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FD3860-0x0000000186FD3B70
		public void FireImpactProjectiles(Vector2 pos) {} // 0x0000000186FD3B70-0x0000000186FD4010
		protected override void OnDestroy() {} // 0x0000000186FD4010-0x0000000186FD4090
		public override void Cleanup() {} // 0x0000000186FD4090-0x0000000186FD40E0
		public override void CheckArcanas() {} // 0x0000000186FD40E0-0x0000000186FD4240
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
	}
}
