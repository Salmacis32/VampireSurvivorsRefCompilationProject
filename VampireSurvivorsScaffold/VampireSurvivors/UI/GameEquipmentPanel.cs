/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Weapons;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameEquipmentPanel : MonoBehaviour // TypeDefIndex: 14783
	{
		// Fields
		private static Dictionary<VampireSurvivors.Objects.Characters.CharacterController, GameEquipmentPanel> _panels; // 0x00
		[SerializeField]
		private Image _CharacterImage; // 0x20
		[SerializeField]
		private Image _CharacterDeadImage; // 0x28
		[FormerlySerializedAs("_weaponPrefab")]
		[SerializeField]
		private GameObject _WeaponPrefab; // 0x30
		[FormerlySerializedAs("_weaponContainer")]
		[SerializeField]
		private RectTransform _WeaponContainer; // 0x38
		[FormerlySerializedAs("_accessoryPrefab")]
		[SerializeField]
		private GameObject _AccessoryPrefab; // 0x40
		[FormerlySerializedAs("_accessoryContainer")]
		[SerializeField]
		private RectTransform _AccessoryContainer; // 0x48
		private SignalBus _signalBus; // 0x50
		private PlayerOptions _playerOptions; // 0x58
		private DataManager _data; // 0x60
		private readonly List<GameEquipmentPanelItem> _spawnedWeaponSlots; // 0x68
		private readonly List<GameEquipmentPanelItem> _spawnedAccessorySlots; // 0x70
		private List<WeaponType> _extraWeapons; // 0x78
		private const int MaxAccessorySlots = 6; // Metadata: 0x0197720F
		private bool _shouldUpdateFormatting; // 0x80
		private VampireSurvivors.Data.CharacterType _character; // 0x84
		private VampireSurvivors.Objects.Characters.CharacterController _characterController; // 0x88
		private bool _showSprite; // 0x90
	
		// Constructors
		public GameEquipmentPanel() {} // 0x00000001868986A0-0x00000001868988A0
		static GameEquipmentPanel() {} // 0x00000001868988A0-0x0000000186898980
	
		// Methods
		[Inject]
		private void Construct(SignalBus signal, PlayerOptions playerOptions, DataManager dataManager) {} // 0x00000001867686B0-0x00000001867687B0
		private void OnDestroy() {} // 0x00000001868953D0-0x00000001868958E0
		private void Update() {} // 0x00000001868958E0-0x0000000186895950
		private void LateUpdate() {} // 0x0000000186895950-0x0000000186895B80
		public static void ClearPanels() {} // 0x0000000186895B80-0x0000000186895C00
		public void AddExtra(WeaponType weaponType) {} // 0x0000000186895C00-0x0000000186895CB0
		public List<WeaponType> GetExtraWeapons() => default; // 0x00000001819A0360-0x00000001819A0370
		public void Rebuild() {} // 0x0000000186895CB0-0x0000000186895CD0
		public void Initialize(VampireSurvivors.Objects.Characters.CharacterController characterController, bool showSprite) {} // 0x0000000186895CD0-0x0000000186896690
		private void OnEnable() {} // 0x0000000186896690-0x0000000186896740
		[IteratorStateMachine(typeof(_WaitAndFormat_d__28))]
		private IEnumerator WaitAndFormat() => default; // 0x0000000186896740-0x00000001868967E0
		private void Reset() {} // 0x00000001868967E0-0x0000000186896C10
		private void ClearWeaponSlots() {} // 0x0000000186896C10-0x0000000186896ED0
		private void ClearAccessorySlots() {} // 0x0000000186896ED0-0x0000000186897190
		private void CreateWeaponSlots() {} // 0x0000000186897190-0x0000000186897360
		private void RebuildWeaponSlots() {} // 0x0000000186897360-0x00000001868977F0
		[IteratorStateMachine(typeof(_WaitAndRebuild_d__34))]
		private IEnumerator WaitAndRebuild() => default; // 0x00000001868977F0-0x0000000186897890
		private void AddWeapon(GameplaySignals.WeaponAddedToCharacterSignal sig) {} // 0x0000000186897890-0x00000001868978B0
		private void OnCharacterRemovedWeapon(GameplaySignals.WeaponRemovedFromCharacterSignal sig) {} // 0x0000000186897890-0x00000001868978B0
		private void CreateAccessorySlots() {} // 0x00000001868978B0-0x0000000186897A30
		private void RebuildAccessorySlots() {} // 0x0000000186897A30-0x0000000186897F80
		private void AddAccessory(GameplaySignals.AccessoryAddedToCharacterSignal sig) {} // 0x0000000186897F80-0x0000000186897FC0
		private void OnCharacterRemovedAccessory(GameplaySignals.AccessoryRemovedFromCharacterSignal sig) {} // 0x0000000186897F80-0x0000000186897FC0
		public static GameEquipmentPanel GetPanelForCharacter(VampireSurvivors.Objects.Characters.CharacterController c) => default; // 0x0000000186897FC0-0x00000001868980B0
		public void BlockWeapon(Weapon weapon, bool blocked) {} // 0x00000001868980B0-0x00000001868982D0
		public void DisableWeaponIcon(Weapon weapon, bool disable) {} // 0x00000001868982D0-0x00000001868986A0
	}
}
