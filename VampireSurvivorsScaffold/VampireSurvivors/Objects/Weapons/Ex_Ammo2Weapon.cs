/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Ex_Ammo2Weapon : Weapon // TypeDefIndex: 16655
	{
		// Fields
		private BulletPool InvisProjectilesPool; // 0x158
		[SerializeField]
		private Projectile InvisProjectilePrefab; // 0x160
		[SerializeField]
		private ParticleSystem[] _gunastropheParticleSystem; // 0x168
		[SerializeField]
		private float _particleLaunchVelocity; // 0x170
		[SerializeField]
		private float _particleGravity; // 0x174
		private Camera _mainCamera; // 0x178
		private ParticleSystem.Particle[] _activeParticles; // 0x180
		private float[] _randomBounceValues; // 0x188
		private readonly List<RapidDamageInstance> _rapidDamageInstances; // 0x190
		private const WeaponType _counterWeaponType = WeaponType.EX_AMMO1_COUNTER; // Metadata: 0x01977DBF
		private Weapon _counterWeapon; // 0x198
		private Vector3 _cameraOrthographicSize; // 0x1A0
	
		// Properties
		private Vector3 _gravityVector { get => default; } // 0x0000000187033C10-0x0000000187033C30 
	
		// Constructors
		public Ex_Ammo2Weapon() {} // 0x0000000187036560-0x0000000187036650
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187033C30-0x0000000187033F20
		protected override void Awake() {} // 0x0000000187033F20-0x0000000187034180
		public override void CheckArcanas() {} // 0x0000000187034180-0x00000001870345D0
		private void InitBounceValues() {} // 0x00000001870345D0-0x0000000187034C80
		protected override void OnUpdate() {} // 0x0000000187034C80-0x0000000187035800
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000187035800-0x0000000187035910
		public Vector3 GetRandomActiveParticlePosition() => default; // 0x0000000187035910-0x0000000187035A50
		public void EmitParticles(int amount) {} // 0x0000000187035A50-0x0000000187035FA0
		private void ApplyParticleVelocity(ParticleSystem.Particle[] particles, int particleCount, float left, float right, float top, float bottom) {} // 0x0000000187035FA0-0x0000000187036340
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187036340-0x0000000187036560
	}
}
