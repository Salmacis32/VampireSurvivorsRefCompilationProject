/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Lexone.UnityTwitchChat;
using Rewired.Integration.UnityUI;
using TMPro;
using UnityEngine;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI.Twitch
{
	public class TwitchLevelUpPanel : MonoBehaviour // TypeDefIndex: 18538
	{
		// Fields
		[SerializeField]
		private RectTransform _CountDownBackground; // 0x20
		[SerializeField]
		private Transform _CountDownFill; // 0x28
		[SerializeField]
		private TextMeshProUGUI _CountDownNumberText; // 0x30
		[SerializeField]
		private TwitchLevelUpOption _OptionPrefab; // 0x38
		[SerializeField]
		private RectTransform _PositionOption1; // 0x40
		[SerializeField]
		private RectTransform _PositionOption2; // 0x48
		[SerializeField]
		private RectTransform _PositionOption3; // 0x50
		[SerializeField]
		private RectTransform _PositionOption4; // 0x58
		[SerializeField]
		private RectTransform _PositionRerolls; // 0x60
		[SerializeField]
		private RectTransform _PositionSkip; // 0x68
		[SerializeField]
		private RectTransform _PositionBanish; // 0x70
		[SerializeField]
		private RectTransform _PositionPass; // 0x78
		[SerializeField]
		private GameObject _NavigatorsRoot; // 0x80
		private CanvasGroup _canvasGroup; // 0x88
		private LevelUpPage _levelUpPage; // 0x90
		private bool _banishChoice; // 0x98
		private bool _countdownStarted; // 0x99
		private int _rerollOptionNumber; // 0x9C
		private int _skipOptionNumber; // 0xA0
		private int _banishOptionNumber; // 0xA4
		private int _passOptionNumber; // 0xA8
		private int _twitchLimitCount; // 0xAC
		private List<int> _twitchOptionCounter; // 0xB0
		private int _howManyOptions; // 0xB8
		private List<TwitchLevelUpOption> _twitchOptionsPool; // 0xC0
		private List<TwitchLevelUpOption> _twitchOptions; // 0xC8
		private Tween _twitchCountdownBarTween; // 0xD0
		private RewiredStandaloneInputModule _inputModule; // 0xD8
		private const int CountdownLength = 7; // Metadata: 0x0197AA16
	
		// Properties
		private RewiredStandaloneInputModule InputModule { get => default; } // 0x00000001867C2420-0x00000001867C2580 
	
		// Constructors
		public TwitchLevelUpPanel() {} // 0x00000001867C6B80-0x00000001867C6D90
	
		// Methods
		private void Awake() {} // 0x00000001867C2580-0x00000001867C29B0
		private void Update() {} // 0x00000001867C29B0-0x00000001867C29C0
		public void InitTwitchPanel(LevelUpPage levelUpPage) {} // 0x00000001867C29C0-0x00000001867C2AC0
		public void ShowCountdown() {} // 0x00000001867C2AC0-0x00000001867C2C30
		public void EnableAllUIInteraction() {} // 0x00000001867C2C30-0x00000001867C2CD0
		private void CreateCountDownBar() {} // 0x00000001867C2CD0-0x00000001867C3010
		private void CreateButtons() {} // 0x00000001867C3010-0x00000001867C39A0
		private TwitchLevelUpOption SpawnTwitchOption(Transform parent, RectTransform targetPositionTransform, Action callback) => default; // 0x00000001867C39A0-0x00000001867C3F70
		private TwitchLevelUpOption GrabOptionFromPool() => default; // 0x00000001867C3F70-0x00000001867C4040
		private void AdjustOptionSpawnPosition(Transform spawnParentTransform, RectTransform targetRectTransform) {} // 0x00000001867C4040-0x00000001867C41E0
		private void CleanTwitchOptions() {} // 0x00000001867C41E0-0x00000001867C47C0
		private void StartCountdown() {} // 0x00000001867C47C0-0x00000001867C4A10
		private void EnterCountdownNumber(int num) {} // 0x00000001867C4A10-0x00000001867C4F30
		private void ExitCountdownNumber(int num) {} // 0x00000001867C4F30-0x00000001867C5290
		private void EndCountDownNumber(int num) {} // 0x00000001867C5290-0x00000001867C52A0
		private void CountdownComplete() {} // 0x00000001867C52A0-0x00000001867C5830
		private void ProcessMessage(Chatter chatter) {} // 0x00000001867C5830-0x00000001867C5E00
		private void IncreaseTwitchOption(int num, string username) {} // 0x00000001867C5E00-0x00000001867C60B0
		private int CalculateChoice() => default; // 0x00000001867C60B0-0x00000001867C6400
		private void DisableAllUIInteraction() {} // 0x00000001867C6400-0x00000001867C64A0
		private void OptionZeroSelected() {} // 0x00000001867C64A0-0x00000001867C64B0
		private void OptionOneSelected() {} // 0x00000001867C64B0-0x00000001867C64C0
		private void OptionTwoSelected() {} // 0x00000001867C64C0-0x00000001867C64D0
		private void OptionThreeSelected() {} // 0x00000001867C64D0-0x00000001867C64E0
		private void OptionSelected(int num) {} // 0x00000001867C64E0-0x00000001867C6570
		private void OnTwitchReroll() {} // 0x00000001867C6570-0x00000001867C65C0
		private void OnTwitchSkip() {} // 0x00000001867C65C0-0x00000001867C65F0
		private void OnTwitchBanish() {} // 0x00000001867C65F0-0x00000001867C6940
		private void SetBanishMode() {} // 0x00000001867C6940-0x00000001867C6A80
		private void OnTwitchPass() {} // 0x00000001867C6A80-0x00000001867C6AD0
		private void ResetTwitchOptionCounterValues() {} // 0x00000001867C6AD0-0x00000001867C6B80
	}
}
