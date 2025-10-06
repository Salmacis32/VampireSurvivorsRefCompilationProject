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
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class OptionsController : MonoBehaviour // TypeDefIndex: 14902
	{
		// Fields
		[SerializeField]
		private List<OptionsTabType> _OptionsConfig; // 0x20
		[SerializeField]
		private Selectable OnUp; // 0x28
		[SerializeField]
		private Selectable OnDown; // 0x30
		[SerializeField]
		private Selectable Quit; // 0x38
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x40
		[SerializeField]
		private RectTransform _TabContainer; // 0x48
		[SerializeField]
		private RectTransform _DisplayPanel; // 0x50
		[SerializeField]
		private GameObject _TabPrefab; // 0x58
		[SerializeField]
		private RectTransform _Content; // 0x60
		[SerializeField]
		private GameObject _TickboxPrefab; // 0x68
		[SerializeField]
		private GameObject _SliderPrefab; // 0x70
		[SerializeField]
		private GameObject _ButtonPrefab; // 0x78
		[SerializeField]
		private GameObject _MultipleChoicePrefab; // 0x80
		[SerializeField]
		private GameObject _DropdownPrefab; // 0x88
		[SerializeField]
		private GameObject _DropdownImagesPrefab; // 0x90
		[SerializeField]
		private GameObject _InputPrefab; // 0x98
		[SerializeField]
		private GameObject _LabelPrefab; // 0xA0
		[SerializeField]
		private CoopConfig _CoopConfig; // 0xA8
		private List<IUIObject> _spawnedUnselectables; // 0xB0
		private List<ISelectableUI> _spawnedElements; // 0xB8
		private List<GameObject> _spawnedTabs; // 0xC0
		private ScrollEnhancer _scroller; // 0xC8
		private SignalBus _signalBus; // 0xD0
		private PlayerOptions _playerOptions; // 0xD8
		private AdventureManager _adventureManager; // 0xE0
		private CheatsController _cheatsController; // 0xE8
		private Resolution? _selectedResolution; // 0xF0
		private List<string> _resolutionStrings; // 0x108
		private int _selectedRefreshRate; // 0x110
		private FullScreenMode _selectedWindowMode; // 0x114
		private bool _vSyncEnabled; // 0x118
		private int _selectedFrameRate; // 0x11C
		private AchievementManager _achievementManager; // 0x120
		private MultiplayerManager _multiplayer; // 0x128
		private LabeledInputUI _twitchChannelNameInput; // 0x130
		private LabeledButtonUI _twitchConnectButton; // 0x138
		private LabeledButtonUI _twitchDisconnectButton; // 0x140
		private OptionsTabType? _currentTabType; // 0x148
		private CustomDropDown _screenResolutionDropdown; // 0x150
		private CustomDropDown _refreshRateDropdown; // 0x158
		private SliderUI _frameRateSlider; // 0x160
		private TickBoxUI _vSyncTickBox; // 0x168
		private LabeledButtonUI _applyGraphicsButton; // 0x170
		private List<Resolution> _resolutions; // 0x178
		private List<Resolution> _currentRefreshRateResolutions; // 0x180
		private ScreenOrientation _currentScreenOrientation; // 0x188
		private int _deleteSaveClicks; // 0x18C
		private int _loadSavegameClicks; // 0x190
		private bool _shouldDeleteAdventureData; // 0x194
		private static uint[] optionColours; // 0x00
	
		// Nested types
		public enum OptionsTabType // TypeDefIndex: 14896
		{
			QUICKACCESS = 0,
			DISPLAY = 1,
			SOUND = 2,
			GAMEPLAY = 3,
			USER = 4,
			ABOUT = 5,
			INGAME = 6,
			CHEATS = 7,
			MULTIPLAYER = 8
		}
	
		// Constructors
		public OptionsController() {} // 0x0000000186925000-0x0000000186925470
		static OptionsController() {} // 0x0000000186925470-0x0000000186925550
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, PlayerOptions player, CheatsController cheats, AchievementManager achievementManager, MultiplayerManager multi, AdventureManager adventureManager) {} // 0x0000000186915CE0-0x0000000186915F20
		public void Initialize() {} // 0x0000000186915F20-0x0000000186916A90
		private void AddTabs() {} // 0x0000000186916A90-0x0000000186917110
		private Sprite GetTabSprite(OptionsTabType t) => default; // 0x0000000186917110-0x0000000186917220
		private string GetTabName(OptionsTabType t) => default; // 0x0000000186917220-0x00000001869173B0
		private void SelectTab(OptionsTabType type) {} // 0x00000001869173B0-0x00000001869177B0
		private void ClearPage() {} // 0x00000001869177B0-0x0000000186917E10
		public GameObject GetFirstTab() => default; // 0x0000000186917E10-0x0000000186917EA0
		public GameObject GetFirstElement() => default; // 0x0000000186917EA0-0x0000000186917F50
		public Selectable GetFirstSelectable() => default; // 0x0000000186917F50-0x0000000186917FF0
		public Selectable GetLastSelectable() => default; // 0x0000000186917FF0-0x00000001869180A0
		public void ClearAll() {} // 0x00000001869180A0-0x00000001869187C0
		public void RefreshTab(OptionsTabType type) {} // 0x00000001869187C0-0x0000000186918810
		private void BuildPage(OptionsTabType type) {} // 0x0000000186918810-0x0000000186918AB0
		private void GenerateNavigation() {} // 0x0000000186918AB0-0x0000000186919830
		[IteratorStateMachine(typeof(_WaitAndFormatWidth_d__65))]
		private IEnumerator WaitAndFormatWidth() => default; // 0x0000000186919830-0x00000001869198D0
		public void SetUpNavigation(Selectable sel) {} // 0x0000000180B1D4C0-0x0000000180B1D520
		public void SetDownNavigation(Selectable sel) {} // 0x0000000180B1D520-0x0000000180B1D580
		public void SetQuit(Selectable sel) {} // 0x0000000181953C20-0x0000000181953C80
		private void AddFlashingVfxTickBox() {} // 0x00000001869198D0-0x00000001869199A0
		private void BuildQuickAccessPage() {} // 0x00000001869199A0-0x0000000186919C20
		private void BuildIngamePage() {} // 0x0000000186919C20-0x000000018691A020
		private void BuildDisplayPage() {} // 0x000000018691A020-0x000000018691A360
		private void BuildSoundPage() {} // 0x000000018691A360-0x000000018691A510
		private void BuildGameplayPage() {} // 0x000000018691A510-0x000000018691A7E0
		private void BuildUserPage() {} // 0x000000018691A7E0-0x000000018691ACE0
		private void BuildAboutPage() {} // 0x0000000180B15170-0x0000000180B15180
		private void BuildCheatsPage() {} // 0x000000018691ACE0-0x000000018691AFA0
		private List<Color> ColourDropdownValues() => default; // 0x000000018691AFA0-0x000000018691B180
		private void BuildMultiplayerPage() {} // 0x000000018691B180-0x000000018691BCE0
		private void AddLanguageButton() {} // 0x000000018691BCE0-0x000000018691BEC0
		private void AddVisuallyInvertStages() {} // 0x000000018691BEC0-0x000000018691C040
		private void AddDisableMovingBackground() {} // 0x000000018691C040-0x000000018691C390
		private void AddFullScreen() {} // 0x000000018691C390-0x000000018691C460
		private void AddJoystickTypes() {} // 0x000000018691C460-0x000000018691C710
		private void AddOrientations() {} // 0x000000018691C710-0x000000018691CA90
		private int GetResolutionIndex(int screenWidth, int screenHeight) => default; // 0x000000018691CA90-0x000000018691CDF0
		private void AddResolutions() {} // 0x000000018691CDF0-0x000000018691D4B0
		private void HandleRefreshRateDropdown() {} // 0x000000018691D4B0-0x000000018691DC60
		private void AddFrameRateSlider() {} // 0x000000018691DC60-0x000000018691DD80
		private void AddBorderTypes() {} // 0x000000018691DD80-0x000000018691E340
		private void AddWindowTypes() {} // 0x000000018691E340-0x000000018691E650
		private void AddVisibleJoysticks() {} // 0x000000018691E650-0x000000018691E720
		private void AddSoundEffectTypes() {} // 0x000000018691E720-0x000000018691E9E0
		public LabeledInputUI AddLabeledInput(string labelText, string defaultValue = "" /* Metadata: 0x0197723F */, string placeholder = "" /* Metadata: 0x01977240 */, bool textIsLocalizationTerm = true /* Metadata: 0x01977241 */) => default; // 0x000000018691E9E0-0x000000018691ED60
		private SliderUI AddSlider(string text, float defaultValue, Action<float> valueChangeCallback, bool textIsLocalizationTerm = true /* Metadata: 0x01977242 */, float minValue = 0f /* Metadata: 0x01977243 */, float maxValue = 1f /* Metadata: 0x01977247 */) => default; // 0x000000018691ED60-0x000000018691F1C0
		private SliderUI AddSliderInteger(string text, int defaultValue, Action<int> valueChangeCallback, bool textIsLocalizationTerm = true /* Metadata: 0x0197724B */, int minValue = 0 /* Metadata: 0x0197724C */, int maxValue = 100 /* Metadata: 0x0197724D */) => default; // 0x000000018691F1C0-0x000000018691F6B0
		private CustomDropDown AddDropDown(string text, List<string> options, int selectedIndex, Action<int> callbackWithNewSelectedIndex, int howManyOptionsToShowAtOnce = 4 /* Metadata: 0x0197724F */, bool textIsLocalizationTerm = true /* Metadata: 0x01977250 */) => default; // 0x000000018691F6B0-0x000000018691FC50
		private void RegenerateDropdownOptions(CustomDropDown customDropDown, List<string> options, int selectedIndex, bool textIsLocalizationTerm = true /* Metadata: 0x01977251 */) {} // 0x000000018691FC50-0x000000018691FF10
		private void AddColourDropDown(string text, List<Color> options, int selectedIndex, Action<int> callbackWithNewSelectedIndex, int howManyOptionsToShowAtOnce = 4 /* Metadata: 0x01977252 */, bool textIsLocalizationTerm = true /* Metadata: 0x01977253 */) {} // 0x000000018691FF10-0x0000000186920470
		private TickBoxUI AddTickBox(string text, bool defaultValue, Action<bool> valueChangeCallback, bool textIsLocalizationTerm = true /* Metadata: 0x01977254 */) => default; // 0x0000000186920470-0x0000000186920830
		public LabeledButtonUI AddLabeledButton(string labelText, string buttonText, Action callback, bool textIsLocalizationTerm = true /* Metadata: 0x01977255 */) => default; // 0x0000000186920830-0x0000000186920BD0
		public void AddLabel(string labelText) {} // 0x0000000186920BD0-0x0000000186920EF0
		private void AddMultipleChoice(string labelText, List<string> buttonLabels, List<Action> callbacks, int selectedIndex, bool textIsLocalizedTerm = true /* Metadata: 0x01977256 */) {} // 0x0000000186920EF0-0x0000000186921460
		private string Translate(string term) => default; // 0x0000000186921460-0x00000001869214E0
		public void ToggleVisualInvert(bool b) {} // 0x00000001869214E0-0x0000000186921520
		public void SetJoystickDefault() {} // 0x0000000186921520-0x0000000186921560
		public void SetJoystickLegacy() {} // 0x0000000186921560-0x00000001869215A0
		private void SetOrientation(int index) {} // 0x00000001869215A0-0x00000001869215E0
		public void ApplySelectedOrientation() {} // 0x00000001869215E0-0x0000000186921750
		private void SetMusic(float f) {} // 0x0000000186921750-0x0000000186921870
		private void SetSounds(float f) {} // 0x0000000186921870-0x0000000186921990
		private void SetClassicMusic() {} // 0x0000000186921990-0x00000001869219C0
		private void SetBlastProcessedMusic() {} // 0x00000001869219C0-0x00000001869219F0
		public void FlashingVFX(bool b) {} // 0x00000001869219F0-0x0000000186921B10
		public void DisableBlood(bool b) {} // 0x0000000186921B10-0x0000000186921B50
		private void ScreenShake(bool value) {} // 0x0000000186921B50-0x0000000186921B90
		private void PixelFont(bool value) {} // 0x0000000186921B90-0x0000000186921C90
		private void DisplayDefangedEnemies(bool value) {} // 0x0000000186921C90-0x0000000186921CD0
		private void StageLighting(bool value) {} // 0x0000000186921CD0-0x0000000186921D50
		public void VisibleJoystick(bool b) {} // 0x0000000186921D50-0x0000000186921E70
		public void DamageNumbers(bool b) {} // 0x0000000186921E70-0x0000000186921F90
		public void GlimmerCarousel(bool b) {} // 0x0000000186921F90-0x00000001869220B0
		public void SetFullscreen(bool b) {} // 0x00000001869220B0-0x00000001869221D0
		public void ToggleMovingBackground(bool b) {} // 0x00000001869221D0-0x00000001869222F0
		public void ToggleStageProgression(bool b) {} // 0x00000001869222F0-0x0000000186922410
		public void ToggleControllerVibration(bool value) {} // 0x0000000186922410-0x0000000186922450
		public void ToggleAssignControllerToPlayer1(bool value) {} // 0x0000000186922450-0x00000001869224C0
		public void TogglePopupsShouldFollowPriority(bool value) {} // 0x00000001869224C0-0x0000000186922500
		public void ToggleShowPlayerIndicators(bool value) {} // 0x0000000186922500-0x0000000186922610
		public void TogglePermanentCoopOutlines(bool value) {} // 0x0000000186922610-0x0000000186922720
		public void ToggleTintUISelection(bool value) {} // 0x0000000186922720-0x0000000186922830
		public void SetPlayerColourIndex(int playerIndex, int index) {} // 0x0000000186922830-0x0000000186922A30
		public void SetCoopChestMode(bool value) {} // 0x0000000186922A30-0x0000000186922A70
		public void ToggleHideDebugUI(bool value) {} // 0x0000000186922A70-0x0000000186922BB0
		public void ToggleHideGameUI(bool value) {} // 0x0000000186922BB0-0x0000000186922C30
		public void ViewPonclePrivacyPolicy() {} // 0x0000000186922C30-0x0000000186922C90
		public void OpenLanguagesPage() {} // 0x0000000186922C90-0x0000000186922D80
		public void SetResolution(int i) {} // 0x0000000186922D80-0x0000000186922F20
		public void SetRefreshRate(int i) {} // 0x0000000186922F20-0x00000001869230F0
		private void SetTargetFrameRate(int targetFrameRate) {} // 0x00000001820926D0-0x00000001820926E0
		public void SetBorderType(int i) {} // 0x00000001869230F0-0x0000000186923130
		public void SetWindowMode(int i) {} // 0x0000000186923130-0x0000000186923210
		private void UpdateRefreshRateDropdownVisibility(bool forceShow = false /* Metadata: 0x01977257 */) {} // 0x0000000186923210-0x00000001869236D0
		public void SetVsyncEnabled(bool value) {} // 0x00000001869236D0-0x0000000186923C60
		public void ApplyGraphicsSettings() {} // 0x0000000186923C60-0x00000001869240A0
		public void RestoreBackup() {} // 0x00000001869240A0-0x0000000186924170
		public void RecoverOldData() {} // 0x0000000186924170-0x0000000186924240
		private void ShowDeleteAdventureDataPopup(Action onComplete) {} // 0x0000000186924240-0x0000000186924480
		public void DeleteSave() {} // 0x0000000186924480-0x0000000186924550
		private void ActuallyDeleteSave() {} // 0x0000000186924550-0x0000000186924790
		[IteratorStateMachine(typeof(_WaitAndReselect_d__152))]
		private IEnumerator WaitAndReselect() => default; // 0x0000000186924790-0x0000000186924830
		private void HideAdsButtons(bool b) {} // 0x0000000186924830-0x0000000186924960
		private void OnTwitchConnectButtonPressed() {} // 0x0000000186924960-0x0000000186924A40
		private void OnTwitchDisconnectButtonPressed() {} // 0x0000000186924A40-0x0000000186924B30
		private void UpdateTwitchButtonStates(bool updateSelection = false /* Metadata: 0x01977258 */) {} // 0x0000000186924B30-0x0000000186924C50
		private void UpdateTwitchButtonNavigation(bool isTwitchConfigured) {} // 0x0000000186924C50-0x0000000186925000
	}
}
