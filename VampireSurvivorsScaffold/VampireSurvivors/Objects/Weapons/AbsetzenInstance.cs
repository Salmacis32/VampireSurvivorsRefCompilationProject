/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class AbsetzenInstance // TypeDefIndex: 16572
	{
		// Fields
		private readonly List<EME_GreatswordProjectile_Absetzen> _swordProjectiles; // 0x10
		private readonly BulletPool _swordBulletPool; // 0x18
		private readonly BulletPool _beamBulletPool; // 0x20
		private readonly EME_Weapon _parentWeapon; // 0x28
		private readonly Transform _targetTransform; // 0x30
		private VampireSurvivors.Framework.TimerSystem.Timer _glimmerShotTimer; // 0x38
		private int _amount; // 0x40
		private int _amountSpawned; // 0x44
		private readonly float _repeatInterval; // 0x48
		private bool _beamFired; // 0x4C
	
		// Properties
		public bool BeamFired { get => default; } // 0x00000001841C7E40-0x00000001841C7E50 
	
		// Constructors
		public AbsetzenInstance() {} // Dummy constructor
		public AbsetzenInstance(EME_Weapon parentWeapon, Transform targetTransform, BulletPool swordBulletPool, BulletPool beamBulletPool, float repeatInterval) {} // 0x0000000187013000-0x0000000187013230
	
		// Methods
		public void FireProjectiles(int amount, float2 pos, Transform target) {} // 0x0000000187013230-0x00000001870135E0
		public void InternalUpdate() {} // 0x00000001870135E0-0x00000001870136E0
		private void FireAbsetzenBeam(float2 position, int index) {} // 0x00000001870136E0-0x0000000187013C60
		public void Cleanup() {} // 0x0000000187013C60-0x0000000187013CE0
	}
}
