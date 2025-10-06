/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_GrandCross2_Weapon : Weapon // TypeDefIndex: 16375
	{
		// Fields
		[SerializeField]
		private Projectile _BeamProjectilePrefab; // 0x158
		private const float BeamDamageMultiplier = 1.3f; // Metadata: 0x01977C83
		private bool _hasSprites; // 0x160
		private PhaserSprite _lightSprite; // 0x168
		private Rectangle _pfxRect; // 0x170
		private ParticleSystem _pfx; // 0x178
		private EmitZone _pfxEmitZone; // 0x180
		private BulletPool _beamProjectilePool; // 0x188
		private MultiTargetTween _alphaTween; // 0x190
		private MultiTargetTween _scaleTween; // 0x198
	
		// Properties
		public float BeamWidth { get => default; } // 0x0000000186FBF8D0-0x0000000186FBF8F0 
		public float BeamHeight { get => default; } // 0x0000000186FBF8F0-0x0000000186FBF910 
		public float2 BeamScale { get => default; } // 0x0000000186FBF910-0x0000000186FBFA00 
		public float2 BeamXExtents { get => default; } // 0x0000000186FBFA00-0x0000000186FBFA80 
	
		// Constructors
		public TP_GrandCross2_Weapon() {} // 0x0000000186FC14C0-0x0000000186FC1510
	
		// Methods
		protected override void OnStart() {} // 0x0000000186FBFA80-0x0000000186FBFD70
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FBFD70-0x0000000186FBFDB0
		private void InitSpritesAndPfx() {} // 0x0000000186FBFDB0-0x0000000186FC0AB0
		public override void InternalUpdate() {} // 0x0000000186FC0AB0-0x0000000186FC0B60
		private void UpdateLightSprite() {} // 0x0000000186FC0B60-0x0000000186FC0C00
		private void UpdatePfxEmitZone() {} // 0x0000000186FC0C00-0x0000000186FC0EA0
		public void TriggerBeam() {} // 0x0000000186FC0EA0-0x0000000186FC1110
		public override void CheckArcanas() {} // 0x0000000186FC1110-0x0000000186FC1270
		public override void SetVisible(bool visible) {} // 0x0000000186FC1270-0x0000000186FC12E0
		public override void Cleanup() {} // 0x0000000186FC12E0-0x0000000186FC1350
		private bool OnBulletOverlapsEnemy_Beam(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FC1350-0x0000000186FC14C0
	}
}
