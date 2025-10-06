/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerMenya : CharacterController // TypeDefIndex: 16952
	{
		// Fields
		private bool _hasSecondAnim; // 0x3F0
		private float _mightBonus; // 0x3F4
		private float _moveBonus; // 0x3F8
		private float _cooldownBonus; // 0x3FC
		private float _curseBonus; // 0x400
		private float _morphDuration; // 0x404
		private int _morphedTimes; // 0x408
		private int _finalMorphedTimes; // 0x40C
		private SpriteRenderer _sparkSprite; // 0x410
		private SpriteRenderer _ringSprite; // 0x418
		private MultiTargetTween _ringTween; // 0x420
		private MultiTargetTween _sparkTween; // 0x428
		private SpriteRenderer _burstSprite; // 0x430
		private SpriteRenderer _darkSprite; // 0x438
		private MultiTargetTween _darkTween; // 0x440
		private SpriteAnimation _burstAnim; // 0x448
		private int[] _thresholds; // 0x450
		private int _finalThreshold; // 0x458
		private bool _isMorphed; // 0x45C
		private bool _hasBonusApplied; // 0x45D
		private int _enemiesTs; // 0x460
		private float _originalMoveSpeed; // 0x464
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerMenya() {} // 0x000000018711A0C0-0x000000018711A1B0
	
		// Methods
		private void CalculateTreshold() {} // 0x00000001871176A0-0x0000000187117710
		protected override void OnUpdate() {} // 0x0000000187117710-0x00000001871178B0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977F3B */) {} // 0x00000001871178B0-0x0000000187118840
		protected override void OnStop() {} // 0x00000001871084A0-0x00000001871084D0
		[Command]
		public void PerformOnlineMorph(long startingSimFrame) {} // 0x0000000187118840-0x0000000187118920
		private void Morph() {} // 0x0000000187118920-0x00000001871192B0
		private void Unmorph() {} // 0x00000001871192B0-0x0000000187119750
		private void PlaySparkle() {} // 0x0000000187119750-0x000000018711A0C0
	}
}
