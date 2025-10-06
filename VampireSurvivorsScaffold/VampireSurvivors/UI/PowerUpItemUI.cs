/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.PowerUp;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class PowerUpItemUI : SelectableUI // TypeDefIndex: 14917
	{
		// Fields
		[SerializeField]
		private Localize Title; // 0xA0
		[SerializeField]
		private Image Icon; // 0xA8
		[SerializeField]
		private GameObject UpgradeSlotPrefab; // 0xB0
		[SerializeField]
		private RectTransform Container; // 0xB8
		[SerializeField]
		private UnityEngine.UI.Button Clicker; // 0xC0
		[SerializeField]
		private Image Background; // 0xC8
		[SerializeField]
		private Image Frame; // 0xD0
		[SerializeField]
		private Color MaxColor; // 0xD8
		public PowerUpData _data; // 0xE8
		public PowerUpType _type; // 0xF0
		public PowerUpsPage _page; // 0xF8
		private int _currentLevel; // 0x100
		private int _maxRank; // 0x104
		private List<GameObject> _spawnedSlots; // 0x108
	
		// Constructors
		public PowerUpItemUI() {} // 0x000000018692D4F0-0x000000018692D5F0
	
		// Methods
		public void SetData(PowerUpData data, PowerUpType type, PowerUpsPage page, int currentLevel, int maxRank) {} // 0x000000018692BC70-0x000000018692C9A0
		public void Reset() {} // 0x000000018692C9A0-0x000000018692CDD0
		private void CreateSlot(int i) {} // 0x000000018692CDD0-0x000000018692CEE0
		public bool UpdateAfterPurchase() => default; // 0x000000018692CEE0-0x000000018692D300
		public void SetActive(bool b) {} // 0x000000018692D300-0x000000018692D360
		public void SetInfo() {} // 0x000000018692D360-0x000000018692D3A0
		private void CheckMaxedOut() {} // 0x000000018692D3A0-0x000000018692D4E0
		public bool IsMaxedOut() => default; // 0x000000018692D4E0-0x000000018692D4F0
		protected override void OnSelected() {} // 0x000000018692D360-0x000000018692D3A0
	}
}
