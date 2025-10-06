/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TPCreditsPage : BaseUIPage // TypeDefIndex: 15017
	{
		// Fields
		public static VampireSurvivors.Data.CharacterType[] CharactersToUnlocks; // 0x00
		[SerializeField]
		private RectTransform _Container; // 0xE0
		[SerializeField]
		private GameObject _TextPrefab; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xF0
		[SerializeField]
		private RectTransform _CongaContainer; // 0xF8
		[SerializeField]
		private GameObject _CongaItem; // 0x100
		[SerializeField]
		private CanvasGroup _NowLoading; // 0x108
		[SerializeField]
		private TPCreditsScene _ScenePrefab; // 0x110
		[SerializeField]
		private AnimationClip _Animation; // 0x118
		[SerializeField]
		private Animator _Animator; // 0x120
		[SerializeField]
		private GameObject _Hand; // 0x128
		[SerializeField]
		private Image _EndFlash; // 0x130
		[SerializeField]
		private RectTransform _Rotator; // 0x138
		[SerializeField]
		private GameObject _Overlay; // 0x140
		[SerializeField]
		private GameObject _VideoDisplay; // 0x148
		[SerializeField]
		private Material _NowLoadingMaterial; // 0x150
		[SerializeField]
		private float _NowLoadingInputSpeed; // 0x158
		private PlayerOptions _playerOptions; // 0x160
		private DataManager _data; // 0x168
		private MultiplayerManager _multiplayerManager; // 0x170
		public static string CACHE_GROUP_NAME; // 0x08
		private TPCreditsScene _sceneInstance; // 0x178
		private List<WiggleTween> _movementTweens; // 0x180
		private List<EnemyType> _enemyList; // 0x188
		private List<VampireSurvivors.Data.CharacterType> _characterList; // 0x190
		private Dictionary<EnemyType, List<EnemyData>> _enemyData; // 0x198
		private Dictionary<VampireSurvivors.Data.CharacterType, List<CharacterData>> _characterData; // 0x1A0
		private List<UISpriteAnimation> _anims; // 0x1A8
		private int _moveTweenIndex; // 0x1B0
		[ReadOnly]
		[SerializeField]
		private float _congaSpeed; // 0x1B4
		private int _congaLength; // 0x1B8
		private float _widthCounter; // 0x1BC
		private int _enemyCount; // 0x1C0
		private int _characterCount; // 0x1C4
		private bool _syncAudioCheck; // 0x1C8
		private float _currentTime; // 0x1CC
		private Vector2 _JSDefaultScreenSize; // 0x1D0
		private List<RectTransform> _spawnedConga; // 0x1D8
		private PlaySoundResult _soundResult; // 0x1E0
		private float _normalizedTime; // 0x1E8
		private float _animLength; // 0x1EC
		private bool _isPlaying; // 0x1F0
		private bool _loadingComplete; // 0x1F1
	
		// Constructors
		public TPCreditsPage() {} // 0x00000001869B28C0-0x00000001869B2D70
		static TPCreditsPage() {} // 0x00000001869B2D70-0x00000001869B2ED0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, DataManager data, MultiplayerManager multi) {} // 0x00000001869ADBB0-0x00000001869ADCD0
		protected void FixedUpdate() {} // 0x00000001869ADCD0-0x00000001869AE210
		protected override void Update() {} // 0x00000001869AE210-0x00000001869AE690
		public void SetTime(float time) {} // 0x00000001869AE690-0x00000001869AE730
		public void TakeMyHand() {} // 0x00000001869AE730-0x00000001869AE7D0
		protected override void OnShowStart(GameObject g) {} // 0x00000001869AE7D0-0x00000001869AEB90
		protected override void OnShowFinish(GameObject g) {} // 0x00000001869AEB90-0x00000001869AEC40
		protected override void OnHideFinish(GameObject g) {} // 0x00000001869AEC40-0x00000001869AEF10
		[IteratorStateMachine(typeof(_WaitAndHide_d__51))]
		private IEnumerator WaitAndHide() => default; // 0x00000001869AEF10-0x00000001869AEFB0
		[IteratorStateMachine(typeof(_WaitAndFormatPortrait_d__52))]
		private IEnumerator WaitAndFormatPortrait() => default; // 0x00000001869AEFB0-0x00000001869AF050
		private void Play() {} // 0x00000001869AF050-0x00000001869AF1C0
		[IteratorStateMachine(typeof(_WaitAndPlay_d__54))]
		private IEnumerator WaitAndPlay() => default; // 0x00000001869AF1C0-0x00000001869AF260
		private void GenerateFramesAndEvents() {} // 0x0000000180B15170-0x0000000180B15180
		private void GenerateTextKeyFrames() {} // 0x00000001869AF260-0x00000001869AF4D0
		private void SetMusic() {} // 0x00000001869AF4D0-0x00000001869AF5C0
		private void CreateConga() {} // 0x00000001869AF5C0-0x00000001869AF6F0
		private void CreateWiggleTweens() {} // 0x00000001869AF6F0-0x00000001869AF7E0
		private void CreateEnemyList() {} // 0x00000001869AF7E0-0x00000001869B09A0
		public void PlayVideo() {} // 0x00000001869B09A0-0x00000001869B0B30
		private void GetNextCharacter() {} // 0x00000001869B0B30-0x00000001869B10E0
		private GameObject CreateEnemyAnimation(EnemyType type, int frameIndex = 0 /* Metadata: 0x01977274 */) => default; // 0x00000001869B10E0-0x00000001869B12C0
		private void CreateCharacterAnimation(VampireSurvivors.Data.CharacterType type, int frameIndex = 0 /* Metadata: 0x01977275 */) {} // 0x00000001869B12C0-0x00000001869B1600
		private GameObject CreatePawn(List<Sprite> sprites, bool flip = false /* Metadata: 0x01977276 */) => default; // 0x00000001869B1600-0x00000001869B1C50
		private void CreateCharacterList() {} // 0x00000001869B1C50-0x00000001869B2730
		private void BuildCredits() {} // 0x00000001869B2730-0x00000001869B27B0
		private void AddText(string t) {} // 0x00000001869B27B0-0x00000001869B2830
		public void DisableAllInput() {} // 0x00000001869B2830-0x00000001869B28C0
	}
}
