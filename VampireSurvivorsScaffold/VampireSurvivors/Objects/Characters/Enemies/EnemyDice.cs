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
	public class EnemyDice : EnemyDiamond // TypeDefIndex: 17301
	{
		// Fields
		private static WeightedStore WEIGHTEDSTORE; // 0x00
		protected Vector2 _initialVelocity; // 0x2A8
		private float _grav; // 0x2B0
	
		// Properties
		protected override bool UseStandardLootTable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override float InvulDelay { get => default; } // 0x0000000186D7E010-0x0000000186D7E020 
		protected override float ItemChance { get => default; } // 0x0000000187249440-0x0000000187249450 
		protected override float Volume_breaking { get => default; } // 0x00000001872437B0-0x00000001872437C0 
		protected override float Volume_gotHit { get => default; } // 0x00000001872437C0-0x00000001872437D0 
		protected override SfxType Sfx_breaking { get => default; } // 0x0000000181B99450-0x0000000181B99460 
		protected override SfxType Sfx_gotHit { get => default; } // 0x0000000181BE95A0-0x0000000181BE95B0 
		protected override bool ChangeFramesOnHit { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool DoBaseUpdate { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool IsImmovable { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual bool IsAxe { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool IsSnake { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual uint[] TintProgression { get => default; } // 0x0000000187249450-0x00000001872494C0 
		protected override string _textureName { get => default; } // 0x00000001872494C0-0x0000000187249500 
		protected override string DefaultFrame { get => default; } // 0x0000000187249500-0x0000000187249540 
		protected override string[] AvailableFrames { get => default; } // 0x0000000187249540-0x0000000187249690 
	
		// Constructors
		public EnemyDice() {} // 0x00000001872447F0-0x0000000187244810
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote = false /* Metadata: 0x0197840C */) {} // 0x0000000187249690-0x0000000187249B00
		public override void OnSpawnDone() {} // 0x0000000187243BC0-0x0000000187243C20
		protected virtual void OnHit_ChangeSprite() {} // 0x0000000187249B00-0x0000000187249E40
		protected virtual void OnHit_ChangeTint() {} // 0x0000000187249E40-0x000000018724A130
		protected override void ChangeFrame() {} // 0x000000018724A130-0x000000018724A150
		protected override void OnUpdate() {} // 0x000000018724A150-0x000000018724A2E0
		protected override void CustomLoot() {} // 0x000000018724A2E0-0x000000018724A610
		private void AxeUpdate() {} // 0x000000018724A610-0x000000018724A740
		private void SnakeUpdate() {} // 0x0000000187244500-0x00000001872447F0
	}
}
