/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	public class RewardManager // TypeDefIndex: 17519
	{
		// Fields
		[Inject]
		private DataManager _data; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private GameSessionData _session; // 0x20
		[Inject]
		private SignalBus _signalBus; // 0x28
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0x30
		private readonly List<WeaponType> _ownedWeapons; // 0x38
		private readonly List<WeaponType> _ownedAccessories; // 0x40
		private readonly List<WeaponType> _availableWeapons; // 0x48
		private readonly List<WeaponType> _availableAccessories; // 0x50
	
		// Constructors
		public RewardManager() {} // 0x0000000187346820-0x0000000187346AD0
	
		// Methods
		public List<Reward> GetLevelUpRewards(int amount) => default; // 0x0000000187345DB0-0x0000000187346820
	}
}
