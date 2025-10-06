/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SoulSteal_Weapon : Weapon // TypeDefIndex: 16487
	{
		// Fields
		private List<PhaserSprite> explosionSprites; // 0x158
		private int _exploIndex; // 0x160
		private bool _isManualFire; // 0x164
	
		// Constructors
		public TP_SoulSteal_Weapon() {} // 0x0000000186FF0BE0-0x0000000186FF0C30
	
		// Methods
		public void SetManualFire() {} // 0x0000000186FF0C30-0x0000000186FF0C50
		public override void Fire(bool skipTriggers = false /* Metadata: 0x01977CE0 */) {} // 0x0000000186FF0C50-0x0000000186FF1390
		protected override void Awake() {} // 0x0000000186FF1390-0x0000000186FF1890
		public void Hit(EnemyController enemyController) {} // 0x0000000186FF1890-0x0000000186FF19A0
		public override void ParadoxFire() {} // 0x0000000186FF19A0-0x0000000186FF1A50
		protected override FiringAnimation GetFiringAnimation() => default; // 0x0000000181BA4B30-0x0000000181BA4B40
		public override void ResetFiringTimer() {} // 0x0000000186FF1A50-0x0000000186FF1A80
		public override void SetVisible(bool visible) {} // 0x0000000186FF1A80-0x0000000186FF1BF0
	}
}
