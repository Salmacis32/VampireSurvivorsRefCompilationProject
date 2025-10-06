/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Interfaces;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Ex_Ammo1Weapon : Weapon // TypeDefIndex: 16652
	{
		// Fields
		[SerializeField]
		private bool _multitickDamage; // 0x158
		[SerializeField]
		private float _rapidFireDamageInterval; // 0x15C
		[SerializeField]
		private int _ticksPerRapidFire; // 0x160
		private const WeaponType _counterWeaponType = WeaponType.EX_AMMO1_COUNTER; // Metadata: 0x01977DB5
		private Weapon _counterWeapon; // 0x168
		private readonly List<RapidDamageInstance> _rapidDamageInstances; // 0x170
	
		// Properties
		public virtual bool FireInTheFacedDirection { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public Ex_Ammo1Weapon() {} // 0x00000001870335D0-0x00000001870336D0
	
		// Methods
		public override void DealDamage(IDamageable other, float damage) {} // 0x0000000187032AE0-0x0000000187032D80
		public override void InternalUpdate() {} // 0x0000000187032D80-0x0000000187033180
		public override void CheckArcanas() {} // 0x0000000187033180-0x00000001870334B0
		public override bool LevelUp() => default; // 0x00000001870334B0-0x00000001870335D0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
