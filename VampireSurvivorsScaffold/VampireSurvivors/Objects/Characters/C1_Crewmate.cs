/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class C1_Crewmate : CharacterController // TypeDefIndex: 16999
	{
		// Fields
		private List<WeaponType> _addedBonuses; // 0x3F0
		private Dictionary<WeaponType, float> _powerUpBonusList; // 0x3F8
		private Dictionary<WeaponType, float> _weaponBonusList; // 0x400
	
		// Constructors
		public C1_Crewmate() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FC1 */) {} // 0x0000000187141A30-0x0000000187141F30
		public override void OnLevelUpCompleted() {} // 0x0000000187141F30-0x00000001871423B0
		private void HandleEquipment(Equipment equipment) {} // 0x00000001871423B0-0x00000001871427C0
		[Command]
		public void AddValue(int bonus, float bonusValue) {} // 0x00000001871427C0-0x0000000187142950
	}
}
