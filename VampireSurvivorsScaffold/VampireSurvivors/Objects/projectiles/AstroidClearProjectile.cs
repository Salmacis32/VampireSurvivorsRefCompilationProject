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
	public class AstroidClearProjectile : Projectile // TypeDefIndex: 15438
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _baseSpriteRenderer; // 0xD0
		[SerializeField]
		private SpriteRenderer _ringRenderer; // 0xD8
		[SerializeField]
		private SpriteRenderer _rainbowRenderer; // 0xE0
		[SerializeField]
		private SpriteRenderer _raysRenderer; // 0xE8
		private MultiTargetTween _ttween6; // 0xF0
		private MultiTargetTween _ttween5; // 0xF8
		private MultiTargetTween _ttween3; // 0x100
		private MultiTargetTween _ttween4; // 0x108
		private MultiTargetTween _ttween4Alpha; // 0x110
		private MultiTargetTween _ttween2; // 0x118
		private MultiTargetTween _ttween1; // 0x120
		private AstroidClearWeapon _trueWeapon; // 0x128
		private bool _alreadyRecycled; // 0x130
	
		// Constructors
		public AstroidClearProjectile() {} // 0x0000000186BFD730-0x0000000186BFD780
	
		// Methods
		protected override void Awake() {} // 0x0000000186BFC1C0-0x0000000186BFC350
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BFC350-0x0000000186BFC5E0
		private void Detonate() {} // 0x0000000186BFC5E0-0x0000000186BFD660
		public override void Despawn() {} // 0x0000000186BFD660-0x0000000186BFD730
	}
}
