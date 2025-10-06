/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterSkillCardsManager // TypeDefIndex: 16812
	{
		// Fields
		private List<CharacterSkillCard_Base> _characterCards; // 0x10
	
		// Properties
		public List<CharacterSkillCard_Base> ActiveCards { get => default; } // 0x0000000180B15C10-0x0000000180B15C20 
	
		// Constructors
		public CharacterSkillCardsManager() {} // 0x00000001870D5B80-0x00000001870D5C40
	
		// Methods
		public void AddCharacterCard(CharacterSkillCard_Base card) {} // 0x00000001870D1DB0-0x00000001870D1E20
		public void OnOwnerRevived(float percentage = 1f /* Metadata: 0x01977E7D */, bool instantRevival = false /* Metadata: 0x01977E81 */) {} // 0x00000001870D1E20-0x00000001870D1F00
		public void OnOwnerLevelUpSkipped() {} // 0x00000001870D1F00-0x00000001870D1FC0
		public void OnOwnerGetDamaged(float damageAmount) {} // 0x00000001870D1FC0-0x00000001870D2090
		public void OnOwnerCriticalHPTreshold(float rawValue) {} // 0x00000001870D2090-0x00000001870D2160
		public void OnOwnerLevelUp() {} // 0x00000001870D2160-0x00000001870D2220
		public void UpdateCards() {} // 0x00000001870D2220-0x00000001870D22E0
		public static List<SkillCardEdition> GetSpecialEditions(int cardCount, ref Unity.Mathematics.Random random) => default; // 0x00000001870D22E0-0x00000001870D2480
		public static List<SkillCardEdition> GetRandomEditions(int totalCardsInDraft, ref Unity.Mathematics.Random random) => default; // 0x00000001870D2480-0x00000001870D26D0
		public static SkillCardEdition GetWeightedEdition(ref Unity.Mathematics.Random random, float wBase = 75f /* Metadata: 0x01977E82 */, float wFoil = 4f /* Metadata: 0x01977E86 */, float wGala = 4f /* Metadata: 0x01977E8A */, float wHolo = 7f /* Metadata: 0x01977E8E */, float wPoly = 7f /* Metadata: 0x01977E92 */, float wInve = 3f /* Metadata: 0x01977E96 */) => default; // 0x00000001870D26D0-0x00000001870D2C40
		public static float GetSurvarotDifficultyMultiplier() => default; // 0x00000001870D2C40-0x00000001870D3180
		public static float AdjustAdditionalEnemiesHPMultiplierWithINVE(float currentMul) => default; // 0x00000001870D3180-0x00000001870D35E0
		public static CharacterSkillCard_Base GetCardForArcanaType(ArcanaType arcanaType) => default; // 0x00000001870D35E0-0x00000001870D4A70
		public static float SvMult_AnyRare() => default; // 0x00000001870D4A70-0x00000001870D4CE0
		public static float SvMult_Foil() => default; // 0x00000001870D4CE0-0x00000001870D4F50
		public static float SvMult_Gala() => default; // 0x00000001870D4F50-0x00000001870D51C0
		public static float SvMult_Poly() => default; // 0x00000001870D51C0-0x00000001870D5430
		public static float SvMult_Holo() => default; // 0x00000001870D5430-0x00000001870D56A0
		public static float SvMult_Inve() => default; // 0x00000001870D56A0-0x00000001870D5910
		public static float SvMult_Base() => default; // 0x00000001870D5910-0x00000001870D5B80
	}
}
