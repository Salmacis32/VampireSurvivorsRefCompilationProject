/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Jonhathan_Character : TP_Character // TypeDefIndex: 17080
	{
		// Fields
		[SerializeField]
		private Image _HealthBar; // 0x3F0
		[SerializeField]
		private Image _HealthBarFill; // 0x3F8
		private bool _isCharging; // 0x400
		private float _chargeTime; // 0x404
		private float _maxChargeTimeMS; // 0x408
		private List<WeaponType> spells; // 0x410
		private PhaserSprite _cursor1; // 0x418
		private PhaserSprite _cursor2; // 0x420
		private MultiTargetTween _angle1Tween; // 0x428
		private MultiTargetTween _angle2Tween; // 0x430
		private MultiTargetTween _scaleTween; // 0x438
	
		// Constructors
		public TP_Jonhathan_Character() {} // 0x000000018716BAF0-0x000000018716C7E0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018716A550-0x000000018716B0B0
		private void HideCharge() {} // 0x000000018716B0B0-0x000000018716B220
		private void ShowCharge() {} // 0x000000018716B220-0x000000018716B390
		protected override void OnUpdate() {} // 0x000000018716B390-0x000000018716B6B0
		private void FireAllSpells() {} // 0x000000018716B6B0-0x000000018716B9B0
		public override void OnMeleeAttackAnim() {} // 0x000000018716B9B0-0x000000018716BA50
		public override void OnRangedAttackAnim() {} // 0x000000018716BA50-0x000000018716BAF0
	}
}
