/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class PlayerInfo : MonoBehaviour // TypeDefIndex: 14054
	{
		// Fields
		public Action<int, int, VampireSurvivors.Objects.Characters.CharacterController> OnLevelUpSuggestedCallback; // 0x30
		public Action<VampireSurvivors.Data.CharacterType> OnCharacterSelectionChanged; // 0x40
		public Action<SkinType> OnSkinSelectionChanged; // 0x48
		private VampireSurvivors.Data.CharacterType _selectedCharacter; // 0x50
		private SkinType _skinType; // 0x54
		private bool _isReadyToPlay; // 0x58
		private bool _sceneLoaded; // 0x59
		private bool _gameplayLoaded; // 0x5A
		private bool _stageInitialized; // 0x5B
		private CoherenceSync _characterEntity; // 0x60
		private VampireSurvivors.Objects.Characters.CharacterController _characterController; // 0x68
		private CoherenceSync _coherenceSync; // 0x70
		private int _averageLatencyMs; // 0x78
		private int _suggestedLevelUp; // 0x7C
		private List<byte[]> _powerUpChunks; // 0x80
		private Dictionary<PowerUpType, PlayerStat> _hostPowerUps; // 0x88
		private bool _isInBanishMode; // 0x90
		private bool _hasGameplayUiActive; // 0x91
	
		// Properties
		[OnValueSynced("OnCharacterUpdate")]
		[Sync]
		public int SelectedCharacter { get => default; set {} } // 0x0000000180B15770-0x0000000180B15780 0x0000000182621130-0x0000000182621140
		[OnValueSynced("OnSkinUpdate")]
		[Sync]
		public int SelectedSkin { get => default; set {} } // 0x00000001819A01D0-0x00000001819A01E0 0x0000000181EDFC70-0x0000000181EDFC80
		[Sync]
		public bool IsReadyToPlay { get => default; set {} } // 0x00000001827FCB50-0x00000001827FCB60 0x00000001827FCB60-0x00000001827FCB70
		[Sync]
		public bool SceneLoaded { get => default; set {} } // 0x000000018491C7F0-0x000000018491C800 0x0000000184BE3070-0x0000000184BE3080
		[Sync]
		public bool GameplayLoaded { get => default; set {} } // 0x000000018277C8F0-0x000000018277C900 0x0000000186C3BC80-0x0000000186C3BC90
		[Sync]
		public bool StageInitialized { get => default; set {} } // 0x0000000185EA8420-0x0000000185EA8430 0x0000000185EA8430-0x0000000185EA8440
		[Sync]
		public CoherenceSync CharacterEntity { get => default; set {} } // 0x0000000180B15740-0x0000000180B15750 0x000000018117C120-0x000000018117C180
		[Sync]
		public int AverageLatencyMs { get => default; set {} } // 0x0000000182926B50-0x0000000182926B60 0x0000000185050F70-0x0000000185050F80
		[OnValueSynced("OnLevelUpSuggested")]
		[Sync]
		public int SuggestedLevelUp { get => default; set {} } // 0x0000000181BABDF0-0x0000000181BABE00 0x0000000181BABE00-0x0000000181BABE10
		[Sync]
		public bool IsInBanishMode { get => default; set {} } // 0x00000001819643B0-0x00000001819643C0 0x00000001826FAF20-0x00000001826FAF30
		[Sync]
		public bool HasGameplayUiActive { get => default; set {} } // 0x00000001854115C0-0x00000001854115D0 0x000000018675B7E0-0x000000018675B7F0
		[Sync]
		public int UiPageId { get; set; } // 0x000000018195ECC0-0x000000018195ECD0 0x0000000181962000-0x0000000181962010
		[Sync]
		public string UserName { get; set; } // 0x0000000180B15540-0x0000000180B15550 0x0000000180B1D4C0-0x0000000180B1D520
		public VampireSurvivors.Objects.Characters.CharacterController CharacterController { get => default; } // 0x0000000186C3BC90-0x0000000186C3BE70 
		public bool UpdateAverageLatency { get; set; } // 0x000000018274EAA0-0x000000018274EAB0 0x0000000180B1D580-0x0000000180B1D590
		public bool HasStateAuthority { get => default; } // 0x0000000186C3BE70-0x0000000186C3BEE0 
	
		// Constructors
		public PlayerInfo() {} // 0x0000000186C3C340-0x0000000186C3C390
	
		// Methods
		public void OnCharacterUpdate(int oldCharacter, int newCharacter) {} // 0x0000000186C3BEE0-0x0000000186C3BF00
		public void OnSkinUpdate(int oldSkin, int newSkin) {} // 0x0000000186C3BF00-0x0000000186C3BF20
		public void OnLevelUpSuggested(int old, int newSuggestion) {} // 0x0000000186C3BF20-0x0000000186C3BFE0
		public void ResetGameSession() {} // 0x0000000186C3BFE0-0x0000000186C3C050
		private void Awake() {} // 0x0000000186C3C050-0x0000000186C3C190
		private void Update() {} // 0x0000000186C3C190-0x0000000186C3C340
	}
}
