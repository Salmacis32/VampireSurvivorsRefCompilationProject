/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class OphionWeapon : Weapon // TypeDefIndex: 16168
	{
		// Fields
		private ParticleEmitterManager _pfxEmitter; // 0x158
		private GravityWell _well; // 0x160
		private WeaponType _counterWeaponType; // 0x168
		private ShadowServantCounterWeapon _counterWeapon; // 0x170
	
		// Constructors
		public OphionWeapon() {} // 0x0000000186F3C710-0x0000000186F3C770
	
		// Methods
		protected override void Awake() {} // 0x0000000186F3B4E0-0x0000000186F3BF00
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F3BF00-0x0000000186F3BF10
		public override void CheckArcanas() {} // 0x0000000186F3BF10-0x0000000186F3C280
		public override bool LevelUp() => default; // 0x0000000186F3C280-0x0000000186F3C3A0
		protected override void OnUpdate() {} // 0x0000000186F3C3A0-0x0000000186F3C4B0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F3C4B0-0x0000000186F3C710
	}
}
