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
	public class TP_Holy1_Weapon : Weapon // TypeDefIndex: 16382
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private string _cursorTexture; // 0x168
		private string _cursorSprite; // 0x170
		private Vector2 _cursorOffset; // 0x178
		private float _cursorMinAlpha; // 0x180
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x184
		protected Weapon _counterWeapon; // 0x188
		protected SantaJavelinCounterWeapon _counterSet; // 0x190
		protected bool _hasCounterSet; // 0x198
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Holy1_Weapon() {} // 0x0000000186FC6F50-0x0000000186FC70B0
	
		// Methods
		public override float PArea() => default; // 0x0000000186FC5D20-0x0000000186FC5D80
		protected override void Awake() {} // 0x0000000186FC5D80-0x0000000186FC5F40
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC5F40-0x0000000186FC6100
		public override void InternalUpdate() {} // 0x0000000186FC6100-0x0000000186FC62C0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C8E */) {} // 0x0000000186FC62C0-0x0000000186FC6570
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C8F */) {} // 0x0000000186FC6570-0x0000000186FC67F0
		public override bool LevelUp() => default; // 0x0000000186FC67F0-0x0000000186FC6910
		public override void CheckArcanas() {} // 0x0000000186FC6910-0x0000000186FC6C00
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FC6C00-0x0000000186FC6E50
		public override void SetVisible(bool visible) {} // 0x0000000186FC6E50-0x0000000186FC6F50
	}
}
