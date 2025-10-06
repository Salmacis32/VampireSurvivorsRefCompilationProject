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
	public class LarobbaWeapon : Weapon // TypeDefIndex: 16720
	{
		// Fields
		private readonly List<float> _targetAngles; // 0x158
		private int _lastAngleIndex; // 0x160
		private const int MaxAngles = 12; // Metadata: 0x01977DF0
		private const int MaxFrames = 20; // Metadata: 0x01977DF1
		private int _lastRobbaIndex; // 0x164
		[SerializeField]
		private List<Sprite> _robbaFrames; // 0x168
	
		// Constructors
		public LarobbaWeapon() {} // 0x00000001870970B0-0x00000001870971A0
	
		// Methods
		public override void CheckArcanas() {} // 0x0000000187096870-0x0000000187096B10
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187096B10-0x0000000187096EF0
		public float GetAngle() => default; // 0x0000000187096EF0-0x0000000187096F90
		public Sprite GetRobbaFrame() => default; // 0x0000000187096F90-0x0000000187097030
		public override bool LevelUp() => default; // 0x0000000187097030-0x00000001870970B0
	}
}
