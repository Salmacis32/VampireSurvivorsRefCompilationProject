/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.SceneManagement;
using VampireSurvivors.App.Data;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class MultiplayerManager : IInitializable, IDisposable, ITickable // TypeDefIndex: 17513
	{
		// Fields
		[Inject]
		private PlayerOptions _playerOptions; // 0x10
		[Inject]
		private SignalBus _signalBus; // 0x18
		[Inject]
		private CoopConfig _coopConfig; // 0x20
		public int? PartySize; // 0x28
		public bool PartyModeEnabled; // 0x30
		private const string POPUP_ID_PREFIX = "ControllerDisconnect-"; // Metadata: 0x019786C7
		private List<Player> _players; // 0x68
		private List<Player> _playersToRemove; // 0x70
		private Color[] _availableColors; // 0x78
		private Dictionary<Player, VampireSurvivors.Objects.Characters.CharacterController> _characters; // 0x80
		private Player _previousPlayer; // 0x88
		private static MultiplayerManager s_instance; // 0x00
		private List<FollowerData> _aiCharacters; // 0x90
		private List<Player> _disconnectedPlayers; // 0x98
		private int[] _uiControllingPlayers; // 0xA0
		public bool AllowPlayerJoining; // 0xA8
		public bool AllowPlayerRemoval; // 0xA9
		public bool AllowP1Reassign; // 0xAA
		private bool _hasForcedPauseForDisconnect; // 0xAB
		private bool _backButtonListening; // 0xAC
		private RewiredStandaloneInputModule _inputModule; // 0xB0
		private List<int> ControllersAwaitingReconnection; // 0xB8
		private int _selectedPlayerIndex; // 0xC0
		public List<Player> _playersWhoHaveUsedTheirController; // 0xC8
	
		// Properties
		public static MultiplayerManager Instance { get => default; } // 0x0000000187339C50-0x0000000187339C90 
		public bool IsMultiplayer { get => default; } // 0x0000000187339C90-0x0000000187339CE0 
		public CoopConfig CoopConfig { get => default; } // 0x0000000180B15530-0x0000000180B15540 
		public bool IsAwaitingControllerReconnect { get => default; } // 0x0000000187339CE0-0x0000000187339D30 
		private RewiredStandaloneInputModule InputModule { get => default; } // 0x0000000187339D30-0x0000000187339E90 
		public bool IsUIBeingBlocked { get => default; } // 0x0000000187339E90-0x0000000187339F40 
		public List<FollowerData> AICharacters { get => default; } // 0x0000000181919F80-0x0000000181919F90 
	
		// Events
		public event OnPlayerStateChange PlayerAdded;
		public event OnPlayerStateChange PlayerRemoved;
		public event OnPlayerStateChange PlayerSelected;
		public event OnPlayerStateChange PlayerSettingChanged;
		public event OnControllerStateChange ControllerDisconnected;
		public event OnRefresh RefreshUI;
	
		// Nested types
		public delegate void OnPlayerStateChange(Player p); // TypeDefIndex: 17508; 0x000000018196C5F0-0x000000018196C600
	
		public delegate void OnControllerStateChange(Player p); // TypeDefIndex: 17509; 0x000000018196C5F0-0x000000018196C600
	
		public delegate void OnRefresh(); // TypeDefIndex: 17510; 0x000000018196C270-0x000000018196C280
	
		// Constructors
		public MultiplayerManager() {} // 0x0000000187342A30-0x0000000187342DE0
	
		// Methods
		public void Initialize() {} // 0x0000000187339F40-0x000000018733A430
		private void InitializeColours() {} // 0x000000018733A430-0x000000018733A5D0
		public void Dispose() {} // 0x000000018733A5D0-0x000000018733AAD0
		public void Tick() {} // 0x000000018733AAD0-0x000000018733B5A0
		private void ResetToSinglePlayerMode() {} // 0x000000018733B5A0-0x000000018733B7A0
		private void OnPlayerControllerAdded(ControllerAssignmentChangedEventArgs args) {} // 0x000000018733B7A0-0x000000018733C260
		private void OnPlayerControllerRemoved(ControllerAssignmentChangedEventArgs args) {} // 0x000000018733C260-0x000000018733D660
		private void OnControllerDisconnected(ControllerStatusChangedEventArgs args) {} // 0x0000000180B15170-0x0000000180B15180
		public void AddPlayersFromPartyMode(int partySize) {} // 0x000000018733D660-0x000000018733D8B0
		private Player GetPlayerFromController(Rewired.Controller controller) => default; // 0x000000018733D8B0-0x000000018733DA90
		public void AddDisconnectedPlayer(Player player) {} // 0x000000018733DA90-0x000000018733DF90
		public void AddPlayerForRemoval(Player p) {} // 0x000000018733DF90-0x000000018733E120
		public int GetInternalPlayerIndex(Player p) => default; // 0x000000018733E120-0x000000018733E1D0
		public void ClearAllExtraPlayers() {} // 0x000000018733E1D0-0x000000018733E280
		public void RemoveDisconnectedPlayer(Player player) {} // 0x000000018733E280-0x000000018733E420
		private void OnControllerConnected(ControllerStatusChangedEventArgs args) {} // 0x000000018733E420-0x000000018733E6D0
		private void SetInitialPlayers() {} // 0x000000018733E6D0-0x000000018733E980
		private void StopVibrationOnSceneUnload(Scene s) {} // 0x000000018733E980-0x000000018733EAD0
		private void StopVibrationOnSceneLoad(Scene s, LoadSceneMode mode) {} // 0x000000018733EAD0-0x000000018733EC20
		public void SetControllerAssignedToPlayer1(bool value) {} // 0x000000018733EC20-0x000000018733EF50
		public void AddPlayer(Player p) {} // 0x000000018733EF50-0x000000018733F200
		public void UpdatePlayerControllerColour(Player player, Color color) {} // 0x0000000180B15170-0x0000000180B15180
		public void ResetPlayerControllerColor(Player player) {} // 0x0000000180B15170-0x0000000180B15180
		public void RemovePlayer(Player p) {} // 0x000000018733F200-0x000000018733F5E0
		public void ResetSystem() {} // 0x000000018733F5E0-0x000000018733F740
		public void ResetMultiplayerSelections() {} // 0x000000018733F740-0x0000000187340040
		public Color GetSlotColor(int playerSlot) => default; // 0x0000000187340040-0x0000000187340100
		public List<Player> GetPlayers() => default; // 0x00000001819A0210-0x00000001819A0220
		public bool IsCharacterTypeInGame(VampireSurvivors.Data.CharacterType t) => default; // 0x0000000187340100-0x0000000187340290
		public VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllerFromType(VampireSurvivors.Data.CharacterType t) => default; // 0x0000000187340290-0x0000000187340430
		public int GetPlayerCount() => default; // 0x0000000187340430-0x00000001873404B0
		public int GetAICount() => default; // 0x00000001873404B0-0x0000000187340580
		public Player GetCurrentPlayer() => default; // 0x0000000187340580-0x00000001873405F0
		public void PlayerControlOverride(Player p) {} // 0x00000001873405F0-0x00000001873406A0
		public void DisableAllUIInteraction() {} // 0x00000001873406A0-0x0000000187340860
		public void EnableAllUIInteraction() {} // 0x0000000187340860-0x0000000187340A00
		public void SelectPlayerOne(bool exclusiveUIControl = false /* Metadata: 0x019786B9 */, bool vibrate = true /* Metadata: 0x019786BA */) {} // 0x0000000187340A00-0x0000000187340AC0
		public void AllowAllPlayersToUseUI() {} // 0x0000000187340AC0-0x0000000187340D60
		public void AddPlayerToUIControl(Player player) {} // 0x0000000187340D60-0x0000000187340EF0
		public void SelectLastPlayer(bool exclusiveUIControl = false /* Metadata: 0x019786BB */, bool vibrate = true /* Metadata: 0x019786BC */) {} // 0x0000000187340EF0-0x0000000187340FC0
		public Player GetPlayerOne() => default; // 0x0000000187340FC0-0x0000000187341030
		public List<VampireSurvivors.Data.CharacterType> GetCharacterSelections() => default; // 0x0000000187341030-0x00000001873412D0
		public void SelectPlayer(Player p, bool exclusiveUIControl = false /* Metadata: 0x019786BD */, bool vibrate = true /* Metadata: 0x019786BE */, float vibrationMS = 200f /* Metadata: 0x019786BF */) {} // 0x00000001873412D0-0x00000001873418A0
		public void Refresh() {} // 0x00000001873418A0-0x0000000187341A00
		public bool NextPlayer(bool exclusiveUIControl = true /* Metadata: 0x019786C3 */, bool vibrate = true /* Metadata: 0x019786C4 */) => default; // 0x0000000187341A00-0x0000000187341B30
		public bool PreviousPlayer(bool exclusiveUIControl = true /* Metadata: 0x019786C5 */, bool vibrate = true /* Metadata: 0x019786C6 */) => default; // 0x0000000187341B30-0x0000000187341C80
		public Player GetSelectedPlayer() => default; // 0x0000000187341C80-0x0000000187341CF0
		public Player GetPlayerFromID(int id) => default; // 0x0000000187341CF0-0x0000000187341DD0
		public Player GetPlayerFromIndex(int playerIndex) => default; // 0x0000000187341DD0-0x0000000187341E50
		public int GetSelectedPlayerIndex() => default; // 0x00000001831C30C0-0x00000001831C30D0
		public void AddCharacter(Player p, VampireSurvivors.Objects.Characters.CharacterController c) {} // 0x0000000187341E50-0x0000000187341FD0
		public void RemoveCharacter(Player p) {} // 0x0000000187341FD0-0x0000000187342070
		public void RemoveAllCharacters() {} // 0x0000000187342070-0x00000001873420C0
		public VampireSurvivors.Objects.Characters.CharacterController GetCharacter(int playerID) => default; // 0x00000001873420C0-0x00000001873421E0
		public VampireSurvivors.Objects.Characters.CharacterController GetCharacter(Player player) => default; // 0x00000001873421E0-0x0000000187342240
		public List<VampireSurvivors.Objects.Characters.CharacterController> GetAllCharacters() => default; // 0x0000000187342240-0x0000000187342330
		public VampireSurvivors.Objects.Characters.CharacterController GetSelectedCharacter() => default; // 0x0000000187342330-0x00000001873423A0
		public Color GetPlayerColour(Player player) => default; // 0x00000001873423A0-0x0000000187342490
		public Color GetUIControlColour() => default; // 0x0000000187342490-0x00000001873425C0
		public void EnsurePlayableCharacters() {} // 0x00000001873425C0-0x0000000187342A30
	}
}
