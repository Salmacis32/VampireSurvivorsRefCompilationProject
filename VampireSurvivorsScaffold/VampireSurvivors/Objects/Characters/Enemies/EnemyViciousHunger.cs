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
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyViciousHunger : EnemyController // TypeDefIndex: 17419
	{
		// Fields
		[SerializeField]
		protected MeshRenderer eyeMesh; // 0x270
		[SerializeField]
		protected Transform eyeModel; // 0x278
		private float _sineF; // 0x280
		private MultiTargetTween _spritesDeathTween; // 0x288
		private MultiTargetTween _wingsAngleTween; // 0x290
		private bool _isFirstUpdate; // 0x298
		private float _eyeRotationX; // 0x29C
		private float _eyeRotationY; // 0x2A0
		private TweenerCore<float, float, FloatOptions> SineTween; // 0x2A8
		private MultiTargetTween _disappearTween; // 0x2B0
		private TweenerCore<Vector3, Vector3, VectorOptions> _eyeScaleTween; // 0x2B8
		private List<TweenerCore<Quaternion, Vector3, QuaternionOptions>> rotationTweens; // 0x2C0
		private Circle _explosionCircle; // 0x2C8
		private ParticleEmitterManager _pfxEmitter2; // 0x2D0
		private ParticleEmitterManager _pfxEmitter; // 0x2D8
	
		// Constructors
		public EnemyViciousHunger() {} // 0x00000001872B8470-0x00000001872B8570
	
		// Methods
		protected override void Awake() {} // 0x00000001872B5FA0-0x00000001872B6030
		protected void RandomEyeAngle() {} // 0x00000001872B6030-0x00000001872B6470
		protected override void OnRecycleEnemy() {} // 0x00000001872B6470-0x00000001872B6B50
		private void GenerateSpritesAndAnimations() {} // 0x00000001872B6B50-0x00000001872B7F60
		private void UpdateSprites() {} // 0x00000001872B7F60-0x00000001872B8060
		protected override void OnUpdate() {} // 0x00000001872B8060-0x00000001872B8150
		protected override void Die() {} // 0x00000001872B8150-0x00000001872B81A0
		private void LateUpdate() {} // 0x00000001872B81A0-0x00000001872B8320
		public override void Disappear() {} // 0x00000001872B8320-0x00000001872B8430
		public override void Despawn() {} // 0x00000001872B8430-0x00000001872B8470
	}
}
