/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class EnemyItemUI : SelectableUI // TypeDefIndex: 14193
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Number; // 0xA0
		[SerializeField]
		private TextMeshProUGUI _Name; // 0xA8
		[SerializeField]
		private Image _Background; // 0xB0
		private BestiaryPage _page; // 0xB8
		private EnemyData _data; // 0xC0
		private EnemyType _type; // 0xC8
		private bool _hasKilled; // 0xCC
	
		// Constructors
		public EnemyItemUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public void SetData(EnemyType type, int count, EnemyData dat, BestiaryPage page, bool hasKilled) {} // 0x0000000186DAC860-0x0000000186DACBA0
		public bool HasKilled() => default; // 0x0000000185EF5B10-0x0000000185EF5B20
		protected override void OnSelected() {} // 0x0000000186DACBA0-0x0000000186DACC00
		protected override void OnDeselected() {} // 0x0000000186DACC00-0x0000000186DACC30
		private void SetInfoPanel() {} // 0x0000000186DACC30-0x0000000186DACC70
	}
}
