/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_VampireKiller_Fire_Projectile : Projectile // TypeDefIndex: 15715
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private Tween _scaleTween; // 0xD8
		private PhaserSprite _animatedSprite; // 0xE0
		private uint[] _tints; // 0xE8
		private bool _isDespawning; // 0xF0
	
		// Constructors
		public TP_VampireKiller_Fire_Projectile() {} // 0x0000000186D4A330-0x0000000186D4A420
	
		// Methods
		protected override void Awake() {} // 0x0000000186D48B80-0x0000000186D48EB0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D48EB0-0x0000000186D492E0
		public void SetAngleVelocity_Deg(float angleDeg) {} // 0x0000000186D492E0-0x0000000186D49640
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D49640-0x0000000186D49AB0
		public void StartDespawn() {} // 0x0000000186D49AB0-0x0000000186D49B00
		private void GenerateParticleSystem() {} // 0x0000000186D49B00-0x0000000186D4A330
		public override void Despawn() {} // 0x0000000186C80530-0x0000000186C80560
	}
}
