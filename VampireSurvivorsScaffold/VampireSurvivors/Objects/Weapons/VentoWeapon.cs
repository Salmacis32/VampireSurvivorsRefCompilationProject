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
	public class VentoWeapon : Weapon // TypeDefIndex: 16795
	{
		// Fields
		private float _walked; // 0x158
		private VampireSurvivors.Framework.TimerSystem.Timer _walkedTimer; // 0x160
		private float _pBonus; // 0x168
		private ParticleEmitterManager _pfxEmitterManager; // 0x170
		private ParticleSystem _pfxEmitter; // 0x178
		private bool _initialisedParticles; // 0x180
		private const float MUL = 166.66667f; // Metadata: 0x01977E57
	
		// Constructors
		public VentoWeapon() {} // 0x00000001870C6F50-0x00000001870C6FA0
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870C61B0-0x00000001870C6990
		public override float PPower() => default; // 0x00000001870A1820-0x00000001870A1870
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
		public override void Cleanup() {} // 0x0000000186FFC3E0-0x0000000186FFC410
		public override void InternalUpdate() {} // 0x00000001870C6990-0x00000001870C6F50
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void CheckArcanas() {} // 0x00000001870C5F50-0x00000001870C60C0
	}
}
