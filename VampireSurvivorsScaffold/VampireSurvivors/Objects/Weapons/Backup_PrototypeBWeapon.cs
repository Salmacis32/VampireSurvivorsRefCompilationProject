/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Backup_PrototypeBWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16128
	{
		// Fields
		private List<PhaserSprite> _planeSprites; // 0x160
		private List<float2> _planeVectors; // 0x168
		private VampireSurvivors.Framework.TimerSystem.Timer _planeTimer; // 0x170
		private MultiTargetTween _moveTween; // 0x178
		private VampireSurvivors.Framework.TimerSystem.Timer[] _explosionTimers; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer[] _explosionDelays; // 0x188
		private BulletPool _explosionPool; // 0x190
		private float2 _playerPos; // 0x198
		public float planesOffsetY; // 0x1A0
	
		// Constructors
		public Backup_PrototypeBWeapon() {} // 0x0000000186F18810-0x0000000186F189C0
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F16D60-0x0000000186F17740
		private void startPlanes() {} // 0x0000000186F17740-0x0000000186F17EA0
		public override void InternalUpdate() {} // 0x0000000186F17EA0-0x0000000186F180A0
		private void dropexplosion(int explosionIndex) {} // 0x0000000186F180A0-0x0000000186F184E0
		public override void Cleanup() {} // 0x0000000186F184E0-0x0000000186F18810
	}
}
