/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class CharacterWeaponsManager : EquipmentManager // TypeDefIndex: 15080
	{
		// Fields
		private int _maxActiveCount; // 0x48
		private int _maxHiddenCount; // 0x4C
	
		// Properties
		public bool ShouldSkipWeaponUpdates { get => default; } // 0x00000001869ED7C0-0x00000001869ED7D0 
	
		// Constructors
		public CharacterWeaponsManager() {} // 0x00000001869EE440-0x00000001869EE450
	
		// Methods
		public void SetWeaponsActive(bool active) {} // 0x00000001869ED7D0-0x00000001869ED810
		public Weapon SetWeaponActive(bool active, Weapon effectedWeapon = null) => default; // 0x00000001869ED810-0x00000001869EDC10
		public void SetMaxWeaponCount(int maxActives, int maxHidden) {} // 0x00000001869EDC10-0x00000001869EDDD0
		private void SetWeaponVisible(Weapon weapon, bool visible) {} // 0x00000001869EDDD0-0x00000001869EDF60
		protected override void OnUpdate() {} // 0x00000001869EDF60-0x00000001869EE090
		public Weapon GetWeaponByType(WeaponType weaponType, bool searchHidden = false /* Metadata: 0x019772EC */) => default; // 0x00000001869EE090-0x00000001869EE140
		public Weapon GetWeaponByTypeFromAnyCollection(WeaponType weaponType) => default; // 0x00000001869EE140-0x00000001869EE440
	}
}
