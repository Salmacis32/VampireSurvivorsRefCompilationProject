/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIEffects;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.VFX.Shatter;
using VampireSurvivors.Spells;
using VampireSurvivors.Tools;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SecretsPage : BaseUIPage // TypeDefIndex: 14967
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _ObtainsText; // 0xE8
		[SerializeField]
		private GameObject _KeyboardButtonPrefab; // 0xF0
		[SerializeField]
		private GameObject _SpellCharacterPrefab; // 0xF8
		[SerializeField]
		private RectTransform _KeyboardContainer; // 0x100
		[SerializeField]
		private RectTransform _SpellCharacterContainer; // 0x108
		[SerializeField]
		private RectTransform _SpellCharacterContainer2; // 0x110
		[SerializeField]
		private RectTransform _SpellCharacterBackground; // 0x118
		[SerializeField]
		private GameObject _ShowKeyboardButton; // 0x120
		[SerializeField]
		private GameObject _SecretPrefab; // 0x128
		[SerializeField]
		private RectTransform _SecretContainer; // 0x130
		[SerializeField]
		private TextMeshProUGUI _Unlocks; // 0x138
		[SerializeField]
		private Image _CharacterRewardIcon; // 0x140
		[SerializeField]
		private Image _OtherRewardIcon; // 0x148
		[SerializeField]
		private Shake _PanelShake; // 0x150
		[SerializeField]
		private ParticleEmitterManager _RuneParticlesEmitter; // 0x158
		[SerializeField]
		private SecretUnlockPopup _UnlockPopup; // 0x160
		[SerializeField]
		private GameObject _TwirlPrefab; // 0x168
		[SerializeField]
		private RectTransform _TwirlContainer; // 0x170
		[SerializeField]
		private RectTransform _Spinner; // 0x178
		[FormerlySerializedAs("fakeScreenSprite")]
		[SerializeField]
		private Sprite fakeScreenSpriteLandScape; // 0x180
		[SerializeField]
		private Sprite fakeScreenSpritePortrait; // 0x188
		[Header("DevilRoom")]
		[SerializeField]
		private Image _DevilFader; // 0x190
		[SerializeField]
		private UIDissolve _DevilPattern; // 0x198
		[SerializeField]
		private RectTransform _DevilSpinner; // 0x1A0
		[SerializeField]
		private RectTransform _Skull; // 0x1A8
		[SerializeField]
		private ShatterVFX _Shatter; // 0x1B0
		[SerializeField]
		private Texture2D _GeneratedTexture; // 0x1B8
		[SerializeField]
		private RawImage _RunePatternImage; // 0x1C0
		[SerializeField]
		private RectTransform _RuneContainer; // 0x1C8
		private Dictionary<SecretType, SecretData> _secrets; // 0x1D0
		private Dictionary<VampireSurvivors.Data.CharacterType, List<CharacterData>> _characterData; // 0x1D8
		private string _currentEnteredCheat; // 0x1E0
		private int _characterIndex; // 0x1E8
		private int _maxLength; // 0x1EC
		private int _baseLength; // 0x1F0
		private bool _allowInput; // 0x1F4
		private bool _isBusy; // 0x1F5
		private bool _twirlsBuilt; // 0x1F6
		private DataManager _data; // 0x1F8
		private PlayerOptions _playerOptions; // 0x200
		private SpellsManager _spellsManager; // 0x208
		private ParticleSystem _runeParticles; // 0x210
		private ParticleSystem _inputParticles; // 0x218
		private GravityWell _gravityWell; // 0x220
		private List<UnityEngine.UI.Button> _keyboardButtons; // 0x228
		private List<GameObject> _spellGameCharacters; // 0x230
		private List<string> _spells; // 0x238
		private List<GameObject> _spawned; // 0x240
		private List<char> _characters; // 0x248
		private string[] _tints; // 0x250
		private string _spellString; // 0x258
		private float _baseCharacterSize; // 0x260
		private Vector3 _baseScale; // 0x264
		private SecretData _currentData; // 0x270
		private SecretType _currentType; // 0x278
		private SecretItemUI _currentItem; // 0x280
		private List<GameObject> _twirlContainer; // 0x288
		private List<Image> _twirlImages; // 0x290
		private bool _canNavigate; // 0x298
		private BgmType _previousBGM; // 0x29C
		private BgmModType _previousBGMMod; // 0x2A0
		private AchievementManager _achievementManager; // 0x2A8
	
		// Constructors
		public SecretsPage() {} // 0x0000000186961CA0-0x0000000186962C10
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player, SpellsManager spellsManager, AchievementManager achievementManager) {} // 0x0000000186951C80-0x0000000186951E00
		private void Start() {} // 0x0000000186951E00-0x0000000186951E10
		protected override void Awake() {} // 0x0000000186951E10-0x0000000186951F00
		[IteratorStateMachine(typeof(_DelayedInitShatter_d__66))]
		private IEnumerator DelayedInitShatter() => default; // 0x0000000186951F00-0x0000000186951FA0
		public void ShowKeyboard() {} // 0x0000000186951FA0-0x0000000186952010
		public void SetInfoPanel(SecretData data, SecretType type, SecretItemUI item) {} // 0x0000000186952010-0x0000000186953A30
		public void DoDevilEffect() {} // 0x0000000186953A30-0x00000001869540F0
		public void PlayRunes() {} // 0x00000001869540F0-0x00000001869546D0
		private void CreateRuneTexture() {} // 0x00000001869546D0-0x0000000186955770
		protected override void OnShowStart(GameObject g) {} // 0x0000000186955770-0x00000001869568D0
		[IteratorStateMachine(typeof(_WaitAndSelect_d__73))]
		private IEnumerator WaitAndSelect() => default; // 0x00000001869568D0-0x0000000186956970
		protected override void OnHideStart(GameObject g) {} // 0x0000000186956970-0x0000000186956B50
		private void NavigationWrap() {} // 0x0000000186956B50-0x0000000186956DF0
		private bool GetMusicData(BgmType bgmType, out MusicData musicData) {
			musicData = default;
			return default;
		} // 0x0000000186956DF0-0x0000000186956F80
		private void PlaySoundTrack() {} // 0x0000000186956F80-0x00000001869572E0
		private void BuildTwirls() {} // 0x00000001869572E0-0x00000001869584A0
		private void OnDestroy() {} // 0x00000001869584A0-0x0000000186958530
		private GameObject SpawnTwirl(GameObject container, Vector2 pos, string spriteName, string textureName, float angle) => default; // 0x0000000186958530-0x0000000186958820
		private void StartRuneParticles() {} // 0x0000000186958820-0x0000000186959520
		private void StartInputParticles() {} // 0x0000000186959520-0x000000018695A130
		protected override void Update() {} // 0x000000018695A130-0x000000018695AB30
		private void Populate() {} // 0x000000018695AB30-0x000000018695B310
		private void ClearSpawned() {} // 0x000000018695B310-0x000000018695B520
		private void BuildKeyboard() {} // 0x000000018695B520-0x000000018695BDA0
		private void Unlock(SecretType t) {} // 0x000000018695BDA0-0x000000018695DE30
		private void PostUnlock() {} // 0x000000018695DE30-0x000000018695E020
		private void CheckUnlockedSecretAchievements(SecretType t) {} // 0x000000018695E020-0x000000018695E080
		[IteratorStateMachine(typeof(_WaitAndReselectSpells_d__90))]
		private IEnumerator WaitAndReselectSpells() => default; // 0x000000018695E080-0x000000018695E120
		private void everything() {} // 0x000000018695E120-0x000000018695E2E0
		private void everywhere() {} // 0x000000018695E2E0-0x000000018695E400
		[IteratorStateMachine(typeof(_WaitAndResetSliderValue_d__93))]
		private IEnumerator WaitAndResetSliderValue(float f) => default; // 0x000000018695E400-0x000000018695E4C0
		private void ShowTwirls() {} // 0x000000018695E4C0-0x000000018695E720
		private void HideTwirls() {} // 0x000000018695E720-0x000000018695E860
		private void SetNextCharacter(GameObject sender) {} // 0x000000018695E860-0x000000018695EC70
		private void SetNextCharacter(string s) {} // 0x000000018695EC70-0x000000018695F060
		[IteratorStateMachine(typeof(_DisableGravityWell_d__98))]
		private IEnumerator DisableGravityWell() => default; // 0x000000018695F060-0x000000018695F100
		private void PlayHitSound() {} // 0x000000018695F100-0x000000018695F230
		private void Backspace() {} // 0x000000018695F230-0x000000018695F500
		[IteratorStateMachine(typeof(_WaitForParticles_d__101))]
		private IEnumerator WaitForParticles() => default; // 0x000000018695F500-0x000000018695F5A0
		private void PlayInputParticles(Transform character) {} // 0x000000018695F5A0-0x000000018695FB60
		private RectTransform GetSpellContainer() => default; // 0x000000018695FB60-0x000000018695FBE0
		private void FormatSpell() {} // 0x000000018695FBE0-0x0000000186960170
		private void CheckSpells() {} // 0x0000000186960170-0x0000000186960480
		private void ClearSpell() {} // 0x0000000186960480-0x0000000186960730
		private void BuildSpellBase() {} // 0x0000000186960730-0x0000000186960BD0
		private void AddSpellCharacter() {} // 0x0000000186960BD0-0x0000000186960D00
		private bool CheckForCheat(SecretType t) => default; // 0x0000000186960D00-0x00000001869617A0
		private void Spin() {} // 0x00000001869617A0-0x0000000186961CA0
	}
}
