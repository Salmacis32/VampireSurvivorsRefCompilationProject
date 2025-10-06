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
	public class Sample2Projectile : Projectile // TypeDefIndex: 15453
	{
		// Fields
		private PhaserSprite sampleSprite; // 0xD0
		private PhaserSprite crystalSprite; // 0xD8
		private MultiTargetTween crystalTween; // 0xE0
		private Sample2Weapon trueWeapon; // 0xE8
		protected int[] tints; // 0xF0
		protected SfxType[] dropSounds; // 0xF8
		protected SfxType[] stepSounds; // 0x100
		private bool isInitialised; // 0x108
		private MultiTargetTween _moveXTween; // 0x110
		private MultiTargetTween _moveYTween; // 0x118
		private bool isBreaking; // 0x120
		private VampireSurvivors.Framework.TimerSystem.Timer _expireTimer; // 0x128
		private MultiTargetTween despawnTween; // 0x130
		private PhaserSprite overlaySprite; // 0x138
		private PhaserSprite numberSprite; // 0x140
		private MultiTargetTween overlayAlphaTween; // 0x148
		private MultiTargetTween numberSpriteTween; // 0x150
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0x158
		private MultiTargetTween enterTween; // 0x160
		private int assignedNumber; // 0x168
		private float2 playerOffset; // 0x16C
		private bool followOwner; // 0x174
	
		// Constructors
		public Sample2Projectile() {} // 0x0000000186C0F460-0x0000000186C0F6A0
	
		// Methods
		protected override void Awake() {} // 0x0000000186C0C540-0x0000000186C0C5E0
		public virtual void makeSprites() {} // 0x0000000186C0C5E0-0x0000000186C0CBD0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186C0CBD0-0x0000000186C0CE50
		public void SetFloorTarget(int showNumber, float2 targetPos, float delay, float activationDelay) {} // 0x0000000186C0CE50-0x0000000186C0D430
		public void Dropped() {} // 0x0000000186C0D430-0x0000000186C0DE70
		public void Break() {} // 0x0000000186C0DE70-0x0000000186C0E560
		protected void dropSound() {} // 0x0000000186C0E560-0x0000000186C0E6C0
		protected void breakSound() {} // 0x0000000186C0E6C0-0x0000000186C0E820
		public void StartDespawn() {} // 0x0000000186C0E820-0x0000000186C0EB00
		public void Shrink(bool alsoDespawn = false /* Metadata: 0x0197762C */) {} // 0x0000000186C0EB00-0x0000000186C0EE70
		public override void Despawn() {} // 0x0000000186C0EE70-0x0000000186C0EEF0
		public override void InternalUpdate() {} // 0x0000000186C0EEF0-0x0000000186C0EFD0
		private void checkOverlap(int tries) {} // 0x0000000186C0EFD0-0x0000000186C0F460
	}
}
