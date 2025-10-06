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
	public class CorridorProjectile : Projectile // TypeDefIndex: 15415
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _CorridorBg; // 0xD0
		[SerializeField]
		private SpriteRenderer _CorridorLight; // 0xD8
		private Tween _angleTween; // 0xE0
		private Tween _scaleTween; // 0xE8
		private Tween _alphaTweenBg; // 0xF0
		private Tween _alphaTweenLight; // 0xF8
		private float _worldScreenHeight; // 0x100
		private float _targetScale; // 0x104
		private float _targetAlpha; // 0x108
		private float _startAlpha; // 0x10C
	
		// Constructors
		public CorridorProjectile() {} // 0x0000000186BDE900-0x0000000186BDE960
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BDD200-0x0000000186BDD520
		public override void InternalUpdate() {} // 0x0000000186BDD520-0x0000000186BDD7E0
		public override void Despawn() {} // 0x0000000186BDD7E0-0x0000000186BDDA70
		private void InAnim() {} // 0x0000000186BDDA70-0x0000000186BDE350
		private void OutAnim() {} // 0x0000000186BDE350-0x0000000186BDE900
	}
}
