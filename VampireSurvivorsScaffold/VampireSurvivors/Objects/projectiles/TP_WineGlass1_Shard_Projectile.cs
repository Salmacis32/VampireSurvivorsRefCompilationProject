/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_WineGlass1_Shard_Projectile : Projectile // TypeDefIndex: 15726
	{
		// Fields
		private PhaserSprite _shardSprite; // 0xD0
		private MultiTargetTween _scaleTween; // 0xD8
		private List<string> _shardSprites; // 0xE0
	
		// Constructors
		public TP_WineGlass1_Shard_Projectile() {} // 0x0000000186D54FE0-0x0000000186D551C0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D54390-0x0000000186D545D0
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D545D0-0x0000000186D54D20
		private void StartDespawn() {} // 0x0000000186D54D20-0x0000000186D54FB0
		public override void Despawn() {} // 0x0000000186D54FB0-0x0000000186D54FE0
	}
}
