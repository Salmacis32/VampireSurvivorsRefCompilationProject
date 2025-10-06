/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class FriendshipAmulet : NetworkPickup // TypeDefIndex: 16028
	{
		// Fields
		private static List<Equipment> s_equipmentCache; // 0x00
		private LevelUpFactory _levelUpFactory; // 0x170
		private CoherenceSync _sync; // 0x178
	
		// Constructors
		public FriendshipAmulet() {} // 0x0000000186EB9C10-0x0000000186EB9C20
		static FriendshipAmulet() {} // 0x0000000186EB9C20-0x0000000186EB9D00
	
		// Methods
		[Inject]
		private void GetLevelUpFactory(LevelUpFactory levelUpFactory) {} // 0x0000000185C36330-0x0000000185C36390
		protected override void Awake() {} // 0x0000000186EB9050-0x0000000186EB90F0
		public override void GetTaken() {} // 0x0000000186EB90F0-0x0000000186EB9370
		public static void ApplyFriendshipAmuletLevelUp(WeaponType weaponType, CharacterController player) {} // 0x0000000186EB9370-0x0000000186EB9500
		public static WeaponType? GetRandomWeaponToLevelUp(CharacterController player) => default; // 0x0000000186EB9500-0x0000000186EB9A20
		private void SendOnlineLevelUps() {} // 0x0000000186EB9A20-0x0000000186EB9C10
	}
}
