/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Vento2Weapon : Weapon // TypeDefIndex: 16794
	{
		// Fields
		private BulletPool _extraPool; // 0x158
		private bool _generatedPools; // 0x160
		private VampireSurvivors.Framework.TimerSystem.Timer _healTimer; // 0x168
		private bool _canHeal; // 0x170
		private VampireSurvivors.Framework.TimerSystem.Timer _explodeTimer; // 0x178
		private bool _canExplode; // 0x180
		private float _walked; // 0x184
		private VampireSurvivors.Framework.TimerSystem.Timer _walkedTimer; // 0x188
		private float _pBonus; // 0x190
		private const float Mul = 166.66667f; // Metadata: 0x01977E4B
		private const float HealDelay = 500f; // Metadata: 0x01977E4F
		private const float ExplodeDelay = 500f; // Metadata: 0x01977E53
	
		// Constructors
		public Vento2Weapon() {} // 0x00000001870C60C0-0x00000001870C6120
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFC3A0-0x0000000186FFC3D0
		public override float PPower() => default; // 0x00000001870C4600-0x00000001870C4650
		public override void InternalUpdate() {} // 0x00000001870C4650-0x00000001870C4930
		public override void Cleanup() {} // 0x00000001870C4930-0x00000001870C49A0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x00000001870C49A0-0x00000001870C4D40
		protected override void OnStart() {} // 0x00000001870C4D40-0x00000001870C52D0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C52D0-0x00000001870C58F0
		protected bool OnExplosionOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C58F0-0x00000001870C5DB0
		public override void SetVisible(bool visible) {} // 0x00000001870C5DB0-0x00000001870C5F50
		public override void CheckArcanas() {} // 0x00000001870C5F50-0x00000001870C60C0
	}
}
