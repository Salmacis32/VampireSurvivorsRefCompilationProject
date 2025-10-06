/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class EME_CharacterController_CatFollower : CharacterController // TypeDefIndex: 17157
	{
		// Fields
		private List<WeaponType> hiddenWeaponTypes; // 0x3F0
		private WeaponType _chosenWeapon; // 0x3F8
		protected const string EmeraldsTextureName = "character_eme_witch"; // Metadata: 0x01978101
		[SerializeField]
		private bool _randomiseColour; // 0x3FC
		private float RingLevelUpEveyXLevels; // 0x400
		private List<Sprite> idleAnim; // 0x408
	
		// Constructors
		public EME_CharacterController_CatFollower() {} // 0x000000018718A480-0x000000018718A7E0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x00000001871898C0-0x0000000187189990
		public override void LevelUp() {} // 0x0000000187189990-0x0000000187189C50
		protected override void SetCharacterSprite() {} // 0x0000000187189C50-0x0000000187189F90
		protected override void SetupAnimation() {} // 0x0000000187189F90-0x000000018718A070
		protected override void AddAttackAnimations() {} // 0x000000018718A070-0x000000018718A1B0
		private List<Sprite> GetCatIdleAnimation() => default; // 0x000000018718A1B0-0x000000018718A3E0
		protected virtual VampireSurvivors.Data.ItemType GetCatType() => default; // 0x000000018718A3E0-0x000000018718A480
	}
}
