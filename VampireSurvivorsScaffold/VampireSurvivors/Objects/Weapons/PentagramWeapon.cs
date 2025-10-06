/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class PentagramWeapon : Weapon // TypeDefIndex: 16748
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _WhiteDot; // 0x158
		public float _R; // 0x160
		public float _G; // 0x164
		public float _B; // 0x168
		public float _A; // 0x16C
		private MultiTargetTween _rgbTween; // 0x170
		private MultiTargetTween _alphaTween; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer _levelOneFireTimer; // 0x180
		private bool _restoreInitialFire; // 0x188
		private bool _canFlash; // 0x189
	
		// Properties
		public SpriteRenderer WhiteDot { get => default; } // 0x0000000184755AB0-0x0000000184755AC0 
		protected override bool UseOnlineTimer { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		public bool EraseItems { get; private set; } // 0x00000001870A4160-0x00000001870A4170 0x00000001870A4170-0x00000001870A4180
	
		// Constructors
		public PentagramWeapon() {} // 0x00000001870A5820-0x00000001870A5890
	
		// Methods
		public override float PInterval() => default; // 0x00000001870A4180-0x00000001870A41A0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870A41A0-0x00000001870A41F0
		public override void InternalUpdate() {} // 0x00000001870A41F0-0x00000001870A43B0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E13 */) {} // 0x00000001870A43B0-0x00000001870A4680
		public void FirePentagram(bool eraseItems, bool skipTriggers) {} // 0x00000001870A4680-0x00000001870A46A0
		private void PerformFire(bool skipTriggers) {} // 0x00000001870A46A0-0x00000001870A52E0
		private void MakeWhiteDot() {} // 0x00000001870A52E0-0x00000001870A55E0
		public override void SetVisible(bool visible) {} // 0x00000001870A55E0-0x00000001870A5690
		protected override void MakeLevelOne() {} // 0x00000001870A5690-0x00000001870A56B0
		private void RunInitialFire() {} // 0x00000001870A56B0-0x00000001870A5820
	}
}
