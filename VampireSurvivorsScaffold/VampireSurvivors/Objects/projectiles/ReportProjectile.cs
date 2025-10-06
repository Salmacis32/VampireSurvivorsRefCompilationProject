/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Projectiles;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.projectiles
{
	public class ReportProjectile : Projectile // TypeDefIndex: 15183
	{
		// Fields
		[SerializeField]
		protected SpriteRenderer _visuals; // 0xD0
		[SerializeField]
		protected SpriteAnimation _anim; // 0xD8
		private float2 _firingDirection; // 0xE0
		[NonSerialized]
		public float _life; // 0xE8
		protected float2 offset; // 0xEC
		protected bool visualInitalised; // 0xF4
	
		// Properties
		protected virtual bool followPlayerFacing { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public ReportProjectile() {} // 0x0000000186A7EE30-0x0000000186A7EEA0
	
		// Methods
		protected virtual void InitVisuals() {} // 0x0000000186A7EEA0-0x0000000186A7EFE0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186A7EFE0-0x0000000186A7F8F0
		public override void InternalUpdate() {} // 0x0000000186A7F8F0-0x0000000186A7F9E0
	}
}
