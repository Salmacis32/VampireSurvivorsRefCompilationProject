/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class ArcanaManager : GameTickable, IInitializable, IDisposable // TypeDefIndex: 17442
	{
		// Fields
		[Inject]
		private GameSessionData _gameSessionData; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private WeaponsFacade _weaponsFacade; // 0x20
		[Inject]
		private DataManager _dataManager; // 0x28
		[Inject]
		private SignalBus _signalBus; // 0x30
		[Inject]
		private GameManager _gameManager; // 0x38
		[Inject]
		private LootManager _lootManager; // 0x40
		private SarabandeWeapon _sarabandeWeapon; // 0x48
		private FireExplosionWeapon _fireExplosionWeapon; // 0x50
		private ColdExplosionWeapon _coldExplosionWeapon; // 0x58
		private GemCannonWeapon _gemCannonWeapon; // 0x60
		private DivineBloodlineWeapon _divineBloodlineWeapon; // 0x68
		private WickedSeason _wickedSeason; // 0x70
		private BloodAstronomiaWeapon _bloodAstronomiaWeapon; // 0x78
		private JetBlackWeapon _jetBlackWeapon; // 0x80
		private MadMoonWeapon _madMoonWeapon; // 0x88
		private bool _hasWickedSeason; // 0x90
		private bool _hasSilentSanctuary; // 0x91
		private bool _hasAstronomia; // 0x92
		private bool _hasSapphireMist; // 0x93
		private bool _hasBreadAnathema; // 0x94
		private bool _hasMoonlightBolero; // 0x95
		private bool _hasHailFromTheFuture; // 0x96
		private bool _hasJetBlackWeapon; // 0x97
		private bool _hasCrystalCries; // 0x98
		private bool _hasMadMoon; // 0x99
		private bool _hasVictorianHorror; // 0x9A
		private float _heartOfFireStartingPower; // 0xA4
		private readonly Dictionary<VampireSurvivors.Objects.Characters.CharacterController, List<WeaponType>> _beginning; // 0xA8
		public static float CritMul; // 0x00
		public static float ThornsValue; // 0x04
		private List<Destructible> m_newDestructibles; // 0xE0
		private ArcanaManager_VFX arcanaManager_VFX; // 0xE8
		private ArcanaManager_Support arcanaManager_Support; // 0xF0
	
		// Properties
		public SarabandeWeapon SarabandeWeapon { get => default; } // 0x0000000180B15760-0x0000000180B15770 
		public float SilentCooldown { get; private set; } // 0x000000018675D2F0-0x000000018675D300 0x000000018675D300-0x000000018675D310
		public float SilentMight { get; private set; } // 0x00000001846DB9B0-0x00000001846DB9C0 0x0000000186758970-0x0000000186758980
		public ArcanaManager_Support ArcaneManagerSupport { get => default; } // 0x00000001819716C0-0x00000001819716D0 
		public List<ArcanaType> ActiveArcanas { get; private set; } // 0x00000001819A0190-0x00000001819A01A0 0x0000000182743780-0x00000001827437E0
		private bool HealOnCoins { get; set; } // 0x00000001847A2F00-0x00000001847A2F10 0x00000001857FB7A0-0x00000001857FB7B0
		public bool CoinFever { get; private set; } // 0x00000001857FB7B0-0x00000001857FB7C0 0x00000001857FB7C0-0x00000001857FB7D0
		public bool MadGroove { get; private set; } // 0x00000001872C0950-0x00000001872C0960 0x00000001872C0960-0x00000001872C0970
		private bool CanGather { get; set; } // 0x00000001872C0970-0x00000001872C0980 0x00000001872C0980-0x00000001872C0990
		public List<WeaponType> HeartOfFireWeapons { get; private set; } // 0x00000001819A0460-0x00000001819A0470 0x0000000182743940-0x00000001827439A0
		public FireExplosionWeapon FireExplosionWeapon { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		private VampireSurvivors.Objects.Characters.CharacterController ActivePlayer { get => default; } // 0x0000000181994FF0-0x0000000181995010 
		public WickedSeason WickedSeason { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public float XpMultiplier { get; set; } // 0x0000000183725DE0-0x0000000183725DF0 0x0000000183725DF0-0x0000000183725E00
		public float DivineBloodlineHpBonusUnit { get; set; } // 0x0000000183725E00-0x0000000183725E10 0x0000000183725E10-0x0000000183725E20
		public bool HasDivineBloodline { get; set; } // 0x0000000182908290-0x00000001829082A0 0x0000000184BDAFD0-0x0000000184BDAFE0
		public bool HasAstronomia { get => default; } // 0x00000001854115D0-0x00000001854115E0 
		public bool HasMoonlightBolero { get => default; } // 0x0000000185410C30-0x0000000185410C40 
		public bool HasHailFromTheFuture { get => default; } // 0x00000001872C0AE0-0x00000001872C0AF0 
		public bool HasSapphireMist { get => default; } // 0x00000001854115E0-0x00000001854115F0 
		public bool HasCrystalCries { get => default; } // 0x00000001819A0450-0x00000001819A0460 
		public bool HasBreadAnathema { get => default; } // 0x0000000182649830-0x0000000182649840 
		public bool HasMadMoon { get => default; } // 0x00000001826E9A80-0x00000001826E9A90 
		public bool HasVictorianHorror { get => default; } // 0x00000001872C0AF0-0x00000001872C0B00 
		public int MinTreasureChestLevel { get; set; } // 0x0000000183726220-0x0000000183726230 0x0000000183726230-0x0000000183726240
		public bool PewPew { get; set; } // 0x0000000182816BD0-0x0000000182816BE0 0x0000000182816BE0-0x0000000182816BF0
		public int MaxArcanasPerRun { get; set; } // 0x0000000181E318F0-0x0000000181E31900 0x0000000181E31900-0x0000000181E31910
	
		// Constructors
		public ArcanaManager() {} // 0x00000001872CA940-0x00000001872CAC10
		static ArcanaManager() {} // 0x00000001872CAC10-0x00000001872CAC70
	
		// Methods
		public List<WeaponType> Beginning(VampireSurvivors.Objects.Characters.CharacterController player) => default; // 0x00000001872C0990-0x00000001872C0AE0
		public void Initialize() {} // 0x00000001872C0B00-0x00000001872C0F60
		public void Dispose() {} // 0x00000001872C0F60-0x00000001872C1100
		protected override void OnTick() {} // 0x00000001872C1100-0x00000001872C13E0
		public void OnGameManagerInitialization() {} // 0x00000001872C13E0-0x00000001872C13F0
		public void InitializeVFX() {} // 0x00000001872C13F0-0x00000001872C1490
		public void InitializeSupportObjects() {} // 0x00000001872C1490-0x00000001872C1680
		public void TriggerArcana(ArcanaType arcanaType) {} // 0x00000001872C1680-0x00000001872C3BE0
		public void CheckSilent() {} // 0x00000001872C3BE0-0x00000001872C4110
		public void TriggerAwake(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872C4110-0x00000001872C4650
		public void TriggerSarabande(float damage, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872C4650-0x00000001872C4860
		public void TriggerFireExplosion(Vector2 pos) {} // 0x00000001872C4860-0x00000001872C4980
		public void TriggerColdExplosion(Vector2 pos) {} // 0x00000001872C4980-0x00000001872C4AE0
		public void TriggerGemCannon(float damage, string frameName, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872C4AE0-0x00000001872C4D30
		public void TriggerAstronomia(Weapon weapon) {} // 0x00000001872C4D30-0x00000001872C5600
		public bool HasRandomazzoEnabled() => default; // 0x00000001872C5600-0x00000001872C56F0
		public bool HasSurvarotsEnabled() => default; // 0x00000001872C56F0-0x00000001872C57F0
		public void OnWeaponFired(Weapon weapon) {} // 0x00000001872C57F0-0x00000001872C5A80
		public void OnFoodPickedUp(VampireSurvivors.Objects.Characters.CharacterController character, VampireSurvivors.Data.ItemType itemType, float value) {} // 0x00000001872C5A80-0x00000001872C5AF0
		public void OnPlayerLevelUp(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001872C5AF0-0x00000001872C5C70
		public void OnPlayerHPRecovery(VampireSurvivors.Objects.Characters.CharacterController character, float rawValue) {} // 0x00000001872C5C70-0x00000001872C5F40
		public void OnPlayerHPDamage(VampireSurvivors.Objects.Characters.CharacterController character, float rawValue) {} // 0x00000001872C5F40-0x00000001872C61B0
		public void OnPlayerLastBreath(VampireSurvivors.Objects.Characters.CharacterController character, float rawValue) {} // 0x00000001872C61B0-0x00000001872C62F0
		public void OnPlayerCriticalHPTreshold(VampireSurvivors.Objects.Characters.CharacterController character, float rawValue) {} // 0x00000001872C62F0-0x00000001872C6380
		public void OnPlayerHPRecovery(VampireSurvivors.Objects.Characters.CharacterController character, float rawValue, float actualRecovery) {} // 0x00000001872C6380-0x00000001872C63A0
		public void AddHeartOfFireWeapon(Weapon weapon, float newWeaponPower) {} // 0x00000001872C63A0-0x00000001872C6590
		private void ActivateSpeedSineBonus() {} // 0x00000001872C6590-0x00000001872C6750
		private void ActivateDurationSineBonus() {} // 0x00000001872C6750-0x00000001872C6910
		private void ActivateAreaSineBonus() {} // 0x00000001872C6910-0x00000001872C6AD0
		private void ActivateHeartOfFireRetaliation() {} // 0x00000001872C6AD0-0x00000001872C6CE0
		private void CheckOnAllWeapons() {} // 0x00000001872C6CE0-0x00000001872C70C0
		private void PickedUpCoin(GameplaySignals.OnAfterCoinsAddedSignal signal) {} // 0x00000001872C70C0-0x00000001872C7110
		private void ActivateLevelUpBonus(string property, float value) {} // 0x00000001872C7110-0x00000001872C74C0
		public void IncreaseBloodlineBonus(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x00000001872C74C0-0x00000001872C7600
		private void Cleanup() {} // 0x00000001872C7600-0x00000001872C7670
		private void GatherAllStageItems() {} // 0x00000001872C7670-0x00000001872C8DA0
		private List<Pickup> GetSubset(List<Pickup> items, int playerIndex, int playerCount) => default; // 0x00000001872C8DA0-0x00000001872C8E80
		private void GatherStageItemsForPosition(float2 playerPos, List<Pickup> items, List<Pickup> others, List<Pickup> coins, List<Pickup> gems, float destructiblesProportion) {} // 0x00000001872C8E80-0x00000001872C9F00
		private void GatherAllDestructibles(float2 playerPos, float radius4, float proportionOfMax) {} // 0x00000001872C9F00-0x00000001872CA940
	}
}
