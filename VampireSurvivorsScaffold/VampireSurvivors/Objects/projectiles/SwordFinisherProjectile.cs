/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class SwordFinisherProjectile : Projectile // TypeDefIndex: 15972
	{
		// Fields
		private MultiTargetTween _scaleTween; // 0xD0
		private MultiTargetTween _tween2; // 0xD8
		private PhaserSprite _highlightSprite; // 0xE0
		private MultiTargetTween _posTween; // 0xE8
		private MultiTargetTween _alphaTween; // 0xF0
		private PhaserSprite _crackSprite; // 0xF8
		private MultiTargetTween _damageTween; // 0x100
		private MultiTargetTween _fadeOutTween; // 0x108
		private MultiTargetTween _alphaCrackTween; // 0x110
		private float spriteRatio; // 0x118
		private SwordWeapon _trueWeapon; // 0x120
		private ParticleSystem _pfxEmitter; // 0x128
		private PhaserSprite _impactSprite; // 0x130
		private MultiTargetTween _impactTween; // 0x138
		public float sfxVolume; // 0x140
	
		// Constructors
		public SwordFinisherProjectile() {} // 0x0000000186E7F420-0x0000000186E7F490
	
		// Methods
		protected override void Awake() {} // 0x0000000186E7D260-0x0000000186E7D780
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E7D780-0x0000000186E7F420
	}
}
