/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EX_Gaea_Circle_Projectile : Projectile // TypeDefIndex: 15863
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer expireTimer; // 0xD0
		private bool _isDespawning; // 0xD8
		private Vector2 _collisionPos; // 0xDC
		private Vector2 _spritePos; // 0xE4
		private Transform _cachedSpriteTransform; // 0xF0
		private Material material; // 0xF8
		private static readonly int _matColor; // 0x00
		private static readonly int _matAlpha; // 0x04
		private static readonly int _matCutout; // 0x08
		private Tween angleTween; // 0x100
		private MultiTargetTween _tween1; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer hitboxTimer; // 0x110
		private Tween cutoutTween; // 0x118
		private List<Vector3> colors; // 0x120
	
		// Constructors
		public EX_Gaea_Circle_Projectile() {} // 0x0000000186DFBB10-0x0000000186DFBF50
		static EX_Gaea_Circle_Projectile() {} // 0x0000000186DFBF50-0x0000000186DFC010
	
		// Methods
		protected override void Awake() {} // 0x0000000186DFA890-0x0000000186DFA980
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DFA980-0x0000000186DFB7E0
		public override void Despawn() {} // 0x0000000186DFB7E0-0x0000000186DFB8A0
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186DFB8A0-0x0000000186DFBB10
	}
}
