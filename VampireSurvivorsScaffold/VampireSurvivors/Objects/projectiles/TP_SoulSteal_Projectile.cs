/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_SoulSteal_Projectile : Projectile // TypeDefIndex: 15670
	{
		// Fields
		private bool _tryAgain; // 0xD0
		private int _tries; // 0xD4
		private List<PhaserSprite> explosionSprites; // 0xD8
		private int _exploIndex; // 0xE0
		private TP_SoulSteal_Weapon _soulStealWeapon; // 0xE8
	
		// Constructors
		public TP_SoulSteal_Projectile() {} // 0x0000000186D1E260-0x0000000186D1E2B0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D1D3F0-0x0000000186D1D420
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D1D420-0x0000000186D1D550
		public override void InternalUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		public void DoSoulSteal(List<EnemyController> enemies) {} // 0x0000000186D1D550-0x0000000186D1DAE0
		private void DoSoulStealAgain(List<EnemyController> enemies) {} // 0x0000000186D1DAE0-0x0000000186D1E000
		private void CheckForDoSoulStealAgain(List<EnemyController> enemies) {} // 0x0000000186D1E000-0x0000000186D1E1C0
		public bool CheckHeart() => default; // 0x0000000186D1E1C0-0x0000000186D1E260
	}
}
