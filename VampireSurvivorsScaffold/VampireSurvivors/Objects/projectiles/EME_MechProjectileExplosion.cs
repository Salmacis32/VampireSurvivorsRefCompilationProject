/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_MechProjectileExplosion : Projectile // TypeDefIndex: 15812
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundVFX; // 0xD0
		private const float Radius = 48f; // Metadata: 0x0197788C
		private const float VFXScale = 0.8f; // Metadata: 0x01977890
		private Tween _tween; // 0xD8
		private bool _hasExploded; // 0xE0
	
		// Constructors
		public EME_MechProjectileExplosion() {} // 0x0000000186DCAEE0-0x0000000186DCAF30
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DCA270-0x0000000186DCAAA0
		private void LateUpdate() {} // 0x0000000186C16150-0x0000000186C16170
		private void FadeOut() {} // 0x0000000186DCAAA0-0x0000000186DCACA0
		private void PlaySfx() {} // 0x0000000186DCACA0-0x0000000186DCADD0
		public override void Despawn() {} // 0x0000000186C80530-0x0000000186C80560
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DCADD0-0x0000000186DCAEE0
	}
}
