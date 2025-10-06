/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SacredBeast1_Dragon_Projectile : Projectile // TypeDefIndex: 15644
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xD0
		private float _offset; // 0xD8
		private Vector2 _direction; // 0xDC
		private float2 _centralPos; // 0xE4
		private float _offsetDist; // 0xEC
	
		// Constructors
		public TP_SacredBeast1_Dragon_Projectile() {} // 0x0000000186D04870-0x0000000186D04960
	
		// Methods
		protected override void Awake() {} // 0x0000000186D040B0-0x0000000186D04150
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D04150-0x0000000186D04490
		public override void InternalUpdate() {} // 0x0000000186D04490-0x0000000186D04610
		public float2 PickPosition() => default; // 0x0000000186D04610-0x0000000186D04840
		public override void Despawn() {} // 0x0000000186D04840-0x0000000186D04870
	}
}
