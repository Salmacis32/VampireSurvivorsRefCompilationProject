/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerSpaceDette : CharacterController // TypeDefIndex: 16975
	{
		// Fields
		private Phaser2Weapon StartingWeapon; // 0x3F0
		private float _baseWeaponPower; // 0x3F8
		private int _nextTreshold; // 0x3FC
		private int _extraFollowersAmount; // 0x400
		private int _maxFollowers; // 0x404
		private int[] _thresholds; // 0x408
		private int _finalThreshold; // 0x410
		private List<VampireSurvivors.Data.CharacterType> possibleFollowers; // 0x418
		private List<VampireSurvivors.Data.CharacterType> currentFollowers; // 0x420
	
		// Constructors
		public CharacterControllerSpaceDette() {} // 0x000000018712C6C0-0x000000018712C990
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018712BF00-0x000000018712C0D0
		private void CalculateTreshold() {} // 0x000000018712C0D0-0x000000018712C160
		protected override void OnUpdate() {} // 0x000000018712C160-0x000000018712C220
		public override void LevelUp() {} // 0x000000018712C220-0x000000018712C3B0
		private void AddRandomFollower() {} // 0x000000018712C3B0-0x000000018712C6C0
	}
}
