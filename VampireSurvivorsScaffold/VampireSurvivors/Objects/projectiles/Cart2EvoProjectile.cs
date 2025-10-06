/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Cart2EvoProjectile : Projectile // TypeDefIndex: 15406
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _CartSprite; // 0xD0
		[SerializeField]
		private SpriteRenderer _LightSprite; // 0xD8
		private const float Radius = 75f; // Metadata: 0x01977612
		private Cart2EvoWeapon _trueWeapon; // 0xE0
		private Bounds _camBounds; // 0xE8
		private ParticleSystem _pfxEmitter; // 0x100
		private float _cachedSpeed; // 0x108
		private float _cachedArea; // 0x10C
		private bool _isOnScreen; // 0x110
		private bool _canDespawn; // 0x111
		private bool _isFlipped; // 0x112
		private int _flipSwitch; // 0x114
	
		// Properties
		public bool IsLastCart { get; set; } // 0x00000001865DBE60-0x00000001865DBE70 0x00000001867531A0-0x00000001867531B0
		public bool IsFlipped { get => default; } // 0x0000000185DD4F00-0x0000000185DD4F10 
	
		// Constructors
		public Cart2EvoProjectile() {} // 0x0000000186BCB3F0-0x0000000186BCB440
	
		// Methods
		protected override void Awake() {} // 0x0000000186BC9B50-0x0000000186BC9B70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BC9B70-0x0000000186BC9D60
		public override void InternalUpdate() {} // 0x0000000186BC9D60-0x0000000186BC9E30
		private void UpdatePosition() {} // 0x0000000186BC9E30-0x0000000186BCA020
		private void CheckForDespawn() {} // 0x0000000186BCA020-0x0000000186BCA0E0
		public void SetFlipped(bool flipped) {} // 0x0000000186BCA0E0-0x0000000186BCA340
		private void InitSprites() {} // 0x0000000186BCA340-0x0000000186BCA530
		private void SetBody() {} // 0x0000000186BCA530-0x0000000186BCA600
		private void SetDepths() {} // 0x0000000186BCA600-0x0000000186BCA7F0
		private void GeneratePfx() {} // 0x0000000186BCA7F0-0x0000000186BCAD70
		private void UpdatePfx() {} // 0x0000000186BCAD70-0x0000000186BCB030
		public override void Despawn() {} // 0x0000000186BCB030-0x0000000186BCB0B0
		private void CheckForTrainTrackFadeOut() {} // 0x0000000186BCB0B0-0x0000000186BCB3F0
	}
}
