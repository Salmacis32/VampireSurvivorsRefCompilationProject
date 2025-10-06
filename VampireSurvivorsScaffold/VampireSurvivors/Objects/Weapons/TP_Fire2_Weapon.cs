/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Fire2_Weapon : Weapon // TypeDefIndex: 16366
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private PhaserSprite _cursor; // 0x160
		private string _cursorTexture; // 0x168
		private string _cursorSprite; // 0x170
		private bool _lockCursor; // 0x178
		private EnemyController _lockOnTarget; // 0x180
		private BulletPool _tailPool; // 0x188
		private bool _hasGemini; // 0x190
		private TP_Fire1_Weapon _fire1Weapon; // 0x198
		private float2 RotationDurationRange; // 0x1A0
		private float2 ForwardDurationRange; // 0x1A8
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public int TailAmount { get; set; } // 0x0000000186EDE2C0-0x0000000186EDE2D0 0x000000018613C470-0x000000018613C480
		public PhaserSprite Cursor { get => default; } // 0x00000001827668E0-0x00000001827668F0 
	
		// Constructors
		public TP_Fire2_Weapon() {} // 0x0000000186FB9B50-0x0000000186FB9CB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186FB7F40-0x0000000186FB80E0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB80E0-0x0000000186FB8570
		public override void InternalUpdate() {} // 0x0000000186FB8570-0x0000000186FB8A80
		public override void OnMirrorData(Vector2 position) {} // 0x0000000186FB3100-0x0000000186FB3210
		protected float CalcRadAngle(float x1, float y1, float x2, float y2) => default; // 0x0000000186F36730-0x0000000186F36750
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C6E */) {} // 0x0000000186FB8A80-0x0000000186FB8BB0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186FB8BB0-0x0000000186FB92B0
		public override void CheckArcanas() {} // 0x0000000186FB92B0-0x0000000186FB9450
		public Projectile SpawnTailProjectile(float2 pos, int index) => default; // 0x0000000186FB9450-0x0000000186FB97A0
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186FB97A0-0x0000000186FB99F0
		public override void SetVisible(bool visible) {} // 0x0000000186FB99F0-0x0000000186FB9B20
		public override void Cleanup() {} // 0x0000000186FB9B20-0x0000000186FB9B50
	}
}
