/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Ex_Magistone1_Projectile : Projectile // TypeDefIndex: 15865
	{
		// Fields
		[SerializeField]
		private List<MeshRenderer> _GemMeshes; // 0xD0
		[SerializeField]
		private GameObject _MeshContainer; // 0xD8
		[SerializeField]
		private SpriteRenderer _ShadowSprite; // 0xE0
		private const float Radius = 56f; // Metadata: 0x0197790D
		private const float MinRotateDuration = 2f; // Metadata: 0x01977911
		private const float MaxRotateDuration = 3f; // Metadata: 0x01977915
		private Ex_Magistone1_Weapon _trueWeapon; // 0xE8
		private MeshRenderer _gemMesh; // 0xF0
		private int _meshIndex; // 0xF8
		private uint _tint; // 0xFC
		private int _spawnCounter; // 0x100
		private float _spawnOffsetY; // 0x104
		private Tween _posTween; // 0x108
		private Tween _angleTween; // 0x110
		private Tween _shadowFadeTween; // 0x118
		private Tween _shadowScaleTween; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
	
		// Constructors
		public Ex_Magistone1_Projectile() {} // 0x0000000186DFFD90-0x0000000186DFFDE0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DFDC10-0x0000000186DFDD80
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DFDD80-0x0000000186DFE290
		public void SetSpawnOffsetY(float spawnOffsetY) {} // 0x0000000186DFE290-0x0000000186DFE2A0
		private void SetupGemMesh() {} // 0x0000000186DFE2A0-0x0000000186DFE5E0
		public void InitRotation() {} // 0x0000000186DFE5E0-0x0000000186DFE9D0
		private void DropGem() {} // 0x0000000186DFE9D0-0x0000000186DFEE90
		private void DoShadowTween(Vector2 position, float tweenDuration, Ease ease) {} // 0x0000000186DFEE90-0x0000000186DFF3E0
		private void SpawnFragments() {} // 0x0000000186DFF3E0-0x0000000186DFF990
		private void PlaySfx() {} // 0x0000000186DFF990-0x0000000186DFFB70
		private float GetScaledAlpha() => default; // 0x0000000186DFFB70-0x0000000186DFFBE0
		public override void Despawn() {} // 0x0000000186DFFBE0-0x0000000186DFFD90
	}
}
