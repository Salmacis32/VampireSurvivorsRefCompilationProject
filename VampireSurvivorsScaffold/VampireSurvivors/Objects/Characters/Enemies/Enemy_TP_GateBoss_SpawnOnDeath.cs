/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_GateBoss_SpawnOnDeath : Enemy_TP_GateBoss // TypeDefIndex: 17262
	{
		// Fields
		[SerializeField]
		public EnemyType ToSpawnOnDeath; // 0x3A8
	
		// Constructors
		public Enemy_TP_GateBoss_SpawnOnDeath() {} // 0x0000000187225300-0x0000000187225310
	
		// Methods
		public override void Despawn() {} // 0x0000000187225540-0x0000000187225820
		protected override void DoDeathAnimation() {} // 0x0000000187225820-0x0000000187225B20
		private void SpawnNewEnemy(float2 position) {} // 0x0000000187225B20-0x0000000187225D30
	}
}
