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
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class AccessoriesFacade : IInitializable, IDisposable // TypeDefIndex: 17431
	{
		// Fields
		[Inject]
		private AccessoriesFactory _accessoriesFactory; // 0x10
		[Inject]
		private SignalBus _signalBus; // 0x18
		[Inject]
		private LevelUpFactory _levelUpFactory; // 0x20
		[Inject]
		private PlayerOptions _playerOptions; // 0x28
		[Inject]
		private ArcanaManager _arcanaManager; // 0x30
	
		// Constructors
		public AccessoriesFacade() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x0000000180B15170-0x0000000180B15180
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public void AddAccessory(WeaponType accessoryType, CharacterController characterController, bool removeFromStore = true /* Metadata: 0x019785AB */) {} // 0x00000001872BF120-0x00000001872BF920
		public void RemoveAccessory(WeaponType accessoryType, CharacterController characterController, bool notifyRemove = true /* Metadata: 0x019785AC */) {} // 0x00000001872BF920-0x00000001872BFC60
	}
}
