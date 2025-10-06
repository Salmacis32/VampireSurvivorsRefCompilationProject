/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public abstract class EquipmentManager : GameMonoBehaviour // TypeDefIndex: 15081
	{
		// Properties
		public static int MaxCapacity { get; } // 0x00000001819170A0-0x00000001819170B0 
		public List<Equipment> ActiveEquipment { get; } // 0x0000000180B15540-0x0000000180B15550 
		public List<Equipment> HiddenEquipment { get; } // 0x0000000180B15550-0x0000000180B15560 
		public List<Equipment> RemovedHiddenEquipment { get; } // 0x0000000180B15560-0x0000000180B15570 
		public List<Equipment> RemovedEquipment { get; } // 0x0000000180B15750-0x0000000180B15760 
	
		// Constructors
		protected EquipmentManager() {} // 0x00000001869EEFB0-0x00000001869EF210
	
		// Methods
		public Equipment GetEquipmentByType(WeaponType equipmentType, bool searchHidden = false /* Metadata: 0x019772ED */) => default; // 0x00000001869EE5F0-0x00000001869EE780
		public Equipment GetRemovedHiddenEquipment(WeaponType equipmentType) => default; // 0x00000001869EE780-0x00000001869EE900
		public Equipment GetRemovedEquipment(WeaponType equipmentType) => default; // 0x00000001869EE900-0x00000001869EEA80
		public void LevelUpAllActiveEquipment() {} // 0x00000001869EEA80-0x00000001869EEBE0
		public void MaxLevelUpAllEquipment() {} // 0x00000001869EEBE0-0x00000001869EED50
		public void AddEquipment(Equipment item) {} // 0x00000001869EED50-0x00000001869EEDB0
		public void AddHiddenEquipment(Equipment item) {} // 0x00000001869EEDB0-0x00000001869EEE10
		public void RemoveEquipment(Equipment item) {} // 0x00000001869EEE10-0x00000001869EEEE0
		public void RemoveHiddenEquipment(Equipment item) {} // 0x00000001869EEEE0-0x00000001869EEFB0
	}
}
