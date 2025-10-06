/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Signals;
using VampireSurvivors.UI;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class WeaponSelectionPage : BaseWeaponSelectionPage // TypeDefIndex: 14263
	{
		// Fields
		[SerializeField]
		private RectTransform _Container; // 0xE0
		[SerializeField]
		private GameObject _WeaponPrefab; // 0xE8
		[SerializeField]
		private RectTransform _Panel; // 0xF0
		[SerializeField]
		private RectTransform _SkipButton; // 0xF8
		[SerializeField]
		private SpriteReel _LeftBanner; // 0x100
		[SerializeField]
		private SpriteReel _RightBanner; // 0x108
		private PlayerOptions _playerOptions; // 0x110
		private DataManager _dataManager; // 0x118
		private SignalBus _signalBus; // 0x120
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x128
		private WeaponType _currentType; // 0x130
		private List<WeaponSelectionItemUI> _spawned; // 0x138
		private bool _hasSelected; // 0x140
		private VampireSurvivors.Objects.Characters.CharacterController _targetCharacter; // 0x148
	
		// Constructors
		public WeaponSelectionPage() {} // 0x0000000187043EE0-0x0000000187043FE0
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player, DataManager data, SignalBus signalBus) {} // 0x000000018703ECE0-0x000000018703F1B0
		private void OnWeaponSkippedRemotely() {} // 0x000000018703F1B0-0x000000018703F210
		private void OnWeaponSelectedRemotely(OnlineSignals.SelectCandyBoxWeapon weapon) {} // 0x000000018703F210-0x000000018703F310
		public override void SetSelected(WeaponSelectionItemUI item) {} // 0x000000018703F310-0x000000018703F330
		public override void SelectWeapon(WeaponSelectionItemUI item) {} // 0x000000018703F330-0x000000018703F4C0
		public void Skip() {} // 0x000000018703F4C0-0x000000018703F660
		protected override void OnShowStart(GameObject g) {} // 0x000000018703F660-0x000000018703FD40
		protected override VampireSurvivors.Objects.Characters.CharacterController GetCharacterControllingUi() => default; // 0x0000000184F54FC0-0x0000000184F54FD0
		private void ExecuteSkip() {} // 0x000000018703F1B0-0x000000018703F210
		private void ExecuteWeaponSelection(WeaponType weapon) {} // 0x000000018703FD40-0x00000001870400F0
		private void GetBaseWeapons(List<WeaponType> weaponList = null) {} // 0x00000001870400F0-0x0000000187040C30
		private void GetPassiveWeapons() {} // 0x0000000187040C30-0x0000000187041470
		private void AddXifYisUnlocked(WeaponType x, WeaponType y, ref List<WeaponType> list) {} // 0x0000000187041470-0x0000000187041540
		private void GetEvolvedWeapons() {} // 0x0000000187041540-0x0000000187043670
		private void SelectFirst() {} // 0x0000000187043670-0x0000000187043730
		private void AddWeapon(WeaponType t, WeaponData d) {} // 0x0000000187043730-0x00000001870438C0
		private void Clear() {} // 0x00000001870438C0-0x0000000187043B80
		private void RemoveCandyBox() {} // 0x0000000187043B80-0x0000000187043CA0
		private void OnDestroy() {} // 0x0000000187043CA0-0x0000000187043EE0
	}
}
