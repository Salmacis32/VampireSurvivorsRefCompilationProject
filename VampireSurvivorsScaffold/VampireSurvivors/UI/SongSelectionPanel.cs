/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SongSelectionPanel : MonoBehaviour // TypeDefIndex: 14980
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0x20
		[SerializeField]
		private TextMeshProUGUI _SongTitle; // 0x28
		[SerializeField]
		private TextMeshProUGUI _SpeedName; // 0x30
		[SerializeField]
		private TickBoxUI _LockSelectedBox; // 0x38
		private SignalBus _signalBus; // 0x40
		private DataManager _data; // 0x48
		private PlayerOptions _playerOptions; // 0x50
		private AdventureManager _adventureManager; // 0x58
		private Dictionary<BgmType, MusicData> _musicData; // 0x60
		private List<BgmModType> _speedList; // 0x68
		private List<BgmType> _songList; // 0x70
		private BgmType _selectedSong; // 0x78
		private BgmModType _selectedSpeed; // 0x7C
		private BgmType _previousSong; // 0x80
		private int _speedIndex; // 0x84
		private int _songIndex; // 0x88
		public static bool UserHasChangedSong; // 0x00
		private bool _isInitialSet; // 0x8C
		private bool _forceCharacterSongUntilManuallyChanged; // 0x8D
		private float _crossFadeTime; // 0x90
	
		// Constructors
		public SongSelectionPanel() {} // 0x000000018696C5F0-0x000000018696C7A0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DataManager data, PlayerOptions player, AdventureManager adventureManager) {} // 0x00000001869699E0-0x0000000186969B30
		public void Initialize() {} // 0x0000000186969B30-0x000000018696A5F0
		public void Refresh() {} // 0x000000018696A5F0-0x000000018696A750
		public void MakeVisuallyDisabled() {} // 0x000000018696A750-0x000000018696A800
		public void MakeVisuallyEnabled() {} // 0x000000018696A800-0x000000018696A8B0
		private void UnlockAllSongsForAdventure() {} // 0x000000018696A8B0-0x000000018696AED0
		private void OnDisable() {} // 0x000000018696AED0-0x000000018696B030
		private void OnEnable() {} // 0x000000018696B030-0x000000018696B0B0
		public void Stop() {} // 0x000000018696B0B0-0x000000018696B100
		public void Confirm() {} // 0x000000018696B100-0x000000018696B150
		public void ToggleLockSelected(bool b) {} // 0x000000018696B150-0x000000018696B270
		public void SetStage(StageData s) {} // 0x000000018696B270-0x000000018696B680
		public BgmType GetCurrentSelectedTrack() => default; // 0x0000000182926B50-0x0000000182926B60
		public void PreviousSong() {} // 0x000000018696B680-0x000000018696B790
		public void NextSong() {} // 0x000000018696B790-0x000000018696B8A0
		public void PreviousSpeed() {} // 0x000000018696B8A0-0x000000018696B980
		public void NextSpeed() {} // 0x000000018696B980-0x000000018696BA60
		public void SetSpeed(BgmModType speed) {} // 0x000000018696BA60-0x000000018696BB60
		public void AddSong(BgmType bgm) {} // 0x000000018696BB60-0x000000018696BC00
		public void AddSpeed(BgmModType bgmMod) {} // 0x000000018696BC00-0x000000018696BCA0
		private bool GetMusicData(BgmType bgmType, out MusicData musicData) {
			musicData = default;
			return default;
		} // 0x000000018696BCA0-0x000000018696BE30
		private void PlayAtSpeed() {} // 0x000000018696BE30-0x000000018696C150
		private void SetSpeedName() {} // 0x000000018696C150-0x000000018696C2B0
		private void SetIcon() {} // 0x000000018696C2B0-0x000000018696C3E0
		private void SetName() {} // 0x000000018696C3E0-0x000000018696C5F0
	}
}
