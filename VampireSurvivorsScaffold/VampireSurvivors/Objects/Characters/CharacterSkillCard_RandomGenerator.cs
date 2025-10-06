/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterSkillCard_RandomGenerator // TypeDefIndex: 16862
	{
		// Fields
		public static Dictionary<STATNAME, float[]> StatBonuses; // 0x00
		public static Dictionary<STATNAME, float[]> StatPerLevelGrowth; // 0x08
		private static Array StatNameValues; // 0x10
		private static bool IsInitialised; // 0x18
		public static int TotalWeight; // 0x1C
		public static List<ArcanaType> SubSkills_Foil; // 0x28
		public static List<ArcanaType> SubSkills_All; // 0x30
		public static List<ArcanaType> SubSkills_AddWeapon; // 0x38
		public static List<ArcanaType> SubSkills_XLevel; // 0x40
		public static List<ArcanaType> SubSkills_OnSkip; // 0x48
		public static List<ArcanaType> SubSkills_EnemiesCount; // 0x50
		public static List<ArcanaType> SubSkills_OnDamaged; // 0x58
		public static List<ArcanaType> SubSkills_OnRevive; // 0x60
		public static List<ArcanaType> SubSkills_Passives; // 0x68
		public static List<ArcanaType> SubSkills_GoldCount; // 0x70
		public static List<ArcanaType> SubSkills_Overheal; // 0x78
		public static List<ArcanaType> SubSkills_HPCritical; // 0x80
		public static int NUM_SET_DEFAULT; // 0x88
		public static int NUM_SET_EXPANSION1; // 0x8C
	
		// Properties
		public static List<WeightedArcana> WeightedSurvarots { get; set; } // 0x00000001870E08D0-0x00000001870E0930 0x00000001870E0930-0x00000001870E09F0
	
		// Nested types
		public enum STATNAME // TypeDefIndex: 16860
		{
			Amount = 0,
			Area = 1,
			Armor = 2,
			Cooldown = 3,
			Banish = 4,
			Charm = 5,
			Curse = 6,
			Defang = 7,
			Duration = 8,
			Fever = 9,
			Greed = 10,
			Growth = 11,
			InvulTimeBonus = 12,
			Luck = 13,
			Magnet = 14,
			MaxHp = 15,
			MoveSpeed = 16,
			Power = 17,
			Recycle = 18,
			Regen = 19,
			ReRolls = 20,
			Revivals = 21,
			Shroud = 22,
			Skips = 23,
			Speed = 24
		}
	
		public struct WeightedArcana // TypeDefIndex: 16861
		{
			// Fields
			public ArcanaData data; // 0x00
			public float weight; // 0x08
		}
	
		// Constructors
		public CharacterSkillCard_RandomGenerator() {} // 0x0000000180B15170-0x0000000180B15180
		static CharacterSkillCard_RandomGenerator() {} // 0x00000001870E25E0-0x00000001870E4650
	
		// Methods
		public static void Init() {} // 0x00000001870E09F0-0x00000001870E0BB0
		public static void GetRandomModifierStat(ModifierStats stats, bool isGrowthValue = false /* Metadata: 0x01977EAB */) {} // 0x00000001870E0BB0-0x00000001870E0DE0
		public static void GetRandomModifierGrowth(ModifierStats stats) {} // 0x00000001870E0DE0-0x00000001870E0E40
		public static void ChangeStats(ModifierStats stats, STATNAME converted, float bonusAmount) {} // 0x00000001870E0E40-0x00000001870E1120
		public static List<int> GetRandomLevelProgression() => default; // 0x00000001870E1120-0x00000001870E1B60
		public static ArcanaType GetRandomSubCard() => default; // 0x00000001870E1B60-0x00000001870E1BD0
		public static ArcanaType GetRandomSubCard(List<ArcanaType> list) => default; // 0x00000001870E1BD0-0x00000001870E1C10
		public static ArcanaType GetOneSurvarotFromWeightedList(List<ArcanaType> exclusions, ref Unity.Mathematics.Random random) => default; // 0x00000001870E1C10-0x00000001870E24E0
		public static List<ArcanaType> GetWeightedSurvarots(int cardsNumber, ref Unity.Mathematics.Random random) => default; // 0x00000001870E24E0-0x00000001870E25E0
	}
}
