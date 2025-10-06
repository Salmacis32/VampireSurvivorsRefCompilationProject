/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SacredBeast1_Bird_Projectile : Projectile // TypeDefIndex: 15643
	{
		// Fields
		private Vector3 _movement; // 0xD0
		private float _flipSwitch; // 0xDC
		[NonSerialized]
		public float orbitRadius; // 0xE0
		[NonSerialized]
		public float orbitAngle; // 0xE4
		private MultiTargetTween _speedTween; // 0xE8
		private MultiTargetTween _scaleTween; // 0xF0
		private float _spinDuration; // 0xF8
		private bool _rotatingState; // 0xFC
		private Vector3 _offset; // 0x100
		private SpriteAnimation _anim; // 0x110
	
		// Constructors
		public TP_SacredBeast1_Bird_Projectile() {} // 0x0000000186D04040-0x0000000186D040B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D03110-0x0000000186D03330
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D03330-0x0000000186D03C00
		public void shootDiscus() {} // 0x0000000186D03C00-0x0000000186D03DA0
		public override void InternalUpdate() {} // 0x0000000186D03DA0-0x0000000186D03FF0
		public override void Despawn() {} // 0x0000000186D03FF0-0x0000000186D04040
	}
}
