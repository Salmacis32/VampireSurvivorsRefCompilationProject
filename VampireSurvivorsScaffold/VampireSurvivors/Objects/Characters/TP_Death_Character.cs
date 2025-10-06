/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Death_Character : TP_Character // TypeDefIndex: 17053
	{
		// Fields
		private float _cooldownBonus; // 0x3F0
		private float _greedBonus; // 0x3F4
		private float _mightBonus; // 0x3F8
		private bool _isMorphed; // 0x3FC
		private PhaserSprite _sparkSprite; // 0x400
		private PhaserSprite _ringSprite; // 0x408
		private PhaserSprite _burstSprite; // 0x410
		private PhaserSprite _darkSprite; // 0x418
		private SpriteAnimation _burstSpriteAnim; // 0x420
		private MultiTargetTween _ringTween; // 0x428
		private MultiTargetTween _sparkTween; // 0x430
		private MultiTargetTween _darkTween; // 0x438
		private PhaserSprite _deathMask; // 0x440
		private PhaserSprite _deathSpine; // 0x448
		private PhaserSprite _deathCape; // 0x450
		private PhaserSprite _leftEye; // 0x458
		private PhaserSprite _rightEye; // 0x460
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Death_Character() {} // 0x0000000187107F90-0x0000000187107FA0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FE9 */) {} // 0x000000018715B570-0x000000018715B640
		public override void LevelUp() {} // 0x000000018715B640-0x000000018715B840
		public void Morph(bool addBonusStats = true /* Metadata: 0x01977FEA */) {} // 0x000000018715B840-0x000000018715BCD0
		protected override void OnUpdate() {} // 0x000000018715BCD0-0x000000018715BDF0
		public override void OnDeath() {} // 0x000000018715BDF0-0x000000018715C6A0
		private void SetupSparkle() {} // 0x000000018715C6A0-0x000000018715D460
		private void PlaySparkle() {} // 0x000000018715D460-0x000000018715DD00
		private void CreateMegaloDeathSprites() {} // 0x000000018715DD00-0x000000018715EA70
		private void UpdateMegaloDeathParts() {} // 0x000000018715EA70-0x000000018715F4E0
		private void UpdateEyes() {} // 0x000000018715F4E0-0x000000018715FBA0
	}
}
