/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySnowman : EnemyDiamond // TypeDefIndex: 17394
	{
		// Fields
		private static WeightedStore WEIGHTEDSTORE; // 0x00
		private readonly string _defaultFrame_Default; // 0x2A8
		private readonly string[] _availableFrames_Default; // 0x2B0
		private readonly string _defaultFrame_XL; // 0x2B8
		private readonly string[] _availableFrames_XL; // 0x2C0
	
		// Properties
		protected override bool UseStandardLootTable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override float InvulDelay { get => default; } // 0x0000000186F8EB60-0x0000000186F8EB70 
		protected override float ItemChance { get => default; } // 0x0000000185C62C30-0x0000000185C62C40 
		protected override float Volume_breaking { get => default; } // 0x000000018729EA30-0x000000018729EA40 
		protected override float Volume_gotHit { get => default; } // 0x000000018729EA40-0x000000018729EA50 
		protected override SfxType Sfx_breaking { get => default; } // 0x0000000181C11FE0-0x0000000181C11FF0 
		protected override SfxType Sfx_gotHit { get => default; } // 0x0000000181C135A0-0x0000000181C135B0 
	
		// Constructors
		public EnemySnowman() {} // 0x000000018729F310-0x000000018729F650
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018729EA50-0x000000018729EDA0
		public override void OnSpawnDone() {} // 0x000000018729EDA0-0x000000018729EFE0
		protected override void OnUpdate() {} // 0x000000018726D290-0x000000018726D2C0
		protected override void CustomLoot() {} // 0x000000018729EFE0-0x000000018729F310
	}
}
