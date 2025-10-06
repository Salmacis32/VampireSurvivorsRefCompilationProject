/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_AuraBlast2_HellfireProjectile : Projectile // TypeDefIndex: 15502
	{
		// Fields
		[SerializeField]
		private SpriteTrail _Trail; // 0xD0
		private const float Radius = 16f; // Metadata: 0x01977663
		private const float Gravity = 6.25f; // Metadata: 0x01977667
		private Vector2 _velocity; // 0xD8
		private int _flipSwitch; // 0xE0
		private PhaserSprite _hellfireSprite; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
	
		// Constructors
		public TP_AuraBlast2_HellfireProjectile() {} // 0x0000000186C67620-0x0000000186C67670
	
		// Methods
		protected override void Awake() {} // 0x0000000186C65CA0-0x0000000186C661A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C661A0-0x0000000186C666D0
		private void InitSprites() {} // 0x0000000186C666D0-0x0000000186C66730
		private void InitTrail() {} // 0x0000000186C66730-0x0000000186C668B0
		private void InitVelocity() {} // 0x0000000186C668B0-0x0000000186C66A40
		private void ScaleIn() {} // 0x0000000186C66A40-0x0000000186C66CF0
		private void PlaySfx() {} // 0x0000000186C66CF0-0x0000000186C66E10
		public override void InternalUpdate() {} // 0x0000000186C66E10-0x0000000186C66F50
		private void UpdateVelocity() {} // 0x0000000186C66F50-0x0000000186C671F0
		private void CheckForDespawn() {} // 0x0000000186C671F0-0x0000000186C67330
		public override void Despawn() {} // 0x0000000186C67330-0x0000000186C67440
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C67440-0x0000000186C67550
		protected override void OnHasHitAnotherPlayerObject(IDamageable other) {} // 0x0000000186C67550-0x0000000186C67560
		private void OnHasHitAnObjectLogic(IDamageable other) {} // 0x0000000186C67560-0x0000000186C67620
	}
}
