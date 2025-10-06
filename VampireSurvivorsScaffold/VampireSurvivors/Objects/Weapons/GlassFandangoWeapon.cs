/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class GlassFandangoWeapon : Weapon // TypeDefIndex: 16695
	{
		// Fields
		private float _walked; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _walkedTimer; // 0x160
		private ParticleEmitterManager _pfxEmitterManager; // 0x168
		private ParticleSystem _pfxEmitter; // 0x170
		private bool _initialisedParticles; // 0x178
		private const float MUL = 500f; // Metadata: 0x01977DDA
		[FormerlySerializedAs("sizeee")]
		public float ProjectilePixelSize; // 0x17C
	
		// Constructors
		public GlassFandangoWeapon() {} // 0x0000000187086F10-0x0000000187086F70
	
		// Methods
		public override float PArea() => default; // 0x0000000187085E30-0x0000000187085EE0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187085EE0-0x0000000187086A70
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977DD9 */) {} // 0x0000000187086A70-0x0000000187086B50
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000187086B50-0x0000000187086D10
		public override void Cleanup() {} // 0x0000000186FFC3E0-0x0000000186FFC410
		public override void InternalUpdate() {} // 0x0000000187086D10-0x0000000187086F10
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
	}
}
