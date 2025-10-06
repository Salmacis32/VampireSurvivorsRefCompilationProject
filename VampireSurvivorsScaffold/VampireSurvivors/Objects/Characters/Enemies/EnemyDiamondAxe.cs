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
	public class EnemyDiamondAxe : EnemyAxeMotion // TypeDefIndex: 17293
	{
		// Fields
		private int _hitsTaken; // 0x280
		private bool _isInvul; // 0x284
		private bool _canBreak; // 0x285
		private string[] _availableFrames; // 0x288
		private VampireSurvivors.Framework.TimerSystem.Timer _selfTimer; // 0x290
		private float _invulDelay; // 0x298
	
		// Constructors
		public EnemyDiamondAxe() {} // 0x00000001872435C0-0x0000000187243780
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000187242A00-0x0000000187242A80
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187242A80-0x0000000187242E30
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019783FE */, float damageKb = 1f /* Metadata: 0x019783FF */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978403 */, bool hasKb = true /* Metadata: 0x01978404 */) {} // 0x0000000187242E30-0x0000000187242F60
		protected void ChangeFrame() {} // 0x0000000187242F60-0x0000000187243220
		protected override void Die() {} // 0x0000000187243220-0x00000001872435C0
	}
}
