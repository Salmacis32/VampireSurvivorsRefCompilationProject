/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_DeathScythe : EnemyController // TypeDefIndex: 17250
	{
		// Fields
		private float2 _targetScreenPoint; // 0x270
	
		// Properties
		[Sync]
		public Vector2 BodyVelocity { get => default; set {} } // 0x0000000187218410-0x0000000187218480 0x0000000187218480-0x00000001872184B0
	
		// Constructors
		public Enemy_TP_DeathScythe() {} // 0x0000000187218EA0-0x0000000187218EF0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872184B0-0x00000001872186C0
		private void PickRandomScreenPoint() {} // 0x00000001872186C0-0x00000001872188E0
		protected override void Die() {} // 0x00000001872188E0-0x00000001872188F0
		public override void Disappear() {} // 0x00000001872182C0-0x00000001872182D0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978310 */, float damageKb = 1f /* Metadata: 0x01978311 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x01978315 */, bool hasKb = true /* Metadata: 0x01978316 */) {} // 0x00000001872188F0-0x0000000187218A70
		protected override void OnUpdate() {} // 0x0000000187218A70-0x0000000187218EA0
	}
}
