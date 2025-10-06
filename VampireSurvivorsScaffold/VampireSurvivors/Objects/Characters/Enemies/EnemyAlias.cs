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
	public class EnemyAlias : EnemyController // TypeDefIndex: 17273
	{
		// Fields
		public const string ANIM_ALIAS_IDLE = "Alias_Idle"; // Metadata: 0x01978333
		public const string ANIM_ALIAS_DEATH = "Alias_Death"; // Metadata: 0x0197833E
		protected EnemyData _alias; // 0x270
	
		// Properties
		public EnemyData Alias { get => default; } // 0x0000000186A130F0-0x0000000186A13100 
	
		// Constructors
		public EnemyAlias() {} // 0x000000018722AA00-0x000000018722AA50
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018722A200-0x000000018722A740
		public override void Disappear() {} // 0x000000018722A740-0x000000018722A8A0
		protected override void Die() {} // 0x000000018722A8A0-0x000000018722AA00
	}
}
