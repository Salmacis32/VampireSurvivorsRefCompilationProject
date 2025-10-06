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
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameEquipmentPanelItem : MonoBehaviour // TypeDefIndex: 14784
	{
		// Fields
		[SerializeField]
		private RectTransform _levelContainer; // 0x20
		[SerializeField]
		private GameObject _levelPrefab; // 0x28
		[SerializeField]
		private Image _icon; // 0x30
		[SerializeField]
		private Image _BlockedIcon; // 0x38
		[SerializeField]
		[Space]
		private float _iconAlphaWhenEquipmentDisabled; // 0x40
		[SerializeField]
		private Vector2 _blockedIconSizeWhenEquipmentDisabled; // 0x44
		private WeaponData _data; // 0x50
		private WeaponType _type; // 0x58
		private bool _isSet; // 0x5C
		private int _currentLevel; // 0x60
		private readonly List<GameObject> _spawnedSlots; // 0x68
	
		// Constructors
		public GameEquipmentPanelItem() {} // 0x000000018689A6C0-0x000000018689A7C0
	
		// Methods
		public void Initialize(VampireSurvivors.Objects.Characters.CharacterController ownerCharacter, WeaponData data, WeaponType type) {} // 0x00000001868995E0-0x0000000186899D00
		public void Reset() {} // 0x0000000186899D00-0x0000000186899F10
		public bool IsSet() => default; // 0x0000000184A19620-0x0000000184A19630
		public void SetBlocked(bool blocked) {} // 0x0000000186899F10-0x000000018689A050
		public void SetDisabledIcon(bool disabled) {} // 0x000000018689A050-0x000000018689A250
		public void CreateSlots() {} // 0x000000018689A250-0x000000018689A380
		public void SetLevel(int level) {} // 0x000000018689A380-0x000000018689A6C0
		public WeaponData GetWData() => default; // 0x000000018197EAB0-0x000000018197EAC0
		public WeaponType GetWType() => default; // 0x00000001819A01E0-0x00000001819A01F0
	}
}
