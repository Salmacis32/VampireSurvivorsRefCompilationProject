/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Dracula_Character : TP_Character // TypeDefIndex: 17055
	{
		// Fields
		private float _armorBonus; // 0x3F0
		private float _cooldownBonus; // 0x3F4
		private float _moveSpeedBonus; // 0x3F8
		private float _mightBonus; // 0x3FC
		private MorphVFX _morphVFX; // 0x400
		private bool _isMorphed; // 0x408
		private List<PhaserSprite> _megaloSprites; // 0x410
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Dracula_Character() {} // 0x0000000187162BB0-0x0000000187162C80
	
		// Methods
		public override float PPower() => default; // 0x00000001871605E0-0x0000000187160700
		public override void AfterFullInitialization() {} // 0x0000000187160700-0x0000000187160740
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FEB */) {} // 0x0000000187160740-0x0000000187160790
		public override void LevelUp() {} // 0x0000000187160790-0x0000000187160990
		public void Morph(bool addBonusStats = true /* Metadata: 0x01977FEC */) {} // 0x0000000187160990-0x0000000187160EC0
		private void CleanupMegaloSprites() {} // 0x0000000187160EC0-0x0000000187161180
		protected override void OnUpdate() {} // 0x0000000187161180-0x0000000187161190
		private void LateUpdate() {} // 0x0000000187161190-0x00000001871611A0
		private void MakeMorphVFX() {} // 0x00000001871611A0-0x0000000187161450
		private void CreateMegaloDraculaSprites() {} // 0x0000000187161450-0x0000000187162360
		private void UpdateMegaloDraculaSprites() {} // 0x0000000187162360-0x0000000187162A40
		public override void SetExtraVisualsVisible(bool show) {} // 0x0000000187162A40-0x0000000187162BB0
	}
}
