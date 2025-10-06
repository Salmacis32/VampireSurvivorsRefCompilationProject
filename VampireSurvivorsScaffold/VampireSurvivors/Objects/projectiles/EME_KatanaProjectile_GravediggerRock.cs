/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KatanaProjectile_GravediggerRock : Projectile // TypeDefIndex: 15781
	{
		// Fields
		private const float Radius = 16f; // Metadata: 0x0197784A
		private const float AreaMultiplier = 0.7f; // Metadata: 0x0197784E
		private Vector2 _velocity; // 0xD0
		private Tween _angleTween; // 0xD8
		private Tween _scaleTween; // 0xE0
	
		// Constructors
		public EME_KatanaProjectile_GravediggerRock() {} // 0x0000000186D8B6A0-0x0000000186D8B6F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D8ADB0-0x0000000186D8AFB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D8AFB0-0x0000000186D8B5E0
		public override void InternalUpdate() {} // 0x0000000186D8B5E0-0x0000000186D8B650
		public override void Despawn() {} // 0x0000000186D8B650-0x0000000186D8B6A0
	}
}
