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
	public class EnemyUpDown : EnemyController // TypeDefIndex: 17417
	{
		// Fields
		public const string ANIM_ALIAS_IDLE = "Alias_Idle"; // Metadata: 0x0197856B
		public const string ANIM_ALIAS_DEATH = "Alias_Death"; // Metadata: 0x01978576
		private bool _useAlias; // 0x270
		private EnemyData _alias; // 0x278
	
		// Constructors
		public EnemyUpDown() {} // 0x00000001872B5BE0-0x00000001872B5C30
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872B5640-0x00000001872B5B00
		protected override void Die() {} // 0x00000001872B5B00-0x00000001872B5B70
		public override void Disappear() {} // 0x00000001872B5B70-0x00000001872B5BE0
	}
}
