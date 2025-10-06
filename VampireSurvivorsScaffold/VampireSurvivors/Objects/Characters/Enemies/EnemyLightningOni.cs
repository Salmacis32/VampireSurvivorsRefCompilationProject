/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLightningOni : EnemyController // TypeDefIndex: 17343
	{
		// Fields
		private int _activated; // 0x270
		private bool _performingDeath; // 0x274
	
		// Constructors
		public EnemyLightningOni() {} // 0x000000018727D020-0x000000018727D070
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018727C9A0-0x000000018727C9F0
		public override void Disappear() {} // 0x000000018727C9F0-0x000000018727CA00
		protected override void OnUpdate() {} // 0x000000018727CA00-0x000000018727CAD0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978489 */, float damageKb = 1f /* Metadata: 0x0197848A */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197848E */, bool hasKb = true /* Metadata: 0x0197848F */) {} // 0x000000018727CAD0-0x000000018727CB00
		[Command]
		public void OnlineDie(long startingSimFrame) {} // 0x000000018727CB00-0x000000018727CBE0
		protected override void Die() {} // 0x000000018727CBE0-0x000000018727CD30
		private void PerformDeath() {} // 0x000000018727CD30-0x000000018727D020
	}
}
