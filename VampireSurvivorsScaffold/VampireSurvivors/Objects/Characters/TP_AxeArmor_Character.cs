/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_AxeArmor_Character : TP_Character // TypeDefIndex: 17034
	{
		// Fields
		private bool _canRetaliate; // 0x3F0
		private float _retaliationDelay; // 0x3F4
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimeout; // 0x3F8
	
		// Constructors
		public TP_AxeArmor_Character() {} // 0x0000000187129EA0-0x0000000187129EC0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018714FF90-0x000000018714FFA0
		public override void OnAttackAnim(Weapon.FiringAnimation firingAnimation) {} // 0x000000018714FFA0-0x0000000187150020
		public override void ClearFromSpecialAnims() {} // 0x0000000187150020-0x00000001871500D0
		public override void LevelUp() {} // 0x00000001871500D0-0x00000001871505E0
		public override void OnGetDamaged(string hexColor = "#ff0000" /* Metadata: 0x01977FD9 */, float vulnerabilityDelay = 120f /* Metadata: 0x01977FE1 */, bool playDamageFx = true /* Metadata: 0x01977FE5 */, bool playWeaponDamageFx = false /* Metadata: 0x01977FE6 */) {} // 0x00000001871505E0-0x0000000187150950
		public void ShowRings(int frames) {} // 0x0000000187150950-0x00000001871514E0
	}
}
