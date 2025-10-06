/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VentProjectile : Projectile // TypeDefIndex: 16005
	{
		// Fields
		[SerializeField]
		private Material _dummySpriteMaterial; // 0xD0
		private int _uses; // 0xD8
		private float selfScale; // 0xDC
		private bool _readyForUse; // 0xE0
		protected PhaserSprite _ventSprite; // 0xE8
		protected PhaserSprite _blackHoleSprite; // 0xF0
		private MultiTargetTween _currentTween; // 0xF8
		private List<VentUsageSlot> _usageSlots; // 0x100
		private int _currentlyAnimatingCount; // 0x108
		private float _repeatIntervalCounter; // 0x10C
	
		// Properties
		public bool CanSuckMore { get => default; } // 0x0000000186EA8520-0x0000000186EA8550 
		public PhaserSprite VentSprite { get => default; } // 0x0000000182766DD0-0x0000000182766DE0 
	
		// Nested types
		private class VentUsageSlot // TypeDefIndex: 16001
		{
			// Fields
			public SpriteRenderer _dummySprite; // 0x10
			public MultiTargetTween _currentTween; // 0x18
	
			// Constructors
			public VentUsageSlot() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public VentProjectile() {} // 0x0000000186EAAFE0-0x0000000186EAB0E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186EA8550-0x0000000186EA88A0
		public override void InternalUpdate() {} // 0x0000000186EA88A0-0x0000000186EA8ED0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186EA8ED0-0x0000000186EA9610
		private void Activate() {} // 0x0000000184E07E20-0x0000000184E07E30
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186EA9610-0x0000000186EA9630
		private VentUsageSlot CreateNewSlot() => default; // 0x0000000186EA9630-0x0000000186EA9840
		public void DoVentHit(IDamageable other) {} // 0x0000000186EA9610-0x0000000186EA9630
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186EA9840-0x0000000186EAA140
		private void UpdateClipping(SpriteRenderer dummySprite, float offset = 0f /* Metadata: 0x019779D2 */) {} // 0x0000000186EAA140-0x0000000186EAA210
		private void ReturnFromVent(ArcadeSprite phaserObject, object[] tweenTargets, VentUsageSlot slot) {} // 0x0000000186EAA210-0x0000000186EAA8C0
		private void UseFinished(VentUsageSlot slot) {} // 0x0000000186EAA8C0-0x0000000186EAA9D0
		private void FadeOut() {} // 0x0000000186EAA9D0-0x0000000186EAAD20
		public void AddUses(int uses) {} // 0x0000000186EAAD20-0x0000000186EAAD30
		public bool IsAnimating() => default; // 0x0000000186EAAD30-0x0000000186EAAE30
		public override void Despawn() {} // 0x0000000186EAAE30-0x0000000186EAAFE0
	}
}
