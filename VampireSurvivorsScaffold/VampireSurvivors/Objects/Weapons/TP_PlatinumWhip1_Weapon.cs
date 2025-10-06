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
	public class TP_PlatinumWhip1_Weapon : Weapon // TypeDefIndex: 16435
	{
		// Fields
		[SerializeField]
		private Projectile _memoryWhipPrefab; // 0x158
		protected int _fireCounter; // 0x160
		protected int _specialCounter; // 0x164
		protected int _subWeaponCounter; // 0x168
		private BulletPool _memoryWhipPool; // 0x170
	
		// Constructors
		public TP_PlatinumWhip1_Weapon() {} // 0x0000000186FDB650-0x0000000186FDB6C0
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void OnStart() {} // 0x0000000186FDAF90-0x0000000186FDB270
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CAC */) {} // 0x0000000186FDB270-0x0000000186FDB2F0
		public virtual void OnSpecialCounter(bool skipTriggers = false /* Metadata: 0x01977CAD */) {} // 0x0000000186FDB2F0-0x0000000186FDB620
		public virtual void OnSubWeaponCounter(bool skipTriggers = false /* Metadata: 0x01977CAE */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void Cleanup() {} // 0x0000000186FDB620-0x0000000186FDB650
		public override void CheckArcanas() {} // 0x0000000186F8E930-0x0000000186F8E9F0
	}
}
