/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class HatExplosionProjectile : Projectile // TypeDefIndex: 15445
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _cherryRenderer; // 0xD0
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xD8
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xE0
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0xE8
		private ParticleEmitterManager _particles; // 0xF0
		private ParticleSystem _fwEmitter; // 0xF8
		private float _initialVelocityX; // 0x100
		private float _initialVelocityY; // 0x104
		private GravityWell _well; // 0x108
		private Vector2 _aimVec; // 0x110
		private MultiTargetTween _ttween6; // 0x118
		private MultiTargetTween _ttween5; // 0x120
		private MultiTargetTween _ttween3; // 0x128
		private MultiTargetTween _ttween4; // 0x130
		private MultiTargetTween _ttween4Alpha; // 0x138
		private MultiTargetTween _ttween2; // 0x140
		private MultiTargetTween _ttween1; // 0x148
		private HatWeapon _trueWeapon; // 0x150
		private bool _alreadyRecycled; // 0x158
		private uint[] _onEmitcustomTint2; // 0x160
	
		// Constructors
		public HatExplosionProjectile() {} // 0x0000000186C05EB0-0x0000000186C05FA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C039E0-0x0000000186C046B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C046B0-0x0000000186C04B40
		private void Detonate() {} // 0x0000000186C04B40-0x0000000186C05E70
		public override void Despawn() {} // 0x0000000186C05E70-0x0000000186C05EB0
	}
}
