/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class Accessory : Equipment // TypeDefIndex: 15064
	{
		// Fields
		private ModifierStats _modifierStats; // 0x68
	
		// Properties
		public WeaponData CurrentAccessoryData { get; private set; } // 0x00000001826E99F0-0x00000001826E9A00 0x00000001826E9A00-0x00000001826E9A60
	
		// Constructors
		public Accessory() {} // 0x00000001869D4C80-0x00000001869D4D50
	
		// Methods
		public void Init(CharacterController characterController, WeaponType accessoryType) {} // 0x00000001869D3F20-0x00000001869D4030
		public virtual void OnAccessoryAddedToEquipment() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnAccessoryRemovedFromEquipment() {} // 0x0000000180B15170-0x0000000180B15180
		public void Apply() {} // 0x00000001869D4030-0x00000001869D43D0
		private void ApplyToCharacter(CharacterController character) {} // 0x00000001869D43D0-0x00000001869D44B0
		public override bool LevelUp(bool skipFire = false /* Metadata: 0x0197729B */) => default; // 0x00000001869D44B0-0x00000001869D46F0
		public override void Cleanup() {} // 0x0000000180B15170-0x0000000180B15180
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public override void CheckArcanas() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void MakeLevelOne() {} // 0x00000001869D46F0-0x00000001869D49A0
		protected override Dictionary<WeaponType, JArray> GetDataDictionary() => default; // 0x00000001869D49A0-0x00000001869D49C0
		private void CleanJsonModifierStats() {} // 0x00000001869D49C0-0x00000001869D4C80
	}
}
