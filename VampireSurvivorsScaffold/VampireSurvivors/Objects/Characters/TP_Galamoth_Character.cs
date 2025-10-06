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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Galamoth_Character : TP_Character // TypeDefIndex: 17066
	{
		// Fields
		private bool _canRetaliate; // 0x3F0
		private float _retaliationDelay; // 0x3F4
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimeout; // 0x3F8
	
		// Constructors
		public TP_Galamoth_Character() {} // 0x0000000187129EA0-0x0000000187129EC0
	
		// Methods
		protected override void MakeLevelOne(bool dontGetCharacterDataForCurrentLevel = false /* Metadata: 0x01977FEE */) {} // 0x00000001871654F0-0x0000000187165680
		public override void AfterFullInitialization() {} // 0x0000000187165680-0x00000001871656C0
		public override void LevelUp() {} // 0x00000001871656C0-0x0000000187165BF0
		public override void OnGetDamaged(string hexColor = "#ff0000" /* Metadata: 0x01977FEF */, float vulnerabilityDelay = 120f /* Metadata: 0x01977FF7 */, bool playDamageFx = true /* Metadata: 0x01977FFB */, bool playWeaponDamageFx = false /* Metadata: 0x01977FFC */) {} // 0x0000000187165BF0-0x0000000187165F60
		public void ShowRings(int frames) {} // 0x0000000187165F60-0x0000000187166AF0
	}
}
