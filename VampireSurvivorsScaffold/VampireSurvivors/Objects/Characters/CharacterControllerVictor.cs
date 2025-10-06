/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerVictor : CharacterController // TypeDefIndex: 16979
	{
		// Fields
		private float _armorBonus; // 0x3F0
		private float _armorDelay; // 0x3F4
		private float _armorTime; // 0x3F8
	
		// Constructors
		public CharacterControllerVictor() {} // 0x0000000187131020-0x0000000187131040
	
		// Methods
		public override float PArmor() => default; // 0x0000000187130C60-0x0000000187130D80
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F82 */) {} // 0x0000000187130D80-0x0000000187130DB0
		public override void OnGetDamaged(string hexColor = "#ff0000" /* Metadata: 0x01977F83 */, float vulnerabilityDelay = 120f /* Metadata: 0x01977F8B */, bool playDamageFx = true /* Metadata: 0x01977F8F */, bool playWeaponDamageFx = false /* Metadata: 0x01977F90 */) {} // 0x0000000187130DB0-0x0000000187130E20
		private void AddArmor() {} // 0x0000000187130E20-0x0000000187130E60
		protected override void OnUpdate() {} // 0x0000000187130E60-0x0000000187130EC0
		public override void LevelUp() {} // 0x0000000187130EC0-0x0000000187131020
	}
}
