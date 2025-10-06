/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_PlatinumWhip1_Projectile : Projectile // TypeDefIndex: 15626
	{
		// Fields
		private int AnimFPS; // 0xD0
		private SpriteAnimation _anim; // 0xD8
		private MultiTargetTween _alphaTween; // 0xE0
		private bool _cachedFlipX; // 0xE8
		private PhaserSprite _animatedSprite; // 0xF0
		private Vector3 _directionalOffset; // 0xF8
		private float _bodyRadius; // 0x104
		private float _extensionLength; // 0x108
		private float _extensionDuration; // 0x10C
		private float _heightOffset; // 0x110
		private List<string> animNames; // 0x118
	
		// Constructors
		public TP_PlatinumWhip1_Projectile() {} // 0x0000000186CF2000-0x0000000186CF21A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186CF0BD0-0x0000000186CF10C0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186CF10C0-0x0000000186CF16C0
		public override void InternalUpdate() {} // 0x0000000186CF16C0-0x0000000186CF16D0
		private void UpdatePosition() {} // 0x0000000186CF16D0-0x0000000186CF1A00
		private void SetupAnimations() {} // 0x0000000186CF1A00-0x0000000186CF1BB0
		protected virtual void OnAnimAttackComplete() {} // 0x0000000186CF1BB0-0x0000000186CF1E60
		private void AlphaTweenFinished() {} // 0x0000000186CF1E60-0x0000000186CF1EE0
		public override void Despawn() {} // 0x0000000186CF1EE0-0x0000000186CF2000
	}
}
