/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GameStateMachine : StateMachine // TypeDefIndex: 14121
	{
		// Fields
		public const string INITIALIZE_GAME = "INITIALIZE_GAME"; // Metadata: 0x01976E54
		public const string GAME_READY = "GAME_READY"; // Metadata: 0x01976E64
		public const string PAUSE_GAME = "PAUSE_GAME"; // Metadata: 0x01976E6F
		public const string RETURN_TO_GAME = "RETURN_TO_GAME"; // Metadata: 0x01976E7A
		public const string OPEN_TREASURE = "OPEN_TREASURE"; // Metadata: 0x01976E89
		public const string LEVEL_UP = "LEVEL_UP"; // Metadata: 0x01976E97
		public const string PLAYER_DIED = "PLAYER_DIED"; // Metadata: 0x01976EA0
		public const string GAME_OVER = "GAME_OVER"; // Metadata: 0x01976EAC
		public const string QUIT_GAME = "QUIT_GAME"; // Metadata: 0x01976EB6
		public const string ITEM_FOUND = "ITEM_FOUND"; // Metadata: 0x01976EC0
		public const string RELIC_FOUND = "RELIC_FOUND"; // Metadata: 0x01976ECB
		public const string CHARACTER_FOUND = "CHARACTER_FOUND"; // Metadata: 0x01976ED7
		public const string REVIVE = "REVIVE"; // Metadata: 0x01976EE7
		public const string RECAP = "RECAP"; // Metadata: 0x01976EEE
		public const string SELECT_ARCANA = "SELECT_ARCANA"; // Metadata: 0x01976EF4
		public const string SELECT_SURVAROTS = "SELECT_SURVAROTS"; // Metadata: 0x01976F02
		public const string OPEN_SHOP = "OPEN_SHOP"; // Metadata: 0x01976F13
		public const string DIRECT_TO_RECAP = "DIRECT_TO_RECAP"; // Metadata: 0x01976F1D
		public const string RETURN_TO_LANDING = "RETURN_TO_LANDING"; // Metadata: 0x01976F2D
		public const string OPEN_WEAPON_SELECTION = "OPEN_WEAPON_SELECTION"; // Metadata: 0x01976F3F
		public const string OPEN_SKILL_SELECTION = "OPEN_SKILL_SELECTION"; // Metadata: 0x01976F55
		public const string OPEN_HEALER = "OPEN_HEALER"; // Metadata: 0x01976F6A
		public const string OPEN_DIRECTOR = "OPEN_DIRECTOR"; // Metadata: 0x01976F76
		public const string OPEN_PIANO = "OPEN_PIANO"; // Metadata: 0x01976F84
		public const string PLAY_FINAL_CREDITS = "PLAY_FINAL_CREDITS"; // Metadata: 0x01976F8F
		public const string SHOW_GAMEOVERINO = "SHOW_GAMEOVERINO"; // Metadata: 0x01976FA2
		public const string SHOW_FINAL_FIREWORKS = "SHOW_FINAL_FIREWORKS"; // Metadata: 0x01976FB3
		public const string OPEN_LEVEL_BONUS_SELECTION = "OPEN_LEVEL_BONUS_SELECTION"; // Metadata: 0x01976FC8
		public const string OPEN_TP_WEAPON_SELECTION = "OPEN_TP_WEAPON_SELECTION"; // Metadata: 0x01976FE3
		public const string CONNECTION_ERROR = "CONNECTION_ERROR"; // Metadata: 0x01976FFC
		[HideInInspector]
		public SignalBus SignalBus; // 0x60
	
		// Properties
		public Player Player { get; private set; } // 0x00000001819A0210-0x00000001819A0220 0x00000001827660A0-0x0000000182766100
		public GameManager GameplayManager { get; private set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
		public PlayerOptions PlayerOptions { get; private set; } // 0x00000001819A0360-0x00000001819A0370 0x0000000181917690-0x00000001819176F0
		public string CurrentStateName { get => default; } // 0x0000000186C5BF30-0x0000000186C5C060 
	
		// Events
		public event OnBroadcastStateChange StateChange;
	
		// Nested types
		public delegate void OnBroadcastStateChange(string eventString); // TypeDefIndex: 14119; 0x000000018196C5F0-0x000000018196C600
	
		// Constructors
		public GameStateMachine() {} // 0x0000000186C57480-0x0000000186C57490
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, GameManager gameManager, PlayerOptions playerOptions) {} // 0x0000000186C5C060-0x0000000186C5C160
		private void Awake() {} // 0x0000000186930AC0-0x0000000186930AD0
		[IteratorStateMachine(typeof(_Start_d__51))]
		private IEnumerator Start() => default; // 0x0000000186C5C160-0x0000000186C5C200
		private void AddTransitions() {} // 0x0000000186C5C200-0x0000000186C5CF50
		public void StartGame() {} // 0x0000000186C5CF50-0x0000000186C5CFA0
		public void PauseGame() {} // 0x0000000186C5CFA0-0x0000000186C5CFC0
		public void UnpauseGame() {} // 0x0000000186C5CFC0-0x0000000186C5CFE0
		public void BroadcastEvent(string eventStr) {} // 0x0000000186C5CFE0-0x0000000186C5D000
	}
}
