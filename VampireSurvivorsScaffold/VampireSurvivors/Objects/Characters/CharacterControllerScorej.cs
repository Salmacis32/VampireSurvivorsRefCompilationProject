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
	public class CharacterControllerScorej : CharacterController // TypeDefIndex: 16971
	{
		// Fields
		private bool _canRetaliate; // 0x3F0
		private float _retaliationDelay; // 0x3F4
		private VampireSurvivors.Framework.TimerSystem.Timer _retaliationTimeout; // 0x3F8
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerScorej() {} // 0x0000000187129EA0-0x0000000187129EC0
	
		// Methods
		public override void LevelUp() {} // 0x0000000187128A70-0x0000000187128FA0
		public override void OnGetDamaged(string hexColor = "#ff0000" /* Metadata: 0x01977F64 */, float vulnerabilityDelay = 120f /* Metadata: 0x01977F6C */, bool playDamageFx = true /* Metadata: 0x01977F70 */, bool playWeaponDamageFx = false /* Metadata: 0x01977F71 */) {} // 0x0000000187128FA0-0x0000000187129310
		protected override void OnStop() {} // 0x0000000180B15170-0x0000000180B15180
		public void ShowRings(int frames) {} // 0x0000000187129310-0x0000000187129EA0
	}
}
