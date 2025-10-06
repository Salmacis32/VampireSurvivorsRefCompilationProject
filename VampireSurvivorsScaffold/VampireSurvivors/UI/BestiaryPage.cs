/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.App.Framework;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BestiaryPage : BaseUIPage // TypeDefIndex: 14706
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xE0
		[FormerlySerializedAs("_Name")]
		[SerializeField]
		private TextMeshProUGUI _KillCount; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _QuestionMarks; // 0xF0
		[SerializeField]
		private TextMeshProUGUI _Resistances; // 0xF8
		[SerializeField]
		private TextMeshProUGUI _Skills; // 0x100
		[SerializeField]
		private TextMeshProUGUI _FoundIn; // 0x108
		[SerializeField]
		private TextMeshProUGUI _HP; // 0x110
		[SerializeField]
		private TextMeshProUGUI _Power; // 0x118
		[SerializeField]
		private TextMeshProUGUI _Speed; // 0x120
		[SerializeField]
		private Image _EnvironmentBackground; // 0x128
		[SerializeField]
		private Image _EnemyNotFoundImage; // 0x130
		[SerializeField]
		private GameObject _EnemyIconPrefab; // 0x138
		[SerializeField]
		private GameObject _EnemyItemPrefab; // 0x140
		[SerializeField]
		private RectTransform _EnemyListContainer; // 0x148
		[SerializeField]
		private PositionInsideRectUI _EnemyContainer; // 0x150
		[SerializeField]
		private RectTransform _InfoContent; // 0x158
		[SerializeField]
		private FakeSliderHandleController _InfoSlider; // 0x160
		[SerializeField]
		private ScrollEnhancer _InfoScrollEnhancer; // 0x168
		[SerializeField]
		private Image _Frame; // 0x170
		[SerializeField]
		private Mask _InfoMask; // 0x178
		[SerializeField]
		private GameObject _UndeadStars1Prefab; // 0x180
		[SerializeField]
		private GameObject _UndeadStars2Prefab; // 0x188
		[SerializeField]
		private GameObject _UndeadStars3Prefab; // 0x190
		[SerializeField]
		private bool _Debug; // 0x198
		private DataManager _data; // 0x1A0
		private SignalBus _signalBus; // 0x1A8
		private PlayerOptions _playerOptions; // 0x1B0
		private BestiaryFactory _bestiaryFactory; // 0x1B8
		private AdventureManager _adventureManager; // 0x1C0
		private EnemyData _currentData; // 0x1C8
		private EnemyItemUI _currentItem; // 0x1D0
		private EnemyType _currentType; // 0x1D8
		private Dictionary<StageType, List<StageData>> _stages; // 0x1E0
		private Dictionary<EnemyType, List<EnemyData>> _enemies; // 0x1E8
		private List<GameObject> _spawnedList; // 0x1F0
		private List<GameObject> _spawnedEnemies; // 0x1F8
		private List<List<Vector2>> _positions1; // 0x200
		private List<List<Vector2>> _positions2; // 0x208
		private List<List<Vector2>> _positions3; // 0x210
		private List<List<Vector2>> _positions4; // 0x218
		private List<List<Vector2>> _positions5; // 0x220
		private List<List<Vector2>> _positions6; // 0x228
		private List<List<Vector2>> _positions7; // 0x230
		private List<List<Vector2>> _positions8; // 0x238
		private List<List<Vector2>> _positions9; // 0x240
		private List<List<Vector2>> _positions10; // 0x248
		private List<List<Vector2>> _positions11; // 0x250
		private List<List<Vector2>> _positions12; // 0x258
		private List<List<Vector2>> _positions13; // 0x260
		private List<List<Vector2>> _positions14; // 0x268
		private List<List<Vector2>> _positions15; // 0x270
		private List<List<Vector2>> _positions16; // 0x278
		private List<List<List<Vector2>>> _allPositions; // 0x280
		private const string BestiaryTweenId = "BESTIARY_TWEENS"; // Metadata: 0x019771DB
		private BgmType _previousBGM; // 0x288
		private BgmModType _previousBGMMod; // 0x28C
		private VampireSurvivors.Framework.TimerSystem.Timer _redBlueTimer; // 0x290
	
		// Nested types
		private class EnemyAnimDisplayData // TypeDefIndex: 14702
		{
			// Fields
			public int IdleFrameCount; // 0x10
			public string TextureName; // 0x18
			public float? Scale; // 0x20
			public uint? Tint; // 0x28
			public float Alpha; // 0x30
			public EnemyType Type; // 0x34
			public string FrameName; // 0x38
	
			// Constructors
			public EnemyAnimDisplayData() {} // Dummy constructor
			public EnemyAnimDisplayData(EnemyData data, EnemyType type, string frameName) {} // 0x00000001867AB230-0x00000001867AB340
		}
	
		// Constructors
		public BestiaryPage() {} // 0x00000001867AB020-0x00000001867AB230
	
		// Methods
		[Inject]
		private void Construct(DataManager data, SignalBus signal, PlayerOptions playerOptions, BestiaryFactory bestiaryFactory, AdventureManager adventureManager) {} // 0x000000018679E030-0x000000018679E210
		protected override void Awake() {} // 0x000000018679E210-0x000000018679E250
		public void SetInfoPanel(EnemyType t, EnemyData dat, EnemyItemUI item) {} // 0x000000018679E250-0x000000018679F120
		[IteratorStateMachine(typeof(_WaitAndGenerateSliderNavigation_d__60))]
		private IEnumerator WaitAndGenerateSliderNavigation() => default; // 0x000000018679F120-0x000000018679F1C0
		protected override void OnShowStart(GameObject g) {} // 0x000000018679F1C0-0x000000018679F440
		protected override void OnHideStart(GameObject g) {} // 0x000000018679F440-0x000000018679F550
		private void NavigationWrap() {} // 0x000000018679F550-0x000000018679F820
		private bool GetMusicData(BgmType bgmType, out MusicData musicData) {
			musicData = default;
			return default;
		} // 0x000000018679F820-0x000000018679F9B0
		private void PlaySoundTrack() {} // 0x000000018679F9B0-0x000000018679FD10
		private void Populate() {} // 0x000000018679FD10-0x00000001867A0E50
		private void SetDescription(EnemyData dat, EnemyType type) {} // 0x00000001867A0E50-0x00000001867A0F70
		private void SetFoundIn(EnemyData dat) {} // 0x00000001867A0F70-0x00000001867A14B0
		private void SetStats(EnemyData ed, EnemyType type) {} // 0x00000001867A14B0-0x00000001867A2310
		private void SetResistances(EnemyData dat, EnemyType type) {} // 0x00000001867A2310-0x00000001867A2700
		private void SetSkills(EnemyData dat, EnemyType type) {} // 0x00000001867A2700-0x00000001867A2C80
		private void SetBackground(EnemyData dat, EnemyType type) {} // 0x00000001867A2C80-0x00000001867A31D0
		private static List<Sprite> GetAnimationForEnemy(EnemyData d, int index) => default; // 0x00000001867A31D0-0x00000001867A3320
		private void InitPositions() {} // 0x00000001867A3320-0x00000001867A4A60
		private void ClearExistingEnemyAnims() {} // 0x00000001867A4A60-0x00000001867A4D90
		private void SpawnEnemyAnimations(EnemyData enemyData, EnemyType enemyType) {} // 0x00000001867A4D90-0x00000001867A59A0
		private List<EnemyAnimDisplayData> BuildEnemyDisplayList(EnemyData enemyData, EnemyType enemyType) => default; // 0x00000001867A59A0-0x00000001867A5F80
		private void CreateEnemyAnimation(EnemyAnimDisplayData cData, Vector2 randomPosition, string prefixOverride = "_i" /* Metadata: 0x019771D5 */, bool flipX = false /* Metadata: 0x019771D8 */) {} // 0x00000001867A5F80-0x00000001867A6AC0
		private static void UpdateEnemyDisplay(EnemyAnimDisplayData cData, Image enemyImage, GameObject enemyObject) {} // 0x00000001867A6AC0-0x00000001867A6E20
		private void ApplyAnimationToEnemy(GameObject enemyObject, List<Sprite> sprites, EnemyData enemyData) {} // 0x00000001867A6E20-0x00000001867A70C0
		private void AddEnemyObjectToHierarchy(GameObject enemyObject, List<Vector2> variants, int positionIndex, EnemyType enemyType, bool ignoreAngle = false /* Metadata: 0x019771D9 */) {} // 0x00000001867A70C0-0x00000001867A7460
		private GameObject CreateFactoryPrefab(List<Vector2> variants, int positionIndex, EnemyType enemyType, bool ignoreAngle = false /* Metadata: 0x019771DA */) => default; // 0x00000001867A7460-0x00000001867A7560
		private void CreateDirecter(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A7560-0x00000001867A7600
		private void CreateTrinacria(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A7600-0x00000001867A76F0
		private void CreateSketamari(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A76F0-0x00000001867A7970
		private void CreateCrabbino(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A7970-0x00000001867A7F00
		private void CreateMask(EnemyType enemyType, EnemyType maskType, EnemyData data, List<Vector2> variants, int positionIndex) {} // 0x00000001867A7F00-0x00000001867A8770
		private void CreateAlias(EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A8770-0x00000001867A87D0
		private void CreateGASHADOKURO(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A87D0-0x00000001867A8C40
		private void CreateOROCHIMARIO(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A8C40-0x00000001867A90C0
		private void CreateCosmicEgg(List<Vector2> variants, int positionIndex, EnemyType enemyType) {} // 0x00000001867A90C0-0x00000001867A91B0
		private void CreateRedBlue(EnemyData enemyData, EnemyType enemyType) {} // 0x00000001867A91B0-0x00000001867A9810
		private void CreateUndeadStars(EnemyData enemyData, EnemyType enemyType) {} // 0x00000001867A9810-0x00000001867A9CD0
		private void CreateBigFuzz(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A9CD0-0x00000001867A9EF0
		private void CreateTPDeath(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A9EF0-0x00000001867A9FE0
		private void CreateDoppelganger(List<Vector2> variants, int positionIndex, EnemyType enemyType, EnemyData enemyData) {} // 0x00000001867A9FE0-0x00000001867AB020
	}
}
