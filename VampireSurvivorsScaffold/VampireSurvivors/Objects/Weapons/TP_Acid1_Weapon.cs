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
	public class TP_Acid1_Weapon : Weapon // TypeDefIndex: 16262
	{
		// Fields
		private bool _initialisedParticles; // 0x159
		private float _cursorAngle; // 0x15C
		private float _angleUnit; // 0x160
		private float _targetAngle; // 0x164
		private float _mul; // 0x168
		private bool _cooldownAffectedByMovement; // 0x16C
		public PhaserSprite _cursor; // 0x170
		public PhaserSprite GeminiCursor; // 0x178
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x180
		protected Weapon _counterWeapon; // 0x188
		protected SantaJavelinCounterWeapon _counterSet; // 0x190
		protected bool _hasCounterSet; // 0x198
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Acid1_Weapon() {} // 0x0000000186F83120-0x0000000186F831A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186F81AC0-0x0000000186F81CF0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F81CF0-0x0000000186F81DB0
		public override void InternalUpdate() {} // 0x0000000186F81DB0-0x0000000186F82260
		private float Approach(float start, float end, float shift) => default; // 0x0000000186BD8F50-0x0000000186BD8F70
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BEF */) {} // 0x0000000186F82260-0x0000000186F823A0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186F823A0-0x0000000186F82710
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977BF0 */) {} // 0x0000000186F82710-0x0000000186F82990
		public override bool LevelUp() => default; // 0x0000000186F82990-0x0000000186F82AB0
		public override void CheckArcanas() {} // 0x0000000186F82AB0-0x0000000186F82E80
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186F82E80-0x0000000186F830F0
		public override void SetVisible(bool visible) {} // 0x0000000186F830F0-0x0000000186F83120
	}
}
