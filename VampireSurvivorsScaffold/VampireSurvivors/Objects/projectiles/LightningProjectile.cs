/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class LightningProjectile : Projectile // TypeDefIndex: 15914
	{
		// Fields
		[SerializeField]
		private SpriteScroller _SpriteScroller; // 0xD0
		private Tween _moveTween; // 0xD8
		private Tween _despawnTween; // 0xE0
	
		// Constructors
		public LightningProjectile() {} // 0x0000000186E3D9E0-0x0000000186E3DA30
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E3CD00-0x0000000186E3D510
		[IteratorStateMachine(typeof(_DespawnInAFrame_d__4))]
		private IEnumerator DespawnInAFrame() => default; // 0x0000000186E3D510-0x0000000186E3D5B0
		public override void Despawn() {} // 0x0000000186E05F50-0x0000000186E05FE0
		private void Strike() {} // 0x0000000186E3D5B0-0x0000000186E3D9E0
	}
}
