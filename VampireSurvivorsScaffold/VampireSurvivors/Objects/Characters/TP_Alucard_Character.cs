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
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Alucard_Character : TP_Character // TypeDefIndex: 17031
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
		private float OverhealDelay; // 0x440
		private float OverhealTriggerValue; // 0x444
		private int _currentOverheal; // 0x448
		private int _maxOverheal; // 0x44C
		private VampireSurvivors.Framework.TimerSystem.Timer _overHealTimer; // 0x450
		private TP_SoulSteal_Weapon soulStealWeapon; // 0x458
		private TP_Dominus1_Weapon hellFireWeapon; // 0x460
		private TP_SummonSpirit_Weapon summonSpiritWeapon; // 0x468
		private TP_SwordBrothers_Weapon swordBrothersWeapon; // 0x470
		private bool _fullyInitialized; // 0x478
	
		// Properties
		public override bool DrainWeaponsImmunity { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Alucard_Character() {} // 0x000000018714FCE0-0x000000018714FE50
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018714DBD0-0x000000018714F070
		private void HideCharge() {} // 0x000000018714F070-0x000000018714F1E0
		private void ShowCharge() {} // 0x000000018714F1E0-0x000000018714F350
		protected override void OnUpdate() {} // 0x000000018714F350-0x000000018714F650
		private void FireAllSpells() {} // 0x000000018714F650-0x000000018714F670
		private void SummonSpirit(float value, float rawValue) {} // 0x000000018714F670-0x000000018714F830
		public override void LevelUp() {} // 0x000000018714F830-0x000000018714FC20
		private void SwordBrothers() {} // 0x000000018714FC20-0x000000018714FC40
		public override void OnMeleeAttackAnim() {} // 0x000000018714FC40-0x000000018714FCE0
	}
}
