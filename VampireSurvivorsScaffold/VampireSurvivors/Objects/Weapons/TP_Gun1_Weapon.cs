/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Gun1_Weapon : Weapon // TypeDefIndex: 16377
	{
		// Fields
		[SerializeField]
		private Projectile _shrapnelPrefab; // 0x158
		protected BulletPool _shrapnelPool; // 0x160
		protected BulletPool _gunPool; // 0x168
		protected VampireSurvivors.Framework.TimerSystem.Timer _throwTimer; // 0x170
		protected int _bulletCounter; // 0x178
	
		// Constructors
		public TP_Gun1_Weapon() {} // 0x0000000186FC3D70-0x0000000186FC3DC0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC3290-0x0000000186FC3810
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C88 */) {} // 0x0000000186FC3810-0x0000000186FC3A70
		public override void Cleanup() {} // 0x0000000186FC3A70-0x0000000186FC3AC0
		public virtual void FireShrapnel(Vector2 position, Vector2 velocity, float pAngle = 0f /* Metadata: 0x01977C89 */) {} // 0x0000000186FC3AC0-0x0000000186FC3D00
		protected override void OnDestroy() {} // 0x0000000186FC3D00-0x0000000186FC3D70
	}
}
