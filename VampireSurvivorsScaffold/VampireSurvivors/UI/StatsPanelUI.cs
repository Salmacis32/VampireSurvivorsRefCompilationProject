/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class StatsPanelUI : MonoBehaviour // TypeDefIndex: 14992
	{
		// Fields
		[FormerlySerializedAs("StatPrefab")]
		[SerializeField]
		private StatItemUI _StatPrefab; // 0x20
		[FormerlySerializedAs("Container")]
		[SerializeField]
		private RectTransform _Container; // 0x28
		[FormerlySerializedAs("StatObjects")]
		[SerializeField]
		private List<StatItemUI> _StatObjects; // 0x30
		private bool _hasLoaded; // 0x38
		private PlayerStats _stats; // 0x40
		private DataManager _dataManager; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private EggManager _eggManager; // 0x58
		private MultiplayerManager _multiplayer; // 0x60
		private AdventureManager _adventureManager; // 0x68
		private Dictionary<PowerUpType, PlayerStat> _playerStats; // 0x70
		private Dictionary<PowerUpType, List<PowerUpData>> _powerUps; // 0x78
		private CharacterData _currentCharacter; // 0x80
		private VampireSurvivors.Data.CharacterType _currentCharacterType; // 0x88
		private VampireSurvivors.Objects.Characters.CharacterController _inGameCharacter; // 0x90
		private List<TextMeshProUGUI> _statTextLines; // 0x98
		private bool _isInGame; // 0xA0
		private bool _useEggs; // 0xA1
	
		// Constructors
		public StatsPanelUI() {} // 0x000000018699B480-0x000000018699B610
	
		// Methods
		[Inject]
		private void Construct(PlayerStats stats, DataManager data, PlayerOptions playerOptions, EggManager egg, MultiplayerManager multi, AdventureManager adventureManager) {} // 0x0000000186998930-0x0000000186998B30
		public void Initialize() {} // 0x0000000186998B30-0x0000000186998B70
		public void SetCharacter(CharacterData character, VampireSurvivors.Data.CharacterType type, VampireSurvivors.Objects.Characters.CharacterController ingameCharacter = null) {} // 0x0000000186998B70-0x0000000186998E60
		public void Refresh() {} // 0x0000000186998E60-0x0000000186998E70
		public void EggsToggled() {} // 0x0000000186998E60-0x0000000186998E70
		private void Populate() {} // 0x0000000186998E70-0x00000001869991C0
		private void AddStat(PowerUpType type, PowerUpData data, float val) {} // 0x00000001869991C0-0x00000001869992B0
		private void SetValues() {} // 0x00000001869992B0-0x0000000186999E70
		private float GetPowerUpStatValue(PlayerStat playerStat) => default; // 0x0000000186999E70-0x000000018699A1F0
		private float CheckForOmni(Dictionary<PowerUpType, PlayerStat> playerStat, PowerUpType type) => default; // 0x000000018699A1F0-0x000000018699A600
		private float GetPowerUpStatValueByType(PowerUpType powerUpType, ModifierStats modifierStats) => default; // 0x000000018699A600-0x000000018699A810
		private float GetCharacterValueFromPowerUpType(PowerUpType type) => default; // 0x000000018699A810-0x000000018699B2B0
		private float GetSkinStat(PowerUpType type) => default; // 0x000000018699B2B0-0x000000018699B480
	}
}
