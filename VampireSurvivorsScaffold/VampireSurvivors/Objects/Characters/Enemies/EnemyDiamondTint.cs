/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDiamondTint : EnemyDiamond // TypeDefIndex: 17294
	{
		// Fields
		private static WeightedStore WEIGHTEDSTORE; // 0x00
		protected Vector2 _initialVelocity; // 0x2A8
		private float _grav; // 0x2B0
	
		// Properties
		protected override bool UseStandardLootTable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override float InvulDelay { get => default; } // 0x0000000186D7E010-0x0000000186D7E020 
		protected override float ItemChance { get => default; } // 0x00000001872415B0-0x00000001872415C0 
		protected override float Volume_breaking { get => default; } // 0x00000001872437B0-0x00000001872437C0 
		protected override float Volume_gotHit { get => default; } // 0x00000001872437C0-0x00000001872437D0 
		protected override SfxType Sfx_breaking { get => default; } // 0x0000000181B99450-0x0000000181B99460 
		protected override SfxType Sfx_gotHit { get => default; } // 0x0000000181BE95A0-0x0000000181BE95B0 
		protected override bool ChangeFramesOnHit { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool DoBaseUpdate { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool IsImmovable { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual bool IsAxe { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool IsSnake { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual uint[] TintProgression { get => default; } // 0x00000001872437D0-0x0000000187243840 
	
		// Constructors
		public EnemyDiamondTint() {} // 0x00000001872447F0-0x0000000187244810
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187243840-0x0000000187243BC0
		public override void OnSpawnDone() {} // 0x0000000187243BC0-0x0000000187243C20
		protected override void ChangeFrame() {} // 0x0000000187243C20-0x0000000187243F10
		protected override void OnUpdate() {} // 0x0000000187243F10-0x00000001872440A0
		protected override void CustomLoot() {} // 0x00000001872440A0-0x00000001872443D0
		private void AxeUpdate() {} // 0x00000001872443D0-0x0000000187244500
		private void SnakeUpdate() {} // 0x0000000187244500-0x00000001872447F0
	}
}
