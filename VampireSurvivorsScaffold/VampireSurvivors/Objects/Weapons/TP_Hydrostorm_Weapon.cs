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

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Hydrostorm_Weapon : Weapon // TypeDefIndex: 16394
	{
		// Fields
		private bool _initialisedParticles; // 0x158
		private ParticleSystem _rainEmitter1; // 0x160
		private ParticleSystem _rainEmitter2; // 0x168
		private ParticleSystem _bottleEmitter; // 0x170
		private ParticleSystem _groundEmitter1; // 0x178
		private ParticleSystem _groundEmitter2; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _rainStopTimer; // 0x188
		private bool _groundParticlesActive; // 0x190
	
		// Properties
		protected virtual uint RainEmitterTint1 { get => default; } // 0x0000000186FC9170-0x0000000186FC9180 
		protected virtual uint RainEmitterTint2 { get => default; } // 0x0000000181B4DD40-0x0000000181B4DD50 
		protected virtual int RainEmitterQuantity { get => default; } // 0x0000000182109200-0x0000000182109210 
		protected virtual ParticleSystem.MinMaxCurve RainEmitterAlpha { get => default; } // 0x0000000186FC9180-0x0000000186FC91C0 
		protected virtual bool EnableBottleEmitters { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool EnableGroundEmitters { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public TP_Hydrostorm_Weapon() {} // 0x0000000186FC9120-0x0000000186FC9170
	
		// Methods
		protected override void Awake() {} // 0x0000000186FC91C0-0x0000000186FC9200
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC9200-0x0000000186FC9250
		public override void InternalUpdate() {} // 0x0000000186FC9250-0x0000000186FC9360
		protected virtual void UpdateFiringInterval() {} // 0x0000000186FC9360-0x0000000186FC93E0
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C96 */) {} // 0x0000000186FC93E0-0x0000000186FC9440
		public void FireProjectiles() {} // 0x0000000186FC9440-0x0000000186FC9A20
		private void FireOneRainProjectile(Vector2 pos, int index, Transform target) {} // 0x0000000186FC9A20-0x0000000186FC9A60
		protected virtual void PlaySfx() {} // 0x0000000186FC9A60-0x0000000186FC9B20
		private void PlayBottlePfx(bool play) {} // 0x0000000186FC9B20-0x0000000186FC9BC0
		private void MakeRainEmitters() {} // 0x0000000186FC9BC0-0x0000000186FCB4B0
		private void MakeBottleEmitters() {} // 0x0000000186FCB4B0-0x0000000186FCBFF0
		private void MakeGroundEmitters() {} // 0x0000000186FCBFF0-0x0000000186FCD000
		private void UpdateGroundParticles() {} // 0x0000000186FCD000-0x0000000186FCD100
		private Vector2 GetRandomPositionOnScreen() => default; // 0x0000000186FCD100-0x0000000186FCD1D0
		public override void Cleanup() {} // 0x0000000186FCD1D0-0x0000000186FCD1F0
		public override void SetVisible(bool visible) {} // 0x0000000186FCD1F0-0x0000000186FCD210
		private void StopEmitters() {} // 0x0000000186FCD210-0x0000000186FCD600
	}
}
