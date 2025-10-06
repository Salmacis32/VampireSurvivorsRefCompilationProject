/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyKitsune : EnemyController // TypeDefIndex: 17336
	{
		// Fields
		private Vector2 _headOffset; // 0x270
		private Vector2 _invHeadOffset; // 0x278
		private List<EnemyKitsuneTailTip> _headEnemies; // 0x280
		private MultiTargetTween _fadeTrailTween; // 0x288
	
		// Constructors
		public EnemyKitsune() {} // 0x0000000187276FA0-0x00000001872770B0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187276940-0x0000000187276DA0
		public void PlayDeathAnimations() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void Die() {} // 0x0000000187276DA0-0x0000000187276E80
		public override void Despawn() {} // 0x0000000187276E80-0x0000000187276E90
		protected override void OnUpdate() {} // 0x0000000187276E90-0x0000000187276FA0
	}
}
