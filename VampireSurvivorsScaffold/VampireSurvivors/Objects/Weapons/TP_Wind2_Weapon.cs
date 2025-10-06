/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Wind2_Weapon : Weapon // TypeDefIndex: 16525
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private bool _hasGemini; // 0x168
		private TP_Wind1_Weapon _wind1Weapon; // 0x170
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Wind2_Weapon() {} // 0x0000000186FFFE60-0x0000000186FFFEB0
	
		// Methods
		public override float PSpeed() => default; // 0x0000000186FFE960-0x0000000186FFEAB0
		protected override void Awake() {} // 0x0000000186FFEAB0-0x0000000186FFEC80
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFEC80-0x0000000186FFF110
		public override void InternalUpdate() {} // 0x0000000186FFF110-0x0000000186FFF400
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D27 */) {} // 0x0000000186FFF400-0x0000000186FFF4F0
		public void FireProjectiles() {} // 0x0000000186FFF4F0-0x0000000186FFFA00
		public override void CheckArcanas() {} // 0x0000000186FFFA00-0x0000000186FFFAC0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FFFAC0-0x0000000186FFFD30
		public override void SetVisible(bool visible) {} // 0x0000000186FFFD30-0x0000000186FFFE60
	}
}
