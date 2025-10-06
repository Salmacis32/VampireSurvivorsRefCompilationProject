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
	public class TP_AlucardSpear2_Weapon : TP_AlucardSpear1_Weapon // TypeDefIndex: 16272
	{
		// Fields
		[SerializeField]
		private Projectile _aeroSlicePrefab; // 0x160
		private BulletPool _aeroSlicePool; // 0x168
		protected int _fireCounter; // 0x170
		protected int _specialCounter; // 0x174
	
		// Constructors
		public TP_AlucardSpear2_Weapon() {} // 0x0000000186F87330-0x0000000186F87390
	
		// Methods
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		protected override void OnStart() {} // 0x0000000186F86D80-0x0000000186F87060
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BF3 */) {} // 0x0000000186F87060-0x0000000186F870C0
		public virtual void OnSpecialCounter(bool skipTriggers = false /* Metadata: 0x01977BF4 */) {} // 0x0000000186F870C0-0x0000000186F872E0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F59EB0-0x0000000186F59EC0
		protected override void OnDestroy() {} // 0x0000000186F86C80-0x0000000186F86D00
		public override void Cleanup() {} // 0x0000000186F872E0-0x0000000186F87330
	}
}
