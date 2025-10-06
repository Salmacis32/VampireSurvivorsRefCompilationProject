/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class NovaWeapon : Weapon // TypeDefIndex: 16747
	{
		// Fields
		[SerializeField]
		private Color _projectileColor; // 0x158
		[SerializeField]
		private WeaponType _novaExplosionType; // 0x168
		private uint _convertedColor; // 0x16C
	
		// Constructors
		public NovaWeapon() {} // 0x00000001870A3A10-0x00000001870A3A60
	
		// Methods
		protected override void OnStart() {} // 0x00000001870A3C80-0x00000001870A3D20
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x00000001870A3D20-0x00000001870A3EE0
		public uint ConvertColorToUint(Color color) => default; // 0x00000001870A3EE0-0x00000001870A3F50
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870A3F50-0x00000001870A4160
	}
}
