/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Data.Adventures;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.App.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.UI
{
	public class SelectAdventuresPage : BaseUIPage // TypeDefIndex: 18638
	{
		// Fields
		[SerializeField]
		private GameObject _AdventureItemPrefab; // 0xE0
		[SerializeField]
		private RectTransform _AdventureItemContainer; // 0xE8
		[SerializeField]
		private AdventureInfoPanel _InfoPanel; // 0xF0
		[SerializeField]
		private UnityEngine.UI.Button _ConfirmButton; // 0xF8
		[SerializeField]
		private GameObject _CoinsUI; // 0x100
		[SerializeField]
		private GameObject _AdventureStarsCurrencyUI; // 0x108
		[SerializeField]
		private PixelateEffect _pixelEffect; // 0x110
		[SerializeField]
		private MainMenuBackgroundManager _MainMenuBackgroundManager; // 0x118
		[SerializeField]
		private bool DoPixelEffect; // 0x120
		[SerializeField]
		private AscensionPanel _AscensionPanel; // 0x128
		[SerializeField]
		private Image _PortraitBreaker; // 0x130
		[SerializeField]
		private GameObject _PortraitAscensionGroup; // 0x138
		[SerializeField]
		private RectTransform _CustomBackgroundHolderOnMainMenu; // 0x140
		[SerializeField]
		private MainMenuPage _MainMenuPage; // 0x148
		[SerializeField]
		private AchievementPopup _AchievementPopup; // 0x150
		private AdventureManager _adventureManager; // 0x158
		private PlayerOptions _playerOptions; // 0x160
		private DataManager _dataManager; // 0x168
		private MainMenuBackgroundFactory _backgroundFactory; // 0x170
		private AdventureProgressManager _adventureProgressManager; // 0x178
		private AchievementManager _achievementManager; // 0x180
		private List<AdventureItemUI> _spawned; // 0x188
		private AdventureItemUI _selected; // 0x190
		private AdventureItemUI _ascending; // 0x198
		private TutorialPopup _spawnedTutorialPopup; // 0x1A0
	
		// Properties
		private RewiredStandaloneInputModule InputModule { get => default; } // 0x0000000186803100-0x0000000186803250 
		public AdventureManager AdventureManager { get => default; } // 0x0000000184755AB0-0x0000000184755AC0 
		public DataManager DataManager { get => default; } // 0x00000001829176E0-0x00000001829176F0 
		public PlayerOptions PlayerOptions { get => default; } // 0x00000001827668E0-0x00000001827668F0 
	
		// Constructors
		public SelectAdventuresPage() {} // 0x00000001868071A0-0x0000000186807290
	
		// Methods
		[Inject]
		private void Construct(AdventureManager adventureManager, PlayerOptions playerOptions, DataManager data, MainMenuBackgroundFactory backgroundFactory, AdventureProgressManager adventureProgressManager, AchievementManager achievementManager) {} // 0x0000000186803250-0x0000000186803490
		protected override void Awake() {} // 0x00000001867BF7D0-0x00000001867BF7E0
		public void SelectAdventure(AdventureItemUI item) {} // 0x0000000186803490-0x0000000186803AC0
		public void SetAscendingAdventureItem(AdventureItemUI item) {} // 0x0000000186747030-0x0000000186747090
		private void OnAscended(bool result) {} // 0x0000000186803AC0-0x0000000186803CB0
		public GameObject GetBackground(AdventureType adventureType) => default; // 0x0000000186803CB0-0x0000000186803CE0
		public void ConfirmAdventure() {} // 0x0000000186803CE0-0x0000000186803F60
		[IteratorStateMachine(typeof(_Animate_d__40))]
		private IEnumerator Animate() => default; // 0x0000000186803F60-0x0000000186804000
		[IteratorStateMachine(typeof(_MoveBackgroundIntoPlaceInANiceFancyWay_d__41))]
		private IEnumerator MoveBackgroundIntoPlaceInANiceFancyWay(Transform bg) => default; // 0x0000000186804000-0x0000000186804100
		protected override void OnShowStart(GameObject g) {} // 0x0000000186804100-0x0000000186804B40
		private void QueueAchievements(List<AchievementData> achievementsUnlocked) {} // 0x0000000186804B40-0x0000000186804C00
		private void ShowTutorialPopup() {} // 0x0000000186804C00-0x0000000186804D60
		private void OnTutorialFinished() {} // 0x0000000186804D60-0x0000000186804E30
		protected override void OnHideStart(GameObject g) {} // 0x0000000186804E30-0x0000000186804FF0
		private void Populate() {} // 0x0000000186804FF0-0x00000001868057F0
		protected override void Update() {} // 0x00000001868057F0-0x0000000186805920
		private void GenerateNavigation() {} // 0x0000000186805920-0x0000000186806310
		protected override void OnHideFinish(GameObject g) {} // 0x0000000186806310-0x00000001868064B0
		private void ClearItems() {} // 0x00000001868064B0-0x0000000186806770
		protected override void OnEnterPressed() {} // 0x0000000186806770-0x0000000186806AD0
		public void HandleDLCPerPlatform() {} // 0x0000000186806AD0-0x0000000186806B70
		private void UpdateCompletionPanelInfo(AdventureType adventureType) {} // 0x0000000186806B70-0x0000000186806EB0
		private void UpdateAdventureStatesBasedOnHideToggle() {} // 0x0000000186806EB0-0x00000001868071A0
	}
}
