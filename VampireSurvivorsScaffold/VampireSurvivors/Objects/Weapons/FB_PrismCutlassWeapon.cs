/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_PrismCutlassWeapon : Weapon // TypeDefIndex: 16244
	{
		// Fields
		protected WeaponType _counterWeaponType; // 0x158
		protected Weapon _counterWeapon; // 0x160
		private bool _fireCounterSet; // 0x168
		private bool _hasCounterSet; // 0x169
		private FB_PrismCutlassWeapon _counterSet; // 0x170
	
		// Constructors
		public FB_PrismCutlassWeapon() {} // 0x0000000186F76FF0-0x0000000186F77050
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F77050-0x0000000186F770D0
		public override void CheckArcanas() {} // 0x0000000186F770D0-0x0000000186F77430
		public override bool LevelUp() => default; // 0x0000000186F77430-0x0000000186F77550
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BE6 */) {} // 0x0000000186F77550-0x0000000186F777F0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
	}
}
