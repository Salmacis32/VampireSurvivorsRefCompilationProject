/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class SantaJavelin2Weapon : SantaJavelinWeapon // TypeDefIndex: 16760
	{
		// Fields
		[SerializeField]
		private List<MeshRenderer> _3DMeshes; // 0x180
		[SerializeField]
		private Transform _RingTransform; // 0x188
		[SerializeField]
		private MeshRenderer _RingMesh; // 0x190
		[SerializeField]
		private Transform _Ring2Transform; // 0x198
		[SerializeField]
		private MeshRenderer _Ring2Mesh; // 0x1A0
		[SerializeField]
		private Transform _spearCTransform; // 0x1A8
		[SerializeField]
		private MeshRenderer _spearCMesh; // 0x1B0
		[SerializeField]
		private Transform _spearLTransform; // 0x1B8
		[SerializeField]
		private MeshRenderer _spearLMesh; // 0x1C0
		[SerializeField]
		private Transform _spearRTransform; // 0x1C8
		[SerializeField]
		private MeshRenderer _spearRMesh; // 0x1D0
		[SerializeField]
		private float _modelMaterialAlpha; // 0x1D8
		private PhaserSprite _darkBackground; // 0x1E0
		private PhaserSprite _lightBackground; // 0x1E8
		private float _defaultSkyScale; // 0x1F0
		private int _AccumulatedRosaries; // 0x1F4
		private bool _isPlayingWSP; // 0x1F8
		private float _delayBetweenWSP; // 0x1FC
		private float _WSPDelayTotalTime; // 0x200
		private static readonly int _ScrollSpeedX; // 0x00
		private static readonly int _ScrollSpeedY; // 0x04
		private static readonly int _AlphaMul; // 0x08
		private MultiTargetTween _tween1; // 0x208
		private MultiTargetTween _tween2; // 0x210
		private MultiTargetTween _tweenGems; // 0x218
		private bool _generatedPools; // 0x220
		private BulletPool _tvExplosionPool; // 0x228
	
		// Properties
		public override bool SingleProjectile { get => default; } // 0x0000000181958370-0x0000000181958380 
	
		// Constructors
		public SantaJavelin2Weapon() {} // 0x00000001870AEDA0-0x00000001870AEDD0
		static SantaJavelin2Weapon() {} // 0x00000001870AEDD0-0x00000001870AEE90
	
		// Methods
		public override float PPower() => default; // 0x00000001870A7DA0-0x00000001870A7E80
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870A7E80-0x00000001870A9380
		public void StartWeirdSoulsPurifier() {} // 0x00000001870A9380-0x00000001870A9410
		public override void InternalUpdate() {} // 0x00000001870A9410-0x00000001870A9570
		private void PlayWSP() {} // 0x00000001870A9570-0x00000001870A9710
		private void AlternateBackgrounds() {} // 0x00000001870A9710-0x00000001870A9B40
		private void WSPDamage() {} // 0x00000001870A9B40-0x00000001870AA710
		private void PlaySFX(float vol1 = 1.8f /* Metadata: 0x01977E17 */, float vol2 = 0.5f /* Metadata: 0x01977E1B */) {} // 0x00000001870AA710-0x00000001870AA850
		private void exe_FadeInBG() {} // 0x00000001870AA850-0x00000001870AB0E0
		private void exe_RigthSpear() {} // 0x00000001870AB0E0-0x00000001870AB6E0
		private void exe_LeftSpear() {} // 0x00000001870AB6E0-0x00000001870ABCE0
		private void exe_CentralSpear() {} // 0x00000001870ABCE0-0x00000001870AC2E0
		private void exe_Explode() {} // 0x00000001870AC2E0-0x00000001870AD2A0
		private void OnWSPComplete() {} // 0x00000001870AD2A0-0x00000001870AD2C0
		protected void ScreenShake(float duration = 24f /* Metadata: 0x01977E1F */, float strength = 1f /* Metadata: 0x01977E23 */) {} // 0x00000001870AD2C0-0x00000001870AD780
		public override void Cleanup() {} // 0x00000001870AD780-0x00000001870ADD50
		public override void ForcedFire(bool hasTarget, Vector3 position, bool skipTriggers = false /* Metadata: 0x01977E27 */) {} // 0x00000001870ADD50-0x00000001870AE190
		protected override Vector3 Fire_FireProjectiles(bool hasTarget, Vector3 position, bool skipTriggers = false /* Metadata: 0x01977E28 */) => default; // 0x00000001870AE190-0x00000001870AE4E0
		protected override void OnStart() {} // 0x00000001870AE4E0-0x00000001870AE700
		protected override void OnPause() {} // 0x00000001870AE700-0x00000001870AE940
		protected override void OnResume() {} // 0x00000001870AE940-0x00000001870AEB70
		public void SecondaryFireAt(Vector2 targetPos) {} // 0x00000001870AEB70-0x00000001870AEC30
		protected bool OnMinorBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x00000001870AEC30-0x00000001870AEDA0
	}
}
