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
	public class FB_HomingProjectile : Projectile // TypeDefIndex: 15473
	{
		// Fields
		[SerializeField]
		private SpriteAnimation _anim; // 0xD0
		public float2 _targetPosition; // 0xD8
		public float _timeSinceChangedTarget; // 0xE0
	
		// Constructors
		public FB_HomingProjectile() {} // 0x0000000186C23140-0x0000000186C23190
	
		// Methods
		protected override void Awake() {} // 0x0000000186C22630-0x0000000186C22990
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C22990-0x0000000186C22C30
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186C22C30-0x0000000186C23140
	}
}
