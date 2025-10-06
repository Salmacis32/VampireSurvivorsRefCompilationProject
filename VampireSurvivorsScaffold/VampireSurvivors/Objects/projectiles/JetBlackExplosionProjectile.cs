/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class JetBlackExplosionProjectile : Projectile // TypeDefIndex: 15904
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _rockSprite; // 0xD0
		[SerializeField]
		private SpriteRenderer _starSprite; // 0xD8
		[SerializeField]
		private SpriteRenderer _starSprite2; // 0xE0
		[SerializeField]
		private SpriteRenderer _bubbleSprite; // 0xE8
		[SerializeField]
		private SpriteAnimation _animation; // 0xF0
		private bool _initialisedParticles; // 0xF8
		private MultiTargetTween _tween; // 0x100
		private MultiTargetTween _tween2; // 0x108
		private MultiTargetTween _tween3; // 0x110
		private MultiTargetTween _tween4; // 0x118
		private MultiTargetTween _tween5; // 0x120
		private MultiTargetTween _tween6; // 0x128
	
		// Constructors
		public JetBlackExplosionProjectile() {} // 0x0000000186E35D50-0x0000000186E35DA0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E34AA0-0x0000000186E34CB0
		private void OnRecycle(float salvoDuration) {} // 0x0000000186E34CB0-0x0000000186E35260
		private void DisplayMe(float salvoDuration) {} // 0x0000000186E35260-0x0000000186E35D50
	}
}
