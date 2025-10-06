/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_DeathHand_Projectile : Projectile // TypeDefIndex: 15535
	{
		// Fields
		private bool _isLeftHand; // 0xD0
		private List<PhaserSprite> _armSprites; // 0xD8
		private PhaserSprite _crack; // 0xE0
		private ParticleSystem _rockParticles; // 0xE8
		[NonSerialized]
		public bool _isMoving; // 0xF0
		private float2 _startPosition; // 0xF4
		private float2 _targetPosition; // 0xFC
		private float _moveTween; // 0x104
		private MultiTargetTween _screenShakeTween; // 0x108
		private MultiTargetTween _crackTween; // 0x110
	
		// Constructors
		public TP_DeathHand_Projectile() {} // 0x0000000186C864A0-0x0000000186C864F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C82DD0-0x0000000186C82E70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C82E70-0x0000000186C83FF0
		public void DoStep(float2 targetPos) {} // 0x0000000186C83FF0-0x0000000186C84280
		private void EndStep() {} // 0x0000000186C84280-0x0000000186C84760
		protected override void OnUpdate() {} // 0x0000000186C84760-0x0000000186C84CE0
		public float2 CalculateTargetPos() => default; // 0x0000000186C84CE0-0x0000000186C84E00
		private void UpdateJoints(float xOffset, List<PhaserSprite> armSprites, float extraScale) {} // 0x0000000186C84E00-0x0000000186C855F0
		private float FindNextJointT(float2 start, float2 end, float2 lastJointPos, float lastJointT, float desiredDistance, float iterationStep = -0.01f /* Metadata: 0x019776C8 */) => default; // 0x0000000186C855F0-0x0000000186C85740
		private float2 ArmSample(float2 start, float2 end, float t) => default; // 0x0000000186C85740-0x0000000186C85900
		public override void Despawn() {} // 0x0000000186C85900-0x0000000186C85F10
		public void ScreenShake(int repeats = 6 /* Metadata: 0x019776CC */) {} // 0x0000000186C85F10-0x0000000186C864A0
	}
}
