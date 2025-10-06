/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_StarFlail2_Weapon : Weapon // TypeDefIndex: 16499
	{
		// Fields
		private BulletPool _bladePool; // 0x158
		private BulletPool _swipeBodyPool; // 0x160
	
		// Constructors
		public TP_StarFlail2_Weapon() {} // 0x0000000186FF7EB0-0x0000000186FF7F00
	
		// Methods
		public override float PPower() => default; // 0x0000000186FF70A0-0x0000000186FF7160
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F59EB0-0x0000000186F59EC0
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B209C0-0x0000000180B209D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CEC */) {} // 0x0000000186FF79E0-0x0000000186FF7B20
		public TP_StarFlail2_Blade_Projectile SpawnBladeAt(float2 pos, int enemiesHit = 0 /* Metadata: 0x01977CED */, int damage = 1 /* Metadata: 0x01977CEE */, float area = 1f /* Metadata: 0x01977CEF */) => default; // 0x0000000186FF7B20-0x0000000186FF7EB0
		protected override void OnDestroy() {} // 0x0000000186FD77A0-0x0000000186FD7820
		public override void Cleanup() {} // 0x0000000186FD74D0-0x0000000186FD7500
	}
}
