/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Trapano2Weapon : Weapon // TypeDefIndex: 16790
	{
		// Fields
		public Color[] _UnionSpriteColours; // 0x158
		public Color[] _UnionTrailColours; // 0x160
		private const float Mul = 16.666666f; // Metadata: 0x01977E42
	
		// Properties
		public bool IsUnion { get; set; } // 0x0000000182766960-0x0000000182766970 0x00000001847A8F00-0x00000001847A8F10
	
		// Constructors
		public Trapano2Weapon() {} // 0x00000001870C35E0-0x00000001870C3630
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870C2D90-0x00000001870C2DD0
		public override void InternalUpdate() {} // 0x00000001870C2DD0-0x00000001870C2EA0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C2EA0-0x00000001870C3090
		public override void CheckArcanas() {} // 0x00000001870C3090-0x00000001870C3390
		protected override bool OnSecondaryBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870C3390-0x00000001870C35E0
	}
}
