/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public abstract class Equipment : GameMonoBehaviour // TypeDefIndex: 15077
	{
		// Fields
		protected DataManager _dataManager; // 0x28
		protected JObject _currentJsonDataObject; // 0x30
		protected SignalBus _signalBus; // 0x38
		protected LevelUpFactory _levelUpFactory; // 0x40
		private WeaponType _equipmentType; // 0x48
	
		// Properties
		public int Level { get; set; } // 0x00000001819A01C0-0x00000001819A01D0 0x000000018395D5B0-0x000000018395D5C0
		public int LevelsNumber { get; set; } // 0x0000000180B15770-0x0000000180B15780 0x0000000182621130-0x0000000182621140
		public WeaponType Type { get; protected set; } // 0x00000001819A01B0-0x00000001819A01C0 0x00000001828975D0-0x00000001828975E0
		public CharacterController Owner { get; set; } // 0x0000000180B15730-0x0000000180B15740 0x00000001826E9730-0x00000001826E9790
		public bool ShowInRecap { get; set; } // 0x000000018289FD40-0x000000018289FD50 0x0000000184EC0B20-0x0000000184EC0B30
	
		// Constructors
		protected Equipment() {} // 0x00000001869ED550-0x00000001869ED5A0
	
		// Methods
		protected virtual void FakeConstruct() {} // 0x00000001869ECF40-0x00000001869ED0E0
		public virtual bool IsPowerup() => default; // 0x0000000181958370-0x0000000181958380
		public virtual void Cleanup() {} // 0x0000000180B15170-0x0000000180B15180
		public abstract bool LevelUp(bool skipFire = false /* Metadata: 0x019772E9 */);
		public abstract void CheckArcanas();
		public abstract void InternalUpdate();
		protected abstract Dictionary<WeaponType, JArray> GetDataDictionary();
		protected abstract void MakeLevelOne();
		protected virtual bool GetDataForLevel(WeaponType type, int level, out JObject newLevelData, bool upgradeExistingData = true /* Metadata: 0x019772EA */) {
			newLevelData = default;
			return default;
		} // 0x00000001869ED0E0-0x00000001869ED310
		public bool IsMaxLevel() => default; // 0x00000001869ED310-0x00000001869ED3E0
		public bool IsEvolution() => default; // 0x00000001869ED3E0-0x00000001869ED440
		public int GetLevelsNumber() => default; // 0x00000001869ED440-0x00000001869ED4D0
		private void EditorPrintDataAsJson() {} // 0x00000001869ED4D0-0x00000001869ED550
	}
}
