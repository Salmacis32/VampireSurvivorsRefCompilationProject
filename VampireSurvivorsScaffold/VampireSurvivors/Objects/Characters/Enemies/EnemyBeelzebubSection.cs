/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyBeelzebubSection : EnemyController // TypeDefIndex: 17229
	{
		// Fields
		public PhaserSprite[] _chains; // 0x270
		private bool _hasExplosions; // 0x278
		private List<PhaserSprite> explosionSprites; // 0x280
		private float offsetRadius; // 0x288
		private List<VampireSurvivors.Framework.TimerSystem.Timer> explosionTimers; // 0x290
		private int ExplosionsNumber; // 0x298
		private bool _isFalling; // 0x29C
		private float _fallTimer; // 0x2A0
		private List<PhaserSprite> _flies; // 0x2A8
		private float _flyMovementPhaseOffset; // 0x2B0
	
		// Constructors
		public EnemyBeelzebubSection() {} // 0x00000001871F4B10-0x00000001871F4C10
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001871F2A10-0x00000001871F2AF0
		[Command]
		public void OnlineSetupSection(CoherenceSync boss, bool hasChains, string spriteName, bool isHead) {} // 0x00000001871F2AF0-0x00000001871F2B90
		public void SetupBeelzebubSection(EnemyBeelzebub parentBoss, bool hasChains, string spriteName, bool isHead) {} // 0x00000001871F2B90-0x00000001871F2EB0
		private void SetupFlies() {} // 0x00000001871F2EB0-0x00000001871F3360
		protected override void OnUpdate() {} // 0x00000001871F3360-0x00000001871F3DE0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019782D6 */, float damageKb = 1f /* Metadata: 0x019782D7 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019782DB */, bool hasKb = true /* Metadata: 0x019782DC */) {} // 0x00000001871F3DE0-0x00000001871F3E00
		public override void Disappear() {} // 0x00000001871ECB40-0x00000001871ECB50
		protected override void Die() {} // 0x00000001871ECB40-0x00000001871ECB50
		public override void Despawn() {} // 0x00000001871F3E00-0x00000001871F3F30
		private void SetupExplosions() {} // 0x00000001871F3F30-0x00000001871F44C0
		private void PlayExplosions() {} // 0x00000001871F44C0-0x00000001871F4B10
	}
}
