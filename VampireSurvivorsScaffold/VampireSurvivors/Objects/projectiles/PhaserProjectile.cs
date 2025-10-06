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
	public class PhaserProjectile : Projectile // TypeDefIndex: 15939
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _whiteSprite; // 0xD0
		private bool _alreadyRecycled; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private MultiTargetTween _scaleTween; // 0xE8
		private PhaserWeapon _trueWeapon; // 0xF0
		private Transform _cachedSpriteTransform; // 0xF8
		protected float _screenScale; // 0x100
		protected float _scaleDuration; // 0x104
		protected float _projectileScale; // 0x108
		protected float heigthScale; // 0x10C
		protected float whiteScale; // 0x110
		protected uint[] _colors; // 0x118
	
		// Constructors
		public PhaserProjectile() {} // 0x0000000186E554C0-0x0000000186E555E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E555E0-0x0000000186E557E0
		protected virtual void Setuppo() {} // 0x0000000186E557E0-0x0000000186E558D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E558D0-0x0000000186E56190
		public virtual void SetSelfColor() {} // 0x0000000186E56190-0x0000000186E561E0
		public virtual void SetSelfScale() {} // 0x0000000186E561E0-0x0000000186E56200
		public override void Despawn() {} // 0x0000000186E56200-0x0000000186E562D0
		public override void InternalUpdate() {} // 0x0000000186E562D0-0x0000000186E56430
	}
}
