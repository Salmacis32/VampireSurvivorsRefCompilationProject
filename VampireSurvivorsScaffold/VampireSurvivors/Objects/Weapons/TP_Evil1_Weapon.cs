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
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Evil1_Weapon : Weapon // TypeDefIndex: 16355
	{
		// Fields
		private bool _initialisedParticles; // 0x159
		private PhaserSprite _cursor; // 0x160
		private bool _lockCursor; // 0x168
		private EnemyController _lockOnTarget; // 0x170
		[SerializeField]
		private Projectile _skullPrefab; // 0x178
		private BulletPool _skullPool; // 0x180
		[NonSerialized]
		public static float staticTotalTime; // 0x00
		protected WeaponType _counterWeaponType; // 0x188
		protected Weapon _counterWeapon; // 0x190
		protected SantaJavelinCounterWeapon _counterSet; // 0x198
		protected bool _hasCounterSet; // 0x1A0
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
		public bool CanFireNormally { get; set; } // 0x0000000184F54D70-0x0000000184F54D80 0x000000018675C9B0-0x000000018675C9C0
	
		// Constructors
		public TP_Evil1_Weapon() {} // 0x0000000186FB4070-0x0000000186FB40D0
	
		// Methods
		public override float PPower() => default; // 0x0000000186FB2810-0x0000000186FB28D0
		protected override void Awake() {} // 0x0000000186FB28D0-0x0000000186FB2C80
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FB2C80-0x0000000186FB2D60
		public override void InternalUpdate() {} // 0x0000000186FB2D60-0x0000000186FB3100
		public override void OnMirrorData(Vector2 position) {} // 0x0000000186FB3100-0x0000000186FB3210
		protected float CalcRadAngle(float x1, float y1, float x2, float y2) => default; // 0x0000000186F36730-0x0000000186F36750
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C69 */) {} // 0x0000000186FB3210-0x0000000186FB3460
		public void FireSkull(Vector2 pos) {} // 0x0000000186FB3460-0x0000000186FB34A0
		public void FireProjectiles(Vector2 pos, float direction) {} // 0x0000000186FB34A0-0x0000000186FB3830
		protected void Fire_FireCounter(bool skipTriggers = false /* Metadata: 0x01977C6A */) {} // 0x0000000186FB3830-0x0000000186FB3940
		public override bool LevelUp() => default; // 0x0000000186FB3940-0x0000000186FB3A60
		public override void CheckArcanas() {} // 0x0000000186FB3A60-0x0000000186FB3ED0
		protected bool OnSkullOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FB3ED0-0x0000000186FB4070
		public override void SetVisible(bool visible) {} // 0x0000000186FA7E20-0x0000000186FA7E50
	}
}
