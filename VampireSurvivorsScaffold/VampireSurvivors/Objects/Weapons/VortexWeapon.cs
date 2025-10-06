/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class VortexWeapon : Weapon // TypeDefIndex: 16800
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Renderer; // 0x158
		private MultiTargetTween _imageTween; // 0x160
		private float _recoveredHP; // 0x168
		private float _recoveredCalculated; // 0x16C
		private SpriteRenderer _imageBG; // 0x170
		private ParticleEmitterManager _particlesManager; // 0x178
		private ParticleSystem _pfxEmitter; // 0x180
		private GravityWell _well; // 0x188
		private float _imageScale; // 0x190
		private Circle _shape1; // 0x198
		private EmitZone _emitZone; // 0x1A0
		private float _innerScale; // 0x1A8
		private float _innerDuration; // 0x1AC
		private float _vfxTime; // 0x1B0
		private float _mul; // 0x1B4
		private bool _cooldownAffectedByMovement; // 0x1B8
	
		// Properties
		public float RecoveredHP { get => default; } // 0x00000001829505F0-0x0000000182950600 
	
		// Constructors
		public VortexWeapon() {} // 0x00000001870CAE30-0x00000001870CAEA0
	
		// Methods
		public override float PAmount() => default; // 0x0000000185C0CCB0-0x0000000185C0CCC0
		public override float PPower() => default; // 0x00000001870C8C00-0x00000001870C8C50
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870C8C50-0x00000001870C9F30
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E62 */) {} // 0x00000001870C9F30-0x00000001870C9FF0
		protected void VortexUpdate(float deltaTime) {} // 0x00000001870C9FF0-0x00000001870CA590
		public override void InternalUpdate() {} // 0x00000001870CA590-0x00000001870CA6A0
		public override void ResetFiringTimer() {} // 0x0000000186F292B0-0x0000000186F292D0
		public override void Cleanup() {} // 0x00000001870CA6A0-0x00000001870CA8B0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870CA8B0-0x00000001870CACC0
		public override void CheckArcanas() {} // 0x00000001870CACC0-0x00000001870CAD80
		public override void SetVisible(bool visible) {} // 0x00000001870CAD80-0x00000001870CAE30
	}
}
