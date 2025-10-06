/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class VampiricaProjectile : Projectile // TypeDefIndex: 15980
	{
		// Fields
		private MultiTargetTween _tween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private SpriteRenderer _ghost1; // 0xE0
		private SpriteRenderer _ghost2; // 0xE8
		private bool _doneInit; // 0xF0
		private float _previousArea; // 0xF4
	
		// Constructors
		public VampiricaProjectile() {} // 0x0000000186E8F100-0x0000000186E8F150
	
		// Methods
		protected override void Awake() {} // 0x0000000186E8DF00-0x0000000186E8E350
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E8E350-0x0000000186E8F100
		public override void Despawn() {} // 0x0000000186C741B0-0x0000000186C741F0
	}
}
