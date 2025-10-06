/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Savrog2Union_Weapon : Weapon // TypeDefIndex: 16465
	{
		// Fields
		[SerializeField]
		private Projectile _SpinningProjectilePrefab; // 0x158
		public Color[] _UnionSpriteColours; // 0x160
		public Color[] _UnionTrailColours; // 0x168
		private Vector2 radiusOffset90; // 0x170
		private PhaserSprite clone1; // 0x178
		private PhaserSprite clone2; // 0x180
		public uint[] _cloneTint; // 0x188
		private float _timeStopped; // 0x190
		private Vector2 _previousVector; // 0x194
		public Vector2 RadiusOffset; // 0x19C
		private BulletPool _spinningPool; // 0x1A8
		private const float Mul = 16.666666f; // Metadata: 0x01977CCC
		private ParticleEmitterManager _pfxManager; // 0x1B8
		private ParticleSystem _pfx; // 0x1C0
	
		// Properties
		public bool IsUnion { get; set; } // 0x0000000186FE6AE0-0x0000000186FE6AF0 0x0000000186ECCA40-0x0000000186ECCA50
	
		// Constructors
		public TP_Savrog2Union_Weapon() {} // 0x0000000186FEA090-0x0000000186FEA220
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FE6AF0-0x0000000186FE6DD0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FE6DD0-0x0000000186FE6E10
		private Vector2 Rotate45(Vector2 v) => default; // 0x0000000186FE6E10-0x0000000186FE6E50
		private Vector2 Rotate90(Vector2 v) => default; // 0x0000000186FE6E50-0x0000000186FE6E80
		public override void InternalUpdate() {} // 0x0000000186FE6E80-0x0000000186FE76E0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CCB */) {} // 0x0000000186FE76E0-0x0000000186FE8630
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FE8630-0x0000000186FE8820
		public override void CheckArcanas() {} // 0x0000000186FE8820-0x0000000186FE8B20
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FE8B20-0x0000000186FE8D70
		private void MakeOwnerClones() {} // 0x0000000186FE8D70-0x0000000186FE95C0
		private void GenerateParticleSystem() {} // 0x0000000186FE95C0-0x0000000186FEA030
		public override void SetVisible(bool visible) {} // 0x0000000186FEA030-0x0000000186FEA090
	}
}
