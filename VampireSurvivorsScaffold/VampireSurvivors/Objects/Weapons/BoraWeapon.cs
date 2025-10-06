/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class BoraWeapon : Weapon // TypeDefIndex: 16144
	{
		// Fields
		private Camera _camera; // 0x158
		private List<Vector2> _targetPoints; // 0x160
		private int _lastRadiusIndex; // 0x168
		private const int MaxAngles = 12; // Metadata: 0x01977B83
		private bool _cooldownAffectedByMovement; // 0x16C
		private const float Mul = 333.33334f; // Metadata: 0x01977B84
	
		// Constructors
		public BoraWeapon() {} // 0x0000000186F29440-0x0000000186F29530
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F28DF0-0x0000000186F29100
		public Vector2 GetTargetPoint() => default; // 0x0000000186F29100-0x0000000186F291B0
		public override void InternalUpdate() {} // 0x0000000186F291B0-0x0000000186F292B0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void CheckArcanas() {} // 0x0000000186F292D0-0x0000000186F29440
	}
}
