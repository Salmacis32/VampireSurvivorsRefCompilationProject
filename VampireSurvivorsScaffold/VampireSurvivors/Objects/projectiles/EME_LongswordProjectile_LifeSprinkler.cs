/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_LongswordProjectile_LifeSprinkler : Projectile // TypeDefIndex: 15799
	{
		// Fields
		[SerializeField]
		private ParticleSystem lifeSprinklerFullVFX; // 0xD0
		[SerializeField]
		private ParticleEventCall lifeSprinklerFullVFXParticleEventCall; // 0xD8
		[SerializeField]
		private ParticleSystem lifeSprinklerCrossVFX; // 0xE0
		[SerializeField]
		private ParticleEventCall lifeSprinklerCrossVFXParticleEventCall; // 0xE8
		private MultiTargetTween _despawnTween; // 0xF0
		private MultiTargetTween _alphaTween; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _hitboxTimer; // 0x100
		private MultiTargetTween _moveTween; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _movementTimer; // 0x110
		private EME_Longsword1Weapon _trueweapon; // 0x118
		private PhaserSprite cloneImage1; // 0x120
		private PhaserSprite cloneImage2; // 0x128
		private PhaserSprite cloneImage3; // 0x130
		private PhaserSprite cloneImage4; // 0x138
		private MultiTargetTween _fadeInClonesTween; // 0x140
		private MultiTargetTween _fadeClonesTween; // 0x148
	
		// Constructors
		public EME_LongswordProjectile_LifeSprinkler() {} // 0x0000000186DBF890-0x0000000186DBF8E0
	
		// Methods
		protected override void Awake() {} // 0x0000000186DBD400-0x0000000186DBD4A0
		private void MakeCloneSprites() {} // 0x0000000186DBD4A0-0x0000000186DBE1A0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186DBE1A0-0x0000000186DBF170
		private void GoToNearestEnemy() {} // 0x0000000186DBF170-0x0000000186DBF5F0
		public override void Despawn() {} // 0x0000000186DBF5F0-0x0000000186DBF6C0
		private void LateUpdate() {} // 0x0000000186DBF6C0-0x0000000186DBF800
		private void DespawnAfterParticlesToFinish() {} // 0x0000000186DBF800-0x0000000186DBF890
	}
}
