/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	[DefaultExecutionOrder(860)]
	public class SoleSolutionWeapon : Weapon // TypeDefIndex: 16778
	{
		// Fields
		[SerializeField]
		private Mesh _quadMesh; // 0x158
		[SerializeField]
		private RenderTexture _renderTexture; // 0x160
		[SerializeField]
		private MeshRenderer _galaxyMesh; // 0x168
		[SerializeField]
		private MeshRenderer _blitRenderer; // 0x170
		public float _LayersAlpha; // 0x178
		public float _GalaxyAlpha; // 0x17C
		public float _GalaxyScale; // 0x180
		public float _GalaxyForce; // 0x184
		private List<Tilemap> _layers; // 0x188
		private bool _canFire; // 0x190
		private bool _initialised; // 0x191
		private SpriteRenderer _background; // 0x198
		private Material _galaxyRTMaterial; // 0x1A0
		private bool _particlesGenerated; // 0x1A8
		private ParticleEmitterManager _particlesManager; // 0x1B0
		private ParticleSystem _pfxEmitter; // 0x1B8
		private GravityWell _well; // 0x1C0
		private Camera _mainCam; // 0x1C8
		private bool _canFadeTilemaps; // 0x1D0
	
		// Constructors
		public SoleSolutionWeapon() {} // 0x00000001870BF020-0x00000001870BF080
	
		// Methods
		private void LateUpdate() {} // 0x00000001870BB350-0x00000001870BB5B0
		public override float PInterval() => default; // 0x00000001870BB5B0-0x00000001870BB5C0
		public override void OnWeaponAdded() {} // 0x00000001870BB5C0-0x00000001870BB760
		public override float PPower() => default; // 0x00000001870BB760-0x00000001870BB870
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x00000001870BB870-0x00000001870BBD30
		private void KillTilemapFade() {} // 0x00000001870BBD30-0x00000001870BBD40
		protected override void OnDestroy() {} // 0x00000001870BBD40-0x00000001870BBE90
		public override void ParadoxFire() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977E3B */) {} // 0x00000001870BBE90-0x00000001870BC7D0
		protected override void OnPause() {} // 0x00000001870BC7D0-0x00000001870BC8E0
		protected override void OnResume() {} // 0x00000001870BC8E0-0x00000001870BCA00
		protected override void MakeLevelOne() {} // 0x00000001870BCA00-0x00000001870BCAB0
		private void GenerateParticleSystems() {} // 0x00000001870BCAB0-0x00000001870BD510
		private void InitialiseRT() {} // 0x00000001870BD510-0x00000001870BDBD0
		private void FadeOutLayers() {} // 0x00000001870BDBD0-0x00000001870BDF00
		private void RestoreLayers() {} // 0x00000001870BDF00-0x00000001870BE230
		private void SetLayersAlpha(float alpha) {} // 0x00000001870BE230-0x00000001870BE700
		private void Motion1() {} // 0x00000001870BE700-0x00000001870BEAB0
		private void Motion2() {} // 0x00000001870BEAB0-0x00000001870BEE60
		private void UpdateGalaxy() {} // 0x00000001870BEE60-0x00000001870BF020
	}
}
