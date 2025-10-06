/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class MedicalScanProjectile : Projectile // TypeDefIndex: 15993
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _medscanFront; // 0xD0
		private VampireSurvivors.Objects.Characters.CharacterController _targetPlayer; // 0xD8
		private float _animationT; // 0xE0
		private bool _isAnimating; // 0xE4
		protected PhaserSprite _explosionSprite; // 0xE8
		private PhaserSprite _rainbowSprite; // 0xF0
		private MultiTargetTween _rainbowTween; // 0xF8
		private MultiTargetTween _rainbowTween2; // 0x100
		private MultiTargetTween _highlightTween; // 0x108
		private MultiTargetTween _highlightTween2; // 0x110
	
		// Constructors
		public MedicalScanProjectile() {} // 0x0000000186E9CF00-0x0000000186E9CF50
	
		// Methods
		protected override void Awake() {} // 0x0000000186E9CF50-0x0000000186E9D6B0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E9D6B0-0x0000000186E9DA30
		public override void SetTarget(Transform target) {} // 0x0000000186E9DA30-0x0000000186E9DB40
		public override void InternalUpdate() {} // 0x0000000186E9DB40-0x0000000186E9E170
		protected virtual void ApplyScanEffect() {} // 0x0000000186E9E170-0x0000000186E9E5E0
		public void LateUpdate() {} // 0x0000000186E9E5E0-0x0000000186E9E700
		protected float GetRadius() => default; // 0x0000000186E9E700-0x0000000186E9E820
		public override void Despawn() {} // 0x0000000186E9E820-0x0000000186E9E8A0
	}
}
