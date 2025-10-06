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
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class Cart2EvoWeapon : Weapon // TypeDefIndex: 16150
	{
		// Fields
		private const float CartWidth = 3.1f; // Metadata: 0x01977B8A
		private const float LightWidth = 2.6f; // Metadata: 0x01977B8E
		private Camera _mainCamera; // 0x158
		private Transform _topTrackContainer; // 0x160
		private Transform _bottomTrackContainer; // 0x168
		private List<PhaserSprite> _topTracks; // 0x170
		private List<PhaserSprite> _bottomTracks; // 0x178
		private int _fireCounter; // 0x180
		private bool _hasImage; // 0x184
		private bool _hasCharacterImage; // 0x185
		private PhaserSprite _backSprite; // 0x188
		private Cart2Weapon _cartWeapon; // 0x190
		private bool _totalDamageCalculated; // 0x198
	
		// Properties
		public float ScaleMultiplier { get; } // 0x00000001847566B0-0x00000001847566C0 
	
		// Constructors
		public Cart2EvoWeapon() {} // 0x0000000186F2E260-0x0000000186F2E3E0
	
		// Methods
		public override float PPower() => default; // 0x0000000186F2B880-0x0000000186F2B980
		public override float PArea() => default; // 0x0000000186F2B980-0x0000000186F2B9B0
		public override float PSpeed() => default; // 0x0000000186F2B9B0-0x0000000186F2B9E0
		protected override void Awake() {} // 0x0000000186F2B9E0-0x0000000186F2BA60
		protected override void OnStart() {} // 0x0000000186F2BA60-0x0000000186F2BA80
		private void CreateDetachedCartWeapon() {} // 0x0000000186F2BA80-0x0000000186F2BE20
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F2BE20-0x0000000186F2BF10
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B89 */) {} // 0x0000000186F2BF10-0x0000000186F2C590
		private void PlaySfx(int amount) {} // 0x0000000186F2C590-0x0000000186F2C710
		private void GenerateTrainTracks(Vector2 startPos) {} // 0x0000000186F2C710-0x0000000186F2D1E0
		private void UpdateTrainTrack(bool flipped, float yOffset) {} // 0x0000000186F2D1E0-0x0000000186F2D660
		public void ShowTrainTrack(bool show, bool flipped) {} // 0x0000000186F2D660-0x0000000186F2D820
		public override void InternalUpdate() {} // 0x0000000186F2D820-0x0000000186F2D9B0
		public override void Fire() {} // 0x0000000186F2D9B0-0x0000000186F2D9E0
		private void UpdateFiringInterval() {} // 0x0000000186F2D9E0-0x0000000186F2DA90
		private void UpdateCartWeapon() {} // 0x0000000186F2DA90-0x0000000186F2DB80
		public override void ResetFiringTimer() {} // 0x0000000186F2DB80-0x0000000186F2DBA0
		public override float CalculateTotalDamage() => default; // 0x0000000186F2DBA0-0x0000000186F2DBF0
		protected override void OnUpdate() {} // 0x0000000186F2DBF0-0x0000000186F2DC20
		private void InitImage() {} // 0x0000000186F2DC20-0x0000000186F2DF00
		private void UpdateImage() {} // 0x0000000186F2DF00-0x0000000186F2DFA0
		public override void SetVisible(bool visible) {} // 0x0000000186F2DFA0-0x0000000186F2E0A0
		public override void Cleanup() {} // 0x0000000186F2E0A0-0x0000000186F2E1B0
		private void LateUpdate() {} // 0x0000000186F2E1B0-0x0000000186F2E260
	}
}
