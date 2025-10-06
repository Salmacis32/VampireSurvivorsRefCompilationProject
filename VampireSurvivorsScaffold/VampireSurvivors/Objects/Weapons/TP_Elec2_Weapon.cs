/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Elec2_Weapon : Weapon // TypeDefIndex: 16348
	{
		// Fields
		private float _mul; // 0x158
		private bool _cooldownAffectedByMovement; // 0x15C
		private bool _initialisedParticles; // 0x15D
		private PhaserSprite _cursor; // 0x160
		private bool _hasGemini; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer rainStopTimer; // 0x170
		private TP_Elec1_Weapon _elec1Weapon; // 0x178
		private Vector2 _mirrorPos; // 0x180
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Elec2_Weapon() {} // 0x0000000186FAF3A0-0x0000000186FAF400
	
		// Methods
		protected override void Awake() {} // 0x0000000186FAE050-0x0000000186FAE210
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FAE210-0x0000000186FAE6A0
		public override void InternalUpdate() {} // 0x0000000186FAE6A0-0x0000000186FAE9A0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C64 */) {} // 0x0000000186FAE9A0-0x0000000186FAEAC0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FAEAC0-0x0000000186FAEE90
		public override void CheckArcanas() {} // 0x0000000186FAEE90-0x0000000186FAF000
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FAF000-0x0000000186FAF270
		public override void SetVisible(bool visible) {} // 0x0000000186FAF270-0x0000000186FAF3A0
	}
}
