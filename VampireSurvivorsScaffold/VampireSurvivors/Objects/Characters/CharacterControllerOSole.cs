/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerOSole : CharacterControllerHalloween // TypeDefIndex: 16957
	{
		// Fields
		private float _amountBonus; // 0x3F0
		private float _armorBonus; // 0x3F4
		private float _maxHpBonus; // 0x3F8
		private MorphVFX _morphVFX; // 0x400
		private bool _isMorphed; // 0x408
		private Weapon _evolvedWeapon; // 0x410
		private PhaserSprite _sprCore; // 0x418
		private PhaserSprite _sprFlower; // 0x420
		private PhaserSprite _sprPond; // 0x428
		private PhaserSprite _sprSplash; // 0x430
		private PhaserSprite _sprGrass; // 0x438
	
		// Properties
		public bool IsMorphed { get => default; } // 0x0000000187120500-0x0000000187120510 
	
		// Constructors
		public CharacterControllerOSole() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000187120510-0x0000000187120620
		public override void LevelUp() {} // 0x0000000187120620-0x0000000187120780
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F47 */) {} // 0x0000000187120780-0x00000001871208C0
		private void MorphedOnStop() {} // 0x00000001871208C0-0x0000000187120900
		private void MakeMorphVFX() {} // 0x0000000187120900-0x0000000187120BB0
		protected override void OnStop() {} // 0x0000000187120BB0-0x0000000187120C00
		private void Morph() {} // 0x0000000187120C00-0x0000000187121230
		private void MakeSprites() {} // 0x0000000187121230-0x0000000187121AF0
		private void UpdateSprites() {} // 0x0000000187121AF0-0x0000000187121BE0
	}
}
