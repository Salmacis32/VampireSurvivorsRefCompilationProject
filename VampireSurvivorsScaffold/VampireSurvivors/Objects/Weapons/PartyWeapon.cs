/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class PartyWeapon : Weapon // TypeDefIndex: 16170
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0x158
		private ParticleSystem _emitter1; // 0x160
		private GravityWell _well1; // 0x168
		protected uint[] CircleColors; // 0x170
		protected uint[] StarColors; // 0x178
		protected uint[] TriangleColors; // 0x180
		protected uint[] HeartColors; // 0x188
		private int _colorIndex; // 0x190
		private readonly int _maxColors; // 0x194
		private PartyCounterWeapon _counterWeapon; // 0x198
		private WeaponType _counterWeaponType; // 0x1A0
		[NonSerialized]
		public int FireType; // 0x1A4
		[NonSerialized]
		public bool FrontFiring; // 0x1A8
	
		// Constructors
		public PartyWeapon() {} // 0x0000000186F3E490-0x0000000186F3E770
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F3CA20-0x0000000186F3D470
		private void PickType() {} // 0x0000000186F3D470-0x0000000186F3D5A0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BAA */) {} // 0x0000000186F3D5A0-0x0000000186F3D9D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F3D9D0-0x0000000186F3DCF0
		public uint GetRandomCircleColor() => default; // 0x0000000186F3DCF0-0x0000000186F3DD50
		public uint GetRandomStarColor() => default; // 0x0000000186F3DD50-0x0000000186F3DDB0
		public uint GetRandomTriangleColor() => default; // 0x0000000186F3DDB0-0x0000000186F3DE10
		public uint GetRandomHeartColor() => default; // 0x0000000186F3DE10-0x0000000186F3DE70
		public override void CheckArcanas() {} // 0x0000000186F3DE70-0x0000000186F3E230
		public override bool LevelUp() => default; // 0x0000000186F3E230-0x0000000186F3E350
		public override void ParadoxFire() {} // 0x0000000186F3E350-0x0000000186F3E490
	}
}
