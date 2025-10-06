/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class ArcanaInfoPanel : MonoBehaviour // TypeDefIndex: 14666
	{
		// Fields
		[SerializeField]
		private Localize _InfoTitle; // 0x20
		[SerializeField]
		private Localize _InfoDescription; // 0x28
		[SerializeField]
		private RectTransform _AffectedWeaponGroup; // 0x30
		[SerializeField]
		private RectTransform _DynamicGrid; // 0x38
		[SerializeField]
		private bool _ReorderWeaponsBasedOnOwnership; // 0x40
		[SerializeField]
		private Image _AffectedWeaponImageTemplate; // 0x48
		[FormerlySerializedAs("_MaxWeaponsBeforeCarousel")]
		[SerializeField]
		private int _MaxWeaponsBeforeGrid; // 0x50
		private DataManager _data; // 0x58
		private PlayerOptions _playerOptions; // 0x60
		private VampireSurvivors.Objects.Characters.CharacterController _controllingCharacter; // 0x68
		private readonly List<GameObject> _affectedWeapons; // 0x70
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x78
		private Dictionary<VampireSurvivors.Data.ItemType, ItemData> _items; // 0x80
		private readonly List<Equipment> _equipment; // 0x88
		private List<WeaponType> _ownedWeapons; // 0x90
	
		// Constructors
		public ArcanaInfoPanel() {} // 0x00000001865E2650-0x00000001865E2880
	
		// Methods
		[Inject]
		private void Construct(DataManager data, PlayerOptions player, GameManager game, ArcanaManager arcana) {} // 0x00000001865DF3C0-0x00000001865DF470
		public void Initialize() {} // 0x00000001865DF470-0x00000001865DF9C0
		public void SetControllingCharacter(VampireSurvivors.Objects.Characters.CharacterController controllingCharacter) {} // 0x00000001827660A0-0x0000000182766100
		public void SetInfo(ArcanaData arcanaData, ArcanaType arcanaType) {} // 0x00000001865DF9C0-0x00000001865DFAF0
		private bool IsWeaponSelectorType(WeaponType? weaponType) => default; // 0x00000001865DFAF0-0x00000001865DFB70
		private void PopulateAffectedWeaponCarousel(ArcanaData arcanaData, ArcanaType type) {} // 0x00000001865DFB70-0x00000001865E1440
		private void SetGridActive() {} // 0x00000001865E1440-0x00000001865E1AB0
		private void AddAffectedWeapon(WeaponType weaponType) {} // 0x00000001865E1AB0-0x00000001865E1E70
		private void AddAffectedItem(VampireSurvivors.Data.ItemType itemType) {} // 0x00000001865E1E70-0x00000001865E2040
		private void GenerateImageForAffectedWeapon(Sprite weaponSprite, bool isOwned) {} // 0x00000001865E2040-0x00000001865E2460
		private void ClearAffectedWeapons() {} // 0x00000001865E2460-0x00000001865E2650
		private void LateUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	}
}
