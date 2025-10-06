/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerSyuuto : CharacterController // TypeDefIndex: 16977
	{
		// Fields
		private bool _hasSecondAnim; // 0x3F0
		private float _armorBonus; // 0x3F4
		private float _areaBonus; // 0x3F8
		private float _speedBonus; // 0x3FC
		private float _moveSpeedBonus; // 0x400
		private float _maxHpBonus; // 0x404
		private SpriteRenderer _sparkSprite; // 0x408
		private SpriteRenderer _ringSprite; // 0x410
		private MultiTargetTween _ringTween; // 0x418
		private MultiTargetTween _sparkTween; // 0x420
		private SpriteRenderer _burstSprite; // 0x428
		private SpriteRenderer _darkSprite; // 0x430
		private MultiTargetTween _darkTween; // 0x438
		private SpriteAnimation _burstAnim; // 0x440
		private bool _isMorphed; // 0x448
	
		// Constructors
		public CharacterControllerSyuuto() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F81 */) {} // 0x000000018712E1C0-0x000000018712E230
		private void MakeMorphVFX() {} // 0x000000018712E230-0x000000018712F150
		public override void AfterFullInitialization() {} // 0x000000018712F150-0x000000018712F330
		public override void LevelUp() {} // 0x000000018712F330-0x000000018712F470
		public override void OnWeaponMadeLevelOne(WeaponType type) {} // 0x000000018712F470-0x000000018712F480
		private void Morph() {} // 0x000000018712F480-0x000000018712FCE0
		private void PlaySparkle() {} // 0x000000018712FCE0-0x0000000187130650
	}
}
