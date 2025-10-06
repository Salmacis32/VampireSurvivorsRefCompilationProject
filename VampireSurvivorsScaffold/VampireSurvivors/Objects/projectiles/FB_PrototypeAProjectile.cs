/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class FB_PrototypeAProjectile : Projectile // TypeDefIndex: 15482
	{
		// Fields
		private float _offset; // 0xD0
		private float _offsetDist; // 0xD4
		private float2 _centralPos; // 0xD8
		private Vector3 _direction; // 0xE0
		private SpriteAnimation _anims; // 0xF0
		private float _wArea; // 0xF8
		private float _MaxAlpha; // 0xFC
		private float _AlphaDiff; // 0x100
	
		// Constructors
		public FB_PrototypeAProjectile() {} // 0x0000000186C2D920-0x0000000186C2D990
	
		// Methods
		protected override void Awake() {} // 0x0000000186C2CF90-0x0000000186C2D210
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C2D210-0x0000000186C2D420
		public override void InternalUpdate() {} // 0x0000000186C2D420-0x0000000186C2D680
		protected override void OnHasHitAnObject(IDamageable target) {} // 0x0000000186C2D680-0x0000000186C2D690
		protected override void OnHasHitAnotherPlayerObject(IDamageable target) {} // 0x0000000186C2D690-0x0000000186C2D760
		private void OnHasHitAnObjectLogic(IDamageable target, bool triggerHit) {} // 0x0000000186C2D760-0x0000000186C2D920
	}
}
