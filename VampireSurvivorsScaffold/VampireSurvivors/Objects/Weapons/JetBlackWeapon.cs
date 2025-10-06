/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class JetBlackWeapon : Weapon // TypeDefIndex: 16715
	{
		// Fields
		private List<GravityWell> _gravityWells; // 0x158
		private List<System.Numerics.Vector3> _offsets; // 0x160
		private bool _initialisedParticles; // 0x168
		private ParticleSystem ownerBloodVfx; // 0x170
		private bool canFire; // 0x178
		private float firingTimer; // 0x17C
		private float accumulatedDamage; // 0x180
		private float accumulatedRecovery; // 0x184
		public ParticleSystem DamageVfx; // 0x188
	
		// Constructors
		public JetBlackWeapon() {} // 0x0000000187091C70-0x0000000187091CD0
	
		// Methods
		public override float PPower() => default; // 0x00000001870907A0-0x0000000187090800
		public override float SecondaryPPower() => default; // 0x0000000187090800-0x00000001870908F0
		protected override void OnStart() {} // 0x00000001870908F0-0x0000000187090910
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187090910-0x00000001870912F0
		public override void InternalUpdate() {} // 0x00000001870912F0-0x0000000187091370
		public void OnPlayerHitDamage(float value) {} // 0x0000000187091370-0x00000001870914D0
		public void OnPlayerRecovery(float value) {} // 0x00000001870914D0-0x0000000187091630
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DE6 */) {} // 0x0000000187091630-0x0000000187091920
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public void SpawnExplosionsAt(float2 _pos) {} // 0x0000000187091920-0x0000000187091C70
	}
}
