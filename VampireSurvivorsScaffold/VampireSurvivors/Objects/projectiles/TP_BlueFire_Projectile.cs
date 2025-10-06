/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_BlueFire_Projectile : Projectile // TypeDefIndex: 15506
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private ParticleEmitterManager _particleEmitterManager; // 0xD8
		private DG.Tweening.Sequence _scaleTween; // 0xE0
		private const float Radius = 8f; // Metadata: 0x01977683
	
		// Constructors
		public TP_BlueFire_Projectile() {} // 0x0000000186C6DAE0-0x0000000186C6DB30
	
		// Methods
		protected override void Awake() {} // 0x0000000186C6BD70-0x0000000186C6BE20
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C6BE20-0x0000000186C6C8E0
		public override void InternalUpdate() {} // 0x0000000186C6C8E0-0x0000000186C6CA90
		private void AssignRandomColorToGroundFx() {} // 0x0000000186C6CA90-0x0000000186C6CCE0
		private void GenerateParticleSystems() {} // 0x0000000186C6CCE0-0x0000000186C6DAE0
	}
}
