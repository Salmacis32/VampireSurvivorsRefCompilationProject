/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Shuriken_Weapon : FB_QuantisedAngleWeapon // TypeDefIndex: 16474
	{
		// Fields
		private float _amount; // 0x160
		private List<float> _shuffledIndexes; // 0x168
	
		// Properties
		public override float QuantisationStep { get => default; } // 0x0000000185C0CCB0-0x0000000185C0CCC0 
	
		// Constructors
		public TP_Shuriken_Weapon() {} // 0x0000000186F6E850-0x0000000186F6E8A0
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CD8 */) {} // 0x0000000186FEE600-0x0000000186FEE7B0
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186FEE7B0-0x0000000186FEEA60
		public override void CheckArcanas() {} // 0x0000000186FEEA60-0x0000000186FEED80
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000180B21570-0x0000000180B21580
		private void GenerateShuffleIndexes(float amount) {} // 0x0000000186FEED80-0x0000000186FEEF00
	}
}
