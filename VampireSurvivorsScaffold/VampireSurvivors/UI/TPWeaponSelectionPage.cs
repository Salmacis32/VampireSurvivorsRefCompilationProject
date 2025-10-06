/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TPWeaponSelectionPage : BaseWeaponSelectionPage // TypeDefIndex: 15029
	{
		// Fields
		[Header("References")]
		[SerializeField]
		private Image _Background; // 0xE0
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xE8
		[SerializeField]
		private Image _Frame; // 0xF0
		[SerializeField]
		private GameObject _WeaponPrefab; // 0xF8
		[SerializeField]
		private Transform _SkipButton; // 0x100
		[SerializeField]
		private Image _Mask; // 0x108
		[SerializeField]
		private RectTransform _PanelRectTransform; // 0x110
		private List<WeaponType> _weaponList; // 0x118
		private List<GameObject> _spawned; // 0x120
		private WeaponSelectionItemUI _currentSelected; // 0x128
		private WeaponType _currentType; // 0x130
		private VampireSurvivors.Objects.Characters.CharacterController _targetCharacter; // 0x138
		private bool _hasSelected; // 0x140
		private DataManager _data; // 0x148
		private PlayerOptions _playerOptions; // 0x150
		private SignalBus _signalBus; // 0x158
		private List<WeaponType> _tpSpell; // 0x160
		private List<WeaponType> _tpSpell_Secret; // 0x168
		private List<WeaponType> _tpMelee; // 0x170
		private List<WeaponType> _tpMelee_Secret; // 0x178
		private List<WeaponType> _tpProjectile; // 0x180
		private List<WeaponType> _tpProjectile_Secret; // 0x188
		private List<WeaponType> _tpGlyph; // 0x190
		private List<WeaponType> _tpGlyph_Secret; // 0x198
		private List<WeaponType> _tpWhip; // 0x1A0
		private List<WeaponType> _tpFamiliars; // 0x1A8
		private List<WeaponType> _emeAllWeapons; // 0x1B0
	
		// Constructors
		public TPWeaponSelectionPage() {} // 0x00000001869BEE10-0x00000001869C0150
	
		// Methods
		[Inject]
		private void InjectData(DataManager data, PlayerOptions player, SignalBus signalBus) {} // 0x00000001869BAA20-0x00000001869BAFC0
		private void OnWeaponSkippedRemotely() {} // 0x00000001869BAFC0-0x00000001869BB010
		private void OnWeaponSelectedRemotely(OnlineSignals.SelectTPWeapon weapon) {} // 0x00000001869BB010-0x00000001869BB110
		protected override void OnShowStart(GameObject g) {} // 0x00000001869BB110-0x00000001869BB540
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000184F612E0-0x0000000184F612F0
		private void Clear() {} // 0x00000001869BB540-0x00000001869BB760
		public override void SetSelected(WeaponSelectionItemUI item) {} // 0x00000001869BB760-0x00000001869BB7F0
		private void Populate() {} // 0x00000001869BB7F0-0x00000001869BC400
		public override void SelectWeapon(WeaponSelectionItemUI item) {} // 0x00000001869BC400-0x00000001869BC590
		private void ExecuteWeaponSelection(WeaponType selected) {} // 0x00000001869BC590-0x00000001869BC940
		public void Skip() {} // 0x00000001869BC940-0x00000001869BCAD0
		private void ExecuteSkip() {} // 0x00000001869BAFC0-0x00000001869BB010
		private void SpawnWeapon(WeaponType t, WeaponData d) {} // 0x00000001869BCAD0-0x00000001869BCC10
		private void MakeSpellBookConfig() {} // 0x00000001869BCC10-0x00000001869BD110
		private void MakeCoatOfArmsConfig() {} // 0x00000001869BD110-0x00000001869BD610
		private void MakeMorningStarConfig() {} // 0x00000001869BD610-0x00000001869BD960
		private void MakeSpectralSwordConfig() {} // 0x00000001869BD960-0x00000001869BDE60
		private void MakeEbonyDialogueConfig() {} // 0x00000001869BDE60-0x00000001869BE360
		private void MakeFamiliarConfig() {} // 0x00000001869BE360-0x00000001869BEA70
		private void MakeEmeraldsConfig() {} // 0x00000001869BEA70-0x00000001869BEE10
	}
}
