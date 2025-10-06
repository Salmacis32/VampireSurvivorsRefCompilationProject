/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Quincy_Character : TP_Character // TypeDefIndex: 17108
	{
		// Fields
		private TP_Neutron_Weapon neutronWeapon; // 0x3F0
		[SerializeField]
		private Image _HealthBar; // 0x3F8
		[SerializeField]
		private Image _HealthBarFill; // 0x400
		private bool _isCharging; // 0x408
		private float _chargeTime; // 0x40C
		private float _maxChargeTimeMS; // 0x410
		private PhaserSprite _cursor1; // 0x418
		private PhaserSprite _cursor2; // 0x420
		private MultiTargetTween _angle1Tween; // 0x428
		private MultiTargetTween _angle2Tween; // 0x430
		private MultiTargetTween _scaleTween; // 0x438
	
		// Constructors
		public TP_Quincy_Character() {} // 0x0000000187175D30-0x0000000187175D50
	
		// Methods
		public override void AfterFullInitialization() {} // 0x0000000187174950-0x00000001871754B0
		private void HideCharge() {} // 0x00000001871754B0-0x0000000187175620
		private void ShowCharge() {} // 0x0000000187175620-0x0000000187175790
		protected override void OnUpdate() {} // 0x0000000187175790-0x0000000187175AB0
		private void FireAllSpells() {} // 0x0000000187175AB0-0x0000000187175D30
		public override void LevelUp() {} // 0x0000000187139FF0-0x000000018713A000
	}
}
