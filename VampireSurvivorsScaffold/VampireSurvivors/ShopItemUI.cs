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
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class ShopItemUI : SelectableUI // TypeDefIndex: 14232
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0xA0
		[SerializeField]
		private Localize _Name; // 0xA8
		[SerializeField]
		private Localize _Description; // 0xB0
		[SerializeField]
		private TextMeshProUGUI _Price; // 0xB8
		[SerializeField]
		private Image _Fader; // 0xC0
		[SerializeField]
		private UISpriteAnimation _SheenAnimation; // 0xC8
		[SerializeField]
		private Image _LockIcon; // 0xD0
		[SerializeField]
		private Image[] _OnlineSuggestionsIcons; // 0xD8
		private WeaponData _weaponData; // 0xE0
		private WeaponType _weaponType; // 0xE8
		private ItemData _itemData; // 0xF0
		private VampireSurvivors.Data.ItemType _itemType; // 0xF8
		private GameWindowedUIPage _page; // 0x100
		private PlayerOptions _playerOptions; // 0x108
		private float _price; // 0x110
		private bool _isSoldOut; // 0x114
		private int _quantity; // 0x118
		private int _index; // 0x11C
	
		// Properties
		public WeaponType WeaponType { get => default; } // 0x0000000182916F80-0x0000000182916F90 
		public VampireSurvivors.Data.ItemType ItemType { get => default; } // 0x00000001827FCB90-0x00000001827FCBA0 
		public bool IsSoldOut { get => default; } // 0x0000000185DD5080-0x0000000185DD5090 
		public bool IsCustomActionItem { get; private set; } // 0x0000000182917530-0x0000000182917540 0x0000000184BB63B0-0x0000000184BB63C0
	
		// Events
		public event Action OnPurchased;
	
		// Constructors
		public ShopItemUI() {} // 0x00000001865B2B50-0x00000001865B2BB0
	
		// Methods
		public bool CanBuy() => default; // 0x0000000186F002C0-0x0000000186F00310
		public void InvokeCustomPurchaseAction() {} // 0x0000000186F00310-0x0000000186F00330
		public void Buy() {} // 0x0000000186F00330-0x0000000186F007D0
		public void SetWeaponData(WeaponData d, WeaponType t, GameWindowedUIPage page, PlayerOptions po, float price, int index, int quantity = 1 /* Metadata: 0x01977089 */, float priceMarkupMultiplier = 1f /* Metadata: 0x0197708A */, bool useWeaponDataPrice = false /* Metadata: 0x0197708E */) {} // 0x0000000186F007D0-0x0000000186F00C10
		private void SetLockState() {} // 0x0000000186F00C10-0x0000000186F00D20
		public void SetItemData(ItemData d, VampireSurvivors.Data.ItemType t, GameWindowedUIPage page, float price, int index, int quantity = 1 /* Metadata: 0x0197708F */, float priceMarkupMultiplier = 1f /* Metadata: 0x01977090 */) {} // 0x0000000186F00D20-0x0000000186F01100
		private void HookOnlineCallback() {} // 0x0000000186F01100-0x0000000186F014B0
		private void OnBuySuggestedCallback(int newSuggestion, int seatNumber, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186F014B0-0x0000000186F015D0
		public void SetCustomAction(CustomActionInventoryItem inventoryItem, GameWindowedUIPage page, float priceMarkupMultiplier = 1f /* Metadata: 0x01977094 */) {} // 0x0000000186F015D0-0x0000000186F01910
		private void SetIconSize() {} // 0x0000000186F01910-0x0000000186F01D10
		protected override void OnSelected() {} // 0x0000000186F01D10-0x0000000186F01E10
		public void ShuffleText() {} // 0x0000000186F01E10-0x0000000186F01F50
		public void SetPrice(float i) {} // 0x0000000186F01F50-0x0000000186F02050
		public float GetPrice() => default; // 0x0000000185D800D0-0x0000000185D800E0
		public void SoldOut() {} // 0x0000000186F02050-0x0000000186F020D0
		public ItemData GetItemData() => default; // 0x00000001819716C0-0x00000001819716D0
		public WeaponData GetWeaponData() => default; // 0x000000018282D820-0x000000018282D830
		protected override void OnDestroy() {} // 0x0000000186F020D0-0x0000000186F02480
		private void AnimateBuy() {} // 0x0000000186F02480-0x0000000186F024B0
	}
}
