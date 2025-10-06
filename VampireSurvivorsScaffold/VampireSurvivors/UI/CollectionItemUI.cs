/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CollectionItemUI : SelectableUI // TypeDefIndex: 14737
	{
		// Fields
		[SerializeField]
		private Image LockedIcon; // 0xA0
		[SerializeField]
		private Image UnlockedIcon; // 0xA8
		[SerializeField]
		private Image Frame; // 0xB0
		[SerializeField]
		private Image _SealIcon; // 0xB8
		private WeaponData _weaponData; // 0xC0
		private WeaponType _weaponType; // 0xC8
		private CollectionsPage _page; // 0xD0
		private ItemData _itemData; // 0xD8
		private VampireSurvivors.Data.ItemType _itemType; // 0xE0
		private ArcanaData _arcanaData; // 0xE8
		private ArcanaType _arcanaType; // 0xF0
		private UnityEngine.UI.Button _button; // 0xF8
		private bool _seen; // 0x100
		public CollectionTypes CollectionType; // 0x104
	
		// Nested types
		public enum CollectionTypes // TypeDefIndex: 14736
		{
			WEAPON = 0,
			ITEM = 1,
			ARCANA = 2
		}
	
		// Constructors
		public CollectionItemUI() {} // 0x000000018686E370-0x000000018686E3D0
	
		// Methods
		public void SetData(WeaponData w, CollectionsPage page, WeaponType _wType, bool isSealed) {} // 0x000000018686CB80-0x000000018686CE30
		public ItemData GetItemData() => default; // 0x0000000182A45A70-0x0000000182A45A80
		private void SetIconSizes() {} // 0x000000018686CE30-0x000000018686D3A0
		public void SetItem(ItemData w, CollectionsPage page, VampireSurvivors.Data.ItemType _item, bool isSealed) {} // 0x000000018686D3A0-0x000000018686D6D0
		public void SetArcana(ArcanaData w, CollectionsPage page, ArcanaType type) {} // 0x000000018686D6D0-0x000000018686D9F0
		public void Seal() {} // 0x000000018686D9F0-0x000000018686DA60
		public void UnSeal() {} // 0x000000018686DA60-0x000000018686DB10
		public bool IsWeapon() => default; // 0x000000018686DB10-0x000000018686DB50
		public bool IsPassive() => default; // 0x000000018686DB50-0x000000018686DB90
		public bool IsItem() => default; // 0x000000018686DB90-0x000000018686DBC0
		public bool IsRelic() => default; // 0x000000018686DBC0-0x000000018686DC60
		public bool IsArcana() => default; // 0x000000018686DC60-0x000000018686DC70
		public bool IsDefaultContent() => default; // 0x000000018686DC70-0x000000018686DCB0
		public bool IsExtra() => default; // 0x000000018686DCB0-0x000000018686DD10
		private void SetLocked(bool isUnlocked) {} // 0x000000018686DD10-0x000000018686E050
		protected override void OnSelected() {} // 0x000000018686E050-0x000000018686E0E0
		private void SetupClickRegister() {} // 0x000000018686E0E0-0x000000018686E200
		private void RegisterClick() {} // 0x000000018686E200-0x000000018686E2F0
		public WeaponType GetWeaponType() => default; // 0x00000001849C5CF0-0x00000001849C5D00
		public WeaponData GetWeaponData() => default; // 0x00000001819A0460-0x00000001819A0470
		public VampireSurvivors.Data.ItemType GetItemType() => default; // 0x0000000181E31910-0x0000000181E31920
		public ContentGroupType GetContentGroup() => default; // 0x000000018686E2F0-0x000000018686E370
		public ArcanaType GetArcanaType() => default; // 0x0000000181B66970-0x0000000181B66980
	}
}
