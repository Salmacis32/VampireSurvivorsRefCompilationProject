/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KickProjectile_Thunder : Projectile // TypeDefIndex: 15789
	{
		// Fields
		[SerializeField]
		private List<TrailRenderer> _Trails; // 0xD0
		[SerializeField]
		private float TrailPreTime; // 0xD8
		[SerializeField]
		private ParticleSystem ThunderHeadFX; // 0xE0
		[SerializeField]
		private ParticleSystem ThunderHeadEndFX; // 0xE8
		[SerializeField]
		private bool FadeAlpha; // 0xF0
		private Vector2 _saveVel; // 0xF4
		private List<int> _targetAngles; // 0x100
		private int _wallBounces; // 0x108
		private static readonly int Tiling; // 0x00
		private EME_Kick1Weapon _trueWeapon; // 0x110
		private int _bouncedTimes; // 0x118
		private bool _isLeft; // 0x11C
		[SerializeField]
		protected int ExtraBounces; // 0x120
		[SerializeField]
		protected int AngleOffset; // 0x124
	
		// Constructors
		public EME_KickProjectile_Thunder() {} // 0x0000000186D938D0-0x0000000186D93DB0
		static EME_KickProjectile_Thunder() {} // 0x0000000186D93DB0-0x0000000186D93E10
	
		// Methods
		protected override void Awake() {} // 0x0000000186D916E0-0x0000000186D918C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D918C0-0x0000000186D92390
		public override void InternalUpdate() {} // 0x0000000186D92390-0x0000000186D929E0
		private void SetRotationBasedOnVelocity(Transform target, Vector2 velocity) {} // 0x0000000186D929E0-0x0000000186D92B40
		private void Bounce(Body b, bool up, bool down, bool left, bool right) {} // 0x0000000186D92B40-0x0000000186D92CF0
		private void SetupTrails(TrailRenderer _trail) {} // 0x0000000186D92CF0-0x0000000186D92E20
		private void FadeOutAndDispose() {} // 0x0000000186D92E20-0x0000000186D933B0
		public override void Despawn() {} // 0x0000000186D933B0-0x0000000186D938D0
	}
}
