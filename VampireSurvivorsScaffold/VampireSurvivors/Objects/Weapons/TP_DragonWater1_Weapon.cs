/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_DragonWater1_Weapon : Weapon // TypeDefIndex: 16327
	{
		// Fields
		[SerializeField]
		private Projectile _waterDragonHeadPrefab; // 0x158
		[SerializeField]
		private Projectile _waterDragonTailPrefab; // 0x160
		protected int _fireCounter; // 0x168
		protected int _specialCounter; // 0x16C
		protected int _subWeaponCounter; // 0x170
		private BulletPool _memoryWhipPool; // 0x178
		private BulletPool _tailPool; // 0x180
	
		// Constructors
		public TP_DragonWater1_Weapon() {} // 0x0000000186FA67A0-0x0000000186FA6810
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void OnStart() {} // 0x0000000186FA5F20-0x0000000186FA6470
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C5B */) {} // 0x0000000186FA6470-0x0000000186FA64F0
		public virtual void OnSpecialCounter(bool skipTriggers = false /* Metadata: 0x01977C5C */) {} // 0x0000000186FA64F0-0x0000000186FA65B0
		public virtual void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977C5D */) {} // 0x0000000180B15170-0x0000000180B15180
		public Projectile SpawnTailProjectile(float2 pos, int index) => default; // 0x0000000186FA65B0-0x0000000186FA65F0
		public override void Cleanup() {} // 0x0000000186FA65F0-0x0000000186FA6640
		public override void CheckArcanas() {} // 0x0000000186FA6640-0x0000000186FA67A0
	}
}
