/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AdvancedMusicSelection : BasePopup // TypeDefIndex: 14651
	{
		// Fields
		[Header("Albums")]
		[SerializeField]
		private RectTransform _AlbumContainer; // 0x48
		[SerializeField]
		private GameObject _AlbumPrefab; // 0x50
		[SerializeField]
		private UICarousel _Carousel; // 0x58
		[SerializeField]
		private CanvasGroup _AlbumGroup; // 0x60
		[Header("Tracks")]
		[SerializeField]
		private RectTransform _TrackContainer; // 0x68
		[SerializeField]
		private GameObject _TrackPrefab; // 0x70
		[SerializeField]
		private CanvasGroup _TrackGroup; // 0x78
		[Header("Info Panel")]
		[SerializeField]
		private TextMeshProUGUI _Name; // 0x80
		[SerializeField]
		private TextMeshProUGUI _Author; // 0x88
		[SerializeField]
		private TextMeshProUGUI _Duration; // 0x90
		[SerializeField]
		private TextMeshProUGUI _Playback; // 0x98
		[SerializeField]
		private TextMeshProUGUI _Modifier; // 0xA0
		[SerializeField]
		private TickBoxUI _PlayOnlyDuringGameplay; // 0xA8
		[SerializeField]
		private Image _Icon; // 0xB0
		[SerializeField]
		private UnityEngine.UI.Button _ModifierButton; // 0xB8
		[SerializeField]
		private UnityEngine.UI.Button _ConfirmButton; // 0xC0
		[SerializeField]
		private UnityEngine.UI.Button _PlaybackButton; // 0xC8
		[SerializeField]
		private TickBoxUI _LockSelected; // 0xD0
		[Header("General")]
		[SerializeField]
		private RectTransform _Panel; // 0xD8
		[SerializeField]
		private UnityEngine.UI.Button _CloseButton; // 0xE0
		[SerializeField]
		private GameObject _InfoPanel; // 0xE8
		[Header("Sensitivity")]
		[SerializeField]
		private float _HorizontalAlbumNavigationSensitivity; // 0xF0
		private List<KeyValuePair<AlbumType, AlbumData>> _albums; // 0x100
		private List<GameObject> _spawnedAlbums; // 0x108
		private List<TrackItemUI> _spawnedTracks; // 0x110
		private List<BgmModType> _speedList; // 0x118
		private List<BgmPlaybackType> _playbackList; // 0x120
		private BgmModType _selectedSpeed; // 0x128
		private int _speedIndex; // 0x12C
		private BgmPlaybackType _selectedPlayback; // 0x130
		private int _playbackIndex; // 0x134
		private int _albumIndex; // 0x138
		private global::Rewired.Player _player; // 0x140
		private TrackItemUI _selectedTrack; // 0x148
		private DataManager _data; // 0x150
		private MultiplayerManager _multiplayer; // 0x158
		private PlayerOptions _playerOptions; // 0x160
		private DiContainer _diContainer; // 0x168
		private BgmType _defaultSong; // 0x170
		private bool _canInteract; // 0x174
		private bool _axisReset; // 0x175
		private int _currentTrackIndex; // 0x178
		private string _currentCacheName; // 0x180
		private BgmType _currentPlayingTrack; // 0x188
		private bool _initialLockSelected; // 0x18C
		private BgmType _initialBGMType; // 0x190
		private BgmModType _initialBGMMod; // 0x194
		private NavigationPhase _navPhase; // 0x198
	
		// Events
		public event OnSelectionChanged SelectedTrackChanged;
	
		// Nested types
		public delegate void OnSelectionChanged(); // TypeDefIndex: 14647; 0x000000018196C270-0x000000018196C280
	
		private enum NavigationPhase // TypeDefIndex: 14648
		{
			TRACKS = 0,
			SETTINGS = 1,
			UNIVERSAL = 2
		}
	
		// Constructors
		public AdvancedMusicSelection() {} // 0x0000000187315E80-0x0000000187316240
	
		// Methods
		[Inject]
		private void Construct(DataManager data, MultiplayerManager multi, PlayerOptions playerOptions) {} // 0x0000000187310310-0x0000000187310430
		private void Awake() {} // 0x0000000187310430-0x0000000187310670
		private void ChangeAlbum(int index) {} // 0x0000000187310670-0x0000000187310E50
		private void SpawnTracksForAlbum() {} // 0x0000000187310E50-0x0000000187311350
		[IteratorStateMachine(typeof(_Start_d__57))]
		private IEnumerator Start() => default; // 0x0000000187311350-0x00000001873113F0
		private bool GetMusicData(BgmType bgmType, out MusicData musicData) {
			musicData = default;
			return default;
		} // 0x00000001873113F0-0x0000000187311580
		private void PlayAtSpeed() {} // 0x0000000187311580-0x0000000187311C20
		public void Confirm() {} // 0x0000000187311C20-0x0000000187311E10
		public void SetCurrentSelectedSong(BgmType current) {} // 0x0000000186EDD140-0x0000000186EDD150
		public void ClosePopup() {} // 0x0000000187311E10-0x0000000187312090
		private void ReleaseBGM() {} // 0x0000000187312090-0x0000000187312110
		private void OnDestroy() {} // 0x0000000187312110-0x0000000187312680
		private void SetTracksUnlocked() {} // 0x0000000187312680-0x0000000187312B60
		private void TogglePlayDuringRun(bool isOn) {} // 0x0000000187312B60-0x0000000187312B90
		public void AddSpeed(BgmModType bgmMod) {} // 0x0000000187312B90-0x0000000187312C40
		private void AddPlayback(BgmPlaybackType pb) {} // 0x0000000187312C40-0x0000000187312CF0
		public void SetSpeed(BgmModType speed) {} // 0x0000000187312CF0-0x0000000187312DF0
		public void SetPlayback(BgmPlaybackType pb) {} // 0x0000000187312DF0-0x0000000187312EF0
		public void PreviousPlayback() {} // 0x0000000187312EF0-0x0000000187312FC0
		public void PreviousSpeed() {} // 0x0000000187312FC0-0x0000000187313090
		public void NextSpeed() {} // 0x0000000187313090-0x0000000187313330
		public void NextPlayback() {} // 0x0000000187313330-0x0000000187313470
		private void OnInputMethodChanged(UIHelper.ActiveInputType newinput) {} // 0x0000000187313470-0x00000001873134A0
		private void Update() {} // 0x00000001873134A0-0x0000000187313990
		private new void LateUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		private void VisuallyDisableInfoPanel() {} // 0x0000000187313990-0x0000000187313A70
		private void VisuallyEnableInfoPanel() {} // 0x0000000187313A70-0x0000000187313B50
		private void VisuallyDisableTopPanel() {} // 0x0000000187313B50-0x0000000187313BA0
		private void VisuallyEnableTopPanel() {} // 0x0000000187313BA0-0x0000000187313BF0
		private void SetTrackNavigation(Selectable defaultSelected = null) {} // 0x0000000187313BF0-0x0000000187314050
		private int FindAlbumIndexForTrack(BgmType track) => default; // 0x0000000187314050-0x00000001873142F0
		private void SetPhase3Navigation() {} // 0x00000001873142F0-0x00000001873143C0
		private void SetUniversalNavigation() {} // 0x00000001873143C0-0x0000000187314420
		public void SelectNextTrack() {} // 0x0000000187314420-0x0000000187314590
		public void SelectTrack(TrackItemUI track) {} // 0x0000000187314590-0x00000001873147E0
		public void SelectPreviousTrack() {} // 0x00000001873147E0-0x0000000187314950
		private void UpdateInfoPanel() {} // 0x0000000187314950-0x0000000187314BA0
		public void Populate() {} // 0x0000000187314BA0-0x0000000187314BD0
		private void SetDefaultAlbumIndex() {} // 0x0000000187314BD0-0x0000000187314D40
		private Selectable GetDefaultSelectedItem() => default; // 0x0000000187314D40-0x0000000187314E60
		private void SpawnAlbums() {} // 0x0000000187314E60-0x00000001873152F0
		public void SetSelectedTrack(TrackItemUI t) {} // 0x00000001873152F0-0x00000001873154E0
		private void GenerateTrackNavigation() {} // 0x00000001873154E0-0x0000000187315AB0
		private void SetSpeedName() {} // 0x0000000187315AB0-0x0000000187315C10
		private void SetPlaybackName() {} // 0x0000000187315C10-0x0000000187315CA0
		private TrackItemUI SpawnTrack(BgmType t, MusicData d) => default; // 0x0000000187315CA0-0x0000000187315E50
		public void ToggleLockSelected(bool b) {} // 0x0000000187315E50-0x0000000187315E80
	}
}
