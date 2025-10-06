/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Characters;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class CharacterItemUI : SelectableUI // TypeDefIndex: 14722
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _CharacterName; // 0xA0
		[SerializeField]
		private Image _CharacterIcon; // 0xA8
		[SerializeField]
		private Image _WeaponIcon; // 0xB0
		[SerializeField]
		private Image _ShadowIcon; // 0xB8
		[SerializeField]
		private Image _LockIcon; // 0xC0
		[SerializeField]
		private Image _Background; // 0xC8
		[SerializeField]
		private Image _Flash; // 0xD0
		private ICharacterSelector _page; // 0xD8
		private UIUnlockStates? _forcedUnlockState; // 0xE0
		private bool _isTaken; // 0xE8
		private bool _voidWeapon; // 0xE9
		private DataManager _dataManager; // 0xF0
		private PlayerOptions _playerOptions; // 0xF8
		private Color _highlightColor; // 0x100
		private readonly float _iconUIScale; // 0x110
		private CharacterItem _charItem; // 0x118
		private Color _backgroundColor; // 0x120
	
		// Properties
		public CharacterItem CharacterItem { get => default; } // 0x00000001829475E0-0x00000001829475F0 
		public VampireSurvivors.Data.CharacterType Type { get => default; } // 0x000000018684FEB0-0x000000018684FED0 
	
		// Constructors
		public CharacterItemUI() {} // 0x0000000186853450-0x0000000186853510
	
		// Methods
		public void SetData(ICharacterSelector page, DataManager dataManager, PlayerOptions playerOptions, CharacterItem charItem, bool useDefaultSkin = false /* Metadata: 0x019771EC */) {} // 0x000000018684FED0-0x0000000186850240
		public void Refresh(bool setInfoPanel = true /* Metadata: 0x019771ED */) {} // 0x0000000186850240-0x00000001868504A0
		public void AnimateIn() {} // 0x00000001868504A0-0x0000000186850AB0
		[IteratorStateMachine(typeof(_WaitAndSelect_d__24))]
		private IEnumerator WaitAndSelect() => default; // 0x0000000186850AB0-0x0000000186850B50
		public void SetTakenByAnotherPlayer(bool taken, Color highlightColor) {} // 0x0000000186850B50-0x0000000186850C60
		public bool IsTakenByAnotherPlayer() => default; // 0x00000001828C4B40-0x00000001828C4B50
		public void SetSelected() {} // 0x0000000186850C60-0x0000000186850CF0
		public void UnSelect() {} // 0x0000000186850CF0-0x0000000186850E00
		private Sprite GetBackgroundSprite() => default; // 0x0000000186850E00-0x0000000186850F10
		public bool IsAvailable() => default; // 0x0000000186850F10-0x0000000186850F70
		public bool IsCharAvailable() => default; // 0x0000000186850F70-0x0000000186850FF0
		public bool IsSkinAvailable() => default; // 0x0000000186850FF0-0x0000000186851030
		public bool IsPurchasable() => default; // 0x0000000186851030-0x00000001868510A0
		public bool IsCharPurchasable() => default; // 0x00000001868510A0-0x0000000186851120
		public bool IsSkinPurchasable() => default; // 0x0000000186851120-0x0000000186851160
		public bool IsUnlockable() => default; // 0x0000000186851160-0x00000001868511D0
		public bool IsCharUnlockable() => default; // 0x00000001868511D0-0x0000000186851250
		public bool IsSkinUnlockable() => default; // 0x0000000186851250-0x0000000186851290
		public float GetPrice() => default; // 0x0000000186851290-0x0000000186851350
		private float CharMarkup() => default; // 0x0000000186851350-0x00000001868515A0
		public void SetInfoPanel() {} // 0x00000001868515A0-0x0000000186851690
		public bool HasForcedUnlockState() => default; // 0x0000000186851690-0x00000001868516E0
		public void SetForcedUnlockState(UIUnlockStates? state) {} // 0x00000001868516E0-0x0000000186851700
		public bool IsUnlockableAndSecret() => default; // 0x0000000186851700-0x0000000186851770
		public Sprite GetCharSprite(VampireSurvivors.Data.CharacterType charType, CharacterData charData) => default; // 0x0000000186851770-0x0000000186851870
		private void UpdateVisualState() {} // 0x0000000186851870-0x0000000186851920
		private void SetVisualStateUnlockable() {} // 0x0000000186851920-0x0000000186851C60
		private void SetVisualStatePurchasable() {} // 0x0000000186851C60-0x0000000186851F80
		private void SetVisualStateAvailable() {} // 0x0000000186851F80-0x0000000186852570
		private void SetIconSizes() {} // 0x0000000186852570-0x0000000186852F80
		private void SetCharacterSprite() {} // 0x0000000186852F80-0x0000000186853060
		protected override void OnSelected() {} // 0x0000000186853060-0x0000000186853070
		private void SetCharacterName() {} // 0x0000000186853070-0x0000000186853130
		private void SetWeaponIconSprite() {} // 0x0000000186853130-0x0000000186853450
	}
}
