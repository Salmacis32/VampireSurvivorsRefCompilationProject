/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence;
using Coherence.Connection;
using Coherence.Log;
using Coherence.Toolkit;
using Coherence.Toolkit.Bindings;
using Coherence.Toolkit.ReplicationServer;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Stages;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class OnlineStageManager : MonoBehaviour // TypeDefIndex: 14053
	{
		// Fields
		public Action<int, PlayerInfo> OnSeatAssigned; // 0x48
		public Action OnBecomeAuthority; // 0x50
		[NonSerialized]
		[OnValueSynced("OnSeatAssignedRemotely")]
		[Sync]
		public uint _firstSeat; // 0x58
		[NonSerialized]
		[OnValueSynced("OnSeatAssignedRemotely")]
		[Sync]
		public uint _secondSeat; // 0x5C
		[NonSerialized]
		[OnValueSynced("OnSeatAssignedRemotely")]
		[Sync]
		public uint _thirdSeat; // 0x60
		[NonSerialized]
		[OnValueSynced("OnSeatAssignedRemotely")]
		[Sync]
		public uint _fourthSeat; // 0x64
		private CoherenceSync _sync; // 0x78
		private bool _signalledGameStart; // 0x80
		private bool _signalledInitializeGameSession; // 0x81
		private bool _signalledInitStage; // 0x82
		private bool _isResumingGame; // 0x83
		private Coherence.Log.Logger _logger; // 0x88
		private IReplicationServer _replicationServer; // 0x90
		private List<byte[]> _powerUpChunks; // 0x98
		private Unity.Mathematics.Random _minorArcanasRng; // 0xA0
		private Unity.Mathematics.Random _survarotsRng; // 0xA4
		private Unity.Mathematics.Random _uiPageRng; // 0xA8
		private SignalBus _signalBus; // 0xB0
		private long _lastCalculatedSimulationFrame; // 0xB8
		private bool _sentOpenTerrace; // 0xC0
		private static OnlineStageManager _instance; // 0x00
		private OnlinePlatformSupportBase _onlinePlatformSupport; // 0xC8
		private bool _sentPauseRequest; // 0xD0
	
		// Properties
		public static OnlineStageManager Instance { get => default; } // 0x0000000186AEB090-0x0000000186AEB0D0 
		public OnlinePlatformSupportBase OnlinePlatformSupport { get => default; } // 0x00000001827666D0-0x00000001827666E0 
		public bool IsHost { get => default; } // 0x0000000186AEB0D0-0x0000000186AEB140 
		public CoherenceSync Sync { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public int NumberOfConnectedPlayers { get => default; } // 0x0000000186AEB140-0x0000000186AEB220 
		public List<WeaponType> ChosenLevelUpWeapons { get; private set; } // 0x0000000180B15530-0x0000000180B15540 0x0000000180B1C120-0x0000000180B1C180
		public List<VampireSurvivors.Data.ItemType> ChosenLevelUpItems { get; private set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public List<VampireSurvivors.Objects.Characters.CharacterController> ChosenAmuletTargets { get; private set; } // 0x0000000180B15550-0x0000000180B15560 0x0000000180B1D520-0x0000000180B1D580
		public List<WeightedLimitBreak> ChosenLimitBreaks { get; private set; } // 0x0000000180B15560-0x0000000180B15570 0x0000000181953C20-0x0000000181953C80
		public bool ListenForHostDisconnection { get; set; } // 0x0000000182699160-0x0000000182699170 0x0000000182699170-0x0000000182699180
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint RandomEventsSeed { get; set; } // 0x0000000182A74C20-0x0000000182A74C30 0x0000000182A74C30-0x0000000182A74C40
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint MinorArcanasSeed { get; set; } // 0x0000000181B5A280-0x0000000181B5A290 0x0000000181B5A290-0x0000000181B5A2A0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint SurvarotsSeed { get; set; } // 0x00000001819A0220-0x00000001819A0230 0x0000000181B5A2A0-0x0000000181B5A2B0
		[Sync(DefaultSyncMode = SyncMode.CreationOnly)]
		public uint UiPageSeed { get; set; } // 0x0000000182926720-0x0000000182926730 0x00000001851EFAA0-0x00000001851EFAB0
		public Unity.Mathematics.Random MinorArcanasRng { get => default; } // 0x0000000181DEFE80-0x0000000181DEFE90 
		public Unity.Mathematics.Random SurvarotsRng { get => default; } // 0x0000000182949870-0x0000000182949880 
		[Sync]
		public int StageEventSpawned { get => default; set {} } // 0x0000000186AEB220-0x0000000186AEB400 0x0000000186AEB400-0x0000000186AEB5F0
		[Sync]
		public bool ControlTimeScale { get => default; set {} } // 0x0000000186AEB5F0-0x0000000186AEB690 0x0000000186AEB690-0x0000000186AEB730
	
		// Nested types
		private class GlimmerQueueEntry // TypeDefIndex: 14029
		{
			// Fields
			public CoherenceSync Player; // 0x10
			public bool IsActiveEquipment; // 0x18
			public int WeaponIndex; // 0x1C
	
			// Constructors
			public GlimmerQueueEntry() {} // Dummy constructor
			public GlimmerQueueEntry(CoherenceSync player, bool isActiveEquipment, int weaponIndex) {} // 0x0000000184F3EC80-0x0000000184F3ECF0
		}
	
		// Constructors
		public OnlineStageManager() {} // 0x0000000186AFC550-0x0000000186AFC5B0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x0000000182743780-0x00000001827437E0
		public int NextUiPageInt() => default; // 0x0000000186AEB730-0x0000000186AEB760
		[IteratorStateMachine(typeof(_IterateSeats_d__80))]
		public IEnumerable<PlayerInfo> IterateSeats() => default; // 0x0000000186AEB760-0x0000000186AEB810
		public static bool IsHostInTheGame() => default; // 0x0000000186AEB810-0x0000000186AEB9F0
		public List<VampireSurvivors.Objects.Characters.CharacterController> GetPlayerCharacters() => default; // 0x0000000186AEB9F0-0x0000000186AEBD90
		public int GetSeatNumberForCharacter(VampireSurvivors.Objects.Characters.CharacterController characterController) => default; // 0x0000000186AEBD90-0x0000000186AEC0A0
		public PlayerInfo GetPlayerInfoForCharacter(VampireSurvivors.Objects.Characters.CharacterController characterController) => default; // 0x0000000186AEC0A0-0x0000000186AEC3B0
		public VampireSurvivors.Objects.Characters.CharacterController GetCharacterForSeatNumber(int seatNumber) => default; // 0x0000000186AEC3B0-0x0000000186AEC5E0
		public List<VampireSurvivors.Data.CharacterType> GetCharacterSelections() => default; // 0x0000000186AEC5E0-0x0000000186AEC8D0
		public List<VampireSurvivors.Objects.Characters.CharacterController> GetOrderedCharacterControllers() => default; // 0x0000000186AEC8D0-0x0000000186AECBC0
		public int GetMySeatNumber() => default; // 0x0000000186AECBC0-0x0000000186AECE90
		public PlayerInfo GetMyPlayerInfo() => default; // 0x0000000186AECE90-0x0000000186AECFB0
		public PlayerInfo GetHostPlayerInfo() => default; // 0x0000000186AECFB0-0x0000000186AECFC0
		public int GetHighestAverageLatencyMs() => default; // 0x0000000186AECFC0-0x0000000186AED250
		public long GetStartingOnlineClientFrame() => default; // 0x0000000186AED250-0x0000000186AEDBC0
		public bool IsHostClientConnection(CoherenceClientConnection clientConn) => default; // 0x0000000186AEDBC0-0x0000000186AEDC30
		public void InjectDeps(IReplicationServer replicationServer) {} // 0x000000018198E590-0x000000018198E5F0
		public bool AreAllPlayersInsideGameplayUi(int uiPageId) => default; // 0x0000000186AEDC30-0x0000000186AEDEE0
		public void SendLoadGameplayScene() {} // 0x0000000186AEDEE0-0x0000000186AEE020
		[IteratorStateMachine(typeof(__WaitToStartOnline_d__97))]
		private IEnumerator _WaitToStartOnline() => default; // 0x0000000186AEE020-0x0000000186AEE0C0
		[Command]
		public void ReloadCurrentScene() {} // 0x0000000186AEE0C0-0x0000000186AEE1B0
		[Command]
		public void LockOnlineUI() {} // 0x0000000186AEE1B0-0x0000000186AEE2C0
		[Command]
		public void LoadGameplayScene() {} // 0x0000000186AEE2C0-0x0000000186AEE3E0
		[Command]
		public void InitializeGameSession(long startingSimulationFrame) {} // 0x0000000186AEE3E0-0x0000000186AEE4E0
		[Command]
		public void InitializeStageLogic(long startingSimulationFrame) {} // 0x0000000186AEE4E0-0x0000000186AEE5B0
		[Command]
		public void StartGameplay(long startingSimulationFrame) {} // 0x0000000186AEE5B0-0x0000000186AEE680
		private void SubscribeToSignals() {} // 0x0000000186AEE680-0x0000000186AEE930
		public void SendOpenTreasureCommand() {} // 0x0000000186AEE930-0x0000000186AEEA00
		[Command]
		public void OpenTreasure(long startingSimFrame) {} // 0x0000000186AEEA00-0x0000000186AEEAE0
		public void SendClaimTreasureRequestCommand() {} // 0x0000000186AEEAE0-0x0000000186AEEB80
		[Command]
		public void ClaimTreasureRequest() {} // 0x0000000186AEEB80-0x0000000186AEECF0
		public void SendClaimTreasureCommand() {} // 0x0000000186AEECF0-0x0000000186AEEDC0
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void ClaimTreasure(long startingSimFrame) {} // 0x0000000186AEEDC0-0x0000000186AEEEA0
		public void SendOnlineLevelUpCommand(bool shouldSwapToLevelUpUi, bool adjustXpFactors, List<WeaponType> chosenWeapons, List<VampireSurvivors.Data.ItemType> chosenItems, List<VampireSurvivors.Objects.Characters.CharacterController> amuletTargets, List<WeightedLimitBreak> limitBreaks) {} // 0x0000000186AEEEA0-0x0000000186AEF3C0
		private static List<ValueTuple<string, object>> BuildLevelUpLogArgs(OnlineLevelUpData levelUpData) => default; // 0x0000000186AEF3C0-0x0000000186AEFCD0
		[Command]
		public void OnlineLevelUp(long startingSimFrame, bool shouldSwapToLevelUpUi, bool adjustXpFactors, CoherenceSync activeCharacter, byte[] chosenWeapons, byte[] chosenItems, bool hasAmuletTargets, byte[] limitBreaks) {} // 0x0000000186AEFCD0-0x0000000186AF01A0
		public void ProcessOnlineLevelUpData(OnlineLevelUpData levelUpData) {} // 0x0000000186AF01A0-0x0000000186AF0310
		public void SendLevelUpWithoutScreen() {} // 0x0000000186AF0310-0x0000000186AF03E0
		[Command]
		public void LevelUpWithoutScreen(long startingSimFrame) {} // 0x0000000186AF03E0-0x0000000186AF04B0
		public void SendFinishLevelUpCommand(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF04B0-0x0000000186AF05A0
		[Command]
		public void FinishLevelUp(long startingSimFrame, int weaponType, CoherenceSync receivingCharacter) {} // 0x0000000186AF05A0-0x0000000186AF06C0
		public void SendFinishLevelUpWithItemCommand(VampireSurvivors.Data.ItemType itemType, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF06C0-0x0000000186AF07B0
		[Command]
		public void FinishLevelUpWithItem(long startingSimFrame, int itemType, CoherenceSync receivingCharacter) {} // 0x0000000186AF07B0-0x0000000186AF0940
		public void SendFinishLevelupWithFriendshipAmuletCommand() {} // 0x0000000186AF0940-0x0000000186AF0A10
		[Command]
		public void FinishLevelUpWithFriendshipAmulet(long startingSimFrame) {} // 0x0000000186AF0A10-0x0000000186AF0AB0
		public void SendFinishLevelUpWithLimitBreak(int limitBreakIndex, bool alwaysRandomLimitBreak, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF0AB0-0x0000000186AF0C40
		[Command]
		public void FinishLevelUpWithLimitBreak(long startingSimFrame, int limitBreakIndex, bool alwaysRandomLimitBreak, CoherenceSync receivingCharacter) {} // 0x0000000186AF0C40-0x0000000186AF0DE0
		public void SendBanishWeaponCommand(WeaponType weaponType) {} // 0x0000000186AF0DE0-0x0000000186AF0EC0
		[Command]
		public void BanishWeaponOnline(long startingSimFrame, int weaponType) {} // 0x0000000186AF0EC0-0x0000000186AF0FE0
		public void SendRequestLevelUpReRoll() {} // 0x0000000186AF0FE0-0x0000000186AF1080
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestLevelUpReRoll() {} // 0x0000000186AF1080-0x0000000186AF1170
		public void SendLevelUpReRollOnline(List<WeaponType> chosenWeapons) {} // 0x0000000186AF1170-0x0000000186AF1260
		[Command]
		public void LevelUpReRollOnline(byte[] chosenWeapons) {} // 0x0000000186AF1260-0x0000000186AF13E0
		public void SendLevelUpSkipOnline() {} // 0x0000000186AF13E0-0x0000000186AF14B0
		[Command]
		public void LevelUpSkipOnline(long startingSimFrame) {} // 0x0000000186AF14B0-0x0000000186AF1550
		public void SendRequestLevelUpPassOnline() {} // 0x0000000186AF1550-0x0000000186AF15F0
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestLevelUpPassOnline() {} // 0x0000000186AF15F0-0x0000000186AF16E0
		public void SendLevelUpPassOnline(VampireSurvivors.Objects.Characters.CharacterController activePlayer, bool showStats) {} // 0x0000000186AF16E0-0x0000000186AF19C0
		[Command]
		public void LevelUpPassOnline(CoherenceSync activePlayer, bool showStats) {} // 0x0000000186AF19C0-0x0000000186AF1BC0
		public void StartFriendshipAmulet() {} // 0x0000000186AF1BC0-0x0000000186AF1C60
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestFriendshipAmulet() {} // 0x0000000186AF1C60-0x0000000186AF1EF0
		public void SendFriendshipAmuletLevelUpWeaponForCharacter(WeaponType weaponType, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF1EF0-0x0000000186AF2200
		[Command]
		public void FriendshipAmuletLevelUpWeaponForCharacter(long simFrame, int weaponType, CoherenceSync player) {} // 0x0000000186AF2200-0x0000000186AF2580
		public void SendMerchantPurchase(WeaponType weapon, VampireSurvivors.Data.ItemType item, int index, int price, VampireSurvivors.Objects.Characters.CharacterController purchasingPlayer) {} // 0x0000000186AF2580-0x0000000186AF2730
		[Command]
		public void MerchantPurchase(long simFrame, int weaponType, int itemType, int index, int price, CoherenceSync player) {} // 0x0000000186AF2730-0x0000000186AF2900
		public void SendCloseMerchant() {} // 0x0000000186AF2900-0x0000000186AF29C0
		[Command]
		public void CloseMerchant(long simFrame) {} // 0x0000000186AF29C0-0x0000000186AF2A60
		public void SendCloseItemFoundPage(bool discard) {} // 0x0000000186AF2A60-0x0000000186AF2B30
		[Command]
		public void CloseItemFoundPage(long startingSimFrame, bool discard) {} // 0x0000000186AF2B30-0x0000000186AF2C50
		public void SendSelectArcana(ArcanaType arcanaType) {} // 0x0000000186AF2C50-0x0000000186AF2D20
		[Command]
		public void SelectArcana(long startingSimFrame, int selectedArcana) {} // 0x0000000186AF2D20-0x0000000186AF2E40
		public void SendSelectCharacterCard(ArcanaType arcanaType, SkillCardEdition edition, ArcanaType? subCardType) {} // 0x0000000186AF2E40-0x0000000186AF3020
		[Command]
		public void SelectCharacterCard(long startingSimFrame, int selectedArcana, int edition, int subCardType) {} // 0x0000000186AF3020-0x0000000186AF3160
		public void SendReRollMinorArcanas() {} // 0x0000000186AF3160-0x0000000186AF3200
		[Command]
		public void ReRollMinorArcanas() {} // 0x0000000186AF3200-0x0000000186AF32F0
		public void SendReRollCharacterCards() {} // 0x0000000186AF32F0-0x0000000186AF3390
		[Command]
		public void ReRollCharacterCards() {} // 0x0000000186AF3390-0x0000000186AF3480
		public void SendBoosterSurvarots() {} // 0x0000000186AF3480-0x0000000186AF3520
		[Command]
		public void BoosterSurvarots() {} // 0x0000000186AF3520-0x0000000186AF3610
		public void SendSkipMinorArcanas() {} // 0x0000000186AF3610-0x0000000186AF36D0
		[Command]
		public void SkipMinorArcanas(long startingSimFrame) {} // 0x0000000186AF36D0-0x0000000186AF3770
		public void SendSkipSurvarots() {} // 0x0000000186AF3770-0x0000000186AF3830
		[Command]
		public void SkipSurvarots(long startingSimFrame) {} // 0x0000000186AF3830-0x0000000186AF38D0
		public void SendSkipTreasureAnimation() {} // 0x0000000186AF38D0-0x0000000186AF3990
		[Command]
		public void SkipTreasureAnimation(long startingSimFrame) {} // 0x0000000186AF3990-0x0000000186AF3A30
		public void SendTpWeaponSkip() {} // 0x0000000186AF3A30-0x0000000186AF3AF0
		[Command]
		public void TpWeaponSkip(long startingSimFrame) {} // 0x0000000186AF3AF0-0x0000000186AF3B90
		public void SendTpWeaponSelection(WeaponType weapon) {} // 0x0000000186AF3B90-0x0000000186AF3C60
		[Command]
		public void SelectTpWeapon(long startingSimFrame, int weaponType) {} // 0x0000000186AF3C60-0x0000000186AF3D80
		public void SendCandyBoxWeaponSelection(WeaponType weapon) {} // 0x0000000186AF3D80-0x0000000186AF3E50
		[Command]
		public void SelectWeaponFromCandyBox(long startingSimFrame, int weaponType) {} // 0x0000000186AF3E50-0x0000000186AF3F70
		public void SendCandyBoxSkip() {} // 0x0000000186AF3F70-0x0000000186AF4030
		public void SendLevelUpBonusSelection(PowerUpType levelUpBonus) {} // 0x0000000186AF4030-0x0000000186AF4100
		[Command]
		public void LevelUpBonusSelection(long startingSimFrame, int powerUpBonus) {} // 0x0000000186AF4100-0x0000000186AF4220
		[Command]
		public void CandyBoxSkip(long startingSimFrame) {} // 0x0000000186AF4220-0x0000000186AF42C0
		public void SendLevelBonusSelectionSkip() {} // 0x0000000186AF42C0-0x0000000186AF4380
		[Command]
		public void LevelBonusSelectionSkip(long startingSimFrame) {} // 0x0000000186AF4380-0x0000000186AF4420
		public void SendOpenPiano(VampireSurvivors.Objects.Characters.CharacterController nearestPlayer) {} // 0x0000000186AF4420-0x0000000186AF4500
		[Command]
		public void OpenPiano(long startingSimFrame, CoherenceSync nearestPlayer) {} // 0x0000000186AF4500-0x0000000186AF4620
		public void SendSuccessfulPiano() {} // 0x0000000186AF4620-0x0000000186AF46E0
		[Command]
		public void SuccessfulPiano(long startingSimFrame) {} // 0x0000000186AF46E0-0x0000000186AF4780
		public void SendExitPiano() {} // 0x0000000186AF4780-0x0000000186AF4840
		[Command]
		public void ExitPiano(long startingSimFrame) {} // 0x0000000186AF4840-0x0000000186AF48E0
		public void SendRightCoffinOpened() {} // 0x0000000186AF48E0-0x0000000186AF49A0
		[Command]
		public void RightCoffinOpened(long startingSimFrame) {} // 0x0000000186AF49A0-0x0000000186AF4A40
		public void SendTouchedPianoKey(int key) {} // 0x0000000186AF4A40-0x0000000186AF4B00
		[Command]
		public void TouchedPianoKey(int touchedPianoKey) {} // 0x0000000186AF4B00-0x0000000186AF4C20
		public void SendRevealCharacter() {} // 0x0000000186AF4C20-0x0000000186AF4CC0
		[Command]
		public void RevealCharacter() {} // 0x0000000186AF4CC0-0x0000000186AF4DB0
		public void SendCollectCharacter() {} // 0x0000000186AF4DB0-0x0000000186AF4E70
		[Command]
		public void CollectCharacter(long startingSimFrame) {} // 0x0000000186AF4E70-0x0000000186AF4F10
		public void SendSelectDirecterTooEasy() {} // 0x0000000186AF4F10-0x0000000186AF4FD0
		[Command]
		public void SelectDirecterTooEasy(long startingSimFrame) {} // 0x0000000186AF4FD0-0x0000000186AF5070
		public void SendSelectDirecterTooHard() {} // 0x0000000186AF5070-0x0000000186AF5130
		[Command]
		public void SelectDirecterTooHard(long startingSimFrame) {} // 0x0000000186AF5130-0x0000000186AF51D0
		public void SendSelectDirecterOkButton() {} // 0x0000000186AF51D0-0x0000000186AF5290
		[Command]
		public void SelectDirecterOkButton(long startingSimFrame) {} // 0x0000000186AF5290-0x0000000186AF5330
		public void SendSetMadMoonSymbols(string serializedSymbols) {} // 0x0000000186AF5330-0x0000000186AF5410
		[Command]
		public void SetMadMoonSymbols(string serializedSymbols, long startingSimFrame) {} // 0x0000000186AF5410-0x0000000186AF5590
		public void SendDirecterStageSwitch(int newStage) {} // 0x0000000186AF5590-0x0000000186AF5660
		[Command]
		public void DirecterStageSwitch(long startingSimFrame, int newStage) {} // 0x0000000186AF5660-0x0000000186AF5780
		public void SendEnterTheBossi() {} // 0x0000000186AF5780-0x0000000186AF5840
		[Command]
		public void EnterTheBossi(long startingSimFrame) {} // 0x0000000186AF5840-0x0000000186AF5910
		public void SendWestwoodsSpin() {} // 0x0000000186AF5910-0x0000000186AF5A20
		[Command]
		public void WestwoodsSpin(long startingSimFrame, int seed) {} // 0x0000000186AF5A20-0x0000000186AF5B40
		public void SendPauseRequest(VampireSurvivors.Objects.Characters.CharacterController pausingPlayer) {} // 0x0000000186AF5B40-0x0000000186AF5F90
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void PauseRequest(CoherenceSync pausingPlayer) {} // 0x0000000186AF5F90-0x0000000186AF61C0
		[Command]
		public void GenericPause(long startingSimFrame, CoherenceSync pausingPlayer) {} // 0x0000000186AF61C0-0x0000000186AF6570
		public void SendFreezeMyPlayer(bool freeze) {} // 0x0000000186AF6570-0x0000000186AF6700
		[Command]
		public void FreezePlayer(long startingSimFrame, bool freeze, CoherenceSync resumingPlayer) {} // 0x0000000186AF6700-0x0000000186AF6820
		public void SendForceCloseUi() {} // 0x0000000186AF6820-0x0000000186AF68F0
		[Command]
		public void ForceCloseUi(long startingSimFrame) {} // 0x0000000186AF68F0-0x0000000186AF6990
		public void SendTransitionToHolyForbidden() {} // 0x0000000186AF6990-0x0000000186AF6AB0
		[Command]
		public void TransitionToHolyForbidden(long startingSimFrame) {} // 0x0000000186AF6AB0-0x0000000186AF6B50
		public void SendTransitionToFoscari2() {} // 0x0000000186AF6B50-0x0000000186AF6C70
		[Command]
		public void TransitionToFoscari2(long startingSimFrame) {} // 0x0000000186AF6C70-0x0000000186AF6D40
		public void SendOpenMainArcanaPage() {} // 0x0000000186AF6D40-0x0000000186AF6E00
		[Command]
		public void OpenMainArcanaPage(long startingSimFrame) {} // 0x0000000186AF6E00-0x0000000186AF6F80
		public void SendArcanaModeTransition() {} // 0x0000000186AF6F80-0x0000000186AF7040
		[Command]
		public void ArcanaModeTransition(long startingSimFrame) {} // 0x0000000186AF7040-0x0000000186AF70E0
		public void SendBackground3GRAZIELLAUnlock() {} // 0x0000000186AF70E0-0x0000000186AF71A0
		[Command]
		public void Background3GRAZIELLAUnlock(long startingSimFrame) {} // 0x0000000186AF71A0-0x0000000186AF72E0
		public void SendBackground1NeoUnlock() {} // 0x0000000186AF72E0-0x0000000186AF73A0
		[Command]
		public void SendBackground1NeoUnlock(long startingSimFrame) {} // 0x0000000186AF73A0-0x0000000186AF74E0
		public void SendAdvanceDevilRoomLevel() {} // 0x0000000186AF74E0-0x0000000186AF75A0
		[Command]
		public void AdvanceDevilRoomLevel(long startingSimFrame) {} // 0x0000000186AF75A0-0x0000000186AF76E0
		public void SendDarkassoCutscene(VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF76E0-0x0000000186AF77C0
		[Command]
		public void DarkassoCutscene(long startingSimFrame, CoherenceSync player) {} // 0x0000000186AF77C0-0x0000000186AF79E0
		public void SendGift(Vector2 startPosition, Vector2 endPosition, VampireSurvivors.Data.ItemType itemType, WeaponType weaponType) {} // 0x0000000186AF79E0-0x0000000186AF7B60
		[Command]
		public void ProcessGift(Vector2 startPosition, Vector2 endPosition, int itemType, int weaponType) {} // 0x0000000186AF7B60-0x0000000186AF7E80
		public void SendStartSabotagion(float duration, int chosenEventTarget, Vector2 targetLocation, string newsFeedText, bool isPickleRush) {} // 0x0000000186AF7E80-0x0000000186AF8000
		[Command]
		public void StartSabotagion(float duration, int chosenEventTarget, Vector2 targetLocation, string newsFeedText, bool isPickleRush) {} // 0x0000000186AF8000-0x0000000186AF80B0
		public void SendStartCoopGaeaEvent() {} // 0x0000000186AF80B0-0x0000000186AF8170
		[Command]
		public void StartCoopGaeaEvent(long startingSimFrame) {} // 0x0000000186AF8170-0x0000000186AF82B0
		public void SendCoopSetFirstEnmemyKilled() {} // 0x0000000186AF82B0-0x0000000186AF8370
		[Command]
		public void CoopSetFirstEnmemyKilled(long startingSimFrame) {} // 0x0000000186AF8370-0x0000000186AF84B0
		public void SendOpenTerrace() {} // 0x0000000186AF84B0-0x0000000186AF8560
		[Command]
		public void OpenTerrace() {} // 0x0000000186AF8560-0x0000000186AF8620
		public void SendMazerellaUnlockTorinoSecret() {} // 0x0000000186AF8620-0x0000000186AF86C0
		[Command]
		public void MazerellaUnlockTorinoSecret() {} // 0x0000000186AF86C0-0x0000000186AF8780
		[Command]
		public void OnlineSetEnemyFollowerData(short enemyType, bool wasCartRider) {} // 0x0000000186AF8780-0x0000000186AF88F0
		[Command]
		public void OnlineSetRecycledEnemyFollowerData(short enemyType, bool wasCartRider, CoherenceSync followedCharacterSync) {} // 0x0000000186AF88F0-0x0000000186AF8970
		public void SendTurnOnVaccuum(VampireSurvivors.Objects.Characters.CharacterController target) {} // 0x0000000186AF8970-0x0000000186AF8B90
		[Command]
		public void TurnOnVaccuum(CoherenceSync target) {} // 0x0000000186AF8B90-0x0000000186AF8C20
		public void SendSnapYellows(PickupWeapon gRing, PickupWeapon sRing, PickupWeapon lMeta, PickupWeapon rMeta, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186AF8C20-0x0000000186AF8D60
		[Command]
		public void SnapYellows(CoherenceSync gRing, CoherenceSync sRing, CoherenceSync lMeta, CoherenceSync rMeta, CoherenceSync player) {} // 0x0000000186AF8D60-0x0000000186AF8FA0
		public void FireSyncTimer(long startingSimFrame, Action onSyncedTimer, bool canBePaused = true /* Metadata: 0x01976CDE */) {} // 0x0000000186AF8FA0-0x0000000186AF9660
		private void TransitionToHolyForbidden() {} // 0x0000000186AF9660-0x0000000186AF9720
		private void PerformGenericPause(CoherenceSync pausingPlayer) {} // 0x0000000186AF9720-0x0000000186AF9B20
		private void OnEnteredUi() {} // 0x0000000186AF9B20-0x0000000186AF9BB0
		private void OnStageSelectedRemotely(int oldStage, int newStage) {} // 0x0000000186AF9BB0-0x0000000186AF9C10
		private void OnSeatAssignedRemotely(uint oldId, uint newId) {} // 0x0000000186AF9C10-0x0000000186AF9C70
		private PlayerInfo ReturnPlayerInfoForSeat(uint seat) => default; // 0x0000000186AF9C70-0x0000000186AF9DF0
		private void Awake() {} // 0x0000000186AF9DF0-0x0000000186AFA480
		private void InitRngs() {} // 0x0000000186AFA480-0x0000000186AFA4F0
		public void ResetGameSession() {} // 0x0000000186AFA4F0-0x0000000186AFA6A0
		private void Update() {} // 0x0000000186AFA6A0-0x0000000186AFA7F0
		private void SignalInitGameSession() {} // 0x0000000186AFA7F0-0x0000000186AFAC70
		private void SignalInitStage() {} // 0x0000000186AFAC70-0x0000000186AFB010
		private void SignalGameStart() {} // 0x0000000186AFB010-0x0000000186AFB3A0
		private void OnStateAuthority() {} // 0x0000000186AFB3A0-0x0000000186AFB680
		private void ReassignSeats() {} // 0x0000000186AFB680-0x0000000186AFBAD0
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186AFBAD0-0x0000000186AFBB70
		private void OnDestroy() {} // 0x0000000186AFBB70-0x0000000186AFC010
		private void OnClientDisconnected(CoherenceClientConnection clientConn) {} // 0x0000000186AFC010-0x0000000186AFC1E0
		private void OnClientJoined(CoherenceClientConnection clientConn) {} // 0x0000000186AFC1E0-0x0000000186AFC380
		private bool TryToAssignSeat(ref uint seat, uint newClient, int seatNumber, PlayerInfo playerInfo) => default; // 0x0000000186AFC380-0x0000000186AFC4F0
		private void OnApplicationQuit() {} // 0x0000000186AFC4F0-0x0000000186AFC550
		private void ShutDown() {} // 0x0000000186AFC4F0-0x0000000186AFC550
	}
}
