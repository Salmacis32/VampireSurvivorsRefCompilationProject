/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_FlikTrailProjectile : Projectile // TypeDefIndex: 15862
	{
		// Fields
		[SerializeField]
		private TrailRenderer _trail; // 0xD0
		private ParticleEmitterManager _pfxManager; // 0xD8
		private ParticleSystem _pfxEmitter; // 0xE0
		private bool _expired; // 0xE8
		private float _updateLoops; // 0xEC
		private MultiTargetTween _fadeTrailTween; // 0xF0
		private MultiTargetTween _angleTween; // 0xF8
		private Vector2 _startingPoint; // 0x100
		public float angleLerp; // 0x108
		private float _trailTime; // 0x10C
		private EX_FlikTrailWeapon _trueWeapon; // 0x110
		private EnemyController _enemy; // 0x118
		private List<Vector3> _trailPositions; // 0x120
	
		// Constructors
		public EX_FlikTrailProjectile() {} // 0x0000000186DFA720-0x0000000186DFA810
	
		// Methods
		public void SetEnemy(EnemyController enemy) {} // 0x0000000184BDAFE0-0x0000000184BDB040
		protected override void Awake() {} // 0x0000000186DF8440-0x0000000186DF8C30
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DF8C30-0x0000000186DF9330
		public override void InternalUpdate() {} // 0x0000000186DF9330-0x0000000186DFA070
		public override void Despawn() {} // 0x0000000186DFA070-0x0000000186DFA100
		private void InitTrail() {} // 0x0000000186DFA100-0x0000000186DFA390
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186DFA390-0x0000000186DFA3A0
		private void FadeOut() {} // 0x0000000186DFA3A0-0x0000000186DFA720
		private Vector2 Rotate_point(float targetX, float targetY, float angle, Vector2 origin) => default; // 0x0000000186BFAF80-0x0000000186BFB020
	}
}
