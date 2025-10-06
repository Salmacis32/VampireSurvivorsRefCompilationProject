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
	public class TriaceProjectile : Projectile // TypeDefIndex: 15979
	{
		// Fields
		private ParticleEmitterManager _PfxEmitter; // 0xD0
		private PhaserSprite _GroundFx; // 0xD8
		private MultiTargetTween _ScaleTween; // 0xE0
		private MultiTargetTween _AlphaTween; // 0xE8
		private float _radius; // 0xF0
		private uint _myColor; // 0xF4
		private ParticleSystem _projEmitter; // 0xF8
		private float _timeToReach; // 0x100
	
		// Constructors
		public TriaceProjectile() {} // 0x0000000186E8DEA0-0x0000000186E8DF00
	
		// Methods
		protected override void Awake() {} // 0x0000000186E8BD00-0x0000000186E8CEC0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E8CEC0-0x0000000186E8D710
		public override void InternalUpdate() {} // 0x0000000186E8D710-0x0000000186E8D930
		public override void Despawn() {} // 0x0000000186E8D930-0x0000000186E8DA00
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186E8DA00-0x0000000186E8DBD0
		public override void SetTarget(Transform target) {} // 0x0000000186E8DBD0-0x0000000186E8DEA0
	}
}
