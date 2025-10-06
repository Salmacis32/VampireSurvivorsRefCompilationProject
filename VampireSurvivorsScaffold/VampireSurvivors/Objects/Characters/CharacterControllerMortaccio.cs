/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerMortaccio : CharacterController // TypeDefIndex: 16954
	{
		// Fields
		private bool _isMorphed; // 0x3F0
		private int _amountBonus; // 0x3F4
		private int _armorBonus; // 0x3F8
		private int _maxHpBonus; // 0x3FC
		private PhaserSprite _sparkSprite; // 0x400
		private PhaserSprite _ringSprite; // 0x408
		private PhaserSprite _burstSprite; // 0x410
		private PhaserSprite _darkSprite; // 0x418
		private PhaserSprite _head; // 0x420
		private SpriteAnimation _burstSpriteAnim; // 0x428
		private SpriteAnimation _headSpriteAnim; // 0x430
		private MultiTargetTween _ringTween; // 0x438
		private MultiTargetTween _sparkTween; // 0x440
		private MultiTargetTween _darkTween; // 0x448
		private readonly float2 _headOffset; // 0x450
		private readonly float2 _invHeadOffset; // 0x458
		private bool _morphSpritesHidden; // 0x460
	
		// Properties
		public bool IsMorphed { get => default; } // 0x000000018711AA50-0x000000018711AA60 
	
		// Constructors
		public CharacterControllerMortaccio() {} // 0x000000018711D050-0x000000018711D080
	
		// Methods
		protected override void OnUpdate() {} // 0x000000018711AA60-0x000000018711AC90
		public override void LevelUp() {} // 0x000000018711AC90-0x000000018711ADF0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F3F */) {} // 0x000000018711ADF0-0x000000018711BBE0
		private void MakeBigSkeleton() {} // 0x000000018711BBE0-0x000000018711BF90
		private void Morph() {} // 0x000000018711BF90-0x000000018711C6E0
		private void PlaySparkle() {} // 0x000000018711C6E0-0x000000018711CF80
		public override void Revive(float percentage = 1f /* Metadata: 0x01977F40 */, bool instantRevival = false /* Metadata: 0x01977F44 */) {} // 0x000000018711CF80-0x000000018711CFD0
		public override void OnDeath() {} // 0x000000018711CFD0-0x000000018711D010
		public override void SetExtraVisualsVisible(bool show) {} // 0x000000018711D010-0x000000018711D050
	}
}
