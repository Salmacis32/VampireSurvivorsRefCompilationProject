/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
	public class TP_Custos4_Weapon : TP_Custos_Weapon // TypeDefIndex: 16303
	{
		// Fields
		[SerializeField]
		private Transform _DummyTarget; // 0x1B8
		private const int AnimFPS = 20; // Metadata: 0x01977C33
		private PhaserSprite _custos1; // 0x1C0
		private PhaserSprite _custos2; // 0x1C8
		private PhaserSprite _custos3; // 0x1D0
		private Vector2 _offset1; // 0x1D8
		private Vector2 _offset2; // 0x1E0
		private Vector2 _offset3; // 0x1E8
		private int _firingCounter; // 0x1F0
		private const int MinBites = 6; // Metadata: 0x01977C34
		private int _numBites; // 0x1F4
		private const int MinFireballs = 16; // Metadata: 0x01977C35
		private int _numFireballs; // 0x1F8
		private const float HeadFadeTime = 500f; // Metadata: 0x01977C36
		private const float GapBetweenFireballandBiteAttacks = 250f; // Metadata: 0x01977C3A
		private VampireSurvivors.Framework.TimerSystem.Timer _animTimer; // 0x200
		private MultiTargetTween _alphaTween; // 0x208
	
		// Constructors
		public TP_Custos4_Weapon() {} // 0x0000000186F9B200-0x0000000186F9B280
	
		// Methods
		protected override void Awake() {} // 0x0000000186F6AB60-0x0000000186F6AB70
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F97340-0x0000000186F98360
		public override void InternalUpdate() {} // 0x0000000186F98360-0x0000000186F98370
		public override float PArea() => default; // 0x0000000186F98370-0x0000000186F983D0
		public override float PInterval() => default; // 0x0000000186F983D0-0x0000000186F98430
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977C32 */) {} // 0x0000000186F98430-0x0000000186F98530
		private void StartFireballAttack() {} // 0x0000000186F98530-0x0000000186F98F90
		private void ShootFireballs() {} // 0x0000000186F98F90-0x0000000186F99630
		private void FireFireballProjectiles(int index) {} // 0x0000000186F99630-0x0000000186F99DA0
		private Transform GetFireballTarget() => default; // 0x0000000186F99DA0-0x0000000186F9A0F0
		private void EndFireballAttack() {} // 0x0000000186F9A0F0-0x0000000186F9A580
		private void BiteAttack() {} // 0x0000000186F9A580-0x0000000186F9A900
		private void FireOneBiteProjectile(List<BulletPool> sequence, List<Vector2> offsets, int index) {} // 0x0000000186F9A900-0x0000000186F9AA80
		private List<BulletPool> GenerateBiteSequence() => default; // 0x0000000186F9AA80-0x0000000186F9AE90
		private List<Vector2> GetBiteOffsets(List<BulletPool> sequence) => default; // 0x0000000186F9AE90-0x0000000186F9B140
		public override void Cleanup() {} // 0x0000000186F9B140-0x0000000186F9B190
		public override void SetVisible(bool visible) {} // 0x0000000186F9B190-0x0000000186F9B200
		private float AlphaFromScale(float weaponArea, float maxScale, float minAlpha) => default; // 0x0000000186E5A460-0x0000000186E5A4C0
	}
}
