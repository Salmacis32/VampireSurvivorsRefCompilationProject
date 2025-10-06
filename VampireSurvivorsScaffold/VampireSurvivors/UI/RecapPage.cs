/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Framework.System;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Spells;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class RecapPage : BaseUIPage // TypeDefIndex: 14936
	{
		// Fields
		[FormerlySerializedAs("MapTitle")]
		[SerializeField]
		private TextMeshProUGUI _MapTitle; // 0xE0
		[FormerlySerializedAs("CharacterName")]
		[SerializeField]
		private TextMeshProUGUI _CharacterName; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _EggCount; // 0xF0
		[FormerlySerializedAs("Survived")]
		[SerializeField]
		private PropertyUI _Survived; // 0xF8
		[FormerlySerializedAs("Gold")]
		[SerializeField]
		private PropertyUI _Gold; // 0x100
		[FormerlySerializedAs("Levels")]
		[SerializeField]
		private PropertyUI _Levels; // 0x108
		[FormerlySerializedAs("Enemies")]
		[SerializeField]
		private PropertyUI _Enemies; // 0x110
		[FormerlySerializedAs("WeaponRecapContainer")]
		[SerializeField]
		private RectTransform _WeaponRecapContainer; // 0x118
		[FormerlySerializedAs("WeaponIcons")]
		[SerializeField]
		private RectTransform _WeaponIcons; // 0x120
		[FormerlySerializedAs("StatIcons")]
		[SerializeField]
		private RectTransform _StatIcons; // 0x128
		[FormerlySerializedAs("LootIcons")]
		[SerializeField]
		private RectTransform _LootIcons; // 0x130
		[FormerlySerializedAs("WeaponRecapPrefab")]
		[SerializeField]
		private GameObject _WeaponRecapPrefab; // 0x138
		[FormerlySerializedAs("AchievementsPanel")]
		[SerializeField]
		private GameObject _AchievementsPanel; // 0x140
		[FormerlySerializedAs("QuantityIconPrefab")]
		[SerializeField]
		private IconQuantityUI _QuantityIconPrefab; // 0x148
		[FormerlySerializedAs("CharacterIcon")]
		[SerializeField]
		private Image _CharacterIcon; // 0x150
		[FormerlySerializedAs("AchievementPopup")]
		[SerializeField]
		private AchievementPopup _AchievementPopup; // 0x158
		[SerializeField]
		private Selectable _DoneButton; // 0x160
		[SerializeField]
		private GameObject _HideAchievementsButton; // 0x168
		[SerializeField]
		private GameObject _AcceptAchievementsButton; // 0x170
		[SerializeField]
		private TickBoxUI _AcceptAchievementsTickBoxUI; // 0x178
		[SerializeField]
		private GameObject _DestructablePrefab; // 0x180
		[SerializeField]
		private GameObject _ArcanaPrefab; // 0x188
		[SerializeField]
		private RectTransform _ArcanaContainer; // 0x190
		[SerializeField]
		private RectTransform _TweenOrigin; // 0x198
		[SerializeField]
		private GameObject _UnlockBadge; // 0x1A0
		[SerializeField]
		private TextMeshProUGUI _UnlockCountText; // 0x1A8
		[SerializeField]
		private UnityEngine.UI.Button _WatchAdForExtraGoldButton; // 0x1B0
		[SerializeField]
		private ParticleEmitterManager _CoinEmitter; // 0x1B8
		[SerializeField]
		private GameObject _PreviousCharacterButton; // 0x1C0
		[SerializeField]
		private GameObject _NextCharacterButton; // 0x1C8
		[SerializeField]
		private UnityEngine.UI.Button _openLogsButton; // 0x1D0
		[SerializeField]
		private FakeSliderHandleController _sliderHandle; // 0x1D8
		private SignalBus _signalBus; // 0x1E0
		private PlayerOptions _playerOptions; // 0x1E8
		private AchievementManager _achievements; // 0x1F0
		private DataManager _dataManager; // 0x1F8
		private PlayerStats _playerStats; // 0x200
		private ArcanaManager _arcanaManager; // 0x208
		private UnityServicesManager _unityServicesManager; // 0x210
		private AdventureManager _adventureManager; // 0x218
		private SpellsManager _spellsManager; // 0x220
		private AchievementManager _achievementManager; // 0x228
		private ParticleSystem _particles; // 0x230
		private StringBuilder _timeFormatStringBuilder; // 0x238
		private RectTransform _rectTransform; // 0x240
		private List<Tween> _activeTweens; // 0x248
		private VampireSurvivors.Objects.Characters.CharacterController _currentCharacter; // 0x250
		private int _currentCharacterIndex; // 0x258
		private List<GameObject> _spawned; // 0x260
		private Dictionary<VampireSurvivors.Data.CharacterType, GameObject> _characterWeapons; // 0x268
		private bool _isFirstShow; // 0x270
		private int _selectedCharacterIndex; // 0x274
		private Color hiddenWeaponNameColor; // 0x278
	
		// Nested types
		public struct StatsDisplay // TypeDefIndex: 14930
		{
			// Fields
			public string Name; // 0x00
			public int Level; // 0x08
			public string WeaponFrameName; // 0x10
			public string WeaponTextureName; // 0x18
			public float InflictedDamage; // 0x20
			public float Lifetime; // 0x24
			public float Dps; // 0x28
			public bool IsBestDps; // 0x2C
			public bool IsBestRaw; // 0x2D
			public VampireSurvivors.Data.CharacterType Owner; // 0x30
			public Color NameColor; // 0x34
		}
	
		private class CustomPickupData // TypeDefIndex: 14931
		{
			// Fields
			public VampireSurvivors.Data.ItemType? ItemType; // 0x10
			public int Amount; // 0x18
			public string FrameName; // 0x20
			public string TextureName; // 0x28
	
			// Constructors
			public CustomPickupData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public RecapPage() {} // 0x000000018693D380-0x000000018693D5C0
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, AchievementManager achievement, PlayerOptions playerOptions, DataManager dataManager, PlayerStats playerStats, ArcanaManager arcanaManager, UnityServicesManager unityServicesManager, AdventureManager adventureManager, SpellsManager spellsManager, AchievementManager achievementManager) {} // 0x0000000186932CA0-0x0000000186933060
		public void HideAchievements() {} // 0x0000000186933060-0x0000000186933360
		public void AcceptAchievementsToggle(bool _ = true /* Metadata: 0x01977267 */) {} // 0x0000000186933360-0x0000000186933420
		public void ReturnToLanding() {} // 0x0000000186933420-0x00000001869337E0
		public void WatchAdForExtraGold() {} // 0x00000001869337E0-0x0000000186933810
		public void NextCharacter() {} // 0x0000000186933810-0x0000000186933960
		public void PreviousCharacter() {} // 0x0000000186933960-0x0000000186933AB0
		private void RefreshCharacterSpecificStats() {} // 0x0000000186933AB0-0x0000000186934190
		protected override void OnShowStart(GameObject g) {} // 0x0000000186934190-0x0000000186936560
		[IteratorStateMachine(typeof(_SelectDoneDelayed_d__62))]
		private IEnumerator SelectDoneDelayed() => default; // 0x0000000186936560-0x0000000186936600
		private void EditorShowCompletionPopup() {} // 0x0000000186936600-0x00000001869366A0
		private void OnDestroy() {} // 0x00000001869366A0-0x0000000186936810
		private void SetInfo() {} // 0x0000000186936810-0x00000001869368F0
		private void DoAnimations() {} // 0x00000001869368F0-0x00000001869369B0
		private void SetHeader() {} // 0x00000001869369B0-0x0000000186936D40
		private void SetCharacter() {} // 0x0000000186936D40-0x00000001869371D0
		private void SetRunStats() {} // 0x00000001869371D0-0x00000001869380B0
		private void AddWeapons() {} // 0x00000001869380B0-0x0000000186939E30
		private static void CalculateBestStats(List<StatsDisplay> allStats) {} // 0x0000000186939E30-0x000000018693A150
		private StatsDisplay GenerateStatsDisplay(Weapon weapon) => default; // 0x000000018693A150-0x000000018693A510
		public void AddPowerUps() {} // 0x000000018693A510-0x000000018693ACD0
		public void AddCollectedItems() {} // 0x000000018693ACD0-0x000000018693BE10
		private void SpawnDestructible(int index, float duration, string frameName, string textureName) {} // 0x000000018693BE10-0x000000018693C090
		private void AddArcanas() {} // 0x000000018693C090-0x000000018693C660
		private void GenerateWeaponRecap(StatsDisplay statsDisplay) {} // 0x000000018693C660-0x000000018693C8A0
		private void QueueAchievements(List<AchievementData> achievementsUnlocked) {} // 0x000000018693C8A0-0x000000018693CB40
		private bool CanShowPostRunGoldAdRewardButton() => default; // 0x000000018693CB40-0x000000018693CBB0
		private void RewardExtraGoldFromAd() {} // 0x000000018693CBB0-0x000000018693D0A0
		private void PlayParticles() {} // 0x000000018693D0A0-0x000000018693D1B0
		public void OpenLogs() {} // 0x000000018693D1B0-0x000000018693D380
	}
}
