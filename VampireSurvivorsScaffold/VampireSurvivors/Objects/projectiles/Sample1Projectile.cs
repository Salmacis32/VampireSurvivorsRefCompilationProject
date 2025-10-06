/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Sample1Projectile : Projectile // TypeDefIndex: 15451
	{
		// Fields
		private string[] frameNames; // 0xD0
		private PhaserSprite sampleSprite; // 0xD8
		private PhaserSprite crystalSprite; // 0xE0
		private MultiTargetTween crystalTween; // 0xE8
		private Sample1Weapon trueWeapon; // 0xF0
		protected int[] tints; // 0xF8
		protected SfxType[] dropSounds; // 0x100
		protected SfxType[] stepSounds; // 0x108
		private bool isInitialised; // 0x110
		private MultiTargetTween _moveXTween; // 0x118
		private MultiTargetTween _moveYTween; // 0x120
		private bool isBreaking; // 0x128
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x130
		private MultiTargetTween despawnTween; // 0x138
	
		// Constructors
		public Sample1Projectile() {} // 0x0000000186C0C180-0x0000000186C0C500
	
		// Methods
		public virtual void makeSprites() {} // 0x0000000186C0A330-0x0000000186C0A7D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C0A7D0-0x0000000186C0AD60
		public void SetFloorTarget(float duration, float2 targetPos) {} // 0x0000000186C0AD60-0x0000000186C0B210
		public void Dropped() {} // 0x0000000186C0B210-0x0000000186C0B390
		public void Break() {} // 0x0000000186C0B390-0x0000000186C0B830
		protected void dropSound() {} // 0x0000000186C0B830-0x0000000186C0B990
		protected void breakSound() {} // 0x0000000186C0B990-0x0000000186C0BAF0
		public void StartDespawn() {} // 0x0000000186C0BAF0-0x0000000186C0BDD0
		public void Shrink(bool alsoDespawn = false /* Metadata: 0x0197762B */) {} // 0x0000000186C0BDD0-0x0000000186C0C140
		public override void Despawn() {} // 0x0000000186C0C140-0x0000000186C0C180
	}
}
