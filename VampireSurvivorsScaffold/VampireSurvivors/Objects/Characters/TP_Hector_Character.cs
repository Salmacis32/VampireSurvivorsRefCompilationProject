/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Hector_Character : CharacterController // TypeDefIndex: 17070
	{
		// Fields
		private List<VampireSurvivors.Data.CharacterType> possibleFollowers; // 0x3F0
		private List<VampireSurvivors.Data.CharacterType> currentFollowers; // 0x3F8
	
		// Constructors
		public TP_Hector_Character() {} // 0x0000000187168220-0x00000001871685E0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FFD */) {} // 0x0000000187167C50-0x0000000187167C70
		public override WeaponType GetFourthLevelUpOption() => default; // 0x0000000187167C70-0x0000000187167D20
		public override void AfterFullInitialization() {} // 0x0000000187167D20-0x0000000187167E10
		public override void LevelUp() {} // 0x0000000187167E10-0x0000000187167EF0
		private void AddRandomFollower() {} // 0x0000000187167EF0-0x0000000187168220
	}
}
