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
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Shanoa_Character : TP_Character // TypeDefIndex: 17115
	{
		// Fields
		private int meleeIndex; // 0x3F0
		[SerializeField]
		private Image _ChargeBar; // 0x3F8
		[SerializeField]
		private Image _ChargeBarFill; // 0x400
		private bool _isCharging; // 0x408
		private float _chargeTime; // 0x40C
		private float _maxChargeTimeMS; // 0x410
		private List<WeaponType> spells; // 0x418
		private PhaserSprite _cursor1; // 0x420
		private PhaserSprite _cursor2; // 0x428
		private MultiTargetTween _angle1Tween; // 0x430
		private MultiTargetTween _angle2Tween; // 0x438
		private MultiTargetTween _scaleTween; // 0x440
	
		// Constructors
		public TP_Shanoa_Character() {} // 0x0000000187178ED0-0x0000000187179870
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187177850-0x00000001871783B0
		private void HideCharge() {} // 0x00000001871783B0-0x0000000187178520
		private void ShowCharge() {} // 0x0000000187178520-0x0000000187178690
		protected override void OnUpdate() {} // 0x0000000187178690-0x0000000187178970
		private void FireAllSpells() {} // 0x0000000187178970-0x0000000187178CC0
		public override void OnAttackAnim(Weapon.FiringAnimation firingAnimation) {} // 0x0000000187178CC0-0x0000000187178D40
		public override void ClearFromSpecialAnims() {} // 0x0000000187178D40-0x0000000187178DF0
		public override void OnMeleeAttackAnim() {} // 0x0000000187178DF0-0x0000000187178ED0
	}
}
