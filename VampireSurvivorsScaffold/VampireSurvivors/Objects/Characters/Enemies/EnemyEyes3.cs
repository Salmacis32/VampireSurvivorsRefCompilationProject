/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyEyes3 : EnemyController // TypeDefIndex: 17317
	{
		// Fields
		private bool _hasGeneratedSprites; // 0x270
		private PhaserSprite _eyes; // 0x278
		private MultiTargetTween _onEnterTween; // 0x280
	
		// Constructors
		public EnemyEyes3() {} // 0x0000000187263A70-0x0000000187263AC0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872630E0-0x0000000187263120
		private void LateUpdate() {} // 0x0000000187263120-0x0000000187263130
		private void UpdateEyes() {} // 0x0000000187263130-0x0000000187263540
		protected override void Die() {} // 0x0000000187263540-0x0000000187263580
		public override void Disappear() {} // 0x0000000187263580-0x00000001872635C0
		public override void Despawn() {} // 0x00000001872635C0-0x0000000187263600
		protected override void OnRecycleEnemy() {} // 0x0000000187263600-0x0000000187263870
		private void GenerateSprites() {} // 0x0000000187263870-0x0000000187263A70
	}
}
