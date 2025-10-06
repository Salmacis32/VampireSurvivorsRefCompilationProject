/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TrainHazardProjectile : Projectile // TypeDefIndex: 15976
	{
		// Fields
		private ParticleSystem _pfxEmitter; // 0xD0
		private float _defaultSpeed; // 0xD8
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer _soundEvent; // 0xE8
		private PhaserSprite _lightSprite; // 0xF0
	
		// Constructors
		public TrainHazardProjectile() {} // 0x0000000186E86680-0x0000000186E866D0
	
		// Methods
		protected override void Awake() {} // 0x0000000186E84F90-0x0000000186E85140
		public override void Despawn() {} // 0x0000000186E85140-0x0000000186E85180
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E85180-0x0000000186E85870
		public void PlaySounds() {} // 0x0000000186E85870-0x0000000186E85A20
		public override void InternalUpdate() {} // 0x0000000186E85A20-0x0000000186E85F30
		private void SetDepths() {} // 0x0000000186E85F30-0x0000000186E86100
		private void GeneratePfx() {} // 0x0000000186E86100-0x0000000186E86680
	}
}
