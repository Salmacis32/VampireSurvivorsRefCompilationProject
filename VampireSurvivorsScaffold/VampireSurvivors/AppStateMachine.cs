/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AppStateMachine : StateMachine // TypeDefIndex: 14104
	{
		// Fields
		public const string LANDING_SCREEN = "LANDING_SCREEN"; // Metadata: 0x01976CEC
		public const string MAIN_MENU = "MAIN_MENU"; // Metadata: 0x01976CFB
		public const string SHOW_POWER_UPS = "SHOW_POWER_UPS"; // Metadata: 0x01976D05
		public const string SHOW_OPTIONS = "SHOW_OPTIONS"; // Metadata: 0x01976D14
		public const string GO_BACK = "GO_BACK"; // Metadata: 0x01976D21
		public const string SHOW_ACHIEVEMENTS = "SHOW_ACHIEVEMENTS"; // Metadata: 0x01976D29
		public const string SHOW_COLLECTIONS = "SHOW_COLLECTIONS"; // Metadata: 0x01976D3B
		public const string SHOW_CREDITS = "SHOW_CREDITS"; // Metadata: 0x01976D4C
		public const string SELECT_CHARACTER = "SELECT_CHARACTER"; // Metadata: 0x01976D59
		public const string SHOW_ONLINE = "SHOW_ONLINE"; // Metadata: 0x01976D6A
		public const string SHOW_ONLINE_LOBBY = "SHOW_ONLINE_LOBBY"; // Metadata: 0x01976D76
		public const string ONLINE_ERROR = "ONLINE_ERROR"; // Metadata: 0x01976D88
		public const string GO_BACK_ONLINE = "GO_BACK_ONLINE"; // Metadata: 0x01976D95
		public const string START_GAME = "START_GAME"; // Metadata: 0x01976DA4
		public const string SELECT_STAGE = "SELECT_STAGE"; // Metadata: 0x01976DAF
		public const string OPEN_LANGUAGES = "OPEN_LANGUAGES"; // Metadata: 0x01976DBC
		public const string RETURN_TO_OPTIONS = "RETURN_TO_OPTIONS"; // Metadata: 0x01976DCB
		public const string WARNING_SHOWN = "WARNING_SHOWN"; // Metadata: 0x01976DDD
		public const string OPEN_BESTIARY = "OPEN_BESTIARY"; // Metadata: 0x01976DEB
		public const string OPEN_SECRETS = "OPEN_SECRETS"; // Metadata: 0x01976DF9
		public const string OPEN_DLC_STORE = "OPEN_DLC_STORE"; // Metadata: 0x01976E06
		public const string OPEN_ACCOUNT_PAGE = "OPEN_ACCOUNT_PAGE"; // Metadata: 0x01976E15
		public const string SELECT_ADVENTURE = "SELECT_ADVENTURE"; // Metadata: 0x01976E27
		public const string OPEN_TPCREDITS = "OPEN_TPCREDITS"; // Metadata: 0x01976E38
		public const string SHOW_WARNING = "SHOW_WARNING"; // Metadata: 0x01976E47
		public bool SkipToGame; // 0x58
		[HideInInspector]
		public SignalBus SignalBus; // 0x60
		[HideInInspector]
		public PlayerOptions Options; // 0x68
		[HideInInspector]
		public MultiplayerManager Multiplayer; // 0x70
	
		// Properties
		public static AppStateMachine Instance { get; private set; } // 0x0000000186C56400-0x0000000186C56440 0x0000000186C56440-0x0000000186C564E0
	
		// Constructors
		public AppStateMachine() {} // 0x0000000186C57480-0x0000000186C57490
	
		// Methods
		private void Awake() {} // 0x0000000186C564E0-0x0000000186C56640
		private void OnDestroy() {} // 0x0000000186C56640-0x0000000186C56650
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions options, MultiplayerManager multi) {} // 0x00000001868F29C0-0x00000001868F2AC0
		[IteratorStateMachine(typeof(_Start_d__36))]
		private IEnumerator Start() => default; // 0x0000000186C56650-0x0000000186C566F0
		private void AddAllTransitions() {} // 0x0000000186C566F0-0x0000000186C57480
	}
}
