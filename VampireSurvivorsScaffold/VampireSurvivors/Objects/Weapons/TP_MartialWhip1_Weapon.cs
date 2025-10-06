/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_MartialWhip1_Weapon : TP_WhipCore1_Weapon // TypeDefIndex: 16426
	{
		// Fields
		[SerializeField]
		private Projectile _impactProjectile; // 0x178
		protected BulletPool _impactPool; // 0x180
	
		// Constructors
		public TP_MartialWhip1_Weapon() {} // 0x0000000186FC8280-0x0000000186FC8290
	
		// Methods
		public override float SecondaryPPower() => default; // 0x0000000186FD8BD0-0x0000000186FD8CB0
		protected override void Awake() {} // 0x0000000186FD8CB0-0x0000000186FD8FB0
		public void FireImpactProjectiles(Vector2 pos) {} // 0x0000000186FD8FB0-0x0000000186FD94E0
		protected override void OnDestroy() {} // 0x0000000186FD4010-0x0000000186FD4090
		public override void Cleanup() {} // 0x0000000186FD4090-0x0000000186FD40E0
		public override void CheckArcanas() {} // 0x0000000186FD94E0-0x0000000186FD9680
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
	}
}
