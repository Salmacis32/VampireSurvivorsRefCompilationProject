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
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Fire1_Weapon : Weapon // TypeDefIndex: 16363
	{
		// Fields
		private float GroundRadiusX; // 0x15C
		private float GroundRadiusY; // 0x160
		private bool _initialisedParticles; // 0x164
		private PhaserSprite _cursor; // 0x168
		private bool _lockCursor; // 0x170
		private EnemyController _lockOnTarget; // 0x178
		private bool _canLockOn; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _lockOnTimer; // 0x188
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x190
		protected Weapon _counterWeapon; // 0x198
		protected SantaJavelinCounterWeapon _counterSet; // 0x1A0
		protected bool _hasCounterSet; // 0x1A8
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Fire1_Weapon() {} // 0x0000000186FB7990-0x0000000186FB7A10
	
		// Methods
		protected override void Awake() {} // 0x0000000186FB5FC0-0x0000000186FB6190
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB6190-0x0000000186FB6270
		public override void InternalUpdate() {} // 0x0000000186FB6270-0x0000000186FB6760
		public override void OnMirrorData(Vector2 position) {} // 0x0000000186FB6760-0x0000000186FB6870
		protected float CalcRadAngle(float x1, float y1, float x2, float y2) => default; // 0x0000000186F36730-0x0000000186F36750
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C6C */) {} // 0x0000000186FB6870-0x0000000186FB6BB0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FB6BB0-0x0000000186FB6FF0
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C6D */) {} // 0x0000000186FB6FF0-0x0000000186FB70F0
		public override bool LevelUp() => default; // 0x0000000186FB70F0-0x0000000186FB7210
		public override void CheckArcanas() {} // 0x0000000186FB7210-0x0000000186FB76C0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FB76C0-0x0000000186FB7930
		public override void SetVisible(bool visible) {} // 0x0000000186FB7930-0x0000000186FB7960
		public override void Cleanup() {} // 0x0000000186FB7960-0x0000000186FB7990
	}
}
