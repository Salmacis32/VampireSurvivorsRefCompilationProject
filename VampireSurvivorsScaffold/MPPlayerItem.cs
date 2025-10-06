/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Algorithm;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class MPPlayerItem : MonoBehaviour // TypeDefIndex: 13868
{
	// Fields
	[SerializeField]
	private GameObject _CharacterSelectedGroup; // 0x20
	[SerializeField]
	private GameObject _AwaitingPlayerGroup; // 0x28
	[SerializeField]
	private GameObject _AwaitingSelectionGroup; // 0x30
	[SerializeField]
	private GameObject _AwaitingTurnGroup; // 0x38
	[SerializeField]
	private GameObject _AwaitingConnect; // 0x40
	[SerializeField]
	private TextMeshProUGUI _AwaitingConnectText; // 0x48
	[SerializeField]
	private Image _Frame; // 0x50
	[SerializeField]
	private Image _OuterFrame; // 0x58
	[SerializeField]
	private TextMeshProUGUI _CharacterName; // 0x60
	[SerializeField]
	private TextMeshProUGUI _PlayerName; // 0x68
	[SerializeField]
	private Image _CharacterIcon; // 0x70
	[SerializeField]
	private Image _WeaponIcon; // 0x78
	[SerializeField]
	private Image _WeaponShadow; // 0x80
	[SerializeField]
	private Image _aiIcon; // 0x88
	private Player _player; // 0x90
	public PlayerState _PlayerState; // 0x98
	private DataManager _dataManager; // 0xA8
	private PlayerOptions _playerOptions; // 0xB0
	private VampireSurvivors.Data.CharacterType _type; // 0xB8
	private CharacterData _data; // 0xC0
	private int _index; // 0xC8
	public bool _aiCharacter; // 0xCC
	private AIType _aiType; // 0xD0
	private bool _isPartyMode; // 0xD4

	// Properties
	public Player Player { get => default; } // 0x0000000181919F80-0x0000000181919F90 
	public bool IsAI { get => default; } // 0x0000000185EF5B10-0x0000000185EF5B20 
	public VampireSurvivors.Data.CharacterType Type { get => default; } // 0x0000000182937930-0x0000000182937940 
	public AIType AIType { get => default; } // 0x0000000181BDC430-0x0000000181BDC440 

	// Events
	public event Action OnAiSettingsButtonClicked;

	// Nested types
	public enum PlayerState // TypeDefIndex: 13867
	{
		INACTIVE = 0,
		CONNECTED = 1,
		WAITING = 2,
		SELECTING = 3,
		FINISHED = 4,
		LOCKED = 5
	}

	// Constructors
	public MPPlayerItem() {} // 0x0000000180B18150-0x0000000180B181A0

	// Methods
	public void Initialize(DataManager dataManager, PlayerOptions playerOptions) {} // 0x00000001865B2D90-0x00000001865B2F20
	private void Awake() {} // 0x00000001865B2F20-0x00000001865B2F60
	public void SetAIType(AIType aiType) {} // 0x0000000181BDC440-0x0000000181BDC450
	public void SetPlayer(Player p) {} // 0x00000001865B2F60-0x00000001865B30C0
	public void SetCharacterType(VampireSurvivors.Data.CharacterType characterType) {} // 0x00000001865B30C0-0x00000001865B30D0
	private void Update() {} // 0x00000001865B30D0-0x00000001865B3BD0
	public void SetData() {} // 0x00000001865B3BD0-0x00000001865B4060
	private void SetWeaponIconSprite(CharacterData characterData, Skin skinData) {} // 0x00000001865B4060-0x00000001865B4290
	public void GoToInactive() {} // 0x00000001865B4290-0x00000001865B45B0
	public void SetPartymodeText() {} // 0x00000001865B45B0-0x00000001865B46B0
	public void GoToConnected() {} // 0x00000001865B46B0-0x00000001865B4870
	public void LockSelection() {} // 0x00000001865B4870-0x00000001865B4880
	public void UnlockSelected() {} // 0x00000001865B4880-0x00000001865B4890
	public void SetPlayerName(int index) {} // 0x00000001865B4890-0x00000001865B4A10
	public void GoToWaiting() {} // 0x00000001865B4A10-0x00000001865B4C00
	public void SetIndex(int index) {} // 0x0000000184E1A070-0x0000000184E1A080
	private void SetColor(float saturation = 1f /* Metadata: 0x01976A4F */) {} // 0x00000001865B4C00-0x00000001865B4D50
	public void GoToSelecting() {} // 0x00000001865B4D50-0x00000001865B4E60
	public void GoToFInished() {} // 0x00000001865B4E60-0x00000001865B4F90
	public void UpdateAIIcon() {} // 0x00000001865B4F90-0x00000001865B5120
	public void RefreshData() {} // 0x00000001865B5120-0x00000001865B5560
}

