/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class SubSkillCard_OnDamaged_GroundHit : CharacterSkillCard_Base // TypeDefIndex: 16883
	{
		// Fields
		private Weapon _groundHitWeapon; // 0x70
		private bool _canRetaliate; // 0x78
		private float retaliationDelay; // 0x7C
	
		// Constructors
		public SubSkillCard_OnDamaged_GroundHit() {} // Dummy constructor
		public SubSkillCard_OnDamaged_GroundHit(ArcanaType type) {} // 0x00000001870E7A20-0x00000001870E7A40
	
		// Methods
		public override void InitialActivate() {} // 0x00000001870E7A40-0x00000001870E7D10
		public override void OnOwnerGetDamaged(float damageAmount) {} // 0x00000001870E7D10-0x00000001870E7E00
	}
}
