/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Cloud;
using Coherence.Connection;
using Coherence.Log;
using Coherence.Toolkit;
using Coherence.Toolkit.ReplicationServer;
using PlayFab.Party;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Platforms;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class RoomSelectionPage : BaseUIPage // TypeDefIndex: 14952
	{
		// Fields
		[SerializeField]
		private GameObject _roomSelection; // 0xE0
		[SerializeField]
		private LabeledInputUI _lobbyIdInput; // 0xE8
		[SerializeField]
		private UnityEngine.UI.Button _joinButton; // 0xF0
		[SerializeField]
		private UnityEngine.UI.Button _createRoomButton; // 0xF8
		[SerializeField]
		private UnityEngine.UI.Button _startButton; // 0x100
		[SerializeField]
		private UnityEngine.UI.Button _leaveButton; // 0x108
		[SerializeField]
		private UnityEngine.UI.Button _adventuresButton; // 0x110
		[SerializeField]
		private UnityEngine.UI.Button _collectionsButton; // 0x118
		[SerializeField]
		private UnityEngine.UI.Button _powerUpsButton; // 0x120
		[SerializeField]
		private CoherenceSyncConfig _onlineStageManagerPrefab; // 0x128
		[SerializeField]
		private CoherenceSyncConfig _hostPlayerOptions; // 0x130
		[SerializeField]
		private CoherenceSyncConfig _lobbyCharacterData; // 0x138
		[SerializeField]
		private TextMeshProUGUI _infoText; // 0x140
		[SerializeField]
		private GameObject _initContainer; // 0x148
		[SerializeField]
		private PlayFabMultiplayerManager _playFabPrefab; // 0x150
		[SerializeField]
		private GameObject _preCharacterSelectionLobby; // 0x158
		[SerializeField]
		private TextMeshProUGUI _lobbyIdText; // 0x160
		[SerializeField]
		private List<TextMeshProUGUI> _lobbyPlayerNames; // 0x168
		[SerializeField]
		private OnlineDLCSection _OnlineDLCSection; // 0x170
		private List<DlcType> _AvailableDLCs; // 0x178
		private Coherence.Log.Logger _logger; // 0x180
		private INetworkProvider _activeProvider; // 0x188
		private INetworkProvider _p2pProvider; // 0x190
		private CloudNetworkProvider _cloudProvider; // 0x198
		private DiContainer _diContainer; // 0x1A0
		private LobbiesManager _lobbiesManager; // 0x1A8
		private Coroutine _fireUiSignalRoutine; // 0x1B0
		private SignalBus _signalBus; // 0x1B8
		private IReplicationServer _replicationServer; // 0x1C0
		private bool _isStartingGame; // 0x1C8
		private static Dictionary<SystemPlatformTypes, NetworkProviders> _platformToProvider; // 0x08
		private const int ClientHostingDisconnectTimeout = 30000; // Metadata: 0x01977268
		private const float OnlineInitTimeout = 15f; // Metadata: 0x0197726C
	
		// Properties
		public LobbiesManager LobbiesManager { get => default; } // 0x0000000185FA2680-0x0000000185FA2690 
		public DiContainer DiContainer { get => default; } // 0x0000000181971880-0x0000000181971890 
		public IReplicationServer ReplicationServer { get => default; } // 0x0000000185D99B30-0x0000000185D99B40 
		public static RoomSelectionPage Instance { get; private set; } // 0x000000018693EF70-0x000000018693EFD0 0x000000018693EFD0-0x000000018693F080
		public bool IsInLobby { get => default; } // 0x000000018693F080-0x000000018693F0C0 
	
		// Constructors
		public RoomSelectionPage() {} // 0x000000018694A920-0x000000018694AA10
		static RoomSelectionPage() {} // 0x000000018694AA10-0x000000018694AC40
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DiContainer diContainer, MultiplayerManager multiplayerManager, LobbiesManager lobbiesManager) {} // 0x000000018693F0C0-0x000000018693F200
		public void LeaveGame() {} // 0x000000018693F200-0x000000018693F210
		public void StartGame() {} // 0x000000018693F210-0x000000018693F4C0
		public void CreateRoom() {} // 0x000000018693F4C0-0x000000018693F550
		private void OnLoggedInWithCoherenceAfterCreate(bool result) {} // 0x000000018693F550-0x000000018693F8C0
		public void JoinRoom(string _lobbyID) {} // 0x000000018693F8C0-0x000000018693F960
		public void JoinRoom() {} // 0x000000018693F960-0x000000018693F9E0
		private static void ShowConnectionLostPopup() {} // 0x000000018693F9E0-0x000000018693FBE0
		private void OnLoggedInWithCoherenceAfterJoin(string lobbyTag, bool result) {} // 0x000000018693FBE0-0x000000018693FDD0
		public static EndpointData GetLocalEndpoint() => default; // 0x000000018693FDD0-0x00000001869400A0
		private async void StartGameBasedOnNetworkType(NetworkType networkType) {} // 0x00000001869400A0-0x0000000186940270
		private async void JoinLobby(string lobbyTag) {} // 0x0000000186940270-0x0000000186940490
		protected override void Awake() {} // 0x0000000186940490-0x0000000186940520
		private void OnEnable() {} // 0x0000000186940520-0x0000000186940AA0
		private void OnDisable() {} // 0x0000000186940AA0-0x0000000186940BE0
		private void RemoveConnectionListeners() {} // 0x0000000186940BE0-0x0000000186940D30
		[IteratorStateMachine(typeof(_InitializeOnlineModules_d__61))]
		private IEnumerator InitializeOnlineModules() => default; // 0x0000000186940D30-0x0000000186940DD0
		private void UpdateLobbyState() {} // 0x0000000186940DD0-0x0000000186941000
		private void OnJoinError() {} // 0x0000000186941000-0x0000000186941060
		private void ChangeUiState(bool activate, string infoText) {} // 0x0000000186941060-0x0000000186941330
		private void SwitchLobbyState(bool activate) {} // 0x0000000186941330-0x0000000186941550
		private void OnJoinedLobby() {} // 0x0000000186941550-0x0000000186941CD0
		private async void UpdateReadyState(long ready) {} // 0x0000000186941CD0-0x0000000186941EB0
		private void ChangeButtonsState(bool active) {} // 0x0000000186941EB0-0x0000000186941F90
		private void UpdateStartButtonState(bool active) {} // 0x0000000186941F90-0x0000000186942170
		private void OnStartGameMessageReceived(LobbySession lobby, MessagesReceived messages) {} // 0x0000000186942170-0x0000000186942E40
		private void OnP2PSessionError(string errorMessage) {} // 0x0000000186942E40-0x0000000186943070
		private void OnLobbyOwnerChanged(LobbySession lobby, LobbyPlayer player) {} // 0x000000018693F200-0x000000018693F210
		private void UpdatePlayerNames() {} // 0x0000000186943070-0x0000000186943750
		private void UpdateAvailableDLC() {} // 0x0000000186943750-0x0000000186944480
		private List<DlcType> GetDLCStringAsTypes(string dlcString) => default; // 0x0000000186944480-0x0000000186944600
		private void OnGameReady(bool result, string errorMessage, Dictionary<string, string> networkAttributes) {} // 0x0000000186944600-0x0000000186944B70
		private async void UpdateLobbyAttributes(List<CloudAttribute> attributes) {} // 0x0000000186944B70-0x0000000186944D90
		private void OnAttributesAdded(RequestResponse<bool> req) {} // 0x0000000186944D90-0x0000000186945120
		private List<LobbyPlayer> GetMessageRecipients() => default; // 0x0000000186945120-0x0000000186945530
		private void OnP2PFailedMessageReceived(LobbySession lobby, MessagesReceived messages) {} // 0x0000000186945530-0x0000000186945BF0
		private void FallbackToCoherenceCloud() {} // 0x0000000186945BF0-0x0000000186945D70
		private void OnP2PSessionReady() {} // 0x0000000186945D70-0x0000000186945EE0
		private void StartHostingCoherenceGame() {} // 0x0000000186945EE0-0x0000000186946270
		private void OnStartedHosting(CoherenceBridge _) {} // 0x0000000186946270-0x0000000186946490
		private async void SendStartGameMessage() {} // 0x0000000186946490-0x0000000186946650
		private void OnStartGameMessageSent(RequestResponse<bool> req) {} // 0x0000000186946650-0x0000000186946780
		private NetworkType GetNetworkType() => default; // 0x0000000186946780-0x0000000186947040
		private async void CreateLobby() {} // 0x0000000186947040-0x0000000186947200
		private void OnCreatedLobby() {} // 0x0000000186947200-0x0000000186947660
		private void OnConnectionLostWithCoherence() {} // 0x0000000186947660-0x00000001869477F0
		private void OnPlayerLeft(LobbySession lobby, LobbyPlayer player, string reason) {} // 0x00000001869477F0-0x0000000186947990
		private void OnPlayerJoined(LobbySession lobby, LobbyPlayer player) {} // 0x0000000186947990-0x0000000186947B30
		private void InstantiateLobbyEntities(CoherenceClientConnectionManager _) {} // 0x0000000186947B30-0x0000000186947DB0
		private void ShowOnlineLobby(CoherenceClientConnectionManager _) {} // 0x0000000186947DB0-0x00000001869482B0
		[IteratorStateMachine(typeof(_FireUiSignalCoroutine_d__95))]
		private IEnumerator FireUiSignalCoroutine() => default; // 0x00000001869482B0-0x0000000186948350
		private void OnClientDisconnected(CoherenceClientConnection clientConn) {} // 0x0000000186948350-0x00000001869486B0
		private void FireUiSignal() {} // 0x00000001869486B0-0x0000000186948930
		private void StartReplicationServerIfP2P() {} // 0x0000000186948930-0x0000000186949080
		private ReplicationServerConfig GetConfig() => default; // 0x0000000186949080-0x0000000186949610
		private void OnConnectionError(CoherenceBridge _, ConnectionException e) {} // 0x0000000186949610-0x0000000186949720
		private void OnDestroy() {} // 0x0000000186949720-0x0000000186949950
		public void UpdateActiveProvider() {} // 0x0000000186949950-0x00000001869499B0
		protected override void Update() {} // 0x00000001869499B0-0x0000000186949A50
		private void ShutDown() {} // 0x0000000186941000-0x0000000186941060
		private async void LeaveLobby() {} // 0x0000000186949A50-0x0000000186949C10
		private void OnApplicationQuit() {} // 0x0000000186949C10-0x0000000186949D30
		private void StopReplicationServer() {} // 0x0000000186949D30-0x0000000186949DE0
		private void ReplicationServer_OnLog(string log) {} // 0x0000000186949DE0-0x0000000186949E60
		private void ReplicationServer_OnExit(int code) {} // 0x0000000186949E60-0x0000000186949F90
		public void GoBackOnline() {} // 0x0000000186949F90-0x000000018694A150
		public void ShowBestiary() {} // 0x000000018694A150-0x000000018694A230
		public void ShowOptions() {} // 0x000000018694A230-0x000000018694A310
		public void ShowPowerUps() {} // 0x000000018694A310-0x000000018694A3F0
		public void ShowAchievements() {} // 0x000000018694A3F0-0x000000018694A4D0
		public void ShowCollections() {} // 0x000000018694A4D0-0x000000018694A5B0
		public void ShowAdventuresView() {} // 0x000000018694A5B0-0x000000018694A780
		private void ChangeLobbyOpenState(bool open) {} // 0x000000018694A780-0x000000018694A920
	}
}
