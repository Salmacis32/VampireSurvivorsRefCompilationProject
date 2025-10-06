/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyMinHealth_KillRatio : EnemyController // TypeDefIndex: 17357
	{
		// Fields
		private DG.Tweening.Sequence _onEnterTween; // 0x270
		private int _lives; // 0x278
	
		// Properties
		public TweenerCore<float, float, FloatOptions> AccelTween { get; set; } // 0x00000001869A0820-0x00000001869A0830 0x00000001870EF820-0x00000001870EF880
	
		// Constructors
		public EnemyMinHealth_KillRatio() {} // 0x0000000187285F80-0x0000000187285FE0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872856E0-0x0000000187285D30
		public override void OnTeleportOnCull() {} // 0x0000000187285D30-0x0000000187285E00
		private void Accelerate() {} // 0x0000000187285E00-0x0000000187285F80
		public override void Despawn() {} // 0x0000000187285600-0x0000000187285640
		protected override void Die() {} // 0x0000000187285640-0x0000000187285680
	}
}
