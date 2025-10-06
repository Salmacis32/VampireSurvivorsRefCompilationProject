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
	public class CherryStarExplosionProjectile : Projectile // TypeDefIndex: 15410
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xD0
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xD8
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0xE0
		private ParticleEmitterManager _particles; // 0xE8
		private ParticleSystem _fwEmitter; // 0xF0
		private GravityWell _well; // 0xF8
		private bool _isDespawning; // 0x100
		private Vector2 _aimVec; // 0x104
		private MultiTargetTween _ttween6; // 0x110
		private MultiTargetTween _ttween5; // 0x118
		private MultiTargetTween _ttween3; // 0x120
		private MultiTargetTween _ttween4; // 0x128
		private MultiTargetTween _ttween4Alpha; // 0x130
		private MultiTargetTween _ttween2; // 0x138
		private MultiTargetTween _ttween1; // 0x140
		private CherryWeapon _trueWeapon; // 0x148
		private bool _alreadyRecycled; // 0x150
		private uint[] _onEmitcustomTint2; // 0x158
	
		// Constructors
		public CherryStarExplosionProjectile() {} // 0x0000000186BD6660-0x0000000186BD6750
	
		// Methods
		protected override void Awake() {} // 0x0000000186BD4270-0x0000000186BD4DE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BD4DE0-0x0000000186BD5270
		private void Detonate() {} // 0x0000000186BD5270-0x0000000186BD65A0
		public override void Despawn() {} // 0x0000000186BD65A0-0x0000000186BD6660
	}
}
