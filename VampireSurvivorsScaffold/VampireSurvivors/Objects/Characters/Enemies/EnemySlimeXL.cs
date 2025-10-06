/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySlimeXL : EnemyController // TypeDefIndex: 17388
	{
		// Fields
		protected bool HasSpawned; // 0x270
		private MultiTargetTween _onEnterTween; // 0x278
	
		// Properties
		protected virtual int EnemiesToSpawnAmount { get => default; } // 0x0000000180B21570-0x0000000180B21580 
		protected virtual EnemyType EnemyToSpawnOnDeath { get => default; } // 0x0000000181E0B980-0x0000000181E0B990 
	
		// Constructors
		public EnemySlimeXL() {} // 0x000000018729D180-0x000000018729D1D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018729D1D0-0x000000018729D410
		protected override void Die() {} // 0x000000018729D410-0x000000018729D680
	}
}
