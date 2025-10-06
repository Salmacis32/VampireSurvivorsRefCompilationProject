/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class EquipmentIconPaused : MonoBehaviour // TypeDefIndex: 14758
	{
		// Fields
		[SerializeField]
		private List<Image> _Levels; // 0x20
		[SerializeField]
		private Image _Icon; // 0x28
		[SerializeField]
		private Sprite _CompletedLevel; // 0x30
		[SerializeField]
		private Sprite _IncompleteLevel; // 0x38
		[SerializeField]
		private GameObject _LevelIconPrefab; // 0x40
		[SerializeField]
		private RectTransform _LevelIconContainer; // 0x48
		[SerializeField]
		private TextMeshProUGUI _LimitBreakLevelText; // 0x50
		private List<GameObject> _spawned; // 0x58
		private WeaponType _type; // 0x60
	
		// Constructors
		public EquipmentIconPaused() {} // 0x0000000186881B90-0x0000000186881D20
	
		// Methods
		public void SetData(WeaponType t, int level, int maxLevel, Sprite s, bool isBanished) {} // 0x0000000186881600-0x0000000186881A70
		public WeaponType GetWeaponType() => default; // 0x00000001819A0200-0x00000001819A0210
		public void SetLimitBreakLevel(int limitBreakLevel, int foundWeaponLevel) {} // 0x0000000186881A70-0x0000000186881B90
	}
}
