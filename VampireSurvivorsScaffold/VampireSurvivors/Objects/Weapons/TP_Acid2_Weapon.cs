/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Acid2_Weapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16267
	{
		// Fields
		private IDamageable _targetDamagable; // 0x160
		private bool _hasGemini; // 0x168
		private TP_Acid1_Weapon _acid1Weapon; // 0x170
		private PhaserSprite _cursor; // 0x178
		private float _cursorAngle; // 0x180
		private float _angleUnit; // 0x184
		private float _targetAngle; // 0x188
		private float _mul; // 0x18C
		private bool _cooldownAffectedByMovement; // 0x190
		private bool _isStandalone; // 0x191
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public virtual float PlayerFacing { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
		private PhaserSprite CursorToUse1 { get => default; } // 0x0000000186F83540-0x0000000186F83580 
		private PhaserSprite CursorToUse2 { get => default; } // 0x0000000186F83580-0x0000000186F835C0 
	
		// Constructors
		public TP_Acid2_Weapon() {} // 0x0000000186F85BA0-0x0000000186F85C10
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F835C0-0x0000000186F83BF0
		public override void InternalUpdate() {} // 0x0000000186F83BF0-0x0000000186F849D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F849D0-0x0000000186F84BE0
		private void UpdateTargeting() {} // 0x0000000186F84BE0-0x0000000186F85110
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BF1 */) {} // 0x0000000186F85110-0x0000000186F852B0
		public void FireProjectiles(Vector2 pos) {} // 0x0000000186F852B0-0x0000000186F85620
		public override void CheckArcanas() {} // 0x0000000186F85620-0x0000000186F85790
		private float Approach(float start, float end, float shift) => default; // 0x0000000186BD8F50-0x0000000186BD8F70
		private void DisplayCursorVFX(int _times, float _duration) {} // 0x0000000186F85790-0x0000000186F85A00
		public override void SetVisible(bool visible) {} // 0x0000000186F85A00-0x0000000186F85BA0
	}
}
