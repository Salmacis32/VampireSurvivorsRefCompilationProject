/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AutomationPopup : BasePopup // TypeDefIndex: 14693
	{
		// Fields
		[SerializeField]
		protected UnityEngine.UI.Button _Close; // 0x48
		[SerializeField]
		protected UnityEngine.UI.Button _Confirm; // 0x50
		[SerializeField]
		protected UnityEngine.UI.Button _QuickStart; // 0x58
		[SerializeField]
		private RectTransform _AutomationContainer; // 0x60
		[SerializeField]
		private RectTransform _SettingsContainer; // 0x68
		private DataManager _dataManager; // 0x70
		[SerializeField]
		private GameObject _TickboxPrefab; // 0x78
		[SerializeField]
		private GameObject _SliderPrefab; // 0x80
		[SerializeField]
		private GameObject _ButtonPrefab; // 0x88
		[SerializeField]
		private GameObject _DropdownPrefab; // 0x90
		[SerializeField]
		private GameObject _MultipleChoicePrefab; // 0x98
		[SerializeField]
		private GameObject _TickboxSmallPrefab; // 0xA0
		[SerializeField]
		private GameObject _LabelPrefab; // 0xA8
		private List<ISelectableUI> _automationElements; // 0xB0
		private List<IUIObject> _spawnedElements; // 0xB8
		private List<IUIObject> _settingElements; // 0xC0
		private List<TickBoxUI> _allStageChoices; // 0xC8
		private bool _stageOptionsActive; // 0xD0
		private List<string> _allStages; // 0xD8
		private List<StageType> _allStageTypes; // 0xE0
	
		// Constructors
		public AutomationPopup() {} // 0x0000000186793F10-0x0000000186794190
	}
}
