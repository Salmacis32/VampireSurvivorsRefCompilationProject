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
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BoneGiantWeapon : BoneWeapon // TypeDefIndex: 16142
	{
		// Fields
		private float2 _headOffset; // 0x158
		private float2 _inv_headOffset; // 0x160
		private float2 _haloOffset; // 0x168
		private float2 _inv_haloOffset; // 0x170
		private float2 _inv_frontOffset; // 0x178
		private float2 _inv_backOffset; // 0x180
		private float2 _frontOffset; // 0x188
		private float2 _backOffset; // 0x190
		private bool _hasSkeleton; // 0x198
		private bool _hasCharacterSkeleton; // 0x199
		private bool _areArmsAttached; // 0x19A
		private int _firedTimes; // 0x19C
		private int _secondaryFireCounter; // 0x1A0
		private BulletPool _giantArmPool; // 0x1A8
		private BoneGiantProjectile _frontArm; // 0x1B0
		private BoneGiantProjectile _backArm; // 0x1B8
		private PhaserSprite _head; // 0x1C0
		private PhaserSprite _torso; // 0x1C8
		private MultiTargetTween _armsSpinTween; // 0x1D0
		private MultiTargetTween _armsSpinTween2; // 0x1D8
		private bool _isAttacking; // 0x1E0
		private PhaserSprite _halo; // 0x1E8
	
		// Constructors
		public BoneGiantWeapon() {} // 0x0000000186F28910-0x0000000186F28A10
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F260D0-0x0000000186F26270
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B82 */) {} // 0x0000000186F26270-0x0000000186F26420
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F26420-0x0000000186F265F0
		public override void InternalUpdate() {} // 0x0000000186F265F0-0x0000000186F26630
		private void LateUpdate() {} // 0x0000000186F26630-0x0000000186F26650
		private void InitSkeleton() {} // 0x0000000186F26650-0x0000000186F275C0
		private void UpdateSkeleton() {} // 0x0000000186F275C0-0x0000000186F27BB0
		private void AttachArms() {} // 0x0000000186F27BB0-0x0000000186F27C80
		private void DetachArms() {} // 0x0000000186F27C80-0x0000000186F27E10
		private void SpinArms() {} // 0x0000000186F27E10-0x0000000186F27F80
		private bool OnGiantArmOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F27F80-0x0000000186F28180
		public override void SetVisible(bool visible) {} // 0x0000000186F28180-0x0000000186F28540
		public override void Cleanup() {} // 0x0000000186F28540-0x0000000186F28910
	}
}
