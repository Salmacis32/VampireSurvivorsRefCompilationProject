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
	public class TP_Evil2_Weapon : Weapon // TypeDefIndex: 16358
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private bool _hasGemini; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer rainStopTimer; // 0x170
		private TP_Evil1_Weapon _baseWeapon; // 0x178
		private PhaserSprite _sDarkness; // 0x180
		public bool HasNightmare; // 0x188
		private float _radius; // 0x18C
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Evil2_Weapon() {} // 0x0000000186FB5E50-0x0000000186FB5EB0
	
		// Methods
		public override float PPower() => default; // 0x0000000186FB4280-0x0000000186FB4340
		protected override void Awake() {} // 0x0000000186FB4340-0x0000000186FB47C0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB47C0-0x0000000186FB4C50
		public override void InternalUpdate() {} // 0x0000000186FB4C50-0x0000000186FB5060
		protected float CalcRadAngle(float x1, float y1, float x2, float y2) => default; // 0x0000000186F36730-0x0000000186F36750
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C6B */) {} // 0x0000000186FB5060-0x0000000186FB5180
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FB5180-0x0000000186FB53C0
		public override void CheckArcanas() {} // 0x0000000186FB53C0-0x0000000186FB5530
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FB5530-0x0000000186FB57A0
		public override void SetVisible(bool visible) {} // 0x0000000186FB57A0-0x0000000186FB58D0
		private float Approach(float start, float end, float shift) => default; // 0x0000000186BD8F50-0x0000000186BD8F70
		private void NightmareCheck() {} // 0x0000000186FB58D0-0x0000000186FB5E10
		private bool IsCharacterInRange(Vector2 charPos, Vector2 projPos, float radiusSqrd) => default; // 0x0000000186FB5E10-0x0000000186FB5E50
	}
}
