/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Holy2_Weapon : Weapon // TypeDefIndex: 16385
	{
		// Fields
		[SerializeField]
		private TP_Holy2_WeaponSupport support; // 0x158
		private bool _initialisedParticles; // 0x160
		private bool _hasGemini; // 0x161
		private TP_Holy1_Weapon _holy1Weapon; // 0x168
	
		// Properties
		public virtual bool IsPrimaryWeapon { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public TP_Holy2_Weapon() {} // 0x0000000186FC7940-0x0000000186FC7990
	
		// Methods
		protected override void Awake() {} // 0x0000000186FC70B0-0x0000000186FC70F0
		public override float PInterval() => default; // 0x0000000186FC70F0-0x0000000186FC7130
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FC7130-0x0000000186FC7590
		public override void InternalUpdate() {} // 0x0000000186FC7590-0x0000000186FC7710
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C90 */) {} // 0x0000000186FC7710-0x0000000186FC7810
		public override void SetVisible(bool visible) {} // 0x0000000186FC7810-0x0000000186FC7940
	}
}
