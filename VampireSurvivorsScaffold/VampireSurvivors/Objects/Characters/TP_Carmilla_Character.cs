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
	public class TP_Carmilla_Character : TP_Character // TypeDefIndex: 17038
	{
		// Fields
		[SerializeField]
		private Image _ChargeBar; // 0x3F0
		[SerializeField]
		private Image _ChargeBarFill; // 0x3F8
		private bool _isCharging; // 0x400
		private float _chargeTime; // 0x404
		private float _maxChargeTimeMS; // 0x408
		private List<WeaponType> spells; // 0x410
		private PhaserSprite _cursor1; // 0x418
		private PhaserSprite _cursor2; // 0x420
		private MultiTargetTween _angle1Tween; // 0x428
		private MultiTargetTween _angle2Tween; // 0x430
		private MultiTargetTween _scaleTween; // 0x438
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Carmilla_Character() {} // 0x00000001871542C0-0x0000000187154510
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187152BB0-0x0000000187153710
		private void FireAllSpells() {} // 0x0000000187153710-0x0000000187153CC0
		protected override void OnUpdate() {} // 0x0000000187153CC0-0x0000000187153FE0
		private void HideCharge() {} // 0x0000000187153FE0-0x0000000187154150
		private void ShowCharge() {} // 0x0000000187154150-0x00000001871542C0
		protected override void OnStop() {} // 0x00000001871084A0-0x00000001871084D0
		public override bool ShouldCollideWithWalls() => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}
