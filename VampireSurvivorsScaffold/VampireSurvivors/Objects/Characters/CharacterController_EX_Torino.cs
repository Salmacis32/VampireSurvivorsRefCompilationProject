/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterController_EX_Torino : CharacterController // TypeDefIndex: 16989
	{
		// Fields
		private MorphVFX _morphVFX; // 0x3F0
		private Weapon _groundHitWeapon; // 0x3F8
		private bool _canRetaliate; // 0x400
		private int _morphLevel; // 0x404
		private List<WeaponType> _magicWeapons; // 0x408
	
		// Constructors
		public CharacterController_EX_Torino() {} // 0x000000018713B970-0x000000018713BC10
	
		// Methods
		private void SyncedMorph() {} // 0x000000018713A210-0x000000018713A370
		public override void LevelUp() {} // 0x000000018713A370-0x000000018713A4F0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FC0 */) {} // 0x000000018713A4F0-0x000000018713A7D0
		public override bool GetDamaged(float damageAmount) => default; // 0x000000018713A7D0-0x000000018713A910
		[Command]
		public void Morph() {} // 0x000000018713A910-0x000000018713B5F0
		private void MakeMorphVFX() {} // 0x000000018713B5F0-0x000000018713B8A0
		private void MorphToSecondForm() {} // 0x000000018713B8A0-0x000000018713B8C0
		private void MorphToThirdForm() {} // 0x000000018713B8C0-0x000000018713B8E0
		private void SetBodyOffset(float x, float y) {} // 0x000000018713B8E0-0x000000018713B970
	}
}
