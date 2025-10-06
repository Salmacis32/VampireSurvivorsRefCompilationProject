/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.App.Framework;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Items;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Pickups
{
	[UsedImplicitly]
	public class PickupManager : IInitializable, IDisposable // TypeDefIndex: 16019
	{
		// Fields
		private static PickupFactory _pickupFactory; // 0x00
		private static readonly List<Pickup> PickupItems; // 0x08
	
		// Properties
		public static List<Pickup> Pickups { get => default; } // 0x0000000186EB64A0-0x0000000186EB6500 
		public static PickupFactory PickupFactory { get => default; } // 0x0000000186EB6500-0x0000000186EB6560 
	
		// Constructors
		public PickupManager() {} // 0x0000000180B15170-0x0000000180B15180
		static PickupManager() {} // 0x0000000186EB75E0-0x0000000186EB76C0
	
		// Methods
		[Inject]
		private void Construct(PickupFactory pickupFactory) {} // 0x0000000186EB6560-0x0000000186EB6610
		public void Initialize() {} // 0x0000000186EB6610-0x0000000186EB6680
		public void Dispose() {} // 0x0000000186EB6680-0x0000000186EB66D0
		public static Pickup CreatePickup(Vector2 pos, VampireSurvivors.Data.ItemType itemType) => default; // 0x0000000186EB66D0-0x0000000186EB68C0
		public static void ReturnPickup(Pickup pickup) {} // 0x0000000186EB68C0-0x0000000186EB6A00
		public static void RemovePickup(Pickup pickup) {} // 0x0000000186EB6A00-0x0000000186EB6AE0
		public static void AddPickup(Pickup pickup) {} // 0x0000000186EB6AE0-0x0000000186EB6B60
		public static void Cleanup() {} // 0x0000000186EB6B60-0x0000000186EB6C20
		public static bool IsPickupItemInWorld(VampireSurvivors.Data.ItemType itemType) => default; // 0x0000000186EB6C20-0x0000000186EB6D60
		public static Pickup GetPickupItemFromWorld(VampireSurvivors.Data.ItemType itemType) => default; // 0x0000000186EB6D60-0x0000000186EB6EE0
		public static PickupRelic GetRelicItemFromWorld(VampireSurvivors.Data.ItemType relicType) => default; // 0x0000000186EB6EE0-0x0000000186EB7080
		public static List<Pickup> GetAllPickupsOfTypes(params VampireSurvivors.Data.ItemType[] types) => default; // 0x0000000186EB7080-0x0000000186EB7270
		public static bool IsWeaponPickupItemInWorld(WeaponType weaponType) => default; // 0x0000000186EB7270-0x0000000186EB73D0
		public static PickupWeapon GetPickupWeaponFromWorld(WeaponType weaponType) => default; // 0x0000000186EB73D0-0x0000000186EB7570
		private void GeneratePools() {} // 0x0000000186EB6610-0x0000000186EB6680
		public static ObjectPool GetPool(VampireSurvivors.Data.ItemType itemType) => default; // 0x0000000186EB7570-0x0000000186EB75E0
	}
}
