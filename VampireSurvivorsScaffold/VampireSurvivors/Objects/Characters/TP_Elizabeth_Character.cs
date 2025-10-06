/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Elizabeth_Character : TP_Character // TypeDefIndex: 17056
	{
		// Fields
		private MorphVFX _morphVFX; // 0x3F0
		private bool _isMorphed; // 0x3F8
		private bool _hasSecondAnim; // 0x3F9
		private float _mightBonus; // 0x3FC
		private float _cooldownBonus; // 0x400
		private float _morphDuration; // 0x404
		private int _morphedTimes; // 0x408
		private int _finalMorphedTimes; // 0x40C
		private int _finalThreshold; // 0x410
		private int _enemiesTs; // 0x414
		private bool hasBonusesApplied; // 0x418
		private int[] _thresholds; // 0x420
		private bool canMorph; // 0x428
		private List<Vector2> _cachedHeadOffsets; // 0x430
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Elizabeth_Character() {} // 0x0000000187163E00-0x0000000187163F70
	
		// Methods
		private void CalculateTreshold() {} // 0x0000000187162C80-0x0000000187162CF0
		protected override void OnUpdate() {} // 0x0000000187162CF0-0x0000000187162EC0
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FED */) {} // 0x0000000187162EC0-0x0000000187163190
		[Command]
		public void Morph() {} // 0x0000000187163190-0x00000001871638A0
		private void Unmorph() {} // 0x00000001871638A0-0x0000000187163B50
		public void MakeMorphVFX() {} // 0x0000000187163B50-0x0000000187163E00
	}
}
