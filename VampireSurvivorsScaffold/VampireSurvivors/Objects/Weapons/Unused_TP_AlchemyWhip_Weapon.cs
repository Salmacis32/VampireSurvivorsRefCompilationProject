/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Unused_TP_AlchemyWhip_Weapon : Weapon // TypeDefIndex: 16539
	{
		// Fields
		private int _iterations; // 0x158
		private int _totalNodes; // 0x15C
		private float _nodeDistance; // 0x160
		private Vector2 _gravity; // 0x164
		private Vector2 _whipForce; // 0x16C
		private VerletNode[] _nodes; // 0x178
		private Projectile[] _whipProjectiles; // 0x180
		private List<float2> _whipFireList; // 0x188
		private float _flipNum; // 0x190
		private float _tempArea; // 0x194
		private VampireSurvivors.Framework.TimerSystem.Timer _resetFireTimer; // 0x198
	
		// Constructors
		public Unused_TP_AlchemyWhip_Weapon() {} // 0x00000001870067E0-0x0000000187006A80
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187005530-0x0000000187005960
		private void updateScale() {} // 0x0000000187005960-0x0000000187005A60
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D2D */) {} // 0x0000000187005A60-0x0000000187005FF0
		private void shiftWhipForce(int index) {} // 0x0000000187005FF0-0x00000001870060D0
		public override void InternalUpdate() {} // 0x00000001870060D0-0x0000000187006200
		private void Simulate() {} // 0x0000000187006200-0x0000000187006560
		private void ApplyConstraints() {} // 0x0000000187006560-0x00000001870067E0
	}
}
