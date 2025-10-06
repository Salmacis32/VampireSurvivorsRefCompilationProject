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
	public class NdujaProjectile : Projectile // TypeDefIndex: 15931
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _GroundFx; // 0xD0
		private ParticleEmitterManager _particleEmitterManager; // 0xD8
		private DG.Tweening.Sequence _scaleTween; // 0xE0
		private const float Radius = 16f; // Metadata: 0x01977970
		protected bool isPlayerFacing; // 0xE8
	
		// Constructors
		public NdujaProjectile() {} // 0x0000000186E4ECF0-0x0000000186E4ED50
	
		// Methods
		protected override void Awake() {} // 0x0000000186E4ED50-0x0000000186E4ED80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E4ED80-0x0000000186E4F8F0
		public override void InternalUpdate() {} // 0x0000000186E4F8F0-0x0000000186E4FAA0
		private void AssignRandomColorToGroundFx() {} // 0x0000000186E4FAA0-0x0000000186E4FCF0
		private void GenerateParticleSystems() {} // 0x0000000186E4FCF0-0x0000000186E50AE0
	}
}
