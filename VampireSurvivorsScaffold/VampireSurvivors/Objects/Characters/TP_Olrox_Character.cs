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
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Olrox_Character : TP_Character // TypeDefIndex: 17107
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
		private NdujaWeapon addedHiddenWeapon; // 0x430
		private List<Vector2> _cachedHeadOffsets; // 0x438
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Olrox_Character() {} // 0x00000001871727D0-0x00000001871728B0
	
		// Methods
		private void CalculateTreshold() {} // 0x0000000187162C80-0x0000000187162CF0
		protected override void OnUpdate() {} // 0x00000001871730B0-0x0000000187173340
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01978003 */) {} // 0x0000000187173340-0x0000000187173600
		public void PermanentMorph() {} // 0x0000000187173600-0x0000000187173A70
		[Command]
		public void Morph() {} // 0x0000000187173A70-0x0000000187174300
		private void Unmorph() {} // 0x0000000187174300-0x00000001871746A0
		public void MakeMorphVFX() {} // 0x00000001871746A0-0x0000000187174950
	}
}
