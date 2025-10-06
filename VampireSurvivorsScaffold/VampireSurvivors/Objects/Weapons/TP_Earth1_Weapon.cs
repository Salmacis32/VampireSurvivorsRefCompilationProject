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
	public class TP_Earth1_Weapon : Weapon // TypeDefIndex: 16331
	{
		// Fields
		private bool _initialisedParticles; // 0x159
		private PhaserSprite _cursor; // 0x160
		private float _topBarHeight; // 0x168
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x16C
		protected Weapon _counterWeapon; // 0x170
		protected SantaJavelinCounterWeapon _counterSet; // 0x178
		protected bool _hasCounterSet; // 0x180
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Earth1_Weapon() {} // 0x0000000186FA7E50-0x0000000186FA7EC0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FA6B50-0x0000000186FA6D20
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FA6D20-0x0000000186FA6DE0
		public override void InternalUpdate() {} // 0x0000000186FA6DE0-0x0000000186FA70A0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C5F */) {} // 0x0000000186FA70A0-0x0000000186FA71E0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FA71E0-0x0000000186FA74F0
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C60 */) {} // 0x0000000186FA74F0-0x0000000186FA7770
		public override bool LevelUp() => default; // 0x0000000186FA7770-0x0000000186FA7890
		public override void CheckArcanas() {} // 0x0000000186FA7890-0x0000000186FA7BB0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FA7BB0-0x0000000186FA7E20
		public override void SetVisible(bool visible) {} // 0x0000000186FA7E20-0x0000000186FA7E50
	}
}
