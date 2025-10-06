/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Wind1_Weapon : Weapon // TypeDefIndex: 16516
	{
		// Fields
		private bool _initialisedParticles; // 0x159
		private PhaserSprite _cursor; // 0x160
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x168
		protected Weapon _counterWeapon; // 0x170
		protected SantaJavelinCounterWeapon _counterSet; // 0x178
		protected bool _hasCounterSet; // 0x180
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Wind1_Weapon() {} // 0x0000000186FFE3B0-0x0000000186FFE410
	
		// Methods
		public override float PSpeed() => default; // 0x0000000186FFCDA0-0x0000000186FFCEF0
		protected override void Awake() {} // 0x0000000186FFCEF0-0x0000000186FFD0C0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFD0C0-0x0000000186FFD180
		public override void InternalUpdate() {} // 0x0000000186FFD180-0x0000000186FFD560
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D25 */) {} // 0x0000000186FFD560-0x0000000186FFD6A0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FFD6A0-0x0000000186FFDA30
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977D26 */) {} // 0x0000000186FFDA30-0x0000000186FFDCB0
		public override bool LevelUp() => default; // 0x0000000186FFDCB0-0x0000000186FFDDD0
		public override void CheckArcanas() {} // 0x0000000186FFDDD0-0x0000000186FFE0F0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FFE0F0-0x0000000186FFE3B0
		public override void SetVisible(bool visible) {} // 0x0000000186FA7E20-0x0000000186FA7E50
	}
}
