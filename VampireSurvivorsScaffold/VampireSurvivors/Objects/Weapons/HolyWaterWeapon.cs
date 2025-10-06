/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class HolyWaterWeapon : Weapon // TypeDefIndex: 16711
	{
		// Fields
		private readonly List<float> _targetAngles; // 0x158
		private readonly List<float> _targetRadii; // 0x160
		private int _lasAngleIndex; // 0x168
		private int _lastRadiusIndex; // 0x16C
		private const int MaxAngles = 12; // Metadata: 0x01977DE5
		private float _mul; // 0x170
		private bool _cooldownAffectedByMovement; // 0x174
	
		// Constructors
		public HolyWaterWeapon() {} // 0x0000000187090620-0x00000001870907A0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x000000018708FF70-0x0000000187090210
		public override void CheckArcanas() {} // 0x0000000187090210-0x0000000187090380
		public override void InternalUpdate() {} // 0x0000000187090380-0x0000000187090480
		public override bool LevelUp() => default; // 0x0000000187090480-0x00000001870904E0
		public float GetAngle() => default; // 0x00000001870904E0-0x0000000187090580
		public float GetRadius() => default; // 0x0000000187090580-0x0000000187090620
		public override float PPower() => default; // 0x0000000186F32BA0-0x0000000186F32BF0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
	}
}
