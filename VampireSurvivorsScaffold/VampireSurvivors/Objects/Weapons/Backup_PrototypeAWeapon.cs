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
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Backup_PrototypeAWeapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16125
	{
		// Fields
		private SpriteRenderer _muzzleFlash; // 0x160
		private bool _muzzleFlashLastRotated; // 0x168
		private int _frameCount; // 0x16C
		private float _sinPhase; // 0x170
		private List<PhaserSprite> _planeSprites; // 0x178
		private List<float2> _planeVectors; // 0x180
		private VampireSurvivors.Framework.TimerSystem.Timer _planeTimer; // 0x188
		private bool _planeFiring; // 0x190
		private int _planeCounter; // 0x194
		private VampireSurvivors.Framework.TimerSystem.Timer _planeFiringTimer; // 0x198
		private MultiTargetTween _moveTween; // 0x1A0
		private BulletPool _planeBulletPool; // 0x1A8
		private float2 _playerPos; // 0x1B0
		public float planesOffsetX; // 0x1B8
	
		// Constructors
		public Backup_PrototypeAWeapon() {} // 0x0000000186F16A90-0x0000000186F16C40
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F14F40-0x0000000186F15AA0
		private void startPlanes() {} // 0x0000000186F15AA0-0x0000000186F15FB0
		public override void InternalUpdate() {} // 0x0000000186F15FB0-0x0000000186F16230
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B68 */) {} // 0x0000000186F16230-0x0000000186F168D0
		public override void Cleanup() {} // 0x0000000186F168D0-0x0000000186F16A90
	}
}
