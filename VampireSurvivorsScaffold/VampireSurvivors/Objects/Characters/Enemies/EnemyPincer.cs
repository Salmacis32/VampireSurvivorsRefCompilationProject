/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyPincer : EnemyController // TypeDefIndex: 17368
	{
		// Fields
		private int _lives; // 0x270
		private Tween _onEnterTween; // 0x278
	
		// Properties
		public Action OnDead { get; set; } // 0x00000001869A0820-0x00000001869A0830 0x00000001870EF820-0x00000001870EF880
	
		// Constructors
		public EnemyPincer() {} // 0x000000018728BF20-0x000000018728BF80
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018728B6C0-0x000000018728BB40
		protected override void OnUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void UpdateDepth() {} // 0x0000000180B15170-0x0000000180B15180
		public void SetDepth(float newDepth) {} // 0x000000018728BB40-0x000000018728BB70
		protected override void Die() {} // 0x000000018728BB70-0x000000018728BF20
	}
}
