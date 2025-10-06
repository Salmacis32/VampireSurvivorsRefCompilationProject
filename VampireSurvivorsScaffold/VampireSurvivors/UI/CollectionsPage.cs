/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CollectionsPage : BaseUIPage // TypeDefIndex: 14740
	{
		// Fields
		public static bool IsMagician; // 0x00
		[SerializeField]
		private bool _DEBUG; // 0xE0
		[SerializeField]
		private Localize Name; // 0xE8
		[SerializeField]
		private Localize Description; // 0xF0
		[SerializeField]
		private Localize AdditionalInfo; // 0xF8
		[SerializeField]
		private Image Icon; // 0x100
		[SerializeField]
		private Image Background; // 0x108
		[SerializeField]
		private Localize Title; // 0x110
		[SerializeField]
		private GameObject CollectionPrefab; // 0x118
		[SerializeField]
		private RectTransform _MagicianPanel; // 0x120
		[SerializeField]
		private SealPanel _SealPanel; // 0x128
		[SerializeField]
		private GameObject _GridPrefab; // 0x130
		[SerializeField]
		private GameObject _HeaderPrefab; // 0x138
		[SerializeField]
		private TextMeshProUGUI _FilterModeText; // 0x140
		[SerializeField]
		private MobileConfig _PanelPanelConfig; // 0x148
		[SerializeField]
		private MegaSealPanel _MegaSealPanel; // 0x150
		private DataManager _data; // 0x158
		private PlayerOptions _playerOptions; // 0x160
		private AdventureManager _adventures; // 0x168
		private List<CollectionItemUI> _spawned; // 0x170
		private List<GameObject> _structuralSpawned; // 0x178
		private int _totalUnlocked; // 0x180
		private int _totalAvailable; // 0x184
		private RectTransform _scrollRect; // 0x188
		private int _yellowSignClickCount; // 0x190
		private RectTransform _activeContentGrid; // 0x198
		private bool shouldForceLayoutUpdate; // 0x1A0
		private bool shouldRegenerateNav; // 0x1A1
		private bool _hasDarkasso; // 0x1A2
		private List<CollectionItemUI> _defaultSortOrder; // 0x1A8
		public FilterType _currentFilter; // 0x1B0
	
		// Nested types
		public enum FilterType // TypeDefIndex: 14738
		{
			DEFAULT = 0,
			BY_TYPE = 1,
			BY_VERSION = 2,
			ADVENTURE = 3
		}
	
		// Constructors
		public CollectionsPage() {} // 0x0000000186878E10-0x0000000186878FB0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player, AdventureManager adventure) {} // 0x000000018686E3D0-0x000000018686E4F0
		protected override void OnShowStart(GameObject g) {} // 0x000000018686E4F0-0x000000018686E830
		private void LateUpdate() {} // 0x000000018686E830-0x000000018686E8E0
		private void Populate() {} // 0x000000018686E8E0-0x000000018686F5F0
		private void GenerateNavigation() {} // 0x000000018686F5F0-0x000000018686FD90
		private void SpawnElements(Dictionary<WeaponType, List<WeaponData>> weapons, WeaponType[] yellowWeapons, Dictionary<VampireSurvivors.Data.ItemType, ItemData> items, VampireSurvivors.Data.ItemType[] yellowItems, Dictionary<ArcanaType, ArcanaData> arcanas) {} // 0x000000018686FD90-0x0000000186870720
		protected override void OnHideStart(GameObject g) {} // 0x0000000186870720-0x0000000186870830
		private void AddWeapon(WeaponData dat, WeaponType type) {} // 0x0000000186870830-0x00000001868709F0
		private GameObject AddItem(ItemData dat, VampireSurvivors.Data.ItemType type) => default; // 0x00000001868709F0-0x0000000186870BB0
		private void AddArcana(ArcanaData dat, ArcanaType type) {} // 0x0000000186870BB0-0x0000000186870CE0
		private void SetTitle() {} // 0x0000000186870CE0-0x00000001868713D0
		private void SortByDefault() {} // 0x00000001868713D0-0x0000000186871980
		private void SortByType() {} // 0x0000000186871980-0x0000000186872AD0
		private void SortByVersion() {} // 0x0000000186872AD0-0x0000000186873EC0
		private ContentGroupType GetContentGroup(CollectionItemUI item) => default; // 0x0000000186873EC0-0x0000000186873F10
		private void ClearStructures() {} // 0x0000000186873F10-0x0000000186874250
		private void SortByAdventure() {} // 0x0000000186874250-0x0000000186875340
		private void AddHeader(string text) {} // 0x0000000186875340-0x0000000186875450
		private void AddGrid() {} // 0x0000000186875450-0x0000000186875590
		private void AddFakeContent() {} // 0x0000000186875590-0x00000001868757A0
		public void SetInfoPanel(WeaponData d, WeaponType type) {} // 0x00000001868757A0-0x0000000186875E10
		public void RegisterItemClick(bool isYellowSign) {} // 0x0000000186875E10-0x0000000186876010
		public void WeaponClicked(CollectionItemUI item, WeaponType t) {} // 0x0000000186876010-0x0000000186876480
		private void BanishWeapon(CollectionItemUI item) {} // 0x0000000186876480-0x0000000186876580
		private void UnBanishWeapon(CollectionItemUI item) {} // 0x0000000186876580-0x0000000186876690
		private void ContentGroupBanishWeapon(CollectionItemUI item) {} // 0x0000000186876690-0x0000000186876810
		private void ContentGroupUnBanishWeapon(CollectionItemUI item) {} // 0x0000000186876810-0x00000001868768E0
		private void ContentGroupBanishItem(CollectionItemUI item) {} // 0x0000000180B15170-0x0000000180B15180
		private void ContentGroupUnBanishItem(CollectionItemUI item) {} // 0x00000001868768E0-0x00000001868769B0
		public void UnsealAll() {} // 0x00000001868769B0-0x0000000186876C80
		private void BanishItem(CollectionItemUI item) {} // 0x0000000186876C80-0x0000000186876D70
		private void UnBanishItem(CollectionItemUI item) {} // 0x0000000186876D70-0x0000000186876E80
		public void BanishGroup(ContentGroupType contentGroup) {} // 0x0000000186876E80-0x00000001868770F0
		public void UnBanishGroup(ContentGroupType contentGroup) {} // 0x00000001868770F0-0x0000000186877370
		public void ItemClicked(CollectionItemUI item, VampireSurvivors.Data.ItemType t) {} // 0x0000000186877370-0x0000000186877790
		public void OnUnsealableClicked() {} // 0x0000000186877790-0x0000000186877840
		public void SetInfoPanel(ItemData d, VampireSurvivors.Data.ItemType type) {} // 0x0000000186877840-0x0000000186877D10
		public void CycleFiltering() {} // 0x0000000186877D10-0x0000000186877F50
		private void SetFilter() {} // 0x0000000186877F50-0x00000001868780C0
		private void UpdateFilterTextDisplay() {} // 0x00000001868780C0-0x00000001868781F0
		public void SetInfoPanel(ArcanaData d, ArcanaType type) {} // 0x00000001868781F0-0x0000000186878550
		private void SetIconSize() {} // 0x0000000186878550-0x0000000186878960
		public void Reset() {} // 0x0000000186878960-0x0000000186878C60
		private void MakeMagician() {} // 0x0000000186878C60-0x0000000186878E10
	}
}
