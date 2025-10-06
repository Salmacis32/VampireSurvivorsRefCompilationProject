/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AchievementsPage : BaseUIPage // TypeDefIndex: 14646
	{
		// Fields
		[SerializeField]
		private GameObject _AchievementPrefab; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _Description; // 0xE8
		[SerializeField]
		private TextMeshProUGUI _UnlockDescription; // 0xF0
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xF8
		[SerializeField]
		private TextMeshProUGUI _ObtainedText; // 0x100
		[SerializeField]
		private Image _InfoBackground; // 0x108
		[SerializeField]
		private Localize _DescriptionText; // 0x110
		[SerializeField]
		private Image _Icon; // 0x118
		[SerializeField]
		private Image _IconBg; // 0x120
		[SerializeField]
		private Image _MoneyIcon; // 0x128
		[SerializeField]
		private TickBoxUI _HideCompleted; // 0x130
		[SerializeField]
		private GameObject _InfoPanel; // 0x138
		private PlayerOptions _playerOptions; // 0x140
		private DataManager _dataManager; // 0x148
		private AchievementManager _achievementManager; // 0x150
		private AdventureManager _adventureManager; // 0x158
		private List<GameObject> _spawned; // 0x160
		private List<AchievementType> _baseGameUnlocked; // 0x168
	
		// Constructors
		public AchievementsPage() {} // 0x000000018730FC00-0x000000018730FDA0
	
		// Methods
		[Inject]
		private void Construct(AchievementManager achievements, PlayerOptions playerOptions, DataManager dataManager, AdventureManager adventureManager) {} // 0x000000018730C230-0x000000018730C3C0
		protected override void Awake() {} // 0x000000018730C3C0-0x000000018730C3F0
		public void SelectAdventureProgress(AdventureAchievementType type, AchievementData achievementData) {} // 0x000000018730C3F0-0x000000018730C460
		public void SelectAchievement(AchievementType type, AchievementData bad) {} // 0x000000018730C460-0x000000018730C4D0
		public void Reset() {} // 0x000000018730C4D0-0x000000018730C6E0
		public void ToggleCompleted() {} // 0x000000018730C6E0-0x000000018730C760
		protected override void OnShowStart(GameObject g) {} // 0x000000018730C760-0x000000018730C850
		protected override void OnHideStart(GameObject g) {} // 0x0000000186927040-0x0000000186927050
		private void Populate() {} // 0x000000018730C850-0x000000018730CE30
		private void UpdateInfoDisplay(AchievementData bad) {} // 0x000000018730CE30-0x000000018730E670
		private void PopulateAdventureProgress() {} // 0x000000018730E670-0x000000018730EBA0
		private void SpawnAdventureProgressUnlock(AdventureAchievementType type, AchievementData data) {} // 0x000000018730EBA0-0x000000018730EE40
		private void PopulateBaseGameAchievements() {} // 0x000000018730EE40-0x000000018730F6A0
		private int GetValidUnlockedAchievementCount() => default; // 0x000000018730F6A0-0x000000018730F8F0
		[IteratorStateMachine(typeof(_WaitAndReformat_d__32))]
		private IEnumerator WaitAndReformat() => default; // 0x000000018730F8F0-0x000000018730F990
		private void SpawnAchievement(AchievementType type, AchievementData data) {} // 0x000000018730F990-0x000000018730FC00
	}
}
