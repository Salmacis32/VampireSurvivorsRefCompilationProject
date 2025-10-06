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
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class LevelBonusSelectionItem : SelectableUI // TypeDefIndex: 14207
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Name; // 0xA0
		[SerializeField]
		private Image _Icon; // 0xA8
		private PowerUpType _type; // 0xB0
		private PowerUpData _data; // 0xB8
		private LevelBonusSelectionPage _page; // 0xC0
		private UnityEngine.UI.Button _button; // 0xC8
	
		// Constructors
		public LevelBonusSelectionItem() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public void SetData(LevelBonusSelectionPage page, PowerUpType t, PowerUpData d) {} // 0x0000000186DB0E60-0x0000000186DB1360
		private string UppercaseFirst(string s) => default; // 0x0000000186DB1360-0x0000000186DB1440
		public void DisableButton() {} // 0x0000000186DB1440-0x0000000186DB1470
		protected override void OnSelected() {} // 0x0000000186DB1470-0x0000000186DB1500
		public PowerUpType GetPowerUpType() => default; // 0x0000000181F88A50-0x0000000181F88A60
		private void ClickButton() {} // 0x0000000186DB1500-0x0000000186DB1530
		private void SetIconSize() {} // 0x0000000186DB1530-0x0000000186DB1930
	}
}
