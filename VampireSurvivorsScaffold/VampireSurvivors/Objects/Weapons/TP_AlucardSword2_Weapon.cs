/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_AlucardSword2_Weapon : Weapon // TypeDefIndex: 16276
	{
		// Fields
		private const int MaxGhostsPerFire = 6; // Metadata: 0x01977BF6
		private int _totalOtherEvos; // 0x158
		private int _fireCounter; // 0x15C
	
		// Properties
		public int NumOtherEvos { get => default; } // 0x0000000186F877E0-0x0000000186F87800 
		public int ModFireCounter { get => default; } // 0x0000000186F87800-0x0000000186F87830 
	
		// Constructors
		public TP_AlucardSword2_Weapon() {} // 0x0000000186F87F70-0x0000000186F87FC0
	
		// Methods
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BF5 */) {} // 0x0000000186F87830-0x0000000186F87B80
		public override Projectile FireOneProjectile(Vector2 pos, int index, Transform target = null, BulletPool pool = null) => default; // 0x0000000186F87B80-0x0000000186F87BE0
		private void CheckOtherEvos() {} // 0x0000000186F87BE0-0x0000000186F87F70
	}
}
