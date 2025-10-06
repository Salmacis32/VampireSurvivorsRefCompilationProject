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
	public class LegionnaireProjectile : Projectile // TypeDefIndex: 15421
	{
		// Fields
		private SpriteAnimation _spriteAnimation; // 0xD0
		private Color[][] _tints; // 0xD8
		private bool _hasAlreadyBeenRecycled; // 0xE0
		private MultiTargetTween _despawnTween; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		private LegionnaireWeapon _trueWeapon; // 0xF8
		private bool _isMoving; // 0x100
	
		// Properties
		public override float ProjectileSpeed { get => default; } // 0x0000000186BE3A10-0x0000000186BE3AD0 
	
		// Constructors
		public LegionnaireProjectile() {} // 0x0000000186BE4890-0x0000000186BE4B40
	
		// Methods
		protected override void Awake() {} // 0x0000000186BE3AD0-0x0000000186BE3B70
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BE3B70-0x0000000186BE4750
		public override void Despawn() {} // 0x0000000186BE4750-0x0000000186BE4770
		protected override void OnUpdate() {} // 0x0000000186BE4770-0x0000000186BE4890
	}
}
