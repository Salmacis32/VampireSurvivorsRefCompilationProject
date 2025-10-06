/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class ShopFactory // TypeDefIndex: 17522
	{
		// Fields
		[Inject]
		private DataManager _data; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		private List<WeaponType> _availableWeapons; // 0x20
		private List<VampireSurvivors.Data.ItemType> _availableItems; // 0x28
	
		// Properties
		public List<WeaponType> AvailableWeapons { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public List<VampireSurvivors.Data.ItemType> AvailableItems { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	
		// Constructors
		public ShopFactory() {} // 0x0000000187348CD0-0x0000000187348E30
	
		// Methods
		public void GenerateShopInventory(CharacterController player) {} // 0x0000000187346B40-0x0000000187346E60
		public void InjectRemoteShop(List<WeaponType> weapons, List<VampireSurvivors.Data.ItemType> items) {} // 0x00000001852686F0-0x00000001852687A0
		public static List<WeaponType> GetValidAdventureWeaponsForMerchant(List<WeaponType> merchantInventory, PlayerOptions playerOptions) => default; // 0x0000000187346E60-0x0000000187347160
		public static List<WeaponType> GetValidCustomMerchantWeapons(List<WeaponType> merchantInventory, PlayerOptions playerOptions) => default; // 0x0000000187347160-0x00000001873474E0
		public static List<VampireSurvivors.Data.ItemType> GetValidCustomMerchantItems(List<VampireSurvivors.Data.ItemType> merchantInventoryItems, PlayerOptions playerOptions) => default; // 0x00000001873474E0-0x0000000187347860
		public bool DoesPlayerAlreadyHaveWeapon(WeaponType t) => default; // 0x0000000187347860-0x0000000187347B90
		private void MakeCustomInventory() {} // 0x0000000187347B90-0x0000000187348110
		private void MakeStandardInventory(CharacterController player) {} // 0x0000000187348110-0x00000001873488F0
		private void MakeArcanaInventory() {} // 0x00000001873488F0-0x0000000187348B20
		private void MakeEggsInventory(CharacterController player) {} // 0x0000000187348B20-0x0000000187348CD0
	}
}
