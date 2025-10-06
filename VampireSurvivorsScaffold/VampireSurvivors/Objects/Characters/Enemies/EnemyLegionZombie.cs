/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyLegionZombie : EnemyController // TypeDefIndex: 17240
	{
		// Fields
		private float _timeInMidair; // 0x270
		private bool _hasHitGround; // 0x274
		private EnemyLegion _legionBoss; // 0x278
	
		// Properties
		[Sync]
		public GameObject LegionBoss { get => default; set {} } // 0x0000000187201E30-0x0000000187201F30 0x0000000187201F30-0x00000001872020F0
	
		// Constructors
		public EnemyLegionZombie() {} // 0x0000000187202720-0x0000000187202770
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872020F0-0x00000001872025D0
		public void Setup(EnemyLegion legionBoss) {} // 0x0000000186753770-0x00000001867537D0
		protected override void OnUpdate() {} // 0x00000001872025D0-0x0000000187202720
	}
}
