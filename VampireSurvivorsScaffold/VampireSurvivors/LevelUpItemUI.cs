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
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class LevelUpItemUI : SelectableUI // TypeDefIndex: 14208
	{
		// Fields
		[SerializeField]
		private Image _Background; // 0xA0
		[SerializeField]
		private Localize _Name; // 0xA8
		[SerializeField]
		private TextMeshProUGUI _Level; // 0xB0
		[SerializeField]
		private TextMeshProUGUI _New; // 0xB8
		[SerializeField]
		private TextMeshProUGUI _Description; // 0xC0
		[SerializeField]
		private Image _Icon; // 0xC8
		[SerializeField]
		private TextMeshProUGUI _EvoText; // 0xD0
		[SerializeField]
		private Image[] _EvoIcons; // 0xD8
		[SerializeField]
		private Image _EvoCharacterIcon; // 0xE0
		[SerializeField]
		private GameObject _ItemCharacterIconGroup; // 0xE8
		[SerializeField]
		private Image[] _ItemCharacterIcons; // 0xF0
		[SerializeField]
		private Image[] _OnlineSuggestionsIcons; // 0xF8
		private WeaponData _data; // 0x100
		private WeaponData _levelData; // 0x108
		private WeaponType _type; // 0x110
		private LevelUpPage _page; // 0x118
		private List<WeaponData> _allData; // 0x120
		private WeightedLimitBreak _wlBreak; // 0x128
		private int _index; // 0x130
		private ItemData _itemData; // 0x138
		private VampireSurvivors.Data.ItemType _itemType; // 0x140
		private int _currentLevel; // 0x144
		private bool _isLimitBreak; // 0x148
		private bool _isNew; // 0x149
	
		// Properties
		public WeightedLimitBreak LimitBreakData { get => default; } // 0x0000000182937BD0-0x0000000182937BE0 
		public VampireSurvivors.Data.ItemType ItemType { get => default; } // 0x0000000181B53310-0x0000000181B53320 
		public int Index { get => default; } // 0x0000000184756700-0x0000000184756710 
	
		// Constructors
		public LevelUpItemUI() {} // 0x0000000186DB60B0-0x0000000186DB61B0
	
		// Methods
		public void Select() {} // 0x0000000186DB1930-0x0000000186DB1AD0
		public void SelectWeapon() {} // 0x0000000186DB1AD0-0x0000000186DB1B30
		public void SelectItem() {} // 0x0000000186DB1B30-0x0000000186DB1B70
		public void SetWeaponData(LevelUpPage page, WeaponType type, WeaponData baseData, WeaponData levelData, int index, int newLevel, bool isNew, bool showEvo = false /* Metadata: 0x01977056 */, List<Sprite> evoIcons = null, Sprite characterOwner = null) {} // 0x0000000186DB1B70-0x0000000186DB3140
		private void HookOnlineCallback() {} // 0x0000000186DB3140-0x0000000186DB34F0
		private void OnLevelUpSuggestedCallback(int newSuggestion, int seatNumber, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000186DB34F0-0x0000000186DB3610
		protected override void OnDestroy() {} // 0x0000000186DB3610-0x0000000186DB39C0
		public bool IsNew() => default; // 0x000000018675C970-0x000000018675C980
		public void DisableSelection() {} // 0x0000000186DB39C0-0x0000000186DB3AA0
		public void EnableSelection() {} // 0x0000000186DB3AA0-0x0000000186DB3B80
		public WeaponType GetWeaponType() => default; // 0x0000000184E07690-0x0000000184E076A0
		public bool IsFriendshipAmulet() => default; // 0x0000000186DB3B80-0x0000000186DB3BA0
		public void SetItemData(VampireSurvivors.Data.ItemType type, ItemData data, LevelUpPage page, int index, List<VampireSurvivors.Objects.Characters.CharacterController> affectedCharacters = null) {} // 0x0000000186DB3BA0-0x0000000186DB4540
		public bool IsWeapon() => default; // 0x0000000186DB4540-0x0000000186DB4580
		public bool IsPowerUp() => default; // 0x0000000186DB4580-0x0000000186DB45C0
		public void SetLimitBreakData(LevelUpPage page, WeightedLimitBreak wlBreak, Equipment e, WeaponData baseWeaponData, WeaponType weaponType, int index) {} // 0x0000000186DB45C0-0x0000000186DB5080
		public Image GetIcon() => default; // 0x00000001827666D0-0x00000001827666E0
		private string ParseLimitBreakData(LimitBreakData d) => default; // 0x0000000186DB5080-0x0000000186DB60B0
	}
}
