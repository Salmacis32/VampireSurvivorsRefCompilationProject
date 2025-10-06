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
	public class TP_Valmanway_Weapon : Weapon // TypeDefIndex: 16509
	{
		// Fields
		private float _walked; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _walkedTimer; // 0x160
		private ParticleEmitterManager _pfxEmitterManager; // 0x168
		private ParticleSystem _pfxEmitter; // 0x170
		private bool _initialisedParticles; // 0x178
		private const float MUL = 500f; // Metadata: 0x01977D18
		private bool _isManualFire; // 0x179
	
		// Constructors
		public TP_Valmanway_Weapon() {} // 0x0000000186FFC4F0-0x0000000186FFC540
	
		// Methods
		public void SetManualFire() {} // 0x0000000186FFC380-0x0000000186FFC3A0
		public override float PArea() => default; // 0x0000000186FD2130-0x0000000186FD2190
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FFC3A0-0x0000000186FFC3D0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D17 */) {} // 0x0000000186FFC3D0-0x0000000186FFC3E0
		public override void Cleanup() {} // 0x0000000186FFC3E0-0x0000000186FFC410
		public override void InternalUpdate() {} // 0x0000000186FFC410-0x0000000186FFC4F0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
	}
}
