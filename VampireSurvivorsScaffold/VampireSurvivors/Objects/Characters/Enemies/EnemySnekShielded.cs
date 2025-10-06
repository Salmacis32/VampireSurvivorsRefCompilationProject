/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySnekShielded : EnemyController // TypeDefIndex: 17392
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _shieldTimer; // 0x270
		private bool _hasShield; // 0x278
		private float _shieldDamage; // 0x27C
		private float _shieldDuration; // 0x280
	
		// Constructors
		public EnemySnekShielded() {} // 0x000000018729E860-0x000000018729E8C0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018729E100-0x000000018729E270
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784F6 */, float damageKb = 1f /* Metadata: 0x019784F7 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784FB */, bool hasKb = true /* Metadata: 0x019784FC */) {} // 0x000000018729E270-0x000000018729E560
		protected override void OnUpdate() {} // 0x000000018729E560-0x000000018729E580
		private void SnakeUpdate() {} // 0x000000018729E580-0x000000018729E860
	}
}
