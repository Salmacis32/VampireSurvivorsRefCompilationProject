/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class LevelUpFactory : IInitializable, IDisposable // TypeDefIndex: 17503
	{
		// Fields
		private float _defaultXPFactor; // 0x10
		private float _currentXpFactor; // 0x14
		private float _previousXpFactor; // 0x18
		private float _chanceForExistingPowerUp; // 0x1C
		private int _levelUpOptions; // 0x20
		private int _accumulatedWeight; // 0x24
		private bool _useDebugLog; // 0x28
		private static LinkedList<WeaponType> _weaponStore; // 0x00
		private static LinkedList<WeaponType> _excludedWeapons; // 0x08
		private static LinkedList<WeaponType> _specialWeapons; // 0x10
		private static LinkedList<WeaponType> _banishedWeapons; // 0x18
		private static List<WeightedWeapon> _weightedStore; // 0x20
		[Inject]
		private GameSessionData _gameSessionData; // 0x30
		[Inject]
		private SignalBus _signalBus; // 0x38
		[Inject]
		private DataManager _data; // 0x40
		[Inject]
		private PlayerOptions _playerOptions; // 0x48
		[Inject]
		private CoopConfig _coopConfig; // 0x50
		private List<WeaponType> _unlockedWeapons; // 0x58
		private List<CharacterController> _cachedPlayerList; // 0x60
		private List<bool> _coopAmuletBag; // 0x68
	
		// Properties
		public float XpRequiredToLevelUp { get => default; } // 0x00000001828A3D30-0x00000001828A3D40 
		public float PreviousXpRequiredToLevelUp { get => default; } // 0x000000018264AEB0-0x000000018264AEC0 
		public List<WeightedWeapon> WeightedStore { get => default; } // 0x000000018732BF30-0x000000018732BF90 
		public LinkedList<WeaponType> WeaponStore { get => default; } // 0x000000018732BF90-0x000000018732BFF0 
		public LinkedList<WeaponType> ExcludedWeapons { get => default; } // 0x000000018732BFF0-0x000000018732C050 
		public LinkedList<WeaponType> BanishedWeapons { get => default; } // 0x000000018732C050-0x000000018732C0B0 
		public LinkedList<WeaponType> SpecialWeapons { get => default; } // 0x000000018732C0B0-0x000000018732C110 
	
		// Constructors
		public LevelUpFactory() {} // 0x0000000187337660-0x0000000187337740
		static LevelUpFactory() {} // 0x0000000187337740-0x0000000187337820
	
		// Methods
		public void Initialize() {} // 0x000000018732B870-0x000000018732BC90
		public void Dispose() {} // 0x000000018732BC90-0x000000018732BF30
		public void Init() {} // 0x000000018732C110-0x000000018732C210
		public void CalculateXpFactor() {} // 0x000000018732C210-0x000000018732C6B0
		public void ForceExclude(WeaponType t) {} // 0x000000018732C6B0-0x000000018732C7C0
		public void Banish(WeaponType t) {} // 0x000000018732C7C0-0x000000018732CAB0
		public bool IsBanished(WeaponType t) => default; // 0x000000018732CAB0-0x000000018732CB50
		public bool IsBlockedDueToCoop(WeaponType t, CharacterController character) => default; // 0x000000018732CB50-0x000000018732D190
		public LinkedList<WeaponType> GetBanishedWeapons() => default; // 0x000000018732D190-0x000000018732D1F0
		public Dictionary<WeaponType, List<WeaponData>> GetWeapons() => default; // 0x000000018732D1F0-0x000000018732D210
		public List<WeaponType> GetExistingNotMaxedWeapons(CharacterController character) => default; // 0x000000018732D210-0x000000018732D960
		public void AddLateWeapon(WeaponType weapon, CharacterController character) {} // 0x000000018732D960-0x000000018732DD80
		public List<WeaponType> RerollLevelUpPowerUps(List<WeaponType> excludedWeapons, CharacterController character) => default; // 0x000000018732DD80-0x000000018732DF10
		private void CalculateWeightsWithExclusions(List<WeaponType> exclusions, CharacterController character) {} // 0x000000018732DF10-0x000000018732E610
		public WeaponType GetSpecialWeapon(WeaponType weapon) => default; // 0x000000018732E610-0x000000018732E700
		public bool HasPowerupsInStore(CharacterController character) => default; // 0x000000018732E700-0x000000018732E7A0
		public void ValidatePurchasedPassiveFromMerchant(WeaponType weaponType) {} // 0x000000018732E7A0-0x000000018732E7B0
		public WeaponType PullRemainingPowerUp(CharacterController character) => default; // 0x000000018732E7B0-0x000000018732EBF0
		public WeaponType PullRemainingExistingWeapon(CharacterController character, bool includePowerUps = true /* Metadata: 0x019786AB */) => default; // 0x000000018732EBF0-0x000000018732F450
		public WeaponType PullNewWeapon(CharacterController character, bool includePowerUps = true /* Metadata: 0x019786AC */) => default; // 0x000000018732F450-0x000000018732FCC0
		public WeaponType PullExisting(WeaponType weapontype) => default; // 0x000000018732FCC0-0x000000018732FDF0
		private List<Equipment> GetAvailableEquipmentForEvolution(CharacterController character) => default; // 0x000000018732FDF0-0x0000000187330500
		public bool HasPotentialEvolution(CharacterController character) => default; // 0x0000000187330500-0x00000001873307B0
		public WeaponType PullEvolution(CharacterController character) => default; // 0x00000001873307B0-0x0000000187330E70
		private bool HasEvolutionRequirements(WeaponData data, List<Equipment> held, CharacterController characterController) => default; // 0x0000000187330E70-0x00000001873318F0
		public static bool CheckUniqueRequirements(WeaponData data, List<Equipment> held, CharacterController characterController) => default; // 0x00000001873318F0-0x00000001873319A0
		private static bool AlucardShieldUniqueRequirements(List<Equipment> held) => default; // 0x00000001873319A0-0x0000000187331D50
		private static bool CalamityRingUniqueRequirements(List<Equipment> held) => default; // 0x0000000187331D50-0x0000000187331F60
		public void InitialiseWeights() {} // 0x0000000187331F60-0x0000000187331F90
		public void CalculateWeights(CharacterController character) {} // 0x0000000187331F90-0x0000000187332C50
		public List<WeaponType> GetLevelUpPowerups(CharacterController character) => default; // 0x0000000187332C50-0x00000001873338C0
		public List<VampireSurvivors.Data.ItemType> GetLevelUpItems() => default; // 0x00000001873338C0-0x0000000187333AF0
		private bool HasEnoughCoinBag2Pickups(PlayerOptionsData config) => default; // 0x0000000187333AF0-0x0000000187333BA0
		public void RemoveFromStore(WeaponType weapon, CharacterController character) {} // 0x0000000187333BA0-0x0000000187333D00
		public void RemoveFromSpecialWeapons(WeaponType weapon) {} // 0x0000000187333D00-0x0000000187333D80
		public WeaponType GetRandomExistingWeapon(CharacterController character) => default; // 0x0000000187333D80-0x0000000187334330
		public bool DoesWeaponStoreContainWeaponType(WeaponType weaponType) => default; // 0x0000000187334330-0x00000001873343D0
		public void RemoveFromExcluded(GameplaySignals.RemoveWeaponFromExcluded signal) {} // 0x000000018732E7A0-0x000000018732E7B0
		public void RemoveFromExcluded(WeaponType type) {} // 0x00000001873343D0-0x0000000187334680
		public void BanishedSealedWeapons() {} // 0x0000000187334680-0x0000000187334B10
		public List<WeaponType> GetRemainingPowerupsAndWeapons() => default; // 0x0000000187334B10-0x0000000187334E00
		public List<CharacterController> FindFriendshipAmuletTargets(bool checkAmuletBag) => default; // 0x0000000187334E00-0x0000000187335450
		private void InitializeWeaponStores() {} // 0x0000000187335450-0x0000000187335860
		private void ApplyUnlocks() {} // 0x0000000187335860-0x0000000187335B30
		private void ProcessBaseWeaponData() {} // 0x0000000187335B30-0x0000000187335FA0
		public void ExcludeNonOwnedLockedWeapons(List<CharacterController> allPlayers) {} // 0x0000000187335FA0-0x0000000187336720
		private static WeaponType TryParseType(string type) => default; // 0x0000000187336720-0x00000001873367D0
		private List<WeaponType> GetRemainingNotMaxedWeapons() => default; // 0x00000001873367D0-0x0000000187336A00
		private static WeaponType GetWeaponFromWeightedStore(List<WeightedWeapon> store, double value) => default; // 0x0000000187336A00-0x0000000187336B90
		private WeaponType GetRandomWeightedWeaponOrPowerUp() => default; // 0x0000000187336B90-0x0000000187336CA0
		private WeaponType GetRandomWeightedWeapon(CharacterController character) => default; // 0x0000000187336CA0-0x0000000187337240
		private int GetLevelUpOptions() => default; // 0x0000000187337240-0x0000000187337300
		private float ChanceForExistingPowerUp() => default; // 0x0000000187337300-0x0000000187337390
		private void InitAmuletBag() {} // 0x0000000187337390-0x0000000187337660
	}
}
