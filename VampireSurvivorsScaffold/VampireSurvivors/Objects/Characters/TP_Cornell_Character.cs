/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Cornell_Character : TP_Character // TypeDefIndex: 17050
	{
		// Fields
		private float _amountBonus; // 0x3F0
		private float _armorBonus; // 0x3F4
		private float _maxHpBonus; // 0x3F8
		private float _moveSpeedBonus; // 0x3FC
		private MorphVFX _morphVFX; // 0x400
		private bool _isMorphed; // 0x408
	
		// Constructors
		public TP_Cornell_Character() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		public override void OnWeaponMadeLevelOne(WeaponType type) {} // 0x0000000187159E60-0x0000000187159E70
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FE8 */) {} // 0x0000000187159E70-0x0000000187159ED0
		public override WeaponType GetFourthLevelUpOption() => default; // 0x0000000187159ED0-0x000000018715A8A0
		private void MakeMorphVFX() {} // 0x000000018715A8A0-0x000000018715AB50
		private void Morph() {} // 0x000000018715AB50-0x000000018715B2E0
	}
}
