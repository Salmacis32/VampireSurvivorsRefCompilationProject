/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_AlucardSpear1_Weapon : Weapon // TypeDefIndex: 16270
	{
		// Fields
		private BulletPool _pommelPool; // 0x158
	
		// Constructors
		public TP_AlucardSpear1_Weapon() {} // 0x0000000186F86D30-0x0000000186F86D80
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F59EB0-0x0000000186F59EC0
		protected override void OnStart() {} // 0x0000000186F868D0-0x0000000186F86BF0
		public Projectile CreatePommelProjectile(int index) => default; // 0x0000000186F86BF0-0x0000000186F86C80
		protected override void OnDestroy() {} // 0x0000000186F86C80-0x0000000186F86D00
		public override void Cleanup() {} // 0x0000000186F86D00-0x0000000186F86D30
	}
}
