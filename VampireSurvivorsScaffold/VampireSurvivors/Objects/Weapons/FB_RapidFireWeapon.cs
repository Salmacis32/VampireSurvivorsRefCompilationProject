/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class FB_RapidFireWeapon : Weapon // TypeDefIndex: 16251
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0x158
		private float2 _particlesOffset; // 0x160
	
		// Constructors
		public FB_RapidFireWeapon() {} // 0x0000000186F1CB60-0x0000000186F1CBD0
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BEA */) {} // 0x0000000186F7C480-0x0000000186F7C5E0
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F7C5E0-0x0000000186F7CF00
		public override float PInterval() => default; // 0x0000000186F7CF00-0x0000000186F7CF50
		public override void CheckArcanas() {} // 0x0000000186F73070-0x0000000186F73210
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
	}
}
