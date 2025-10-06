/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SarabandeProjectile : Projectile // TypeDefIndex: 15948
	{
		// Fields
		private Tween _alphaTween; // 0xD0
		private Tween _scaleTween; // 0xD8
		private Transform _cachedOwnerTransform; // 0xE0
		private float _radius; // 0xE8
		private float _standardPxSize; // 0xEC
		private PhaserSprite _juliaSprite; // 0xF0
		private Transform _juliaTransform; // 0xF8
		private List<string> _doilies; // 0x100
		private SarabandeWeapon _trueWeapon; // 0x108
	
		// Constructors
		public SarabandeProjectile() {} // 0x0000000186E66A00-0x0000000186E66ED0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E65420-0x0000000186E65540
		private void NormalAttack() {} // 0x0000000186E65540-0x0000000186E65BD0
		public void JuliaAttack() {} // 0x0000000186E65BD0-0x0000000186E66770
		public override void InternalUpdate() {} // 0x0000000186E66770-0x0000000186E668E0
		public override void Despawn() {} // 0x0000000186E668E0-0x0000000186E66A00
	}
}
