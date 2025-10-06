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
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Unused_TP_AlchemyWhipTween_Weapon : Weapon // TypeDefIndex: 16536
	{
		// Fields
		private int _iterations; // 0x158
		private int _totalNodes; // 0x15C
		private VerletTweenNode[] _nodes; // 0x160
		private Projectile[] _whipProjectiles; // 0x168
		private List<List<Vector2>> _splineList; // 0x170
		private float _flipNum; // 0x178
		private float _tempArea; // 0x17C
		private bool _applyTipControl; // 0x180
		private float2 _gravity; // 0x184
		private float _nodeDistance; // 0x18C
		private int _splineIndex; // 0x190
		private MultiTargetTween _lerpTween; // 0x198
		private float _waypointTotalDist; // 0x1A0
		private float2 _characterOffset; // 0x1A4
		private VampireSurvivors.Framework.TimerSystem.Timer _resetTimer; // 0x1B0
	
		// Constructors
		public Unused_TP_AlchemyWhipTween_Weapon() {} // 0x00000001870051C0-0x0000000187005430
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000187003440-0x0000000187003A90
		private void updateScale() {} // 0x0000000187003A90-0x0000000187003B90
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977D2C */) {} // 0x0000000187003B90-0x0000000187003EB0
		private void ShiftWhipForce(int index) {} // 0x0000000187003EB0-0x0000000187004650
		private void bodyEnabled(bool enable) {} // 0x0000000187004650-0x00000001870046D0
		public override void InternalUpdate() {} // 0x00000001870046D0-0x0000000187004810
		private void Simulate() {} // 0x0000000187004810-0x0000000187004A00
		private void ApplyConstraints() {} // 0x0000000187004A00-0x0000000187004C80
		public float2 MultiLerp(List<Vector2> waypoints, float ratio) => default; // 0x0000000187004C80-0x0000000187004F40
		public static int GetVectorIndexFromDistanceTravelled(List<Vector2> waypoints, float distanceTravelled) => default; // 0x0000000187004F40-0x0000000187005020
		public float MultiDistance(List<Vector2> waypoints) => default; // 0x0000000187005020-0x00000001870051C0
	}
}
