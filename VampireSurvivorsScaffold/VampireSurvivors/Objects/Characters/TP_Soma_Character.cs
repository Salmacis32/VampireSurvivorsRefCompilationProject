/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Soma_Character : TP_Character // TypeDefIndex: 17119
	{
		// Fields
		private TP_SoulSteal_Weapon soulStealWeapon; // 0x3F0
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Soma_Character() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018717ACF0-0x000000018717AF00
		public void SoulSteal() {} // 0x000000018717AF00-0x000000018717AF60
		public override void OnAttackAnim(Weapon.FiringAnimation firingAnimation) {} // 0x000000018717AF60-0x000000018717B060
		public override void ClearFromSpecialAnims() {} // 0x000000018717B060-0x000000018717B110
	}
}
