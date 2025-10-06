/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class C1_Impostor : CharacterController // TypeDefIndex: 17003
	{
		// Fields
		private bool _hasSecondAnim; // 0x3F0
		private float _mightBonus; // 0x3F4
		private float _moveBonus; // 0x3F8
		private float _cooldownBonus; // 0x3FC
		private float _morphDuration; // 0x400
		private int _morphedTimes; // 0x404
		private int _finalMorphedTimes; // 0x408
		private SpriteRenderer _sparkSprite; // 0x410
		private SpriteRenderer _ringSprite; // 0x418
		private MultiTargetTween _ringTween; // 0x420
		private MultiTargetTween _sparkTween; // 0x428
		private SpriteRenderer _burstSprite; // 0x430
		private SpriteRenderer _darkSprite; // 0x438
		private MultiTargetTween _darkTween; // 0x440
		private int[] _thresholds; // 0x448
		private int _finalThreshold; // 0x450
		private bool _isMorphed; // 0x454
		private int _enemiesTs; // 0x458
		private MorphVFX _morphVFX; // 0x460
		private List<Weapon> hiddenTongues; // 0x468
		private bool hasBonusesApplied; // 0x470
		private float _originalMoveSpeed; // 0x474
	
		// Constructors
		public C1_Impostor() {} // 0x0000000187145620-0x0000000187145710
	
		// Methods
		private void CalculateTreshold() {} // 0x0000000187144130-0x00000001871441A0
		protected override void OnUpdate() {} // 0x00000001871441A0-0x0000000187144370
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FC3 */) {} // 0x0000000187144370-0x0000000187144490
		[Command]
		public void Morph() {} // 0x0000000187144490-0x0000000187144F20
		private void Unmorph() {} // 0x0000000187144F20-0x0000000187145370
		public void MakeMorphVFX() {} // 0x0000000187145370-0x0000000187145620
	}
}
