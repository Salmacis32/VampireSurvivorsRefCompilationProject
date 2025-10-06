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
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SpriteWhip_Projectile : Projectile // TypeDefIndex: 15681
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
		private bool _isDespawning; // 0x110
		private float _heightOffset; // 0x114
		private List<string> animNames; // 0x118
		private Tween _offsetTween; // 0x120
	
		// Constructors
		public TP_SpriteWhip_Projectile() {} // 0x0000000186D2B240-0x0000000186D2B4B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D29E40-0x0000000186D2A170
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D2A170-0x0000000186D2A860
		public override void InternalUpdate() {} // 0x0000000186D2A860-0x0000000186D2A870
		private void UpdatePosition() {} // 0x0000000186D2A870-0x0000000186D2ABA0
		private void SetupAnimations() {} // 0x0000000186D2ABA0-0x0000000186D2AF00
		protected virtual void OnAnimAttackComplete() {} // 0x0000000186D2AF00-0x0000000186D2B1B0
		public void StartDespawn() {} // 0x0000000186D2B1B0-0x0000000186D2B1E0
		public override void Despawn() {} // 0x0000000186D2B1E0-0x0000000186D2B240
	}
}
