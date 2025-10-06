/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TongueProjectile : Projectile // TypeDefIndex: 15997
	{
		// Fields
		[SerializeField]
		protected TrailRenderer _trail; // 0xD0
		[SerializeField]
		protected float _attackSpeed; // 0xD8
		protected Sprite _trailSprite; // 0xE0
		protected float _AttackLerp; // 0xE8
		private float _minAngleRotDeg; // 0xEC
		private float _maxAngleRotDeg; // 0xF0
		private float _angleRng; // 0xF4
		protected bool _retracting; // 0xF8
		protected float2 _lastTargetPoint; // 0xFC
		protected bool _hasHitAnObject; // 0x104
		protected EnemyController _targetEnemy; // 0x108
		protected SfxType[] s_sounds; // 0x110
	
		// Constructors
		public TongueProjectile() {} // 0x0000000186EA1B50-0x0000000186EA1C70
	
		// Methods
		protected override void Awake() {} // 0x0000000186EA0360-0x0000000186EA03A0
		protected virtual void InitTrailSprite() {} // 0x0000000186EA03A0-0x0000000186EA0480
		protected void SetupTrail() {} // 0x0000000186EA0480-0x0000000186EA0A60
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186EA0A60-0x0000000186EA0C90
		public void SetTargetEnemy(EnemyController enemy) {} // 0x0000000182766880-0x00000001827668E0
		private void InitTrail() {} // 0x0000000186EA0C90-0x0000000186EA0DD0
		protected float2 GetMouthPosition() => default; // 0x0000000186EA0DD0-0x0000000186EA0F00
		protected virtual Vector3[] GetCurve(float2 startPoint, float2 currentPoint) => default; // 0x0000000186EA0F00-0x0000000186EA10B0
		protected void UpdateTrail() {} // 0x0000000186EA10B0-0x0000000186EA13D0
		public override void InternalUpdate() {} // 0x0000000186EA13D0-0x0000000186EA16E0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186EA16E0-0x0000000186EA17E0
		protected void PlayLickSound() {} // 0x0000000186EA17E0-0x0000000186EA19F0
		public override void Despawn() {} // 0x0000000186EA19F0-0x0000000186EA1B50
	}
}
