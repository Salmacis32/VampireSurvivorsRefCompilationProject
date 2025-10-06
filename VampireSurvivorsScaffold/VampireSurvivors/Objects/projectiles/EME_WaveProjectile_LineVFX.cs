/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_WaveProjectile_LineVFX : Projectile // TypeDefIndex: 15848
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail1; // 0xD0
		private EME_WaveWeapon _trueWeapon; // 0xD8
		private bool _isFirstUpdate; // 0xE0
		private EnemyController _targetEnemy; // 0xE8
		private Vector3 p0; // 0xF0
		private Vector3 p1; // 0xFC
		private Vector3 p2; // 0x108
		private Vector3 p3; // 0x114
		private float _elapsedLineTime; // 0x120
		private float _lineDuration; // 0x124
		private bool _hasReachedTarget; // 0x128
		private bool _isDespawning; // 0x129
	
		// Constructors
		public EME_WaveProjectile_LineVFX() {} // 0x0000000186DECAC0-0x0000000186DECB20
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DEBED0-0x0000000186DEC110
		public void SetTargetEnemy(EnemyController enemy) {} // 0x0000000186DEC110-0x0000000186DEC170
		private void Activate() {} // 0x0000000186DEC170-0x0000000186DEC410
		private void LateUpdate() {} // 0x0000000186DEC410-0x0000000186DEC8D0
		private Vector3 CalculateQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2) => default; // 0x0000000186DEC8D0-0x0000000186DEC9C0
		public void OnTargetReached() {} // 0x0000000186DEC9C0-0x0000000186DECA10
		private void StartDespawn() {} // 0x0000000186DECA10-0x0000000186DECAC0
		public override void Despawn() {} // 0x0000000186BE1200-0x0000000186BE12D0
	}
}
