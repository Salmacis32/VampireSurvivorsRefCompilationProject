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
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class HostPlayerOptions : MonoBehaviour // TypeDefIndex: 14021
	{
		// Fields
		private PlayerOptions _playerOptions; // 0x28
		private AdventureManager _adventureManager; // 0x30
		private CoherenceSync _coherenceSync; // 0x38
		private SignalBus _signalBus; // 0x40
		private DataManager _dataManager; // 0x48
		private byte[] _openedCoffins; // 0x50
		private byte[] _unlockedArcanas; // 0x58
		private byte[] _boughtPowerUps; // 0x60
		private byte[] _disabledPowerUps; // 0x68
		private byte[] _collectedItems; // 0x70
		private List<byte[]> _unlockedWeaponsChunks; // 0x78
		private List<byte[]> _collectedWeaponsChunks; // 0x80
		private List<byte[]> _sealedWeaponsChunks; // 0x88
		private byte[] _sealedItems; // 0x90
		private byte[] _unlockedStages; // 0x98
		private List<byte[]> _hostPickupCountChunks; // 0xA0
		private List<byte[]> _hostAchievementsChunks; // 0xA8
		private byte[] _ascensionData; // 0xB0
		private int _currentAdventureType; // 0xB8
		private bool _openedCoffinsReady; // 0xBC
		private bool _unlockedArcanasReady; // 0xBD
		private bool _boughtPowerUpsReady; // 0xBE
		private bool _disabledPowerUpsReady; // 0xBF
		private bool _collectedItemsReady; // 0xC0
		private bool _unlockedWeaponsReady; // 0xC1
		private bool _collectedWeaponsReady; // 0xC2
		private bool _sealedWeaponsReady; // 0xC3
		private bool _sealedItemsReady; // 0xC4
		private bool _unlockedStagesReady; // 0xC5
		private bool _hostPickupCountReady; // 0xC6
		private bool _hostAchievementsReady; // 0xC7
		private bool _ascensionDataReady; // 0xC8
		private bool _adventureReady; // 0xC9
	
		// Properties
		public static HostPlayerOptions Instance { get; private set; } // 0x0000000186ADEE40-0x0000000186ADEE80 0x0000000186ADEE80-0x0000000186ADEF20
		public bool IsReady { get; set; } // 0x0000000181E0A560-0x0000000181E0A570 0x0000000181E0A570-0x0000000181E0A580
		[OnValueSynced("OnStageSelectedRemotely")]
		[Sync]
		public int SelectedStage { get; set; } // 0x0000000181E0A5A0-0x0000000181E0A5B0 0x0000000181E0A5B0-0x0000000181E0A5C0
		public byte[] HostOpenedCoffins { get => default; } // 0x000000018197EAB0-0x000000018197EAC0 
		public byte[] AvailableHostArcanas { get => default; } // 0x0000000180B15730-0x0000000180B15740 
		public byte[] AvailableHostBoughtPowerUps { get => default; } // 0x0000000180B15740-0x0000000180B15750 
		public byte[] HostDisabledPowerUps { get => default; } // 0x00000001819A0210-0x00000001819A0220 
		public byte[] HostCollectedItems { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
		public List<byte[]> HostUnlockedWeapons { get => default; } // 0x00000001819A0360-0x00000001819A0370 
		public List<byte[]> HostCollectedWeapons { get => default; } // 0x00000001819A0370-0x00000001819A0380 
		public List<byte[]> HostSealedWeapons { get => default; } // 0x00000001819A03E0-0x00000001819A03F0 
		public byte[] HostSealedItems { get => default; } // 0x0000000181919F80-0x0000000181919F90 
		public byte[] HostUnlockedStages { get => default; } // 0x0000000181971630-0x0000000181971640 
		public List<byte[]> HostPickupCount { get => default; } // 0x00000001819A0250-0x00000001819A0260 
		public List<byte[]> HostAchievements { get => default; } // 0x00000001819716D0-0x00000001819716E0 
		public byte[] AscensionData { get => default; } // 0x00000001819A0190-0x00000001819A01A0 
		[Sync]
		public bool SelectedHyper { get => default; set {} } // 0x0000000186ADEF20-0x0000000186ADEF50 0x0000000186ADEF50-0x0000000186ADEFB0
		[Sync]
		public bool SelectedHurry { get => default; set {} } // 0x0000000186ADEFB0-0x0000000186ADEFE0 0x0000000186ADEFE0-0x0000000186ADF040
		[Sync]
		public bool SelectedInverse { get => default; set {} } // 0x0000000186ADF040-0x0000000186ADF070 0x0000000186ADF070-0x0000000186ADF0D0
		[Sync]
		public bool VisuallyInvert { get => default; set {} } // 0x0000000186ADF0D0-0x0000000186ADF110 0x0000000186ADF110-0x0000000186ADF170
		[Sync]
		public bool SelectedReapers { get => default; set {} } // 0x0000000186ADF170-0x0000000186ADF1A0 0x0000000186ADF1A0-0x0000000186ADF200
		[Sync]
		public bool SelectedMazzo { get => default; set {} } // 0x0000000186ADF200-0x0000000186ADF230 0x0000000186ADF230-0x0000000186ADF290
		[Sync]
		public bool SelectedRandomEvents { get => default; set {} } // 0x0000000186ADF290-0x0000000186ADF2C0 0x0000000186ADF2C0-0x0000000186ADF320
		[Sync]
		public bool HasKilledTheFinalBoss { get => default; set {} } // 0x0000000186ADF320-0x0000000186ADF360 0x0000000186ADF360-0x0000000186ADF3C0
		[Sync]
		public bool HasSeenFinalFireworks { get => default; set {} } // 0x0000000186ADF3C0-0x0000000186ADF400 0x0000000186ADF400-0x0000000186ADF460
		[Sync]
		public bool SelectedSharePassives { get => default; set {} } // 0x0000000186ADF460-0x0000000186ADF490 0x0000000186ADF490-0x0000000186ADF4F0
		[Sync]
		public bool HasSeenDarkanaTransition { get => default; set {} } // 0x0000000186ADF4F0-0x0000000186ADF520 0x0000000186ADF520-0x0000000186ADF550
		[Sync]
		public int SelectedArcana { get => default; set {} } // 0x0000000186ADF550-0x0000000186ADF580 0x0000000186ADF580-0x0000000186ADF5D0
		[Sync]
		public bool SelectedOnlineFreeRoam { get => default; set {} } // 0x0000000186ADF5D0-0x0000000186ADF600 0x0000000186ADF600-0x0000000186ADF660
		public int CurrentAdventureType { get => default; set {} } // 0x0000000186ADF660-0x0000000186ADF730 0x00000001865B30C0-0x00000001865B30D0
	
		// Constructors
		public HostPlayerOptions() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions playerOptions, AdventureManager adventureManager, DataManager dataManager) {} // 0x0000000186ADF730-0x0000000186ADF880
		[Command]
		public void SendOpenedCoffins(byte[] openedCoffins) {} // 0x0000000186ADF880-0x0000000186ADF8F0
		[Command]
		public void SendUnlockedArcanas(byte[] unlockedArcanas) {} // 0x0000000186ADF8F0-0x0000000186ADF960
		[Command]
		public void SendBoughtPowerUps(byte[] boughtPowerUps) {} // 0x0000000186ADF960-0x0000000186ADF9D0
		[Command]
		public void SendDisabledPowerUps(byte[] disabledPowerUps) {} // 0x0000000186ADF9D0-0x0000000186ADFA40
		[Command]
		public void SendCollectedItems(byte[] collectedItems) {} // 0x0000000186ADFA40-0x0000000186ADFAB0
		[Command]
		public void SendUnlockedWeaponsChunk(byte[] unlockedWeaponsChunk, int expectedChunks) {} // 0x0000000186ADFAB0-0x0000000186ADFCD0
		[Command]
		public void SendCollectedWeaponsChunk(byte[] collectedWeaponsChunk, int expectedChunks) {} // 0x0000000186ADFCD0-0x0000000186ADFF00
		[Command]
		public void SendSealedWeaponsChunk(byte[] sealedWeaponsChunk, int expectedChunks) {} // 0x0000000186ADFF00-0x0000000186AE0130
		[Command]
		public void SendSealedItems(byte[] sealedItems) {} // 0x0000000186AE0130-0x0000000186AE01A0
		[Command]
		public void SendUnlockedStages(byte[] unlockedStages) {} // 0x0000000186AE01A0-0x0000000186AE0210
		[Command]
		public void SendHostPickupCountChunk(byte[] hostPickupCountChunk, int expectedChunks) {} // 0x0000000186AE0210-0x0000000186AE0370
		[Command]
		public void SendHostAchievementsChunk(byte[] hostAchievementsChunk, int expectedChunks) {} // 0x0000000186AE0370-0x0000000186AE04D0
		[Command]
		public void SendAdventureType(int adventureType) {} // 0x0000000186AE04D0-0x0000000186AE05B0
		[Command]
		public void SendAscensionData(byte[] ascensionData) {} // 0x0000000186AE05B0-0x0000000186AE0620
		[Command(defaultRouting = MessageTarget.AuthorityOnly)]
		public void RequestSaveData() {} // 0x0000000186AE0620-0x0000000186AE0630
		private void Awake() {} // 0x0000000186AE0630-0x0000000186AE0AD0
		private void OnDestroy() {} // 0x0000000186AE0AD0-0x0000000186AE0C20
		private void OnStageSelectedRemotely(int oldStage, int newStage) {} // 0x0000000186AE0C20-0x0000000186AE0D10
		[IteratorStateMachine(typeof(_WaitForPlayerOptions_d__132))]
		private IEnumerator WaitForPlayerOptions() => default; // 0x0000000186AE0D10-0x0000000186AE0DB0
		private void SendHostSaveData() {} // 0x0000000186AE0DB0-0x0000000186AE1490
		private void SendChunks(List<byte[]> chunks, Action<byte[], int> sendChunkCommand) {} // 0x0000000186AE1490-0x0000000186AE16A0
		private bool ReceivedAllData() => default; // 0x0000000186AE16A0-0x0000000186AE1720
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186AE1720-0x0000000186AE17C0
	}
}
