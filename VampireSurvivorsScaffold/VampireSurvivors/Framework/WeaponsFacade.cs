/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Weapons;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class WeaponsFacade : IInitializable, IDisposable // TypeDefIndex: 17539
	{
		// Fields
		[Inject]
		private WeaponFactory _weaponFactory; // 0x10
		[Inject]
		private SignalBus _signalBus; // 0x18
		[Inject]
		private LevelUpFactory _levelUpFactory; // 0x20
		[Inject]
		private PlayerOptions _playerOptions; // 0x28
		[Inject]
		private ArcanaManager _arcanaManager; // 0x30
	
		// Constructors
		public WeaponsFacade() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public Weapon AddWeapon(WeaponType weaponType, CharacterController character, bool removeFromStore = true /* Metadata: 0x01978714 */) => default; // 0x0000000187354920-0x0000000187355000
		public Weapon CreateDetachedWeapon(WeaponType weaponType, CharacterController characterController) => default; // 0x0000000187355000-0x00000001873553C0
		public Weapon RemoveWeapon(WeaponType weaponType, CharacterController characterController, bool notifyRemove = true /* Metadata: 0x01978715 */) => default; // 0x00000001873553C0-0x0000000187355650
		public Equipment RemoveEquipment(WeaponType weaponType, CharacterController characterController, bool notifyRemove = true /* Metadata: 0x01978716 */) => default; // 0x0000000187355650-0x00000001873559F0
		public Weapon AddHiddenWeapon(WeaponType weaponType, CharacterController characterController, bool removeFromStore = true /* Metadata: 0x01978717 */, bool allowDuplicates = false /* Metadata: 0x01978718 */) => default; // 0x00000001873559F0-0x00000001873560C0
		public void RemoveHiddenWeapon(WeaponType weaponType, CharacterController characterController) {} // 0x00000001873560C0-0x0000000187356490
		public void RemoveThisHiddenWeapon(Weapon weapon, CharacterController characterController) {} // 0x0000000187356490-0x00000001873565E0
	}
}
