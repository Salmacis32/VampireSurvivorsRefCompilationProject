/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SinistroCustos_Weapon : TP_Custos_Weapon // TypeDefIndex: 16476
	{
		// Fields
		private const float YOffset = 0.25f; // Metadata: 0x01977CDA
		private bool _custos1Equipped; // 0x1B8
	
		// Properties
		public float YOffsetFinal { get => default; } // 0x0000000186FEEF00-0x0000000186FEEF70 
	
		// Constructors
		public TP_SinistroCustos_Weapon() {} // 0x0000000186F8EA60-0x0000000186F8EAB0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FEEF70-0x0000000186FEF070
		public override void InternalUpdate() {} // 0x0000000186FEF070-0x0000000186FEF2F0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CD9 */) {} // 0x0000000186FEF2F0-0x0000000186FEF480
		private float GetYOffsetFinal() => default; // 0x0000000186FEEF00-0x0000000186FEEF70
	}
}
