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
	public class FB_MultiStageWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16242
	{
		// Fields
		protected float2 _bulletStartOffset; // 0x160
	
		// Constructors
		public FB_MultiStageWeapon() {} // 0x0000000186F75890-0x0000000186F75900
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F70BB0-0x0000000186F70BE0
		public override void InternalUpdate() {} // 0x0000000186F76140-0x0000000186F76800
		private void RefreshTarget(FB_MultiStageProjectile bullet) {} // 0x0000000186F76800-0x0000000186F76AB0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F76AB0-0x0000000186F76D80
	}
}
