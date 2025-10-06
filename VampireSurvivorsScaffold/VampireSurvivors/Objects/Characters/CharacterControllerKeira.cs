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
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerKeira : CharacterController // TypeDefIndex: 16943
	{
		// Fields
		[SerializeField]
		private Image _HealthBar; // 0x3F0
		[SerializeField]
		private Image _HealthBarFill; // 0x3F8
		private bool _isCharging; // 0x400
		private float _chargeTime; // 0x404
		private float _maxChargeTimeMS; // 0x408
		private float _defaultChargeTimeMS; // 0x40C
		private Color ChargeColor; // 0x410
		private Color ReadyColor; // 0x420
		private List<WeaponType> spells; // 0x430
		private VampireSurvivors.Framework.TimerSystem.Timer nextTriggeredSkillTimer; // 0x438
	
		// Constructors
		public CharacterControllerKeira() {} // 0x0000000187110130-0x0000000187110340
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018710F200-0x000000018710F2E0
		private void HideCharge() {} // 0x000000018710F2E0-0x000000018710F480
		private void ShowCharge() {} // 0x000000018710F480-0x000000018710F620
		private void HighlightCharge() {} // 0x000000018710F620-0x000000018710F7C0
		protected override void OnUpdate() {} // 0x000000018710F7C0-0x000000018710FD80
		private void TriggerChargeSkill() {} // 0x000000018710FD80-0x000000018710FFD0
		public override void LevelUp() {} // 0x000000018710FFD0-0x0000000187110130
	}
}
