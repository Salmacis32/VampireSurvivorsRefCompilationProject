/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Rapidus_Weapon : Weapon // TypeDefIndex: 16447
	{
		// Fields
		private ArcadeSprite sprite; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer spriteTimer; // 0x160
		private bool _initialisedParticles; // 0x168
		protected ParticleEmitterManager _pfxEmitterManager; // 0x170
		protected ParticleSystem _pfxEmitter; // 0x178
		private const float Radius = 16f; // Metadata: 0x01977CC5
		private float _currentMovespeedBonus; // 0x180
	
		// Properties
		protected virtual float _perLevelBonus { get => default; } // 0x0000000185C62C30-0x0000000185C62C40 
		protected virtual int _maxCharges { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
	
		// Constructors
		public TP_Rapidus_Weapon() {} // 0x0000000186FDEAA0-0x0000000186FDEAF0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FDEAF0-0x0000000186FDFEA0
		protected override void OnStart() {} // 0x0000000186FDFEA0-0x0000000186FE0130
		public void UpdateSprite() {} // 0x0000000186FE0130-0x0000000186FE0470
		public override float PPower() => default; // 0x0000000186FE0470-0x0000000186FE0570
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CC4 */) {} // 0x0000000186FE0570-0x0000000186FE09D0
		public override void SetVisible(bool visible) {} // 0x0000000186FE09D0-0x0000000186FE0A00
		protected override bool OnBulletOverlapsDestructible(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186FE0A00-0x0000000186FE0B80
	}
}
