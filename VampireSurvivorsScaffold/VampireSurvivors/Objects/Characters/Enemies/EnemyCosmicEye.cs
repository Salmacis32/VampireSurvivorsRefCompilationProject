/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyCosmicEye : EnemyController // TypeDefIndex: 17282
	{
		// Fields
		[SerializeField]
		protected Transform eyeModel; // 0x270
		private bool _hasGeneratedSprites; // 0x278
		private float _sineF; // 0x27C
		private PhaserSprite _wingL1; // 0x280
		private PhaserSprite _wingR1; // 0x288
		private PhaserSprite _wingL2; // 0x290
		private PhaserSprite _wingR2; // 0x298
		private PhaserSprite _wingL3; // 0x2A0
		private PhaserSprite _wingR3; // 0x2A8
		private PhaserSprite _wingSmL1; // 0x2B0
		private PhaserSprite _wingSmR1; // 0x2B8
		private PhaserSprite _wingSmL2; // 0x2C0
		private PhaserSprite _wingSmR2; // 0x2C8
		private PhaserSprite _wingSmL3; // 0x2D0
		private PhaserSprite _wingSmR3; // 0x2D8
		private MultiTargetTween _spritesDeathTween; // 0x2E0
		private MultiTargetTween _wingsAngleTween; // 0x2E8
		private bool _isFirstUpdate; // 0x2F0
		private float _eyeRotationX; // 0x2F4
		private float _eyeRotationY; // 0x2F8
		private PhaserSprite[] AllWings; // 0x300
		private PhaserSprite[] AllSmallWings; // 0x308
		private PhaserSprite[] AllSprites; // 0x310
		private TweenerCore<float, float, FloatOptions> SineTween; // 0x318
		private MultiTargetTween _disappearTween; // 0x320
		private TweenerCore<Vector3, Vector3, VectorOptions> _eyeScaleTween; // 0x328
		private List<TweenerCore<Quaternion, Vector3, QuaternionOptions>> rotationTweens; // 0x330
		private const string FrameNameWing = "desWing_i01.png"; // Metadata: 0x019783BC
		private const string FrameNameWingL = "desWingL_i01.png"; // Metadata: 0x019783CC
	
		// Constructors
		public EnemyCosmicEye() {} // 0x0000000187239F80-0x000000018723A080
	
		// Methods
		protected override void Awake() {} // 0x0000000187234F80-0x0000000187235010
		protected void RandomEyeAngle() {} // 0x0000000187235010-0x0000000187235450
		protected override void OnRecycleEnemy() {} // 0x0000000187235450-0x00000001872376B0
		private void GenerateSpritesAndAnimations() {} // 0x00000001872376B0-0x0000000187239280
		private void UpdateSprites() {} // 0x0000000187239280-0x0000000187239740
		protected override void OnUpdate() {} // 0x0000000187239740-0x00000001872397A0
		protected override void Die() {} // 0x00000001872397A0-0x00000001872397F0
		protected override void OnDeathAnimationComplete() {} // 0x00000001872397F0-0x0000000187239A30
		private void LateUpdate() {} // 0x0000000187239A30-0x0000000187239BB0
		public override void Disappear() {} // 0x0000000187239BB0-0x0000000187239EF0
		public override void Despawn() {} // 0x0000000187239EF0-0x0000000187239F80
	}
}
