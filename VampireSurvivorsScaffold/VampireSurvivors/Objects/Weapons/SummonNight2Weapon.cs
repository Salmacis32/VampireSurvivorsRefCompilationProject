/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SummonNight2Weapon : Weapon // TypeDefIndex: 16786
	{
		// Fields
		private BulletPool _redPool; // 0x158
	
		// Constructors
		public SummonNight2Weapon() {} // 0x00000001870C1FB0-0x00000001870C2000
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F3BF00-0x0000000186F3BF10
		protected Projectile FireOneBullet_RedPool(float2 position, int index, Transform target) => default; // 0x00000001870C1010-0x00000001870C11F0
		protected override void OnStart() {} // 0x00000001870C11F0-0x00000001870C1700
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E3E */) {} // 0x00000001870C1700-0x00000001870C1FB0
	}
}
