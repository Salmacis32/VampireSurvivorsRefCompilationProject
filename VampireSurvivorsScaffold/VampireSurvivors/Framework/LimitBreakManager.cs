/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class LimitBreakManager // TypeDefIndex: 17506
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private DataManager _dataManager; // 0x18
		private List<WeaponType> _excludedWeapons; // 0x20
		private const int LevelUpOptions = 3; // Metadata: 0x019786AD
		private const string PropNameMax = "max"; // Metadata: 0x019786AE
		private const string PropNameRarity = "rarity"; // Metadata: 0x019786B2
	
		// Constructors
		public LimitBreakManager() {} // 0x0000000187338FE0-0x00000001873390A0
	
		// Methods
		public List<WeightedLimitBreak> GetLimitBreakBonuses() => default; // 0x00000001873379B0-0x0000000187337C40
		public WeightedLimitBreak GetRandomWeightedWeapon() => default; // 0x0000000187337C40-0x0000000187338800
		public bool HasLimitBreaks() => default; // 0x0000000187338800-0x0000000187338F40
		private int GetLevelUpOptions() => default; // 0x0000000187338F40-0x0000000187338FE0
	}
}
