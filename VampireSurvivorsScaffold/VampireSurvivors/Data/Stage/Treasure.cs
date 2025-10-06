/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Data.Stage
{
	[Serializable]
	[Title("Treasure")]
	public class Treasure // TypeDefIndex: 18457
	{
		// Fields
		[NonSerialized]
		public bool QuickTreasureAnim; // 0x32
		[NonSerialized]
		public CharacterController openingPlayer; // 0x38
		[NonSerialized]
		public CharacterController winningPlayer; // 0x40
		[NonSerialized]
		public List<TreasurePrizeTypePair> prizes; // 0x48
		[NonSerialized]
		public List<WeaponType> accumulatedWeaponPrizes; // 0x50
		[NonSerialized]
		public float accumulatedCoinPrize; // 0x58
		[NonSerialized]
		public float quickAddedCoins; // 0x5C
		[NonSerialized]
		public List<WeaponType> accumulatedWorldSpacePrizes; // 0x60
	
		// Properties
		[Title("Chances")]
		public List<float> chances { get; set; } // 0x0000000180B15C10-0x0000000180B15C20 0x0000000181958310-0x0000000181958370
		[Title("Level")]
		public int level { get; set; } // 0x00000001819457C0-0x00000001819457D0 0x000000018195FC50-0x000000018195FC60
		[Title("Prize Types")]
		public List<PrizeType?> prizeTypes { get; set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		[Title("Fixed Prizes")]
		public List<WeaponType> fixedPrizes { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		[Title("Has Arcana")]
		public bool hasArcana { get; set; } // 0x0000000180B1C110-0x0000000180B1C120 0x000000018197EA10-0x000000018197EA20
		[Title("Has Randoms")]
		public bool hasRandoms { get; set; } // 0x000000018197EA20-0x000000018197EA30 0x000000018197EA30-0x000000018197EA40
	
		// Constructors
		public Treasure() {} // 0x000000018675B240-0x000000018675B300
	
		// Methods
		public void AddPrizes(List<TreasurePrizeTypePair> argPrizes, List<WeaponType> argAccumulatedWeaponPrizes, int argAccumulatedCoinPrize, List<WeaponType> argAccumulatedWorldSpacePrizes = null) {} // 0x000000018675A6E0-0x000000018675A810
		public int GetCoinPrize() => default; // 0x000000018675A810-0x000000018675A930
		public void ClaimPrizes(CharacterController character) {} // 0x000000018675A930-0x000000018675B130
		private void SpawnWorldSpaceWeapon(float x, float y, WeaponType weaponPrize, float delay) {} // 0x000000018675B130-0x000000018675B240
	}
}
