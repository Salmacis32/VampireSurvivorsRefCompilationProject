/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AchievementDataUI : SelectableUI // TypeDefIndex: 14644
	{
		// Fields
		[SerializeField]
		private Image Icon; // 0xA0
		[SerializeField]
		private Image Tick; // 0xA8
		[SerializeField]
		private TextMeshProUGUI Label; // 0xB0
		[SerializeField]
		private GameObject Moneybag; // 0xB8
		[SerializeField]
		private GameObject _Frame; // 0xC0
		[SerializeField]
		private Localize localizer; // 0xC8
		private AchievementsPage _page; // 0xD0
		private AchievementData _data; // 0xD8
		private DataManager _dataManager; // 0xE0
		private bool _isAdventureAchievement; // 0xE8
		private AchievementType _type; // 0xEC
		private AdventureAchievementType _adventureType; // 0xF0
		private bool _hasAchieved; // 0xF4
	
		// Constructors
		public AchievementDataUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public void SetData(AdventureAchievementType type, AchievementData bad, AchievementsPage page, DataManager dataManager, bool hasCompleted) {} // 0x000000018730AF20-0x000000018730AF60
		public void SetData(AchievementType type, AchievementData bad, AchievementsPage page, DataManager dataManager, bool hasCompleted) {} // 0x000000018730AF60-0x000000018730AFA0
		private void Init(AchievementData achievementData, AchievementsPage page, DataManager dataManager, bool hasCompleted) {} // 0x000000018730AFA0-0x000000018730B7D0
		protected override void OnSelected() {} // 0x000000018730B7D0-0x000000018730B890
		private void SetSprite() {} // 0x000000018730B890-0x000000018730B900
		public bool IsCompleted() => default; // 0x000000018730B900-0x000000018730B920
		private Sprite GetSpriteForAchievement(AchievementData bad) => default; // 0x000000018730B920-0x000000018730C230
	}
}
