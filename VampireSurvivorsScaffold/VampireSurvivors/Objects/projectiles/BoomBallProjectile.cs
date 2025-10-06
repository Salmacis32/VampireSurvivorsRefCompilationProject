/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Interfaces;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class BoomBallProjectile : Projectile // TypeDefIndex: 15400
	{
		// Fields
		private bool alreadyRecycled; // 0xD0
		private bool alreadyGenerated; // 0xD1
		private bool IsExploding; // 0xD2
		private BallState State; // 0xD4
		private float maximizedTimer; // 0xD8
		private Flower2Weapon trueWeapon; // 0xE0
		private bool isFrozen; // 0xE8
		private float SpeedX; // 0xEC
		private float SpeedY; // 0xF0
		private float Radius; // 0xF4
		private float ExplodingSpeed; // 0xF8
		private float MAXRADIUS; // 0xFC
		private float MAXTIMER; // 0x100
		private float OffsetX; // 0x104
		private float OffsetY; // 0x108
		private float MoveSpeed; // 0x10C
		private MultiTargetTween splashTweenIn; // 0x110
		private MultiTargetTween splashTweenOut; // 0x118
		private MultiTargetTween finalTweenOut; // 0x120
		private List<uint> tints; // 0x128
		private MultiTargetTween enterTween; // 0x130
		private MultiTargetTween flowerTweenIn; // 0x138
		private PhaserSprite sprSplash; // 0x140
		private PhaserSprite sprFlower; // 0x148
		private PhaserSprite _GroundFx; // 0x150
		private PhaserSprite displaySprite; // 0x158
	
		// Properties
		public HashSet<IDamageable> objectsHit { get => default; } // 0x00000001827666D0-0x00000001827666E0 
	
		// Constructors
		public BoomBallProjectile() {} // 0x0000000186BBEA90-0x0000000186BBED30
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186BBBD30-0x0000000186BBC760
		public void Reset() {} // 0x0000000186BBC760-0x0000000186BBCB20
		public override void InternalUpdate() {} // 0x0000000186BBCB20-0x0000000186BBCE40
		public void CheckOverlap() {} // 0x0000000186BBCE40-0x0000000186BBD0B0
		public void Detonate() {} // 0x0000000186BBD0B0-0x0000000186BBD490
		public override void Despawn() {} // 0x0000000186BBD490-0x0000000186BBD6F0
		public void MakeProfusionSprites() {} // 0x0000000186BBD6F0-0x0000000186BBDF00
		public void PlayAnim() {} // 0x0000000186BBDF00-0x0000000186BBE700
		public void StopAnim() {} // 0x0000000186BBE700-0x0000000186BBEA90
	}
}
