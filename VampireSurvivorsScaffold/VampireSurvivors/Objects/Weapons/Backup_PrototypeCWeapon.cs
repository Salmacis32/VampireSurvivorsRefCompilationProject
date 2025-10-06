/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Backup_PrototypeCWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16131
	{
		// Fields
		private int PlanePoolAmount; // 0x160
		private int ExplosionPerPlaneAmount; // 0x164
		private List<Backup_PlaneData> _planeDatas; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _planeStartingTimer; // 0x170
		private PhaserSpline _spline; // 0x178
		private float _maxPathWidth; // 0x180
		private float _maxPathHeight; // 0x184
		private BulletPool _explosionPool; // 0x188
		private readonly List<float> CurveData; // 0x190
	
		// Constructors
		public Backup_PrototypeCWeapon() {} // 0x0000000186F1A3B0-0x0000000186F1C150
	
		// Methods
		public override void Fire() {} // 0x0000000186F18AD0-0x0000000186F18D10
		public override float PAmount() => default; // 0x0000000186F18D10-0x0000000186F18D80
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F18D80-0x0000000186F18FD0
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F18FD0-0x0000000186F199F0
		private Backup_PlaneData nextPlane() => default; // 0x0000000186F199F0-0x0000000186F19AD0
		private void startPlanes(int planeAmount) {} // 0x0000000186F19AD0-0x0000000186F19DD0
		public override void InternalUpdate() {} // 0x0000000186F19DD0-0x0000000186F1A1E0
		public override void Cleanup() {} // 0x0000000186F1A1E0-0x0000000186F1A3B0
	}
}
