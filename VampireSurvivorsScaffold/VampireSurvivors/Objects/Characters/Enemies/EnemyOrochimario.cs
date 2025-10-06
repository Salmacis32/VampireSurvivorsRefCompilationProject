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
	public class EnemyOrochimario : EnemyController // TypeDefIndex: 17362
	{
		// Fields
		private Vector2 _headOffset; // 0x270
		private Vector2 _invHeadOffset; // 0x278
		private List<EnemyOrochiHead> _headEnemies; // 0x280
		private MultiTargetTween _fadeTrailTween; // 0x288
		[SerializeField]
		private EnemyType _headEnemyType; // 0x290
	
		// Constructors
		public EnemyOrochimario() {} // 0x0000000187289560-0x0000000187289680
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187289030-0x0000000187289480
		public void PlayDeathAnimations() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void Die() {} // 0x0000000187289480-0x0000000187289560
		public override void Despawn() {} // 0x0000000187276E80-0x0000000187276E90
		protected override void OnUpdate() {} // 0x0000000187276E90-0x0000000187276FA0
	}
}
