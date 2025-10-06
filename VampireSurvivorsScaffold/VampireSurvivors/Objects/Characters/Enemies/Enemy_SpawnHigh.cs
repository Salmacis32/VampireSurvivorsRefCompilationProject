/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_SpawnHigh : EnemyController // TypeDefIndex: 17422
	{
		// Fields
		private DG.Tweening.Sequence _onEnterTween; // 0x270
		private VampireSurvivors.Framework.TimerSystem.Timer _cullableGraceTimer; // 0x278
	
		// Constructors
		public Enemy_SpawnHigh() {} // 0x00000001872B9C20-0x00000001872B9C70
	
		// Methods
		protected override void OnRecycleEnemy() {} // 0x00000001872B9670-0x00000001872B9740
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B9740-0x00000001872B9B40
		public override void Despawn() {} // 0x00000001872B9B40-0x00000001872B9B90
		protected override void Die() {} // 0x00000001872B9B90-0x00000001872B9BE0
		private void KillTweens() {} // 0x00000001872B9BE0-0x00000001872B9C20
	}
}
