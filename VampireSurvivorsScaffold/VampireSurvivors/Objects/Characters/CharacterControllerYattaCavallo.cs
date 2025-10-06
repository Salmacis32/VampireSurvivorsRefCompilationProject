/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerYattaCavallo : CharacterControllerHalloween // TypeDefIndex: 16980
	{
		// Fields
		private float _amountBonus; // 0x3F0
		private float _armorBonus; // 0x3F4
		private float _maxHpBonus; // 0x3F8
		private float _luckBonus; // 0x3FC
		private MorphVFX _morphVFX; // 0x400
		private bool _isMorphed; // 0x408
		private CherryWeapon _cherryWeapon; // 0x410
	
		// Properties
		public bool IsMorphed { get => default; } // 0x0000000187120500-0x0000000187120510 
	
		// Constructors
		public CharacterControllerYattaCavallo() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override void LevelUp() {} // 0x0000000187131040-0x00000001871311A0
		protected override void OnUpdate() {} // 0x00000001871311A0-0x00000001871311E0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F91 */) {} // 0x00000001871311E0-0x0000000187131320
		private void MorphedOnStop() {} // 0x00000001871208C0-0x0000000187120900
		private void MakeMorphVFX() {} // 0x0000000187131320-0x00000001871315D0
		protected override void OnStop() {} // 0x0000000187120BB0-0x0000000187120C00
		private void Morph() {} // 0x00000001871315D0-0x00000001871320B0
	}
}
