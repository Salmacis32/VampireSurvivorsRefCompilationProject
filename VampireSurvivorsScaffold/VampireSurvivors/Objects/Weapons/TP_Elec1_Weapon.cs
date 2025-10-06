/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Elec1_Weapon : Weapon // TypeDefIndex: 16342
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private float _mul; // 0x168
		private bool _cooldownAffectedByMovement; // 0x16C
		private List<float2> _cursorOffsets; // 0x170
		private List<float> _cursorRotations; // 0x178
		private int _cursorActiveIndex; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _cursorResetTimer; // 0x188
		private VampireSurvivors.Framework.TimerSystem.Timer _explosionResetTimer; // 0x190
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x198
		protected Weapon _counterWeapon; // 0x1A0
		protected SantaJavelinCounterWeapon _counterSet; // 0x1A8
		protected bool _hasCounterSet; // 0x1B0
	
		// Properties
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F61610-0x0000000184F61620 0x0000000186FAB880-0x0000000186FAB890
	
		// Constructors
		public TP_Elec1_Weapon() {} // 0x0000000186FAD1B0-0x0000000186FAD3F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FAB890-0x0000000186FABAC0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FABAC0-0x0000000186FABFE0
		public override void InternalUpdate() {} // 0x0000000186FABFE0-0x0000000186FAC420
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C62 */) {} // 0x0000000186FAC420-0x0000000186FAC530
		public void FireProjectiles() {} // 0x0000000186FAC530-0x0000000186FAC900
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C63 */) {} // 0x0000000186FAC900-0x0000000186FACB80
		public override bool LevelUp() => default; // 0x0000000186FACB80-0x0000000186FACCA0
		public override void CheckArcanas() {} // 0x0000000186FACCA0-0x0000000186FACFC0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FACFC0-0x0000000186FAD160
		public override void SetVisible(bool visible) {} // 0x0000000186FA7E20-0x0000000186FA7E50
		public override void Cleanup() {} // 0x0000000186FAD160-0x0000000186FAD1B0
	}
}
