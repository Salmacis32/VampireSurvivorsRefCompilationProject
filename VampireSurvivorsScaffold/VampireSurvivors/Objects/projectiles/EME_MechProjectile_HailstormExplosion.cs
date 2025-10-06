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
	public class EME_MechProjectile_HailstormExplosion : Projectile // TypeDefIndex: 15817
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundVFX; // 0xD0
		private const float Radius = 60f; // Metadata: 0x019778AC
		private const float VFXScale = 0.8f; // Metadata: 0x019778B0
		private Tween _tween; // 0xD8
	
		// Constructors
		public EME_MechProjectile_HailstormExplosion() {} // 0x0000000186DD1A80-0x0000000186DD1AD0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DD0E90-0x0000000186DD16C0
		private void LateUpdate() {} // 0x0000000186C16150-0x0000000186C16170
		private void FadeOut() {} // 0x0000000186DD16C0-0x0000000186DD18C0
		private void PlaySfx() {} // 0x0000000186DD18C0-0x0000000186DD19F0
		public override void Despawn() {} // 0x0000000186C80530-0x0000000186C80560
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DD19F0-0x0000000186DD1A80
	}
}
