/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Enemies;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLeftRight : EnemyController // TypeDefIndex: 17340
	{
		// Fields
		public const string ANIM_ALIAS_IDLE = "Alias_Idle"; // Metadata: 0x01978472
		public const string ANIM_ALIAS_DEATH = "Alias_Death"; // Metadata: 0x0197847D
		protected EnemyData _alias; // 0x270
		private bool _useAlias; // 0x278
	
		// Properties
		public EnemyData Alias { get => default; } // 0x0000000186A130F0-0x0000000186A13100 
	
		// Constructors
		public EnemyLeftRight() {} // 0x000000018727C950-0x000000018727C9A0
	
		// Methods
		private void CheckAlias() {} // 0x000000018727C2A0-0x000000018727C6C0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018727C6C0-0x000000018727C870
		public override void Disappear() {} // 0x000000018727C870-0x000000018727C8E0
		protected override void Die() {} // 0x000000018727C8E0-0x000000018727C950
	}
}
