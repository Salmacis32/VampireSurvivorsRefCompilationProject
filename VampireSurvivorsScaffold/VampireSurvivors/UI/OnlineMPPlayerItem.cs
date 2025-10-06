/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OnlineMPPlayerItem : MonoBehaviour // TypeDefIndex: 14886
	{
		// Fields
		[SerializeField]
		private GameObject _CharacterSelectedGroup; // 0x20
		[SerializeField]
		private GameObject _PlayerNotConnected; // 0x28
		[SerializeField]
		private Image _Frame; // 0x30
		[SerializeField]
		private Image _OuterFrame; // 0x38
		[SerializeField]
		private TextMeshProUGUI _CharacterName; // 0x40
		[SerializeField]
		private TextMeshProUGUI _PlayerName; // 0x48
		[SerializeField]
		private Image _CharacterIcon; // 0x50
		[SerializeField]
		private Image _WeaponIcon; // 0x58
		[SerializeField]
		private Image _WeaponShadow; // 0x60
		[SerializeField]
		private GameObject _selectionFrame; // 0x68
		[SerializeField]
		private GameObject _selectionBox; // 0x70
		[SerializeField]
		private GameObject _selectionTick; // 0x78
		[SerializeField]
		private GameObject _aiSettingsButton; // 0x80
		private DataManager _dataManager; // 0x88
		private PlayerOptions _playerOptions; // 0x90
		private VampireSurvivors.PlayerInfo _onlinePlayerInfo; // 0x98
		private CharacterData _data; // 0xA0
		private int _index; // 0xA8
		private bool _isMyPlayerButton; // 0xAC
	
		// Properties
		public VampireSurvivors.PlayerInfo OnlinePlayerInfo { get => default; } // 0x0000000181971630-0x0000000181971640 
	
		// Events
		public event Action OnAiSettingsButtonClicked;
	
		// Constructors
		public OnlineMPPlayerItem() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(DataManager dataManager, PlayerOptions playerOptions) {} // 0x0000000185E0E450-0x0000000185E0E510
		private void Awake() {} // 0x00000001869088B0-0x0000000186908990
		public void Init(VampireSurvivors.PlayerInfo playerInfo, int seatNumber) {} // 0x0000000186908990-0x00000001869090C0
		private void OnDestroy() {} // 0x00000001869090C0-0x00000001869093D0
		private void Update() {} // 0x00000001869093D0-0x00000001869095B0
		public void SetAIData(VampireSurvivors.Data.CharacterType type, int index) {} // 0x00000001869095B0-0x0000000186909730
		private void RefreshForSkin(SkinType skinType) {} // 0x0000000186909730-0x0000000186909760
		private void SetData(VampireSurvivors.Data.CharacterType type) {} // 0x0000000186909760-0x0000000186909F60
		private void SetWeaponIconSprite(CharacterData characterData, Skin skinData) {} // 0x0000000186909F60-0x000000018690A2C0
		private void SetColor(float saturation = 1f /* Metadata: 0x0197723B */) {} // 0x000000018690A2C0-0x000000018690A410
	}
}
