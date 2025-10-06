/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_RapierProjectile_Shocking : Projectile // TypeDefIndex: 15840
	{
		// Fields
		[SerializeField]
		private MeshRenderer _Quad1; // 0xD0
		[SerializeField]
		private MeshRenderer _Quad2; // 0xD8
		private MultiTargetTween _tween; // 0xE0
		private MultiTargetTween _tween2; // 0xE8
		private EME_RapierWeapon _trueWeapon; // 0xF0
		private ParticleEmitterManager _pfxEmitterManager; // 0xF8
		private ParticleSystem _pfxEmitter; // 0x100
		private bool _initialisedParticles; // 0x108
		private PhaserSprite crystalSprite; // 0x110
		private bool isInitialised; // 0x118
		private PhaserSprite impactSprite; // 0x120
		private MultiTargetTween _tween3; // 0x128
		protected bool hasHit; // 0x130
		private static readonly int _AlphaMul; // 0x00
	
		// Properties
		protected uint _pfxTint { get => default; } // 0x0000000186DE2D50-0x0000000186DE2D60 
	
		// Constructors
		public EME_RapierProjectile_Shocking() {} // 0x0000000186DE4D30-0x0000000186DE4D80
		static EME_RapierProjectile_Shocking() {} // 0x0000000186DE4D80-0x0000000186DE4DE0
	
		// Methods
		public virtual void makeSprites() {} // 0x0000000186DE2D60-0x0000000186DE2F10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DE2F10-0x0000000186DE3960
		public override void SetTarget(Transform target) {} // 0x0000000186DE3960-0x0000000186DE4AA0
		public override void Despawn() {} // 0x0000000186DE4AA0-0x0000000186DE4B70
		public void DespawnNow() {} // 0x0000000186DE4B70-0x0000000186DE4C90
		public override void SetNullTarget() {} // 0x0000000186DE4C90-0x0000000186DE4CA0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DE4CA0-0x0000000186DE4D30
	}
}
