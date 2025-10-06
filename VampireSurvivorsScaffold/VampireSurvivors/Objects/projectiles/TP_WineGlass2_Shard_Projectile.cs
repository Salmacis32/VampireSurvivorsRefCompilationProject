/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WineGlass2_Shard_Projectile : Projectile // TypeDefIndex: 15729
	{
		// Fields
		private List<string> frameNames; // 0xD0
		private bool hasHit; // 0xD8
		private PhaserSprite _sunraySprite; // 0xE0
		private VampireSurvivors.Framework.TimerSystem.Timer cullableTimer; // 0xE8
		private MultiTargetTween sunTween; // 0xF0
		private MultiTargetTween _scaleTween; // 0xF8
		private bool isDespawning; // 0x100
	
		// Constructors
		public TP_WineGlass2_Shard_Projectile() {} // 0x0000000186D57D50-0x0000000186D58DB0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D56B30-0x0000000186D56EF0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D56EF0-0x0000000186D57500
		protected override void OnHasHitAnObject(IDamageable other) {} // 0x0000000186D57500-0x0000000186D57590
		private void StartDespawn() {} // 0x0000000186D57590-0x0000000186D578B0
		public override void Despawn() {} // 0x0000000186D578B0-0x0000000186D57920
		private void BeamHere() {} // 0x0000000186D57920-0x0000000186D57D50
	}
}
