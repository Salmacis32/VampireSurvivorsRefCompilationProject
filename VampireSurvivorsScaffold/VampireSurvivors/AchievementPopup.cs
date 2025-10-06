/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class AchievementPopup : MonoBehaviour // TypeDefIndex: 14182
	{
		// Fields
		[SerializeField]
		private Localize _TitleText; // 0x20
		[SerializeField]
		private Localize AchievementName; // 0x28
		[SerializeField]
		private TextMeshProUGUI _AchievementUnlock; // 0x30
		[SerializeField]
		private Image Icon; // 0x38
		[SerializeField]
		private Image _Frame; // 0x40
		[SerializeField]
		private RectTransform AchievementPanel; // 0x48
		[SerializeField]
		private TextMeshProUGUI PageCount; // 0x50
		[SerializeField]
		private GameObject _UnlocksCircle; // 0x58
		[SerializeField]
		private TextMeshProUGUI _UnlockText; // 0x60
		private List<AchievementData> _achievementsToShow; // 0x68
		private int _currentAchievementIndex; // 0x70
		private AchievementManager _achievementManager; // 0x78
		private DataManager _dataManager; // 0x80
		private DG.Tweening.Sequence _showLoop; // 0x88
		private bool _cancelAfterOneCycle; // 0x90
		private static Color _defaultBackgroundPanelColor; // 0x00
		private static Color _adventureBackgroundPanelColor; // 0x10
		private static string _defaultBackgroundSpriteName; // 0x20
		private static string _adventureBackgroundSpriteName; // 0x28
	
		// Constructors
		public AchievementPopup() {} // 0x0000000186DA7850-0x0000000186DA7950
		static AchievementPopup() {} // 0x0000000186DA7950-0x0000000186DA7AC0
	
		// Methods
		[Inject]
		private void Construct(AchievementManager achiement, DataManager data) {} // 0x0000000186DA6EF0-0x0000000186DA6FA0
		private void OnDestroy() {} // 0x0000000186DA6FA0-0x0000000186DA6FB0
		public void SetAchievements(List<AchievementData> achievements, bool cancelAfterOneCycle = false /* Metadata: 0x01977052 */) {} // 0x0000000186DA6FB0-0x0000000186DA7330
		public void CancelLoop() {} // 0x0000000186DA7330-0x0000000186DA73B0
		private void StartShowLoop() {} // 0x0000000186DA73B0-0x0000000186DA77C0
		private void SetLocalizedTitleText(bool isAdventure) {} // 0x0000000186DA77C0-0x0000000186DA7850
	}
}
