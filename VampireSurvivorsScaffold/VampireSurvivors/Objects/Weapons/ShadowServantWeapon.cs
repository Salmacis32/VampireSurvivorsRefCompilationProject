/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class ShadowServantWeapon : Weapon // TypeDefIndex: 16173
	{
		// Fields
		private PhaserSprite _summonSprite; // 0x158
		private MultiTargetTween _summonTween; // 0x160
		private ParticleEmitterManager _particlesManager; // 0x168
		private GravityWell _well; // 0x170
		private WeaponType _counterWeaponType; // 0x178
		private ShadowServantCounterWeapon _counterWeapon; // 0x180
		[NonSerialized]
		public ParticleSystem PfxEmitter; // 0x188
		[NonSerialized]
		public string BaseSpriteName; // 0x190
		[NonSerialized]
		public string SnakeSpriteName; // 0x198
		[NonSerialized]
		public string SnakeDieSpriteName; // 0x1A0
		[NonSerialized]
		public string TrailSpriteName; // 0x1A8
	
		// Constructors
		public ShadowServantWeapon() {} // 0x0000000186F407E0-0x0000000186F40A00
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F3F080-0x0000000186F3FD20
		public override void CheckArcanas() {} // 0x0000000186F3FD20-0x0000000186F400F0
		public override bool LevelUp() => default; // 0x0000000186F400F0-0x0000000186F40210
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977BAC */) {} // 0x0000000186F40210-0x0000000186F40230
		public override void InternalUpdate() {} // 0x0000000186F40230-0x0000000186F40540
		private void SummonAnimation() {} // 0x0000000186F40540-0x0000000186F407E0
	}
}
