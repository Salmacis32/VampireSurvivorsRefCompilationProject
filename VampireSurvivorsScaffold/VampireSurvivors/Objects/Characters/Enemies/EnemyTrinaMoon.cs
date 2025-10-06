/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyTrinaMoon : EnemyTrina // TypeDefIndex: 17416
	{
		// Fields
		private bool _hasShield; // 0x2B8
		private float _shieldDamage; // 0x2BC
		private VampireSurvivors.Framework.TimerSystem.Timer _timer; // 0x2C0
		public Action OnDefeat; // 0x2C8
	
		// Constructors
		public EnemyTrinaMoon() {} // 0x00000001872B5050-0x00000001872B50A0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B50A0-0x00000001872B5260
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978564 */, float damageKb = 1f /* Metadata: 0x01978565 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978569 */, bool hasKb = true /* Metadata: 0x0197856A */) {} // 0x00000001872B5260-0x00000001872B55A0
		protected override void Die() {} // 0x00000001872B55A0-0x00000001872B5620
	}
}
