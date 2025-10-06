/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class LegionnaireWeapon : SwordWeapon // TypeDefIndex: 16164
	{
		// Fields
		private BulletPool _legionnairePool; // 0x198
		private float _spawnRadius; // 0x1A0
		private PhaserSprite _cursor; // 0x1A8
		private Circle _spawnCircle; // 0x1B0
		private ParticleEmitterManager _pfxEmitterManager; // 0x1B8
		private ParticleSystem _smokeEmitter; // 0x1C0
	
		// Properties
		public ParticleSystem SmokeEmitter { get => default; } // 0x0000000185D99B30-0x0000000185D99B40 
	
		// Constructors
		public LegionnaireWeapon() {} // 0x0000000186F368C0-0x0000000186F36930
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186F35230-0x0000000186F35EC0
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977B9E */) {} // 0x0000000186F35EC0-0x0000000186F35F20
		protected override void OnStart() {} // 0x0000000186F35F20-0x0000000186F36130
		public void FireLegionnaire() {} // 0x0000000186F36130-0x0000000186F36510
		protected override void OnUpdate() {} // 0x0000000186F36510-0x0000000186F36730
		protected float CalcRadAngle(float x1, float y1, float x2, float y2) => default; // 0x0000000186F36730-0x0000000186F36750
		public override void CheckArcanas() {} // 0x0000000186F36750-0x0000000186F368C0
		protected override bool OnBulletOverlapsEnemy(CallbackContext context, ArcadeColliderType second, ArcadeColliderType first) => default; // 0x0000000186F33A30-0x0000000186F33A80
	}
}
