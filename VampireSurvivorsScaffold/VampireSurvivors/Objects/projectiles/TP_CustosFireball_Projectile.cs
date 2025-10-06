/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_CustosFireball_Projectile : Projectile // TypeDefIndex: 15519
	{
		// Fields
		private SpriteAnimation _anim; // 0xD0
		private ParticleSystem _pfxEmitter; // 0xD8
		private MultiTargetTween _scaleTween; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE8
	
		// Constructors
		public TP_CustosFireball_Projectile() {} // 0x0000000186C7B6B0-0x0000000186C7B700
	
		// Methods
		protected override void Awake() {} // 0x0000000186C79790-0x0000000186C79970
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C79970-0x0000000186C79F30
		public override void SetTarget(Transform target) {} // 0x0000000186C79F30-0x0000000186C7AF00
		public override void Despawn() {} // 0x0000000186C7AF00-0x0000000186C7AF40
		private void StartDespawn() {} // 0x0000000186C7AF40-0x0000000186C7B1D0
		private void GenerateParticleSystem() {} // 0x0000000186C7B1D0-0x0000000186C7B6B0
	}
}
